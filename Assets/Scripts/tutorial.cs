using UnityEngine;
using UnityEngine.SceneManagement;

public class tutorial : MonoBehaviour
{
   
    public void PlayGame()
    {

        SceneManager.LoadScene("Tutorial");
    }
}