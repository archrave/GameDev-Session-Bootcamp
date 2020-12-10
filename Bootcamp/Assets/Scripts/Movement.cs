using UnityEngine;

public class Movement : MonoBehaviour
    //Change "Movement" 
{

    public Rigidbody x;
    void Start()
    {
        x = GetComponent<Rigidbody>();
    }

    private void FixedUpdate() {
        x.AddForce(0, 0, fwdForce*Time.deltaTime);
        if(Input.GetKey("a"))
        {
            x.AddForce(-sideForce, 0,0);
        }
        if(Input.GetKey("d"))
        {
            x.AddForce(sideForce,0,0);
        }
    }
}
