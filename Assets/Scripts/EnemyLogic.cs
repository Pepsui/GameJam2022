using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLogic : MonoBehaviour
{
    public float health = 100f;
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Weapon") {
            health -= 5f;
        }
    }

    void Update() {
        if(health == 0) {
            Destroy(gameObject);
        }
    }

}
