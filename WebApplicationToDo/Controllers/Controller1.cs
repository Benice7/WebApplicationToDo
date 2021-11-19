using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplicationToDo.Models;

namespace WebApplicationToDo.Controllers
{
    [Route("todos")]
    public class TestController : ApiController
    {
        public static List<Model1> lTodo = new List<Model1>()
        {
            new Model1{id = 0, name = "Do some work", completed = false}
        };

        [HttpGet]
        public List<Model1> Get()
        {
            return lTodo;
        }

        [HttpPost]
        public List<Model1> Post([FromBody] Model1 model)
        {
            lTodo.Add(model);
            return lTodo;
        }

        [HttpPut]
        [Route("{id}")]
        public List<Model1> Put(int id, [FromBody] Model1 model)//update todo
        {
            Model1 TodoUpdate = lTodo.Find(i => i.id == id);
            int index = lTodo.IndexOf(TodoUpdate);
            lTodo[index].completed = true;
            lTodo[index].name = "Done some work";

            return lTodo;
        }

        [HttpDelete]
        [Route("{id}")]
        public List<Model1> Delete(int id)//delete todo
        {
            Model1 Tododel = lTodo.Find(i => i.id == id);
            lTodo.Remove(Tododel);

            return lTodo;
        }
    }
}
