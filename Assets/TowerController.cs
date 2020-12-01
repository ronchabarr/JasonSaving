using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerController : MonoBehaviour
{
    InputForm _inputForm;
    public void Start()
    {
        _inputForm = new InputForm();
        
    }
    public InputForm GetInputForm()
    {
        _inputForm.rotVector = new Vector3(0, Input.GetAxis("Mouse X"), 0);
        _inputForm.shoot = Input.GetKeyDown(KeyCode.Space);
        
            
        
        return _inputForm;
    }

}
