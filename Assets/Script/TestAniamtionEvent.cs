using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestAniamtionEvent : MonoBehaviour {
    AnimationClip clip;
    AnimationEvent even;
    Animation anim;
    AnimationState state;
	// Use this for initialization
	void Start () {
        even = new AnimationEvent();
        even.time = 0.5f;
        even.functionName = "PrintEvent";
        anim = this.GetComponent<Animation>();
        state = anim["idle"];
        clip = anim.clip;
        clip.AddEvent(even);
    }
    public void PrintEvent() {
        Debug.Log(state.time);
    }


    // Update is called once per frame
    void Update () {
		
	}
}
