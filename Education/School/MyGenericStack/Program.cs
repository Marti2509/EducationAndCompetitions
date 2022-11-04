internal class MyStack<T>
{
    T[] internalStack = new T[0];

    // returns the count of the elements inside the stack
    public int Count
    {
        get
        {
            return internalStack.Length;
        }
    }

    // adds an element in the stack
    public void Push(T element)
    {
        if (internalStack == null)
        {
            internalStack[0] = element;
        }
        else
        {
            T[] secondArr = new T[internalStack.Length];

            for (int i = 0; i < internalStack.Length; i++)
            {
                secondArr[i] = internalStack[i];
            }

            internalStack = new T[secondArr.Length + 1];

            for (int i = 0; i < secondArr.Length; i++)
            {
                internalStack[i] = secondArr[i];
            }
            internalStack[internalStack.Length - 1] = element;
        }
    }

    // removes and returns the last placed element in the stack
    public T Pop()
    {
        T[] secondArr = new T[internalStack.Length - 1];
        T elToReturn = internalStack[internalStack.Length - 1];

        for (int i = 0; i <= internalStack.Length - 2; i++)
        {
            secondArr[i] = internalStack[i];
        }

        internalStack = new T[secondArr.Length];

        for (int i = 0; i < secondArr.Length; i++)
        {
            internalStack[i] = secondArr[i];
        }

        return elToReturn;
    }

    // returns the last placed element in the stack
    public T Peek()
    {
        return internalStack[internalStack.Length - 1];
    }

    // removes all elements in the stack
    public void Clear()
    {
        internalStack = new T[0];
    }

    // checks if the given element is contained in the stack
    public bool Contains(T element)
    {
        if (internalStack.Contains(element))
        {
            return true;
        }

        return false;
    }

    // returns the stack as a array of T
    public T[] ToArray()
    {
        return internalStack.ToArray();
    }

    // prints the element on the console
    public void PrintEls()
    {
        for (int i = internalStack.Length - 1; i >= 0; i--)
        {
            Console.Write(internalStack[i] + " ");
        }
        Console.WriteLine();
    }
}