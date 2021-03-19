using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TypeObject
{
    /*
     * Class creates three kinds of monsters and assigns three different breeds to them.
     */
    public class MonsterUsage : MonoBehaviour
    {
        private Breed _fire;
        private Breed _water;
        private Breed _lava;
        
        private Breed _trollBreed;
        private Breed _trollArcherBreed;
        private Breed _trollWizardBreed;

        private Monster _fireElemental;
        private Monster _waterElemental;
        private Monster _lavaElemental;
        
        private Monster _troll;
        private Monster _trollArcher;
        private Monster _trollWizard;

        private void Start()
        {
            CreateBreeds();
            CreateMonsters();
            Attack();
            CheckHealth();
        }
        
        [Button]
        public void CreateBreeds()
        {
            _water = new Breed(null, "Make a pond!", 40);
            _fire = new Breed(null, "Incineration Blaze!", 30);
            
            //Lava overrides the only the health
            _lava = new Breed(_fire, null, 45);

            _trollBreed = new Breed(null, "The troll hits you!", 25);
            _trollArcherBreed = new Breed(_trollBreed, "The troll archer fires an arrow!", 0);
            _trollWizardBreed = new Breed(_trollBreed, "The troll wizard casts a spell on you!", 0);
        }

        [Button]
        public void CreateMonsters()
        {
            _fireElemental = new Monster(_fire);
            _waterElemental = new Monster(_water);
            _lavaElemental = new Monster(_lava);
            
            _troll = new Monster(_trollBreed);
            _trollArcher = new Monster(_trollArcherBreed);
            _trollWizard = new Monster(_trollWizardBreed);
        }

        [Button]
        public void Attack()
        {
            Debug.Log("Fire elemental attacks: " + _fireElemental.GetAttack());
            Debug.Log("Water elemental attacks: " + _waterElemental.GetAttack());
            Debug.Log("Lava elemental attacks: " + _lavaElemental.GetAttack());
            Debug.Log("Troll attacks: " + _troll.GetAttack());
            Debug.Log("Troll Archer attacks: " + _trollArcher.GetAttack());
            Debug.Log("Troll Wizard attacks: " + _trollWizard.GetAttack());
        }
        
        [Button]
        public void CheckHealth()
        {
            Debug.Log("Fire elemental health: " + _fireElemental.GetHealth());
            Debug.Log("Water elemental health: " + _waterElemental.GetHealth());
            Debug.Log("Lava elemental health: " + _lavaElemental.GetHealth());
            Debug.Log("Troll health: " + _troll.GetHealth());
            Debug.Log("Troll Archer health: " + _trollArcher.GetHealth());
            Debug.Log("Troll Wizard health: " + _trollWizard.GetHealth());
        }
    }
}