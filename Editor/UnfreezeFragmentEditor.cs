using OpenFracture.Runtime.Scripts.Fragment;
using UnityEditor;

namespace OpenFracture.Editor
{
    [CustomEditor(typeof(UnfreezeFragment))]
    [CanEditMultipleObjects]
    public class UnfreezeFragmentEditor : UnityEditor.Editor
    {
        // Empty editor required for custom property drawers to work properly
    }
}
