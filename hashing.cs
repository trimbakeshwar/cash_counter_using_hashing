using System;
using System.Collections.Generic;
using System.Text;

namespace cash_counter_using_hashing
{
    class hashing
    {
        int size;
        int[] element;
        int hashvalue;
        int nextSlot;
        int front;
        public hashing(int size)
        {
            this.size = size;
            element = new int[size];
            hashvalue = 0;
            nextSlot = 0;
             front = 0;
        }
        public void put(int value)
        {
            hashvalue = value % size;
            if (element[hashvalue] == 0)
            {
                element[hashvalue] = value;
            }
            else
            {
                if (element[hashvalue] == value)
                {
                    element[hashvalue] = value;
                }
                else
                {
                    nextSlot = (hashvalue + 1) % size;
                    while (element[nextSlot] != 0 && element[nextSlot] != value)
                    {
                        nextSlot = (nextSlot) % size;
                    }
                    if (element[nextSlot] == 0)
                    {
                        element[nextSlot] = value;
                    }
                    else
                    {
                        element[nextSlot] = value;
                    }
                }
            }

        }
        public void remove()
        {
            
           
            int value = element[front];
            this.front = this.front + 1;
            //  size = size - 1;


        }
        public void display()
        {
            for (int i = front; i < size; i++)
            {
                Console.WriteLine(element[i]);
            }
        }
    }
}
