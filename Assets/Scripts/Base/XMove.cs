using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XMove : MoveBase
{
    public override void InitLocation()
    {
        MoveObject.localPosition = new Vector3(InitPosition, MoveObject.localPosition.y, MoveObject.localPosition.z);
    }

    public override void UpdateModelPosition()
    {
            MoveObject.localPosition = new Vector3(NowPosition, MoveObject.localPosition.y, MoveObject.localPosition.z);
    }
}
