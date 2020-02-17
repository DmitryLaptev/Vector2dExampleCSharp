using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vector2dExampleCSharp
{
    class Vector2d
    {
        double x;
        double y;
        public Vector2d()
        {
            x = 0;
            y = 0;
        }
        public Vector2d(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public Vector2d(double x1, double y1, double x2, double y2)
        {
            this.x = x2-x1;
            this.y = y2-y1; 
        }
        public double GetX() => x;
        public double GetY() => y;
        public void SetX() => x = double.Parse(Console.ReadLine());
        public void SetY() => y = double.Parse(Console.ReadLine());
        Vector2d sum(Vector2d b)
        {
            x += b.x;
            y += b.y;
            return new Vector2d(x, y);
        }
        Vector2d sub(Vector2d b)
        {
            x -= b.x;
            y -= b.y;
            return new Vector2d(x, y);
        }
        double scalarMult(Vector2d b)
        {
            return x*b.x + y*b.y;
        }
        Vector2d mult(double value)
        {
            x *= value;
            y *= value;
            return new Vector2d(x, y);
        }
        public double length()
        {
            return Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
        }
        public double tanAngle(Vector2d b)
        {
            return (x*b.y - y*b.x) / scalarMult(b);
        }
        public static Vector2d operator+(Vector2d v1,Vector2d v2)
        {
            return new Vector2d(v1.x + v2.x, v1.y + v2.y);
        }
        public static Vector2d operator-(Vector2d v1, Vector2d v2)
        {
            return new Vector2d(v1.x - v2.x, v1.y - v2.y);
        }
        public static double operator/(Vector2d v1, Vector2d v2)
        {
            return v1.x * v2.x + v1.y * v2.y;
        }
        public static Vector2d operator*(Vector2d vector, double realNumber)
        {
            return new Vector2d(realNumber * vector.x, realNumber * vector.y);
        }
        /*public static Vector2d operator ++(Vector2d v)
        {
            v.x++;
            v.y++;
            return new Vector2d(v.x,v.y); 
        }*/
        public static Vector2d operator ++(Vector2d v)
        {
            Vector2d temp= new Vector2d (v.x, v.y);
            temp.x++;
            temp.y++;
            return temp;
        }
        public static Vector2d operator --(Vector2d v)
        {
            v.x--;
            v.y--;
            return new Vector2d(v.x, v.y);
        }
        ~Vector2d()
        {
            Console.WriteLine("Enabled"); 
        }
        /*public static Vector2d operator --(Vector2d v)
        {
            Vector2d temp= new Vector2d (v.x, v.y);
            temp.x--;
            temp.y--;
            return temp;
        }*/
        public void Print()
        {
            Console.WriteLine("(" + x + ";" + y + ")");
        }
        public static explicit operator string(Vector2d v)
        {
            string s = "(" + v.x.ToString() + ";" + v.y.ToString() + ")";
            return s;
        }
    }
}
