using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropping : MonoBehaviour
{
    public GameObject diamond;
    public GameObject rocket;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DropObjects() {
        StartCoroutine("DropObject");
    }

    GameObject WhichObject() {
        int id = Random.Range(0, 2) * 10;
        print(id);
        if (id <= 5f) {
            return diamond;
        } else {
            return rocket;
        }
    }

    public IEnumerator DropObject() {
        for (;;) {
            GameObject obj = WhichObject();
            Instantiate(obj);
            print("Object created!");
            yield return new WaitForSeconds(Random.Range(1.5f, 3f));
        }
    }
}
