using SimpleWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SimpleWebApp.Controllers
{
    public class ValueController : ApiController
    {
        private static List<string> _list = new List<string>() { "Demo", "Content" };

        // GET: api/Value
        public IEnumerable<string> Get()
        {
            return _list;
        }

        // GET: api/Value/5
        public string Get(int id)
        {
            return _list.Count > id ? _list[id] : null;
        }

        // POST: api/Value
        public void Post([FromBody]ValueModel value)
        {
            _list.Add(value.Text);
        }

        // PUT: api/Value/5
        public void Put(int id, [FromBody]ValueModel value)
        {
            if (id < _list.Count)
                _list[id] = value.Text;
        }

        // DELETE: api/Value/5
        public void Delete(int id)
        {
            if (id < _list.Count)
                _list.RemoveAt(id);
        }
    }
}
