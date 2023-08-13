using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProceduralToolkit.Samples
{
    [RequireComponent(typeof(MeshRenderer), typeof(MeshFilter))]
    public class DoubleDigeuk : MonoBehaviour
    {
        public float radius = 0.35f;
        public int segment = 8;
        public float height = 2f;


        private void Start()
        {
            GetComponent<MeshFilter>().mesh = MeshGenerator.DoubleDigeuk(radius, segment, height).ToMesh();
        }

        void Update()
        {
            GetComponent<MeshFilter>().mesh = MeshGenerator.DoubleDigeuk(radius, segment, height).ToMesh();
        }
    }
}