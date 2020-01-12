using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElementScript : MonoBehaviour
{
    void Update() { transform.position = new Vector3(transform.position.x, transform.position.y + 0.05f, transform.position.z); }
    void OnCollisionEnter(Collision collision) { Destroy(this.gameObject); }
}
