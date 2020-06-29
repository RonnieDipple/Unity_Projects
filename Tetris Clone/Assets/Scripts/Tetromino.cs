using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tetromino : MonoBehaviour
{
    private float fall = 0;

    public float fullspeed = 1;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        checkUserInput();
    }

    void checkUserInput()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.position += new Vector3(1, 0, 0);
            if (!CheckIsValidPosition())
            {
                transform.position += new Vector3(-1, 0,0);

            }

        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.position += new Vector3(-1, 0, 0);
            if (!CheckIsValidPosition())
            {
                transform.position += new Vector3(1, 0,0);

            }


        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.Rotate(0, 0, 90);
            if (!CheckIsValidPosition())
            {
                transform.position += new Vector3(0, 0,-90);

            }


        }
        else if (Input.GetKeyDown(KeyCode.DownArrow) || Time.time - fall >= fullspeed)
        {
            transform.position += new Vector3(0, -1, 0);
            if (!CheckIsValidPosition())
            {
                transform.position += new Vector3(0, 1,0);

            }
            fall = Time.time;
        }
    }

    bool CheckIsValidPosition()
    {
        foreach (Transform mino in transform)
        {
            Vector2 pos = FindObjectOfType<Game>().Round(mino.position);
            if (FindObjectOfType<Game>().CheckIsInsideGrid(pos) == false)
            {
                return false;
            }

        }

        return true;
    }
}


