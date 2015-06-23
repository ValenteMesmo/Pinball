﻿using UnityEngine;
using System.Collections;
using UnitySolution.InputComponents;

public class LeftInputOnTouch : MonoBehaviour
{
    ControlsPlayerInputs inputs;

    protected override void OnAwake()
    {
        base.OnAwake();
        var touches = GlobalComponents.Get<DetectsTouchOnAnyCollidersInScene>();
        touches.OnTouch += inputs_OnTouch;
        touches.OffTouch += inputs_OffTouch;       

        inputs = GlobalComponents.Get<ControlsPlayerInputs>();
    }

    void inputs_OffTouch(object sender, TransformEvevntArgs e)
    {
        if (e.Transform.gameObject == gameObject)
        {
            inputs.ReleaseLeftButton();
        }
    }

    void inputs_OnTouch(object sender, PointEvevntArgs e)
    {
        if (e.Transform.gameObject == gameObject)
        {
            inputs.PressLeftButton();
        }
    }
}