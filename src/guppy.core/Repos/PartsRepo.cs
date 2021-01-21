using guppy.core.Models;
using System.Collections.Generic;
using System.Linq;

namespace guppy.core.Repos
{
    internal class PartsRepo : IPartRepository
    {
        private readonly List<IPart> _parts;

        public void AddPart(IPart part) => _parts.Add(part);

        public void AddParts(IEnumerable<IPart> parts) => _parts.AddRange(parts);

        public IEnumerable<IPart> GetAllParts() => _parts;

        public IPart GetPartByID(string id)
        {
            return _parts.Find(x => x.PartNumber == id);
        }

        public PhantomPart GetPhantomPartByID(string id)
        {
            return _parts
                .OfType<PhantomPart>()
                .FirstOrDefault(x => x.PartNumber == id);
        }

        public IEnumerable<PhantomPart> GetPhantomParts() => _parts.OfType<PhantomPart>();

        public StockedPart GetStockedPartByID(string id)
        {
            return _parts
                .OfType<StockedPart>()
                .FirstOrDefault(x => x.PartNumber == id);
        }

        public IEnumerable<StockedPart> GetStockedParts() => _parts.OfType<StockedPart>();
    }
}