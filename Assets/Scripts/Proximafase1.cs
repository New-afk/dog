using UnityEngine;
using UnityEngine.SceneManagement;

public class Proximafase1 : MonoBehaviour
{
   
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {

        SceneManager.LoadScene("Jogo4");
        
        }
    }

    void Update()
    {
        
    }
}
