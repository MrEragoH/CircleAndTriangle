using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleAndTriangle
{    
    public class Figures
    {
        public string Query = $@"SELECT        Category.NameCategory, Product.NameProduct
FROM            Category INNER JOIN
                         ProductCategory ON Category.IdCategory = ProductCategory.IdCategory RIGHT JOIN
                         Product ON ProductCategory.IdProduct = Product.IdProduct";
        public static string Area(double s1, double s2, double s3, double r)
        {
            string Rez = "";
            double Circle = 0, Triangle = 0;
            if (r > 0)
            {
                Circle = 3.14 * Math.Pow(r, 2);
                Rez = $"Площадь круга = {Math.Round(Circle, 2)}\r\n";
            }
            else
                Rez = $"Круга с заданным радиусом не существует\r\n";
            double s4 = 0;
            if (s1 < s2)
            {
                s4 = s1;
                s1 = s2;
                s2 = s4;
            }
            if (s1 < s3)
            {
                s4 = s1;
                s1 = s3;
                s3 = s4;
            }
            bool Ninety = false;
            if (Math.Pow(s1, 2) == (Math.Pow(s2, 2) + Math.Pow(s3, 2)))
                Ninety = true;
            if (s1 > 0 && s2 > 0 && s3 > 0)
            {
                double p = (s1 + s2 + s3) / 2;
                Triangle = Math.Sqrt(p * (p - s1) * (p - s2) * (p - s3));
                Rez += $"Площадь треугольника = {Math.Round(Triangle, 2)}";
                if (Ninety == true)
                    Rez += "\r\nТреугольник является прямоугольным";
                else
                    Rez += "\r\nТреугольник не является прямоугольным";
            }
            else
                Rez += "Треугольника с заданными сторонами не существует";
            return Rez;
        }
    }
}
