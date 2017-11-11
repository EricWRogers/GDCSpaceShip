using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

namespace PMManager{

/*Still Needed:
	-Fonts
	-Ship Sprites
	-Ship models
	-Scoring Information 


	***Delete each after it is added***
*/

public class PM_Manager : MonoBehaviour {
		public Canvas TestCanvas;
		public Image SpeedBar, DamageBar, AmorBar, DescBox;
		public Text Description, ShipTitle, PlayerPoints;
		public Sprite Lock, ArmorMask,SpeedMask,DamageMask;

		int points=0;//for purchasing
		int upgrade=0;//upgrade selected

		public int playerpoints;
		public int cost; //points used? or upgrade gauge used?
		public int number;
		public int current;
		public bool locked;
		public string[] descriptions;
		public string[] titles;//number of upgrade 1-10


		double speed,armor,damage;

	// Use this for initialization
	void Start () {
			
		//For upgrade test
			descriptions[0] = "Please press an upgrade to view description";
			descriptions[1] = "Test ship one";
			descriptions[2] = "Test ship two";
			descriptions[3] = "Test ship three";
			descriptions[4] = "Test ship four";
			descriptions[5] = "Test ship five";
			descriptions[6] = "Test ship six";
			descriptions[7] = "Test ship seven";
			descriptions[8] = "Test ship eight";
		
			titles[0] = "No Title To Display";
			titles[1] = "Ship 1";
			titles[2] = "Ship 2";
			titles[3] = "Ship 3";
			titles[4] = "Ship 4";
			titles[5] = "Ship 5";
			titles[6] = "Ship 6";
			titles[7] = "Ship 7";
			titles[8] = "Ship 8";

			//@TODO: Figure out why the array won't count the 9th or 10th element
			number = 0;


		//End test
		
		
	}

		//Button functions

		public void Select(){
			//Which button is selected, will be the numbered upgrade to be displayed
			//Test button upgrade
			var current= EventSystem.current.currentSelectedGameObject;
			number = int.Parse (current.tag.ToString());
			Debug.Log ("Button " + number + " has been pressed");
			ShowInfo (number);


			//End test
		}

		public void Back(){
			//Go back to previous screen
		}

		public void Buy(){
			//purchase function--will do reset the meter back to empty
			ShipTitle.text = "TODO:";
			Description.text = "Things to be worked on: Stats Bars, Font, Purchase/Back/Buy Buttons, ship info needed, point system (11/7/2017)";
		}

		public void Execute(){
			//play game
		}

		void ShowInfo(int n){ //shows the info of the upgrade in the upgrade box
			Description.text=descriptions[n];
			ShipTitle.text = titles[n];

		}




	// Update is called once per frame
	void Update () {
		
	}
}

}
