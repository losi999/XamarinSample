using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using XamarinSample.API.Core;
using XamarinSample.API.Core.Model.DTO;
using XamarinSample.API.Core.Model.Entities;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace XamarinSample.API.Controllers {
    [Route("api/[controller]")]
    public class MobileController : ControllerBase {
        public MobileController(IUnitOfWork unitOfWork) : base(unitOfWork) {

        }




        // GET: api/mobile
        [HttpGet]
        public string Get() {
            return "mobilecontroller";
        }

        // POST: api/mobile/signup
        [HttpPost]
        [Route(nameof(SignUp))]
        public IActionResult SignUp(string username, string password) {
            var check = _unitOfWork.User.Get(username);
            if (check == null) {
                var user = new User(username, password);
                _unitOfWork.User.Insert(user);
                if (_unitOfWork.Complete()) {
                    return Ok();
                }
                return BadRequest();
            }
            return BadRequest();
        }

        // POST: api/mobile/login
        [HttpPost]
        [Route(nameof(LogIn))]
        public IActionResult LogIn(string username, string password) {
            var user = _unitOfWork.User.Get(username);
            if (user == null) {
                return BadRequest("Incorrect username");
            }
            if (user.Password == password) {
                return Ok();
            }
            return BadRequest("Incorrect password");
        }

    }
}
