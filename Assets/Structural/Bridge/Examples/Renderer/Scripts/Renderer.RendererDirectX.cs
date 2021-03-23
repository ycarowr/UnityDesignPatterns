using UnityEngine;

namespace Bridge
{

    public partial class Renderer
    {
        private class RendererDirectX : IRendererImpl
        {
            public RendererType Type => RendererType.DirectX;

            public void Render(Sprite sprite)
            {
                Debug.Log("Rendered with DirectX");
            }
        }
    }
}