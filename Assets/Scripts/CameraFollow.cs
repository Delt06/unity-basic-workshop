using UnityEngine;

public class CameraFollow : MonoBehaviour
{
	public Transform FollowTarget;

	private void LateUpdate()
	{
		// Камера всегда находится на определенном расстоянии от цели
		Vector3 newPosition = FollowTarget.position + _offset;
		newPosition.y = _fixedY; // но Y фиксирован (чтобы камера не падала вниз за целью)
		transform.position = newPosition;
	}

	private void Awake()
	{
		Vector3 initialPosition = transform.position;
		_offset = initialPosition - FollowTarget.position;
		_fixedY = initialPosition.y;
	}

	private float _fixedY;
	private Vector3 _offset;
}