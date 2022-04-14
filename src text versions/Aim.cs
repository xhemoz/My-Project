using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aim : MonoBehaviour
{
    [SerializeField]
    private Camera cam;

    private float screenX;
    private float screenY;


    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
        screenX = Screen.width / 2;
        screenY = Screen.height / 2;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 reticle = new Vector3(screenX, screenY, 0f);
        Vector3 rayOrigin = cam.ViewportToWorldPoint(reticle);
        RaycastHit hit;
        if (Physics.Raycast(rayOrigin, cam.transform.forward, out hit, 1000))
        {
            transform.LookAt(hit.point);
        }
        transform.rotation.SetLookRotation(cam.transform.up);
    }
}
