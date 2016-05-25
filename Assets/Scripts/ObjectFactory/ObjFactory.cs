using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace LegoVR
{
    public abstract class ShapeFactory
    {
        public abstract ShapePiece CreateObject(Vector3 pos, string name);
    }
}
