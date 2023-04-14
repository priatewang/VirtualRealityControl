using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

/// <summary>
/// 运动控制基类(平移、旋转)
/// </summary>
public class MoveBase : MonoBehaviour
{
    /// <summary>
    /// 运动控制对象
    /// </summary>
    public Transform MoveObject;

    /// <summary>
    /// 传过来的位置
    /// </summary>
    protected float DataPosition;

    /// <summary>
    /// 初始化位置
    /// </summary>
    public float InitPosition;
    /// <summary>
    /// 当前位置
    /// </summary>
    public float NowPosition;

    /// <summary>
    /// 模型移动长度，比例计算
    /// </summary>
    public float MoveLength = 1;
    /// <summary>
    /// 实际移动长度
    /// </summary>
    public float ActualLength = 1;

    /// <summary>
    /// 设置实时数据
    /// </summary>
    /// <param name="pos"></param>
    public virtual void SetDataPos(float pos)
    {
        DataPosition = pos;
    }

    public bool IsChange()
    {

        if (NowPosition != DataPosition)
        {
            return true;
        }
        else
        {
            return false;
        }


    }


    void Start()
    {
        MoveObject = gameObject.transform;
    }
    /// <summary>
    /// 初始化位置参数
    /// </summary>
    public virtual void InitLocation()
    {

    }

    private void FixedUpdate()
    {

        if (IsChange())
        {

            NowPosition = InitPosition + DataPosition * MoveLength / ActualLength;

            UpdateModelPosition();
        }

    }
    /// <summary>
    /// 更新位置
    /// </summary>
    public virtual void UpdateModelPosition()
    {

    }


}
