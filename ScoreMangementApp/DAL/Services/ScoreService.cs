using ScoreManagementApp.DAL.Interrfaces;
using ScoreManagementApp.DAL.Services.Repository;
using ScoreManagementApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace ScoreManagementApp.DAL.Services
{
    public class ScoreService : IScoreService
    {
        private readonly IScoreRepository _repository;

        public ScoreService(IScoreRepository repository)
        {
            _repository = repository;
        }

        public Task<Score> CreateScore(Score expense)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public Task<bool> DeleteScoreById(long id)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public List<Score> GetAllScores()
        {
            //write your code here
            throw new NotImplementedException();
        }

        public Task<Score> GetScoreById(long id)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public Task<Score> UpdateScore(Score model)
        {
            //write your code here
            throw new NotImplementedException();
        }
    }
}