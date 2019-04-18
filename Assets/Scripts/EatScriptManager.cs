using UnityEngine;
using System.Collections;

public class EatScriptManager : MonoBehaviour
{
    public GameObject food;
    void Start()
    {
        food.transform.position = new Vector2(Random.Range(-6, 6), Random.Range(-4, 3));
    }
}
