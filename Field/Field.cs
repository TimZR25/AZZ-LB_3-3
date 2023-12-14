using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AZZ_LB_3_3
{
    public class Field : IField
    {
        public IFieldPrint fieldPrint { get; private set; }

        private ICell[,] _field;

        private int _sizeSide;

        private static Field? instance;

        public void FieldOut()
        {
            for (int x = 0; x < _field.GetLength(0); x++)
            {
                for (int y = 0; y < _field.GetLength(1); y++)
                {
                    Console.Write(_field[x, y]);
                }
                Console.WriteLine();
            }
        }

        public Field(int sizeSide)
        {
            _sizeSide = sizeSide;

            _field = new ICell[_sizeSide, _sizeSide];

            for (int x = 0; x < _sizeSide; x++)
            {
                for (int y = 0; y < _sizeSide; y++)
                {
                    ICell cell = new Cell(x, y);
                    _field[x, y] = cell;
                }
            }

            AddNeighborsAll();
        }

        public void AddModel(IModel model, int x, int y)
        {
            if (_field[x, y].Model == null) _field[x, y].Model = model;
            else { Console.WriteLine("Нельзя поставить модель в занятое поле\n"); }
        }

        public ICell? GetCell(int x, int y)
        {
            if (x > _sizeSide || y > _sizeSide || x < 0 || y < 0) {
                throw new ArgumentOutOfRangeException("Некорректные координаты для получения клетки");
            }

            return _field[x, y];
        }

        public void ClearField()
        {
            foreach (ICell cell in _field)
            {
                cell.Model = null;
            }
        }

        private void AddNeighborsAll()
        {
            for (int x = 0; x < _sizeSide; x++)
            {
                for (int y = 0; y < _sizeSide; y++)
                {
                    AddNeighbors(x, y);
                }
            }
        }

        private IEnumerable<int> Shifts(int v, int? max)
        {
            yield return 0;
            if (v > 0) yield return -1;
            if (v < max - 1) yield return 1;
        }

        private void AddNeighbors(int x, int y)
        {
            foreach (int dx in Shifts(x, _sizeSide))
            {
                foreach (int dy in Shifts(y, _sizeSide))
                {
                    if ((dx == 0) && (dy == 0))
                        continue;
                    _field[x, y].Neighbors.Add(_field[x + dx, y + dy]);
                }
            }
        }

        public List<ICell> GetNeighborsRadius(ICell cell, int radius)
        {
            if (cell == null) throw new ArgumentNullException("Пустая ссылка на клетку");
            if (radius == null) throw new ArgumentNullException("Пустая ссылка на радиус");
            if (radius < 1) throw new ArgumentOutOfRangeException("Радиус не может быть меньше 1");

            HashSet<ICell> result = new HashSet<ICell>(cell.Neighbors);
            result.Add(cell);

            int count = 1;

            HashSet<ICell> neighbors = new HashSet<ICell>(cell.Neighbors);

            while (count != radius)
            {
                List<ICell> currentCells = new List<ICell>(neighbors);
                neighbors.Clear();

                for (int i = 0; i < currentCells.Count; i++)
                {
                    for (int j = 0; j < currentCells[i].Neighbors.Count; j++)
                    {
                        neighbors.Add(currentCells[i].Neighbors[j]);
                        result.Add(currentCells[i].Neighbors[j]);
                    }
                }
                count++;
            }

            result.Remove(cell);

            return new List<ICell>(result);
        }
    }
}
