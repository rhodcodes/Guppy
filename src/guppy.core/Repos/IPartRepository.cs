using guppy.core.Models;
using System.Collections.Generic;

namespace guppy.core.Repos
{
    internal interface IPartRepository
    {
        void AddPart(IPart part);

        void AddParts(IEnumerable<IPart> parts);

        public IEnumerable<IPart> GetAllParts();

        public IPart GetPartByID(string id);

        public PhantomPart GetPhantomPartByID(string id);

        public IEnumerable<PhantomPart> GetPhantomParts();

        public StockedPart GetStockedPartByID(string id);

        public IEnumerable<StockedPart> GetStockedParts();
    }
}