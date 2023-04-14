using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

/// <summary>
/// �˶����ƻ���(ƽ�ơ���ת)
/// </summary>
public class MoveBase : MonoBehaviour
{
    /// <summary>
    /// �˶����ƶ���
    /// </summary>
    public Transform MoveObject;

    /// <summary>
    /// ��������λ��
    /// </summary>
    protected float DataPosition;

    /// <summary>
    /// ��ʼ��λ��
    /// </summary>
    public float InitPosition;
    /// <summary>
    /// ��ǰλ��
    /// </summary>
    public float NowPosition;

    /// <summary>
    /// ģ���ƶ����ȣ���������
    /// </summary>
    public float MoveLength = 1;
    /// <summary>
    /// ʵ���ƶ�����
    /// </summary>
    public float ActualLength = 1;

    /// <summary>
    /// ����ʵʱ����
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
    /// ��ʼ��λ�ò���
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
    /// ����λ��
    /// </summary>
    public virtual void UpdateModelPosition()
    {

    }


}
