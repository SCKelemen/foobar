using System;

namespace Processors {

    public interface IProcessor<T>
    {
        void Process(ref T item);
    }
}