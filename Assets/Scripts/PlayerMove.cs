using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour
{ 
    public float speed = 5f; //speed of movement
    float minX = -6.5f; // min x postion for player
    float maxX= 7.5f; // max x postion for player

        void Update()
        {
            // get horizontal input 
            float horizontalInput = Input.GetAxis("Horizontal");

            //  movement direction
            Vector3 movement = new Vector3(horizontalInput, 0f, 0f);

            // move player
            transform.position += movement * speed * Time.deltaTime;
            // move within boundries
             transform.position = new Vector3(Mathf.Clamp(transform.position.x, minX, maxX), transform.position.y, transform.position.z);
        }
}