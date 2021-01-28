namespace guppy.core.Models
{
    [DataTable("StockedParts")]
    internal record StockedPart : IPart
    {
        [DataColumn("Part Number")]
        public string PartNumber { get; init; } = string.Empty;
        [DataColumn("Description")]
        public string Description { get; init; } = string.Empty;
        [DataColumn("Usual Source")]
        public string? UsualSource { get; init; }
        [DataColumn("Unit Of Measure")]
        public string? UnitOfMeasure { get; init; }
        [DataColumn("Product Group")]
        public string? ProductGroup { get; init; }
        [DataColumn("Default Receipt Location")]
        public string? DefaultReceiptLocation { get; init; }
        [DataColumn("Default Issue Location")]
        public string? DefaultIssueLocation { get; init; }
        [DataColumn("Workshop")]
        public string? Workshop { get; init; }
        [DataColumn("Drawing Number")]
        public string? DrawingNumber { get; init; }
        [DataColumn("Manufacturing Lead Time")]
        public decimal? ManufacturingLeadTime { get; init; }
        [DataColumn("Stock Decimals")]
        public decimal? StockDecimals { get; init; }
        [DataColumn("Assembly Decimals")]
        public decimal? AssemblyDecimals { get; init; }
        [DataColumn("Material Finish")]
        public string? MaterialFinish { get; init; }
        [DataColumn("Material Grade")]
        public string? MaterialGrade { get; init; }
        [DataColumn("Material Spec")]
        public string? MaterialSpec { get; init; }
        [DataColumn("Weight (KG)")]
        public decimal? Weight { get; init; }
        [DataColumn("Notes")]
        public string? Notes { get; init; }
        [DataColumn("Previous PNMBR")]
        public string? PreviousPartNumber { get; init; }
        [DataColumn("Catalogue PNMBR")]
        public string? CataloguePartNumber { get; init; }

        public override string ToString()
        {
            return PartNumber!;
        }
    }
}