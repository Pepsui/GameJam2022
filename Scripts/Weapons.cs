using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapons : MonoBehaviour
{
    [SerializeField] bool earthState;
    public float pubDamage;
    
   public struct Pickaxe {
        int damageNum;
        float fuelAmount;
        bool isEquipped;
        private void EarthState(bool state) {
            if(isEquipped) {
                if(state) {
                    damageNum = 5;
                    fuelAmount = 100f;
                }
                else {
                    damageNum = 10;
                    fuelAmount = 100f;
                    fuelAmount -= 0.25f;
                    
                }
            }
        }
        
    }

    public struct Shovel {
       int damageNum;
       float fuelAmount;
       bool isEquipped;
       
       private void EarthState(bool state) {
           if(isEquipped) {
                if(state) {
                    damageNum = 5;
                    fuelAmount = 100f;
                }
                else {
                    damageNum = 10;
                    fuelAmount = 100f;
                    fuelAmount -= 0.25f;
                    
                }
            }
        }
   
    }

    public struct Sword {
       int damageNum;
       float fuelAmount;
       bool isEquipped;

       private void EarthState(bool state) {
           if(isEquipped) {
                if(state) {
                    damageNum = 5;
                    fuelAmount = 100f;
                }
                else {
                    damageNum = 10;
                    fuelAmount = 100f;
                    fuelAmount -= 0.25f;
                    
                }
            }
        }
    }
    
}
