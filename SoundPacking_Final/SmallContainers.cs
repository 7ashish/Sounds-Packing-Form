using System;
using System.Collections.Generic;

public class Pair<F, S> : IComparable<Pair<F, S>>, IComparable where S : IComparable
{
    public F First;
    public S Second;
    public int CompareTo(Pair<F, S> other)
    {
        return Second.CompareTo(other.Second)*-1;
    }
    public int CompareTo(object obj)
    {
        if(obj.GetType() == typeof(Pair<F, S>))
        {
            Pair<F, S> p = obj as Pair<F, S>;
            return Second.CompareTo(p.Second) * -1;
        }
        return 0;
    }
}