using UnityEngine;

public class Object : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;

    // Static counter shared across all spawned objects
    private static int objectCount = 0;

    void Start()
    {
        objectCount++; // Increase count whenever a new object is created

        // If this is the 10th object
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
