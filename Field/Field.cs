using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AZZ_LB_3_3
{
    public class Field
    {
        private List<Cell> _field;

        private int? _sizeSide;

        private static Field? instance;

        private Field(int? sizeSide)
        {
            _field = new List<Cell>();
            for (int i = 0; i < sizeSide; i++)
            {
                for (int j = 0; j < sizeSide; j++)
                {
                    Cell cell = new Cell(i, j);
                    _field.Add(cell);
                }
                _sizeSide = sizeSide;
            }
        }

        public static Field getInstance(int? sizeSide)
        {
            //if (size == null || size < 1) { throw; }   сделать проверку
            if (instance == null)
            {
                instance = new Field(sizeSide);
            }
            return instance;
        }

        public void FieldOut()
        {
            int count = 0;

            foreach (Cell cell in _field)
            {

                Console.Write(cell.ToString());
                count++;

                if (count % _sizeSide == 0)
                {
                    Console.WriteLine();
                }
            }
        }
        public void AddModel(IModel model, int x, int y)
        {
            for (int i = 0; i < _field.Count; i++)
            {
                if (_field[i].X == x && _field[i].Y == y)
                {
                    if (_field[i].Model == null) _field[i].AddModelInCell(model);
                    else { Console.WriteLine("Нельзя поставить модель в занятое поле\n"); }
                    break;
                }
            }
        }
        public Cell? GetCell(int x, int y)
        {
            Cell? result = null;

            if (x > _sizeSide || y > _sizeSide || x < 0 || y < 0) {
                throw new ArgumentOutOfRangeException("Некорректные координаты для получения клетки");
            }

            for (int i = 0; i < _field.Count; i++) {
                if (_field[i].X == x && _field[i].Y == y) { result = _field[i]; }
            }

            return result;
        }
    }
}
