using OpenFracture.Runtime.Scripts;
using UnityEditor;

namespace OpenFracture.Editor
{
    [CustomEditor(typeof(Fracture))]
    [CanEditMultipleObjects]
    public class FractureEditor : UnityEditor.Editor
    {
        // Empty editor required for custom property drawers to work properly
    }
}
