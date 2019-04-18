using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
  
public class ApplyOptions : MonoBehaviour {
    public Text text;
    public Toggle tog;
    

    Assets.Code.Options Opj;
	// Use this for initialization
	
    public void saveOptions()
    {
        Opj = new Assets.Scripts.Options("");
        int b = int.Parse(text.text);
        Opj.changeSomethingInOptions((int) b , tog.isOn);
        
    } 
}
