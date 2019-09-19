using System;
using UnityEngine;

namespace AnimationQueue
{
    [RequireComponent(typeof(AnimationQueue))]
    public class AnimationSender : MonoBehaviour
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
            AnimationQueue.Animate(AnimationQueue.AnimationType.MoveLeft);
        }

        [Button]
        void EnqueueMoveRight()
        {
            AnimationQueue.Animate(AnimationQueue.AnimationType.MoveRight);
        }

        [Button]
        void EnqueueRotateLeft()
        {
            AnimationQueue.Animate(AnimationQueue.AnimationType.RotateLeft);
        }

        [Button]
        void EnqueueRotateRight()
        {
            AnimationQueue.Animate(AnimationQueue.AnimationType.RotateRight);
        }

        [Button]
        void EnqueueScaleUp()
        {
            AnimationQueue.Animate(AnimationQueue.AnimationType.ScaleUp);
        }

        [Button]
        void EnqueueScaleDown()
        {
            AnimationQueue.Animate(AnimationQueue.AnimationType.ScaleDown);
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
            
            AnimationQueue.Animate(values[UnityEngine.Random.Range(0, values.Length)]);
        }

        [Button]
        void Animate10xRandomly()
        {
            for (int i = 0; i < 10; ++i)
                AnimateRandomly();
        }
    }
}