using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSwipeScript : MonoBehaviour
{
    public  Vector3 StartPosition;
    public  Vector3 EndPosition;
    public  Vector3 Direction;
    public Rigidbody rb;
    public Transform endgoal;
    public float throwForce = 10f;
    public bool canMove = true;

  

     void Start()
    {
        rb = GetComponent<Rigidbody>();
        endgoal = spawningScript.instance.Goal.transform;
      

    }

     void FixedUpdate()
    {
        if (!canMove)
            return;
        if (Input.touchCount > 0)
        {
            print("touch detected ");
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                print("touch began ");
                Vector3 touchPos = Input.GetTouch(0).position; //storing the position of touch 
                touchPos.z = -Camera.main.transform.position.z; //
               // StartPosition = Camera.main.ScreenToWorldPoint(touchPos);
                StartPosition = touchPos;
            }
            if (touch.phase == TouchPhase.Moved)
            {
                print("moved ");
                Vector3 touchPos = Input.GetTouch(0).position;
                touchPos.z = -Camera.main.transform.position.z;
                //EndPosition = Camera.main.ScreenToWorldPoint(touchPos);
                EndPosition = touchPos;
                Direction = (EndPosition - StartPosition).normalized;
            }

            if (touch.phase == TouchPhase.Ended)
            {
                canMove = false;
                Vector3 touchPos = Input.GetTouch(0).position;
                touchPos.z = -Camera.main.transform.position.z;
                //EndPosition = Camera.main.ScreenToWorldPoint(touchPos);
                EndPosition = touchPos;
                Direction = (EndPosition - StartPosition).normalized;

                Vector3 endPoint = (endgoal.position - transform.position).normalized;
                Direction += endPoint; // Add goal direction to the throw direction

                rb.AddForce(Direction* throwForce, ForceMode.Impulse);
                spawningScript.instance.spawnBall = true;
                Destroy(gameObject, 3f);
                
            }
        }
    }
    
}
