using UnityEngine;

public class triger : MonoBehaviour
{
    [SerializeField] GameObject capofPlayer;
    
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag== "Player")
        {
            capofPlayer.SetActive(true);
        }
    }
}
