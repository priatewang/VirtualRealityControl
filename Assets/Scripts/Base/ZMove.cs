using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZMove : MoveBase
{
    public override void InitLocation()
    {
        MoveObject.localPosition = new Vector3(MoveObject.localPosition.x, MoveObject.localPosition.y, InitPosition);
    }

    public override void UpdateModelPosition()
    {
        MoveObject.localPosition = new Vector3(MoveObject.localPosition.x, MoveObject.localPosition.y, NowPosition);
    }
}
