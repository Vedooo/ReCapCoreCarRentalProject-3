using Core.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Dto
{
    public class CarRentDetailDto : IDto
    {
        public int CarId { get; set; }
        public int RentId { get; set; }
        public Nullable<DateTime> ReturnDate { get; set; }
    }
}
