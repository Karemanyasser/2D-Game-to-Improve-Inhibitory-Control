using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI; 
using System.IO;

public class Random_Cards : MonoBehaviour
{
    public List<Sprite> spriteList;  // create a list of images
    public Image image1; // to render image1
    public Image image2; // to render image2

    public GameObject pressBtn; // press button
    public GameObject nextBtn; // next button
     public GameObject nextText; // next text


     // assign images index
            int image1Index;
            int image2Index;

    public float updateRate = 800000f; // run every 0.2 seconds
    // public InputHandler inputHandler;
    int score = 0; // test score
    int mistakes = 0; // mistake press

    string textscore; // score and date
    int count = 10; // number of rounds

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("DelayedUpdate", 0.0f, updateRate);
    }

    // Update is called once per frame
    void DelayedUpdate()
    {
        if (spriteList.Count > 1 && count > 0)
        {
            // assign images index
            image1Index = Random_Fun();
            image2Index = Random_Fun();
            // render images
            image1.sprite = spriteList[image1Index];
            image2.sprite = spriteList[image2Index];
            // number of rounds
            count -=1;
            // next button and text not active
            nextBtn.SetActive(false);
            nextText.SetActive(false);
            }
            if(count <= 0){
            // activate after rounds are over and  deactivate pressbutton 
            nextBtn.SetActive(true);
            nextText.SetActive(true);
            pressBtn.SetActive(false);}


        
    }
    int Random_Fun()
    {
        int randomNumber = Random.Range(0, 6);

        return randomNumber;
    }
    public void IfClicked()
        { if (image1Index == image2Index){
            score += 1;
           
        }
        else
        {
            mistakes +=1;
        }
         textscore=InputHandler.CurrentParticipant.AddTestScore(score,mistakes);
            Debug.Log($"Button was pressed! {textscore}");
        }
    public void SaveScore()
    {
        string json = JsonUtility.ToJson(InputHandler.CurrentParticipant);
        File.WriteAllText("D:/carrie works/vr work/2d_IC/TestScore.json", json);
    }

}
