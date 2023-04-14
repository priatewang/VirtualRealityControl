using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZRotate : MoveBase
{
    public override void InitLocation()
    {
        MoveObject.localRotation = Quaternion.Euler(MoveObject.localPosition.x, MoveObject.localPosition.y, InitPosition);
    }
    public override void UpdateModelPosition()
    {
        MoveObject.localRotation = Quaternion.Euler(MoveObject.localPosition.x, MoveObject.localPosition.y, NowPosition);
    }
}
