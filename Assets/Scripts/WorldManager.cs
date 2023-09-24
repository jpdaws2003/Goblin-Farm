using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Tilemaps;

public class WorldManager : MonoBehaviour
{
    // [SerializeField] private Tilemap soilTileMap;
    // [SerializeField] private Tilemap tilledTileMap;
    // [SerializeField] private Tile plowableTile;
    // [SerializeField] private Tile plowedTile;

    // void LateUpdate()
    // {
    //     if (Input.GetMouseButtonDown(0))
    //     {
    //         PlowTile();
    //     }
    //     if (Input.GetMouseButton(1)) {
    //         UnPlowTile();
    //     }
    // }

    // private void UnPlowTile() {
    //     Vector3Int tilePos = tilledTileMap.WorldToCell(Camera.main.ScreenToWorldPoint(Input.mousePosition));
    //     Tile tile = tilledTileMap.GetTile<Tile>(tilePos);

    //     if (tile == plowedTile)
    //     {
    //         //get distance from player to tile
    //         var distance = Vector2.Distance(Player.Instance.Position, soilTileMap.GetCellCenterWorld(tilePos));
    //         if (distance <= Player.Instance.range) {
    //             //plow tile
    //             tilledTileMap.SetTile(tilePos, null);
    //         }
    //     }
    // }

    // private void PlowTile() {
    //     Vector3Int tilePos = soilTileMap.WorldToCell(Camera.main.ScreenToWorldPoint(Input.mousePosition));
    //     Tile tile = soilTileMap.GetTile<Tile>(tilePos);

    //     if (tile == plowableTile)
    //     {
    //         //get distance from player to tile
    //         var distance = Vector2.Distance(Player.Instance.Position, soilTileMap.GetCellCenterWorld(tilePos));
    //         if (distance <= Player.Instance.range) {
    //             //plow tile
    //             tilledTileMap.SetTile(tilePos, plowedTile);
    //         }
    //     }
    // }
}

//tileMap.RefreshTile()
//when a tile is plowed, it should set a timer. Then when that timer is up, and there is no crop planted on it, it should return to normal.
//Either add a timer to every single tile when it is plowed to do so on it's own
//Or have a tick system, where the tile sends a command to happen in x ticks, and when the tick happens, the worldManager runs all commands, and runs refresh function on tile
//So either figure out how to get a script on plowed tiles, or handle it all from here, sending the tile position and tick to be refreshed to worldManager.

//Learn about event system in unity, finish on scriptable objects
//Set up code to go to VSCode and remove unwanted files
