using INDATAProject.Models;
using INDATAProject.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace INDATAProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet]
        public ActionResult GetUsers()
        {
            var users = _userRepository.GetUsers();
            return Ok(users);
        }

        [HttpPost("add")]
        public ActionResult Add([FromBody] User user)
        {
            _userRepository.Add(user);
            _userRepository.SaveAll();
            return Ok();
        }

        [HttpDelete("delete")]
        public ActionResult Delete([FromBody] User user)
        {
            try
            {
                _userRepository.Delete(user);
                _userRepository.SaveAll();

                return Ok();
            }
            catch(Exception e) {
                return BadRequest(e.Message);
            }

        }

        [HttpPost("update")]
        public ActionResult Update([FromBody] User user)
        {
            try
            {
                _userRepository.Update(user);
                _userRepository.SaveAll();

                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
