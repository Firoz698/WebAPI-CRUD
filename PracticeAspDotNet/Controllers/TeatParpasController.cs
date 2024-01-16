using Microsoft.AspNetCore.Mvc;
using PracticeAspDotNet.Database;
using PracticeAspDotNet.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PracticeAspDotNet.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TeatParpasController : ControllerBase
    {
        DataBContext _db;
        public TeatParpasController(DataBContext db) {
            _db = db;
        }



        // GET: api/<TeatParpasController>
        [HttpGet]
        public List<User> GetUserMethod()
        {
           List<User> user = new List<User>();
            user = _db.UserInfo.ToList();
            return user;
        }

    

        // POST api/<TeatParpasController>
        [HttpPost]
        public User PostUserMethod(User user)
        {
            _db.UserInfo.Add(user);
            _db.SaveChanges();
            return user;
        }

        // PUT api/<TeatParpasController>/5
        [HttpPut]
        public User UpdateMethod(User user)
        {
            User IdStore = _db.UserInfo.Find(user.Id);
            if (IdStore != null)
            {
                _db.UserInfo.Update(user);
                _db.SaveChanges();
                user.Name = "Successfully Updated";
            }
            else
            {
                user.Name = "Data Not Found";
            }
            return user;
        }

        // DELETE api/<TeatParpasController>/5
        [HttpDelete]
        public User DeleteUser(int id)
        {
            User user = _db.UserInfo.Find(id);
            _db.UserInfo.Remove(user);
            _db.SaveChanges();
            return user;
        }
    }
}
