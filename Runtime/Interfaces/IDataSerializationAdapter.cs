﻿namespace d4160.Systems.DataPersistence
{
    using UnityEngine.GameFoundation.DataPersistence;

    public interface IDataSerializationActions
    {
        ISerializableData GetSerializableData();

        void FillFromSerializableData(ISerializableData data);

        void InitializeData(ISerializableData data);
    }

    public interface IDataSerializationAdapter : IDataSerializationActions
    {
        void Initialize(
            string saveDataPathFull,
            IDataPersistence dataPersistence,
            System.Action onInitializeCompleted = null,
            System.Action onInitializeFailed = null);

        void Uninitialize();

        void Load(
            IDataPersistence dataPersistence,
            System.Action onLoadCompleted = null,
            System.Action onLoadFailed = null);

        void Save(
            IDataPersistence dataPersistence,
            System.Action onSaveCompleted = null,
            System.Action onSaveFailed = null);
    }
}