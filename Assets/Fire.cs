using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public FireBall fireBall;
    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Debug.Log("Fire!");
            FireBall f = Instantiate(fireBall, new Vector3(transform.position.x,transform.position.y,transform.position.z + 1f), Quaternion.identity);
        }
    }
}
