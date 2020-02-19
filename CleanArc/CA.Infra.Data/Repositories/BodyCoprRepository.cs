using CleanArc.Domain.Interfaces;
using CleanArc.Domain.Models;
using CleanArc.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArc.Infra.Data.Repositories
{
    public class BodyCoprRepository : IBodyCorpRepository
    {
        private BodyCorporateDbContext _bcCtx;

        public BodyCoprRepository(BodyCorporateDbContext bcCtx) 
        {
            _bcCtx = bcCtx;
        }

        public IEnumerable<BodyCorporate> GetBodyCorporates()
        {
            return _bcCtx.BodyCorporates;
        }
    }
}
