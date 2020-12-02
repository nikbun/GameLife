using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class GameField : MonoBehaviour
{
	[SerializeField] private RectInt sizeRect;
	[SerializeField] private Tilemap tilemap;
	[SerializeField] private Tile borderTile;
	[SerializeField] private GameMap map;
	[SerializeField] private LifeCycle lifeCycle;

	public GameMap Map => map;

	public LifeCycle LifeCycle => lifeCycle;

	private void Start()
	{
		SetBorder(sizeRect.min - Vector2Int.one, sizeRect.max + Vector2Int.one);
		map.CreateMap(sizeRect, tilemap);
		lifeCycle.Initialize(map.GetCells());
	}

	private void SetBorder(Vector2Int borderMin, Vector2Int borderMax)
	{
		tilemap.ClearAllTiles();
		for (int x = borderMin.x; x <= borderMax.x; x++)
		{
			for (int y = borderMin.y; y <= borderMax.y; y++)
			{
				if (x == borderMin.x || x == borderMax.x || y == borderMin.y || y == borderMax.y)
				{
					tilemap.SetTile(new Vector3Int(x, y, 0), borderTile);
				}
			}
		}
	}
}
