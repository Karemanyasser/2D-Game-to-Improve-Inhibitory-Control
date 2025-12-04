using Unity.VisualScripting;
using UnityEditor.Callbacks;
using UnityEngine;
using System.IO;

public class Bullet : MonoBehaviour
{
    public float bulletSpeed = 15f;
    public Rigidbody2D rb;
    string textscore; // score and date

    private void FixedUpdate()
    {
        rb.linearVelocity = Vector2.up * bulletSpeed; // bullet spead and direction
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
         // Destroy the object that collided with
        Destroy(collision.gameObject);
        SpriteRenderer sr = collision.gameObject.GetComponentInChildren<SpriteRenderer>(); // get the color of the object which is the color of the sprite that is a child to the object
        if(sr.color == Color.red) // if color is red save score
        {
            InputHandler.CurrentParticipant.GameScore += 1;
            textscore=InputHandler.CurrentParticipant.AddGameScore(InputHandler.CurrentParticipant.GameScore);
            
            Debug.Log($"Button was pressed! {textscore}");
            SaveScore();
        }
        
    }
     public void SaveScore()
    {
        string json = JsonUtility.ToJson(InputHandler.CurrentParticipant);
        File.WriteAllText("D:/carrie works/vr work/2d_IC/GameScore.json", json);
    }


}
