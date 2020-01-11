using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public string elementName, atomicSymbol;
    public int cashModifier;
    public int healthModifier;

    public Vector2 collect(int cash, int health)
    {
        int newCash = cash + cashModifier;
        int newHealth = health + healthModifier;
        Vector2 collectVec = new Vector2(newCash, newHealth);
        return collectVec; //
    }

    public class CashPickup : Pickup
    {
        public class Copper : CashPickup
        {
            public Copper() { elementName = "Copper"; atomicSymbol = "Cu"; cashModifier = 5; healthModifier = 0; }
        }

        public class Silver : CashPickup
        {
            public Silver() { elementName = "Silver"; atomicSymbol = "Ag"; cashModifier = 10; healthModifier = 0; }
        }

        public class Gold : CashPickup
        {
            public Gold() { elementName = "Gold"; atomicSymbol = "Au"; cashModifier = 15; healthModifier = 0; }
        }

        public class Platinum : CashPickup
        {
            public Platinum() { elementName = "Platinum"; atomicSymbol = "Pt"; cashModifier = 20; healthModifier = 0; }
        }
    }
    public class HealthPickup : Pickup
    {
        public class Nitrogen : HealthPickup
        {
            public Nitrogen() { elementName = "Nitrogen"; atomicSymbol = "N"; cashModifier = 0; healthModifier = 1; }
        }

        public class Hydrogen : HealthPickup
        {
            public Hydrogen() { elementName = "Hydrogen"; atomicSymbol = "H"; cashModifier = 0; healthModifier = 2; }
        }

        public class Oxygen : HealthPickup
        {
            public Oxygen() { elementName = "Oxygen"; atomicSymbol = "O"; cashModifier = 0; healthModifier = 3; }
        }

        public class Carbon : HealthPickup
        {
            public Carbon() { elementName = "Carbon"; atomicSymbol = "C"; cashModifier = 0; healthModifier = 4; }
        }
    }
    public class NegativePickup : Pickup
    {
        public class Mercury : NegativePickup
        {
            public Mercury() { elementName = "Mercury"; atomicSymbol = "Hg"; cashModifier = 0; healthModifier = -1; }
        }
        public class Arsenic : NegativePickup
        {
            public Arsenic() { elementName = "Arsenic"; atomicSymbol = "As"; cashModifier = 0; healthModifier = -2; }
        }
        public class Plutonium : NegativePickup
        {
            public Plutonium() { elementName = "Plutonium"; atomicSymbol = "Pu"; cashModifier = 0; healthModifier = -3; }
        }
        public class Uranium : NegativePickup
        {
            public Uranium() { elementName = "Uranium"; atomicSymbol = "U"; cashModifier = 0; healthModifier = -4; }
        }
    }
}
