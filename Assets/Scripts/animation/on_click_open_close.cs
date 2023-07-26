using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class on_click_open_close : MonoBehaviour, IPointerClickHandler
{
    private Animator m_Animator;
    private void Start()
    {
        m_Animator = GetComponent<Animator>();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        
        m_Animator.SetTrigger("Click");
    }
}
