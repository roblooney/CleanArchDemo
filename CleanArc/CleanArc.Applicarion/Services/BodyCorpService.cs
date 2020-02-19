using CleanArc.Application.Interfaces;
using CleanArc.Application.ViewModels;
using CleanArc.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArc.Application.Services
{
    public class BodyCorpService : IBodyCorpService
    {
        private IBodyCorpRepository _bodyCorpRepository;

        public BodyCorpService(IBodyCorpRepository bodyCorpRepository) 
        {
            _bodyCorpRepository = bodyCorpRepository;
        }

        public BodyCorpViewModel GetBodyCorpList()
        {
            return new BodyCorpViewModel() 
            { 
                BodyCorporates = _bodyCorpRepository.GetBodyCorporates()            
            };
        }

    }
}
