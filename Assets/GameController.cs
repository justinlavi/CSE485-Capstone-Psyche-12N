using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public Character character;  // Reference to the character script
    public Spaceship_script spaceship;  // Reference to the spaceship script
    public Asteroid_script asteroid;

    private bool isControllingCharacter = true;

    private void Start()
    {
        character.enabled = isControllingCharacter;
        asteroid.enabled = isControllingCharacter;
        spaceship.enabled = !isControllingCharacter;

    }
    private void Update()
    {
        // Check for the input key to toggle control
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            isControllingCharacter = !isControllingCharacter;

            // Enable or disable control scripts based on the toggle state
            character.enabled = isControllingCharacter;
            asteroid.enabled = isControllingCharacter;  
            spaceship.enabled = !isControllingCharacter;
        }
    }
}
