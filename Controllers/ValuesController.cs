﻿using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace openshserv.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "first and vv 1 1", "second", "value asdmoresobie", "value4", "some new val", "hahahahah", "mod_sth" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "hmm_bef more value one ch_1 plus some change hmm merg ok_br";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
            if (id == -2 || id > 3)
                return;
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            //no deletion
        }
    }
}
