using ScoreManagement.Models;
using ScoreManagementApp.DAL.Interrfaces;
using ScoreManagementApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace ScoreManagementApp.Controllers
{
    public class ScoreController : ApiController
    {
        private readonly IScoreService _service;
        public ScoreController(IScoreService service)
        {
            _service = service;
        }
        public ScoreController()
        {
            // Constructor logic, if needed
        }
        [HttpPost]
        [Route("api/Score/CreateScore")]
        [AllowAnonymous]
        public async Task<IHttpActionResult> CreateScore([FromBody] Score model)
        {
            //write your code here
            throw new NotImplementedException();
        }


        [HttpPut]
        [Route("api/Score/UpdateScore")]
        public async Task<IHttpActionResult> UpdateScore([FromBody] Score model)
        {
            //write your code here
            throw new NotImplementedException();
        }


        [HttpDelete]
        [Route("api/Score/DeleteScore")]
        public async Task<IHttpActionResult> DeleteScore(long id)
        {
            //write your code here
            throw new NotImplementedException();
        }


        [HttpGet]
        [Route("api/Score/GetScoreById")]
        public async Task<IHttpActionResult> GetScoreById(long id)
        {
            //write your code here
            throw new NotImplementedException();
        }


        [HttpGet]
        [Route("api/Score/GetAllScores")]
        public async Task<IEnumerable<Score>> GetAllScores()
        {
            //write your code here
            throw new NotImplementedException();
        }
    }
}
