namespace AZZ_LB_3_3
{
    class Program
    {
        public static void Main()
        {
            int sizeField = 3; // размер поля
            Field field = Field.getInstance(sizeField);
            field.FieldOut();
        }
    }
}