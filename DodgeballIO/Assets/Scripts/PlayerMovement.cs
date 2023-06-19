using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb;
    public GameObject cameri;
    bool grounded = false;
    public float jumpCount = 1;
    [Range(0.0f, 30.0f)][SerializeField] float speed;
    [Range(0.0f, 5.0f)][SerializeField] float jumpForce;
    float initialSpeed;
    // Start is called before the first frame update
    void Start()
    {
        initialSpeed = speed;
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Movement();
    }

    void Movement()
    {
        transform.rotation = Quaternion.Euler(new Vector3(0, cameri.transform.localEulerAngles.y, 0));
        float horiz = Input.GetAxis("Horizontal");
        float uppies = Input.GetAxis("Vertical");
        transform.Translate(speed * Time.deltaTime * uppies * Vector3.forward);
        transform.Translate(speed * Time.deltaTime * horiz * Vector3.right);
        if (Input.GetKeyDown(KeyCode.Space) && jumpCount > 0)
        {
            rb.AddRelativeForce(Vector3.up*jumpForce, ForceMode.Impulse);
            jumpCount--;
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = initialSpeed * 1.5f;
        }
        else
        {
            speed = initialSpeed;
        }
    }

    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("Ground"))
        {
            grounded = true;
            jumpCount = 1;
        }
    }
}
