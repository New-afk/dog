using UnityEngine;
using UnityEngine.SceneManagement;

public class TelaInicial : MonoBehaviour
{
   
    public void PlayGame()
    {

        SceneManager.LoadScene("Jogo");
    }

    public void QuitGame()
    {

        Debug.Log("Saindo do jogo");
        Application.Quit();
    }
}
