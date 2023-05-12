using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewModel
{
    private bool isStopPopup;

    public ViewModel(){
        isStopPopup = false;
    }

    public void SetisStopPopup(bool dis){
        isStopPopup = dis;
    }
    public bool GetisStopPopup(){
        return isStopPopup;
    }

}
