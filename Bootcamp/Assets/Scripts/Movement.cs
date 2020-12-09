using UnityEngine;

public class Movement : MonoBehaviour
    //Change "Movement" 
{

    public Rigidbody x;
    void Start()
    {
       
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        x.AddForce(0, 0, 1000 * Time.deltaTime);
        if(Input.GetKey("d"))
        {
            x.AddForce(500 * Time.deltaTime, 0, 0);
        }
        else if(Input.GetKey("a"))
        {
            x.AddForce(-500 * Time.deltaTime, 0, 0);
        }
    }
}
