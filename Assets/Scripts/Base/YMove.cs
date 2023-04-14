using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YMove : MoveBase
{
    public override void InitLocation()
    {
        MoveObject.localPosition = new Vector3(MoveObject.localPosition.x, InitPosition, MoveObject.localPosition.z);
    }

    public override void UpdateModelPosition()
    {
        MoveObject.localPosition = new Vector3(MoveObject.localPosition.x, NowPosition, MoveObject.localPosition.z);

    }
}
