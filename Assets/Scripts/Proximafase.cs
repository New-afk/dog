using UnityEngine;
using UnityEngine.SceneManagement;

public class Proximafase : MonoBehaviour
{
   
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {

        SceneManager.LoadScene("Jogo2");
        
        }
    }

    void Update()
    {
        
    }
}
