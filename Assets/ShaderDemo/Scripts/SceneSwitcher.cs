using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.ShaderDemo.Scripts
{
    public class SceneSwitcher : MonoBehaviour
    {
        private readonly KeyCode[] _numKeyCodes = {
            KeyCode.Alpha0,
            KeyCode.Alpha1,
            KeyCode.Alpha2,
            KeyCode.Alpha3,
            KeyCode.Alpha4,
            KeyCode.Alpha5,
            KeyCode.Alpha6,
            KeyCode.Alpha7,
            KeyCode.Alpha8,
            KeyCode.Alpha9,
        };

        private const int KeyCodeZeroToActualZeroOffset = -48;

        public void Update()
        {
            if (Input.anyKeyDown)
            {
                var numKeyDown = _numKeyCodes.FirstOrDefault(Input.GetKeyDown);
                if (numKeyDown != 0)
                {
                    var sceneIndex = (int)numKeyDown + KeyCodeZeroToActualZeroOffset; // horrid enum cast
                    SceneManager.LoadScene(sceneIndex);
                }
            }
        }
    }
}
