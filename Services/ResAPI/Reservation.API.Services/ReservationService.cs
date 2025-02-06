using Reservation.API.Infsracture;
using Reservation.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation.API.Services
{
    public class ReservationService : IReservationServices
    {
        public async Task<ReservationDTO> GetResByBKNumber(int bkgNumber)
        {
            return await Task.FromResult(new ReservationDTO
            {
                Id = new Random().Next(1, 100),
                BkgNumber = bkgNumber,
                CheckingDate = DateTimeOffset.Now,
                CheckOutDate = DateTimeOffset.Now.AddDays(2),
                BkgDate = DateTimeOffset.Now,
                Amount = new Random().NextDouble() * (2000.0 - 1.0) + 1.0
            });
        }
    }
}
