using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Set
{
    internal class Menu
    {
        public Methods _mt;
        public Menu()
        {
            _mt = new Methods();
        }
        public int Options()
        {
            Console.WriteLine("0. Exit");
            Console.WriteLine("1. Insert");
            Console.WriteLine("2. Remove");
            Console.WriteLine("3. Is empty?");
            Console.WriteLine("4. Return a random number");
            Console.WriteLine("5. Return the largest number");
            Console.WriteLine("6. Print the set");
            Console.Write("\nChoose an option: ");
            int opt = Convert.ToInt32(Console.ReadLine());

            return opt;
        }
        public void Insert()
        {
            try
            {
                Console.Write("Enter the number to insert: ");
                int num = Convert.ToInt32(Console.ReadLine());
                _mt.Insert(num);
            }
            catch (ElementAlreadyPresentException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void Delete()
        {
            try
            {
                Console.Write("Enter number to delete: ");
                int num = Convert.ToInt32(Console.ReadLine());
                _mt.Remove(num);
            }
            catch (ElementNotPresentException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void IsEmpty()
        {
            if (_mt.IsEmpty()) Console.Write("Set is Empty\n");
            else Console.WriteLine("Set is not empty");

        }
        public void ReturnRandom()
        {
            try
            {
                Console.WriteLine($"Here is your random Element: {_mt.ReturnRandom()}");
            }
            catch (SetEmptyException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void Largest()
        {
            try
            {
                Console.WriteLine($"Largest element: {_mt.ReturnLargest()}");
            }
            catch (SetEmptyException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void Print()
        {
            Console.WriteLine("The set is as follows:");
            _mt.PrintSet();
        }
        public void Run()
        {
            int opt;
            do
            {
                opt = Options();

                switch (opt)
                {
                    case 1:
                        Insert();
                        break;
                    case 2:
                        Delete();
                        break;
                    case 3:
                        IsEmpty();
                        break;
                    case 4:
                        ReturnRandom();
                        break;
                    case 5:
                        Largest();
                        break;
                    case 6:
                        Print();
                        break;


                }

            } while (opt != 0);
            {
                Console.WriteLine("Exit successfully!!");
            }
        }
    }
}
