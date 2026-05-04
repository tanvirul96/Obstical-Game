using UnityEngine;

public class Scorer : MonoBehaviour
{

    int hites=0;
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "point_hit")
        {
            hites++;
            Debug.Log("You've bumped into a thing this many times: "+ hites);
        }

        if (other.gameObject.tag == "wall")
        {
            
            Debug.Log("playing savely! \n you hit the wall, it's a wrong touch");

        }
        if (other.gameObject.tag == "obstical_object")
        {
            hites--;
            Debug.Log("You've bumped into a obstical object!! this time sccor decrease: "+ hites);
        }
    }
}
