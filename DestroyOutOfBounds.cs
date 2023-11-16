using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{

    private float topBound = 30.0f;
    private float lowerBound = -10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        // if the objects go out of veiw, this destroyes them 
        if(transform.position.z > topBound)
        {
            Destroy(gameObject);
        }else if(transform.position.z < lowerBound)
        {
            Destroy(gameObject);
            
        }

        if(transform.position.x > 41)
        {
            Destroy(gameObject);
        }else if(transform.position.x < -40)
        {
            Destroy(gameObject);
           
        }
    }
}
