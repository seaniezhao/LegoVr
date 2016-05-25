using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace LegoVR
{
    public class Startup: MonoBehaviour
    {
        void Awake()
        {

        }

        void Start()
        {
            CubeFactory factory = new CubeFactory();

            ShapePiece x = factory.CreateObject(Vector3.zero,"x");

            GameObject go = new GameObject("Parent1");
            go.transform.position = new Vector3(1, 2, 3);
            PieceParent ppt = go.AddComponent<PieceParent>();
            x.Parent = ppt;
            ShapePiece y = factory.CreateObject(Vector3.one, "y");

            x.Merge(y);

            ShapePiece a = factory.CreateObject(Vector3.zero, "a");
            ShapePiece b = factory.CreateObject(Vector3.one,"b");
            a.Merge(b);

            x.Merge(a);

        }
    }
}
