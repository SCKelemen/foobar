using System;

namespace Work {
    // abstract class UnitofWork {
    //     void registerNew(object obj);
    // }

    interface IUnitofWork
    {
        void registerNew(object obj);
        void registerDirty(object obj);
        void registerClean(object obj);
        void registerDeleted(object obj);
        void commit();
        void rollback();

    }
}