using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public float speed;

    // Update is called once per frame
    void FixedUpdate()
    {

        if (GameController.gc.SelectedCharacter != null) {

            Vector3 targetObject = new Vector3(GameController.gc.SelectedCharacter.transform.position.x , GameController.gc.SelectedCharacter.transform.position.y , -10f);
            transform.position = Vector3.Lerp(transform.position , targetObject , speed * Time.deltaTime);

        }
        else {
            transform.position = Vector3.Lerp(transform.position , new Vector3(0f,0f, -10f) , speed * Time.deltaTime);
        }

    }
}
