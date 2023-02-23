using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTowardsMouse : MonoBehaviour
{

        public float moveSpeed = 2.0f;  // speed at which the object moves towards the mouse position

        private Vector3 targetPosition;  // position to move towards

        void Start()
        {
            // set the initial target position to the current position
            targetPosition = transform.position;
        }

        void Update()
        {
            // check if the left mouse button is pressed
            if (Input.GetMouseButton(0))
            {
                // set the target position to the mouse position on the screen
                targetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                targetPosition.z = transform.position.z;  // maintain the original z position
            }

            // calculate the direction and distance to the target position
            Vector3 direction = (targetPosition - transform.position).normalized;
            float distance = Vector3.Distance(transform.position, targetPosition);

            // move the object towards the target position if it is not already there
            if (distance > 0.1f)
            {
                transform.Translate(direction * moveSpeed * Time.deltaTime);
            }
        }
}

