using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyPat : MonoBehaviour
{
    // Start is called before the first frame update
    Animator animator;
    private Vector2 SPEED = new Vector2();
    public Vector2 SPEED_para = new Vector2();
    public int random_para;
    private float counting = 0;

    void Start()
    {
        animator = GetComponent(typeof(Animator)) as Animator;
        
    }

    // Update is called once per frame
    void Update()
    {
        int ranVecResult = 5;
        if (counting == 0)
        {
            System.Random randVec = new System.Random();
            ranVecResult = randVec.Next(random_para);

        }
        counting += Time.deltaTime;
        switch (ranVecResult)
        {
            case 0:
                SPEED.x = SPEED_para.x;
                SPEED.y = 0;
                animator.Play("Enemy Rightwalk");
                break;
            case 1:
                SPEED.x = -1 * SPEED_para.x;
                SPEED.y = 0f;
                animator.Play("Enemy Leftwalk");
                break;
            case 2:
                SPEED.x = 0f;
                SPEED.y = SPEED_para.y;
                animator.Play("backwalk");
                break;
            case 3:
                SPEED.x = 0f;
                SPEED.y = -1 * SPEED_para.y;
                animator.Play("walk");
                break;
        }
        Vector2 Position = transform.position;
        Position.y += SPEED.y * Time.deltaTime;
        Position.x += SPEED.x * Time.deltaTime;
        if (counting > (1/SPEED_para.x))
        {
            counting = 0;
            Position.x = Mathf.Round(Position.x - 0.5f) + 0.5f;
            Position.y = Mathf.Round(Position.y - 0.5f) + 0.5f;
        }
        transform.position = Position;
    }
}
