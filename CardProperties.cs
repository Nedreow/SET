namespace SET
{
    public struct CardProperties
    {
        public readonly int SymbolShape;
        public readonly int SymbolCount;
        public readonly int SymbolColor;
        public readonly int SymbolFill;

        public CardProperties(int symbolShape, int symbolCount, int symbolColor, int symbolFill)
        {
            SymbolShape = symbolShape;
            SymbolCount = symbolCount;
            SymbolColor = symbolColor;
            SymbolFill = symbolFill;
        }
    }
}