using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;

public class PlayerThree : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI bye;
    public string Name = "Mr. McLovinIt";
    public int Age = 86;
    public string Race = "Doesn't Know";
    public int PhysicalDamage = 30;
    public int Armor = 100;
    public int MagicDamage = 75;
    public int MagicResistance = 50;
    public float Speed = 0.5f;
    public void button1press()
    {
        bye.text = "Name: " + Name + " \nAge: " + Age + "\nRace: " + Race + " \nPhysicalDamage: " + PhysicalDamage + " \nArmor: " + Armor + " \nMagicDamage: " + MagicDamage + " \nMagicResisrance: " + MagicResistance + " \nSpeed: " + Speed;

    }
} 

