using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.MagicLeap;

public class BeamRayCast : MonoBehaviour
{
    private MLInput.Controller _controller;

    void Start()
    {
        MLInput.Start();
        MLInput.OnControllerButtonDown += OnButtonDown;
        MLInput.OnControllerButtonUp += OnButtonUp;
        _controller = MLInput.GetController(MLInput.Hand.Right);
    }

    void OnButtonUp(byte controllerId, MLInput.Controller.Button button)
    {
        if (button == MLInput.Controller.Button.Bumper)
        {
            print("Button bumper up");
        }
        if (button == MLInput.Controller.Button.HomeTap)
        {
            print("Button home tap up");
        }
    }

    void OnButtonDown(byte controllerId, MLInput.Controller.Button button)
    {
        RaycastHit hit;
        if (Physics.Raycast(_controller.Position, transform.forward, out hit))
        {
            if (button == MLInput.Controller.Button.Bumper)
            {
                print("Button bumper down");
            }
            if (button == MLInput.Controller.Button.HomeTap)
            {
                print("Button home tap down");
            }
        }
    }

    void CheckTrigger()
    {
        if (_controller.TriggerValue > 0.2f)
        {
            print("Button trigger on");
        }
    }

    void Update()
    {
        transform.position = _controller.Position;
        transform.rotation = _controller.Orientation;
        CheckTrigger();
    }

    void OnDestroy()
    {
        MLInput.OnControllerButtonDown -= OnButtonDown;
        MLInput.OnControllerButtonUp -= OnButtonUp;
        MLInput.Stop();
    }

}
