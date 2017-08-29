using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//用协程写了一个判断在动画播放到一半的时候打印出信息。
public class Ani_Yield : MonoBehaviour {
    Animation anim = null;
    // Use this for initialization
    void Start() {
        anim = GetComponentInChildren<Animation>();
        StartCoroutine(PrintTime());
    }

    // Update is called once per frame
    void Update() {

    }

    IEnumerator PrintTime() {
        yield return StartCoroutine(PlayHalf());
        Debug.Log("中间");
    }

    IEnumerator PlayHalf() {

        while(anim["idle"].normalizedTime <= 0.5)
        {
            yield return new WaitForSeconds(1/60f);
            Debug.Log(anim["idle"].normalizedTime);
        }
        yield return null;
    }
}
