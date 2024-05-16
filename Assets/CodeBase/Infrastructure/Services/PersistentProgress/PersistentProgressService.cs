using System.Collections.Generic;
using CodeBase.Data;
using CodeBase.Services.PersistentProgress;

namespace CodeBase.Infrastructure.Services.PersistentProgress
{
    public class PersistentProgressService : IPersistentProgressService
    {
        public PlayerProgress Progress { get; set; }
        public List<ISavedProgressReader> ProgressReaders { get; }
        public List<ISavedProgress> ProgressWriters { get; }
    }
}