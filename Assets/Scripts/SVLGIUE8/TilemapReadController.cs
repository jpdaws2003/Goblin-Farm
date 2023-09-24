using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class TilemapReadController : MonoBehaviour
{
    [SerializeField] Tilemap tilemap;
    [SerializeField] List<TileData> tileDatas;
    Dictionary<TileBase, TileData> dataFromTiles;

    void Start() {
        dataFromTiles = new Dictionary<TileBase, TileData>();
        foreach(TileData tileData in tileDatas) {
            foreach(TileBase tile in tileData.tiles) {
                dataFromTiles.Add(tile, tileData);
            }
        }
    }

    private void LateUpdate() {
        if (Input.GetMouseButtonDown(0)) {
            GetTileBase(Input.mousePosition);
        }
    }

    public TileBase GetTileBase(Vector2 mousePosition) 
    {
        Vector3 worldPosition = Camera.main.ScreenToWorldPoint(mousePosition);
        Vector3Int tilemapPos = tilemap.WorldToCell(worldPosition);
        TileBase tile = tilemap.GetTile(tilemapPos);

        Debug.Log("Tile in position " + tilemapPos + " is " + tile);
        
        return null;
    }
}
