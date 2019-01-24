using System.Collections.Generic;
using WEB_API.Models;

namespace WEB_API.Services
{
    public class CandidateServices : ICandidateServices
    {

        private readonly Dictionary<string,Candidates> _candidates;
        public CandidateServices()
        {
            _candidates = new Dictionary<string, Candidates>();
        }



        public Candidates AddCandidate(Candidates candidate){

            _candidates.Add(candidate.Id.ToString(), candidate);

            return candidate;
        }

        public Dictionary<string, Candidates> GetCandidates()
        {
            return _candidates;
        }

        public Candidates GetCandidate(int id)
        {

            Candidates cand = null;
            _candidates.TryGetValue(id.ToString(), out cand);
            
            return cand;
            
        }

        public void UpdateCandidate(Candidates candidate){
             
             if(_candidates.ContainsKey(candidate.Id.ToString())){
                
                _candidates.Remove(candidate.Id.ToString());
                _candidates.Add(candidate.Id.ToString(), candidate);

             }
        }

        public void DeleteCandidate(int id)
        {
            if(_candidates.ContainsKey(id.ToString())){
                
                _candidates.Remove(id.ToString());

             }
        }
    }
}