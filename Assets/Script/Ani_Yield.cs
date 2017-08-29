using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//用协程写了一个判断在动画播放到一半的时候打印出信息。然后开始运动，到达目的地后，打印出信息到位
//IEnumerator可以让我的函数按照一定的顺序进行下去，先进行第一个函数，等第一个函数确保执行完毕，再进行第二个函数
public class Ani_Yield : MonoBehaviour {
    Animation anim = null;
    Vector3 targetPos;
    // Use this for initialization
    void Start() {
        targetPos = new Vector3(2,0,0);
        anim = GetComponentInChildren<Animation>();
        StartCoroutine(PrintTime());
    }

    // Update is called once per frame
    void Update() {

    }

    IEnumerator PrintTime() {
        yield return PlayHalf();
        Debug.Log("开始运动");
        yield return Move();
        Debug.Log("到位");
    }

    IEnumerator PlayHalf() {

        while(anim["idle"].normalizedTime <= 0.5)
        {
            yield return new WaitForSeconds(1/60f);
            Debug.Log(anim["idle"].normalizedTime);
        }
        yield return null;
    }

    IEnumerator Move() {

        while (this.transform.position.x<= targetPos.x)
        {
            yield return new WaitForSeconds(1 / 60f);
            this.transform.position = new Vector3(this.transform.position.x+Time.deltaTime, this.transform.position.y, this.transform.position.z);
        }
        yield return null;
    }
}
