using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour
{ 
    public float speed = 5f; // Adjust this in the Inspector

        void Update()
        {
            // Get horizontal input 
            float horizontalInput = Input.GetAxis("Horizontal");

            // Calculate movement direction
            Vector3 movement = new Vector3(horizontalInput, 0f, 0f);

            // Move the object
            transform.position += movement * speed * Time.deltaTime;
        }
}