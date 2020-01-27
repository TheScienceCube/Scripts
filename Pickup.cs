using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public string elementName;
    
    public GameObject rock;
    public GameObject cloud;
    public GameObject crystal;
    public GameObject sprite;
    
    public float value;
    public Vector4 color;

    public class CashPickup : Pickup
    {
        sprite = rock;
        public class Lithium : CashPickup { public Lithium()       { elementName = "Lithium"; value = 6.940f; color = new Vector4(0 / 255, 0 / 255, 0 / 255, 1); }}
        public class Sodium : CashPickup { public Sodium()          { elementName = "Sodium"; value = 22.99f; color = new Vector4(0 / 255, 0 / 255, 0 / 255, 1); }}
        public class Magnesium : CashPickup { public Magnesium() { elementName = "Magnesium"; value = 24.31f; color = new Vector4(0 / 255, 0 / 255, 0 / 255, 1); }}
        public class Aluminum : CashPickup { public Aluminum()    { elementName = "Aluminum"; value = 26.98f; color = new Vector4(0 / 255, 0 / 255, 0 / 255, 1); }}
        public class Silicon : CashPickup { public Silicon()       { elementName = "Silicon"; value = 28.09f; color = new Vector4(0 / 255, 0 / 255, 0 / 255, 1); }}
        public class Potassium : CashPickup { public Potassium() { elementName = "Potassium"; value = 39.10f; color = new Vector4(0 / 255, 0 / 255, 0 / 255, 1); }}
        public class Calcium : CashPickup { public Calcium()       { elementName = "Calcium"; value = 40.08f; color = new Vector4(0 / 255, 0 / 255, 0 / 255, 1); }}
        public class Titanium : CashPickup { public Titanium()    { elementName = "Titanium"; value = 47.87f; color = new Vector4(0 / 255, 0 / 255, 0 / 255, 1); }}
        public class Iron : CashPickup { public Iron()                { elementName = "Iron"; value = 55.85f; color = new Vector4(0 / 255, 0 / 255, 0 / 255, 1); }}
        public class Zinc : CashPickup { public Zinc()                { elementName = "Zinc"; value = 65.38f; color = new Vector4(0 / 255, 0 / 255, 0 / 255, 1); }}
        public class Gallium : CashPickup { public Gallium()       { elementName = "Gallium"; value = 69.72f; color = new Vector4(0 / 255, 0 / 255, 0 / 255, 1); }}
        public class Silver : CashPickup { public Silver()          { elementName = "Silver"; value = 107.9f; color = new Vector4(0 / 255, 0 / 255, 0 / 255, 1); }}
        public class Tin : CashPickup { public Tin()                   { elementName = "Tin"; value = 118.7f; color = new Vector4(0 / 255, 0 / 255, 0 / 255, 1); }}
        public class Tungsten : CashPickup { public Tungsten()    { elementName = "Tungsten"; value = 183.8f; color = new Vector4(0 / 255, 0 / 255, 0 / 255, 1); }}
        public class Osmium : CashPickup { public Osmium()          { elementName = "Osmium"; value = 190.2f; color = new Vector4(0 / 255, 0 / 255, 0 / 255, 1); }}
        public class Gold : CashPickup { public Gold()                { elementName = "Gold"; value = 197.0f; color = new Vector4(0 / 255, 0 / 255, 0 / 255, 1); }}
        public class Platiunum : CashPickup { public Platiunum() { elementName = "Platiunum"; value = 195.1f; color = new Vector4(0 / 255, 0 / 255, 0 / 255, 1); }}
        public class Copper : CashPickup { public Copper()          { elementName = "Copper"; value = 63.55f; color = new Vector4(0 / 255, 0 / 255, 0 / 255, 1); }}
    }
    public class HealthPickup : Pickup
    {
        sprite = gas;
        public class Hydrogen : CashPickup { public Hydrogen()       { elementName = "Hydrogen"; value = 1.008f; color = new Vector4(0 / 255, 0 / 255, 0 / 255, 1); }}
        public class Carbon : CashPickup { public Carbon()             { elementName = "Carbon"; value = 12.01f; color = new Vector4(0 / 255, 0 / 255, 0 / 255, 1); }}
        public class Nitrogen : CashPickup { public Nitrogen()       { elementName = "Nitrogen"; value = 14.01f; color = new Vector4(0 / 255, 0 / 255, 0 / 255, 1); }}
        public class Oxygen : CashPickup { public Oxygen()             { elementName = "Oxygen"; value = 16.00f; color = new Vector4(0 / 255, 0 / 255, 0 / 255, 1); }}
        public class Phosphorus : CashPickup { public Phosphorus() { elementName = "Phosphorus"; value = 31.00f; color = new Vector4(0 / 255, 0 / 255, 0 / 255, 1); }}
        public class Sulfur : CashPickup { public Sulfur()             { elementName = "Sulfur"; value = 32.01f; color = new Vector4(0 / 255, 0 / 255, 0 / 255, 1); }}
    }
    public class NegativePickup : Picku
    {
        sprite = crystal;
        public class Lead : CashPickup { public Lead()               { elementName = "Lead"; value = 207.2f; color = new Vector4(0 / 255, 0 / 255, 0 / 255, 1); }}
        public class Cadmium : CashPickup { public Cadmium()      { elementName = "Cadmium"; value = 112.4f; color = new Vector4(0 / 255, 0 / 255, 0 / 255, 1); }}
        public class Mercury : CashPickup { public Mercury()      { elementName = "Mercury"; value = 200.6f; color = new Vector4(0 / 255, 0 / 255, 0 / 255, 1); }}
        public class Arsenic : CashPickup { public Arsenic()      { elementName = "Arsenic"; value = 74.92f; color = new Vector4(0 / 255, 0 / 255, 0 / 255, 1); }}
        public class Polonium : CashPickup { public Polonium()   { elementName = "Polonium"; value = 209.0f; color = new Vector4(0 / 255, 0 / 255, 0 / 255, 1); }}
        public class Plutonium : CashPickup { public Hydrogen() { elementName = "Plutonium"; value = 244.0f; color = new Vector4(0 / 255, 0 / 255, 0 / 255, 1); }}
        public class Francium : CashPickup { public Francium()   { elementName = "Francium"; value = 223.0f; color = new Vector4(0 / 255, 0 / 255, 0 / 255, 1); }}
        public class Uranium : CashPickup { public Uranium()      { elementName = "Uranium"; value = 238.0f; color = new Vector4(0 / 255, 0 / 255, 0 / 255, 1); }}
        public class Cobalt : CashPickup { public Cobalt()         { elementName = "Cobalt"; value = 58.93f; color = new Vector4(0 / 255, 0 / 255, 0 / 255, 1); }}
        public class Florine : CashPickup { public Florine()      { elementName = "Florine"; value = 19.00f; color = new Vector4(0 / 255, 0 / 255, 0 / 255, 1); }}
        public class Chlorine : CashPickup { public Chlorine()   { elementName = "Chlorine"; value = 35.45f; color = new Vector4(0 / 255, 0 / 255, 0 / 255, 1); }}
    }
}
