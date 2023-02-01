using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basket : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col) {
        print("Caught an object");
        if (col.gameObject.tag  == "Diamond") {
            GameManager.Instance.IncScore(1);
            print("Score increased by 1");
        }
        if (col.gameObject.tag == "Rocket") {
            print("BOOM!");
            GameManager.Instance.IncScore(-5);
        }
        Destroy(col.gameObject);
    }    
}
