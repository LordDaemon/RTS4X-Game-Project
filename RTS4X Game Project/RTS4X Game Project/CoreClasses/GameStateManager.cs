using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace RTS4X_Game_Project.CoreClasses
{
    public class GameStateManager
    {
        protected GameState currentGameState;
        protected Dictionary<string, GameState> gameStates;

        public GameStateManager()
        {
            gameStates = new Dictionary<string, GameState>();
            AddGameState(new GameState("NullState"));
            SwitchTo("NullState");
        }

        public void AddGameState(GameState state)
        {
            gameStates[state.name] = state;
        }

        public GameState GetGameState(string name)
        {
            return gameStates[name];
        }

        public void SwitchTo(string name)
        {
            if (gameStates.ContainsKey(name)) currentGameState = gameStates[name];
            else throw new KeyNotFoundException("The GameState " + name + "does not exist!");
        }

        public GameState CurrrentGameState { get { return currentGameState; } }


        public void Update(GameTime GT)
        {
            currentGameState.Update(GT);
        }

        public void Draw(GameTime GT/*, SpriteBatch SB*/)
        {
            currentGameState.Draw(GT/*, SB*/);
        }
    }
}
