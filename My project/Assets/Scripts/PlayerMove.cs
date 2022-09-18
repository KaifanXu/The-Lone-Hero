
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 0.1f;
    // Update is called once per frame
    void Update()
    {
        float movingX = Input.GetAxis("Horizontal");
        float movingY = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(movingX, 0.0f, movingY);

        transform.position += movement * speed;
    }
}
