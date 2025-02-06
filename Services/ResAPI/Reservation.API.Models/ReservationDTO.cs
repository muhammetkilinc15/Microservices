using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation.API.Models
{
    public class ReservationDTO
    {
        public int Id { get; set; }
        public int BkgNumber { get; set; }

        public DateTimeOffset? CheckingDate { get; set; }
        public DateTimeOffset? CheckOutDate { get; set; }

        public DateTimeOffset? BkgDate { get; set; }
        public double Amount { get; set; }

    }
}
