using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] Transform Player;
    [SerializeField] float minX, maxX;

    void Start()
    {
        
        Player = GameObject.FindWithTag("Player").transform;

    }

    void FixedUpdate()
    {
        
        if (Player.position.x >= transform.position.x)
            transform.position = new Vector3(Player.position.x, Player.position.y, transform.position.z);

        transform.position = new Vector3(Mathf.Clamp(transform.position.x, minX, maxX), 1, transform.position.z);

    }
}
