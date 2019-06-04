using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationSample : MonoBehaviour
{
    // Start is called before the first frame update
    Animator animator;
    public Vector2 SPEED = new Vector2(0.5f, 0.5f);
    public int angle1=0;
    //0~1 north east south west
    void Start()
    {
        animator = GetComponent(typeof(Animator)) as Animator;
    }

    // Update is called once per frame
    void Update()
        
    {
        Move();
        if(Input.GetKey(KeyCode.S))
        {
            animator.Play("playerwalk");
            angle1 = 0;
        } else if (Input.GetKey(KeyCode.W))
        {
            animator.Play("backwalk");
            angle1 = 2;

        } else if (Input.GetKey(KeyCode.A))
        {
            animator.Play("leftwalk");
            angle1 = 3;
        } else if (Input.GetKey(KeyCode.D))
        {
            animator.Play("rightwalk");
            angle1 = 1;
        } else
        
        {
            switch (angle1)
            {
                case 3:
                    animator.Play("Player Leftidle");
                    break;
                case 0:
                    animator.Play("Player Backidle");
                    break;
                case 1:
                    animator.Play("Player Rightidle");
                    break;
                case 2:
                    animator.Play("player Idle");
                    break;
            }
        }
    }

    void Move()
    {
        Vector2 Position = transform.position;
        if (Input.GetKey(KeyCode.W))
        {
            Position.y += SPEED.y * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            Position.y -= SPEED.y * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            Position.x -= SPEED.x * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            Position.x += SPEED.x * Time.deltaTime;
        }
        transform.position = Position;
    }
}
