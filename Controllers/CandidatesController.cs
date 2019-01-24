using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WEB_API.Models;
using WEB_API.Services;

namespace WEB_API.Controllers
{

    [Route("api/candidates/")]
    [ApiController]
    public class CandidatesController : ControllerBase
    {

        private readonly ICandidateServices _services;

        public CandidatesController(ICandidateServices services)
        {
            _services = services;
        }


        [HttpPost]
        [Route("Add")]
        public ActionResult<Candidates> AddCandidate(Candidates candidate){

            var candidates = _services.AddCandidate(candidate);
            
            if(candidates == null){
                return NotFound();
            }
            return candidates;
        }


        [HttpGet]
        [Route("GetAll")]
        public ActionResult<Dictionary<string,Candidates>> GetCandidates(){
            
            var candidates = _services.GetCandidates();

            if(candidates.Count ==0){
                return NotFound();
            }

            return candidates;
        }


        [HttpGet]
        [Route("Get/{id}")]
        public ActionResult<Candidates> GetCandidates(int id){
            
            var candidate = _services.GetCandidate(id);

            if(candidate == null){
                return NotFound();
            }

            return candidate;
        }

        [HttpPut]
        [Route("Update")]
        public ActionResult<string> Update(Candidates candidate){
            
            _services.UpdateCandidate(candidate);
            return "Candidate Updated!";
             
        }

        [HttpDelete]
        [Route("Delete/{id}")]
        public ActionResult<string> Delete(int id){
            
            _services.DeleteCandidate(id);
            return "Candidate Deleted!";
             
        }
    }
}