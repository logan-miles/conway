namespace Conway.Lib {
    public class Cell {
        public bool IsAlive;

        public Cell() : this(false) {}

        public Cell(bool isAlive) {
            IsAlive = isAlive;
        }
    }
}