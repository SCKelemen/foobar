using System;

namespace Processors {

    public interface IProcessor
    {
        void Process(T item);
    }
}