using System.Collections.Generic;
using System.Dynamic;
using System.Security.Cryptography.X509Certificates;

class Player
{
    // auto property
    public Room CurrentRoom { get; set; }

    //fields
    public int Health { get; private set; }

    // constructor
    public Player()
    {

        CurrentRoom = null;
        Health = 100;
    }


    public int Damage(int amount)
    {
        Health -= amount;
        if (Health < 0)
        {
            Health = 0;
        }
        return Health;
    }
    public int Heal(int amount)
    {
        Health += amount;
        if (Health > 100)
        {
            Health = 100;
        }
        return Health;
    }
    public bool IsAlive()
    {

        if (Health == 0)
        {
            return false;
        }
        return true;
    }
}