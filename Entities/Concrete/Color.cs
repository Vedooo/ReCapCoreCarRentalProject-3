using Core.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Color : IEntites
    {
        public int ColorId { get; set; }
        public string ColorName { get; set; }

    }
}
