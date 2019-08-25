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
            //Next character button released
            if (Input.GetKeyUp(KeyCode.E)) {

                GameController.gc.NextCharacter();

            }
            //Prev character button released
            if (Input.GetKeyUp(KeyCode.Q)) {

                GameController.gc.PrevCharacter();

            }
        }
        else {

            //Character allows it's AI to control it

        }

    }


}
