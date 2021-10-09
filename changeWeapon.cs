using System.Collections;
using System.Collections.Generic;
using UnityEngine;

void OnCollisionEnter(Collision collision){ 

//Variables
 var Pistol : GameObject;
 var Stick : GameObject;
 var pistolisspawned = true;
 var stickisspawned = false;
 var canswitchtopistol = false;
 var canswitchtostick = true;
     
 function Start () {
     ToPistol();
 }
 
 function Update () {
     if(pistolisspawned == true) {
         canswitchtopistol = false;
         canswitchtostick = true;
     }
     if(stickisspawned == true){
         canswitchtostick = false;
         canswitchtopistol = true;
     }
     WeaponSwitch();
 }
 
 function WeaponSwitch() {
     if (Input.GetKeyDown("q")) {
         ToPistol();
     }
     if (Input.GetKeyDown("e")) {
         ToStick();
     }
 }
 
 function ToPistol () {
     if(canswitchtopistol == true) {
     Destroy (GameObject.FindWithTag("Stick"));
     var clone : GameObject;
     clone = Instantiate(Pistol, transform.position, transform.rotation);
     pistolisspawned = true;
     stickisspawned = false;
     }
 }
 
 function ToStick () {
     if(canswitchtostick == true) {
     Destroy (GameObject.FindWithTag("Pistol"));
     var clone : GameObject;
     clone = Instantiate(Stick, transform.position, transform.rotation);
     stickisspawned = true;
     pistolisspawned = false;
     }
} }