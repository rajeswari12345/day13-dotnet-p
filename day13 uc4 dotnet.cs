// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
public class GenericMaximum<T> where T : IComparable
{
    public T[] value;
    public GenericMaximum(T[] Value)
    {
        this.value = Value;
    }
    public T[] sort(T[] values)
    {
        Array.Sort(values);
        return values;
    }
    public T Maxmethod()
    {
        var max = maxvalue(this.value);
        return max;
    }
    public void printmaxvalue()
    {
        var max = maxvalue(this.value);
        Console.WriteLine(" maximum value is " + max);
    }
    static void main(string[] args)
    {
        int[] arr = { 112, 234, 564, 666, 698);
        GenericMaximum<int> generic = new GenericMaximum<int>(arr);
        generic.printmaxvalue();
    }

