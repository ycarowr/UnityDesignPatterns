using System.Collections.Generic;
using UnityEngine;

public partial class TurnBasedGame
{
    public partial class Game : IGameMechanic
    {
        readonly List<IGameMechanic> _gameMechanics = new List<IGameMechanic>();

        public Game()
        {
            AddMechanics(new Player());
            AddMechanics(new Enemies());
            AddMechanics(new TurnStarts());
            AddMechanics(new TurnFinishes());
            AddMechanics(new GameEnd());
            AddMechanics(new GameStart());
        }

        public void StartTurn() => _gameMechanics.ForEach(x => x.StartTurn());

        public void FinishTurn() => _gameMechanics.ForEach(x => x.FinishTurn());

        public void StartGame() => _gameMechanics.ForEach(x => x.StartGame());

        public void EndGame() => _gameMechanics.ForEach(x => x.EndGame());

        void AddMechanics(IGameMechanic m) => _gameMechanics.Add(m);
    }
}