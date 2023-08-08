using ProceduralToolkit.Samples.UI;
using UnityEngine;

namespace ProceduralToolkit.Samples
{
    /// <summary>
    /// Configurator for ChairGenerator with UI and editor controls
    /// </summary>
    public class MeshGeneraatorConfiguration : ConfiguratorBase
    {
        public int id = 0;
        public int index;
        public MeshFilter mesh_filter;//jaum
        public MeshFilter mesh02_filter;//moum
        public RectTransform leftPanel;
        public bool constantSeed = false;
        public MeshGenerator.Config config = new MeshGenerator.Config();
        public MeshGenerator_02.Config config02 = new MeshGenerator_02.Config();

        //sm
        public Renderer jaumRenderer; // jaum renderer
        public Renderer moumRenderer; // jaum renderer
        public string shaderParameter = "SlideVal"; // shader value : Slide
        private Mesh chairMesh;
        private Mesh platformMesh;
        private float oldDepth; // store oldvalue 
        //sm

        private int minIndex = 0;
        private int maxIndex = 13;

        private int minIndex02 = 0;
        private int maxIndex02 = 9;
        private float minRadius = 0.05f;
        private float maxRadius = 0.5f;
        private float minHeight = 0.5f;
        private float maxHeight = 1.2f;
        private int minSegment = 6;
        private int maxSegment = 15;
        private float minHorizontal = 1.0f;
        private float maxHorizontal = 3.0f;
        private float minVertical = 1.0f;
        private float maxVertical = 3.0f;

        private Mesh mesh;
        private Mesh mesh02;

        private void Awake()
        {
            Generate();

            InstantiateControl<SliderControl>(leftPanel)
                .Initialize("Mesh", minIndex, maxIndex, config.index, value =>
                {
                    config.index = value;
                    Generate();
                });

            InstantiateControl<SliderControl>(leftPanel)
                .Initialize("Mesh_02", minIndex02, maxIndex02, config02.index, value =>
                {
                    config02.index = value;
                    Generate();
                });

            InstantiateControl<SliderControl>(leftPanel)
                .Initialize("Radius", minRadius, maxRadius, config.radius, value =>
                {
                    config.radius = value;
                    config02.radius = value;
                    Generate();
                });
            InstantiateControl<SliderControl>(leftPanel)
                .Initialize("Segment", minSegment, maxSegment, config.segment, value =>
                {
                    config.segment = value;
                    config02.segment = value;
                    Generate();
                });
            InstantiateControl<SliderControl>(leftPanel)
                .Initialize("Height", minHeight, maxHeight, config.height, value =>
                {
                    //sm
                    // When the legDepth changes, update the shader parameter
                    float newSlideVal = CalculateSlideVal(config.height);
                    jaumRenderer.material.SetFloat(shaderParameter, newSlideVal);
                    moumRenderer.material.SetFloat(shaderParameter, newSlideVal);
                    //sm
                    config.height = value;
                    config02.height = value;
                    Generate();
                });
            InstantiateControl<SliderControl>(leftPanel)
                .Initialize("Horizontal", minHorizontal, maxHorizontal, config.horizontal, value =>
                {
                    config.horizontal = value;
                    config02.horizontal = value;
                    Generate();
                });
            InstantiateControl<SliderControl>(leftPanel)
                .Initialize("Vertical", minVertical, maxVertical, config.vertical, value =>
                {
                    config.vertical = value;
                    config02.vertical = value;
                    Generate();
                });

            InstantiateControl<ButtonControl>(leftPanel).Initialize("Generate", () => Generate());
            //sm
            oldDepth = config.height; // Initialize with the current depth
        }

        public void Generate(bool randomizeConfig = true)
        {
            //sm
            if (config.height != oldDepth)
            {
                float newSlideVal = CalculateSlideVal(config.height);
                jaumRenderer.material.SetFloat(shaderParameter, newSlideVal);
                moumRenderer.material.SetFloat(shaderParameter, newSlideVal);
                oldDepth = config.height;
            }
            //sm

            if (constantSeed)
            {
                Random.InitState(0);
            }

            if (randomizeConfig)
            {
                GeneratePalette();

                // config.color = GetMainColor();
            }

            //sm : 매개변수만
            var meshGenerator = MeshGenerator.Mesh(config, jaumRenderer, shaderParameter);
            AssignDraftToMeshFilter(meshGenerator, mesh_filter, ref mesh);

            //sm :  매개변수만
            var meshGenerator02 = MeshGenerator_02.Mesh(config02, moumRenderer, shaderParameter);
            AssignDraftToMeshFilter(meshGenerator02, mesh02_filter, ref mesh02);

        }

        //sm
        float CalculateSlideVal(float depth)
        {
            return depth / maxHeight;
        }
        //sm
    }
}
