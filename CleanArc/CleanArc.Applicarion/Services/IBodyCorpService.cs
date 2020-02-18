using CleanArc.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArc.Application.Services
{
    public interface IBodyCorpService
    {
        IEnumerable<BodyCorpViewModel> GetBodyCorpViewModel();
    }
}
