﻿using CleanArc.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArc.Domain.Interfaces
{
    public interface IBodyCorpRepository
    {
        IEnumerable<BodyCorporate> GetBodyCorporates();
    }
}
