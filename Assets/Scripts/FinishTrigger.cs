using UnityEngine;

public class FinishTrigger : MonoBehaviour
{
	public GameObject FinishScreen;
	
	private void OnTriggerEnter(Collider other)
	{
		Rigidbody otherRigidbody = other.attachedRigidbody;
		if (otherRigidbody != null && otherRigidbody.CompareTag("Player"))
		{
			// Выключение перемещения
			otherRigidbody.GetComponent<Movement>().enabled = false;
			Debug.Log("Finish");
			FinishScreen.SetActive(true);
		}
	}
}