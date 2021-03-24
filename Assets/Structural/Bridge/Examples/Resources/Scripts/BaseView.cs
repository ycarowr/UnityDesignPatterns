namespace Bridge
{
    public abstract class BaseView
    {
        protected IResource Resource { get; }

        protected BaseView(IResource resource)
        {
            Resource = resource;
        }

        public abstract void Show();

        public abstract void Hide();
    }
}