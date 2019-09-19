using System;
using UnityEngine;

namespace AnimationQueue
{
    /// <summary>
    ///     A client requesting to animations to the animation queue.
    /// </summary>
    [RequireComponent(typeof(AnimationQueue))]
    public class AnimationClient : MonoBehaviour
    {
        //Pointer to the animation queue.
        AnimationQueue AnimationQueue { get; set; }

        void Awake()
        {
            AnimationQueue = GetComponent<AnimationQueue>();
        }

        [Button]
        void EnqueueMoveLeft()
        {
            AnimationQueue.InvokeAnimation(AnimationQueue.AnimationType.MoveLeft);
        }

        [Button]
        void EnqueueMoveRight()
        {
            AnimationQueue.InvokeAnimation(AnimationQueue.AnimationType.MoveRight);
        }

        [Button]
        void EnqueueRotateLeft()
        {
            AnimationQueue.InvokeAnimation(AnimationQueue.AnimationType.RotateLeft);
        }

        [Button]
        void EnqueueRotateRight()
        {
            AnimationQueue.InvokeAnimation(AnimationQueue.AnimationType.RotateRight);
        }

        [Button]
        void EnqueueScaleUp()
        {
            AnimationQueue.InvokeAnimation(AnimationQueue.AnimationType.ScaleUp);
        }

        [Button]
        void EnqueueScaleDown()
        {
            AnimationQueue.InvokeAnimation(AnimationQueue.AnimationType.ScaleDown);
        }

        [Button]
        void AnimateRandomly()
        {
            var values = new []
            {
                AnimationQueue.AnimationType.MoveLeft,
                AnimationQueue.AnimationType.MoveRight,
                AnimationQueue.AnimationType.RotateLeft,
                AnimationQueue.AnimationType.RotateRight,
                AnimationQueue.AnimationType.ScaleUp,
                AnimationQueue.AnimationType.ScaleDown
            };
            
            AnimationQueue.InvokeAnimation(values[UnityEngine.Random.Range(0, values.Length)]);
        }

        [Button]
        void Animate10xRandomly()
        {
            for (int i = 0; i < 10; ++i)
                AnimateRandomly();
        }
    }
}