using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField]float droping_time=3f;
    MeshRenderer mr;
    Rigidbody rd;
    void Start()
    {
        mr = GetComponent<MeshRenderer>();
        mr.enabled=false;
        rd = GetComponent<Rigidbody>();
        rd.useGravity= false;
        
    }

   
    void Update()
    {
        if (Time.time > droping_time)
        {
          rd.useGravity= true;
          mr.enabled=true;
          //Debug.Log("the object is down.. be safe ");
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            mr.material.color=Color.red;
            print("the Player touch with droping object");
        }
    }
}
