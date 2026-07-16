using UnityEngine;

public class Inimigo : MonoBehaviour
{
    Rigidbody2D     inimigo;
    [SerializeField] float speed = 2f;
    [SerializeField] Transform point1, point2;
    [SerializeField] LayerMask layer;
    [SerializeField] bool isColliding;

    private void Awake()
    {
        inimigo = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        
    }
    private void FixedUpdate()
    {
        inimigo.linearVelocity = new Vector2(speed, inimigo.linearVelocity.y);

        isColliding = Physics2D.Linecast(point1.position, point2.position, layer);

        Debug.DrawLine(point1.position, point2.position, Color.blue);

        if (isColliding)
        {
            transform.localScale = new Vector2(transform.localScale.x *-1, transform.localScale.y);
            speed *= -1;
        }
    }

   
    void Update()
    {
        
    }
}
