using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MyGame
{ 
public class Player : MonoBehaviour
{
       [SerializeField] private float playerSpeed;
       [SerializeField] private Vector3 direction;
       
        //ссылка на компонент, который добавляет физику
       public Rigidbody rb;

       //Поля для силы прыжка и силы гравитации (чтобы не было парения в воздухе)
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
            //получаем направление движения согласно вводу игрока
            direction.z = Input.GetAxis("Vertical");
            direction.x = Input.GetAxis("Horizontal");

            //обрабатываем инпут
            if (Input.GetKeyDown(KeyCode.Space))
            {
                //добавляем прыжок с вектором вверх, силой прыжка и импульсом
                rb.AddForce(Vector2.up * jumpAmount, ForceMode.Impulse);
            }
        }

    void FixedUpdate()
        {
            // получаем скорость движения при помощи направления, заданной скорости, распределенной по времени
            var speed = direction * playerSpeed * Time.deltaTime;
            transform.Translate(speed);

            jumpAmount = 10; 

            //добавляем гравитации
            rb.AddForce(Physics.gravity * (gravityScale - 1) * rb.mass);
        }
    }
}