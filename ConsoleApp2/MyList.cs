using System;
using System.Collections;
using System.Collections.Generic;

public class MyList : IEnumerable
{
    private int[] array;

    public MyList()
    {
        array = new int[0];
    }

    public int this[int index]
    {
        get
        {
            return array[index];
        }
        set
        {
            array[index] = value;
        }
    }

    public IEnumerator GetEnumerator()
    {
        foreach (int item in array)
        {
            yield return item;
        }
    }

    public void Add(int value)
    {
        Array.Resize(ref array, array.Length + 1);
        array[array.Length - 1] = value;
    }

    public bool Contains(int value)
    {
        foreach (int item in array)
        {
            if (item == value)
                return true;
        }
        return false;
    }

    public int IndexOf(int value)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == value)
                return i;
        }
        return -1;
    }

    public void Remove(int value)
    {
        int index = IndexOf(value);
        if (index != -1)
        {
            for (int i = index; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];
            }
            Array.Resize(ref array, array.Length - 1);
        }
    }

    public void Reverse()
    {
        int firstIndex = 0;
        int lastIndex = array.Length - 1;

        while (firstIndex < lastIndex)
        {
            int temp = array[firstIndex];
            array[firstIndex] = array[lastIndex];
            array[lastIndex] = temp;
            firstIndex++;
            lastIndex--;
        }
    }
}
