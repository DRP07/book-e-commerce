using BookStoreNew.Models.Models;
using BookStoreNew.Models.ViewModels;
using BookStoreNew.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Net;
namespace BookStoreNew.Api.Controllers
{
    [Route("api/public")]
    [ApiController]
    public class BookStoreController : ControllerBase
    {
        UserRepository _repository = new UserRepository();

        [HttpPost]
        [Route("login")]
        public IActionResult Login(LoginModel model)
        {
            User user = _repository.Login(model);
            if (user == null)
                return NotFound();

            UserModel userModel = new UserModel(user);
            return Ok(userModel);
        }

        [HttpPost]
        [Route("register")]
        public IActionResult Register(RegisterModel model)
        {
            User user = _repository.Register(model);
            UserModel userModel = new UserModel(user);
            return Ok(userModel);
        }
    }

}
