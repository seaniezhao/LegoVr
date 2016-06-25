using System;
using System.Collections.Generic;
using UnityEngine;
using System.Text;

namespace LegoVR
{
    public class PieceParent:MonoBehaviour
    {
        List<ShapePiece> _childrenPieces = new List<ShapePiece>();

        public List<ShapePiece> ChildrenPieces
        {
            get
            {
                return _childrenPieces;
            }
        }

        public void AddChild(ShapePiece child)
        {
            _childrenPieces.Add(child);
        }

        public void ChangeChildrenParentTo(PieceParent pparent)
        {
            for (int i = 0; i < _childrenPieces.Count; ++i)
            {
                _childrenPieces[i].Parent = pparent;
            }
        }

        public void Merge(PieceParent pparent)
        {
            pparent.ChangeChildrenParentTo(this);
            Destroy(pparent.gameObject);
        }

    }
}
