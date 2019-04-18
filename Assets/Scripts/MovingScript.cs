using UnityEngine;
using System.Collections;

public class MovingScript : MonoBehaviour
{
    bool head_open = false;

    int direction = 2;
    int act_direction = 2;
    // 1 - left
    // 2 - right
    // 3 - up
    // 4 - down

    float seconds = 0.5f;
    public int speed = 1;
    
    Assets.Scripts.Options Opj;

    void MoveInDirection()
    {
        seconds -= speed * Time.deltaTime;
        if (seconds <= 0)
            oneMove();
    }

    void oneMove()
    {
        /*
        Vector2 buf = GameObject.Find("food").transform.position;
        buf -= transform.position;
        if (buf == null) buf = new Vector2(-100, -100);
        if ((buf.x < 0.5 && buf.y < 0.5f && head_open == false) || (buf.x > -0.5f && buf.y > -0.5f && head_open == false))
        {
            var renderer = (SpriteRenderer)gameObject.GetComponent("SpriteRenderer");
            renderer.sprite = Resources.LoadAssetAtPath<Sprite>("Assets/Sprites/head_open.png");
            head_open = true;
        }
        else if (head_open == true)
        {
            var renderer = (SpriteRenderer)gameObject.GetComponent("SpriteRenderer");
            renderer.sprite = Resources.LoadAssetAtPath<Sprite>("Assets/Sprites/head.png");
            head_open = false;
        }
         */

        if (direction == 1)            
            transform.position = new Vector2(transform.position.x - 0.5f, transform.position.y);
            
        else if (direction == 2)
            transform.position = new Vector2(transform.position.x + 0.5f, transform.position.y);
        else if (direction == 3)
            transform.position = new Vector2(transform.position.x, transform.position.y + 0.5f);
        else
            transform.position = new Vector2(transform.position.x, transform.position.y - 0.5f);
      
        act_direction = direction;
        seconds = 0.5f;
   
    }


    void OnSwipeLeft()
    {
        if (act_direction != 1 && act_direction != 2)
            direction = 1;
    }
    void OnSwipeRight()
    {
        if (act_direction != 1 && act_direction != 2)
            direction = 2;
    }
    void OnSwipeUp()
    {
        if (act_direction != 3 && act_direction != 4)
             direction = 3;
    }
    void OnSwipeDown()
    {
        if (act_direction != 3 && act_direction != 4)
            direction = 4;
    }

    void Start()
    {
        //GlobalSpeedSetter sm = GameObject.Find("SliderManager").GetComponent<GlobalSpeedSetter>();
        //if (sm != null)
        //    speed = (int) sm.speed;
        //else speed = 1;
        Opj = new Assets.Scripts.Options();
        Opj.readOptions();
        speed = Opj.speed;
    }
    void Update()
    {

        
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (act_direction != 1 && act_direction != 2)
                direction = 1;
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (act_direction != 1 && act_direction != 2)
                direction = 2;
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (act_direction != 3 && act_direction != 4)
                direction = 3;
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            if (act_direction != 3 && act_direction != 4)
                direction = 4;
        }

        else if (Input.GetKeyDown(KeyCode.P))
        {
            if (Time.timeScale == 1)
                Time.timeScale = 0;
            else Time.timeScale = 1;
        }
        else if (Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = 1;
            Application.LoadLevel("Menu");
        }
        MoveInDirection();

    }
}
