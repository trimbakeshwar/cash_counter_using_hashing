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
        /// <summary>
        /// value %size it assign as hashvalue
        /// if value on index is zero
        /// then add value 
        /// if value is present then goes in else
        /// if same value present on index
        /// then replace this value by new value
        /// if value is not same on that index then goes in else condition
        /// check for next index has value zero
        /// if value of index is zero then insert on this position
        /// </summary>
        /// <param name="value"></param>
        public void put(int value)
        {
            // value %size it assign as hashvalue
            hashvalue = value % size;
            // if value on index is zero then add value 
            if (element[hashvalue] == 0)
            {
                element[hashvalue] = value;
            }
            else
            {
                // if value is present then goes in else
                // if same value present on index
                if (element[hashvalue] == value)
                {
                    // then replace this value by new value
                    element[hashvalue] = value;
                }
                else
                {
                    // if value is not same on that index then goes in else condition
                    // check for next index has value zero
                    nextSlot = (hashvalue + 1) % size;
                    while (element[nextSlot] != 0 && element[nextSlot] != value)//loop is increse still nextslot is zero or value is not zero
                    {
                        //index is increse one and check value on that position is zero
                        nextSlot = (nextSlot+1) % size;
                    }
                    //if on that index value is zero then add value on that position
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
