using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using TacCom;

namespace TacComTest
{
    [TestFixture]
    public class GameBoadTest
    {
        [Test()]
        public void TestThatGameBoardInitializes()
        {
            var target = new GameBoard(null, null, null, null, null);
            Assert.IsNotNull(target);
        }

        [Test()]
        public void TestThatGameBoardHasTeamNames()
        {
            String[] tf2 = new String[2];
            tf2[0] = "Blue";
            tf2[1] = "Red";
            var target = new GameBoard(tf2,null,null,null,null);
        }

        [Test()]
        public void TestThatGameBoardHasCorrectFirstTeamName()
        {
            String[] tf2 = new String[2];
            tf2[0] = "Blue";
            tf2[1] = "Red";
            var target = new GameBoard(tf2, null, null, null, null);

            Assert.AreEqual(tf2[0], target.getTeamNames()[0]);
        }

        [Test()]
        public void TestThatGameBoardHasCorrectSecondTeamName()
        {
            String[] tf2 = new String[2];
            tf2[0] = "Blue";
            tf2[1] = "Red";
            var target = new GameBoard(tf2, null, null, null, null);

            Assert.AreEqual(tf2[1], target.getTeamNames()[1]);
        }

        [Test()]
        public void TestThatGameBoardHasCorrectFirstTeamCharacters()
        {
            Character[] tf2Blue = new Character[6];
            for (int i = 0; i < 6; i++)
            {
                tf2Blue[i] = new Character("Bob", null, 10, 10, 10, new Item(), "Warrior");
            }

            var target = new GameBoard(null, tf2Blue, null, null, null);

            Assert.AreEqual(tf2Blue, target.getFirstTeamCharacters());
        }

        [Test()]
        public void TestThatGameBoardHasCorrectFirstTeamCharactersFirstMember()
        {
            Character[] tf2Blue = new Character[6];
            for (int i = 0; i < 6; i++)
            {
                tf2Blue[i] = new Character("Bob", null, 10, 10, 10, new Item(), "Warrior");
            }

            var target = new GameBoard(null, tf2Blue, null, null, null);

            Assert.AreEqual(tf2Blue[0], target.getFirstTeamCharacters()[0]);
        }

        [Test()]
        public void TestThatGameBoardHasCorrectFirstTeamCharactersSecondMember()
        {
            Character[] tf2Blue = new Character[6];
            for (int i = 0; i < 6; i++)
            {
                tf2Blue[i] = new Character("Bob", null, 10, 10, 10, new Item(), "Warrior");
            }

            var target = new GameBoard(null, tf2Blue, null, null, null);

            Assert.AreEqual(tf2Blue[1], target.getFirstTeamCharacters()[1]);
        }

        [Test()]
        public void TestThatGameBoardHasCorrectFirstTeamCharactersThirdMember()
        {
            Character[] tf2Blue = new Character[6];
            for (int i = 0; i < 6; i++)
            {
                tf2Blue[i] = new Character("Bob", null, 10, 10, 10, new Item(), "Warrior");
            }

            var target = new GameBoard(null, tf2Blue, null, null, null);

            Assert.AreEqual(tf2Blue[2], target.getFirstTeamCharacters()[2]);
        }

        [Test()]
        public void TestThatGameBoardHasCorrectFirstTeamCharactersFourthMember()
        {
            Character[] tf2Blue = new Character[6];
            for (int i = 0; i < 6; i++)
            {
                tf2Blue[i] = new Character("Bob", null, 10, 10, 10, new Item(), "Warrior");
            }

            var target = new GameBoard(null, tf2Blue, null, null, null);

            Assert.AreEqual(tf2Blue[3], target.getFirstTeamCharacters()[3]);
        }

        [Test()]
        public void TestThatGameBoardHasCorrectFirstTeamCharactersFifthMember()
        {
            Character[] tf2Blue = new Character[6];
            for (int i = 0; i < 6; i++)
            {
                tf2Blue[i] = new Character("Bob", null, 10, 10, 10, new Item(), "Warrior");
            }

            var target = new GameBoard(null, tf2Blue, null, null, null);

            Assert.AreEqual(tf2Blue[4], target.getFirstTeamCharacters()[4]);
        }

        [Test()]
        public void TestThatGameBoardHasCorrectFirstTeamCharactersSixthMember()
        {
            Character[] tf2Blue = new Character[6];
            for (int i = 0; i < 6; i++)
            {
                tf2Blue[i] = new Character("Bob", null, 10, 10, 10, new Item(), "Warrior");
            }

            var target = new GameBoard(null, tf2Blue, null, null, null);

            Assert.AreEqual(tf2Blue[5], target.getFirstTeamCharacters()[5]);
        }

        //

        [Test()]
        public void TestThatGameBoardHasCorrectSecondTeamCharacters()
        {
            Character[] tf2Red = new Character[6];
            for (int i = 0; i < 6; i++)
            {
                tf2Red[i] = new Character("Bob", null, 10, 10, 10, new Item(), "Warrior");
            }

            var target = new GameBoard(null, null, tf2Red, null, null);

            Assert.AreEqual(tf2Red, target.getSecondTeamCharacters());
        }

        [Test()]
        public void TestThatGameBoardHasCorrectSecondTeamCharactersFirstMember()
        {
            Character[] tf2Red = new Character[6];
            for (int i = 0; i < 6; i++)
            {
                tf2Red[i] = new Character("Bob", null, 10, 10, 10, new Item(), "Warrior");
            }

            var target = new GameBoard(null, null, tf2Red, null, null);

            Assert.AreEqual(tf2Red[0], target.getSecondTeamCharacters()[0]);
        }

        [Test()]
        public void TestThatGameBoardHasCorrectSecondTeamCharactersSecondMember()
        {
            Character[] tf2Red = new Character[6];
            for (int i = 0; i < 6; i++)
            {
                tf2Red[i] = new Character("Bob", null, 10, 10, 10, new Item(), "Warrior");
            }

            var target = new GameBoard(null, null, tf2Red , null, null);

            Assert.AreEqual(tf2Red[1], target.getSecondTeamCharacters()[1]);
        }

        [Test()]
        public void TestThatGameBoardHasCorrectSecondTeamCharactersThirdMember()
        {
            Character[] tf2Red = new Character[6];
            for (int i = 0; i < 6; i++)
            {
                tf2Red[i] = new Character("Bob", null, 10, 10, 10, new Item(), "Warrior");
            }

            var target = new GameBoard(null, null, tf2Red, null, null);

            Assert.AreEqual(tf2Red[2], target.getSecondTeamCharacters()[2]);
        }

        [Test()]
        public void TestThatGameBoardHasCorrectSecondTeamCharactersFourthMember()
        {
            Character[] tf2Red = new Character[6];
            for (int i = 0; i < 6; i++)
            {
                tf2Red[i] = new Character("Bob", null, 10, 10, 10, new Item(), "Warrior");
            }

            var target = new GameBoard(null, null, tf2Red, null, null);

            Assert.AreEqual(tf2Red[3], target.getSecondTeamCharacters()[3]);
        }

        [Test()]
        public void TestThatGameBoardHasCorrectSecondTeamCharactersFifthMember()
        {
            Character[] tf2Red = new Character[6];
            for (int i = 0; i < 6; i++)
            {
                tf2Red[i] = new Character("Bob", null, 10, 10, 10, new Item(), "Warrior");
            }

            var target = new GameBoard(null, null, tf2Red, null, null);

            Assert.AreEqual(tf2Red[4], target.getSecondTeamCharacters()[4]);
        }

        [Test()]
        public void TestThatGameBoardHasCorrectSecondTeamCharactersSixthMember()
        {
            Character[] tf2Red = new Character[6];
            for (int i = 0; i < 6; i++)
            {
                tf2Red[i] = new Character("Bob", null, 10, 10, 10, new Item(), "Warrior");
            }

            var target = new GameBoard(null, null, tf2Red, null, null);

            Assert.AreEqual(tf2Red[5], target.getSecondTeamCharacters()[5]);
        }

        [Test()]
        public void TestThatGameBoardHasEmptyBackground()
        {
            var target = new GameBoard(null, null, null, null, null);
            Assert.IsNull(target.getBoardBackgroundImage());
        }

        [Test()]
        public void TestThatGameBoardHasEnvironment()
        {
            Environments env = new Environments("shine", null);
            var target = new GameBoard(null, null, null, null, env);
            Assert.AreEqual(target.getEnvironment(), env);
        }

        [Test()]
        public void TestThatGameBoardHasEffectList()
        {
            var target = new GameBoard(null, null, null, null, new Environments("shine", null));
            Assert.IsNotNull(target.getEffectList());
        }

        [Test()]
        public void TestThatGameBoardHasEffectInEffectList()
        {
            Character bob = new Character("Bob", null, 10, 10, 10, new Item(), "Warrior");
            Effect effThat = new Effect("health", 10, 1.0, true, bob);
            var target = new GameBoard(null, null, null, null, null);
            target.addEffect(effThat);
            Assert.AreEqual(effThat, target.getEffectList()[0]);
        }

        [Test()]
        public void TestThatGameBoardHasNoEffectAfterRemovingEffectinEffectList()
        {
            Character bob = new Character("Bob", null, 10, 10, 10, new Item(), "Warrior");
            Effect effThat = new Effect("health", 10, 1.0, true, bob);
            var target = new GameBoard(null, null, null, null, null);
            target.addEffect(effThat);
            target.destroyEffect(effThat);
            Assert.AreEqual(target.getEffectList().Count, 0);
        }

        [Test()]
        public void TestThatGameBoardHasTurn()
        {
            var target = new GameBoard(null, null, null, null, null);
            Assert.True(target.getTurn());
        }

        [Test()]
        public void TestThatGameBoardChangesTurn()
        {
            var target = new GameBoard(null, null, null, null, null);
            target.turn();
            Assert.False(target.getTurn());
        }

        [Test()]
        public void TestThatGameBoardChangesToOriginalTurnPerson()
        {
            var target = new GameBoard(null, null, null, null, null);
            target.turn();
            target.turn();
            Assert.True(target.getTurn());
        }


         [Test()]
        public void TestThatGameBoardDoesFirstCharacterActionsDuringTurnTeam01()
        {
            Character[] tf2Blue = new Character[6];
            for (int i = 0; i < 6; i++)
            {
                tf2Blue[i] = new Character("Bob", null, 10, 10, 10, new Item(), "Warrior");
            }

            Character[] tf2Red = new Character[6];
            for (int i = 0; i < 6; i++)
            {
                tf2Red[i] = new Character("Bob", null, 10, 10, 10, new Item(), "Warrior");
            }


            var target = new GameBoard(null, tf2Blue, tf2Red, null, null);

            for (int i = 0; i < 6; i++)
            {
                Effect effThat = new Effect("health", 1, 10.0, true, target.getFirstTeamCharacters()[i]);
                target.addEffect(effThat);
            }

            target.turn();

            Assert.AreEqual(target.getFirstTeamCharacters()[0].GetCharacterHitPoints(), 90);
        }

        [Test()]
         public void TestThatGameBoardDoesSecondCharacterActionsDuringTurnTeam01()
        {
            Character[] tf2Blue = new Character[6];
            for (int i = 0; i < 6; i++)
            {
                tf2Blue[i] = new Character("Bob", null, 10, 10, 10, new Item(), "Warrior");
            }

            Character[] tf2Red = new Character[6];
            for (int i = 0; i < 6; i++)
            {
                tf2Red[i] = new Character("Bob", null, 10, 10, 10, new Item(), "Warrior");
            }


            var target = new GameBoard(null, tf2Blue, tf2Red, null, null);

            for (int i = 0; i < 6; i++)
            {
                Effect effThat = new Effect("health", 1, 10.0, true, target.getFirstTeamCharacters()[i]);
                target.addEffect(effThat);
            }

            target.turn();

            Assert.AreEqual(target.getFirstTeamCharacters()[1].GetCharacterHitPoints(), 90);
        }

        [Test()]
        public void TestThatGameBoardDoesThirdCharacterActionsDuringTurnTeam01()
        {
            Character[] tf2Blue = new Character[6];
            for (int i = 0; i < 6; i++)
            {
                tf2Blue[i] = new Character("Bob", null, 10, 10, 10, new Item(), "Warrior");
            }

            Character[] tf2Red = new Character[6];
            for (int i = 0; i < 6; i++)
            {
                tf2Red[i] = new Character("Bob", null, 10, 10, 10, new Item(), "Warrior");
            }


            var target = new GameBoard(null, tf2Blue, tf2Red, null, null);

            for (int i = 0; i < 6; i++)
            {
                Effect effThat = new Effect("health", 1, 10.0, true, target.getFirstTeamCharacters()[i]);
                target.addEffect(effThat);
            }

            target.turn();

            Assert.AreEqual(target.getFirstTeamCharacters()[2].GetCharacterHitPoints(), 90);
        }

        [Test()]
        public void TestThatGameBoardDoesFourthCharacterActionsDuringTurnTeam01()
        {
            Character[] tf2Blue = new Character[6];
            for (int i = 0; i < 6; i++)
            {
                tf2Blue[i] = new Character("Bob", null, 10, 10, 10, new Item(), "Warrior");
            }

            Character[] tf2Red = new Character[6];
            for (int i = 0; i < 6; i++)
            {
                tf2Red[i] = new Character("Bob", null, 10, 10, 10, new Item(), "Warrior");
            }


            var target = new GameBoard(null, tf2Blue, tf2Red, null, null);

            for (int i = 0; i < 6; i++)
            {
                Effect effThat = new Effect("health", 1, 10.0, true, target.getFirstTeamCharacters()[i]);
                target.addEffect(effThat);
            }

            target.turn();

            Assert.AreEqual(target.getFirstTeamCharacters()[3].GetCharacterHitPoints(), 90);
        }

        [Test()]
        public void TestThatGameBoardDoesFifthCharacterActionsDuringTurnTeam01()
        {
            Character[] tf2Blue = new Character[6];
            for (int i = 0; i < 6; i++)
            {
                tf2Blue[i] = new Character("Bob", null, 10, 10, 10, new Item(), "Warrior");
            }

            Character[] tf2Red = new Character[6];
            for (int i = 0; i < 6; i++)
            {
                tf2Red[i] = new Character("Bob", null, 10, 10, 10, new Item(), "Warrior");
            }


            var target = new GameBoard(null, tf2Blue, tf2Red, null, null);

            for (int i = 0; i < 6; i++)
            {
                Effect effThat = new Effect("health", 1, 10.0, true, target.getFirstTeamCharacters()[i]);
                target.addEffect(effThat);
            }

            target.turn();

            Assert.AreEqual(target.getFirstTeamCharacters()[4].GetCharacterHitPoints(), 90);
        }

        [Test()]
        public void TestThatGameBoardDoesSixthCharacterActionsDuringTurnTeam01()
        {
            Character[] tf2Blue = new Character[6];
            for (int i = 0; i < 6; i++)
            {
                tf2Blue[i] = new Character("Bob", null, 10, 10, 10, new Item(), "Warrior");
            }

            Character[] tf2Red = new Character[6];
            for (int i = 0; i < 6; i++)
            {
                tf2Red[i] = new Character("Bob", null, 10, 10, 10, new Item(), "Warrior");
            }


            var target = new GameBoard(null, tf2Blue, tf2Red, null, null);

            for (int i = 0; i < 6; i++)
            {
                Effect effThat = new Effect("health", 1, 10.0, true, target.getFirstTeamCharacters()[i]);
                target.addEffect(effThat);
            }

            target.turn();

            Assert.AreEqual(target.getFirstTeamCharacters()[5].GetCharacterHitPoints(), 90);
        }

        ///
        ///
        ///
         [Test()]
        public void TestThatGameBoardDoesFirstCharacterActionsDuringTurnTeam02()
        {
            Character[] tf2Blue = new Character[6];
            for (int i = 0; i < 6; i++)
            {
                tf2Blue[i] = new Character("Bob", null, 10, 10, 10, new Item(), "Warrior");
            }

            Character[] tf2Red = new Character[6];
            for (int i = 0; i < 6; i++)
            {
                tf2Red[i] = new Character("Bob", null, 10, 10, 10, new Item(), "Warrior");
            }


            var target = new GameBoard(null, tf2Blue, tf2Red, null, null);

            for (int i = 0; i < 6; i++)
            {
                Effect effThat = new Effect("health", 1, 10.0, true, target.getSecondTeamCharacters()[i]);
                target.addEffect(effThat);
            }

            target.turn();
            target.turn();
            Assert.AreEqual(target.getSecondTeamCharacters()[0].GetCharacterHitPoints(), 90);
        }

        [Test()]
         public void TestThatGameBoardDoesSecondCharacterActionsDuringTurnTeam02()
        {
            Character[] tf2Blue = new Character[6];
            for (int i = 0; i < 6; i++)
            {
                tf2Blue[i] = new Character("Bob", null, 10, 10, 10, new Item(), "Warrior");
            }

            Character[] tf2Red = new Character[6];
            for (int i = 0; i < 6; i++)
            {
                tf2Red[i] = new Character("Bob", null, 10, 10, 10, new Item(), "Warrior");
            }


            var target = new GameBoard(null, tf2Blue, tf2Red, null, null);

            for (int i = 0; i < 6; i++)
            {
                Effect effThat = new Effect("health", 1, 10.0, true, target.getSecondTeamCharacters()[i]);
                target.addEffect(effThat);
            }

            target.turn();
            target.turn();
            Assert.AreEqual(target.getSecondTeamCharacters()[1].GetCharacterHitPoints(), 90);
        }

        [Test()]
        public void TestThatGameBoardDoesThirdCharacterActionsDuringTurnTeam02()
        {
            Character[] tf2Blue = new Character[6];
            for (int i = 0; i < 6; i++)
            {
                tf2Blue[i] = new Character("Bob", null, 10, 10, 10, new Item(), "Warrior");
            }

            Character[] tf2Red = new Character[6];
            for (int i = 0; i < 6; i++)
            {
                tf2Red[i] = new Character("Bob", null, 10, 10, 10, new Item(), "Warrior");
            }


            var target = new GameBoard(null, tf2Blue, tf2Red, null, null);

            for (int i = 0; i < 6; i++)
            {
                Effect effThat = new Effect("health", 1, 10.0, true, target.getSecondTeamCharacters()[i]);
                target.addEffect(effThat);
            }

            target.turn();
            target.turn();
            Assert.AreEqual(target.getSecondTeamCharacters()[2].GetCharacterHitPoints(), 90);
        }

        [Test()]
        public void TestThatGameBoardDoesFourthCharacterActionsDuringTurnTeam02()
        {
            Character[] tf2Blue = new Character[6];
            for (int i = 0; i < 6; i++)
            {
                tf2Blue[i] = new Character("Bob", null, 10, 10, 10, new Item(), "Warrior");
            }

            Character[] tf2Red = new Character[6];
            for (int i = 0; i < 6; i++)
            {
                tf2Red[i] = new Character("Bob", null, 10, 10, 10, new Item(), "Warrior");
            }


            var target = new GameBoard(null, tf2Blue, tf2Red, null, null);

            for (int i = 0; i < 6; i++)
            {
                Effect effThat = new Effect("health", 1, 10.0, true, target.getSecondTeamCharacters()[i]);
                target.addEffect(effThat);
            }

            target.turn();
            target.turn();
            Assert.AreEqual(target.getSecondTeamCharacters()[3].GetCharacterHitPoints(), 90);
        }

        [Test()]
        public void TestThatGameBoardDoesFifthCharacterActionsDuringTurnTeam02()
        {
            Character[] tf2Blue = new Character[6];
            for (int i = 0; i < 6; i++)
            {
                tf2Blue[i] = new Character("Bob", null, 10, 10, 10, new Item(), "Warrior");
            }

            Character[] tf2Red = new Character[6];
            for (int i = 0; i < 6; i++)
            {
                tf2Red[i] = new Character("Bob", null, 10, 10, 10, new Item(), "Warrior");
            }


            var target = new GameBoard(null, tf2Blue, tf2Red, null, null);

            for (int i = 0; i < 6; i++)
            {
                Effect effThat = new Effect("health", 1, 10.0, true, target.getSecondTeamCharacters()[i]);
                target.addEffect(effThat);
            }

            target.turn();
            target.turn();
            Assert.AreEqual(target.getSecondTeamCharacters()[4].GetCharacterHitPoints(), 90);
        }

        [Test()]
        public void TestThatGameBoardDoesSixthCharacterActionsDuringTurnTeam02()
        {
            Character[] tf2Blue = new Character[6];
            for (int i = 0; i < 6; i++)
            {
                tf2Blue[i] = new Character("Bob", null, 10, 10, 10, new Item(), "Warrior");
            }

            Character[] tf2Red = new Character[6];
            for (int i = 0; i < 6; i++)
            {
                tf2Red[i] = new Character("Bob", null, 10, 10, 10, new Item(), "Warrior");
            }


            var target = new GameBoard(null, tf2Blue, tf2Red, null, null);

            for (int i = 0; i < 6; i++)
            {
                Effect effThat = new Effect("health", 1, 10.0, true, target.getSecondTeamCharacters()[i]);
                target.addEffect(effThat);
            }

            target.turn();
            target.turn();
            Assert.AreEqual(target.getSecondTeamCharacters()[5].GetCharacterHitPoints(), 90);
        }
        [Test()]
        public void TestThatAllBobsDiesAtEndOfTurnTeam01()
        {
            Character[] tf2Blue = new Character[6];
            for (int i = 0; i < 6; i++)
            {
                tf2Blue[i] = new Character("Bob", null, 10, 10, 10, new Item(), "Warrior");
            }

            Character[] tf2Red = new Character[6];
            for (int i = 0; i < 6; i++)
            {
                tf2Red[i] = new Character("Bob", null, 10, 10, 10, new Item(), "Warrior");
            }
            var target = new GameBoard(null, tf2Blue, tf2Red, null, null);

            for (int i = 0; i < 6; i++)
            {
                Effect effThat = new Effect("health", 1, 100.0, true, target.getFirstTeamCharacters()[i]);
                target.addEffect(effThat);
            }

            target.turn();
            Assert.AreEqual(target.getFirstTeamCharacters()[0].GetDead(), true);
            Assert.AreEqual(target.getFirstTeamCharacters()[1].GetDead(), true);
            Assert.AreEqual(target.getFirstTeamCharacters()[2].GetDead(), true);
            Assert.AreEqual(target.getFirstTeamCharacters()[3].GetDead(), true);
            Assert.AreEqual(target.getFirstTeamCharacters()[4].GetDead(), true);
            Assert.AreEqual(target.getFirstTeamCharacters()[5].GetDead(), true);
        }
        [Test()]
        public void TestThatAllBobsDiesAtEndOfTurnTeam02()
        {
            Character[] tf2Blue = new Character[6];
            for (int i = 0; i < 6; i++)
            {
                tf2Blue[i] = new Character("Bob", null, 10, 10, 10, new Item(), "Warrior");
            }

            Character[] tf2Red = new Character[6];
            for (int i = 0; i < 6; i++)
            {
                tf2Red[i] = new Character("Bob", null, 10, 10, 10, new Item(), "Warrior");
            }
            var target = new GameBoard(null, tf2Blue, tf2Red, null, null);

            for (int i = 0; i < 6; i++)
            {
                Effect effThat = new Effect("health", 1, 100.0, true, target.getSecondTeamCharacters()[i]);
                target.addEffect(effThat);
            }

            target.turn();
            Assert.AreEqual(target.getSecondTeamCharacters()[0].GetDead(), true);
            Assert.AreEqual(target.getSecondTeamCharacters()[1].GetDead(), true);
            Assert.AreEqual(target.getSecondTeamCharacters()[2].GetDead(), true);
            Assert.AreEqual(target.getSecondTeamCharacters()[3].GetDead(), true);
            Assert.AreEqual(target.getSecondTeamCharacters()[4].GetDead(), true);
            Assert.AreEqual(target.getSecondTeamCharacters()[5].GetDead(), true);
        }
    }
}
