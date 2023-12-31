using UnityEngine;

public class FishController : MonoBehaviour
{
    [SerializeField] public float speed = 5f;
    private Vector2 direction;
    void Start()
    {
        direction = Vector2.one.normalized;
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
        else if (collision.gameObject.tag == "Floor" || collision.gameObject.tag == "Roof")
        {
            direction.y = -direction.y;
        }

    }
}
