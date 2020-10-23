using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Opdrachten
{
    public class PathFollower : MonoBehaviour
    {
        public float speed = 10;
        private Path path;
        void Start()
        {
            path = GetComponent<Path>();
        }
        void Update()
        {
            transform.position = Vector3.MoveTowards(transform.position, path.waypoints[path.arrayIndex].transform.position, speed * Time.deltaTime);
        }
    }
}