using PetCareManagementSystem.DAL.DAO;
using PetCareManagementSystem.DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCareManagementSystem.BLL
{
    public class BookingDetailsBUS
    {
        private BookingDetailsDAO _dao;
        public BookingDetailsBUS() 
        {
            _dao = new BookingDetailsDAO(); 
        }

        public bool DeleteBookingDetails(int bookingId)
        {
            return _dao.DeleteBookingDetails(bookingId);
        }

        public bool CreateBookingDetails(BookingDetails bookingDetails)
        {
            return _dao.CreateBookingDetails(bookingDetails.BookingId, bookingDetails.ServiceId, bookingDetails.Price, bookingDetails.Discount);
        }
    }
}
