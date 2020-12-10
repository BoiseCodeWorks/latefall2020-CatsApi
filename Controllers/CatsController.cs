using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using LateFall2020CatsApi.Models;
using LateFall2020CatsApi.Services;

namespace LateFall2020CatsApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CatsController : ControllerBase
    {
        private readonly CatService _cs;

        public CatsController(CatService cs)
        {
            _cs = cs;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Cat>> Get()
        {
            try
            {
                return Ok(_cs.GetCats());
            }
            catch (System.Exception err)
            {
                return BadRequest(err.Message);
            }
        }

        [HttpGet("{index}")]
        public ActionResult<Cat> GetOne(int index)
        {
            try
            {
                return Ok(_cs.GetCat(index));
            }
            catch (System.Exception err)
            {
                return BadRequest(err.Message);
            }
        }

        [HttpPost]
        public ActionResult<Cat> Create([FromBody] Cat newCat)
        {
            try
            {
                return Ok(_cs.Create(newCat));
            }
            catch (Exception err)
            {
                return BadRequest(err.Message);
            }
        }

        [HttpDelete("{index}")]
        public ActionResult<String> Delete(int index)
        {
            try
            {
                return Ok(_cs.Delort(index));
            }
            catch (Exception err)
            {
                return BadRequest(err.Message);
            }
        }
    }
}