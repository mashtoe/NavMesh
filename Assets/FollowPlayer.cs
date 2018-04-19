using UnityEngine;
using System.Collections;
using UnityEngine.AI;

public class FollowPlayer : MonoBehaviour
{
    public Transform M_Player;
    // Use this for initialization
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()

    {

        GetComponent<NavMeshAgent>().destination = M_Player.position;
    }


}
