using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class InventoryStruct
{
    Tile material;
    struct Wood {
        int woodAmount;

    }

    struct Stone {
        int stoneAmount;

    }
    struct Grass {
        int grassAmount;

    }
    struct Dirt {
        int dirtAmount;
    }

    public Tile GetMaterial() {
        return material;
    }

    
}
