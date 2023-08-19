using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_builder.Libraries.Labs.var_4
{
    abstract class Chessman
    {
        protected virtual (int, int) parse(string position)
        {
            if (position == null || position.Length < 2) return (-1, -1);
            return (position[0] - 'A', position[1] - '1');
        }
        abstract public bool canMove(string from, string to);
    }


    class Knight : Chessman
    {
        public override bool canMove(string from, string to)
        {
            (int from_x,int from_y) = this.parse(from);
            (int to_x,int to_y) = this.parse(to);
            return Math.Abs(from_x - to_x) * Math.Abs(from_y - to_y) == 2;
        }
        public override bool Equals(object? obj)
        {
            return obj == null ? false : obj.GetType() == GetType();
        }
    }

    class Bishop : Chessman
    {
        public override bool canMove(string from, string to)
        {
            (int from_x, int from_y) = this.parse(from);
            (int to_x, int to_y) = this.parse(to);
            return Math.Abs(from_x - to_x) == Math.Abs(from_y - to_y);
        }
        public override bool Equals(object? obj)
        {
            return obj == null ? false : obj.GetType() == GetType();
        }
    }

    class Rook : Chessman
    {
        public override bool canMove(string from, string to)
        {
            (int from_x, int from_y) = this.parse(from);
            (int to_x, int to_y) = this.parse(to);
            return Math.Abs(from_x - to_x) * Math.Abs(from_y - to_y) == 0;
        }

        public override bool Equals(object? obj)
        {
            return obj == null ? false : obj.GetType() == GetType();
        }
    }

    class Queen : Chessman
    {
        public override bool canMove(string from, string to)
        {
            (int from_x, int from_y) = this.parse(from);
            (int to_x, int to_y) = this.parse(to);
            return 
                Math.Abs(from_x - to_x) * Math.Abs(from_y - to_y) == 0 
                ||
                Math.Abs(from_x - to_x) == Math.Abs(from_y - to_y)
            ;
        }

        public override bool Equals(object? obj)
        {
            return obj == null ? false : obj.GetType() == GetType();
        }
    }

    static class Lab1
    {
        public static void lab1_main()
        {
            List<Chessman> list = new List<Chessman>() { new Queen(), new Bishop(), new Rook(), new Knight() };

            Console.WriteLine($"Queen from G2 to C6 -> {list[0].canMove("G2","C6")}");
            Console.WriteLine($"Bishop from C4 to D6 -> {list[1].canMove("C4","D6")}");
            Console.WriteLine($"Rook from D5 to G5 -> {list[2].canMove("D5","G5")}");
            Console.WriteLine($"Knight from A1 to B3 -> {list[3].canMove("A1","B3")}");

            //Late binding example
            dynamic var1 = new Queen();
            Console.WriteLine($"Queen from B4 to D5 -> {var1.canMove("B4","D5")}");

            //Equals example
            Console.WriteLine($"Does object first equal to var1 : {list[0].Equals(var1)}");
            Console.WriteLine($"Does object second equal to var1 : {list[1].Equals(var1)}");

        }
    }
}
