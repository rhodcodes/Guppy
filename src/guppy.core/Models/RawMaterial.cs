namespace guppy.core.Models
{
    record RawMaterial
    {
        [DataColumn("Material Form")]
        public string? Form { get; init; }
        [DataColumn("Material Specification")]
        public string? Specification { get; init; }
        [DataColumn("Dimension 1")]
        public string? Dimension1 { get; init; }
        [DataColumn("Dimension 2")]
        public string? Dimension2 { get; init; }
        [DataColumn("Dimension 3")]
        public string? Dimension3 { get; init; }
    }
}