using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProceduralToolkit.Samples
{
    [RequireComponent(typeof(MeshRenderer), typeof(MeshFilter))]
    public class M : MonoBehaviour
    {
        public float radius = 0.35f;
        public int segment = 8;
        public float height = 2f;


        private void Start()
        {
            GetComponent<MeshFilter>().mesh = MeshGenerator_02.M(radius, segment, height).ToMesh();
        }

        void Update()
        {
            GetComponent<MeshFilter>().mesh = MeshGenerator_02.M(radius, segment, height).ToMesh();
        }
    }
}