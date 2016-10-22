using UnityEngine;

public class Player_Controller : MonoBehaviour
{
  private Rigidbody2D rigidbody2;

  // Use this for initialization
  void Start()
  {
    this.rigidbody2 = this.GetComponent<Rigidbody2D>();
  }

  // Update is called once per frame
  void LateUpdate()
  {
    var value = Input.GetAxis("Horizontal");
    if (value != 0f)
      this.transform.position += new Vector3(value * 2 * Time.deltaTime, 0);

    var jump = Input.GetKeyDown(KeyCode.Space);
    if (jump)
      rigidbody2.AddForce(new Vector2(0, 5), ForceMode2D.Impulse);
  }
}