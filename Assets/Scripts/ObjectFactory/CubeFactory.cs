using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace LegoVR
{
    public class CubeFactory : ShapeFactory
    {
        public override ShapePiece CreateObject(Vector3 pos ,string name)
        {
            GameObject go = GameObject.Instantiate( AssetManager.Instance.LoadPrefab("Cube", typeof(GameObject)) as GameObject);
            go.name = name;
            go.transform.position = pos;
            go.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);

            ShapePiece script = go.AddComponent<CubePiece>();



            return script;
        }
    }
}
