using Microsoft.AspNetCore.Mvc;
using plu.Domain.IServices;
using plu.Domain.Models;
using plu.Models;
using plu.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace plu.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private readonly IUserService _userService;
        private readonly ILoginService _loginService;

        public UserController(IUserService userService, ILoginService loginService)
        {
            _userService = userService;
            _loginService = loginService;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] User user)
        {
            try
            {
                var validateUserName = await _userService.ValidateExistence(user);
                if (validateUserName)
                {
                    return BadRequest(new { message = "Nombre de usuario ya existente" });
                }
                user.password = Encrypt.EncryptPassword(user.password);
                await _userService.SaveUser(user); //pasa manos 
                return Ok(new { message = "Usuario registrado correctamente" });
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public async Task<IActionResult> PostLog([FromBody] LogUser user)
        {
            try
            {
                user.password = Encrypt.EncryptPassword(user.password);
                var usera = await _loginService.ValidateUser(user);
                
                return Ok(new { message = "Usuario encontrado correctamente" });
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }



    }
}
