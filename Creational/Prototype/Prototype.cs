using System;
using System.Collections.Generic;
using System.Text;

namespace Creational.Prototype
{
    public abstract class Prototype
    {
        public int Id { get; private set; }
        public Prototype(int id)
        {
            this.Id = id;
        }
        public abstract Prototype Clone();
    }
}
