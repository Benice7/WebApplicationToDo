using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplicationToDo.Models;

namespace WebApplicationToDo.Controllers
{
    [Route("/todos")]
    public class TestController : ApiController
    {
        public static List<Model1> lTodo = new List<Model1>()
        {
            new Model1{id = 0, name = "Do some Work", completed = false}
        };

        [HttpGet]
        public List<Model1> Get()
        {

            return lTodo;
        }

        [HttpPut]
        [Route("{id}")]
        public Model1 Put(int id)//update todo
        {
            Model1 Todo = lTodo.Find(i => i.id == id);
            Todo.completed = true;
            return Todo;
        }
    }
}
