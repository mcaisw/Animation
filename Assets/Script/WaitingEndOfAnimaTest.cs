using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaitingEndOfAnimaTest : MonoBehaviour {
    Animation anima;
    // Use this for initialization
    void Start()
    {
        anima = GetComponent<Animation>();
        StartCoroutine(WhileAnimaEnd());
    }

    // Update is called once per frame
    void Update()
    {
        if (anima["attack"].normalizedTime >= 0.97f)//设置循环播放攻击动画
        {
            anima["attack"].normalizedTime = 0;
            StartCoroutine(Attack());
        }
    }

    IEnumerator WhileAnimaEnd()
    {
        yield return new WaitingEndofAnimi(anima);
        Debug.Log("播放完毕");
    }
    

    IEnumerator Attack()
    {
        yield return new WaitWhile(() => anima["attack"].normalizedTime * 19 <= 10);//当动画帧数在10帧之前，悬挂到这里
        Debug.Log("attack");
    }
}
