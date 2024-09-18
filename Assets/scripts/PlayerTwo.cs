using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerTwo : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI Hi;
    string Name = "Joe Biden";
	int Age = 81;
	string Race = "Red, White and Blue American";
	int PhysicalDamage = 20;
	int Armor = 100;
	int MagicDamage = 20;
	int MagicResistance = 5;
	float Speed = 1.5f;

    public void button1press()
	{
        Hi.text = "Name: " + Name + " \nAge: " + Age + "\nRace: " + Race + " \nPhysicalDamage: " + PhysicalDamage + " \nArmor: " + Armor + " \nMagicDamage: " + MagicDamage + " \nMagicResisrance: " + MagicResistance + " \nSpeed: " + Speed;
    }
}

