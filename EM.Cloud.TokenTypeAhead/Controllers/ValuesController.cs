using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EM.Cloud.TokenTypeAhead.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public List<Item> Get(string term)
        {
            var list = new List<Item>();
            list.Add(new Item { id = 1, name = "Bob Dylan" });
            list.Add(new Item { id = 2, name = "ABBEY" });
            list.Add(new Item { id = 3, name = "ABEGAIL " });
            list.Add(new Item { id = 4, name = "ADRIANNA " });
            list.Add(new Item { id = 5, name = "KADRI" });
            list.Add(new Item { id = 6, name = "U2" });
            list.Add(new Item { id = 7, name = "The Doors" });
            list.Add(new Item { id = 8, name = "Stone Roses" });
            list.Add(new Item { id = 9, name = "The Pouges" });
            list.Add(new Item { id = 10, name = "REM" });

            return list;
        }

        public List<Item> Get(string term, int skip, int take)
        {
            var list = new List<Item>();
            list.Add(new Item { id = 1, name = "Bob Dylan" });
            list.Add(new Item { id = 2, name = "ABBEY" });
            list.Add(new Item { id = 3, name = "ABEGAIL " });
            list.Add(new Item { id = 4, name = "ADRIANNA " });
            list.Add(new Item { id = 5, name = "KADRI" });
            list.Add(new Item { id = 6, name = "U2" });
            list.Add(new Item { id = 7, name = "The Doors" });
            list.Add(new Item { id = 8, name = "Stone Roses" });
            list.Add(new Item { id = 9, name = "The Pouges" });
            list.Add(new Item { id = 10, name = "REM" });

            return list;
        }

     
    }

    public class Item
    {
        public int id {get;set;}
        public string name {get;set;}
    }
}
