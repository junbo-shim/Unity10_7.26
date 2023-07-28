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
        Debug.Log("마우스를 올려두었다");
        if(shakeAni == null || shakeAni == default) 
        {
            shakeAni = transform.DOShakeScale(0.5f, 1, 10, 90, true, ShakeRandomnessMode.Harmonic).SetAutoKill();
            shakeAni.onKill += () => DisposeShake();
            return;
        }
        
        //Debug.Log("shakeAni가 비어있지 않다");
        //if (shakeAni.IsComplete() == true) 
        //{
        //    shakeAni = default;
        //    Debug.Log("shakeAni가 비었다");
        //}
    }

    //public void OnPointerExit(PointerEventData eventData) 
    //{
    //    transform.localScale = Vector3.one;
    //    if (shakeAni.IsComplete() == true)
    //    {
    //        shakeAni = default;
    //        Debug.Log("shakeAni가 비었다");
    //    }
    //}

    // ! Tween 이 Kill 될 때 shakeAni 변수를 비워주는 함수
    private void DisposeShake() 
    {
        transform.localScale = Vector3.one;
        shakeAni = default;
    }
}
