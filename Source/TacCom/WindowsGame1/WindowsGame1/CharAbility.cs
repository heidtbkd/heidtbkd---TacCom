using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TacCom
{
    public class CharAbility
    {
        private String abilityName;
        private Effect abilityEffects;
        private int mpCost;
        private Character target;
        private String modifier;

        public CharAbility(String ability, Effect effect, String modif, int cost, Character targ)
        {
            abilityName = ability;
            abilityEffects = effect;
            target = targ;
            modifier = modif;

            if (cost < 1)
            {
                mpCost = 1;
            }
            else if (cost > 100)
            {
                mpCost = 100;
            }
            else
            {
                mpCost = cost;
            }
        }

        public String getAbilityName()
        {
            return abilityName;
        }

        public Effect getAbilityEffect()
        {
            return abilityEffects;
        }

        public int getMPCost()
        {
            return mpCost;
        }

        public object getAbilityChar()
        {
            return target;
        }
    }
}
