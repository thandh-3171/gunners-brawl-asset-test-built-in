using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public Vector3 speed = new Vector3(20, 0, 25);
    private Vector3 motion;

    private void Start() { }

    void Update()
    {
        motion = new Vector3(Input.GetAxisRaw("Horizontal") * speed.x, 0, Input.GetAxisRaw("Vertical") * speed.z);
        transform.Translate(motion * Time.deltaTime);
    }
}
