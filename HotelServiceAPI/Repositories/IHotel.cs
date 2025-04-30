using HotelServiceAPI.Models;

namespace HotelServiceAPI.Repositories
{
    public interface IHotel
    {
        Task<Room?> GetRoomById(int hotelId, int roomId);
        Task<IEnumerable<Room>> GetRoomsByHotelId(int hotelId);
        Task<bool> IsRoomAvailable(int hotelId, int roomId);


    }

}
