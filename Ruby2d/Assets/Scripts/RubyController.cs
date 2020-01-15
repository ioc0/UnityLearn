using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubyController : MonoBehaviour
{
    public float speed = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       

        //
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Debug.Log(horizontal);
        Vector2 position = transform.position;

        position.x += horizontal + speed * Time.deltaTime;
        position.y += vertical + speed * Time.deltaTime;

        transform.position = position;
        Debug.Log(position);
    }
}
