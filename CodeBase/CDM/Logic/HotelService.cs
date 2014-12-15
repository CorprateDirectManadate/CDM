using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoNise.Service;
using CDM.Domain;
using CDM.Service;

namespace CDM.Logic
{
    public class HotelService:IHotelService
    {
        private readonly IRepository<Hotel, int> _hotelRepo;

        public HotelService(IRepository<Hotel, int> hotelRepo)
        {
            _hotelRepo = hotelRepo;
        }

        public int CreateOrganization(Hotel hotel)
        {
            _hotelRepo.Add(hotel);
            return hotel.Id;
        }
    }
}
