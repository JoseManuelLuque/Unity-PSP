using System;
using Unity.VisualScripting;
using UnityEngine;

public class DoriController : MonoBehaviour
{
    [SerializeField]public float speed = 5f;
    [SerializeField] public float push = 5f;
    private Vector2 direction;
    void Start()
    {
        direction = Vector2.one.normalized;
        direction.y = direction.y + push;
    }

    void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Vertical Wall")
        {
            direction.x = -direction.x;
        }
        else if (collision.gameObject.tag == "Floor")
        {
            direction.y = -direction.y + push;
        }
        else if (collision.gameObject.tag =="Roof")
        {
            direction.y = -direction.y;
        }
    }
}
