//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class BallSwipeScript : MonoBehaviour
//{
//    private Vector3 dragStartPosition;
//    private Vector3 dragEndPosition;
//    private Vector3 throwDirection;

//    public Rigidbody rb;
//    public Transform goal;

//    public float throwForce = 10f;

//    private void Start()
//    {
//        rb = GetComponent<Rigidbody>();
//    }

//    private void FixedUpdate()
//    {
//        if (Input.touchCount > 0)
//        {
//            print("1");
//            Touch touch = Input.GetTouch(0);
//            if (touch.phase == TouchPhase.Began)
//            {
//                Vector3 touchPos = Input.GetTouch(0).position;
//                touchPos.z = -Camera.main.transform.position.z;
//                dragStartPosition = Camera.main.ScreenToWorldPoint(touchPos);
//            }
//            if (touch.phase == TouchPhase.Moved)
//            {
//                Vector3 touchPos = Input.GetTouch(0).position;
//                touchPos.z = -Camera.main.transform.position.z;
//                dragEndPosition = Camera.main.ScreenToWorldPoint(touchPos);
//                throwDirection = (dragEndPosition - dragStartPosition).normalized;
//            }

//            if (touch.phase == TouchPhase.Ended)
//            {
//                Vector3 touchPos = Input.GetTouch(0).position;
//                touchPos.z = -Camera.main.transform.position.z;
//                dragEndPosition = Camera.main.ScreenToWorldPoint(touchPos);
//                throwDirection = (dragEndPosition - dragStartPosition).normalized;

//                Vector3 goalDirection = (goal.position - transform.position).normalized;
//                throwDirection += goalDirection; // Add goal direction to the throw direction

//                rb.AddForce(throwDirection * throwForce, ForceMode.Impulse);
//            }
//        }
//    }
//}
