using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class ModeSetter : MonoBehaviour {
    public bool CanSnakeGoThroughWalls = true;
    public Toggle tog;
	// Use this for initialization
	
    void Start()
    {
        Assets.Scripts.Options Opj = new Assets.Scripts.Options();
        Opj.readOptions();
        CanSnakeGoThroughWalls = Opj.ifSnakeCanGoThroughWalls;
        tog.isOn = CanSnakeGoThroughWalls;
    }
    public void isSnakeAbleToGoThroughWalls()
    {
        if (tog.isOn)
            CanSnakeGoThroughWalls = true;
        else
            CanSnakeGoThroughWalls = false;
    }
}
