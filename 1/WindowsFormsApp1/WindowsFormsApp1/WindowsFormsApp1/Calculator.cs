using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Calculator
    {
        private static void IsEmpty(string str)//проверка на пусто ли
        {
            if (str == String.Empty)
            {
                var error = new System.Exception();
                throw error;
            }
        }
        public static bool Bigger(string left, string right) //>
        {
            IsEmpty(left);
            IsEmpty(right);
            bool condition ;
            if (left.Length > right.Length)
                condition = true;
            
            else
                condition = false;
            return condition;

        }
        public static bool Smaller(string left, string right) //<
        {
            IsEmpty(left);
            IsEmpty(right);
            bool condition;
            if (left.Length < right.Length)
                condition = true;

            else
                condition = false;
            return condition;

        }
        public static bool Equal(string left, string right) //==
        {
            IsEmpty(left);
            IsEmpty(right);
            bool condition;
            if (left.Length == right.Length)
                condition = true;

            else
                condition = false;
            return condition;

        }
        public static bool NoEqual(string left, string right) //!=
        {
            IsEmpty(left);
            IsEmpty(right);
            bool condition;
            if (left.Length != right.Length)
                condition = true;

            else
                condition = false;
            return condition;

        }
        private static void AsEmpty(int str)//проверка на пусто ли
        {
            if (str.ToString().Length == 0)
            {
                var error = new System.Exception();
                throw error;
            }
        }
        public static int Right(int left, int right) //>>
        {
            AsEmpty(left);
            AsEmpty(right);
            int condition = left >> right;
                
            return condition;

        }
        public static int Left(int left, int right) //<<
        {
            AsEmpty(left);
            AsEmpty(right);
            int condition = left << right;

            return condition;

        }
    }
}
