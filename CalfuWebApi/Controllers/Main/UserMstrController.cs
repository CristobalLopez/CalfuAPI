using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CalfuDTO.Main;
using CalfuRepository.Main;

namespace CalfuWebApi.Controllers.Main
{
    public class UserMstrController : ApiController
    {
        USER_MSTR_Repository _userMstrRepository;

        [HttpGet]
        [Route("api/GetUser/")]
        public USER_MSTR_DTO GetUser(int id)
        {

            _userMstrRepository = new USER_MSTR_Repository();
            return _userMstrRepository.GetUserMstrRepository(id);
        }

        [HttpGet]
        [Route("api/Login/")]
        public bool LoginUser(string nick, string pass)
        {
            bool retorno = false;
            _userMstrRepository = new USER_MSTR_Repository();

            retorno = _userMstrRepository.LoginByName(nick, pass);

            return retorno;
        }

        [HttpPost]
        [Route("api/AddUser/")]
        public IHttpActionResult AddUser(USER_MSTR_DTO userDto)
        {
            string retorno = "";
            _userMstrRepository = new USER_MSTR_Repository();

            retorno = _userMstrRepository.CreateUserMstr(userDto) ? "Exito" : "Error";

            return Ok(retorno);
        }

        [HttpGet]
        [Route("api/SelectUser/")]
        public List<USER_MSTR_DTO> SelectUser()
        {
            _userMstrRepository = new USER_MSTR_Repository();
            return _userMstrRepository.SelectUserMstrRepository();
        }

        [HttpPut]
        [Route("api/UpdateUser/")]
        public IHttpActionResult UpdateUser(USER_MSTR_DTO userDto)
        {
            string retorno = "";
            _userMstrRepository = new USER_MSTR_Repository();

            retorno = _userMstrRepository.UpdateUserMstr(userDto) ? "Exito" : "Error";

            return Ok(retorno);
        }

        [HttpDelete]
        [Route("api/DeleteUser/")]
        public IHttpActionResult DeleteUser(int id)
        {
            string retorno = "";
            _userMstrRepository = new USER_MSTR_Repository();

            retorno = _userMstrRepository.DeleteUserMstrRepository(id) ? "Exito" : "Error";

            return Ok(retorno);
        }
    }
}
