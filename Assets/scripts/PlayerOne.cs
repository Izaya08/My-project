using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI hello;
    public string Name = "Will Saucy";
    public int Age = 12;
    public string Race = "African-American";
    public int PhysicalDamage = 80;
    public int Armor = 100;
    public int MagicDamage = 10;
    public int MagicResistance = 50;
    public float Speed = 100.5f;

    public void button1press()
    {
        hello.text = "Name: " + Name + " \nAge: " + Age + "\nRace: " + Race + " \nPhysicalDamage: " + PhysicalDamage + " \nArmor: " + Armor + " \nMagicDamage: " + MagicDamage + " \nMagicResisrance: " + MagicResistance + " \nSpeed: " + Speed; 
    }
}

