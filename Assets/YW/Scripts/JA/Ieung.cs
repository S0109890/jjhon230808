using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProceduralToolkit.Samples
{
    public class Ieung : MonoBehaviour
    {
        public float radius = 0.35f;
        public int segment = 8;
        public float height = 2f;

        private void Start()
        {
            transform.GetChild(0).transform.position += new Vector3(height * 0.5f, height * 0.5f, 0);
        }

        void Update()
        {
            Donut donut = transform.GetChild(0).GetComponent<Donut>();
            donut.CircleRadius = radius;
            donut.DonutRadius = height * 0.5f;
            transform.GetChild(0).transform.position =
                transform.position + new Vector3(height * 0.5f, height * 0.5f, 0);
        }
    }
}