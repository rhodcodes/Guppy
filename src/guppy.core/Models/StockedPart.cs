namespace guppy.core.Models
{
    internal record StockedPart : IPart
    {
        public string CataloguePartNumber { get; init; }
        public string DefaultIssueLocation { get; init; }
        public string DefaultReceiptLocation { get; init; }
        public string Description { get; init; }
        public string DrawingNumber { get; init; }
        public string ManufacturingLeadTime { get; init; }
        public string MaterialFinish { get; init; }
        public string MaterialGrade { get; init; }
        public string MaterialSpec { get; init; }
        public string Notes { get; init; }
        public string PartNumber { get; init; }
        public string PreviousPartNumber { get; init; }
        public string ProductGroup { get; init; }
        public string StockDecimals { get; init; }
        public string UnitOfMeasure { get; init; }
        public string UsualSource { get; init; }
        public string Weight { get; init; }
        public string Workshop { get; init; }

        public override string ToString()
        {
            return PartNumber!;
        }
    }
}