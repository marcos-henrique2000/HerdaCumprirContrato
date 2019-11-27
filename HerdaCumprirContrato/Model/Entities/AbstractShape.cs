using System;
using System.Collections.Generic;
using System.Text;
using HerdaCumprirContrato.Enum;

namespace HerdaCumprirContrato.Model.Entities
{
    abstract class AbstractShape : IShape
    {
        public Color Color { get; set; }

        public abstract double Area();
    }
}
