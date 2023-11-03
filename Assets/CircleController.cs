using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
     Vector3 pos = transform.position;
        pos.y = 0;
        transform.position = pos;   
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        pos.x += 0.01f; 
        transform.position = pos;

    }
}
