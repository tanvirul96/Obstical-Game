using UnityEngine;


public class Spinning_object : MonoBehaviour
{
    [SerializeField] int x_axis=0;
    [SerializeField] int y_axis=0;
    [SerializeField] int z_axis=0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(x_axis,y_axis,z_axis);
       
    }
    void OnCollisionEnter(Collision collision)
    {
         if (collision.gameObject.CompareTag("Player"))
            {
                GetComponent<MeshRenderer>().material.color = Color.red;
                Debug.Log("The player touched the spining!");
          }
    }
}
