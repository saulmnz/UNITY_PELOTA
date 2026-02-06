using UnityEngine;

public class CameraController : MonoBehaviour

{
    // METO EL JUGADOR
    public GameObject player; 
    private Vector3 offset;

    void Start()
    {
        // DISTANCIA ENTRE CÁMARA Y JUGADOR
        offset = transform.position - player.transform.position;
    }

    void LateUpdate()
    {
    
        transform.position = player.transform.position + offset;
    }
}