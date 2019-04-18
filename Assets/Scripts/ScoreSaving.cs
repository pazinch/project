using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class ScoreSaving : MonoBehaviour {
    public Text text;
    public Assets.Scripts.Rank rank;
    public InputField placeh;
	// Use this for initialization
	void Start () {
        rank = new Assets.Scripts.Rank();
        text.text = rank.returnCurrent().ToString();
	}

    public void SaveScore(){
        rank.addToRank(placeh.text, rank.returnCurrent());
        Application.LoadLevel("Ranking");
    }

   
	
}
