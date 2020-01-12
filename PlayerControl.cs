using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    //Misc
    private Rigidbody rb;
    private float state;
    public int cash;
    public int health;

    public GameObject element;
    public Transform spawnPoint;
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

    Vector2 returnVector;

    void Spawn()
    {
        Debug.Log("Spawn");
        GameObject elementObject = Instantiate(element, spawnPoint.position + new Vector3(Random.Range(-20, 20) * .1f,0,0), transform.rotation);
        elementObject.transform.parent = null;
        elementObject.AddComponent<Pickup.CashPickup.Gold>();
        elementObject.GetComponent<SpriteRenderer>().color = GetComponent<Pickup.CashPickup.Gold>().color;
    }

    private void OnCollisionEnter(Collision collision)
    {
        int healthModifier = collision.collider.gameObject.GetComponent<Pickup>().healthModifier;
        int cashModifier = collision.collider.gameObject.GetComponent<Pickup>().cashModifier;

        cash += cashModifier;
        health += healthModifier;
    }
}
