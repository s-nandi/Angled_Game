using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    public float distance = 40f;

    private struct PointInSpace
    {
        public Vector3 Position;
        public float Time;
    }

    private float delay = 0.1f;
    private float speed = 5;
    private Queue<PointInSpace> pointsInSpace = new Queue<PointInSpace>();

    void LateUpdate()
    {
        // Add the current target position to the list of positions
        pointsInSpace.Enqueue(new PointInSpace() { Position = player.transform.position, Time = Time.time });

        // Move the camera to the position of the target X seconds ago 
        while (pointsInSpace.Count > 0 && pointsInSpace.Peek().Time <= Time.time - delay + Mathf.Epsilon)
        {
            Vector3 pos = Vector3.Lerp(transform.position, pointsInSpace.Dequeue().Position, Time.deltaTime * speed);
            pos.z -= distance;
            transform.position = pos;
        }
    }

}
