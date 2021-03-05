using UnityEngine;

public class OrderDemoScript : MonoBehaviour
{
	private void Awake()
	{
		Debug.Log("Awake");
	}

	private void OnEnable()
	{
		Debug.Log("OnEnable");
	}

	private void Start()
	{
		Debug.Log("Start");
	}

	private void Update()
	{
		Debug.Log("Update");
	}

	private void OnDisable()
	{
		Debug.Log("OnDisable");
	}

	private void OnDestroy()
	{
		Debug.Log("OnDestroy");
	}
}

