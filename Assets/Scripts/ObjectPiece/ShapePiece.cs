using System;
using System.Collections.Generic;
using UnityEngine;
using System.Text;

namespace LegoVR
{
    public abstract class ShapePiece : MonoBehaviour
    {
        public string Name;
        PieceParent _parent;
        public PieceParent Parent
        {
            get
            {
                return _parent;
            }
            set
            {
                _parent = value;
                _parent.AddChild(this);
                transform.SetParent(_parent.transform,true);
            }
        }



        public void Merge(ShapePiece otherpiece) 
        {
            if (Parent != null && otherpiece.Parent != null) //双方都已经组合过
            {
                Parent.Merge(otherpiece.Parent);
            }
            else if (Parent != null)
            {
                otherpiece.Parent = _parent; 
            }
            else if (otherpiece.Parent != null)
            {
                Parent = otherpiece.Parent;
            }
            else
            {
                GameObject go = new GameObject("Parent");
                PieceParent ppt = go.AddComponent<PieceParent>();
                Parent = ppt;
                otherpiece.Parent = ppt;
            }
        }
    }
}
