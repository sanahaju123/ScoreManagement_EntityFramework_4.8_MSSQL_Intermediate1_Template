using ScoreManagementApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace ScoreManagementApp.DAL.Services.Repository
{
    public class ScoreRepository : IScoreRepository
    {
        private readonly DatabaseContext _dbContext;
        public ScoreRepository(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }


        public async Task<Score> CreateScore(Score expense)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public async Task<bool> DeleteScoreById(long id)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public List<Score> GetAllScores()
        {
            //write your code here
            throw new NotImplementedException();
        }

        public async Task<Score> GetScoreById(long id)
        {
            //write your code here
            throw new NotImplementedException();
        }     
        

        public async Task<Score> UpdateScore(Score model)
        {
            //write your code here
            throw new NotImplementedException();
        }
    }
}