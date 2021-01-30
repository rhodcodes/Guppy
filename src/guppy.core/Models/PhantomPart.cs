namespace guppy.core.Models
{
    [DataTable("Phantoms")]
    internal record PhantomPart : IPart
    {
        [DataColumn("Part Number")]
        public string PartNumber { get; init; } = string.Empty;
        [DataColumn("Description")]
        public string Description { get; init; } = string.Empty;
        [DataColumn("Drawing Number")]
        public string? DrawingNumber { get; init; }
        [DataColumn("Drawing Issue")]
        public string? DrawingIssue { get; init; }
        [DataColumn("Manufacturing Lead Time")]
        public decimal? ManufacturingLeadTime { get; init; }

        public override string ToString()
        {
            return PartNumber;
        }
    }
}