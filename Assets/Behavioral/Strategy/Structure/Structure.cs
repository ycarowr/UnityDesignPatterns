using System.Collections;
using System.Collections.Generic;
using System.Security.Permissions;
using UnityEngine;

namespace Strategy
{
    public class Example
    {
        /// <summary>
        ///     The object that holds the algorithm for strategy A
        /// </summary>
        private readonly IStrategy _strategyA = new StrategyA();
        
        /// <summary>
        ///     The object that holds the algorithm for strategy B
        /// </summary>
        private IStrategy _strategyB = new StrategyB();
        
        /// <summary>
        ///     The current strategy.
        /// </summary>
        private IStrategy CurrentStrategy { get; set; }
        
        public void ExecuteStrategy()
        {
            CurrentStrategy.Execute();
        }

        public Example()
        {
            //default
            CurrentStrategy = _strategyA;
        }

        public void SwapStrategy()
        {
            CurrentStrategy = CurrentStrategy == _strategyA ? _strategyB : _strategyA;
        }
    }
    
    /// <summary>
    ///     The client that makes use of a functionality.
    /// </summary>
    public class Client
    {
        public Client(IStrategy operation)
        {
            Operation = operation;
        }

        private IStrategy Operation { get; }
        
        public void Execute()
        {
            Operation.Execute();
        }
    }

    /// <summary>
    ///     Interface for a functionality.
    /// </summary>
    public interface IStrategy
    {
        void Execute();
    }

    /// <summary>
    ///     Algorithm A that implements the functionality.
    /// </summary>
    public class StrategyA : IStrategy
    {
        public void Execute()
        {
            Debug.Log("Execute Strategy A");
        }
    }
    
    /// <summary>
    ///     Algorithm B that implements the functionality.
    /// </summary>
    public class StrategyB : IStrategy
    {
        public void Execute()
        {
            Debug.Log("Execute Strategy B");
        }
    }
}