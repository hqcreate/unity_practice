using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller_spoon : MonoBehaviour
{
    public GameObject obj;
    public string tag_name;
    public int pop_num;
    public int Win;
    // Start is called before the first frame update
    void Start()
    {
        GameObject[] ary = GameObject.FindGameObjectsWithTag("ppap");
        //Fisher-Yatesアルゴリズムでシャッフルする
        System.Random rng = new System.Random();
        int n = ary.Length;
        Win = n;
        while (n > 1)
        {
            n--;
            int k = rng.Next(n + 1);
            GameObject tmp = ary[k];
            ary[k] = ary[n];
            ary[n] = tmp;
        }
        for(int t = 0; t < pop_num; t++)
        {
            Instantiate(obj,ary[t].transform.position, Quaternion.identity);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
