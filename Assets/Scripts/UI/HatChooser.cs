using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HatChooser : MonoBehaviour
{
    // Start is called before the first frame update

    public Image hatShow;
    public SpriteRenderer hat;

    int index = 0;

    public Sprite[] hats;

    // Update is called once per frame
    void Update()
    {

      


        if (index == -1)
        {
            index = hats.Length-1;
        }

        if (index == hats.Length)
        {
            index = 0;
        }
        hatShow.sprite = hats[index];

    }





    public void NextHat() {

            index++;
        
    }

    public void LastHat()
    {
            index--;

    }

    public void SelectHat() {
        
        hat.sprite = hats[index];
        index = 0;
    }
}

