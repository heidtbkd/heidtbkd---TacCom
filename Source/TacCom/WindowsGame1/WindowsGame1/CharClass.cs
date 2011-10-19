using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TacCom
{
    public class CharClass
    {
        private String className;
        private CharAbility[] characterAbilities;

        //creates the given character class
        public CharClass(String classN ,Object charProp)
        {
            characterAbilities = new CharAbility[4];

            if ((classN != "Battle Mage") && (classN != "Mage") && (classN != "Warrior"))
            {
                className = "Battle Mage";
            }
            else
            {
                className = classN;
            }

            setFirstAbility();
            setSecondAbility();
            setThirdAbility();
            setFourthAbility();
        }

        //returns the name of the class
        public String getClassName()
        {
            return className;
        }

        //returns the list of character abilities
        public CharAbility[] getCharacterAbilities()
        {
            bool isEmpty = false;

            for (int i = 0; i < 4; i++ )
            {
                if ((characterAbilities[i] == null) && (i == 3))
                {
                    isEmpty = true;
                }
            }

            if (isEmpty)
            {
                return null;
            }
            else
            {
                return characterAbilities;
            }
        }

        //returns the first ability
        private void setFirstAbility()
        {
            Character bob = new Character("Bob", null, 10, 10, 10, new Item(), "Warrior");
            Effect blah = new Effect("health", 1, 1.0, true, bob);
            CharAbility blahAb = new CharAbility("Blah", blah, "attack", 1, bob);
            characterAbilities[0] = blahAb;
        }

        //returns the second ability
        private void setSecondAbility()
        {
            Character bob = new Character("Bob", null, 10, 10, 10, new Item(), "Warrior");
            Effect blah = new Effect("health", 1, 1.0, true, bob);
            CharAbility blahAb = new CharAbility("Blah", blah, "attack", 1, bob);
            characterAbilities[1] = blahAb;
        }

        //returns the third ability
        private void setThirdAbility()
        {
            Character bob = new Character("Bob", null, 10, 10, 10, new Item(), "Warrior");
            Effect blah = new Effect("health", 1, 1.0, true, bob);
            CharAbility blahAb = new CharAbility("Blah", blah, "attack", 1, bob);
            characterAbilities[2] = blahAb;
        }

        //returns the third ability
        private void setFourthAbility()
        {
            Character bob = new Character("Bob", null, 10, 10, 10, new Item(), "Warrior");
            Effect blah = new Effect("health", 1, 1.0, true, bob);
            CharAbility blahAb = new CharAbility("Blah", blah, "attack", 1, bob);
            characterAbilities[3] = blahAb;
        }
    }
}
