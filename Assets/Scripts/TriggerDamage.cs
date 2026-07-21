using UnityEngine;

public class TriggerDamage : MonoBehaviour
{
    public HeartSystem heart;
    // public PlayerLogic player;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            heart.vida--;
            // player.anim.SetTrigger("TaDamage");
        }
    }
}
