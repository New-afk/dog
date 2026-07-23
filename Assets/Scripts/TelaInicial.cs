using UnityEngine;
using UnityEngine.SceneManagement;

public class TelaInicial : MonoBehaviour
{
   
    public void PlayGame()
    {

        SceneManager.LoadScene("Selecao");
    }

    public void QuitGame()
    {

        Debug.Log("Saindo do jogo");
        Application.Quit();
    }
}
