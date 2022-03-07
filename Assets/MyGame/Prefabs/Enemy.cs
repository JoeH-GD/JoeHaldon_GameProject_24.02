using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MyGame { 
public class Enemy : MonoBehaviour
{

        [SerializeField] private float playerSpeed;
        [SerializeField] private Vector3 direction;
        [SerializeField] private float rotation;
        

        void Awake ()
        {
            
        }
    // Start is called before the first frame update
        void Start()
          {
        
          }

    // Update is called once per frame
       void Update()
       {
      
       }

       void FixedUpdate()
        {

        }
}
}