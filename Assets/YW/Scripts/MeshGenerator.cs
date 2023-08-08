using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

namespace ProceduralToolkit.Samples
{
    public static class MeshGenerator
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

        private delegate MeshDraft StretchersConstructor(Vector3[] legCenters, float legWidth, float legHeight);


        //sm
        public static MeshDraft Mesh(Config config, Renderer renderer, string shaderParameter)
        {
            //sm ¸Å°³º¯¼ö¸¸
            Assert.IsTrue(config.radius > 0);
            Assert.IsTrue(config.height > 0);
            Assert.IsTrue(config.segment > 0);

            Vector3 zero = Vector3.zero;
            Vector3 rightBottom = Vector3.right * config.height;
            Vector3 rightTop = Vector3.up * config.height;

            List<MeshDraft> meshDrafts = new List<MeshDraft>();
            List<MeshDraft> meshes = meshDrafts;

            var giyuk = new MeshDraft { name = "Giyuk" };
            var nieun = new MeshDraft { name = "Nieun" };
            var digeuk = new MeshDraft { name = "digeuk" };
            var rieul = new MeshDraft { name = "rieul" };
            var mieum = new MeshDraft { name = "mieum" };
            var bieub = new MeshDraft { name = "bieub" };
            var siot = new MeshDraft { name = "siot" };
            var ieung = new MeshDraft { name = "ieung" };
            var jiet = new MeshDraft { name = "jiet" };
            var chiet = new MeshDraft { name = "chiet" };
            var kieuk = new MeshDraft { name = "kieuk" };
            var tigeuk = new MeshDraft { name = "tigeuk" };
            var pieup = new MeshDraft { name = "pieup" };
            var hieu = new MeshDraft { name = "hieu" };

            meshes.Add(giyuk);
            meshes.Add(nieun);
            meshes.Add(digeuk);
            meshes.Add(rieul);
            meshes.Add(mieum);
            meshes.Add(bieub);
            meshes.Add(siot);
            meshes.Add(ieung);
            meshes.Add(jiet);
            meshes.Add(chiet);
            meshes.Add(kieuk);
            meshes.Add(tigeuk);
            meshes.Add(pieup);
            meshes.Add(hieu);


            #region ï¿½ï¿½ï¿½ï¿½
            // ï¿½ï¿½
            giyuk.Add(Horizontal(rightTop, config.radius, config.segment, config.height, config.horizontal, config.vertical));
            giyuk.Add(Vertical(rightBottom, config.radius, config.segment, config.height, config.vertical, config.horizontal));

            // ï¿½ï¿½
            nieun.Add(Horizontal(zero, config.radius, config.segment, config.height, config.horizontal, config.vertical));
            nieun.Add(Vertical(zero, config.radius, config.segment, config.height, config.vertical, config.horizontal));

            // ï¿½ï¿½
            digeuk.Add(Horizontal(rightTop, config.radius, config.segment, config.height, config.horizontal, config.vertical));
            digeuk.Add(Horizontal(zero, config.radius, config.segment, config.height, config.horizontal, config.vertical));
            digeuk.Add(Vertical(zero, config.radius, config.segment, config.height, config.vertical, config.horizontal));

            // ï¿½ï¿½
            rieul.Add(Horizontal(rightTop, config.radius, config.segment, config.height, config.horizontal, config.vertical));
            rieul.Add(Vertical(rightTop / 2 + rightBottom, config.radius, config.segment, config.height / 2, config.vertical, config.horizontal));
            rieul.Add(Horizontal(rightTop / 2, config.radius, config.segment, config.height, config.horizontal, config.vertical));
            rieul.Add(Vertical(zero, config.radius, config.segment, config.height / 2, config.vertical, config.horizontal));
            rieul.Add(Horizontal(zero, config.radius, config.segment, config.height, config.horizontal, config.vertical));

            // ï¿½ï¿½
            mieum.Add(Horizontal(rightTop, config.radius, config.segment, config.height, config.horizontal, config.vertical));
            mieum.Add(Horizontal(zero, config.radius, config.segment, config.height, config.horizontal, config.vertical));
            mieum.Add(Vertical(zero, config.radius, config.segment, config.height, config.vertical, config.horizontal));
            mieum.Add(Vertical(rightBottom, config.radius, config.segment, config.height, config.vertical, config.horizontal));

            // ï¿½ï¿½
            bieub.Add(Vertical(zero, config.radius, config.segment, config.height, config.vertical, config.horizontal));
            bieub.Add(Vertical(rightBottom, config.radius, config.segment, config.height, config.vertical, config.horizontal));
            bieub.Add(Horizontal(rightTop / 2, config.radius, config.segment, config.height, config.horizontal, config.vertical));
            bieub.Add(Horizontal(zero, config.radius, config.segment, config.height, config.horizontal, config.vertical));

            // ï¿½ï¿½
            siot.Add(Diagonal(rightTop / 2, config.radius, config.segment, Mathf.Sqrt(Mathf.Pow(config.height, 2)), -30.0f));
            siot.Add(Diagonal(rightTop / 2 + rightBottom / 2, config.radius, config.segment, Mathf.Sqrt(Mathf.Pow(config.height, 2)), -150.0f));

            // ï¿½ï¿½
            // ieung

            // ï¿½ï¿½
            float diagonal = Mathf.Sqrt(Mathf.Pow(config.height, 2));
            jiet.Add(Horizontal(rightTop, config.radius, config.segment, config.height, config.horizontal, config.vertical));
            jiet.Add(Diagonal(new Vector3(-config.height * 0.1f, config.height / 2, 0), config.radius, config.segment, config.height + config.height * 0.1f, -45.0f));
            jiet.Add(Diagonal(new Vector3(diagonal * 0.4f, diagonal * 0.3f, 0), config.radius, config.segment, diagonal * 0.6f, 45.0f));

            // ï¿½ï¿½
            chiet.Add(Vertical(rightTop + rightBottom / 2, config.radius, config.segment, config.height * 0.3f, config.vertical, config.horizontal));
            chiet.Add(Horizontal(rightTop, config.radius, config.segment, config.height, config.horizontal, config.vertical));
            chiet.Add(Diagonal(new Vector3(-config.height * 0.1f, config.height / 2, 0), config.radius, config.segment, config.height + config.height * 0.1f, -45.0f));
            // chiet.Add(Diagonal(rightTop * 0.6f + rightBottom * 0.3f, config.radius, config.segment, config.height, -45.0f));
            chiet.Add(Diagonal(new Vector3(diagonal * 0.4f, diagonal * 0.3f, 0), config.radius, config.segment, diagonal * 0.6f, 45.0f));


            // ï¿½ï¿½
            kieuk.Add(Horizontal(rightTop, config.radius, config.segment, config.height, config.horizontal, config.vertical));
            kieuk.Add(Horizontal(rightTop / 2, config.radius, config.segment, config.height, config.horizontal, config.vertical));
            kieuk.Add(Vertical(rightBottom, config.radius, config.segment, config.height, config.vertical, config.horizontal));

            // ï¿½ï¿½
            tigeuk.Add(Horizontal(rightTop, config.radius, config.segment, config.height, config.horizontal, config.vertical));
            tigeuk.Add(Horizontal(rightTop / 2, config.radius, config.segment, config.height, config.horizontal, config.vertical));
            tigeuk.Add(Vertical(zero, config.radius, config.segment, config.height, config.vertical, config.horizontal));
            tigeuk.Add(Horizontal(zero, config.radius, config.segment, config.height, config.horizontal, config.vertical));

            // ï¿½ï¿½
            pieup.Add(Horizontal(rightTop, config.radius, config.segment, config.height, config.horizontal, config.vertical));
            pieup.Add(Vertical(rightBottom * 0.25f, config.radius, config.segment, config.height, config.vertical, config.horizontal));
            pieup.Add(Vertical(rightBottom * 0.75f, config.radius, config.segment, config.height, config.vertical, config.horizontal));
            pieup.Add(Horizontal(zero, config.radius, config.segment, config.height, config.horizontal, config.vertical));

            // ï¿½ï¿½
            hieu.Add(Vertical(rightTop + rightBottom / 2, config.radius, config.segment, config.height * 0.3f, config.vertical, config.horizontal));
            hieu.Add(Horizontal(rightTop, config.radius, config.segment, config.height, config.horizontal, config.vertical));

            #endregion

            meshes[config.index].Paint(config.color);

            //sm
            float newSlideVal = CalculateSlideVal(config.height);
            renderer.material.SetFloat(shaderParameter, newSlideVal);
            //sm

            return meshes[config.index];
        }

        // °¡·Î
        private static MeshDraft Horizontal(Vector3 center, float radius, int segment, float height, float horizontal, float vertical)
        {
            var draft = MeshDraft.Cylinder(radius, segment, height * horizontal, true);

            Vector3 zeroVerti = Vector3.right * height / 2;
            draft.Rotate(Quaternion.Euler(0, 0, 90));
            draft.Move(zeroVerti);

            draft.Move(center);

            return draft;
        }

        // ¼¼·Î
        private static MeshDraft Vertical(Vector3 center, float radius, int segment, float height, float vertical, float horizontal)
        {
            var draft = MeshDraft.Cylinder(radius, segment, height * vertical, true);

            Vector3 zeroHorizon = Vector3.up * height / 2;
            draft.Move(zeroHorizon);

            draft.Move(center);

            return draft;
        }

        // ´ë°¢¼±
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
