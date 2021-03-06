﻿

using System;
using System.Collections.Generic;

namespace Backend.Contracts
{
    public interface IAngebotFacade
    {
        void Save(Angebot angebot);

        IEnumerable<Angebot> GetAngebote();

        void CreateBill(Angebot angebot);
    }
}
