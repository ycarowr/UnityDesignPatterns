using Patterns.StateMachine;

namespace CardStateMachine
{
    /// <summary>
    ///     State Machine that holds all states of a UI Card.
    /// </summary>
    public class UiCardFsm : PushDownAutomata
    {
        //--------------------------------------------------------------------------------------------------------------

        public UiCardFsm()
        {
            //Create States
            IdleState = new UiCardIdle(this);
            DisableState = new UiCardDisable(this);
            DragState = new UiCardDrag(this);
            HoverState = new UiCardHover(this);
            DrawState = new UiCardDraw(this);
            DiscardState = new UiCardDiscard(this);

            //Register States
            RegisterState(IdleState);
            RegisterState(DisableState);
            RegisterState(DragState);
            RegisterState(HoverState);
            RegisterState(DrawState);
            RegisterState(DiscardState);

            //Initialize
            Initialize();
        }

        //--------------------------------------------------------------------------------------------------------------

        #region Properties

        UiCardIdle IdleState { get; }
        UiCardDisable DisableState { get; }
        UiCardDrag DragState { get; }
        UiCardHover HoverState { get; }
        UiCardDraw DrawState { get; }
        UiCardDiscard DiscardState { get; }

        #endregion

        //--------------------------------------------------------------------------------------------------------------

        #region Operations

        public void Hover()
        {
            PushState<UiCardHover>();
        }

        public void Disable()
        {
            PushState<UiCardDisable>();
        }

        public void Idle()
        {
            PushState<UiCardIdle>();
        }

        public void Drag()
        {
            PushState<UiCardDrag>();
        }

        public void Draw()
        {
            PushState<UiCardDraw>();
        }

        public void Discard()
        {
            PushState<UiCardDiscard>();
        }

        #endregion
    }
}