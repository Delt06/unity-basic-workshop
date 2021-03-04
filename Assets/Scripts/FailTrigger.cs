using UnityEngine;

public class FailTrigger : MonoBehaviour
{
	public GameObject FailScreen;

	private void OnTriggerEnter(Collider other)
	{
		Rigidbody otherRigidbody = other.attachedRigidbody;
		if (otherRigidbody != null && otherRigidbody.CompareTag("Player"))
		{
			// Выключение перемещения
			otherRigidbody.GetComponent<Movement>().enabled = false;
			Debug.Log("Fail");
			FailScreen.SetActive(true);
		}
	}
}