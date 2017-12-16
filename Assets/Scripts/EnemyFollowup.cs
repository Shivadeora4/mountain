using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollowup : MonoBehaviour
{

   
    [SerializeField]
    Transform mTarget;
    [SerializeField]
    float mFollowSpeed;
    [SerializeField]
    float mFollowRange;

    float mArriveThreshold = 0.05f;

    void Update()
    {
        if (mTarget != null)
        {

            Vector3 targetPosition = new Vector3(mTarget.transform.position.x, mTarget.transform.position.y - 5, transform.position.z);
            Vector3 direction = targetPosition - transform.position;
            float distance = Vector2.Distance(targetPosition, transform.position);
            if (distance < mFollowRange)
            {

                transform.Translate(direction.normalized * mFollowSpeed * Time.deltaTime);
            }
        }
    }

    public void SetTarget(Transform target)
    {
        mTarget = target;
    }
}
