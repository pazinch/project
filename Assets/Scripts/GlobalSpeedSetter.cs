using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
public class GlobalSpeedSetter : MonoBehaviour {
    public Text text;
    public Assets.Scripts.Options Opj;
    public Slider sld;
	void Start () 
    {
        //DontDestroyOnLoad(this);
        Opj = new Assets.Scripts.Options();
        Opj.readOptions();
        text.text = Opj.speed.ToString();
        sld.value = Opj.speed;
	}
	
	public void VolumeSlider(float value)
    {
        int b = (int) value;
        text.text = "" + b;
    }
}
