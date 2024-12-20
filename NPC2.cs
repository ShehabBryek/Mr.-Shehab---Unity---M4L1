using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC2 : MonoBehaviour
{
    // Start is called before the first frame update


    // Update is called once per frame
    
    public float speed = 2;


        void Update()
        {

            Vector3 newPosition = transform.position;


            newPosition.z += speed * Time.deltaTime;


            transform.position = newPosition;
        }
    }


