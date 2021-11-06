using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{

    public string KeyUp;
    public string KeyDown;
    public string KeyRight;
    public string KeyLeft;

    public float DiretionUp;
    public float DiretionRight;

    public bool InputEnabled = true;

    private float TargetDiretionUp;
    private float TargetDiretionRight;
    private float VelocityDiretionUp;
    private float VelocityDiretionRight;

    // Start is called before the first frame update
    void Start()
    {

        KeyUp = "w";
        KeyDown = "s";
        KeyRight = "d";
        KeyLeft = "a";

    }

    // Update is called once per frame
    void Update()
    {

        TargetDiretionUp = (Input.GetKey (KeyUp) ? 1.0f : 0) - (Input.GetKey (KeyDown) ? 1.0f : 0);
        TargetDiretionRight = (Input.GetKey (KeyRight) ? 1.0f : 0) - (Input.GetKey (KeyLeft) ? 1.0f : 0);

        if (InputEnabled == false)
        {

            TargetDiretionUp = TargetDiretionRight = 0;

        }

        DiretionUp = Mathf.SmoothDamp (DiretionUp, TargetDiretionUp, ref VelocityDiretionUp, 0.1f);
        DiretionRight = Mathf.SmoothDamp (DiretionRight, TargetDiretionRight, ref VelocityDiretionRight, 0.1f);


    }
}
