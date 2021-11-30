using System;

namespace Zadanie_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
   
           
        }
    }
    interface ISeries
    {
        int X { get; set; }
        int Y { get; set; }
       

        void setStart(int x);
        int getNext();
        void reset();
    }
    class ArithProgression : ISeries
    {
        public int X { get; set; }
        public int Y { get ; set;}
        int i = 0;
        public ArithProgression(int x, int y)
        {
            X = x;
            Y = y;
        }
        public void setStart(int x)
        {
            Random random = new Random();
            X = Convert.ToInt32(random);
            
            i++;

        }

            public int getNext()
        {
            return (X + Y * i);
            i++;
            
        }

        public void reset()
        {
            i=0;
        }


        
    }
    class GeomProgression : ISeries
        {

        public int X { get; set; }
        public int Y { get; set; }
        int i = 0;
        public GeomProgression(int x, int y)
        {
            X = x;
            Y = y;
        }
        public void setStart(int x)
        {
            Random random = new Random();
            X = Convert.ToInt32(random);
            i++;
        }
        public int getNext()
        {
            return Convert.ToInt32((X * Math.Pow(Y,i)));
            i++;

        }

        public void reset()
        {
            i = 0;
        }


    }









}
