using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TacCom
{
    public class Character
    {
        private String characterName;
        private Object characterImage;
        private int[] characterAttributes = new int[3];
        private Object characterItems;
        private String characterClass;
        private int characterHitPoints;
        private int characterMagicPoints;
        private int characterAttackPower;
        private int characterSpellPower;
        private double characterDodgeChance;
        private double characterCriticalChance;
        private CharAbility[] abilityList;

        private int[] initialCharacterAttributes = new int[3];
        private int initialCharacterHitPoints;
        private int initialCharacterMagicPoints;
        private int initialCharacterAttackPower;
        private int initialCharacterSpellPower;
        private double initialCharacterDodgeChance;
        private double initialCharacterCriticalChance;
        private Boolean dead;

        public Character(String name, Object image, int strength, int intelegence, int agility, Object item, String className)
        {
            dead = false;
            characterName = name;
            characterImage = image;
            characterAttributes[0] = strength;
            initialCharacterAttributes[0] = strength;
            characterAttributes[1] = intelegence;
            initialCharacterAttributes[1] = intelegence;
            characterAttributes[2] = agility;
            initialCharacterAttributes[2] = agility;
            if (strength < 1)
            {
                characterAttributes[0] = 1;
                initialCharacterAttributes[0] = 1;
            }
            if (intelegence < 1)
            {
                characterAttributes[1] = 1;
                initialCharacterAttributes[1] = 1;
            }
            if (agility < 1)
            {
                characterAttributes[2] = 1;
                initialCharacterAttributes[2] = 1;
            }

            characterItems = item;
            characterClass = className;
            SetCharacterHitPoints();
            SetCharacterMagicPoints();
            SetCharacterAttackPower();
            SetCharacterSpellPower();
            SetCharacterDodgeChance();
            SetCharacterCriticalChance();
            abilityList = new CharAbility[4];
        }

        private void SetCharacterCriticalChance()
        {
            characterCriticalChance = 0.06 * characterAttributes[2];
            initialCharacterCriticalChance = characterCriticalChance;
        }

        private void SetCharacterDodgeChance()
        {
            characterDodgeChance = 0.04 * characterAttributes[2];
            initialCharacterDodgeChance = characterDodgeChance;
        }

        private void SetCharacterSpellPower()
        {
            characterSpellPower = 2 * characterAttributes[1];
            initialCharacterSpellPower = characterSpellPower;
        }

        private void SetCharacterAttackPower()
        {
            characterAttackPower = 2 * characterAttributes[0];
            initialCharacterAttackPower = characterAttackPower;
        }

        private void SetCharacterMagicPoints()
        {
            characterMagicPoints = 10 * characterAttributes[1];
            initialCharacterMagicPoints = characterMagicPoints;
        }

        private void SetCharacterHitPoints()
        {
            characterHitPoints = 10 * characterAttributes[0];
            initialCharacterHitPoints = characterHitPoints;
        }

        public int[] GetCharacterAttributes()
        {
            return characterAttributes;
        }

        //TODO: Refactor later
        public Object GetCharacterItemList()
        {
            return characterItems;
        }
        //TODO: Refactor later
        public String GetCharacterClass()
        {
            return characterClass;
        }

        public int GetCharacterHitPoints()
        {
            return characterHitPoints;
        }

        public int GetCharacterMagicPoints()
        {
            return characterMagicPoints;
        }

        public int GetCharacterAttackPower()
        {
            return characterAttackPower;
        }

        public int GetCharacterSpellPower()
        {
            return characterSpellPower;
        }

        public double GetCharacterDodgeChance()
        {
            return characterDodgeChance;
        }

        public double GetCharacterCriticalChance()
        {
            return characterCriticalChance;
        }

        public String GetCharacterName()
        {
            return characterName;
        }

        //TODO: Refactor later
        public Object GetCharacterImage()
        {
            return characterImage;
        }

        public void DeductCharacterHitPoints(int amount)
        {
            characterHitPoints = characterHitPoints - amount;
            if (characterHitPoints < 1)
            {
                SetDead();
            }

        }

        public bool DeductCharacterStat(String stat, int amount)
        {
            if (amount <= 0)
            {
                return false;
            }
            else
            {
                if (stat == "magicPoints")
                {
                    if (amount > (10 * characterAttributes[1]))
                    {
                        characterMagicPoints = 0;
                        return true;
                    }
                    else
                    {
                        if ((characterMagicPoints - amount) < 0)
                        {
                            characterMagicPoints = 0;
                            return true;
                        }
                        else
                        {
                            characterMagicPoints = characterMagicPoints - amount;
                            return true;
                        }
                    }
                }
                else if(stat == "attackPower")
                {
                    if (amount > (2 * characterAttributes[0]))
                    {
                        characterAttackPower = 0;
                        return true;
                    }
                    else
                    {
                        if ((characterAttackPower - amount) < 0)
                        {
                            characterAttackPower = 0;
                            return true;
                        }
                        else
                        {
                            characterAttackPower = characterAttackPower - amount;
                            return true;
                        }
                    }
                }
                else if (stat == "spellPower")
                {
                    if (amount > (2 * characterAttributes[1]))
                    {
                        characterSpellPower = 0;
                        return true;
                    }
                    else
                    {
                        if ((characterSpellPower - amount) < 0)
                        {
                            characterSpellPower = 0;
                            return true;
                        }
                        else
                        {
                            characterSpellPower = characterSpellPower - amount;
                            return true;
                        }
                    }
                }
                else
                {
                    return false;
                }
            }
        }

        public bool DeductCharacterStat(String stat, double amount)
        {
            if (amount <= 0.0)
            {
                return false;
            }
            else
            {
                if (stat == "dodgeChance")
                {
                    if (amount > (0.04 * characterAttributes[2]))
                    {
                        characterDodgeChance = 0.0;
                        return true;
                    }
                    else
                    {
                        if ((characterDodgeChance - amount) < 0.0)
                        {
                            characterDodgeChance = 0.0;
                            return true;
                        }
                        else
                        {
                            characterDodgeChance = characterDodgeChance - amount;
                            return true;
                        }
                    }
                }
                else if (stat == "critChance")
                {
                    if (amount > (0.06 * characterAttributes[2]))
                    {
                        characterCriticalChance = 0.0;
                        return true;
                    }
                    else
                    {
                        if ((characterCriticalChance - amount) < 0.0)
                        {
                            characterCriticalChance = 0.0;
                            return true;
                        }
                        else
                        {
                            characterCriticalChance = characterCriticalChance - amount;
                            return true;
                        }
                    }
                }
                else
                {
                    return false;
                }
            }
        }

        public int[] GetCharacterInitialAttributes()
        {
            return initialCharacterAttributes;
        }

        public object GetCharacterInitialHitPoints()
        {
            return initialCharacterHitPoints;
        }

        public object GetCharacterInitialMagicPoints()
        {
            return initialCharacterMagicPoints;
        }

        public object GetCharacterInitialAttackPower()
        {
            return initialCharacterAttackPower;
        }

        public object GetCharacterInitialSpellPower()
        {
            return initialCharacterSpellPower;
        }

        public object GetCharacterInitialDodgeChance()
        {
            return initialCharacterDodgeChance;
        }

        public object GetCharacterInitialCriticalChance()
        {
            return initialCharacterCriticalChance;
        }

        //TODO: Implement
        public void AddNewItem(String itemName, Object charProp)
        {

        }

        //TODO: Implement
        public void AddNewItemFromProper(String itemName, Object charProp, Object itemProp)
        {

        }
        public Boolean GetDead()
        {
            return dead;
        }
        public void SetDead()
        {
            dead = true;
        }

        public void SetFirstAbilityForCharacter(CharAbility ab)
        {
            abilityList[0] = ab;
        }

        public void SetSecondAbilityForCharacter(CharAbility ab)
        {
            abilityList[1] = ab;
        }
        
        public void SetThirdAbilityForCharacter(CharAbility ab)
        {
            abilityList[2] = ab;
        }

        public void SetFourthAbilityForCharacter(CharAbility ab)
        {
            abilityList[3] = ab;
        }

        public CharAbility[] GetCharacterAbilities()
        {
            return abilityList;
        }
    }
}
