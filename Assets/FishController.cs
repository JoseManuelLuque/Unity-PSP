using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class FishController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Vector3 pos = transform.position;
        pos.y = 0;
        pos.x = 0;
        transform.position = pos; 
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        pos.x += 0.01f; 
        transform.position = pos;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Colision Pez");
    }
}
