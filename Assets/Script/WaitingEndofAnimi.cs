using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaitingEndofAnimi : CustomYieldInstruction
{
    Animation animi;
    public override bool keepWaiting
    {
        get
        {
            return animi.isPlaying;
        }
    }

    public WaitingEndofAnimi(Animation clip) {
        animi = clip;
    }
}
