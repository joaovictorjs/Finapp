using System;
using System.Runtime;

namespace Finapp.Domain;

public class Description
{
    public string Value { get; private set; }

    public Description(string value)
    {
        Value = value;
    }

    public static implicit operator Description(string description) => new Description(description);
}
