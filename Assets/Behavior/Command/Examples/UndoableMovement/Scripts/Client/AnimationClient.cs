using UnityEngine;

namespace Command.UndoableMovement
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
        void AnimateRandomly()
        {
            var values = new[]
            {
                AnimationQueue.AnimationType.MoveLeft,
                AnimationQueue.AnimationType.MoveRight
            };

            AnimationQueue.InvokeAnimation(values[Random.Range(0, values.Length)]);
        }

        [Button]
        void Animate10xRandomly()
        {
            for (var i = 0; i < 10; ++i)
                AnimateRandomly();
        }

        [Button]
        void Undo()
        {
            AnimationQueue.Undo();
        }
    }
}