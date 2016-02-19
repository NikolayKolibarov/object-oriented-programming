using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_GenericList
{
    class GenericList<T>
        where T : IComparable<T>
    {
        private const int defaultCapacity = 16;
        private T[] array;
        private int index;
        private int currentCapacity;

        public GenericList(int capacity = defaultCapacity)
        {
            this.array = new T[capacity];
            this.index = 0;
            currentCapacity = capacity;
        }

        public void Add(T element)
        {
            if (element != null)
            {
                if (index > this.currentCapacity)
                {
                    this.Resize(currentCapacity * 2);
                }
                this.array[index] = element;
                index++;
            }
        }

        public T Get(int position)
        {
            if (position > index)
            {
                throw new InvalidOperationException("You cannot get the element at given index because there is no such index");
            }

            return array[position];
        }

        public void RemoveAt(int position)
        {
            for (int i = position; i < index; i++)
            {
                array[i] = array[i + 1];
            }
            index--;
        }
        
        public void Insert(int position, T value)
        {
            array[position] = value;
        }

        public void Clear()
        {
            T[] clearedArray = new T[defaultCapacity];
            this.array = clearedArray;
        }

        public int Find(T item)
        {
            for (int i = 0; i < index; i++)
            {
                if (item.CompareTo(array[i]) == 0)
                {
                    return i;
                }
            }
            return -1;
        }

        public bool Contains(T item)
        {
            bool contains = false;
            for (int i = 0; i < index; i++)
            {
                if (item.CompareTo(array[i]) == 0)
                {
                    contains = true;
                    break;
                }
            }
            return contains;
        }

        private void Resize(int newCapacity) 
        {
            T[] newArray = new T[newCapacity];
            for (int i = 0; i < this.index; i++)
            {
                newArray[i] = this.array[i];
            }
            this.array = newArray;
            this.currentCapacity = newCapacity;
        }

        public T Max()
        {
            T currentMax = array[0];
            for (int i = 1; i < index; i++)
            {
                if (currentMax.CompareTo(array[i]) == -1)
                {
                    currentMax = array[i];
                }
            }
            return currentMax;
        }

        public T Min()
        {
            T currentMin = array[0];
            for (int i = 1; i < index; i++)
            {
                if (currentMin.CompareTo(array[i]) == 1)
                {
                    currentMin = array[i];
                }
            }
            return currentMin;
        }

        public override string ToString()
        {
            string output = "";
            for (int i = 0; i < index ; i++)
            {
                output += array[i] + " ";
            }
            return output;
        }
    }
}
