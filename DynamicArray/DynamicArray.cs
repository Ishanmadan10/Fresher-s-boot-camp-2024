using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicArrayProj
{
    
        public class DynamicArray<T>
        {
            private T[] array;
            private int size;
            private int capacity;

            public DynamicArray(int initialCapacity)
            {
                if (initialCapacity <= 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(initialCapacity), "Initial capacity must be greater than zero.");
                }

                array = new T[initialCapacity];
                size = 0;
                capacity = initialCapacity;
            }

            public int Count
            {
                get { return size; }
            }

            public void Add(int index, T item)
            {
                if (index < 0 || index > size)
                {
                    throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range.");
                }

                if (size == capacity)
                {
                    ResizeArray();
                }

                ShiftElementsToMakeSpace(index);
                array[index] = item;
                size++;
            }

            public T this[int index]
            {
                get
                {
                    if (index < 0 || index >= size)
                    {
                        throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range.");
                    }

                    return array[index];
                }
            }

            private void ResizeArray()
            {
                capacity *= 2;
                Array.Resize(ref array, capacity);
            }

            private void ShiftElementsToMakeSpace(int index)
            {
                for (int i = size; i > index; i--)
                {
                    array[i] = array[i - 1];
                }
            }
        }
    }


