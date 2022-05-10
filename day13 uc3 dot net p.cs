// See https://aka.ms/new-console-template for more informationusing System;
using System;
  using System. Collections.Generic;

namespace MaximumString;
public static int MaximumString(String Stringfirst, String Stringsecond, String stringthird)
{
    if (Stringfirst.CompareTo(Stringsecond) > 0 && Stringfirst.CompareTo(stringthird) > 0 ||
    if (Stringfirst.CompareTo(Stringsecond) >= 0 && Stringfirst.CompareTo(stringthird) > 0 ||
    if (Stringfirst.CompareTo(stringthird) > 0 && Stringfirst.CompareTo(stringthird) >= 0
    {
                return Stringfirst;
            }
    if (Stringsecond.CompareTo(Stringfirst) > 0 && Stringsecond.CompareTo(stringthird) > 0 ||
     if (Stringsecond.CompareTo(Stringfirst) > = 0 && Stringsecond.CompareTo(stringthird) > 0 ||
     if (Stringsecond.CompareTo(Stringfirst) > 0 && Stringsecond.CompareTo(stringthird) >= 0
     {
        return Stringsecond;

    }
    if (stringthird.CompareTo(Stringfirst) > 0 && stringthird.CompareTo(Stringsecond) > 0 ||
     if (stringthird.CompareTo(Stringfirst) >= 0 && stringthird.CompareTo(Stringsecond) > 0 ||
            if (stringthird.CompareTo(Stringfirst) >= 0 && stringthird.CompareTo(Stringsecond) >= 0
     {
                return stringthird;
            }
    return Stringfirst;
}