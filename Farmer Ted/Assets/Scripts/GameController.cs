using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

    //Singleton instance
    public static GameController gc;

    public List<CharacterController> Characters = new List<CharacterController>();
    public CharacterController SelectedCharacter;
    public GameObject CharacterPrefab;

    public int startingCharacters;
    int characterIndex = 0;

    //Unity method
    private void Awake() {

        //Makes sure that there is only one instance of the gc reference
        if (gc != null) {
            Destroy(gc);
        }
        gc = this;

        for (int i = 0; i < startingCharacters; i++) {

            GameObject tempCharacter = Instantiate(CharacterPrefab, new Vector3(Random.Range(0f,10f), Random.Range(0f , 6f), 0f), Quaternion.Euler(Vector3.zero));
            Characters.Add(tempCharacter.GetComponent<CharacterController>());

        }

        SelectCharacter(0);

    }
    
    //Selects the next Character in the list
    public void NextCharacter() {

        print("Next Character");
        SelectCharacter(characterIndex + 1);

    }

    //Selects the previous character in the list
    public void PrevCharacter() {

        print("Prev Character");
        SelectCharacter(characterIndex - 1);

    }

    void SelectCharacter(int newIndex) {

        if (SelectedCharacter == null) {
            SelectedCharacter = Characters[0];
            SelectedCharacter.isSelected = true;
        }
        else {

            if (newIndex < 0) {
                characterIndex = Characters.Count - 1;
            }
            else if (newIndex > Characters.Count - 1) {
                characterIndex = 0;
            }
            else {
                characterIndex = newIndex;
            }

            //print("Selected: " + characterIndex);

            SelectedCharacter.isSelected = false;
            SelectedCharacter = Characters[characterIndex];
            SelectedCharacter.isSelected = true;

        }

    }
}
