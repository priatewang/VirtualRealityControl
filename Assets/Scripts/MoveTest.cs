using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class MoveTest : MonoBehaviour
{
    public MoveBase Move;
    int pos = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void FixedUpdate()
    {
        // pos++;
        // Move.SetDataPos(pos);
        RobotControl.DataAngles[0]++;
        RobotControl.DataAngles[1]+=0.5f;
    }
}
