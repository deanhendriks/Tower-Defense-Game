using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace Opdrachten
{
    public class Path : MonoBehaviour
    {
        public Transform[] waypoints;
        public int arrayIndex = 0;
        public UnityEvent onFinalWaypointReached;
        public CameraShake shake;


        void Start()
        {
            arrayIndex = 0;
            Waypoints wp = GetComponent<Waypoints>();
        }

        void Update()
        {
            GetNextWaypoint();
        }

        public Waypoints GetNextWaypoint()
        {
             transform.LookAt(waypoints[arrayIndex]); 
            //Als de gameObject de positie bereikt. Dan gaat hij naar de volgende.
            if (transform.position == waypoints[arrayIndex].transform.position)
            {
                arrayIndex++;
            }

            //Als het gelijk staat met de lengte van de array. Dan gaat ie weer terug naar het begin.
            if (arrayIndex == waypoints.Length)
            {
                StartCoroutine(shake.ShakeCamera(2f));
                arrayIndex = waypoints.Length;
                onFinalWaypointReached.Invoke();
                Destroy(this.gameObject,0.1f);
            }
            return null;
        }
    }
}