using UnityEngine;
using System.Collections;

public class Player_Collision : MonoBehaviour
{

  // Use this for initialization
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {

  }

  void OnTriggerEnter2D(Collider2D collider)
  {
    var pickup = collider.CompareTag("Pickup");
    if (pickup)
      collider.gameObject.SetActive(false);

    var enemy = collider.CompareTag("Enemy");
    if (enemy)
      gameObject.SetActive(false);
  }
}