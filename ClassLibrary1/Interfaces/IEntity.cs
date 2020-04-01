using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1.Interfaces
{
    public interface IEntity<T>
    {
        T Id { get; set; }
    }
}
