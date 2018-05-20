using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigO_Notation.DesignPatterns
{
    public sealed class MySingletonPattern : IDisposable
    {
        //Volatile keyword ensures that instatiation is complete
        //before it can be accesed further helping with thread safety
        private static volatile MySingletonPattern _instance;
        private static object _syncLock = new object();
        private bool _disposed;

        private MySingletonPattern()
        {
        }

        //uses a pattern known as double check locking
        public static MySingletonPattern Instance
        {
            get
            {
                if(_instance != null)
                {
                    return _instance;
                }

                //removed double lock because this is a fixed in C# 6
                lock(_syncLock)
                {
                    if(_instance == null)
                    {
                        _instance = new MySingletonPattern();
                    }
                }

                return _instance;
            }
        }

        public void Dispose()
        {
            Dispose(true);

            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if(_disposed)
            {
                return;
            }

            if(disposing)
            {
                _instance = null;
            }
        }
    }
}
