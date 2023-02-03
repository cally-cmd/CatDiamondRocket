using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropping : MonoBehaviour
{
    public GameObject diamond;
    public GameObject rocket;
    private float gravity;
    // Start is called before the first frame update
    void Start()
    {
        gravity  = -9.8f;
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

            Vector2 pos = new Vector2 (Random.Range(-6.5f, 8), Random.Range(10, 11));

            Physics2D.gravity = new Vector2(0, gravity * GameManager.Instance.level);

            //Instantiate(obj);
            
            Instantiate (obj, pos, Quaternion.identity,transform);

            print("Object created!");
            yield return new WaitForSeconds(Random.Range(1.5f, 3f));
        }
    }
}
