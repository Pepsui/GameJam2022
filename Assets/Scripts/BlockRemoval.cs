using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class BlockRemoval : MonoBehaviour
{
    [SerializeField] private Tile destroy;
    [SerializeField] private Tile setDown;
    Tilemap tileMap;
    InventoryStruct inventory;
    void Start()
    {
        tileMap = GetComponent<Tilemap>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        CompositeCollider2D floorCollider = GetComponent<CompositeCollider2D>();
        //creating

        if(Input.GetMouseButton(1)) {
            Vector3 mousePlace = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector3Int selectedTile = tileMap.WorldToCell(mousePlace);
            Debug.Log(selectedTile);
            var tile = tileMap.GetTile(selectedTile);
            Debug.Log(tile);
            tileMap.SetTile(selectedTile, setDown);
            tileMap.SetColliderType(selectedTile, tileMap.GetColliderType(selectedTile));
        }
       
        //destroying
            
        if(Input.GetMouseButton(0)) {
            Vector3 mousePlace = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector3Int selectedTile = tileMap.WorldToCell(mousePlace);
            Debug.Log(selectedTile);
            var tile = tileMap.GetTile(selectedTile);
            Debug.Log(tile);
            tileMap.SetTile(selectedTile, destroy);
        } 
    }
}
