using System;
using System.Collections.Generic;

namespace Backend.Contracts
{
    public interface IKundenFacade
    {
        void Save(Kunde kunde);

        IEnumerable<Kunde> GetKunden();

        Kunde GetKunde(Guid guid);
    }
}
