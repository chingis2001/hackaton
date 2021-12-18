using System;
using System.Collections.Generic;
using System.Linq;
using hackaton.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System.Security.Claims;
using Microsoft.AspNetCore.Http;
using System.IO;
using Newtonsoft.Json;
using System.Net;

namespace hackaton.Controllers
{
    public class AuthController : Controller
    {
        private readonly hackatonContext _context;
        private readonly byte[] _tokensalt;
        private readonly byte[] _passwordsalt;
        private static readonly string key = "89a59cd5a6b8f54f8e2f7308368a85db1c1cc23b";
        public AuthController(hackatonContext context) 
        {
            _context = context;
            _tokensalt = Convert.FromBase64String("h/QUm2iYZ8lIttbVGCTnYA==");
        }
        public IActionResult Auth()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(string? username, string? password, bool rememberme) 
        {
            string resultname = username + password;
            var пользователь = _context.user.FirstOrDefault(t => t.username == username);
            if (пользователь != null)
            {
                var salt = Convert.FromBase64String(пользователь._salt);
                var passwdhash = KeyDerivation.Pbkdf2(
                    password: password,
                    salt: salt,
                    prf: KeyDerivationPrf.HMACSHA1,
                    iterationCount: 10000,
                    numBytesRequested: 256 / 8);
                string stringpasswdhashed = Convert.ToBase64String(passwdhash);
                if (пользователь.password != stringpasswdhashed)
                {
                    ViewBag.Error = "Wrong password!";
                    return View();
                }
                Guid IdUser = пользователь.user_id;
                string UserName = пользователь.username;
                await Authenticate(IdUser.ToString(), UserName);
                if (rememberme)
                {
                    var gh = HttpContext.User.Identity.Name;
                    var hashed = KeyDerivation.Pbkdf2(
                        password: HttpContext.Connection.RemoteIpAddress + HttpContext.Request.Headers["User-Agent"],
                        salt: _tokensalt,
                        prf: KeyDerivationPrf.HMACSHA1,
                        iterationCount: 10000,
                        numBytesRequested: 256 / 8);
                    string stringhashed = Convert.ToBase64String(hashed);
                    пользователь._token = stringhashed;
                    _context.user.Update(пользователь);
                    _context.SaveChanges();
                }
            }
            else 
            {
                ViewBag.Error = "Wrong login";
                return View();
            }
            return RedirectToAction("/Home/Index");
        }
        struct INN_resp 
        {
            public INN_item[] items;
        }
        struct INN_item 
        {
            public INN_IP ИП { get; set; }
        }
        struct INN_IP 
        {
            public string ФИОПолн { get; set; }
            public string ИННФЛ { get; set; }
            public string ОГРНИП { get; set; }
            public string ДатаОГРН { get; set; }
            public string ДатаРег { get; set; }
            public string ВидИП { get; set; }
            public string Пол { get; set; }
            public string ВидГражд { get; set; }
            public string Статус { get; set; }
            public INN_NO НО { get; set; }
            public INN_PF ПФ { get; set; }
            public INN_Address Адрес { get; set; }
            public INN_Osn ОснВидДеят { get; set; }
            public INN_Osn[] ДопВидДеят { get; set; }
            public INN_SPVZ[] СПВЗ { get; set; }
            public object? История { get; set; }
        }
        struct INN_NO 
        {
            public string Рег { get; set; }
            public string РегДата { get; set; }
            public string Учет { get; set; }
            public string УчетДата { get; set; }
        }
        struct INN_PF 
        {
            public string РегНомПФ { get; set; }
            public string ДатаРегПФ { get; set; }
            public string КодПФ { get; set; }
        }
        struct INN_Address 
        {
            public string КодРегион { get; set; }
            public string АдресПолн { get; set; }
            public string Дата { get; set; }
        }
        struct INN_Osn 
        {
            public string Код { get; set; }
            public string Текст { get; set; }
            public string Дата { get; set; }
        }
        struct INN_SPVZ 
        {
            public string Дата { get; set; }
            public string Текст { get; set; }
        }
        private bool CheckINN(string INN, ref bool check, string fi) 
        {
            string url = "https://api-fns.ru/api/egr?";
            url += "req=" + INN;
            url += "&key=" + key;
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/x-www-form-urlencoded";
            WebResponse response = request.GetResponse();
            using (Stream stream = response.GetResponseStream()) 
            {
                using (StreamReader reader = new StreamReader(stream)) 
                {
                    string line = reader.ReadLine();
                    if (line.Length== 12)
                    {
                        check = false;
                        response.Close();
                        return true;
                    }
                    else 
                    {
                        var some = JsonConvert.DeserializeObject<INN_resp>(line);
                        var fio_resp = some.items[0].ИП.ФИОПолн.Split(' ')[0] + some.items[0].ИП.ФИОПолн.Split(' ')[1];
                        bool is_same = fio_resp == fi;
                        if (!is_same) 
                        {
                            check = false;
                            response.Close();
                            return true;
                        }
                    }
                }
            }
            response.Close();
            check = true;
            return true;
        }
        [HttpPost]
        public IActionResult Register(user user, string? INN, string options) 
        {
            var salt = GetSalt();
            if (options == "ispolnitel") 
            {
                bool check = false;
                CheckINN(INN, ref check, user.secondname + user.firstname);
                if (!check) 
                {
                    ModelState.AddModelError("", "ИНН не подходит введите другой");
                    return RedirectToAction("/Home/Index");
                }
            }
            var hashed_password = KeyDerivation.Pbkdf2(
                password: user.password,
                salt: salt,
                prf: KeyDerivationPrf.HMACSHA1,
                iterationCount: 10000,
                numBytesRequested: 256 / 8);
            string stringPasswordHashed = Convert.ToBase64String(hashed_password);
            user.password = stringPasswordHashed;
            user._salt = Convert.ToBase64String(salt);
            if (options == "ispolnitel")
                user.status_id = 3;
            else
                user.status_id = 1;
            _context.Add(user);
            if (!ModelState.IsValid) 
            {
                return RedirectToAction("/Home/Index");
            }
            user other_user = _context.user.SingleOrDefault(t => t.username == user.username);
            if (other_user == null) 
            {
                _context.SaveChanges();
            }
            return RedirectToAction("Index", "Home");
        }
        private async Task Authenticate(string userName, string rolename)
        {
            // создаем один claim
            if (rolename != "admin")
                rolename = "user";
            var claims = new List<Claim>
            {
                new Claim(ClaimsIdentity.DefaultNameClaimType, userName),
                new Claim(ClaimsIdentity.DefaultRoleClaimType, rolename)
            };
            // создаем объект ClaimsIdentity
            ClaimsIdentity id = new ClaimsIdentity(claims, "ApplicationCookie", ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);
            // установка аутентификационных куки
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(id));
        }
        public byte[] GetSalt()
        {
            byte[] salt = new byte[128 / 8];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(salt);
            }
            return salt;
        }
    }
}
