using Unity.VisualScripting;
using UnityEngine;


public class ObjectHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        // Check if the object that hit this obstacle has the tag "Player"
        if (collision.gameObject.CompareTag("Player"))
        {
            GetComponent<MeshRenderer>().material.color = Color.red;
            Debug.Log("The player touched the wall!");
        }
    }
}
