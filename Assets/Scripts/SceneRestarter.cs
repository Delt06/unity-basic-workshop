using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneRestarter : MonoBehaviour
{
	public void Restart()
	{
		Scene activeScene = SceneManager.GetActiveScene();
		int activeSceneIndex = activeScene.buildIndex;
		SceneManager.LoadScene(activeSceneIndex);
	}
}