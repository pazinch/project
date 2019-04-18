using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
public class ObjectManaging : MonoBehaviour
{
    public Text text_points;

    public int points = 0;

    bool init_first = false;
    GameObject first_block;
    public List<Vector2> First_block_positions = new List<Vector2>(); 


    public List <GameObject> AllObjects;

    void Start()
    {
        first_block = GameObject.Find("block");
        First_block_positions.Add(first_block.transform.position);
        text_points.text = points.ToString();
        //AddBlock();
        //Instantiate(first_block).name = "block_0";
        //AllObjects.Add(GameObject.Find("block_0"));
        
        
        
    }

    public void incPoints()
    {
        points++;
        text_points.text = points.ToString();
        if (!init_first)
        {
            AddBlock();
            init_first = true;
        }
        AddBlock();
    }

    void Update()
    {
        

        //first_block = GameObject.Find("block");
        if (First_block_positions[ First_block_positions.Count - 1 ] != (Vector2) first_block.transform.position)
        {
            First_block_positions.Add(first_block.transform.position);
        }
        //set 
        for (int i = 0; i < AllObjects.Count; i++ )
        {
            if (First_block_positions.Count >= AllObjects.Count)
                AllObjects[i].transform.position = First_block_positions[First_block_positions.Count-i-1];

            if (First_block_positions.Count != AllObjects.Count)
            First_block_positions.RemoveRange(0, (First_block_positions.Count - 1 - AllObjects.Count )  );
        }

        

        List<GameObject> check = AllObjects.FindAll(x => x.transform.position == first_block.transform.position);
        if (check.Count > 1)
        {
            
            Application.LoadLevel("Game_over");
            Assets.Code.Rank rank = new Assets.Code.Rank();
            rank.addCurrent(points);
        }
        
       
    }
    
    void AddBlock()
    {
        int size = AllObjects.Count;
        if (size == 0)
        {
            Instantiate(first_block).name = "block_0";
            AllObjects.Add(GameObject.Find("block_0"));

            GameObject.Find("block").GetComponent<SpriteRenderer>().enabled = false;

            MovingScript other = AllObjects[size].GetComponent<MovingScript>();
            if (other != null)
            {
                Destroy(other);
            }
        }
        else if (size == 1)
        {
            Instantiate(AllObjects[0]).name = "block_" + size; ;
            AllObjects.Add(GameObject.Find("block_" + size));

            var renderer = (SpriteRenderer)AllObjects[1].GetComponent("SpriteRenderer");
            renderer.sprite = UnityEditor.AssetDatabase.LoadAssetAtPath<Sprite>("Assets/Sprites/snake.png");
            renderer.sortingOrder = 9;

            MovingScript other = AllObjects[size].GetComponent<MovingScript>();
            if (other != null)
            {
                Destroy(other);
            }
        }
        else
        {
            
            Instantiate(AllObjects[1]).name = "block_" + size;;
            AllObjects.Add(GameObject.Find("block_"+ size));


            MovingScript other = AllObjects[size].GetComponent<MovingScript>();
            if (other != null)
            {
                Destroy(other);
            }
        }
    }

    


}