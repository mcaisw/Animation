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

    }

    IEnumerator WhileAnimaEnd()
    {
        yield return new WaitingEndofAnimi(anima);
        Debug.Log("播放完毕");
    }
}
