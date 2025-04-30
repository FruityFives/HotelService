using HotelServiceAPI.Models;
using HotelServiceAPI.Repositories;
using Moq;

namespace HotelServiceAPI.Test;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        // arrange
        var room = new Room
        {
            Id = 1,
            RoomNumber = 101,
            Capacity = 2,
            IsAvailable = true
        };

        // act
        var roomNumber = room.RoomNumber;
        var capacity = room.Capacity;
        var isAvailable = room.IsAvailable;
        // assert
        Assert.AreEqual(101, roomNumber);
        Assert.AreEqual(2, capacity);
        Assert.IsTrue(isAvailable);
    }

    [Test]
    public void Test2()
    {
        //GET /hotels/{id}/availability — Checks if rooms are available for booking

        //arrange
        var mockHotel = new Mock<IHotel>();
        mockHotel.Setup(h => h.IsRoomAvailable(1, 101)).ReturnsAsync(true);
        var hotelService = mockHotel.Object;
        //act
        var isAvailable = hotelService.IsRoomAvailable(1, 101).Result;
        //assert
        Assert.IsTrue(isAvailable);





    }
}