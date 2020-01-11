using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    //Misc
    private Rigidbody rb;
    private float state;
    public float money;
    public float health;
    //Upgrades
    public int moneyBoost = 1;
    public int speedBoost = 1;
    public int healthBoost = 1;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void Left() { if (state >-2f) { state -= 1; } }
    public void Right() { if (state < 2f) { state += 1; } }

    void Update()
    {
        if (transform.position.x > state) { transform.position = new Vector3(transform.position.x - 0.05f, transform.position.y, transform.position.z); }
        if (transform.position.x < state) { transform.position = new Vector3(transform.position.x + 0.05f, transform.position.y, transform.position.z); }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.tag == "C") { money += Random.Range(100f, 200f) * moneyBoost; }

    }
}
