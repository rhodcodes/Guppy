namespace guppy.core.Models
{
    internal record PhantomPart : IPart
    {
        public string PartNumber { get; init; } = string.Empty;
        public string Description { get; init; } = string.Empty;
        public string? DrawingNumber { get; init; }
        public string? DrawingIssue { get; init; }

        public override string ToString()
        {
            return PartNumber;
        }
    }
}