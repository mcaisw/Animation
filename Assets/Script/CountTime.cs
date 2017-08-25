using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountTime : MonoBehaviour {
    TimeSpan hours = new TimeSpan(2,0,0);
    DateTime CurrentTime;
    DateTime disPlayTime;
    Text temp;
    // Use this for initialization
    void Start () {
        temp = GetComponent<Text>();
        CurrentTime = DateTime.Now.Add(hours);
        //StartCoroutine(CountTimer());
        
    }
	
	// Update is called once per frame
	void Update () {
        //temp.text = (CurrentTime - DateTime.Now).ToString();
        temp.text = string.Format("{0:D2}:{1:D2}:{2:D2}", (CurrentTime - DateTime.Now).Hours, (CurrentTime - DateTime.Now).Minutes, (CurrentTime - DateTime.Now).Seconds);
    }

    IEnumerator CountTimer() {
        while (true)
        {
            yield return new WaitForSeconds(1);
            //Debug.Log((CurrentTime - DateTime.Now));
        }
    }
}
