using System;
using System.Collections.Generic;

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

        internal int GetLength(int v) {
            return board.GetLength(v);
        }

        public bool HasLife(Coordinates coordinates) {
            return GetCell(coordinates).IsAlive;
        }

        private Cell GetCell(Coordinates coordinates) {
            return board[coordinates.row, coordinates.column];
        }

        public Cell[, ] GetStatus() {
            return board;
        }

        public void Step() {
            Cell[, ] nextBoard = new Cell[board.GetLength(0), board.GetLength(1)];

            for (int i = 0; i < nextBoard.GetLength(0); i++) {
                for (int j = 0; j < nextBoard.GetLength(1); j++) {
                    board[i, j] = new Cell(Rules.ShouldBeAlive(new Coordinates(i, j), this));
                }
            }
        }

        public IEnumerable<Cell> GetNeighbors(Coordinates coordinates) {
            List<Cell> neighbors = new List<Cell>();
            for (int i = coordinates.row - 1; i <= coordinates.row + 1; i++) {
                if (i < 0 || i >= GetLength(0))
                    continue;
                for (int j = coordinates.column - 1; j <= coordinates.column + 1; j++) {
                    if (j < 0 || j >= GetLength(1))
                        continue;

                    Coordinates neighbor = new Coordinates(i, j);
                    if (!coordinates.Equals(neighbor) && HasLife(neighbor))
                        neighbors.Add(GetCell(neighbor));
                }
            }

            return neighbors;
        }
    }
}