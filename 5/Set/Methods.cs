using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Set
{
    #region Exe
    public class ElementAlreadyPresentException : Exception
    {
        public ElementAlreadyPresentException(string Message) : base(Message) { }
    }
    public class ElementNotPresentException : Exception
    {
        public ElementNotPresentException(string Message) : base(Message)
        {

        }
    }
    public class SetEmptyException : Exception
    {
        public SetEmptyException(string Message) : base(Message)
        {

        }
    }
    #endregion


    public class Methods
    {
        private List<int> set;

        public Methods()
        {
            set = new List<int>();
        }
        public void Insert(int num)
        {
            bool isIn = false;

            for (int i = 0; i < set.Count; i++)
            {
                if (set[i] == num)
                {
                    isIn = true;
                }
            }
            if (!isIn)
            {
                set.Add(num);
            }
            else
            {
                throw new ElementAlreadyPresentException("Error!!the element already exists in the set!!!");
            }
        }
        public void Remove(int num)
        {
            int ind = 0;
            bool isIn = false;
            for (int i = 0; i < set.Count; i++)
            {
                if (set[i] == num)
                {
                    ind = i;
                    isIn = true;
                    break;

                }
            }
            if (isIn)
            {
                set.RemoveAt(ind);
            }
            else
            {
                throw new ElementNotPresentException("Error!!Element not found!!");
            }

        }
        public bool IsEmpty()
        {
            return set.Count == 0;
        }
        public int ReturnRandom()
        {
            if (set.Count != 0)
            {
                Random rand = new Random();
                int randomNum = rand.Next(0, set.Count);
                return set[randomNum];

            }
            else
            {
                throw new SetEmptyException("Error!!Set is empty!!");
            }

        }
        public int ReturnLargest()
        {
            if (set.Count != 0)
            {
                int max = set[0];
                for (int i = 1; i < set.Count; i++)
                {
                    if (set[i] > max)
                    {
                        max = set[i];
                    }
                }
                return max;
            }
            else
            {
                throw new SetEmptyException("Error!!Set is Empty!!");
            }
        }
        public void PrintSet()
        {
            string joinedSet = string.Join(',', set);
            Console.WriteLine("{" + joinedSet + "}\n");
        }


    }
}
