﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementTopDownScript : MonoBehaviour
{
    public Animator animator;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"),Input.GetAxis("Vertical"), 0f);

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Magnitude", movement.magnitude);

        this.transform.position = transform.position + movement * Time.deltaTime * 3f;


    }
}
