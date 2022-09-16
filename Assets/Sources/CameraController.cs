using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _leftCamBorder;
    [SerializeField] private float _rightCamBorder;

    private float _targetPos;

    private Vector2 _startPos;

    private Camera _camera;

    private void Start()
    {
        _camera = GetComponent<Camera>();
        _targetPos = transform.position.x;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0)) _startPos = _camera.ScreenToWorldPoint(Input.mousePosition);
        else if (Input.GetMouseButton(0))
        {
            float pos = _camera.ScreenToWorldPoint(Input.mousePosition).x - _startPos.x;
            _targetPos = Mathf.Clamp(transform.position.x - pos, _leftCamBorder, _rightCamBorder);
        }
        transform.position = new Vector3(Mathf.Lerp(transform.position.x, _targetPos, _speed * Time.deltaTime), transform.position.y, transform.position.z);
    }
}
