﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Animator animator;
    private Vector2 SPEED = new Vector2();
    public Vector2 SPEED_para = new Vector2();
    private int angle = 2;
    private float counting = 0;

    void Start()
    {
        animator = GetComponent(typeof(Animator)) as Animator;
        animator.Play("player Idle");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("d"))
        {
            SPEED.x = SPEED_para.x;
            SPEED.y = 0;
            animator.Play("player rightwalk");
            angle = 1;
        }
        else if (Input.GetKey("a"))
        {

            SPEED.x = -1 * SPEED_para.x;
            SPEED.y = 0f;
            animator.Play("player leftwalk");
            angle = 3;
        }
        else if (Input.GetKey("w"))
        {

            SPEED.x = 0f;
            SPEED.y = SPEED_para.y;
            animator.Play("player backwalk");
            angle = 2;
        }
        else if (Input.GetKey("s"))
        {

            SPEED.x = 0f;
            SPEED.y = -1 * SPEED_para.y;
            animator.Play("player walk");
            angle = 0;
        }
        else
        {
            SPEED.x = 0f;
            SPEED.y = 0f;
            switch (angle)
            {
                case 0:
                    animator.Play("Enemy Backidle");
                    break;
                case 1:
                    animator.Play("Enemy Rightidle");
                    break;
                case 2:
                    animator.Play("Enemy Idle");
                    break;
                case 3:
                    animator.Play("Enemy Leftidle");
                    break;
            }
        }
                
        Vector2 Position = transform.position;
        Position.y += SPEED.y * Time.deltaTime;
        Position.x += SPEED.x * Time.deltaTime;
        transform.position = Position;


    }



    // 移動関数

    void Move()
    {

        // 現在位置をPositionに代入

        Vector2 Position = transform.position;

        // 左キーを押し続けていたら

        if (Input.GetKey("a"))
        {

            // 代入したPositionに対して加算減算を行う

            Position.x -= SPEED.x;

        }
        else if (Input.GetKey("d"))
        { // 右キーを押し続けていたら

            // 代入したPositionに対して加算減算を行う

            Position.x += SPEED.x;

        }
        else if (Input.GetKey("w"))
        { // 上キーを押し続けていたら

            // 代入したPositionに対して加算減算を行う

            Position.y += SPEED.y;

        }
        else if (Input.GetKey("s"))
        { // 下キーを押し続けていたら

            // 代入したPositionに対して加算減算を行う

            Position.y -= SPEED.y;

        }

        // 現在の位置に加算減算を行ったPositionを代入する


    }

}

