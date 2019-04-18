using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class LoadIntoRanking : MonoBehaviour {
    public Text text;
	// Use this for initialization
	void Start () {
        Assets.Scripts.Rank rank = new Assets.Scripts.Rank();
        rank.readRankFromXML();
        int i = 0;
        text.text = "";
        foreach (var name in rank.names)
        {
            text.text += "Name:" + name + "\n";
            text.text +="Score:"+rank.scores[i]+"\n\n";
            ++i;
        }
	}
	

}
