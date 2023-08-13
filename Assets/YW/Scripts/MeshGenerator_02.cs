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
        //ㅏ
        public static MeshDraft K(float radius, int segment, float height)
        {
            var k = new MeshDraft { name = "K" };

            k.Add(Vertical(Vector3.zero, radius, segment, height));
            k.Add(Horizontal(Vector3.up * height / 2, radius, segment, height / 3));

            return k;
        }

        //ㅑ
        public static MeshDraft I(float radius, int segment, float height)
        {
            var i = new MeshDraft { name = "I" };

            i.Add(Vertical(Vector3.zero, radius, segment, height));
            i.Add(Horizontal(Vector3.up * height / 2 - new Vector3(0, (height / 5), 0), radius, segment, height / 3));
            i.Add(Horizontal(Vector3.up * height/2 + new Vector3(0, (height / 5), 0), radius, segment, height / 3));

            return i;
        }

        //ㅓ
        public static MeshDraft J(float radius, int segment, float height)
        {
            var j = new MeshDraft { name = "J" };

            j.Add(Vertical(Vector3.zero + new Vector3(height / 3, 0, 0), radius, segment, height));
            j.Add(Horizontal(Vector3.up * height / 2, radius, segment, height / 3));

            return j;
        }

        //ㅕ
        public static MeshDraft U(float radius, int segment, float height)
        {
            var u = new MeshDraft { name = "U" };

            u.Add(Vertical(Vector3.zero + new Vector3(height / 3, 0, 0), radius, segment, height));
            u.Add(Horizontal(Vector3.up * height / 2 - new Vector3(0, (height / 5), 0), radius, segment, height / 3));
            u.Add(Horizontal(Vector3.up * height / 2 + new Vector3(0, (height / 5) * 1, 0), radius, segment, height / 3));

            return u;
        }


        //ㅗ
        public static MeshDraft H(float radius, int segment, float height)
        {
            var h = new MeshDraft { name = "H" };

            h.Add(Horizontal(Vector3.zero, radius, segment, height));
            h.Add(Vertical(Vector3.zero + new Vector3(( height / 2), 0, 0), radius, segment, height / 3));

            return h;
        }

        //ㅛ
        public static MeshDraft Y(float radius, int segment, float height)
        {
            var y = new MeshDraft { name = "Y" };

            y.Add(Horizontal(Vector3.zero, radius, segment, height));
            y.Add(Vertical(Vector3.zero + new Vector3((height / 3), 0, 0), radius, segment, height / 3));
            y.Add(Vertical(Vector3.zero + new Vector3((height / 3) * 2, 0, 0), radius, segment, height / 3));

            return y;
        }

        //ㅜ
        public static MeshDraft N(float radius, int segment, float height)
        {
            var n = new MeshDraft { name = "N" };

            n.Add(Horizontal(Vector3.zero + new Vector3(0, height / 3, 0), radius, segment, height));
            n.Add(Vertical(Vector3.zero + new Vector3((height / 2), 0, 0), radius, segment, height / 3));

            return n;
        }

        //ㅠ
        public static MeshDraft B(float radius, int segment, float height)
        {
            var b = new MeshDraft { name = "B" };

            b.Add(Horizontal(Vector3.zero + new Vector3(0, height / 3, 0), radius, segment, height));
            b.Add(Vertical(Vector3.zero + new Vector3((height / 3), 0, 0), radius, segment, height / 3));
            b.Add(Vertical(Vector3.zero + new Vector3((height / 3) * 2, 0, 0), radius, segment, height / 3));

            return b;
        }

        //ㅡ
        public static MeshDraft M(float radius, int segment, float height)
        {
            var m = new MeshDraft { name = "M" };

            m.Add(Vertical(Vector2.zero, radius, segment, height));

            return m;
        }

        //ㅣ
        public static MeshDraft L(float radius, int segment, float height)
        {
            var l = new MeshDraft { name = "L" };

            l.Add(Horizontal(Vector3.zero, radius, segment, height));

            return l;
        }

        // ㅐ
        public static MeshDraft O(float radius, int segment, float height)
        {
            var o = new MeshDraft { name = "O" };

            o.Add(Vertical(Vector3.zero, radius, segment, height));
            o.Add(Horizontal(Vector3.up * height / 2, radius, segment, height / 3));
            o.Add(Vertical(Vector3.zero + new Vector3(height / 3, 0, 0), radius, segment, height));

            return o;
        }

        // ㅒ
        public static MeshDraft DoubleO(float radius, int segment, float height)
        {
            var oo = new MeshDraft { name = "DoubleO" };

            oo.Add(Vertical(Vector3.zero, radius, segment, height));
            oo.Add(Horizontal(Vector3.up * height / 2 - new Vector3(0, (height / 5), 0), radius, segment, height / 3));
            oo.Add(Horizontal(Vector3.up * height / 2 + new Vector3(0, (height / 5), 0), radius, segment, height / 3));
            oo.Add(Vertical(Vector3.zero + new Vector3(height / 3, 0, 0), radius, segment, height));

            return oo;
        }

        //ㅔ
        public static MeshDraft P(float radius, int segment, float height)
        {
            var p = new MeshDraft { name = "P" };

            p.Add(Vertical(Vector3.zero + new Vector3(height / 3, 0, 0), radius, segment, height));
            p.Add(Horizontal(Vector3.up * height / 2, radius, segment, height / 3));
            p.Add(Vertical(Vector3.zero + new Vector3(height / 3, 0, 0), radius, segment, height));
            return p;
        }

        // ㅖ
        public static MeshDraft DoubleP(float radius, int segment, float height)
        {
            var pp = new MeshDraft { name = "DoubleP" };

            pp.Add(Vertical(Vector3.zero + new Vector3(height / 3, 0, 0), radius, segment, height));
            pp.Add(Vertical(Vector3.zero + new Vector3(height / 3, 0, 0), radius, segment, height));
            pp.Add(Vertical(Vector3.zero + new Vector3(height / 3, 0, 0), radius, segment, height));
            pp.Add(Vertical(Vector3.zero + new Vector3(height / 3, 0, 0), radius, segment, height));

            return pp;
        }

        ////sm
        //public static MeshDraft Mesh(Config config, Renderer renderer, string shaderParameter)
        //{
        //    //sm 매개변수만

        //    Assert.IsTrue(config.radius > 0);
        //    Assert.IsTrue(config.height > 0);
        //    Assert.IsTrue(config.segment > 0);

        //    Vector3 zero = Vector3.zero;
        //    Vector3 rightTop = Vector3.up * config.height / 2;

        //    List<MeshDraft> meshes02 = new List<MeshDraft>();



        //    meshes02[config.index].Paint(config.color);
        //    //sm
        //    float newSlideVal = CalculateSlideVal(config.height);
        //    renderer.material.SetFloat(shaderParameter, newSlideVal);
        //    //sm

        //    return meshes02[config.index];
        //}


        private static MeshDraft Horizontal(Vector3 center, float radius, int segment, float height)
        {
            var draft = MeshDraft.Cylinder(radius, segment, height, true);

            Vector3 zeroVerti = Vector3.right * height / 2;
            draft.Rotate(Quaternion.Euler(0, 0, 90));
            draft.Move(zeroVerti);

            draft.Move(center);

            return draft;
        }

        private static MeshDraft Vertical(Vector3 center, float radius, int segment, float height)
        {
            var draft = MeshDraft.Cylinder(radius, segment, height, true);

            Vector3 zeroHorizon = Vector3.up * height / 2;
            draft.Move(zeroHorizon);

            draft.Move(center);

            return draft;
        }

        //sm
        private static float CalculateSlideVal(float height)
        {
            float maxHight = 1.2f;
            return height / maxHight;
        }
        
        private static void MaterialSetting(float height, Renderer renderer, string shaderParameter)
        {
            float newSlideVal = CalculateSlideVal(height);
            renderer.material.SetFloat(shaderParameter, newSlideVal);
        }
        //sm
    }
}
