using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeFunction
{
    private Action action;
    private float timer;
    private bool isDestroyed;

    public TimeFunction(Action action, float timer)
    {
        this.action = action;
        this.timer = timer;
        isDestroyed = false;
        Debug.Log("I am counting!");
    }

    public void Update()
    {
        if (isDestroyed == false)
        {
            timer -= Time.deltaTime;
            if (timer < 0)
            {
                action();
                DestroySelf();
            }
        }
    }

    private void DestroySelf()
    {
        isDestroyed = true;
    }
}
