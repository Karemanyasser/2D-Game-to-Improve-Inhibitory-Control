using UnityEngine;
using System.IO;

public class Object : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    

    // static counter shared across all falling objects
    private static int objectCount = 0;

    void Start()
    {
        objectCount++; // increase count whenever a new object is created

        // if this is the 10th object
        if (objectCount % 10 == 0)
        {
            spriteRenderer.color = Color.blue;
        }
        else
        {
            spriteRenderer.color = Color.red;
        }
    }
   
}
