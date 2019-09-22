using System;
using System.Collections.Generic;
using Patterns;
using UnityEngine;

namespace Command.UndoableMovement
{
    /// <summary>
    ///     An animation processor. It invokes commands.
    /// </summary>
    public class AnimationQueue : TimeredCommandQueue<BaseMotionAnimation>
    {
        List<BaseMotionAnimation> register = new List<BaseMotionAnimation>();
        
        /// <summary>
        ///     A animation type.
        /// </summary>
        public enum AnimationType
        {
            MoveLeft,
            MoveRight
        }

        //define the motion amounts
        readonly Vector3 moveAmount = new Vector3(1, 0, 0);

        [Tooltip("The entity which will be affected by the animations.")] [SerializeField]
        MotionEntity Entity;

        /// <summary>
        ///     Enqueues an animation based on its type.
        /// </summary>
        /// <param name="type"></param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public void InvokeAnimation(AnimationType type)
        {
            var command = type == AnimationType.MoveLeft 
                ? new MoveObject(Entity, -moveAmount)
                : new MoveObject(Entity, moveAmount);
            
            register.Add(command);
            Enqueue(command);
        }

        public void Undo()
        {
            var last = register.Count - 1;
            if (last < 0)
                return;
            
            var command = register[last];
            register.Remove(command);
        }
    }
}