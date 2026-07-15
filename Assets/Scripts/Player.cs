using UnityEngine;
using UnityEngine.InputSystem;


public class Player : MonoBehaviour
{

    Vector3 direcaoPlayer;

    public float velocidadePlayer = 4f;

    public InputAction controlePlayer;

    // public InputAction ataquePlayer;

    // public Animator animPlayer;

    // public bool isWalking = false;

    private void OnEnable()
    {

        controlePlayer.Enable();
        // ataquePlayer.Enable();
        // ataquePlayer.performed += Attack;

    }

    private void OnDisable()
    {

        controlePlayer.Disable();
        // ataquePlayer.Disable();

    }

    void Update()
    {

       direcaoPlayer = controlePlayer.ReadValue<Vector2>();

       transform.Translate(direcaoPlayer * velocidadePlayer * Time.deltaTime);

       if(direcaoPlayer.x != 0 || direcaoPlayer.z != 0)
        {

            // isWalking = true;
            // animPlayer.SetBool("estaAndando", true);

        }
        else
        {

            // isWalking = false;
            // animPlayer.SetBool("estaAndando", false);
         }
    }

    // public void Attack(InputAction.CallbackContext context)
    // {

    //     animPlayer.SetTrigger("ataque");

    // }


}

