using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    public static int gridWidth = 10;

    public static int gridHeight = 20;

    // Start is called before the first frame update
    void Start()
    {
        SpawnNextTetromino();
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void SpawnNextTetromino()
    {
        GameObject nextTetromino = (GameObject)
            Instantiate(Resources.Load(GetRandomTetromino(),
                typeof(GameObject)), new Vector2(5.0f,20.0f), Quaternion.identity) ;
    }

    public bool CheckIsInsideGrid(Vector2 pos)
    {
        return ((int) pos.x >= 0 && (int) pos.x < gridWidth && (int) pos.y >= 0);
    }

    //Helper method rounds x and y
    public Vector2 Round(Vector2 pos)
    {
        return new Vector2(Mathf.Round(pos.x), Mathf.Round(pos.y));
    }

    string GetRandomTetromino()
    {
        int randomTetromino = Random.Range(1, 8);
        string randomTetrominoName = "Just_To_Initialize";
        switch ((randomTetromino))
        {
            case 1:
                randomTetrominoName = "prefabs/Tetromino_T";
                break;
            case 2:
                randomTetrominoName = "prefabs/Tetromino_Long";
                break;
            case 3:
                randomTetrominoName = "prefabs/Tetromino_Square";
                break;
            case 4:
                randomTetrominoName = "prefabs/Tetromino_J";
                break;
            case 5:
                randomTetrominoName = "prefabs/Tetromino_L";
                break;
            case 6:
                randomTetrominoName = "prefabs/Tetromino_S";
                break;
            case 7:
                randomTetrominoName = "prefabs/Tetromino_Z";
                break;
        }

        return randomTetrominoName;
    }
}
