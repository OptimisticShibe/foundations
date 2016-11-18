// Arrays_Stacks.cs
using System;

class Stack
{
    private int[] stack = new int[10]; //establishes that size of array (stack) is 10 (0 to 9)
    private int sp = 0; //keeps track of where I am

    public void Push(int v) // in here, we make a dynamic array (to grow it as needed)
    {
        //stack[sp] = v; // put the value in
        // spe = sp + 1; // move the stack pointer to the next available spot
        stack[sp++] = v;

        // step 1: identify if exceeding the length
        if (sp == stack.Length)
        {
            // step 2: create a new array with a longer length
            int n = stack.Length * 2;
            int[] newStack = new int[n];

            // step 3: copy old array into new array
            stack.CopyTo(newStack, 0);

            // step 4: delete old array
            stack = newStack;
        }
    }

    public int Pop()
    {
        //sp = sp -1;
        //Return stack[sp];
        return stack[--sp];
    }

    public int Top
    {
        get
        {
            return stack[sp - 1]; // return the latest and last value in the stack
        }
    }

    public bool IsEmpty
    {
        get
        {
            //if (sp == 0)
            //{ return true;}
            return sp == 0; //this is saying "return true if this statement is true"
        }
    }
}

class Arrays_Stacks
{
    static void Main()
    {
        Stack stack = new Stack();

        stack.Push(5);
        stack.Push(3);
        stack.Push(2);
        stack.Push(9);

        Console.WriteLine("The last value pushed was {0}", stack.Top);

        while (!stack.IsEmpty)
        {
            Console.WriteLine("Popping {0}", stack.Pop());
        }

        Console.Write("Press Enter...");
        Console.ReadLine();
    }
}