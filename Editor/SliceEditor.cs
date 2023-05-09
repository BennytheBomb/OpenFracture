using OpenFracture.Runtime.Scripts;
using UnityEditor;

namespace OpenFracture.Editor
{
    [CustomEditor(typeof(Slice))]
    [CanEditMultipleObjects]
    public class SliceEditor : UnityEditor.Editor
    {
        // Empty editor required for custom property drawers to work properly
    }
}
