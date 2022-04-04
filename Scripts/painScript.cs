using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class painScript : MonoBehaviour
{
    // Start is called before the first frame update
    public int health;
    public Collider2D painTrigger;

    void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Enemy") {
            health -= 5;
        }
    }
}
