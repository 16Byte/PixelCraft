using UnityEngine;
using System.Collections;

public class BlockCoal : Block {

    public BlockCoal()
        : base() 
    {
 
    }

    public override Tile TexturePosition(Direction direction)
    {
        Tile tile = new Tile();

        /*switch (direction)
        {
            case Direction.up:
                tile.x = 0;
                tile.y = 3;
                return tile;
            case Direction.down:
                tile.x = 0;
                tile.y = 3;
                return tile;
             
        }
        */

            tile.x = 0;
            tile.y = 3;

        return tile;
    }



}
