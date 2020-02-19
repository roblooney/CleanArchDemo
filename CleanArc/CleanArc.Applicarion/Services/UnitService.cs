using CleanArc.Application.Interfaces;
using CleanArc.Application.ViewModels;
using CleanArc.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArc.Application.Services
{
    public class UnitService : IUnitService
    {
        private IUnitRepository _unitRepository;

        public UnitService(IUnitRepository UnitRepository) 
        {
            _unitRepository = UnitRepository;
        }

        public UnitViewModel GetUnitList()
        {
            return new UnitViewModel()
            {
                Units = _unitRepository.GetUnits()
            };
        }
    }
}
