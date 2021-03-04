using UnityEngine;

public class Movement : MonoBehaviour
{
	[SerializeField] private float _speed = 1f;
	[SerializeField] private Vector3 _direction1 = Vector3.forward;
	[SerializeField] private Vector3 _direction2 = Vector3.left;

	private void Update()
	{
		if (Input.GetMouseButtonDown(0)) // клик левой кнопкой мыши
		{
			if (_directionIndex == 0)
				_directionIndex = 1;
			else
				_directionIndex = 0;
		}
	}

	private void FixedUpdate()
	{ 
		Vector3 velocity = GetDirection() * _speed;
		velocity.y = _rigidbody.velocity.y; // не меняем Y, чтобы гравитация работала
		_rigidbody.velocity = velocity;
	}

	private Vector3 GetDirection()
	{
		if (_directionIndex == 0)
			return _direction1;
		return _direction2;
	}

	private void Awake()
	{
		_rigidbody = GetComponent<Rigidbody>();
	}

	private void OnDisable()
	{
		// Остановка при отключении компонента
		Vector3 velocity = Vector3.zero;
		velocity.y = _rigidbody.velocity.y;
		_rigidbody.velocity = velocity;
	}

	private Rigidbody _rigidbody;
	private int _directionIndex;
}