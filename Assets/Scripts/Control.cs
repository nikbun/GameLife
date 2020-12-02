using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
	[SerializeField] private GameField gameField;
	
	private GameMap gameMap;
	private LifeCycle lifeCycle;
	private PlayerInput input;

	private bool IsAdded;
	private bool IsRemoved;

	private void Awake()
	{
		input = new PlayerInput();
	}

	private void OnEnable()
	{
		input.Enable();
	}

	private void OnDisable()
	{
		input.Disable();
	}

	private void Start()
	{
		gameMap = gameField.Map;
		lifeCycle = gameField.LifeCycle;

		input.Player.AddCell.performed += _ => IsAdded = true;
		input.Player.AddCell.canceled += _ => IsAdded = false;

		input.Player.RemoveCell.performed += _ => IsRemoved = true;
		input.Player.RemoveCell.canceled += _ => IsRemoved = false;

		input.Player.PlayPause.performed += _ => lifeCycle.IsPlay = !lifeCycle.IsPlay;
	}

	private void Update()
	{
		if (IsAdded)
		{
			AddCell();
		}
		if (IsRemoved)
		{
			RemoveCell();
		}
	}

	private void AddCell()
	{
		gameMap.TryReviveCell(GetWorldMousePosition());
	}
	private void RemoveCell()
	{
		gameMap.TryKillCell(GetWorldMousePosition());
	}

	private Vector2 GetWorldMousePosition()
	{
		Vector2 mousePosition = input.Player.MousePosition.ReadValue<Vector2>();
		return Camera.main.ScreenToWorldPoint(mousePosition);
	}
}
