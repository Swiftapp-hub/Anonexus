using UnityEngine;

public class Fusee : MonoBehaviour
{
    public int speed = 30;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
