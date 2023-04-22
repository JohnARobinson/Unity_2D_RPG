using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    [SerializeField] private int _width, _height;
    [SerializeField] private Tile _tilePreFab;
    //[SerializeField] private Transform _cam;

    void Start()
    {
         generateGrid();
    }


    void generateGrid()
    {
        for(int i = 0; i < _width; i++)
        {
            for(int j = 0; j < _height; j++){

                var createTile = Instantiate(_tilePreFab, new Vector3(i, j), Quaternion.identity);
                createTile.name = $"Tile{i} {j}";

            }
        }

        //_cam.transform.position = new Vector3((float)_width/2 - 0.5f, (float)_height / 2 - 0.5f, -10);
    }
}
