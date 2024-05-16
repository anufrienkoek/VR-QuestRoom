using CodeBase.Data;
using CodeBase.Infrastructure.Services.PersistentProgress;
using CodeBase.Services.PersistentProgress;
using UnityEngine.SceneManagement;
using UnityEngine.XR.Interaction.Toolkit.Locomotion;

namespace CodeBase.Hero
{
    public class HeroMove : XRBodyTransformer, ISavedProgress
    {
        public void UpdateProgress(PlayerProgress progress) => 
            progress.WorldData.PositionOnLevel = new PositionOnLevel(CurrentLevel(), transform.position.AsVectorData());

        public void LoadProgress(PlayerProgress progress)
        {
            if (CurrentLevel() == progress.WorldData.PositionOnLevel.Level)
            {
                var savedPosition = progress.WorldData.PositionOnLevel.Position;
                
                if(savedPosition != null) 
                    Warp(to: savedPosition);
            }
        }

        private void Warp(Vector3Data to)
        {
            useCharacterControllerIfExists = false;
            transform.position = to.AsUnityVector();
            useCharacterControllerIfExists = true;
        }

        private static string CurrentLevel() => 
            SceneManager.GetActiveScene().name;
    }
}