using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TacCom
{
    public class GameBoard
    {
        private String[] teamNames;
        private Character[] firstTeamCharacters;
        private Character[] secondTeamCharacters;
        private Object boardBackground;
        private Environments weather;
        private List<Effect> activeEffects;
        private bool turnTime;
        
        //Creates a new gameboard
        public GameBoard(String[] nameTeams, Character[] charFirstTeam, Character[] charSecondTeam, Object back, Environments weath)
        {
            teamNames = nameTeams;
            firstTeamCharacters = charFirstTeam;
            secondTeamCharacters = charSecondTeam;
            boardBackground = back;
            weather = weath;
            turnTime = true;
            activeEffects = new List<Effect>();
        }

        //Returns this instance of gameboard
        public GameBoard getGameBoard()
        {
            return this;
        }

        //returns team names
        public String[] getTeamNames()
        {
            return teamNames;
        }

        //returns the first team's characters
        public Character[] getFirstTeamCharacters()
        {
            return firstTeamCharacters;
        }

        public Character[] getSecondTeamCharacters()
        {
            return secondTeamCharacters;
        }

        //Returns the background image
        public Object getBoardBackgroundImage()
        {
            return boardBackground;
        }

        //Returns the environment
        public Environments getEnvironment()
        {
            return weather;
        }

        //returns the list of active effects
        public List<Effect> getEffectList()
        {
            return activeEffects;
        }

        //returns the current turn
        public bool getTurn()
        {
            return turnTime;
        }

        //returns the name of the first team
        public void setFirstTeamName(String name)
        {
            teamNames[0] = name;
        }

        //returns the name of the second team
        public void setSecondTeamName(String name)
        {
            teamNames[1] = name;
        }

        //places the given character into the given slot on the first team
        public void setFirstTeamCharacter(int slot, Character characterProp)
        {
            firstTeamCharacters[slot] = characterProp;
        }

        //places the given character into the given slot on the second team
        public void setSecondTeamCharacter(int slot, Character characterProp)
        {
            secondTeamCharacters[slot] = characterProp;
        }

        //adds a new effect to the effect list
        public void addEffect(Effect deEffect)
        {
            activeEffects.Add(deEffect);
        }

        //removes the given effect from the effect list
        public void destroyEffect(Effect deEffect)
        {
            activeEffects.Remove(deEffect);
        }

        //executes the current turn
        public void turn()
        {
            if (turnTime)
            {
                for (int i = 0; i < activeEffects.Count; i++)
                {
                    activeEffects[i].ApplyEffect();
                    if (activeEffects[i].GetDuration() == 0)
                    {
                        destroyEffect(activeEffects[i]);
                    }
                }
                turnTime = false;
            }
            else
            {
                turnTime = true;
            }
        }
    }
}
