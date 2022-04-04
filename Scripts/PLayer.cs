using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class PLayer : MonoBehaviour
{  
    [SerializeField] float health;
    
    // Start is called before the first frame update
    private void Start()
    {
        health = 100f;
    }


    void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Enemy") {
            health -= 5f;
        }
    }
}
