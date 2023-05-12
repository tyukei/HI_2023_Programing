using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]private View view;
    private ViewModel viewModel;

    public void Start(){
        viewModel = new ViewModel();
    }

    public void OnClickLeftBtn(){
        if(!viewModel.GetisStopPopup()){ // if stop popup is not active
            view.SetStopPopup(true);
            viewModel.SetisStopPopup(true);
        }
    }

    public void OnClickRightBtn(){
        if(viewModel.GetisStopPopup()){ // if stop popup is active
            view.SetStopPopup(false);
            viewModel.SetisStopPopup(false);
        }
    }


    public void OnCLickRBtn(){
        if(Input.GetKey(KeyCode.L)){
            OnClickRLBtn();
        }
    }
    public void OnCLickLBtn(){
        if(Input.GetKey(KeyCode.R)){
            OnClickRLBtn();
        }
    }

    private void OnClickRLBtn(){
        if(viewModel.GetisStopPopup()){ // if stop popup is active
            view.InitAgentPosition();
            view.SetStopPopup(false);
            viewModel.SetisStopPopup(false);
        }
    }
}
