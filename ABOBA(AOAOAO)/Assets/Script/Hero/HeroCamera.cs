using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroCamera : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform target;
    public Vector3 offset;
    public float zoomSpeed = 4f;
    public float minZoom = 5f;
    public float maxZoom = 15f;

    public float pitch = 2f;
    public float yawSpeed = 100f;

    public float currentZoom = 10f;
    public float currentYaw = 0;

    // Update is called once per frame
    void Update()
    {
        currentZoom -= Input.GetAxis("Mouse ScrollWheel") * zoomSpeed;// зум камеры
        currentZoom = Mathf.Clamp(currentZoom, minZoom, maxZoom);// ограничение камеры
        currentYaw -= Input.GetAxis("Horizontal") * yawSpeed * Time.deltaTime;//вращение камеры 
        transform.position = target.position - offset * currentZoom;// позиционирование камеры
        transform.LookAt(target.position + -Vector3.up * pitch);
        transform.RotateAround(target.position, Vector3.up, currentYaw);//вращение вокруг персонажа

    }
}