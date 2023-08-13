using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProceduralToolkit.Samples
{
    [RequireComponent(typeof(MeshRenderer), typeof(MeshFilter))]
    public class Kieuk : MonoBehaviour
    {
        public float radius = 1f;
        public int segment = 16;
        public float height = 2f;


        private void Start()
        {
            GetComponent<MeshFilter>().mesh = MeshGenerator.Kieuk(radius, segment, height).ToMesh();
        }

        void Update()
        {
            GetComponent<MeshFilter>().mesh = MeshGenerator.Kieuk(radius, segment, height).ToMesh();
        }
    }
}