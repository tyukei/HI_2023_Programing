using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class View : MonoBehaviour
{
    [SerializeField] private GameObject agentobj;
    [SerializeField] private GameObject stopPopupobj;

    public void SetStopPopup(bool dis)
    {
        stopPopupobj.SetActive(dis);
    }

    public void InitAgentPosition(){
        agentobj.transform.position = new Vector3(0f, 0.5f, 0f); 
    }
}
