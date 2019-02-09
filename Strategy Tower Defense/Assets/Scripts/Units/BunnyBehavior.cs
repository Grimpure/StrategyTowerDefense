using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BunnyBehavior : MonoBehaviour
{

    public Vector3 speed = new Vector3(3, 0, 0); //Speed at which the Unit Moves
    public float health = 50; //Unit's Health
    public float defense = 0; //Unit's damage-cancellation
    public float attackStrength = 5; //How hard the Unit hits

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= speed * Time.deltaTime;

        if(health >= 0) //Unit dies
        {

        }
    }
}
