using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class ToolsController : MonoBehaviour
{
    [SerializeField] private Tilemap soilTileMap;
    [SerializeField] private Tilemap tilledTileMap;
    [SerializeField] private Tile plowableTile;
    [SerializeField] private Tile plowedTile;

    void LateUpdate()
    {
        if (Input.GetMouseButtonDown(0))
        {
            PlowTile();
        }
        if (Input.GetMouseButton(1)) {
            UnPlowTile();
        }
    }

    private void UnPlowTile() {
        Vector3Int tilePos = tilledTileMap.WorldToCell(Camera.main.ScreenToWorldPoint(Input.mousePosition));
        Tile tile = tilledTileMap.GetTile<Tile>(tilePos);

        if (tile == plowedTile)
        {
            //get distance from player to tile
            var distance = Vector2.Distance(Player.Instance.Position, soilTileMap.GetCellCenterWorld(tilePos));
            if (distance <= Player.Instance.range) {
                //plow tile
                tilledTileMap.SetTile(tilePos, plowableTile);
            }
        }
    }

    private void PlowTile() {
        Vector3Int tilePos = soilTileMap.WorldToCell(Camera.main.ScreenToWorldPoint(Input.mousePosition));
        Tile tile = soilTileMap.GetTile<Tile>(tilePos);

        if (tile == plowableTile)
        {
            //get distance from player to tile
            var distance = Vector2.Distance(Player.Instance.Position, soilTileMap.GetCellCenterWorld(tilePos));
            if (distance <= Player.Instance.range) {
                //plow tile
                tilledTileMap.SetTile(tilePos, plowedTile);
            }
        }
    }
}
