using UnityEngine;
 
public class CamaraConMovimientoController : MonoBehaviour
{
    public GameObject player;
    public float moveSpeed = 10f;
    public float lookSpeed = 500f;
 
    void Update()
    {
        // Movimiento con teclas AWSD
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
 
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        player.transform.Translate(movement * moveSpeed * Time.deltaTime, Space.Self);
 
        // Rotación con el mouse
        float mouseX = Input.GetAxis("Mouse X") * lookSpeed * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * lookSpeed * Time.deltaTime;
 
        player.transform.Rotate(Vector3.up * mouseX); // Rotar al jugador
 
        // Cambio de cámara
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            transform.position = player.transform.position + new Vector3(0, 1.6f, 0);
            transform.rotation = player.transform.rotation;
        }
 
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            transform.position = player.transform.position + new Vector3(0, 2, -5);
            transform.LookAt(player.transform);
        }
 
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            transform.position = player.transform.position + new Vector3(0, 10, 0);
            transform.rotation = Quaternion.Euler(90, 0, 0);
        }
    }
}