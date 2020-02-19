using CleanArc.Domain.Interfaces;
using CleanArc.Domain.Models;
using CleanArc.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArc.Infra.Data.Repositories
{
    class UnitRepository : IUnitRepository
    {
        private BodyCorporateDbContext _bcCtx;

        public UnitRepository(BodyCorporateDbContext bcCtx) 
        {
            _bcCtx = bcCtx;
        }

        public IEnumerable<Unit> GetUnits()
        {
            return _bcCtx.Units;
        }
    }
}
