using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using System.Linq;

public class GameMap : MonoBehaviour
{
	[SerializeField] private Cell sampleCell;

	private Tilemap tilemap;
	private Dictionary<Vector2Int, Cell> cells = new Dictionary<Vector2Int, Cell>();

	public void CreateMap(RectInt sizeRect, Tilemap tilemap)
	{
		this.tilemap = tilemap;
		for (int x = sizeRect.xMin; x <= sizeRect.xMax; x++)
		{
			for (int y = sizeRect.yMin; y <= sizeRect.yMax; y++)
			{
				var position = new Vector2Int(x, y);
				var cell = Instantiate(sampleCell);
				cell.Initialize(position, tilemap);
				cells.Add(position, cell);
			}
		}
		foreach (var cell in cells)
		{
			cell.Value.AdjacentCells = GetAdjacentCells(cell.Key);
		}
	}

	public void TryReviveCell(Vector2 worldPosition)
	{
		var cellPosition = (Vector2Int)tilemap.WorldToCell(worldPosition);
		if (cells.ContainsKey(cellPosition))
		{
			cells[cellPosition].Revive();
		}
	}

	public void TryKillCell(Vector2 worldPosition)
	{
		var cellPosition = (Vector2Int)tilemap.WorldToCell(worldPosition);
		if (cells.ContainsKey(cellPosition))
		{
			cells[cellPosition].Die();
		}
	}

	public List<Cell> GetAdjacentCells(Vector2Int position)
	{
		var adjacentCells = new List<Cell>();
		var sizeRect = new RectInt(position - Vector2Int.one, Vector2Int.one * 2);

		for (int x = sizeRect.xMin; x <= sizeRect.xMax; x++)
		{
			for (int y = sizeRect.yMin; y <= sizeRect.yMax; y++)
			{
				var adjacentPosition = new Vector2Int(x, y);
				if (cells.ContainsKey(adjacentPosition) && position != adjacentPosition)
				{
					adjacentCells.Add(cells[adjacentPosition]);
				}
			}
		}

		return adjacentCells;
	}

	public List<Cell> GetCells()
	{
		return cells.Select(c => c.Value).ToList();
	}
}
