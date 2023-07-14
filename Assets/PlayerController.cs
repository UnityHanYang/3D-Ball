using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        //Vector3 vec = transform.position;
        //vec.x += -x * speed * Time.deltaTime;
        //vec.z += -z * speed * Time.deltaTime;
        //vec.y += transform.position.y * 0;
        //transform.position = vec;   
        transform.position += new Vector3(-x, 0, -z) * speed * Time.deltaTime;

    }
}
