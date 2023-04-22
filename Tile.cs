using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _renderer;
    [SerializeField] private GameObject _highlight;
    // Start is called before the first frame update
    public void OnMouseEnter()
    {
        _highlight.SetActive(true);
    }
    public void OnMouseExit()
    {
        _highlight.SetActive(false);
    }
}
