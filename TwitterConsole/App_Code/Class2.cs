using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Details of the person whose wall it is
/// </summary>
public abstract class Person
{
    string firstName;
    string lastName;

    public Person(string firstName, string lastName)
    {
        this.firstName = firstName;
        this.lastName = lastName;
    }
}