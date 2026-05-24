/*
 * Name: Ryan Crawford
 * Date: May 24, 2026
 * Purpose: Week 2 Project Submission - Demonstrating Interfaces and Polymorphism
 * within the RPG Character Vault application logic.
 */

using System;
using System.Collections.Generic;

namespace RPGCharacterVault
{
    // ---------------------------------------------------------
    // DEMONSTRATING THE CREATION OF AN INTERFACE
    // ---------------------------------------------------------
    public interface ISpecialAbility
    {
        void ExecuteSpecial();
    }

    // Component Class (Composition)
    public class Weapon
    {
        public string ItemName { get; set; }
        public int DamageRating { get; set; }

        public Weapon(string itemName, int damageRating)
        {
            ItemName = itemName;
            DamageRating = damageRating;
        }
    }

    // Base Class (Inheritance)
    public abstract class Character
    {
        public string CharacterName { get; set; }
        public Weapon EquippedWeapon { get; set; }

        public Character(string characterName, Weapon weapon)
        {
            CharacterName = characterName;
            EquippedWeapon = weapon;
        }

        // Virtual method setup for Polymorphism
        public virtual void DisplayStats()
        {
            Console.WriteLine($"Character Name: {CharacterName}");
            Console.WriteLine($"Equipped Weapon: {EquippedWeapon.ItemName} (+{EquippedWeapon.DamageRating} DMG)");
        }
    }

    // Derived Class 1
    public class Mage : Character, ISpecialAbility
    {
        public int TotalMana { get; set; }

        public Mage(string characterName, Weapon weapon, int totalMana) : base(characterName, weapon)
        {
            TotalMana = totalMana;
        }

        // DEMONSTRATING POLYMORPHISM (Method Overriding)
        public override void DisplayStats()
        {
            // Calls the base class first, then adds its own data
            base.DisplayStats();
            Console.WriteLine($"Class: Mage | Total Mana: {TotalMana}");
        }

        // Implementing the Interface
        public void ExecuteSpecial()
        {
            Console.WriteLine($"* {CharacterName} casts a devastating Fireball! *");
        }
    }

    // Derived Class 2
    public class Warrior : Character, ISpecialAbility
    {
        public int ArmorRating { get; set; }

        public Warrior(string characterName, Weapon weapon, int armorRating) : base(characterName, weapon)
        {
            ArmorRating = armorRating;
        }

        // DEMONSTRATING POLYMORPHISM (Method Overriding)
        public override void DisplayStats()
        {
            // Calls the base class first, then adds its own data
            base.DisplayStats();
            Console.WriteLine($"Class: Warrior | Armor Rating: {ArmorRating}");
        }

        // Implementing the Interface
        public void ExecuteSpecial()
        {
            Console.WriteLine($"* {CharacterName} performs a crushing Shield Bash! *");
        }
    }

    // Main Application Execution
    class Program
    {
        static void Main(string[] args)
        {
            // Displays an informative indicator
            Console.WriteLine("==================================================");
            Console.WriteLine("Project Week 2: Interfaces and Polymorphism");
            Console.WriteLine("Developer: Ryan");
            Console.WriteLine("==================================================\n");

            // Displays a welcome message and instructions
            Console.WriteLine("Welcome back to the RPG Character Vault Console Interface!");
            Console.WriteLine("This module tests interface implementation and polymorphic behavior.");
            Console.WriteLine("Press 'Enter' to load the character roster...\n");
            Console.ReadLine();

            // Instantiating classes with realistic information
            Weapon staff = new Weapon("Staff of Magnus", 45);
            Weapon sword = new Weapon("Daedric Greatsword", 65);

            Mage player1 = new Mage("Savos Aren", staff, 450);
            Warrior player2 = new Warrior("Farkas", sword, 120);

            // DEMONSTRATING POLYMORPHISM (Treating derived objects as base objects)
            // We can place both Mages and Warriors into a generic Character list.
            List<Character> characterRoster = new List<Character>() { player1, player2 };

            Console.WriteLine("--- CHARACTER ROSTER ---");
            foreach (Character character in characterRoster)
            {
                // The appropriate overridden DisplayStats() is called automatically 
                // based on the derived object type at runtime.
                character.DisplayStats();

                // Demonstrating Polymorphism via Interface casting
                if (character is ISpecialAbility characterWithAbility)
                {
                    characterWithAbility.ExecuteSpecial();
                }
                Console.WriteLine("----------------------------------------------");
            }

            Console.WriteLine("\nTesting complete. Press any key to exit the application.");
            Console.ReadKey();
        }
    }
}