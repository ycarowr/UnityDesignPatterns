using UnityEngine;

namespace Bridge
{
    public partial class Renderer
    {
        public interface IRendererImpl
        {
            RendererType Type { get; }
            void Render(Sprite sprite);
        }
    }
}