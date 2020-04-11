using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Interactables : MonoBehaviour
{
    
    public GameObject player;
    public SpriteRenderer Char;
    public GameObject panel;

    bool interacted = false;
    bool inzone = false;

    public void Start()
    {
        panel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //inzone = false;
        if (inzone == true)
        {
            Char.enabled = true;
            if (Input.GetKey(KeyCode.F)) 
            {
                interacted = true;
            }
        }
        else {
            Char.enabled = false;

        }

        PortalI(interacted);
 

    }


    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag(player.tag))
        {
            inzone = true;
        }
    }


    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag(player.tag))
        {
            inzone = false;
        }
    }


    void PortalI(bool interacted) {

        if (interacted == true) {
        
        }


    }


}
