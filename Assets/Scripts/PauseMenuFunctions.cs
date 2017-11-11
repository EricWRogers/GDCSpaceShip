using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenuFunctions : MonoBehaviour {

    //Sets up objects for Pause Menu.
    public GameObject PauseMenuTitle;
    public GameObject PauseMenuObjective;
    public GameObject PauseMenuHealth;
    public GameObject PauseMenuMaterial;
    public GameObject PauseMenuControls;
    public GameObject PauseMenuRetButton;
    public GameObject PauseMenuVolButton;
    public GameObject PauseMenuUpgButton;
    public GameObject PauseMenuMaiButton;

    //Sets up objects for Volume Menu
    public GameObject VolText;
	public GameObject VolButton;
    public GameObject VolSlider;

    //Sets up objects for Upgrade Menu
    public GameObject UpgradeMenuManager;
    public GameObject UpgradeMenuStats;
    public GameObject UpgradeMenuBack;
    public GameObject UpgradeMenuExecute;
    public GameObject UpgradeMenuDescriptions;


	public void RetGame()
    {
        //Returns to game.

    }

    public void VolControl()
    {
		//Goes to Volume Control

		//Turns off Pause Menu
		PauseMenuTitle.SetActive (false);
		PauseMenuControls.SetActive (false);
		PauseMenuObjective.SetActive (false);
		PauseMenuHealth.SetActive (false);
		PauseMenuMaterial.SetActive (false);
		PauseMenuRetButton.SetActive (false);
		PauseMenuVolButton.SetActive (false);
		PauseMenuUpgButton.SetActive (false);
		PauseMenuMaiButton.SetActive (false);

		//Turns on Vol Control
		VolText.SetActive (true);
		VolSlider.SetActive (true);
		VolButton.SetActive (true);
    }

	public void VolRet() 
	{
		//Returns from Vol Control to Pause Menu

		//Turns off Vol Control
		VolText.SetActive (false);
		VolSlider.SetActive (false);
		VolButton.SetActive (false);

		//Turns on Pause Menu
		PauseMenuTitle.SetActive (true);
		PauseMenuControls.SetActive (true);
		PauseMenuObjective.SetActive (true);
		PauseMenuHealth.SetActive (true);
		PauseMenuMaterial.SetActive (true);
		PauseMenuRetButton.SetActive (true);
		PauseMenuVolButton.SetActive (true);
		PauseMenuUpgButton.SetActive (true);
		PauseMenuMaiButton.SetActive (true);
	}

    public void UpgradeMenu()
    {
        //Goes to Upgrade Menu

		//Turns off Pause Menu
		PauseMenuTitle.SetActive (false);
		PauseMenuControls.SetActive (false);
		PauseMenuObjective.SetActive (false);
		PauseMenuHealth.SetActive (false);
		PauseMenuMaterial.SetActive (false);
		PauseMenuRetButton.SetActive (false);
		PauseMenuVolButton.SetActive (false);
		PauseMenuUpgButton.SetActive (false);
		PauseMenuMaiButton.SetActive (false);

		//Turns on Upgrade Menu
		UpgradeMenuManager.SetActive (true);
		UpgradeMenuStats.SetActive (true);
		UpgradeMenuDescriptions.SetActive (true);
		UpgradeMenuExecute.SetActive (true);
		UpgradeMenuBack.SetActive (true);
    }

    public void PauseMenu()
    {
		//Returns from Upgrade Menu to Pause Menu

		//Turns off Upgrade Menu
		UpgradeMenuManager.SetActive (false);
		UpgradeMenuStats.SetActive (false);
		UpgradeMenuDescriptions.SetActive (false);
		UpgradeMenuExecute.SetActive (false);
		UpgradeMenuBack.SetActive (false);

		//Turns on Pause Menu
		PauseMenuTitle.SetActive (true);
		PauseMenuControls.SetActive (true);
		PauseMenuObjective.SetActive (true);
		PauseMenuHealth.SetActive (true);
		PauseMenuMaterial.SetActive (true);
		PauseMenuRetButton.SetActive (true);
		PauseMenuVolButton.SetActive (true);
		PauseMenuUpgButton.SetActive (true);
		PauseMenuMaiButton.SetActive (true);

    }

    public void RetMM()
    {
        //Returns to Main Menu.

    }


	
}
