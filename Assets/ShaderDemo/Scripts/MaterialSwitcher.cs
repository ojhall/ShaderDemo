using System;
using System.Linq;
using UnityEngine;

namespace Assets.ShaderDemo.Scripts
{
    [RequireComponent(typeof(Renderer))]
    public class MaterialSwitcher : MonoBehaviour
    {
        public Material[] Materials;

        private Renderer _meshRenderer;
        private int _currentIndex;

        public void Start()
        {
            if (Materials == null || Materials.Length == 0)
            {
                throw new ArgumentException("Must have at least one material!");
            }

            _meshRenderer = GetComponent<Renderer>();
        }

        public void Update()
        {
            if (Input.anyKeyDown)
            {
                Switch();
            }
        }

        private void Switch()
        {
            _currentIndex = (_currentIndex + 1) % Materials.Length;
            _meshRenderer.materials = Enumerable.Repeat(Materials[_currentIndex], _meshRenderer.materials.Length).ToArray();
        }
    }
}