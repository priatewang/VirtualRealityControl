using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YRotate : MoveBase
{
    public override void InitLocation()
    {
        MoveObject.localRotation = Quaternion.Euler(MoveObject.localPosition.x, InitPosition, MoveObject.localPosition.z);
    }
    public override void UpdateModelPosition()
    {
        MoveObject.localRotation = Quaternion.Euler(MoveObject.localPosition.x, NowPosition, MoveObject.localPosition.z);
    }
}
