using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YRotate : MoveBase
{
    public override void InitLocation()
    {
        MoveObject.localRotation = Quaternion.Euler(MoveObject.localRotation.x, InitPosition, MoveObject.localRotation.z);
    }
    public override void UpdateModelPosition()
    {
        MoveObject.localRotation = Quaternion.Euler(MoveObject.localRotation.x, NowPosition, MoveObject.localRotation.z);
    }
}
