using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{

    public bool isSelected = false;
    public float speed;

    SpriteRenderer spriteRederer;

    private void Awake() {

        spriteRederer = GetComponent<SpriteRenderer>();

        spriteRederer.color = new Color(Random.value, Random.value, Random.value);

    }

    private void Start() {

        if (GameController.gc.SelectedCharacter == this.gameObject) {
            isSelected = true;
        }

    }

    private void Update() {

        if (isSelected) {

            //Player controls this character

            //Move up
            if (Input.GetKey(KeyCode.W)) {
                transform.position = transform.position + Vector3.up * Time.deltaTime * speed;
            }
            //Move down
            if (Input.GetKey(KeyCode.S)) {
                transform.position = transform.position + Vector3.down * Time.deltaTime * speed;
            }
            //Move left
            if (Input.GetKey(KeyCode.A)) {
                transform.position = transform.position + Vector3.left * Time.deltaTime * speed;
            }
            //Move right
            if (Input.GetKey(KeyCode.D)) {
                transform.position = transform.position + Vector3.right * Time.deltaTime * speed;
            }

        }
        else {

            //Character allows its AI to control it

        }

    }


}
