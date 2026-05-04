using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class flying : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] float speedy=0f;
    [SerializeField] Transform  player;
    Vector3 PlayerPosition;
    void Awake()
    {
        gameObject.SetActive(false);
    }


    void Start()
    {
        PlayerPosition=player.transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        destroyWhenReached();
        MoveToPlayer();
    }
    void MoveToPlayer()
    {
                transform.position = Vector3.MoveTowards(transform.position,PlayerPosition,speedy*Time.deltaTime);
    }
    void destroyWhenReached()
    {
        if (transform.position== PlayerPosition)
        {
            Destroy(gameObject);
        }
    }
}
