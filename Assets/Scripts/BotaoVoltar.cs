using UnityEngine;
using UnityEngine.SceneManagement;


public class BotaoVoltar : MonoBehaviour
{
   
    public void PlayGame()
    {

        SceneManager.LoadScene("Tela inicial");
    }
}