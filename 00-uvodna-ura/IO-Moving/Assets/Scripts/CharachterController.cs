using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharachterController : MonoBehaviour {

    [SerializeField] Rigidbody2D rigidbody2D;

    [Range(1, 50)]
    [SerializeField] private float jumpVelocity = 1.5f;

    [Range(1, 50)]
    [SerializeField] private float moveVelocity = 1.5f;

    [Range(1,10)]
    [SerializeField] private float fallMultiplier = 1.5f;

    [Range(1, 10)]
    [SerializeField] private float lowJumpMultiplier = 1.25f;

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.Space)) {
            rigidbody2D.velocity += Vector2.up * jumpVelocity;
        }

        if (Input.GetKey(KeyCode.RightArrow)) {
            rigidbody2D.velocity += Vector2.right * moveVelocity * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.LeftArrow)) {
            rigidbody2D.velocity += Vector2.left * moveVelocity * Time.deltaTime;
        }


        if (rigidbody2D.velocity.y < 0) {
            rigidbody2D.velocity += Vector2.up * Physics2D.gravity.y * fallMultiplier * Time.deltaTime;
        } else if (rigidbody2D.velocity.y > 0 && !Input.GetKey(KeyCode.Space)) {
            rigidbody2D.velocity += Vector2.up * Physics2D.gravity.y * lowJumpMultiplier * Time.deltaTime;
        }
        
    }
}
