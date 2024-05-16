using System.Collections.Generic;
using CodeBase.Infrastructure.Services.PersistentProgress;
using CodeBase.Services.PersistentProgress;

namespace CodeBase.Infrastructure.Services
{
    public interface IService
    {
        List<ISavedProgressReader> ProgressReaders { get; }
        List<ISavedProgress> ProgressWriters { get; }
    }
}