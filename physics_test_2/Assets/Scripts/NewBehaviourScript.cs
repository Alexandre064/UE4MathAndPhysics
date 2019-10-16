using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    GameObject prefab;
    int dragForce=0, massForce=1;
    // Start is called before the first frame update
    void Start()
    {
        prefab = Resources.Load("Sphere") as GameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject projectile = Instantiate(prefab) as GameObject;
            Rigidbody rigidbody = projectile.GetComponent<Rigidbody>();
            rigidbody.velocity = Camera.main.transform.forward * 40;
            rigidbody.drag = dragForce;
            rigidbody.mass = massForce;
            projectile.transform.position = transform.position + Camera.main.transform.forward * 2;

        }
        if (Input.GetKeyUp(KeyCode.C))
        {
            dragForce++;
            Debug.Log("Drag :" + dragForce);
        }
        if (Input.GetKeyUp(KeyCode.V))
        {
            dragForce--;
            Debug.Log("Drag :" + dragForce);
        }
        if (Input.GetKeyUp(KeyCode.B))
        {
            massForce++;
            Debug.Log("Mass :" + massForce);
        }
        if (Input.GetKeyUp(KeyCode.N))
        {
            massForce--;
            Debug.Log("Mass :" + massForce);
        }
    }
}
