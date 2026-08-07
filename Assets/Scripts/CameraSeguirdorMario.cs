using UnityEngine;

public class CameraSeguidorMario : MonoBehaviour
{
    [Header("Configurações de Alvo")]
    public Transform player;
    public Vector3 offset = new Vector3(3f, 0f, -10f);

    [Header("Limites da Câmera")]
    public float limiteMinX = 0f;
    public float limiteMaxX = 100f;

    private float posicaoCameraX;
    private bool cameraInicializada = false;

    void Start()
    {
        if (player != null)
        {
            InicializarCamera();
        }
    }

    void LateUpdate()
    {
        if (player == null) return;

        if (!cameraInicializada)
        {
            if (player.position == Vector3.zero)
                return;

            InicializarCamera();
        }

        // Posição desejada da câmera
        float posicaoDesejadaX = player.position.x + offset.x;

        // A câmera nunca volta para a esquerda
        posicaoCameraX = Mathf.Max(posicaoCameraX, posicaoDesejadaX);

        // Aplica os limites mínimo e máximo
        posicaoCameraX = Mathf.Clamp(posicaoCameraX, limiteMinX, limiteMaxX);

        transform.position = new Vector3(
            posicaoCameraX,
            transform.position.y,
            transform.position.z
        );
    }

    private void InicializarCamera()
    {
        posicaoCameraX = Mathf.Clamp(
            player.position.x + offset.x,
            limiteMinX,
            limiteMaxX
        );

        transform.position = new Vector3(
            posicaoCameraX,
            transform.position.y,
            transform.position.z
        );

        cameraInicializada = true;
    }
}