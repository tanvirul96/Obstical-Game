using System.Xml.Schema;
using UnityEngine;
using UnityEngine.Rendering;

public class player_move : MonoBehaviour
{
     [SerializeField] float Movespeed = 15f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        UserInstraction();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();

    }

    void UserInstraction()
    {
        Debug.Log("WELL COME TO THE GAME");
        Debug.Log("ANY MOVMENT USING FOR WASD OR ARROW KEY");
        Debug.Log("DON'T INTO OBJECT");
    }
    void PlayerMovement()
    {
        float X_value = Input.GetAxis("Horizontal")*Time.deltaTime*Movespeed;
        float Z_value = Input.GetAxis("Vertical")*Time.deltaTime*Movespeed;
         transform.Translate(X_value,0,Z_value);
    }
}
