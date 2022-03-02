using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MyGame
{ 
public class Player : MonoBehaviour
{
       [SerializeField] private float playerSpeed;
       [SerializeField] private Vector3 direction;
       public Rigidbody rb;
       public float jumpAmount;
       public float gravityScale;
      

    void Awake()
    {
            playerSpeed = 2;
            gravityScale = 3;

    }



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            direction.z = Input.GetAxis("Vertical");
            direction.x = Input.GetAxis("Horizontal");
            if (Input.GetKeyDown(KeyCode.Space))
            {
                rb.AddForce(Vector2.up * jumpAmount, ForceMode.Impulse);
            }
        }

    void FixedUpdate()
        {
            var speed = direction * playerSpeed * Time.deltaTime;
            transform.Translate(speed);

            jumpAmount = 10; 
            rb.AddForce(Physics.gravity * (gravityScale - 1) * rb.mass);
        }
    }
}