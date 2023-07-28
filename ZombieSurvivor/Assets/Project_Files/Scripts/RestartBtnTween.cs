using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using DG.Tweening;


public class RestartBtnTween : MonoBehaviour, IPointerEnterHandler
{
    Tween shakeAni = default;

    public void OnPointerEnter(PointerEventData eventData) 
    {
        Debug.Log("���콺�� �÷��ξ���");
        if(shakeAni == null || shakeAni == default) 
        {
            shakeAni = transform.DOShakeScale(0.5f, 1, 10, 90, true, ShakeRandomnessMode.Harmonic).SetAutoKill();
            shakeAni.onKill += () => DisposeShake();
            return;
        }
        
        //Debug.Log("shakeAni�� ������� �ʴ�");
        //if (shakeAni.IsComplete() == true) 
        //{
        //    shakeAni = default;
        //    Debug.Log("shakeAni�� �����");
        //}
    }

    //public void OnPointerExit(PointerEventData eventData) 
    //{
    //    transform.localScale = Vector3.one;
    //    if (shakeAni.IsComplete() == true)
    //    {
    //        shakeAni = default;
    //        Debug.Log("shakeAni�� �����");
    //    }
    //}

    // ! Tween �� Kill �� �� shakeAni ������ ����ִ� �Լ�
    private void DisposeShake() 
    {
        transform.localScale = Vector3.one;
        shakeAni = default;
    }
}
