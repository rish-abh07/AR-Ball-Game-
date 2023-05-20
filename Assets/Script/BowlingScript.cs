using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;


public class BowlingScript : MonoBehaviour
{
    public Camera Camera;
    public GameObject ballPrefab;
    public Slider slider;
    //public GameObject pins;
    public void LaunchBall()
    {
       GameObject ball = Instantiate(ballPrefab,Camera.transform.position,Camera.transform.rotation);
       Rigidbody ballRb = ball.GetComponent<Rigidbody>();
        Vector3 impulse = new Vector3(0.0f, 0.0f, slider.value * 100.0f);
        ballRb.AddRelativeForce(impulse , ForceMode.Impulse);
    }
}
