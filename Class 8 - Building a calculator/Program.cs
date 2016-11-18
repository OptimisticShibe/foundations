// Class Exercise No. 1 - Create a basic RPN Calculator
// Make use of Class Stack to create your Class RPN Calculator 
using System;

class Stack
{
    private int[] stack = new int[10];
    private int sp = 0;

    public void Push(int v)
    {
        stack[sp++] = v;
    }

    public int Top
    {
        get
        {
            return stack[sp - 1];
        }
    }

    public bool IsEmpty
    {
        get
        {
            return sp == 0;
        }
    }

    public int Pop()
    {
        return stack[--sp];
    }
}

class RPN
{
    private Stack stack = new Stack();

    public void Process(string str)
    {
        switch (str)
        {
            case "+":
                {
                    int v1 = stack.Pop();
                    int v2 = stack.Pop();
                    int sum = v2 + v1;
                    stack.Push(sum);
                    break;
                    // do the code to add the last two numbers 
                    // and save it in the stack
                }
            case "-":
                {
                    int v1 = stack.Pop();
                    int v2 = stack.Pop();
                    int difference = v2 - v1;
                    stack.Push(difference);
                    break;
                    // do the code to subtract the last from previous
                    // and save it in the stack
                }
            default:
                {
                    int n = int.Parse(str);
                    stack.Push(n);
                    // places the number into the stack
                    break;
                }
        }
    }

    public int Result
    {
        get
        {
          return stack.Top;
            
            // do the code to return the last value
            // return the top value (or the result)
        }
    }
}

class ex17
{
    public static void Main()
    {
        RPN rpn = new RPN();

        while (true)
        {
            string str;

            Console.Write("RPN>");
            str = Console.ReadLine();

            rpn.Process(str);

            Console.WriteLine("={0}", rpn.Result);
        }
    }
}