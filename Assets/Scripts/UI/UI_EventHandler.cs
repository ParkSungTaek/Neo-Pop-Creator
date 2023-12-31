using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

/// <summary> 매개변수 없는 이벤트 핸들러 </summary>
public class UI_EventHandler : MonoBehaviour, IPointerClickHandler, IDragHandler, IEndDragHandler,IPointerDownHandler,IPointerUpHandler, IPointerExitHandler, IDeselectHandler
{
    public Action<PointerEventData> OnDownHandler = null;
    public Action<PointerEventData> OnClickHandler = null;
    public Action<PointerEventData> OnDragHandler = null;
    public Action<PointerEventData> OnDragEndHandler = null;
    public Action<PointerEventData> OnUpHandler = null;
    public Action<PointerEventData> OnExitHandler = null;
    public Action<BaseEventData> OnDeselectHandler = null;

    public void OnPointerDown(PointerEventData eventData)
    {
        OnDownHandler?.Invoke(eventData);

    }
    public void OnPointerClick(PointerEventData eventData)
    {
        OnClickHandler?.Invoke(eventData);
    }

    public void OnDrag(PointerEventData eventData)
    {
        OnDragHandler?.Invoke(eventData);
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        OnDragEndHandler?.Invoke(eventData);
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        OnUpHandler?.Invoke(eventData);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        OnExitHandler?.Invoke(eventData);
    }

    public void OnDeselect(BaseEventData eventData)
    {
        OnDeselectHandler?.Invoke(eventData);
    }
}