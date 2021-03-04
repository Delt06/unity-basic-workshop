using UnityEngine;

public class Coin : MonoBehaviour
{
	public int Value = 1;
	
	private void OnTriggerEnter(Collider other)
	{
		Rigidbody otherRigidbody = other.attachedRigidbody;
		if (otherRigidbody == null) return;

		// Проверка компонента на Rigidbody, который вошел в триггер
		CoinCollector coinCollector = otherRigidbody.GetComponent<CoinCollector>();
		if (coinCollector != null) // coinCollector будет null, если компонент на otherRigidbody нет нужного компонента
		{
			coinCollector.Collect(Value);
			Destroy(gameObject);
		}
	}
}