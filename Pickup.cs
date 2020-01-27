using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public string elementName;
    public float health;
    public float cash;
    public Vector4 color;

    public class CashPickup : Pickup
    {
        public class Lithium : CashPickup { public Lithium() { elementName = "Lithium"; cash = 6.940f; color = new Vector4(0.918f, 0.820f, 0.863f, 1); } }
        public class Sodium : CashPickup { public Sodium() { elementName = "Sodium"; cash = 22.99f; color = new Vector4(0.976f, 0.796f, 0.612f, 1); } }
        public class Magnesium : CashPickup { public Magnesium() { elementName = "Magnesium"; cash = 24.31f; color = new Vector4(0.706f, 0.655f, 0.839f, 1); } }
        public class Aluminum : CashPickup { public Aluminum() { elementName = "Aluminum"; cash = 26.98f; color = new Vector4(0.851f, 0.851f, 0.851f, 1); } }
        public class Silicon : CashPickup { public Silicon() { elementName = "Silicon"; cash = 28.09f; color = new Vector4(0.400f, 0.400f, 0.400f, 1); } }
        public class Potassium : CashPickup { public Potassium() { elementName = "Potassium"; cash = 39.10f; color = new Vector4(0.714f, 0.843f, 0.659f, 1); } }
        public class Calcium : CashPickup { public Calcium() { elementName = "Calcium"; cash = 40.08f; color = new Vector4(0.953f, 0.953f, 0.953f, 1); } }
        public class Titanium : CashPickup { public Titanium() { elementName = "Titanium"; cash = 47.87f; color = new Vector4(0.788f, 0.855f, 0.973f, 1); } }
        public class Iron : CashPickup { public Iron() { elementName = "Iron"; cash = 55.85f; color = new Vector4(0.718f, 0.718f, 0.718f, 1); } }
        public class Zinc : CashPickup { public Zinc() { elementName = "Zinc"; cash = 65.38f; color = new Vector4(0.851f, 0.824f, 0.914f, 1); } }
        public class Gallium : CashPickup { public Gallium() { elementName = "Gallium"; cash = 69.72f; color = new Vector4(0.835f, 0.651f, 0.741f, 1); } }
        public class Silver : CashPickup { public Silver() { elementName = "Silver"; cash = 107.9f; color = new Vector4(0.937f, 0.937f, 0.937f, 1); } }
        public class Tin : CashPickup { public Tin() { elementName = "Tin"; cash = 118.7f; color = new Vector4(0.800f, 0.800f, 0.800f, 1); } }
        public class Tungsten : CashPickup { public Tungsten() { elementName = "Tungsten"; cash = 183.8f; color = new Vector4(0.988f, 0.898f, 0.804f, 1); } }
        public class Osmium : CashPickup { public Osmium() { elementName = "Osmium"; cash = 190.2f; color = new Vector4(0.427f, 0.620f, 0.922f, 1); } }
        public class Gold : CashPickup { public Gold() { elementName = "Gold"; cash = 197.0f; color = new Vector4(1.000f, 0.851f, 0.400f, 1); } }
        public class Platinum : CashPickup { public Platinum() { elementName = "Platinum"; cash = 195.1f; color = new Vector4(0.886f, 0.914f, 0.957f, 1); } }
        public class Copper : CashPickup { public Copper() { elementName = "Copper"; cash = 63.55f; color = new Vector4(0.965f, 0.698f, 0.420f, 1); } }
    }
    public class HealthPickup : Pickup
    {
        public class Hydrogen : HealthPickup { public Hydrogen() { elementName = "Hydrogen"; health = 1.008f; color = new Vector4(1.000f, 0.949f, 0.800f, 1); } }
        public class Carbon : HealthPickup { public Carbon() { elementName = "Carbon"; health = 12.01f; color = new Vector4(0.263f, 0.263f, 0.263f, 1); } }
        public class Nitrogen : HealthPickup { public Nitrogen() { elementName = "Nitrogen"; health = 14.01f; color = new Vector4(0.463f, 0.647f, 0.686f, 1); } }
        public class Oxygen : HealthPickup { public Oxygen() { elementName = "Oxygen"; health = 16.00f; color = new Vector4(0.788f, 0.855f, 0.973f, 1); } }
        public class Phosphorus : HealthPickup { public Phosphorus() { elementName = "Phosphorus"; health = 31.00f; color = new Vector4(0.902f, 0.722f, 0.686f, 1); } }
        public class Sulfur : HealthPickup { public Sulfur() { elementName = "Sulfur"; health = 32.01f; color = new Vector4(1.000f, 0.851f, 0.400f, 1); } }
        //Toxic
        public class Lead : HealthPickup { public Lead() { elementName = "Lead"; health = -207.2f; color = new Vector4(0.027f, 0.216f, 0.388f, 1); } }
        public class Cadmium : HealthPickup { public Cadmium() { elementName = "Cadmium"; health = -112.4f; color = new Vector4(0.600f, 0.600f, 0.600f, 1); } }
        public class Mercury : HealthPickup { public Mercury() { elementName = "Mercury"; health = -200.6f; color = new Vector4(0.424f, 0.357f, 0.357f, 1); } }
        public class Arsenic : HealthPickup { public Arsenic() { elementName = "Arsenic"; health = -74.92f; color = new Vector4(0.522f, 0.125f, 0.047f, 1); } }
        public class Polonium : HealthPickup { public Polonium() { elementName = "Polonium"; health = -209.0f; color = new Vector4(0.902f, 0.569f, 0.220f, 1); } }
        public class Plutonium : HealthPickup { public Plutonium() { elementName = "Plutonium"; health = -244.0f; color = new Vector4(0.800f, 0.800f, 0.800f, 1); } }
        public class Francium : HealthPickup { public Francium() { elementName = "Francium"; health = -223.0f; color = new Vector4(0.867f, 0.494f, 0.420f, 1); } }
        public class Uranium : HealthPickup { public Uranium() { elementName = "Uranium"; health = -238.0f; color = new Vector4(0.129f, 1.000f, 0.345f, 1); } }
        public class Cobalt : HealthPickup { public Cobalt() { elementName = "Cobalt"; health = -58.93f; color = new Vector4(0.235f, 0.471f, 0.847f, 1); } }
        public class Florine : HealthPickup { public Florine() { elementName = "Florine"; health = -19.00f; color = new Vector4(1.000f, 0.949f, 0.800f, 1); } }
        public class Chlorine : HealthPickup { public Chlorine() { elementName = "Chlorine"; health = -35.45f; color = new Vector4(0.788f, 0.855f, 0.973f, 1); } }
        public class Cesium : HealthPickup { public Cesium() { elementName = "Cesium"; health = -132.9f; color = new Vector4(0.400f, 0.400f, 0.400f, 1); } }
    }
}
