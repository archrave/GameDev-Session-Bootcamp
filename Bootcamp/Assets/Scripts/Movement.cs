using UnityEngine;

public class Movement : MonoBehaviour
{

    public Rigidbody x;
    void Start()
    {
        x.AddForce(0, 200, 500);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
