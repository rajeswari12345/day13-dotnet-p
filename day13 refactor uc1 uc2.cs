// See https://aka.ms/new-console-template for more information
using System;
using System. Collections.Generic;
public class GenerixMaximum<T> where T : IComparable
{
    public T firstvalue, secondvalue, thirdvalue;
public GenerixMaximum(T firstvalue, T secondvalue, T thirdvalue)
    {
        this.firstvalue = firstvalue;
        this.secondvalue = secondvalue;
        this.thirdvalue = thirdvalue;
    }
    public static T Maxvalue(T firstvalue, T secondvalue, T thirdvalue)
    {

        {
            if (firstvalue.CompareTo(secondvalue) > 0 && firstvalue.CompareTo(thirdvalue) > 0 ||
           if (firstvalue.CompareTo(secondvalue) > 0 && firstvalue.CompareTo(thirdvalue) > 0 ||
           if (firstvalue.CompareTo(secondvalue) > 0 && firstvalue.CompareTo(thirdvalue) > 0
           { }
            return firstvalue;
        }
        if (secondvalue.CompareTo(firstvalue) > 0 && secondvalue.CompareTo(thirdvalue) > 0 ||
           if (secondvalue.CompareTo(firstvalue) >= 0 && secondvalue.CompareTo(thirdvalue) > 0 ||
            if (secondvalue.CompareTo(firstvalue) >= 0 && secondvalue.CompareTo(thirdvalue) > 0 ||


     {
                    return secondvalue;

                }
        if (thirdvalue.CompareTo(firstvalue) > 0 && thirdvalue.CompareTo(secondvalue) > 0 ||
             if (thirdvalue.CompareTo(firstvalue) >= 0 && thirdvalue.CompareTo(secondvalue) > 0 ||
            if (thirdvalue.CompareTo(firstvalue) >= 0 && thirdvalue.CompareTo(secondvalue) > 0
                    {

                    return thirdvalue;
                }
        return default;
    }
    public T Maxmethod()
    {
       T max = GenerixMaximum<T>.Maxvalue(this.firstvalue, this.secondvalue, this.thirdvalue)
        return max;
    }
}