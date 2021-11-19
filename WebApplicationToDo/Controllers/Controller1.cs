using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplicationToDo.Models;

namespace WebApplicationToDo.Controllers
{
    public class TestController : ApiController
    {
        public static List<Model1> lTodo = new List<Model1>();

        [HttpGet]
        public List<Model1> Get()
        {

            return lTodo;
        }

        [HttpGet]
        public Model1 Get(int id)
        {
            Model1 Todo = lTodo.Find(i => i.id == id);
            return Todo;
        }
    }
}
