class MyQueue<T>
{
    T[] internalQueue = new T[0];

    // returns the count of the elements inside the queue
    public int Count
    {
        get 
        {
            return internalQueue.Length; 
        }
    }

    // adds an element in the queue
    public void Enqueue(T element)
    {
        if (internalQueue == null)
        {
            internalQueue[0] = element;
        }
        else
        {
            T[] secondArr = new T[internalQueue.Length];

            for (int i = 0; i < internalQueue.Length; i++)
            {
                secondArr[i] = internalQueue[i];
            }

            internalQueue = new T[secondArr.Length + 1];

            for (int i = 0; i < secondArr.Length; i++)
            {
                internalQueue[i] = secondArr[i];
            }
            internalQueue[internalQueue.Length - 1] = element;
        }
    }

    // removes and returns the last placed element in the queue
    public T Dequeue()
    {
        T[] secondArr = new T[internalQueue.Length - 1];
        T elToReturn = internalQueue[0];

        int counter = 1;
        for (int i = 0; i < internalQueue.Length - 1; i++)
        {
            secondArr[i] = internalQueue[counter++];
        }

        internalQueue = new T[secondArr.Length];

        for (int i = 0; i < secondArr.Length; i++)
        {
            internalQueue[i] = secondArr[i];
        }

        return elToReturn;
    }

    // returns the last placed element in the queue
    public T Peek()
    {
        return internalQueue[internalQueue.Length - 1];
    }

    // removes all elements in the queue
    public void Clear()
    {
        internalQueue = new T[0];
    }

    // checks if the given element is contained in the queue
    public bool Contains(T element)
    {
        if (internalQueue.Contains(element))
        {
            return true;
        }

        return false;
    }

    // returns the queue as a array of T
    public T[] ToArray()
    {
        return internalQueue.ToArray();
    }

    // prints the element on the console
    public void PrintEls()
    {
        for (int i = internalQueue.Length - 1; i >= 0; i--)
        {
            Console.Write(internalQueue[i] + " ");
        }
        Console.WriteLine();
    }
}