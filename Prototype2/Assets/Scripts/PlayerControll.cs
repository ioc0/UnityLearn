using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControll : MonoBehaviour
{
    // Start is called before the first frame update
    float controls;
    public float speed = 10f;
    public float xRange = 15f;
    public GameObject projectilePrefab;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) )
        {
            Instantiate(projectilePrefab,transform.position,projectilePrefab.transform.rotation);
        }
        controls = Input.GetAxis("Horizontal");
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        transform.Translate(Vector3.right *controls* Time.deltaTime * speed);
        Debug.Log(controls);
    }
}
