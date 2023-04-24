using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotControl : MonoBehaviour
{
    /// <summary>
    /// �ؽ���
    /// </summary>
    public MoveBase[] Joints;

    /// <summary>
    /// �ؽ�����
    /// </summary>
    public static float[] DataAngles;

    // Start is called before the first frame update
    void Start()
    {
        DataAngles=new float[2];
    }

    // Update is called once per frame
    void Update()
    {

        for (int i = 0; i < Joints.Length; i++)
        {
            Joints[i].SetDataPos(DataAngles[i]);
        }

    }
}
