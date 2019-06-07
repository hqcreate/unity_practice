using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_auto : MonoBehaviour
{
    Animator animator;
    private Vector2 SPEED = new Vector2();
    // Start is called before the first frame update
    public string stage_data;
    public int stage_height_half;
    public int stage_width_half;
    public int speed_para;
    private float counting = 0;
    private int angle;
    public int windowP;
    void Start()
    {
        animator = GetComponent(typeof(Animator)) as Animator;
    }

    // Update is called once per frame
    void Update()
    {
        int ranVecResult = 5;
        if(counting == 0){
            System.Random randVec = new System.Random();
            ranVecResult =(int)Mathf.Floor(UnityEngine.Random.Range(0f, 10f));
        }
        switch (ranVecResult)
        {
            case 0:
                SPEED.x = speed_para;
                SPEED.y = 0;
                animator.Play("Enemy Rightwalk");
                angle = 1;
                break;
            case 1:
                SPEED.x = -1 *speed_para;
                SPEED.y = 0f;
                animator.Play("Enemy Leftwalk");
                angle = 3;
                break;
            case 2:
                SPEED.x = 0f;
                SPEED.y = speed_para;
                animator.Play("backwalk");
                angle = 0;
                break;
            case 3:
                SPEED.x = 0f;
                SPEED.y = -1 * speed_para;
                animator.Play("walk");
                angle = 2;
                break;
        }
        if (counting == 0)
        {
            float position_x = Mathf.Round(transform.position.x - 0.5f) + 0.5f;
            float position_y = Mathf.Round(transform.position.y - 0.5f) + 0.5f;
            int position_i =(int)(position_x-0.5f+stage_width_half);
            int position_n = (int)(position_y + 0.5f - stage_height_half) * (-1);
            int position_r = position_i + position_n * 2 * stage_width_half;
            windowP = position_n;
            switch (angle)
            {
                case 0:
                    if (stage_data[position_r-stage_width_half*2] == '0') {
                        SPEED.x = 0;
                        SPEED.y = 0;
                    }
                    break;
                case 1:
                    if (stage_data[position_r+1] == '0')
                    {
                        SPEED.x = 0;
                        SPEED.y = 0;
                    }
                    break;
                case 2:
                    if (stage_data[position_r + stage_width_half * 2] == '0')
                    {
                        SPEED.x = 0;
                        SPEED.y = 0;
                    }
                    break;
                case 3:
                    if (stage_data[position_r -1] == '0')
                    {
                        SPEED.x = 0;
                        SPEED.y = 0;
                    }
                    break;
            }
        }
        counting += Time.deltaTime;
        Vector2 Position = transform.position;
        Position.y += SPEED.y * Time.deltaTime;
        Position.x += SPEED.x * Time.deltaTime;
        if (counting > (1 / speed_para))
        {
            counting = 0;
            Position.x = Mathf.Round(Position.x - 0.5f) + 0.5f;
            Position.y = Mathf.Round(Position.y - 0.5f) + 0.5f;
        }
        transform.position = Position;


    }
}
