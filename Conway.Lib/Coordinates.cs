namespace Conway.Lib {
    public readonly struct Coordinates {
        public Coordinates(int row, int column) {
            this.row = row;
            this.column = column;
        }

        public int row { get; }
        public int column { get; }

        public override string ToString() => $"({row}, {column})";
    }
}