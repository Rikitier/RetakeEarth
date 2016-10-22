using UnityEngine;
using System.Collections;

public class Alien_Controller : MonoBehaviour
{
  private float time;
  private bool left;

  // Use this for initialization
  void Start()
  {
    time = 0f;
    left = true;
  }

  // Update is called once per frame
  void Update()
  {
    time = time + Time.deltaTime;

    if (time > 3)
    {
      time = 0f;
      left = !left;
    }

    if (left)
      transform.position += new Vector3(-2 * Time.deltaTime, 0);
    else
      transform.position += new Vector3(2 * Time.deltaTime, 0);
  }
}