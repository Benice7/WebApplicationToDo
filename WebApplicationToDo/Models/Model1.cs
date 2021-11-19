using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationToDo.Models
{
    public class Model1
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool completed { get; set; }
        public string url { get; set; }

        public Model1()
        {
        }

        public Model1(int id, string name, bool completed)
        {
            this.id = id;
            this.name = name;
            this.completed = completed;
        }

    }
}