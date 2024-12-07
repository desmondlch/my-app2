using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using my_app2.Models;

namespace my_app2.Controllers
{
    [Route("api/User")]
    public class UserController : Controller
    {
        static readonly List<UserModel> _users = new List<UserModel>
        {
            new UserModel { Name="admin", Login="admin", Password="admin" }
        };

        [HttpPost]
        public IActionResult Auth([FromBody] UserModel model)
        {
            return Json(
                _users.FirstOrDefault(
                    u =>
                        u.Login.Equals(model.Login) &&
                        u.Password.Equals(model.Password)));
        }
    }
}