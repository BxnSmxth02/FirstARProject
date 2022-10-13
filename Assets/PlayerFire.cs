using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    public GameObject projectilePrefab;

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount < 0 || Input.GetMouseButtonDown(0))
        {
            Ray dir = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);

            GameObject temp = Instantiate(projectilePrefab, Camera.main.transform.position, Quaternion.identity);

            temp.GetComponent<Rigidbody>().AddForce(dir.direction * 50f, ForceMode.Impulse);
        }
    }
}