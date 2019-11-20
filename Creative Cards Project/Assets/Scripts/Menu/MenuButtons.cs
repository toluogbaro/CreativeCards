// This script just contains functions that get called from clicking on buttons using Unity's UI system.
// Put this script on an object in the scene and use the event properties of the UI components to run the desired method.
// Any method set as "public void" on any script in the scene can be run by the UI event system.
using UnityEngine;
// using UnityEngine.UI; // If we are accessing UI components (eg Text, Button, Slider etc.) you need to use this library.

public class MenuButtons : MonoBehaviour {

    public GameObject mainMenuObject; // The Game Object that holds the Main menu UI elements. (we need a reference to this to switch it on and off).
    public GameObject helpMenuObject; // The Game Object that holds the Help Menu UI elements. (we need a reference to this to switch it on and off).

    // This method runs when the object is loaded or instantiated.
    // Use this to set the initial state of things and setup  references to objects the script needs.
    private void Start()
    {
        #region Development Debug
        // During development, it is useful to have some code to ensure that
        // required properties have been properly set in the ispector.
        // This will give the developer better information about anything they have to fix.
        if (!mainMenuObject)
            Debug.LogError("You need to set the main menu object on " + gameObject.name);
        if (!helpMenuObject)
            Debug.LogError("You need to set the help menu object on " + gameObject.name);
        #endregion

        // It is sometimes useful to show and hide UI elements at the start with script, 
        // rather than rely on them being setup correctly in the scene.
        mainMenuObject.SetActive(true);
        helpMenuObject.SetActive(false);
    }

    // This method toggles the UI objects on and off.
    // It is intneded to be run from a UI component.
    public void ToggleMenuPanels()
    {
        //SetActive() enables or disables a game object.  activeSelf tells us if a game object is active or not. 
        mainMenuObject.SetActive(!mainMenuObject.activeSelf);
        helpMenuObject.SetActive(!helpMenuObject.activeSelf);
    }

    // This method will define what happens when the user presses the start button.
    // It is intneded to be run from a UI component.
    public void PressStartButton()
    {
        Debug.Log("Start button pressed.");
        // VV Add code here to define what happens... VV

        // ^^   ^^
    }

    // This method will define what happens when the user clicks the help button.
    // It is intneded to be run from a UI component.
    public void PressHelpButton()
    {
        Debug.Log("Help button pressed.");
        // VV Add code here to define what happens... VV

        // ^^   ^^
    }

    // This method will define what happens when the user presses the quit button.
    // It is intneded to be run from a UI component.
    public void PressQuitButton()
    {
        Debug.Log("Quit button pressed.");
        // VV Add code here to define what happens... VV

        // ^^   ^^
    }

    // NB You could use the same process in the worksheet to extend the functionality of the quit button by adding a quit confirmation panel.
    // The script will need to know the game object that holds the quit confirmation elements.
    // We could add the methods here and hook them up to buttons in the same way.
}
