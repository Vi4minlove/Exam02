using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
    public interface IStudent
    {
        int StudID { get; set; }
        int StudAge { get; set; }
        string StudClass { get; set; }
        string StudName { get; set; }
        string StudGender { get; set; }

        float StudAvgMark
        {
            get;
        }
        void Print();
    }
    class Student : IStudent
    {
        public int StudID { get ; set; }
        public int StudAge { get; set; }
        public string StudClass { get; set; }
        public string StudName { get; set; }
        public string StudGender { get; set; }

        private float _studAvgMark;
        public float StudAvgMark { get { return _studAvgMark; } }

        public void Print()
        {
            Console.WriteLine($"{StudID}");
            Console.WriteLine($"{StudAge}");
            Console.WriteLine($"{StudClass}");
            Console.WriteLine($"{StudName}");
            Console.WriteLine($"{StudGender}");
            Console.WriteLine($"{StudAvgMark}");
        }
        private int[] MarkList = new int[3];
        public int this[int index]
        {
            get
            {
                return MarkList[index];
            }
            set
            {
                MarkList[index] = value;
            }
        }
        public void CalAvg()
        {
            var sum = 0;
            foreach (int mark in MarkList) { sum += mark; }
            _studAvgMark = sum/MarkList.Length;
        }
    }
}
