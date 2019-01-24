using System.Collections.Generic;
using WEB_API.Models;

namespace WEB_API.Services
{
    public interface ICandidateServices
    {
        Candidates AddCandidate(Candidates candidate);
        Dictionary<string, Candidates> GetCandidates();
        Candidates GetCandidate(int id);
        void UpdateCandidate(Candidates candidate);
        void DeleteCandidate(int id);
    }
}