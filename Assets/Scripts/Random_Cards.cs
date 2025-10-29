using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI; // Required for Image component

public class Random_Cards : MonoBehaviour
{
    public List<Sprite> spriteList;  // create a list of images
    public Image image1; // to render image1
    public Image image2; // to render image2

    public GameObject pressBtn; // press button

     // assign images index
            int image1Index;
            int image2Index;

    public float updateRate = 800000f; // run every 0.2 seconds

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("DelayedUpdate", 0.0f, updateRate);

        // pressBtn.onClick.AddListener(OnButtonClicked);

    }

    // Update is called once per frame
    void DelayedUpdate()
    {
        if (spriteList.Count > 1)
        {
            // assign images index
            image1Index = Random_Fun();
            image2Index = Random_Fun();
            // render images
            image1.sprite = spriteList[image1Index];
            image2.sprite = spriteList[image2Index];
            // if (image1Index == image2Index)
            // {
            //     ifClicked(image1Index, image2Index);
            // }
            //     pressBtn.onClick.AddListener(() => OnButtonClicked(image1Index, image2Index));

                // }


            }

        
    }
    int Random_Fun()
    {
        int randomNumber = Random.Range(0, 6);

        return randomNumber;
    }
    public void IfClicked()
        {
            int score = 0;
             if (image1Index == image2Index){
            score += 1;
            Debug.Log("Button was pressed!");
        }
        }

}
