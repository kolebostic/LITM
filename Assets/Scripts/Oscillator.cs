using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscillator : MonoBehaviour
{
    public GameObject rotatedObject;
    private Vector3 objectPosition;
    public float rotateSpeed;
    public float movementSpeed;
    public float width;
    float timeCounter = 0;
    public float origX;
    public float origY;
    public float origZ;
    public float yOffset;

    // Start is called before the first frame update
    void Start()
    {
        rotatedObject = gameObject;
        objectPosition = new Vector3(origX, origY, origZ);
    }

    // Update is called once per frame
    void Update()
    {
        timeCounter += Time.deltaTime * movementSpeed;
        float x = objectPosition.x;
        float y = objectPosition.y;
        float z = objectPosition.z;

        if (gameObject.CompareTag("Key"))
        {
            rotatedObject.transform.position =
                new Vector3(
                    x,
                    y - 0.1f * timeCounter,
                    z);

            y -= 0.1f * timeCounter;

            rotatedObject.transform.Rotate(Vector3.back, Time.deltaTime * rotateSpeed);
            if (y < yOffset)
            {
                movementSpeed = 0;
            }
        }

        if (gameObject.CompareTag("FlyingBird"))
        {
            rotatedObject.transform.position = 
                new Vector3(
                    x + Mathf.Cos(timeCounter) * width, 
                    y, 
                    z + Mathf.Sin(timeCounter) * width);

            rotatedObject.transform.Rotate(Vector3.up, Time.deltaTime * rotateSpeed);
        }
        if (gameObject.CompareTag("feesh"))
        {
            rotatedObject.transform.position = 
                new Vector3(
                    x + Mathf.Cos(timeCounter) * width, 
                    y,
                    z + Mathf.Sin(timeCounter) * width);

            rotatedObject.transform.Rotate(Vector3.up, Time.deltaTime * rotateSpeed);
        }
        if (gameObject.CompareTag("Firefly1"))
        {
            rotatedObject.transform.position =
                new Vector3(
                    x + Mathf.Cos(timeCounter) * width,
                    y + Mathf.Sin(timeCounter) * width,
                    z);
        }
        if (gameObject.CompareTag("Firefly2"))
        {
            rotatedObject.transform.position =
                new Vector3(
                    x,
                    y + Mathf.Sin(timeCounter) * width,
                    z + 0.1f * timeCounter);
        }
    }
}
