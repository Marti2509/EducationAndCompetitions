class MyList<T>
{
    T[] internalArray = new T[0];

    // returns the count of the elements inside the list
    public int Count
    {
        get
        {
            return internalArray.Length;
        }
    }

    // adds an element in the list
    public void Add(T element)
    {
        if (internalArray == null)
        {
            internalArray[0] = element;
        }
        else
        {
            T[] secondArr = new T[internalArray.Length];

            for (int i = 0; i < internalArray.Length; i++)
            {
                secondArr[i] = internalArray[i];
            }

            internalArray = new T[secondArr.Length + 1];

            for (int i = 0; i < secondArr.Length; i++)
            {
                internalArray[i] = secondArr[i];
            }
            internalArray[internalArray.Length - 1] = element;
        }
    }

    // removes the last element in the queue
    public void Remove()
    {
        if (internalArray != null)
        {
            T[] secondArr = new T[internalArray.Length - 1];
            for (int i = 0; i < internalArray.Length - 1; i++)
            {
                secondArr[i] = internalArray[i];
            }

            internalArray = new T[secondArr.Length];

            for (int i = 0; i < secondArr.Length; i++)
            {
                internalArray[i] = secondArr[i];
            }
        }
    }

    // removes the element from the list on the given index
    public void RemoveAt(int index)
    {
        if (internalArray != null)
        {
            T[] secondArr = new T[internalArray.Length - 1];
            int couterForItems = 0;
            bool hasEntered = false;
            for (int i = 0; i < internalArray.Length - 1; i++)
            {
                if (i == index && hasEntered == false)
                {
                    if (i == 0)
                    {
                        i = -1;
                    }
                    else
                    {
                        i--;
                    }

                    hasEntered = true;
                }
                else
                {
                    secondArr[i] = internalArray[couterForItems];
                }

                couterForItems++;
            }

            internalArray = new T[secondArr.Length];

            for (int i = 0; i < secondArr.Length; i++)
            {
                internalArray[i] = secondArr[i];
            }
        }
    }

    // removes all elements in the list
    public void Clear()
    {
        internalArray = new T[0];
    }

    // checks if the given element is contained in the list
    public bool Contains(T element)
    {
        if (internalArray.Contains(element))
        {
            return true;
        }

        return false;
    }

    // returns the list as a array of T
    public T[] ToArray()
    {
        return internalArray.ToArray();
    }

    // prints the element on the console
    public void PrintEls()
    {
        Console.WriteLine(string.Join(' ', internalArray));
    }
}