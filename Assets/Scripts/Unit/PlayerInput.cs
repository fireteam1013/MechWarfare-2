using UnityEngine;
using System.Collections;

public class PlayerInput : MonoBehaviour {

    float h;
    float v;

    float mouseX;
    float mouseY;

    enum BodyPosition { Standing, Crouching, Prone}
    BodyPosition bp;

    bool jump;

    float ttPosition = 0.5f;
    float ttPositionCheck;
    bool crouch;
    bool prone;

    bool run;

    void Start()
    {
        bp = BodyPosition.Standing;
    }

    void Update()
    {
        h = Input.GetAxisRaw("Horizontal");
        v = Input.GetAxisRaw("Vertical");

        //====================CROUCH CONTROLS====================
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            ttPositionCheck = Time.time + ttPosition;
        }
        if (Input.GetKey(KeyCode.LeftControl))
        {
            if (ttPositionCheck > Time.time)        //If the player just tapped the cntl key
            {
                if (bp == BodyPosition.Standing)
                {
                    bp = BodyPosition.Crouching;
                }else
                if (bp == BodyPosition.Crouching)
                {
                    bp = BodyPosition.Standing;
                }else
                if (bp == BodyPosition.Prone)
                {
                    bp = BodyPosition.Crouching;
                }
                Debug.Log(ttPositionCheck + " / " + bp);
            }
            if (ttPositionCheck < Time.time)        //If the player held the cntl key
            {
                if (bp == BodyPosition.Standing)
                {
                    bp = BodyPosition.Prone;
                }else
                if (bp == BodyPosition.Crouching)
                {
                    bp = BodyPosition.Prone;
                }else
                if (bp == BodyPosition.Prone)
                {
                    bp = BodyPosition.Standing;
                }
                Debug.Log(ttPositionCheck + " / " + bp);
            }
        }


        //====================RUN CONTROLS====================
        if (Input.GetKey(KeyCode.LeftShift))
        {
            run = true;
        }else
        {
            run = false;
        }
    }
}
