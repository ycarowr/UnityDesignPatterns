using UnityEngine;

namespace CardStateMachine
{
    public class UiCardComponent : MonoBehaviour
    {
        UiCardFsm Fsm { get; set; }

        //--------------------------------------------------------------------------------------------------------------

        #region Initialization

        void Awake() => Fsm = new UiCardFsm();

        void Update() => Fsm?.Update();

        #endregion


        //--------------------------------------------------------------------------------------------------------------

        #region Card Operations

        [Button]
        public void Hover() => Fsm.Hover();

        [Button]
        public void Disable() => Fsm.Disable();

        [Button]
        public void Draw() => Fsm.Draw();

        [Button]
        public void Discard() => Fsm.Discard();

        [Button]
        public void Idle() => Fsm.Idle();

        [Button]
        public void Drag() => Fsm.Drag();

        [Button]
        public void Pop() => Fsm.PopState();

        #endregion

        //--------------------------------------------------------------------------------------------------------------
    }
}