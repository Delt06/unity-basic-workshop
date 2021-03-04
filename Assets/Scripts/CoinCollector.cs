using UnityEngine;

public class CoinCollector : MonoBehaviour
{
	public int Coins;
	public CoinsText CoinsText;

	public void Collect(int coins)
	{
		Coins += coins;
		CoinsText.UpdateText(Coins);
		Debug.Log("Collected " + coins);
	}
}