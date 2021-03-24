using UnityEngine;

namespace Bridge
{
    public class LongFormView : BaseView
    {
        public LongFormView (IResource resource): base(resource)
        {

        }

        public override void Hide()
        {
            
        }

        public override void Show()
        {
            Debug.Log($"Display Long form view {Resource.Title} {Resource.Image} {Resource.Snippet} {Resource.Url}");
        }
    }
}