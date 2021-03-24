using UnityEngine;

namespace Bridge
{
    public class ShortFormView : BaseView
    {
        public ShortFormView(IResource resource) : base(resource)
        {

        }

        public override void Hide()
        {

        }

        public override void Show()
        {
            Debug.Log($"Display Short form view {Resource.Title} {Resource.Image}");
        }
    }
}