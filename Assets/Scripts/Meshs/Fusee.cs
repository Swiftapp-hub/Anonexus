using UnityEngine;

public class Fusee : MonoBehaviour
{
    public int speed = 30;
    public int speedRotate = 10;

    void Update()
    {
        transform.Translate(Vector3.forward * (Time.deltaTime * speed));
        transform.Rotate(Vector3.forward * (Time.deltaTime * speedRotate));
    }
}
