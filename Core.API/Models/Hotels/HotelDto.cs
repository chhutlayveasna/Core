using System.ComponentModel.DataAnnotations.Schema;

namespace Core.API.Models.Hotels
{
    public class HotelDto : BaseHotelDto
    {
        public int Id { get; set; }
    }
}