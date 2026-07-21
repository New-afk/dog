using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public RectTransform PanelGameOver;

    public static bool gameover;

    public Vector3 emcima;

    public Vector3 centrodatela;

    void Start()
    {
        
    }

  
    void Update()
    {
        centrodatela = new Vector3(PanelGameOver.position.x, Screen.height/2, PanelGameOver.position.z);
        emcima =  new Vector3(PanelGameOver.position.x, Screen.height*1.5f, PanelGameOver.position.z);

        if(!gameover)
        {
            PanelGameOver.position = emcima;
        }
        else
        {
            PanelGameOver.position = Vector3.Lerp(PanelGameOver.position, centrodatela, Time.deltaTime*10);
        }

        if(Input.GetKeyDown(KeyCode.Space))
        gameover = !gameover;
    }
}
