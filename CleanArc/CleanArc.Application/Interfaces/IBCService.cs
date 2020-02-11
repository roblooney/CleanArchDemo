using CleanArc.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArc.Application.Interfaces
{
    public interface IBCService
    {
        IEnumerable<BodyCorporateViewModel> GetBodyCorporates();
    }
}
