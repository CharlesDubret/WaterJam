using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
	private int _waterLevel = 0;
	[SerializeField] private List<Transform> waterLevelPositions;
	private Dictionary<int, Transform> levels = new Dictionary<int, Transform>();
	[SerializeField] private GameObject Water;

	[SerializeField] private ObjectLerper _ol;

	private void Start()
	{
		int i = 0;
		foreach (Transform tsf in waterLevelPositions)
		{
			levels[i] = tsf;
			i++;
		}
	}

	public void LevelUp()
	{
		_waterLevel++;
		RaiseWaterLevel();
	}

	private void RaiseWaterLevel()
	{
		StartCoroutine(_ol.StartLerp(levels[_waterLevel - 1].position));
	}

	public void EndGame()
	{
		SceneManager.LoadScene("MainScene");
	}
}