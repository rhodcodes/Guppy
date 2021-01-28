namespace guppy.core.Models
{
    internal record StockedPart : IPart
    {
        public string PartNumber { get; init; } = string.Empty;
        public string Description { get; init; } = string.Empty;
        public string? UsualSource { get; init; }
        public string? UnitOfMeasure { get; init; }
        public string? ProductGroup { get; init; }
        public string? DefaultReceiptLocation { get; init; }
        public string? DefaultIssueLocation { get; init; }
        public string? Workshop { get; init; }
        public string? DrawingNumber { get; init; }
        public decimal? ManufacturingLeadTime { get; init; }
        public decimal? StockDecimals { get; init; }
        public decimal? AssemblyDecimals { get; init; }
        public string? MaterialFinish { get; init; }
        public string? MaterialGrade { get; init; }
        public string? MaterialSpec { get; init; }
        public decimal? Weight { get; init; }
        public string? Notes { get; init; }
        public string? PreviousPartNumber { get; init; }
        public string? CataloguePartNumber { get; init; }

        public override string ToString()
        {
            return PartNumber!;
        }
    }
}