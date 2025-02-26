using System.Collections.Generic;

class Player
{
    // auto property
    public Room currentRoom { get; set; }
    // constructor
    public Player()
    {
        currentRoom = null;
    }
}