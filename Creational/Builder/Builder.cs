using System;
using System.Collections.Generic;
using System.Text;

namespace Creational.Builder
{
    public abstract class Builder
    {
        public abstract void BuildPartA();
        public abstract void BuildPartB();
        public abstract void BuildPartC();
        public abstract Diet GetResult();
    }
}
