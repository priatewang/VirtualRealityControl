using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XRotate : MoveBase
{
    public override void InitLocation()
    {
        MoveObject.localRotation = Quaternion.Euler(InitPosition, MoveObject.localRotation.y, MoveObject.localRotation.z);
    }

    public override void UpdateModelPosition()
    {
        MoveObject.localRotation = Quaternion.Euler(NowPosition, MoveObject.localRotation.y, MoveObject.localRotation.z);
    }
}
