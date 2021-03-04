using UnityEngine;
using UnityEngine.UI;

public class CoinsText : MonoBehaviour
{
	public void UpdateText(int coins)
	{
		_text.text = coins.ToString();
	}
	
	private void Awake()
	{
		_text = GetComponent<Text>();
	}

	private Text _text;
}