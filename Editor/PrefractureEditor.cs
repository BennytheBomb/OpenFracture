using OpenFracture.Runtime.Scripts;
using UnityEditor;

namespace OpenFracture.Editor
{
    [CustomEditor(typeof(Prefracture))]
    [CanEditMultipleObjects]
    public class PrefractureEditor : UnityEditor.Editor
    {
        // Empty editor required for custom property drawers to work properly
    }
}
