using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{

    public float speed = 2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

   
    
    

        void Update()
        {

            Vector3 newPosition = transform.position;


        newPosition.z += speed;




        transform.position = newPosition;
        }
    }


