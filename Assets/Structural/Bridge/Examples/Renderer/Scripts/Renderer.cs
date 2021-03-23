using System;
using UnityEngine;

namespace Bridge
{
    public enum RendererType
    {
        DirectX, Vulcan
    }

    public partial class Renderer
    {
        private readonly IRendererImpl _rendererImpl;
        private RendererType Type { get; }

        public Renderer(RendererType type)
        {
            Type = type;

            switch (Type)
            {
                case RendererType.DirectX: _rendererImpl = new RendererDirectX(); 
                    break;
                case RendererType.Vulcan: _rendererImpl = new RendererVulcan(); 
                    break;
                default: Debug.LogError($"Can't create renderer with {Type}"); 
                    break;
            }
        }

        public void Render(Sprite sprite)
        {
            _rendererImpl?.Render(sprite);
        }
    }
}