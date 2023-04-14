using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XRotate : MoveBase
{
    public override void InitLocation()
    {
        MoveObject.localRotation = Quaternion.Euler(InitPosition, MoveObject.localPosition.y, MoveObject.localPosition.z);
    }

    public override void UpdateModelPosition()
    {
        MoveObject.localRotation = Quaternion.Euler(NowPosition, MoveObject.localPosition.y, MoveObject.localPosition.z);
    }
}
