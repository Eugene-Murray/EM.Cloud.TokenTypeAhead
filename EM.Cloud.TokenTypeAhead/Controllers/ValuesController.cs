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
            list.Add(new Item { id = 10, name = "REM" });
            list.Add(new Item { id = 10, name = "REM" });
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
            list.Add(new Item { id = 10, name = "Eugene Murray" });
            list.Add(new Item { id = 10, name = "Eoghan O Muri" });
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

            list.Add(new Item { id = 10, name = "Mr z" });
            list.Add(new Item { id = 10, name = "Yonger" });
            list.Add(new Item { id = 1, name = "Webhead" });
            list.Add(new Item { id = 2, name = "www" });
            list.Add(new Item { id = 3, name = "www2 " });
            list.Add(new Item { id = 4, name = "WWWW3 " });
            list.Add(new Item { id = 5, name = "doo" });
            list.Add(new Item { id = 6, name = "XML" });
            list.Add(new Item { id = 7, name = "XXX" });
            list.Add(new Item { id = 8, name = "PPPP" });
            list.Add(new Item { id = 9, name = "TvvXXXX" });
            list.Add(new Item { id = 10, name = "uuuu" });

            list.Add(new Item { id = 10, name = "Kbbb" });
            list.Add(new Item { id = 10, name = "Lmp" });
            list.Add(new Item { id = 1, name = "Box" });
            list.Add(new Item { id = 2, name = "Fox" });
            list.Add(new Item { id = 3, name = "Wolf" });
            list.Add(new Item { id = 4, name = "Miss Lumpy" });
            list.Add(new Item { id = 5, name = "Mr Grumpy" });
            list.Add(new Item { id = 6, name = "Mr Devil" });
            list.Add(new Item { id = 7, name = "St Patrick" });
            list.Add(new Item { id = 8, name = "Jesus" });
            list.Add(new Item { id = 9, name = "Mary" });
            list.Add(new Item { id = 10, name = "God" });

            return list.Where(i => i.name.Contains(term)).Take(take).ToList();
        }

     
    }

    public class Item
    {
        public int id {get;set;}
        public string name {get;set;}
    }
}
