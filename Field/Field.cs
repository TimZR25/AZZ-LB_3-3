using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AZZ_LB_3_3
{
    public class Field
    {
        private List<Cell> field;

        private int? _sizeSide;

        private static Field? instance;

        private Field(int? sizeSide)
        {
            field = new List<Cell>();
            for (int i = 0; i < sizeSide; i++)
            {
                for (int j = 0; j < sizeSide; j++)
                {
                    Cell cell = new Cell(i, j);
                    field.Add(cell);
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

            foreach (Cell cell in field)
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
            for (int i = 0; i < field.Count; i++)
            {
                if (field[i].X == x && field[i].Y == y)
                {
                    if (field[i].Model == null) field[i].AddModelInCell(model);
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

            for (int i = 0;i < field.Count;i++) {
                if (field[i].X == x && field[i].Y == y) { result = field[i]; }
            }

            return result;
        }
    }
}
