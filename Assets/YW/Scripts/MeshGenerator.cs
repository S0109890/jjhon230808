using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

namespace ProceduralToolkit.Samples
{
    public partial class MeshGenerator
    {
        // ��
        public static MeshDraft Giyuk(float radius, int segment, float height)
        {
            var giyuk = new MeshDraft { name = "Giyuk" };

            giyuk.Add(Horizontal(Vector3.up * height, radius, segment, height));
            giyuk.Add(Vertical(Vector3.right * height, radius, segment, height));

            //meshes[config.index].Paint(config.color);
            return giyuk;
        }

        //��
        public static MeshDraft DoubleGiyuk(float radius, int segment, float height)
        {
            var doubleGiyuk = new MeshDraft { name = "DoubleGiyuk" };

            doubleGiyuk.Add(Horizontal(Vector3.up * height, radius, segment, height*0.5f));
            doubleGiyuk.Add(Vertical(Vector3.right * height*0.5f, radius, segment, height));
            doubleGiyuk.Add(Horizontal(Vector3.up * height + Vector3.right, radius, segment, height*0.5f));
            doubleGiyuk.Add(Vertical(Vector3.right * height, radius, segment, height));

            //meshes[config.index].Paint(config.color);
            return doubleGiyuk;
        }

        // ��
        public static MeshDraft Nieun(float radius, int segment, float height)
        {
            var nieun = new MeshDraft { name = "Nieun" };

            nieun.Add(Horizontal(Vector3.zero, radius, segment, height));
            nieun.Add(Vertical(Vector3.zero, radius, segment, height));

            return nieun;
        }

        // ��
        public static MeshDraft Digeuk(float radius, int segment, float height)
        {
            var digeuk = new MeshDraft { name = "Digeuk" };
     
            digeuk.Add(Horizontal(Vector3.up * height, radius, segment, height));
            digeuk.Add(Horizontal(Vector3.zero, radius, segment, height));
            digeuk.Add(Vertical(Vector3.zero, radius, segment, height));

            return digeuk;
        }

        //��
        public static MeshDraft DoubleDigeuk(float radius, int segment, float height)
        {
            var doubleDigeuk = new MeshDraft { name = "DoubleDigeuk" };

            doubleDigeuk.Add(Horizontal(Vector3.up * height, radius, segment, height*0.5f));
            doubleDigeuk.Add(Horizontal(Vector3.zero, radius, segment, height*0.5f));
            doubleDigeuk.Add(Vertical(Vector3.zero, radius, segment, height));

            doubleDigeuk.Add(Horizontal(Vector3.up * height + Vector3.right, radius, segment, height * 0.5f));
            doubleDigeuk.Add(Horizontal(new Vector3(height * 0.5f, 0, 0), radius, segment, height * 0.5f));
            doubleDigeuk.Add(Vertical(new Vector3(height*0.5f,0,0), radius, segment, height));

            return doubleDigeuk;
        }

        // ��
        public static MeshDraft Rieul(float radius, int segment, float height)
        {
            var rieul = new MeshDraft { name = "Rieul" };

            rieul.Add(Horizontal(Vector3.up * height, radius, segment, height));
            rieul.Add(Vertical(Vector3.up * height / 2 + Vector3.right * height, radius, segment, height / 2));
            rieul.Add(Horizontal(Vector3.up * height / 2, radius, segment, height));
            rieul.Add(Vertical(Vector3.zero, radius, segment, height / 2));
            rieul.Add(Horizontal(Vector3.zero, radius, segment, height));

            return rieul;
        }

        // ��
        public static MeshDraft Mieum(float radius, int segment, float height)
        {
            var mieum = new MeshDraft { name = "Mieum" };

            Vector3 rightBottom = Vector3.right * height;
            Vector3 rightTop = Vector3.up * height;

            mieum.Add(Horizontal(Vector3.up * height, radius, segment, height));
            mieum.Add(Horizontal(Vector3.zero, radius, segment, height));
            mieum.Add(Vertical(Vector3.zero, radius, segment, height));
            mieum.Add(Vertical(Vector3.right * height, radius, segment, height));

            return mieum;
        }

        // ��
        public static MeshDraft Bieub(float radius, int segment, float height)
        {
            var bieub = new MeshDraft { name = "Bieub" };

            bieub.Add(Vertical(Vector3.zero, radius, segment, height));
            bieub.Add(Vertical(Vector3.right * height, radius, segment, height));
            bieub.Add(Horizontal(Vector3.up * height / 2, radius, segment, height));
            bieub.Add(Horizontal(Vector3.zero, radius, segment, height));
            
            return bieub;
        }

        public static MeshDraft DoubleBieub(float radius, int segment, float height)
        {
            var doubleBieub = new MeshDraft { name = "DoubleBieub" };

            doubleBieub.Add(Vertical(Vector3.zero, radius, segment, height));
            doubleBieub.Add(Vertical(Vector3.right * height*0.5f, radius, segment, height));
            doubleBieub.Add(Horizontal(Vector3.up * height*0.5f, radius, segment, height * 0.5f));
            doubleBieub.Add(Horizontal(Vector3.zero, radius, segment, height * 0.5f));

            doubleBieub.Add(Vertical(new Vector3(height * 0.5f, 0, 0), radius, segment, height));
            doubleBieub.Add(Vertical(Vector3.right * height, radius, segment, height));
            doubleBieub.Add(Horizontal(Vector3.up * height / 2+ new Vector3(height * 0.5f, 0, 0), radius, segment, height*0.5f));
            doubleBieub.Add(Horizontal(new Vector3(height * 0.5f, 0, 0), radius, segment, height*0.5f));

            return doubleBieub;
        }

        // ��
        public static MeshDraft Siot(float radius, int segment, float height)
        {
            var siot = new MeshDraft { name = "Siot" };
            float length = Mathf.Sqrt(Mathf.Pow(height, 2) + Mathf.Pow(height * 0.5f, 2));

            siot.Add(Diagonal(new Vector3(height * 0.25f,height * 0.5f,0), radius, segment, length, -30.0f));
            siot.Add(Diagonal(new Vector3(height * 0.75f, height * 0.5f,0), radius, segment, length, -150.0f));

            return siot;
        }

        // ��
        public static MeshDraft DoubleSiot(float radius, int segment, float height)
        {
            var doubleSiot = new MeshDraft { name = "DoubleSiot" };

            float length = Mathf.Sqrt(Mathf.Pow(height, 2) + Mathf.Pow(height * 0.5f, 2));

            doubleSiot.Add(Diagonal(new Vector3(height * 0.1295f, height * 0.483f, 0), radius, segment, length, -15.0f));
            doubleSiot.Add(Diagonal(new Vector3(height * 0.3795f, height * 0.483f, 0), radius, segment, length, -165.0f));

            doubleSiot.Add(Diagonal(new Vector3(height * 0.5295f, height * 0.483f, 0), radius, segment, length, -15.0f));
            doubleSiot.Add(Diagonal(new Vector3(height * 0.7795f, height * 0.483f, 0), radius, segment, length, -165.0f));

            return doubleSiot;
        }

        // ��
        public static MeshDraft Ieung(float radius, int segment, float height)
        {
            var ieung = new MeshDraft { name = "Ieung" };

            // ���� ��ũ��Ʈ�� ��ü.
            return ieung;
        }

        // ��
        public static MeshDraft Jiet(float radius, int segment, float height)
        {
            var jiet = new MeshDraft { name = "Jiet" };

            float length = Mathf.Sqrt(Mathf.Pow(height, 2) + Mathf.Pow(height * 0.5f, 2));

            jiet.Add(Horizontal(Vector3.up * height, radius, segment, height));
            jiet.Add(Diagonal(new Vector3(height * 0.25f, height * 0.5f, 0), radius, segment, length, -30.0f));
            jiet.Add(Diagonal(new Vector3(height * 0.75f, height * 0.5f, 0), radius, segment, length, -150.0f));
            //float diagonal = Mathf.Sqrt(Mathf.Pow(height, 2));
            //jiet.Add(Diagonal(new Vector3(-height * 0.1f, height / 2, 0) + Vector3.right * height / 2,
            //                           radius, segment, height + height * 0.1f, -45.0f));
            //jiet.Add(Diagonal(new Vector3(diagonal * 0.4f, diagonal * 0.3f, 0) + Vector3.right * height / 2,
            //                            radius, segment, diagonal * 0.6f, 45.0f));

            return jiet;
        }

        public static MeshDraft DoubleJiet(float radius, int segment, float height)
        {
            var doublejiet = new MeshDraft { name = "DoubleJiet" };

            float length = Mathf.Sqrt(Mathf.Pow(height, 2) + Mathf.Pow(height * 0.5f, 2));

            doublejiet.Add(Diagonal(new Vector3(height * 0.25f * 0.5f, height * 0.5f, 0), radius, segment, length, -15.0f));
            doublejiet.Add(Diagonal(new Vector3(height * 0.75f * 0.5f, height * 0.5f, 0), radius, segment, length, -165.0f));

            doublejiet.Add(Diagonal(new Vector3(height * 0.25f + height * 0.5f, height * 0.5f, 0), radius, segment, length, -15.0f));
            doublejiet.Add(Diagonal(new Vector3(height * 0.75f + height * 0.25f, height * 0.5f, 0), radius, segment, length, -165.0f));

            return doublejiet;
        }

        // ��
        public static MeshDraft Chiet(float radius, int segment, float height)
        {
            var chiet = new MeshDraft { name = "Chiet" };

            float length = Mathf.Sqrt(Mathf.Pow(height, 2) + Mathf.Pow(height * 0.5f, 2));

            chiet.Add(Vertical(Vector3.up * height + Vector3.right * height / 2, radius, segment, height * 0.3f));
            chiet.Add(Horizontal(Vector3.up * height, radius, segment, height));
            chiet.Add(Diagonal(new Vector3(height * 0.25f, height * 0.5f, 0), radius, segment, length, -30.0f));
            chiet.Add(Diagonal(new Vector3(height * 0.75f, height * 0.5f, 0), radius, segment, length, -150.0f));
            //float diagonal = Mathf.Sqrt(Mathf.Pow(height, 2));
            //chiet.Add(Diagonal(new Vector3(-height * 0.1f, height / 2, 0)+ Vector3.right * height / 2,
            //                            radius, segment, height + height * 0.1f, -45.0f));
            //chiet.Add(Diagonal(new Vector3(diagonal * 0.4f, diagonal * 0.3f, 0)+ Vector3.right * height / 2,
            //                            radius, segment, diagonal * 0.6f, 45.0f));

            return chiet;
        }

        // ��
        public static MeshDraft Kieuk(float radius, int segment, float height)
        {
            var kieuk = new MeshDraft { name = "Kieuk" };

            kieuk.Add(Horizontal(Vector3.up * height, radius, segment, height));
            kieuk.Add(Horizontal(Vector3.up * height / 2, radius, segment, height));
            kieuk.Add(Vertical(Vector3.right * height, radius, segment, height));

            return kieuk;
        }

        // ��
        public static MeshDraft Tigeuk(float radius, int segment, float height)
        {
            var tigeuk = new MeshDraft { name = "Tigeuk" };

            tigeuk.Add(Horizontal(Vector3.up * height, radius, segment, height));
            tigeuk.Add(Horizontal(Vector3.up * height / 2, radius, segment, height));
            tigeuk.Add(Vertical(Vector3.zero, radius, segment, height));
            tigeuk.Add(Horizontal(Vector3.zero, radius, segment, height));

            return tigeuk;
        }

        // ��
        public static MeshDraft Pieup(float radius, int segment, float height)
        {
            var pieup = new MeshDraft { name = "Pieup" };

            pieup.Add(Horizontal(Vector3.up * height, radius, segment, height));
            pieup.Add(Vertical(Vector3.right * height * 0.25f, radius, segment, height));
            pieup.Add(Vertical(Vector3.right * height * 0.75f, radius, segment, height));
            pieup.Add(Horizontal(Vector3.zero, radius, segment, height));

            return pieup;
        }

        // ��
        public static MeshDraft Hieu(float radius, int segment, float height)
        {
            var hieu = new MeshDraft { name = "Hieu" };

            hieu.Add(Vertical(Vector3.up * height + Vector3.right * height / 2, radius, segment, height * 0.3f));
            hieu.Add(Horizontal(Vector3.up * height, radius, segment, height));

            return hieu;
        }

        

        // ����
        private static MeshDraft Horizontal(Vector3 center, float radius, int segment, float height)
        {
            var draft = MeshDraft.Cylinder(radius, segment, height, true);

            Vector3 zeroVerti = Vector3.right * height / 2;
            draft.Rotate(Quaternion.Euler(0, 0, 90));
            draft.Move(zeroVerti);

            draft.Move(center);

            return draft;
        }

        // ����
        private static MeshDraft Vertical(Vector3 center, float radius, int segment, float height)
        {
            var draft = MeshDraft.Cylinder(radius, segment, height, true);

            Vector3 zeroHorizon = Vector3.up * height / 2;
            draft.Move(zeroHorizon);

            draft.Move(center);

            return draft;
        }

        // �밢��
        private static MeshDraft Diagonal(Vector3 center, float radius, int segment, float height, float angle)
        {
            var draft = MeshDraft.Cylinder(radius, segment, height, true);

            //Vector3 zeroVerti = Vector3.right * height / 2;
            draft.Rotate(Quaternion.Euler(0, 0, angle));
            //draft.Move(zeroVerti);

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
    }
}
