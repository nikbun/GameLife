using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class LifeCycle : MonoBehaviour
{
	[Min(0.001f)]
	[SerializeField] private float cycleTime = 0.001f;

	private bool isPlay;
	private Coroutine playCoroutine;
	private List<Cell> cells;

	public bool IsPlay
	{
		get => isPlay;
		set
		{
			isPlay = value;
			if (isPlay)
			{
				Play();
			}
			else
			{
				Stop();
			}
		}
	}

	public void Initialize(List<Cell> cells)
	{
		this.cells = cells;
	}

	private void Play()
	{
		playCoroutine = StartCoroutine(PlayCoroutine());
	}

	private void Stop()
	{
		if (playCoroutine != null)
		{
			StopCoroutine(playCoroutine);
		}
	}

	private IEnumerator PlayCoroutine()
	{
		while (true)
		{
			yield return new WaitForSeconds(cycleTime);
			var toKillCells = GetToKillCells();
			var toReviveCells = GetToReviveCells();
			toKillCells.ForEach(c => c.Die());
			toReviveCells.ForEach(c => c.Revive());
		}
	}

	private List<Cell> GetToKillCells()
	{
		return cells.Where(c => c.IsAlive && 
			(c.GetCountLivingAdjacentCells() < 2 || c.GetCountLivingAdjacentCells() > 3)).ToList();
	}

	private List<Cell> GetToReviveCells()
	{
		return cells.Where(c => !c.IsAlive && c.GetCountLivingAdjacentCells() == 3).ToList();
	}
}
