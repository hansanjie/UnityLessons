using System;
using System.Collections;
using UnityEngine.Bindings;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine
{
    //
    // 摘要:
    //     Position, rotation and scale of an object.
    [NativeHeader("Configuration/UnityConfigure.h")]
    [NativeHeader("Runtime/Transform/Transform.h")]
    [NativeHeader("Runtime/Transform/ScriptBindings/TransformScriptBindings.h")]
    [RequiredByNativeCode]
    public class Transform : Component, IEnumerable
    {
        protected Transform();

        //
        // 摘要:
        // 该物体相对于父物体为坐标原点相对应的坐标
        public Vector3 localPosition { get; set; }
        //
        // 摘要:
        //     该物体在世界坐标系中的旋转角度.
        public Vector3 eulerAngles { get; set; }
        //
        // 摘要:
        // 该物体相对于父物体为坐标原点相对应的坐标.
        public Vector3 localEulerAngles { get; set; }
        //
        // 摘要:
        //     在世界坐标系中红色坐标轴所对应的方向.
        public Vector3 right { get; set; }
        //
        // 摘要:
        //     在世界坐标系中绿色轴所对应的方向
        public Vector3 up { get; set; }
        //
        // 摘要:
        //     在世界坐标系中蓝色轴所对应的方向
        public Vector3 forward { get; set; }
        //
        // 摘要:
        //   该物体在世界坐标系中旋转所对应的四元数.
        public Quaternion rotation { get; set; }
        //
        // 摘要:
        //    该物体在世界坐标系中的坐标.
        public Vector3 position { get; set; }
        //
        // 摘要:
        //     该物体在父物体坐标系旋转所对应的四元数.
        public Quaternion localRotation { get; set; }
        //
        // 摘要:
        //     该物体的父物体的Transform.
        public Transform parent { get; set; }
        //
        // 摘要:
        //     Matrix that transforms a point from world space into local space (Read Only).
        public Matrix4x4 worldToLocalMatrix { get; }
        //
        // 摘要:
        //     Matrix that transforms a point from local space into world space (Read Only).
        public Matrix4x4 localToWorldMatrix { get; }
        //
        // 摘要:
        //     获得Herachy面板中该物体最上层的物体的Transform.
        public Transform root { get; }
        //
        // 摘要:
        //     获得该物体子物体的数量.
        public int childCount { get; }
        //
        // 摘要:
        //     获得该物体在世界坐标系中的缩放值(只读).
        public Vector3 lossyScale { get; }
        //
        // 摘要:
        //     Has the transform changed since the last time the flag was set to 'false'?
        [NativeProperty("HasChangedDeprecated")]
        public bool hasChanged { get; set; }
        //
        // 摘要:
        //     该物体对应父物体坐标系的缩放值.
        public Vector3 localScale { get; set; }
        //
        // 摘要:
        //     The transform capacity of the transform's hierarchy data structure.
        public int hierarchyCapacity { get; set; }
        //
        // 摘要:
        //     The number of transforms in the transform's hierarchy data structure.
        public int hierarchyCount { get; }

        //
        // 摘要:
        //     解除子物体的父子关系.
        [FreeFunction("DetachChildren", HasExplicitThis = true)]
        public void DetachChildren();
        //
        // 摘要:
        //     Finds a child by n and returns it.
        //
        // 参数:
        //   n:
        //     Name of child to be found.
        //
        // 返回结果:
        //     通过名称查找Hierarchy面板中Transform
        public Transform Find(string n);
        [Obsolete("FindChild has been deprecated. Use Find instead (UnityUpgradable) -> Find([mscorlib] System.String)", false)]
        public Transform FindChild(string n);
        //
        // 摘要:
        //     Returns a transform child by index.
        //
        // 参数:
        //   index:
        //     Index of the child transform to return. Must be smaller than Transform.childCount.
        //
        // 返回结果:
        //     通过子物体的序号获得该子物体.
        [FreeFunction("GetChild", HasExplicitThis = true)]
        [NativeThrows]
        public Transform GetChild(int index);
        [NativeMethod("GetChildrenCount")]
        [Obsolete("warning use Transform.childCount instead (UnityUpgradable) -> Transform.childCount", false)]
        public int GetChildCount();
        public IEnumerator GetEnumerator();
        //
        // 摘要:
        //获得该物体在父物体中的子物体序列的序号.
        public int GetSiblingIndex();
        //
        // 摘要:
        //     Transforms a direction from world space to local space. The opposite of Transform.TransformDirection.
        //
        // 参数:
        //   direction:
        public Vector3 InverseTransformDirection(Vector3 direction);
        //
        // 摘要:
        //     Transforms the direction x, y, z from world space to local space. The opposite
        //     of Transform.TransformDirection.
        //
        // 参数:
        //   x:
        //
        //   y:
        //
        //   z:
        public Vector3 InverseTransformDirection(float x, float y, float z);
        //
        // 摘要:
        //     Transforms the position x, y, z from world space to local space. The opposite
        //     of Transform.TransformPoint.
        //
        // 参数:
        //   x:
        //
        //   y:
        //
        //   z:
        public Vector3 InverseTransformPoint(float x, float y, float z);
        //
        // 摘要:
        //     Transforms position from world space to local space.
        //
        // 参数:
        //   position:
        public Vector3 InverseTransformPoint(Vector3 position);
        //
        // 摘要:
        //     Transforms a vector from world space to local space. The opposite of Transform.TransformVector.
        //
        // 参数:
        //   vector:
        public Vector3 InverseTransformVector(Vector3 vector);
        //
        // 摘要:
        //     Transforms the vector x, y, z from world space to local space. The opposite of
        //     Transform.TransformVector.
        //
        // 参数:
        //   x:
        //
        //   y:
        //
        //   z:
        public Vector3 InverseTransformVector(float x, float y, float z);
        //
        // 摘要:
        //     Is this transform a child of parent?
        //
        // 参数:
        //   parent:
        [FreeFunction("Internal_IsChildOrSameTransform", HasExplicitThis = true)]
        public bool IsChildOf([NotNull] Transform parent);
        //
        // 摘要:
        //     Rotates the transform so the forward vector points at target's current position.
        //
        // 参数:
        //   target:
        //     Object to point towards.
        //
        //   worldUp:
        //     通过旋转，物体的蓝色坐标轴指向某个物体.
        public void LookAt(Transform target, [DefaultValue("Vector3.up")] Vector3 worldUp);
        //
        // 摘要:
        //     Rotates the transform so the forward vector points at worldPosition.
        //
        // 参数:
        //   worldPosition:
        //     Point to look at.
        //
        //   worldUp:
        //     Vector specifying the upward direction.
        public void LookAt(Vector3 worldPosition, [DefaultValue("Vector3.up")] Vector3 worldUp);
        //
        // 摘要:
        //     Rotates the transform so the forward vector points at worldPosition.
        //
        // 参数:
        //   worldPosition:
        //     Point to look at.
        //
        //   worldUp:
        //     Vector specifying the upward direction.
        public void LookAt(Vector3 worldPosition);
        //
        // 摘要:
        //     Rotates the transform so the forward vector points at target's current position.
        //
        // 参数:
        //   target:
        //     Object to point towards.
        //
        //   worldUp:
        //     Vector specifying the upward direction.
        public void LookAt(Transform target);
        //相对与自身坐标，该物体在三个轴向上旋转某个角度
        public void Rotate(float xAngle, float yAngle, float zAngle);
        //
        // 摘要:
        //     Applies a rotation of eulerAngles.z degrees around the z-axis, eulerAngles.x
        //     degrees around the x-axis, and eulerAngles.y degrees around the y-axis (in that
        //     order).
        //
        // 参数:
        //   eulers:
        //     The rotation to apply.
        //
        //   relativeTo:
        //     Determines whether to rotate the GameObject either locally to the GameObject
        //     or relative to the Scene in world space.
        public void Rotate(Vector3 eulers, [DefaultValue("Space.Self")] Space relativeTo);
        public void Rotate(Vector3 eulers);
        //
        // 摘要:
        //     Applies a rotation of zAngle degrees around the z axis, xAngle degrees around
        //     the x axis, and yAngle degrees around the y axis (in that order).
        //
        // 参数:
        //   relativeTo:
        //     Determines whether to rotate the GameObject either is locally to the GameObject
        //     or relative to the Scene in world space.
        //
        //   xAngle:
        //     Degrees to rotate the GameObject around the X axis.
        //
        //   yAngle:
        //     Degrees to rotate the GameObject around the Y axis.
        //
        //   zAngle:
        //     Degrees to rotate the GameObject around the Z axis.
        public void Rotate(float xAngle, float yAngle, float zAngle, [DefaultValue("Space.Self")] Space relativeTo);
        //
        // 摘要:
        //     Rotates the object around the given axis by the number of degrees defined by
        //     the given angle.
        //
        // 参数:
        //   angle:
        //     The degrees of rotation to apply.
        //
        //   axis:
        //     The axis to apply rotation to.
        //
        //   relativeTo:
        //     Determines whether to rotate the GameObject either locally to the GameObject
        //     or relative to the Scene in world space.
        public void Rotate(Vector3 axis, float angle, [DefaultValue("Space.Self")] Space relativeTo);
        public void Rotate(Vector3 axis, float angle);
        //
        // 摘要:
        //     Rotates the transform about axis passing through point in world coordinates by
        //     angle degrees.
        //
        // 参数:
        //   point:
        //
        //   axis:
        //
        //   angle:
        public void RotateAround(Vector3 point, Vector3 axis, float angle);
        //
        // 参数:
        //   axis:
        //
        //   angle:
        [Obsolete("warning use Transform.Rotate instead.")]
        public void RotateAround(Vector3 axis, float angle);
        [Obsolete("warning use Transform.Rotate instead.")]
        public void RotateAroundLocal(Vector3 axis, float angle);
        //
        // 摘要:
        //     Move the transform to the start of the local transform list.
        public void SetAsFirstSibling();
        //
        // 摘要:
        //     Move the transform to the end of the local transform list.
        public void SetAsLastSibling();
        //
        // 摘要:
        //     Set the parent of the transform.
        //
        // 参数:
        //   parent:
        //     The parent Transform to use.
        //
        //   worldPositionStays:
        //     If true, the parent-relative position, scale and rotation are modified such that
        //     the object keeps the same world space position, rotation and scale as before.
        //
        //  将该物体设为参数p的子物体
        public void SetParent(Transform p);
        //
        // 摘要:
        //     Set the parent of the transform.
        //
        // 参数:
        //   parent:
        //     The parent Transform to use.
        //
        //   worldPositionStays:
        //     If true, the parent-relative position, scale and rotation are modified such that
        //     the object keeps the same world space position, rotation and scale as before.
        //
        //   p:
        [FreeFunction("SetParent", HasExplicitThis = true)]
        public void SetParent(Transform parent, bool worldPositionStays);
        //设置该物体在世界坐标系中的位置和旋转（四元数）
        public void SetPositionAndRotation(Vector3 position, Quaternion rotation);
        //将该物体移动到父物体某个子物体的位置
        public void SetSiblingIndex(int index);
        //
        // 摘要:
        //     Transforms direction x, y, z from local space to world space.
        //
        // 参数:
        //   x:
        //
        //   y:
        //
        //   z:
        public Vector3 TransformDirection(float x, float y, float z);
        //
        // 摘要:
        //     Transforms direction from local space to world space.
        //
        // 参数:
        //   direction:
        public Vector3 TransformDirection(Vector3 direction);
        //
        // 摘要:
        //     将该物体本地坐标的X值，Y值，Z值组成的坐标转化成世界坐标
        public Vector3 TransformPoint(float x, float y, float z);
        //
        // 摘要:
        //     将该物体本地坐标的点转化成世界坐标
        public Vector3 TransformPoint(Vector3 position);
        //
        // 摘要:
        //     Transforms vector x, y, z from local space to world space.
        
        public Vector3 TransformVector(float x, float y, float z);
        //
        // 摘要:
        //     Transforms vector from local space to world space.
        //
        // 参数:
        //   vector:
        public Vector3 TransformVector(Vector3 vector);
        //
        // 摘要:
        //     Moves the transform by x along the x axis, y along the y axis, and z along the
        //     z axis.
        //
        // 参数:
        //   x:
        //
        //   y:
        //
        //   z:
        //
        //   relativeTo:
        public void Translate(float x, float y, float z);
        //
        // 摘要:
        //    通过三个轴向的大小移动相对于物体的距离
        public void Translate(float x, float y, float z, [DefaultValue("Space.Self")] Space relativeTo);
        //
        // 摘要:
        //     相对于某个物体方向上，移动该物体
        public void Translate(Vector3 translation);
        //
        // 摘要:
        //     Moves the transform in the direction and distance of translation.
        //
        // 参数:
        //   translation:
        //
        //   relativeTo:
        public void Translate(Vector3 translation, [DefaultValue("Space.Self")] Space relativeTo);
        //
        // 摘要:
        //     Moves the transform by x along the x axis, y along the y axis, and z along the
        //     z axis.
        //
        // 参数:
        //   x:
        //
        //   y:
        //
        //   z:
        //
        //   relativeTo:
        public void Translate(float x, float y, float z, Transform relativeTo);
        //
        // 摘要:
        //     Moves the transform in the direction and distance of translation.
        //
        // 参数:
        //   translation:
        //
        //   relativeTo:
        public void Translate(Vector3 translation, Transform relativeTo);
    }
}
