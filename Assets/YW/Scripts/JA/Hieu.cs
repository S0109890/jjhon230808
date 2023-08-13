using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProceduralToolkit.Samples
{
    [RequireComponent(typeof(MeshRenderer), typeof(MeshFilter))]
    public class Hieu : MonoBehaviour
    {
        public float radius = 1f;
        public int segment = 16;
        public float height = 2f;

        private void Start()
        {
            GetComponent<MeshFilter>().mesh = MeshGenerator.Hieu(radius, segment, height).ToMesh();
            transform.GetChild(0).transform.position += new Vector3(height * 0.5f, height * 0.5f, 0);
        }

        void Update()
        {
            Donut donut = transform.GetChild(0).GetComponent<Donut>();
            donut.CircleRadius = radius;
            donut.DonutRadius = height * 0.5f;
            transform.GetChild(0).transform.position = 
                transform.position + new Vector3(height * 0.5f, height * 0.5f, 0);

            GetComponent<MeshFilter>().mesh = MeshGenerator.Hieu(radius, segment, height).ToMesh();
        }
    }
}