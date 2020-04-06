using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed = 3f;
    float range = 15;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        if (transform.position.z > range) {
            Destroy(gameObject);
        }
        else if (transform.position.z < -range)
        {
            Destroy(gameObject);
        }
        
        
    }
}
