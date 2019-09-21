using System.Linq.Expressions;
using UnityEngine;

namespace Command.InputWrapper
{
    using Patterns;
    
    /// <summary>
    ///     A component that binds a input key to any command.
    /// </summary>
    public abstract class KeyCommandBinder : MonoBehaviour
    {
        protected abstract KeyCode Key { get; }
        BaseMotion Command { get; set; }
        
        void Start()
        {
            Command = GetCommand();
        }

        void Update()
        {
            if(Input.GetKey(Key))
                Command?.Execute();
        }

        protected abstract BaseMotion GetCommand();
    }
}