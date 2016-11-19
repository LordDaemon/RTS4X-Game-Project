using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace RTS4X_Game_Project.CoreClasses
{
    public class GameStateManager
    {
        protected GameStates.GameState currentGameState;
        protected Dictionary<string, GameStates.GameState> gameStates;
        public GameWorld gameWorld;
        public Simulation simulation;

        public GameStateManager()
        {
            gameStates = new Dictionary<string, GameStates.GameState>();
            AddGameState(new GameStates.NoSim("NullState"));
            SwitchTo("NullState"); //A state that does nothing.
            gameWorld = new GameWorld();
            simulation = new Simulation();
        }

        public void AddGameState(GameStates.GameState state)
        {
            gameStates[state.name] = state;
            state.Add(this);
        }

        public GameStates.GameState GetGameState(string name)
        {
            return gameStates[name];
        }

        public void SwitchTo(string name)
        {
            if (gameStates.ContainsKey(name)) currentGameState = gameStates[name];
            else throw new KeyNotFoundException("The GameState " + name + "does not exist!");
        }

        public GameStates.GameState CurrrentGameState { get { return currentGameState; } }


        public void Update(GameTime GT)
        {
            currentGameState.Update(GT);
        }

        public void Draw(GameTime GT, SpriteBatch SB)
        {
            currentGameState.Draw(GT, SB);
        }
    }
}
