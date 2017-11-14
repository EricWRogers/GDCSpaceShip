using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class Upgrade_Manager : MonoBehaviour {
		public Canvas TestCanvas;
		public Image SpeedBar, DamageBar, AmorBar, DescBox,ArmorMask,DamageMask,SpeedMask,GreyLock;
		public Text Description, ShipTitle, PlayerPoints, XP;
		public Sprite Lock,Unlock;
		int points=0;//for purchasing
		int upgrade=0;//upgrade selected

		[Space (20)]
		[Header ("Selection")]
		public int playerpoints;
		public int number;
		public int current;
		public bool locked;

		[Space (20)]
		[Header ("Upgrade Info")]
		public int[] cost = new int[11];
		public string[] descriptions;
		public string[] titles;

		[Space (20)]
		[Header ("Ships")]
		public GameObject[] SHIPS = new GameObject[11];
		public GameObject POSITION;
		public GameObject clone;


	
		//number of upgrade 1-10


	// Use this for initialization
	void Start () {
		//For upgrade test
			playerpoints = 100;
			points = playerpoints;

			descriptions[0] = "Please press an upgrade to view description";
			descriptions[1] = "Test ship one";
			descriptions[2] = "Test ship two";
			descriptions[3] = "Test ship three";
			descriptions[4] = "Test ship four";
			descriptions[5] = "Test ship five";
			descriptions[6] = "Test ship six";
			descriptions[7] = "Test ship seven";
			descriptions[8] = "Test ship eight";
			descriptions[9] = "Test ship nine";
			descriptions[10] = "Test ship ten";
		
			titles[0] = "No Title To Display";
			titles[1] = "Ship 1";
			titles[2] = "Ship 2";
			titles[3] = "Ship 3";
			titles[4] = "Ship 4";
			titles[5] = "Ship 5";
			titles[6] = "Ship 6";
			titles[7] = "Ship 7";
			titles[8] = "Ship 8";
			titles[9] = "Ship 9";
			titles[10] = "Ship 10";

			//@TODO: Figure out why the array won't count the 9th or 10th element
			number = 0;
			//random amount

			cost [0] = 000;
			cost [1] = 000;
			cost [2] = 500;
			cost [3] = 650;
			cost [4] = 1500;
			cost [5] = 2500;
			cost [6] = 3100;
			cost [7] = 3450;
			cost [8] = 4500;
			cost [9] = 5200;
			cost [10] =5750;

			GreyLock.enabled = false;


		//End test
	}

		//Button functions

		public void Select(){
			//Which button is selected, will be the numbered upgrade to be displayed
			//Test button upgrade
			var cur= EventSystem.current.currentSelectedGameObject; //to reference the Button that has been clicked
			number = int.Parse (cur.tag.ToString()); //Use that button's tag to assign the number variable to a value
			Debug.Log ("Button " + number + " has been pressed");
			ShowInfo (number);
			Stats (number);
			DisplayShip (number);

			Button btn = cur.GetComponent<Button> ();
			if (locked == false) {
				//change lock sprite to yellow hex

				SpriteState st = new SpriteState ();
				st.highlightedSprite = Unlock;
				btn.spriteState = st;

			}

			if (locked == true) {
				Description.text = "Locked";
				//GreyLock.enabled = true;

			}


			//End test
		}

		public void Back(){
			//Go back to previous screen
		}

		public void Buy(){
			//purchase function--will do reset the meter back to empty
			//"TODO: ";
			//"Need: Fonts, Point System, Ship prefabs, Ship info, Ship names (11/7/2017)";

			if (locked == true) {
				ShipTitle.text = titles [number] + " (Locked)";
				Description.text = "You cannot purchase this item yet";

			} 
			else {
				if (playerpoints >= cost [number]) {
					Description.text = "Purchased!";

				} else {
					Description.text = "You don't have enough points";

				}
			}
		}

		public void DisplayShip(int n){
			Destroy (clone);
			clone=Instantiate (SHIPS [n], POSITION.transform);
			float tilt = clone.GetComponent<Transform> ().rotation.y;
			tilt = 80;
			Debug.Log ("Ship number " + (n) + " has been displayed");


		}

		public void Execute(){
			//play game
			//point test**
			playerpoints+=150;
		}

		void ShowInfo(int n){ //shows the info of the upgrade in the upgrade box
			Description.text=descriptions[n];
			ShipTitle.text = titles[n];
			XP.text = "XP: " + cost [n];



		}

		private void Stats(int n){
			switch (n) { //randomly placing in values for now
			case 1:
				locked = false; //starting ship
				SpeedMask.fillAmount = 0.8f;
				ArmorMask.fillAmount = 0.8f;
				DamageMask.fillAmount = 0.8f;
				break;
			case 2:
				if (cost [number] > playerpoints) {
					locked = true;
				} 
				else {
					locked = false;
				}
				SpeedMask.fillAmount = 0.65f;
				ArmorMask.fillAmount = 0.85f;
				DamageMask.fillAmount = 0.75f;
				break;
			case 3:
				if (cost [number] > playerpoints) {
					locked = true;
				} 
				else {
					locked = false;
				}
				SpeedMask.fillAmount = 0.8f;
				ArmorMask.fillAmount = 0.65f;
				DamageMask.fillAmount = 0.6f;
				break;
			case 4:
				if (cost [number] > playerpoints) {
					locked = true;
				} 
				else {
					locked = false;
				}
				SpeedMask.fillAmount = 0.4f;
				ArmorMask.fillAmount = 0.6f;
				DamageMask.fillAmount = 0.5f;
				break;
			case 5:
				if (cost [number] > playerpoints) {
					locked = true;
				} 
				else {
					locked = false;
				}
				SpeedMask.fillAmount = 0.65f;
				ArmorMask.fillAmount = 0.45f;
				DamageMask.fillAmount = 0.5f;
				break;
			case 6:
				if (cost [number] > playerpoints) {
					locked = true;
				} 
				else {
					locked = false;
				}
				SpeedMask.fillAmount = 0.5f;
				ArmorMask.fillAmount = 0.55f;
				DamageMask.fillAmount = 0.4f;
				break;
			case 7:
				if (cost [number] > playerpoints) {
					locked = true;
				} 
				else {
					locked = false;
				}
				SpeedMask.fillAmount = 0.15f;
				ArmorMask.fillAmount = 0.3f;
				DamageMask.fillAmount = 0.3f;
				break;
			case 8:
				if (cost [number] > playerpoints) {
					locked = true;
				} 
				else {
					locked = false;
				}
				SpeedMask.fillAmount = 0.35f;
				ArmorMask.fillAmount = 0.2f;
				DamageMask.fillAmount = 0.25f;
				break;
			case 9:
				if (cost [number] > playerpoints) {
					locked = true;
				} 
				else {
					locked = false;
				}
				SpeedMask.fillAmount = 0.4f;
				ArmorMask.fillAmount = 0.05f;
				DamageMask.fillAmount = 0.15f;
				break;
			case 10:
				if (cost [number] > playerpoints) {
					locked = true;
				} 
				else {
					locked = false;
				}
				SpeedMask.fillAmount = 0.45f;
				ArmorMask.fillAmount = 0.1f;
				DamageMask.fillAmount = 0.05f;
				break;
			default:
				break;
			
			}
		}

	// Update is called once per frame
	void Update () {
			PlayerPoints.text = "SCORE: " +playerpoints;

			if (locked == true) {
				GreyLock.enabled = true;
			} 
			else {
				GreyLock.enabled = false;
			}

	}

	
}
