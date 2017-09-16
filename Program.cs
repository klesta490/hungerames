using System;
using System.Collections.Generic;

namespace HungerGames
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }


    enum Direction
    {
        Left,
        Right,
        Down,
        Up
    }


    class Path
    {
        public int Distance { get; }
        public Area Area { get; }
        public Direction Direction { get; }

        public Path(Direction direction, Area area, int distance)
        {
            Distance = distance;
            Area = area;
            Direction = direction;
        }
    }
    class Area
    {
        public Coordinates Coordinates { get; }
        public IReadOnlyList<Path> Paths { get; }

        public Area(Coordinates coordinates, IEnumerable<Path> paths)
        {
            Coordinates = coordinates;
            Paths = new List<Path>(paths);
        }
    }

    struct Coordinates
    {
        public int X { get; }
        public int Y { get; }

        public Coordinates(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            
            return Equals((Coordinates)obj);
        }

        bool Equals(Coordinates other)
        {
            return X == other.X && Y == other.Y;
        }

        public override int GetHashCode()
        {
            return 397 * X ^ Y;            
        }
    }

    class Planet
    {
        public Planet(IEnumerable<Area> locations)
        {

        }
    }
}
