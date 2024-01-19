using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed = 5.0f;
    Rigidbody rb;
    private float Xinput;
    private float Yinput;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    
    void Update()
    {
        Xinput = Input.GetAxis("Horizontal");
        Yinput = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        rb.AddForce(Xinput * speed,0, Yinput * speed);
    }
}
