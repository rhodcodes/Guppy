namespace guppy.core.Models
{
    internal record PhantomPart : IPart
    {
        public string Description { get; init; }
        public string PartNumber { get; init; }
        public string DrawingNumber { get; init; }
        public string DrawingIssue { get; init; }

        public override string ToString()
        {
            return PartNumber;
        }
    }
}