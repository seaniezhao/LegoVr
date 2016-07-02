using System;
using System.Collections.Generic;
using UnityEngine;
using System.Text;
using Object=UnityEngine.Object;
namespace LegoVR
{
    public class Asset:IDisposable
    {
        public string AssetName { get; set; }
        public string AssetPath { get; set; }
        public delegate void AssetLoaded(Asset arg);
        public event AssetLoaded OnAssetLoaded;

        //是否加载成功
        public bool IsDone = false;

        //实际资源对象
        private Object _realAsset;




        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
