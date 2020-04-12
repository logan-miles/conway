using System;

namespace Conway.Lib {
    public class Game {
        private Cell[, ] board;

        public Game(int height, int width) {
            board = new Cell[height, width];
            Initialize();
        }

        private void Initialize() {
            for (int i = 0; i < board.GetLength(0); i++) {
                for (int j = 0; j < board.GetLength(1); j++) {
                    board[i, j] = new Cell();
                }
            }
        }

        public void SetCell(Coordinates coordinates, bool value) {
            board[coordinates.row, coordinates.column].IsAlive = value;
        }

        public Cell[, ] GetStatus() {
            return board;
        }

        public void Step() {
            Cell[, ] nextBoard = new Cell[board.GetLength(0), board.GetLength(1)];

            for (int i = 0; i < nextBoard.GetLength(0); i++) {
                for (int j = 0; j < nextBoard.GetLength(1); j++) {
                    board[i, j] = new Cell(ShouldHaveLife(new Coordinates(i, j)));
                }
            }
        }

        private bool ShouldHaveLife(Coordinates coordinates) {
            throw new NotImplementedException();
        }
    }
}