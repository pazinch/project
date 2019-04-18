using UnityEngine;
using System.Collections;

public class EatScript : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        Vector2 new_pos = new Vector2(Random.Range(-6, 6), Random.Range(-4, 3));
        GameObject.Find("Background").GetComponent<ObjectManaging>().
            First_block_positions.Find(x => x.Equals(new_pos));
        GameObject.Find("EatManager").GetComponent<EatScriptManager>().food =
            (GameObject)Instantiate(gameObject, new_pos, Quaternion.identity);
        GameObject.Find("Background").GetComponent<ObjectManaging>().incPoints();
        Destroy(gameObject);
    }
}
