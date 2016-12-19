using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Control : MonoBehaviour
{
    float lastTimeMoved = 0;
    public float timeBetweenMoveDown = 1;
    public Field wall;
    public Instanitiation tetromino;
    public bool i,bot;
    void Start()
    {
    } 
    void Update()
    {
        CheckValidation();
        CheckInput();
        AutoMove();

    }
    public void MoveDown()
    {
        transform.position += new Vector3(0, -1, 0);
        lastTimeMoved = Time.time;
    }
    
    void AutoMove()
    {
        if (Time.time - lastTimeMoved >= timeBetweenMoveDown)
        {
            MoveDown();
        }

    }
    void CheckInput()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow) && (i == true))
        {
            transform.position += new Vector3(-1, 0, 0);
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow) && (i == true))
        {
            transform.position += new Vector3(1, 0, 0);
        }

        else if (Input.GetKeyDown(KeyCode.UpArrow) && (i == true))
        {
            transform.Rotate(0, 0, 90);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow) && (i == true))
        {
            MoveDown();
        }
        else bot = false;
     }

    bool CheckValidation(IEnumerable<Vector3> pointsToCheck)
    {
        foreach (var mino in wall.field)
        {
            foreach (var point in pointsToCheck)
            {
                if (mino.transform.position == point)
                {
                    return i = false;
                }
            }
        }
        return i = true;
    }
}
