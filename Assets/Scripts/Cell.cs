using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Tilemaps;

[CreateAssetMenu(fileName = "New Cell", menuName = "Cell", order = 51)]
public class Cell : ScriptableObject
{
    [SerializeField] private Tile deadTile;
    [SerializeField] private Tile aliveTile;

    private Tilemap tilemap;

    public bool IsAlive
	{
        get;
        private set;
	}

    public Vector2Int Position 
    {
        get;
        private set;
    }

    public List<Cell> AdjacentCells
	{
        get;
        set;
	}

    public Cell Initialize(Vector2Int position, Tilemap tilemap)
	{
        Position = position;
        this.tilemap = tilemap;
        tilemap.SetTile((Vector3Int)Position, deadTile);
        return this;
	}

    public void Revive()
	{
        if (!IsAlive)
		{
            tilemap.SetTile((Vector3Int)Position, aliveTile);
            IsAlive = true;
        }
	}

    public void Die()
    {
        if (IsAlive)
        {
            tilemap.SetTile((Vector3Int)Position, deadTile);
            IsAlive = false;
        }
    }

    public int GetCountLivingAdjacentCells()
	{
        return AdjacentCells.Count(ac => ac.IsAlive == true);
	}
}
