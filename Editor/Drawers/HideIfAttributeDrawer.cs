using UnityEditor;
using UnityEngine;

namespace PixelSparkStudio.Inspector
{
    [CustomPropertyDrawer(typeof(HideIfAttribute))]
    public class HideIfAttributeDrawer : ConditionalAttributeDrawer
    {
        protected override PropertyDrawing GetPropertyDrawing()
        {
            return PropertyDrawing.Hide;
        }
    }
}