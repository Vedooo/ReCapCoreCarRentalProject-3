using Core.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Customer : IEntites
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string CompanyName { get; set; }

    }
}
