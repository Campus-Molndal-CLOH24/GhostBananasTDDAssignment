using GhostBananasTDDAssignment.Data;
using Xunit;

namespace GhostBananasTDDAssignmentTest.Data;

public class RoomTest
{
    [Fact]
    public void AddExitTest()
    {
        // Arrange 
        var room = new Room();
        var direction = "norr";
        
        // Act
        room.AddExit(direction, new Room());
        
        // Assert
        Assert.Equal(1, room.Exits.Count);
        
        
        
        
    }
    
}