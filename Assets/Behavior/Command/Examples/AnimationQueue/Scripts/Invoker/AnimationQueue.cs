using System;
using Patterns;
using UnityEngine;

namespace Command.AnimationQueue
{
    /// <summary>
    ///     An animation processor. It invokes commands.
    /// </summary>
    public class AnimationQueue : TimeredCommandQueue<BaseMotionAnimation>
    {
        /// <summary>
        ///     A animation type.
        /// </summary>
        public enum AnimationType
        {
            MoveLeft, MoveRight, RotateLeft, RotateRight, ScaleUp, ScaleDown
        }
        
        //define the motion amounts
        readonly Vector3 moveAmount = new Vector3(1, 0, 0);
        readonly Vector3 rotationAmount = new Vector3(0, 0, 45);
        readonly Vector3 scaleAmount = new Vector3(0.5f, 0.5f, 0.5f);

        [Tooltip("The entity which will be affected by the animations.")] 
        [SerializeField] MotionEntity Entity;
        
        #region Commands
        
        BaseMotionAnimation MoveLeft { get; set; }
        BaseMotionAnimation MoveRight { get; set; }
        BaseMotionAnimation RotateLeft { get; set; }
        BaseMotionAnimation RotateRight { get; set; }
        BaseMotionAnimation ScaleUp { get; set; }
        BaseMotionAnimation ScaleDown { get; set; }

        #endregion

        void Awake()
        {
            CreateCommands();
        }

        void CreateCommands()
        {
            MoveLeft = new MoveObject(Entity, -moveAmount);
            MoveRight = new MoveObject(Entity, moveAmount);
            RotateLeft = new RotateObject(Entity, rotationAmount);
            RotateRight = new RotateObject(Entity, -rotationAmount);
            ScaleUp = new ScaleObject(Entity, scaleAmount);
            ScaleDown = new ScaleObject(Entity, -scaleAmount);
        }

        /// <summary>
        ///     Enqueues an animation based on its type.
        /// </summary>
        /// <param name="type"></param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public void InvokeAnimation(AnimationType type)
        {
            switch (type)
            {
                case AnimationType.MoveLeft: Enqueue(MoveLeft);
                    break;
                case AnimationType.MoveRight: Enqueue(MoveRight); 
                    break;
                case AnimationType.RotateLeft: Enqueue(RotateLeft);
                    break;
                case AnimationType.RotateRight: Enqueue(RotateRight);
                    break;
                case AnimationType.ScaleUp: Enqueue(ScaleUp);
                    break;
                case AnimationType.ScaleDown: Enqueue(ScaleDown);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(type), type, null);
            }
        }
    }
}