#if UNITY_EDITOR
using Rakugaking.Battle;
using Rakugaking.Character;
using Rakugaking.UI;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;

namespace Rakugaking.EditorTools
{
    public static class Sprint1PrototypeBattleBuilder
    {
        private const string ScenePath = "Assets/Rakugaking/Scenes/PrototypeBattle.unity";
        private const string FighterPrefabPath = "Assets/Rakugaking/Prefabs/Character/PlaceholderFighter.prefab";
        private const string ArenaPrefabPath = "Assets/Rakugaking/Prefabs/Battle/Arena.prefab";

        [MenuItem("Rakugaking/Sprint 1/Build Prototype Battle Scene")]
        public static void BuildPrototypeBattleScene()
        {
            EnsureFolders();

            var scene = EditorSceneManager.NewScene(NewSceneSetup.EmptyScene, NewSceneMode.Single);

            CreateCamera();
            CreateLight();

            var arena = CreateArena();
            PrefabUtility.SaveAsPrefabAsset(arena, ArenaPrefabPath);

            var fighterPrefab = CreatePlaceholderFighter(Vector3.zero, FighterSide.FighterA);
            PrefabUtility.SaveAsPrefabAsset(fighterPrefab, FighterPrefabPath);
            Object.DestroyImmediate(fighterPrefab);

            var fighterA = PrefabUtility.InstantiatePrefab(AssetDatabase.LoadAssetAtPath<GameObject>(FighterPrefabPath)) as GameObject;
            fighterA.name = "FighterA";
            fighterA.transform.position = new Vector3(-2.5f, 2f, 0f);
            fighterA.GetComponent<BattleCharacter>().Setup(FighterSide.FighterA);

            var fighterB = PrefabUtility.InstantiatePrefab(AssetDatabase.LoadAssetAtPath<GameObject>(FighterPrefabPath)) as GameObject;
            fighterB.name = "FighterB";
            fighterB.transform.position = new Vector3(2.5f, 2f, 0f);
            fighterB.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
            fighterB.GetComponent<BattleCharacter>().Setup(FighterSide.FighterB);

            var battleRoot = new GameObject("BattleController");
            var controller = battleRoot.AddComponent<BattleController>();
            var shrinkingRing = battleRoot.AddComponent<ShrinkingRingController>();
            controller.SetFighters(fighterA.GetComponent<BattleCharacter>(), fighterB.GetComponent<BattleCharacter>());

            var hud = new GameObject("BattleHud");
            hud.AddComponent<BattleHud>();

            EditorSceneManager.SaveScene(scene, ScenePath);
            AssetDatabase.SaveAssets();
            AssetDatabase.Refresh();

            Debug.Log($"Sprint 1 prototype scene created: {ScenePath}");
        }

        private static void EnsureFolders()
        {
            CreateFolder("Assets", "Rakugaking");
            CreateFolder("Assets/Rakugaking", "Scenes");
            CreateFolder("Assets/Rakugaking", "Prefabs");
            CreateFolder("Assets/Rakugaking/Prefabs", "Battle");
            CreateFolder("Assets/Rakugaking/Prefabs", "Character");
        }

        private static void CreateFolder(string parent, string name)
        {
            var path = $"{parent}/{name}";
            if (!AssetDatabase.IsValidFolder(path))
            {
                AssetDatabase.CreateFolder(parent, name);
            }
        }

        private static void CreateCamera()
        {
            var cameraObject = new GameObject("Main Camera");
            var camera = cameraObject.AddComponent<Camera>();
            cameraObject.tag = "MainCamera";
            cameraObject.transform.position = new Vector3(0f, 5.5f, -9f);
            cameraObject.transform.rotation = Quaternion.Euler(28f, 0f, 0f);
            camera.fieldOfView = 50f;
        }

        private static void CreateLight()
        {
            var lightObject = new GameObject("Directional Light");
            var light = lightObject.AddComponent<Light>();
            light.type = LightType.Directional;
            light.intensity = 1.1f;
            lightObject.transform.rotation = Quaternion.Euler(50f, -30f, 0f);
        }

        private static GameObject CreateArena()
        {
            var arena = GameObject.CreatePrimitive(PrimitiveType.Cube);
            arena.name = "Arena";
            arena.transform.position = Vector3.zero;
            arena.transform.localScale = new Vector3(8f, 0.3f, 4f);
            return arena;
        }

        private static GameObject CreatePlaceholderFighter(Vector3 position, FighterSide side)
        {
            var root = new GameObject("PlaceholderFighter");
            root.transform.position = position;

            root.AddComponent<Health>();
            var character = root.AddComponent<BattleCharacter>();
            root.AddComponent<Sprint1AutoBattleMotion>();

            var body = CreatePart("Body", root.transform, new Vector3(0f, 1.2f, 0f), new Vector3(0.7f, 1.2f, 0.35f), 2f);
            var head = CreatePart("Head", root.transform, new Vector3(0f, 2.1f, 0f), new Vector3(0.55f, 0.55f, 0.55f), 1f);
            var leftArm = CreatePart("LeftArm", root.transform, new Vector3(-0.65f, 1.25f, 0f), new Vector3(0.3f, 0.9f, 0.3f), 0.7f);
            var rightArm = CreatePart("RightArm", root.transform, new Vector3(0.65f, 1.25f, 0f), new Vector3(0.3f, 0.9f, 0.3f), 0.7f);
            var leftLeg = CreatePart("LeftLeg", root.transform, new Vector3(-0.25f, 0.3f, 0f), new Vector3(0.3f, 1f, 0.3f), 1f);
            var rightLeg = CreatePart("RightLeg", root.transform, new Vector3(0.25f, 0.3f, 0f), new Vector3(0.3f, 1f, 0.3f), 1f);

            AddJoint(head, body);
            AddJoint(leftArm, body);
            AddJoint(rightArm, body);
            AddJoint(leftLeg, body);
            AddJoint(rightLeg, body);

            character.Setup(side);
            return root;
        }

        private static Rigidbody CreatePart(string name, Transform parent, Vector3 localPosition, Vector3 scale, float mass)
        {
            var part = GameObject.CreatePrimitive(PrimitiveType.Capsule);
            part.name = name;
            part.transform.parent = parent;
            part.transform.localPosition = localPosition;
            part.transform.localScale = scale;

            var rigidbody = part.AddComponent<Rigidbody>();
            rigidbody.mass = mass;
            rigidbody.drag = 0.2f;
            rigidbody.angularDrag = 0.2f;

            part.AddComponent<Sprint1CollisionDamage>();
            return rigidbody;
        }

        private static void AddJoint(Rigidbody connectedPart, Rigidbody body)
        {
            var joint = connectedPart.gameObject.AddComponent<ConfigurableJoint>();
            joint.connectedBody = body;
            joint.xMotion = ConfigurableJointMotion.Limited;
            joint.yMotion = ConfigurableJointMotion.Limited;
            joint.zMotion = ConfigurableJointMotion.Limited;
            joint.angularXMotion = ConfigurableJointMotion.Limited;
            joint.angularYMotion = ConfigurableJointMotion.Limited;
            joint.angularZMotion = ConfigurableJointMotion.Limited;
        }
    }
}
#endif
