using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public SimpleTouchUI SimpleTouch;
    public Rigidbody _rigidbody;
    public float speed;
    private void Update()
    {
        _rigidbody.MovePosition(transform.position + (transform.forward * SimpleTouch.GetTouchPosition.y * Time.deltaTime * speed) +
            (transform.right * SimpleTouch.GetTouchPosition.x * Time.deltaTime * speed));
    }
}
