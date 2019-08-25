using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

    //Singleton instance
    public static GameController gc;

    public GameObject SelectedCharacter;
    public GameObject CharacterPrefab;

    public int startingCharacters;

    //Unity default method, like start except it happens first
    private void Awake() {

        //Makes sure that there is only one instance of the gc reference
        if (gc != null) {
            Destroy(gc);
        }
        gc = this;

        for (int i = 0; i < startingCharacters; i++) {

            GameObject tempCharacter = Instantiate(CharacterPrefab, new Vector3(Random.Range(0f,10f), Random.Range(0f , 6f), 0f), Quaternion.Euler(Vector3.zero));

            if (SelectedCharacter == null) {
                SelectedCharacter = tempCharacter;
            }

        }

    }

}
