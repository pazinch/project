using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class SnakeMapCollision : MonoBehaviour
{
    bool isGoingToCrashAgainstWall = false;
    void Start()
    {
        Assets.Scripts.Options Opj = new Assets.Scripts.Options();
        Opj.readOptions();
        isGoingToCrashAgainstWall = Opj.ifSnakeCanGoThroughWalls;
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (!isGoingToCrashAgainstWall)
        {
            if (col.gameObject.name == "Borders")
            {
                GameObject buf = GameObject.Find("block");
                GameObject buf_a = GameObject.Find("block_0");

                if (buf.transform.position.x > 6)
                {
                    buf.transform.position = new Vector2(-6f, transform.position.y);
                }
                else if (buf.transform.position.x < -6)
                {
                    buf.transform.position = new Vector2(6f, transform.position.y);
                }
                else if (buf.transform.position.y > 3)
                {
                    buf.transform.position = new Vector2(transform.position.x, -4f);
                }
                else if (buf.transform.position.y < -4)
                {
                    buf.transform.position = new Vector2(transform.position.x, 3f);
                }
                if (buf_a != null)
                    buf_a.transform.position = buf.transform.position;
            }
        }
        else
        {
            if (col.gameObject.name == "Borders")
            {
                Application.LoadLevel("Game_Over");
                Assets.Scripts.Rank rank = new Assets.Scripts.Rank();
                rank.addCurrent(int.Parse(GameObject.Find("PointsGained").GetComponent<Text>().text));
            }
        }
    }
}
