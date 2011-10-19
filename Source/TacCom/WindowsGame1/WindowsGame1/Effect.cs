using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TacCom
{
    public class Effect
    {
        private String attribute;
        private int turnDuration;
        private double magnitude;
        private bool doesReset;
        private Character targetChar;

        //creates an effect
        public Effect(String attr, int duration, double mag, bool reset, Character target)
        {
            attribute = attr;
            turnDuration = duration;
            magnitude = mag;
            doesReset = reset;
            targetChar = target;
        }

        //returns attribute effect by the effect
        public String GetAttribute()
        {
            return attribute;
        }

        //returns the current duration of the effect
        public int GetDuration()
        {
            return turnDuration;
        }

        //returns the magnitude of the effect
        public double GetMagnitude()
        {
            return magnitude;
        }
        
        //returns whether of not the effect resets at the end of the duration
        public bool GetReset()
        {
            return doesReset;
        }

        //returns the character affected by the ability
        public Character GetCharacter()
        {
            return targetChar;
        }

        //applys the effect to the given character
        public void ApplyEffect()
        {
            if(turnDuration > 0)
            {
                turnDuration -= 1;
                if (attribute == "health")
                {
                    targetChar.DeductCharacterHitPoints((int)magnitude);
                }
                else if (attribute == "dodge")
                {
                    targetChar.DeductCharacterStat("dodgeChance",magnitude);
                }
                else if (attribute == "magicPoints")
                {
                    targetChar.DeductCharacterStat(attribute, (int)magnitude);
                }
                else if (attribute == "attackPower")
                {
                    targetChar.DeductCharacterStat(attribute, (int)magnitude);
                }
                else if (attribute == "spellPower")
                {
                    targetChar.DeductCharacterStat(attribute, (int)magnitude);
                }
                else if (attribute == "crit")
                {
                    targetChar.DeductCharacterStat("critChance", magnitude);
                }
                
            }
        }

        public void setTarget(Character newTarget)
        {
            targetChar = newTarget;
        }
    }
}
