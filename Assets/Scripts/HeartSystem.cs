using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HeartSystem : MonoBehaviour
{
    public int vida;

    public int vidaMaxima;

    public Image[] coracao;

    public Sprite cheio;

    public Sprite vazio;

    void Start()
    {
    
    }

    void Update()
    {
        HealthLogic();
        DeadState();
    }

    void HealthLogic()
    {
        if(vida > vidaMaxima)
        {
            vida = vidaMaxima;
        }

        for (int i = 0; i < coracao.Length; i++)
        {
            if(i< vida)
            {
                coracao[i].sprite = cheio;
            }
            else
            {
                coracao[i].sprite = vazio;
            }
            if(i < vidaMaxima)
            {
                coracao[i].enabled = true;
            }
            else
            {
                coracao[i].enabled = false;
            }
        }

    }

    void DeadState()
    {

        if(vida <= 1)
        {
            // GetComponent<PlayerLogic>().enabled = false;
            Destroy(gameObject, 1.0f);
        }
    }

    // void ResetDead()
    // {
    //     if(vida <= 0)
    //     {
    //         SceneManager.LoadScene("Jogo");
    //     }
    // }
}
