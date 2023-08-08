using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

namespace ProceduralToolkit.Samples
{
    /// <summary>
    /// A fully procedural chair generator, creates entire mesh from scratch and paints it's vertices
    /// </summary>
    public static class MeshGenerator_02
    {
        [Serializable]
        public class Config
        {
            public int index;
            public float radius = 0.07f;
            public int segment = 10;
            public float height = 0.7f;
            public float horizontal = 1.0f;
            public float vertical = 1.0f;
            public Color color = Color.white;
        }

        //sm
        public static MeshDraft Mesh(Config config, Renderer renderer, string shaderParameter)
        {
            //sm 매개변수만

            Assert.IsTrue(config.radius > 0);
            Assert.IsTrue(config.height > 0);
            Assert.IsTrue(config.segment > 0);

            Vector3 zero = Vector3.zero;
            Vector3 rightTop = Vector3.up * config.height / 2;

            List<MeshDraft> meshes02 = new List<MeshDraft>();

            var a = new MeshDraft { name = "a" };
            var ya = new MeshDraft { name = "ya" };
            var u = new MeshDraft { name = "u" };
            var yu = new MeshDraft { name = "yu" };
            var o = new MeshDraft { name = "o" };
            var yo = new MeshDraft { name = "yo" };
            var uo = new MeshDraft { name = "uo" };
            var uu = new MeshDraft { name = "uu" };
            var m = new MeshDraft { name = "m" };
            var l = new MeshDraft { name = "l" };

            meshes02.Add(a);
            meshes02.Add(ya);
            meshes02.Add(u);
            meshes02.Add(yu);
            meshes02.Add(o);
            meshes02.Add(yo);
            meshes02.Add(uo);
            meshes02.Add(uu);
            meshes02.Add(m);
            meshes02.Add(l);

            // ㅏ
            a.Add(Vertical(zero, config.radius, config.segment, config.height, config.vertical, config.horizontal));
            a.Add(Horizontal(rightTop, config.radius, config.segment, config.height / 3, config.vertical, config.horizontal));

            // ㅑ
            ya.Add(Vertical(zero, config.radius, config.segment, config.height, config.vertical, config.horizontal));
            ya.Add(Horizontal(rightTop - new Vector3(0, (config.height / 5), 0), config.radius, config.segment, config.height / 3, config.vertical, config.horizontal));
            ya.Add(Horizontal(rightTop + new Vector3(0, (config.height / 5), 0), config.radius, config.segment, config.height / 3, config.vertical, config.horizontal));

            // ㅓ
            u.Add(Vertical(zero + new Vector3(config.height / 3, 0, 0), config.radius, config.segment, config.height, config.vertical, config.horizontal));
            u.Add(Horizontal(rightTop, config.radius, config.segment, config.height / 3, config.vertical, config.horizontal));

            // ㅕ
            yu.Add(Vertical(zero + new Vector3(config.height / 3, 0, 0), config.radius, config.segment, config.height, config.vertical, config.horizontal));
            yu.Add(Horizontal(rightTop - new Vector3(0, (config.height / 5), 0), config.radius, config.segment, config.height / 3, config.vertical, config.horizontal));
            yu.Add(Horizontal(rightTop + new Vector3(0, (config.height / 5) * 1, 0), config.radius, config.segment, config.height / 3, config.vertical, config.horizontal));

            // ㅗ
            o.Add(Horizontal(zero, config.radius, config.segment, config.height, config.vertical, config.horizontal));
            o.Add(Vertical(zero + new Vector3((config.height / 2), 0, 0), config.radius, config.segment, config.height / 3, config.vertical, config.horizontal));

            // ㅛ
            yo.Add(Horizontal(zero, config.radius, config.segment, config.height, config.vertical, config.horizontal));
            yo.Add(Vertical(zero + new Vector3((config.height / 3), 0, 0), config.radius, config.segment, config.height / 3, config.vertical, config.horizontal));
            yo.Add(Vertical(zero + new Vector3((config.height / 3) * 2, 0, 0), config.radius, config.segment, config.height / 3, config.vertical, config.horizontal));

            // ㅜ
            uo.Add(Horizontal(zero + new Vector3(0, config.height / 3, 0), config.radius, config.segment, config.height, config.vertical, config.horizontal));
            uo.Add(Vertical(zero + new Vector3((config.height / 2), 0, 0), config.radius, config.segment, config.height / 3, config.vertical, config.horizontal));

            // ㅠ
            uu.Add(Horizontal(zero + new Vector3(0, config.height / 3, 0), config.radius, config.segment, config.height, config.vertical, config.horizontal));
            uu.Add(Vertical(zero + new Vector3((config.height / 3), 0, 0), config.radius, config.segment, config.height / 3, config.vertical, config.horizontal));
            uu.Add(Vertical(zero + new Vector3((config.height / 3) * 2, 0, 0), config.radius, config.segment, config.height / 3, config.vertical, config.horizontal));

            // ㅡ
            m.Add(Vertical(zero, config.radius, config.segment, config.height, config.vertical, config.horizontal));

            // ㅣ
            l.Add(Horizontal(zero, config.radius, config.segment, config.height, config.vertical, config.horizontal));

            meshes02[config.index].Paint(config.color);
            //sm
            float newSlideVal = CalculateSlideVal(config.height);
            renderer.material.SetFloat(shaderParameter, newSlideVal);
            //sm

            return meshes02[config.index];
        }


        private static MeshDraft Horizontal(Vector3 center, float radius, int segment, float height, float horizontal, float vertical)
        {
            var draft = MeshDraft.Cylinder(radius, segment, height * horizontal, true);

            Vector3 zeroVerti = Vector3.right * height / 2;
            draft.Rotate(Quaternion.Euler(0, 0, 90));
            draft.Move(zeroVerti);

            draft.Move(center);

            return draft;
        }

        private static MeshDraft Vertical(Vector3 center, float radius, int segment, float height, float vertical, float horizontal)
        {
            var draft = MeshDraft.Cylinder(radius, segment, height * vertical, true);

            Vector3 zeroHorizon = Vector3.up * height / 2;
            draft.Move(zeroHorizon);

            draft.Move(center);

            return draft;
        }

        private static MeshDraft Diagonal(Vector3 center, float radius, int segment, float height, float angle)
        {
            var draft = MeshDraft.Cylinder(radius, segment, height, true);

            Vector3 zeroVerti = Vector3.right * height / 2;
            draft.Rotate(Quaternion.Euler(0, 0, angle));
            draft.Move(zeroVerti);

            draft.Move(center);

            return draft;
        }
        //sm
        private static float CalculateSlideVal(float height)
        {
            float maxHight = 1.2f;
            return height / maxHight;
        }
        //sm
    }
}
