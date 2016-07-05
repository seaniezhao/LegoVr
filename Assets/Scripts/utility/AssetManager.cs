using System;
using System.Collections.Generic;
using UnityEngine;
using System.Text;

namespace LegoVR
{
    public class AssetManager
    {

        private volatile static AssetManager _instance = null;
        private static readonly object lockHelper = new object();
        
        public static AssetManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (lockHelper)
                    {
                        if (_instance == null)
                            _instance = new AssetManager();
                    }
                }
                return _instance;
            }
        }

        private AssetManager() { }

           



        //此处后面会分目录
        public object LoadPrefab(string name , Type type)
        {
            return Resources.Load(name,type);
        }
    }
}
