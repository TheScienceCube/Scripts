using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    //Misc
    private Rigidbody rb;
    private float state;
    public float cash;
    public float health;

    public GameObject element;
    public Transform spawnPoint;

    public Sprite rock;
    public Sprite gas;
    public Sprite crystal;
    //Upgrades
    public int moneyBoost = 1;
    public int speedBoost = 1;
    public int healthBoost = 1;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        InvokeRepeating("Spawn", 2f, 2f);
    }

    public void Left() { if (state >-2f) { state -= 1; } }
    public void Right() { if (state < 2f) { state += 1; } }

    void Update()
    {
        if (transform.position.x > state) { transform.position = new Vector3(transform.position.x - 0.05f, transform.position.y, transform.position.z); }
        if (transform.position.x < state) { transform.position = new Vector3(transform.position.x + 0.05f, transform.position.y, transform.position.z); }
    }

    void Spawn()
    {
        Debug.Log("Spawn");
        GameObject elementObject = Instantiate(element, spawnPoint.position + new Vector3(Random.Range(-20, 20) * .1f,0,0), transform.rotation);
        elementObject.transform.parent = null;
        int index = Random.Range(1, 36);
        switch (index)
        {
            case 01: elementObject.AddComponent<Pickup.HealthPickup.Hydrogen>(); break;
            case 02: elementObject.AddComponent<Pickup.HealthPickup.Carbon>(); break;
            case 03: elementObject.AddComponent<Pickup.HealthPickup.Nitrogen>(); break;
            case 04: elementObject.AddComponent<Pickup.HealthPickup.Oxygen>(); break;
            case 05: elementObject.AddComponent<Pickup.HealthPickup.Phosphorus>(); break;
            case 06: elementObject.AddComponent<Pickup.HealthPickup.Sulfur>(); break;
            case 07: elementObject.AddComponent<Pickup.CashPickup.Lithium>(); break;
            case 08: elementObject.AddComponent<Pickup.CashPickup.Sodium>(); break;
            case 09: elementObject.AddComponent<Pickup.CashPickup.Magnesium>(); break;
            case 10: elementObject.AddComponent<Pickup.CashPickup.Aluminum>(); break;
            case 11: elementObject.AddComponent<Pickup.CashPickup.Silicon>(); break;
            case 12: elementObject.AddComponent<Pickup.CashPickup.Potassium>(); break;
            case 13: elementObject.AddComponent<Pickup.CashPickup.Calcium>(); break;
            case 14: elementObject.AddComponent<Pickup.CashPickup.Titanium>(); break;
            case 15: elementObject.AddComponent<Pickup.CashPickup.Iron>(); break;
            case 16: elementObject.AddComponent<Pickup.CashPickup.Zinc>(); break;
            case 17: elementObject.AddComponent<Pickup.CashPickup.Gallium>(); break;
            case 18: elementObject.AddComponent<Pickup.CashPickup.Silver>(); break;
            case 19: elementObject.AddComponent<Pickup.CashPickup.Tin>(); break;
            case 20: elementObject.AddComponent<Pickup.CashPickup.Tungsten>(); break;
            case 21: elementObject.AddComponent<Pickup.CashPickup.Osmium>(); break;
            case 22: elementObject.AddComponent<Pickup.CashPickup.Gold>(); break;
            case 23: elementObject.AddComponent<Pickup.CashPickup.Platinum>(); break;
            case 24: elementObject.AddComponent<Pickup.CashPickup.Copper>(); break;
            case 25: elementObject.AddComponent<Pickup.HealthPickup.Lead>(); break;
            case 26: elementObject.AddComponent<Pickup.HealthPickup.Cadmium>(); break;
            case 27: elementObject.AddComponent<Pickup.HealthPickup.Mercury>(); break;
            case 28: elementObject.AddComponent<Pickup.HealthPickup.Arsenic>(); break;
            case 29: elementObject.AddComponent<Pickup.HealthPickup.Polonium>(); break;
            case 30: elementObject.AddComponent<Pickup.HealthPickup.Plutonium>(); break;
            case 31: elementObject.AddComponent<Pickup.HealthPickup.Francium>(); break;
            case 32: elementObject.AddComponent<Pickup.HealthPickup.Uranium>(); break;
            case 33: elementObject.AddComponent<Pickup.HealthPickup.Cobalt>(); break;
            case 34: elementObject.AddComponent<Pickup.HealthPickup.Florine>(); break;
            case 35: elementObject.AddComponent<Pickup.HealthPickup.Chlorine>(); break;
            case 36: elementObject.AddComponent<Pickup.HealthPickup.Cesium>(); break;
        }
        if (index < 7) { elementObject.GetComponent<SpriteRenderer>().sprite = gas; }
        if (index > 6 && index < 25) { elementObject.GetComponent<SpriteRenderer>().sprite = rock; }
        if (index > 24) { elementObject.GetComponent<SpriteRenderer>().sprite = crystal; }
        elementObject.GetComponent<SpriteRenderer>().color = elementObject.GetComponent<Pickup>().color;
    }

    private void OnCollisionEnter(Collision collision)
    {
        health += collision.collider.gameObject.GetComponent<Pickup>().health;
        cash += collision.collider.gameObject.GetComponent<Pickup>().cash;
    }
}
