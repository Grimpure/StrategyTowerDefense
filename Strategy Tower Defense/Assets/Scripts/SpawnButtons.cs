using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnButtons : MonoBehaviour
{
    //What Unit to spawn, how much it costs and the cooldown before another can be spawned
    public GameObject friendlyUnit;
    public int unitPrice;
    public float unitCooldown;

    public void SpawnFriendlyUnit()
    {
        Instantiate(friendlyUnit);
    }
}
