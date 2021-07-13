using System;
using UnityEngine.Bindings;
using UnityEngine.Internal;

namespace UnityEngine
{
    //
    // 摘要:
    //     Control of an object's position through physics simulation.
    [NativeHeader("Modules/Physics/Rigidbody.h")]
    [RequireComponent(typeof(Transform))]
    public class Rigidbody : Component
    {
        //刚体
        public Rigidbody();
        // 摘要:
        //     The solverVelocityIterations affects how how accurately Rigidbody joints and
        //     collision contacts are resolved. Overrides Physics.defaultSolverVelocityIterations.
        //     Must be positive.
        public int solverVelocityIterations { get; set; }
        //
        // 摘要:
        //     测量的刚体的最大角速度。
        public float maxAngularVelocity { get; set; }
        //
        // 摘要:
        //     能量阈值，低于该阈值对象开始进入睡眠状态。.
        public float sleepThreshold { get; set; }
        //
        // 摘要:
        //     The solverIterations determines how accurately Rigidbody joints and collision
        //     contacts are resolved. Overrides Physics.defaultSolverIterations. Must be positive.
        public int solverIterations { get; set; }
        //
        // 摘要:
        //     Interpolation allows you to smooth out the effect of running physics at a fixed
        //     frame rate.
        public RigidbodyInterpolation interpolation { get; set; }
        //
        // 摘要:
        //     刚体的速度向量，它代表刚体的变化率
        public Vector3 velocity { get; set; }
        //
        // 摘要:
        //     以弧度为单位测量的刚体的角速度矢量。
        public Vector3 angularVelocity { get; set; }
        //
        // 摘要:
        //     物体的拖动力量.
        public float drag { get; set; }
        //
        // 摘要:
        //     物体角度的拖动力.
        public float angularDrag { get; set; }
        // 摘要:
        //     刚体的质量。
        public float mass { get; set; }
        //
        // 摘要:
        //    刚体脱离穿透状态时的最大速度。
        public float maxDepenetrationVelocity { get; set; }
        //
        // 摘要:
        //     控制物理是否影响刚体。
        public bool isKinematic { get; set; }
        //
        // 摘要:
        //     控制物理是否会改变对象的旋转。
        public bool freezeRotation { get; set; }
        //
        // 摘要:
        //      控制允许模拟此刚体的自由度。.
        public RigidbodyConstraints constraints { get; set; }
        //
        // 摘要:
        //    Rigidbody 的碰撞检测模式。
        public CollisionDetectionMode collisionDetectionMode { get; set; }
        //
        // 摘要:
        //     相对于变换原点的质心.
        public Vector3 centerOfMass { get; set; }
        //
        // 摘要:
        //     刚体在世界空间中的质心（只读）。
        public Vector3 worldCenterOfMass { get; }
        //
        // 摘要:
        //     惯性张量的旋转。
        public Quaternion inertiaTensorRotation { get; set; }
        //
        // 摘要:
        //     质量相对于质心的对角惯性张量。
        public Vector3 inertiaTensor { get; set; }
        //
        // 摘要:
        //     是否应该启用碰撞检测？（默认情况下始终启用）。
        public bool detectCollisions { get; set; }
        //
        // 摘要:
        //     控制重力是否影响这个刚体。
        public bool useGravity { get; set; }
        //
        // 摘要:
        //    刚体的位置。
        public Vector3 position { get; set; }
        //
        // 摘要:
        //     刚体的旋转。
        public Quaternion rotation { get; set; }        
        // 摘要:
        //对模拟爆炸效果的刚体施加力。
        public void AddExplosionForce(float explosionForce, Vector3 explosionPosition, float explosionRadius, [DefaultValue("0.0f")] float upwardsModifier, [DefaultValue("ForceMode.Force)")] ForceMode mode);
        //
        // 摘要:
        //     对模拟爆炸效果的刚体施加力。.
        [ExcludeFromDocs]
        public void AddExplosionForce(float explosionForce, Vector3 explosionPosition, float explosionRadius, float upwardsModifier);
        //
        // 摘要:
        //     对模拟爆炸效果的刚体施加力。
        [ExcludeFromDocs]
        public void AddExplosionForce(float explosionForce, Vector3 explosionPosition, float explosionRadius);
        //
        // 摘要:
        //     向刚体添加一个力。
        public void AddForce(Vector3 force, [DefaultValue("ForceMode.Force")] ForceMode mode);
        //
        // 摘要:
        //     向刚体添加一个力
        [ExcludeFromDocs]
        public void AddForce(Vector3 force);
        //
        // 摘要:
        //      向刚体添加一个力。
        public void AddForce(float x, float y, float z, [DefaultValue("ForceMode.Force")] ForceMode mode);
        //
        // 摘要:
        //     向刚体添加一个力。
        [ExcludeFromDocs]
        public void AddForce(float x, float y, float z);
        //
        // 摘要:
        //     在位置施加力。结果，这将施加扭矩和力
        [ExcludeFromDocs]
        public void AddForceAtPosition(Vector3 force, Vector3 position);
        //
        // 摘要:
        //     在位置施加力。结果，这将施加扭矩和力
        public void AddForceAtPosition(Vector3 force, Vector3 position, [DefaultValue("ForceMode.Force")] ForceMode mode);
        //
        // 摘要:
        //     相对于其坐标系向刚体添加一个力。
        [ExcludeFromDocs]
        public void AddRelativeForce(Vector3 force);
        //
        // 摘要:
        //     相对于其坐标系向刚体添加一个力。
        public void AddRelativeForce(Vector3 force, [DefaultValue("ForceMode.Force")] ForceMode mode);
        //
        // 摘要:
        //     相对于其坐标系向刚体添加一个力。
        [ExcludeFromDocs]
        public void AddRelativeForce(float x, float y, float z);
        //
        // 摘要:
        //     相对于其坐标系向刚体添加一个力。
        public void AddRelativeForce(float x, float y, float z, [DefaultValue("ForceMode.Force")] ForceMode mode);
        //
        // 摘要:
        //     相对于其坐标系向刚体添加扭矩。
        [ExcludeFromDocs]
        public void AddRelativeTorque(Vector3 torque);
        //
        // 摘要:
        //     相对于其坐标系向刚体添加扭矩。
        public void AddRelativeTorque(Vector3 torque, [DefaultValue("ForceMode.Force")] ForceMode mode);
        //
        // 摘要:
        //     相对于其坐标系向刚体添加扭矩。
        [ExcludeFromDocs]
        public void AddRelativeTorque(float x, float y, float z);
        //
        // 摘要:
        //     相对于其坐标系向刚体添加扭矩。
        public void AddRelativeTorque(float x, float y, float z, [DefaultValue("ForceMode.Force")] ForceMode mode);
        //
        // 摘要:
        //     向刚体添加扭矩。
        [ExcludeFromDocs]
        public void AddTorque(float x, float y, float z);
        //
        // 摘要:
        //     向刚体添加扭矩。
        [ExcludeFromDocs]
        public void AddTorque(Vector3 torque);
        //
        // 摘要:
        //     向刚体添加扭矩。
        public void AddTorque(Vector3 torque, [DefaultValue("ForceMode.Force")] ForceMode mode);
        //
        // 摘要:
        //    向刚体添加扭矩。
        public void AddTorque(float x, float y, float z, [DefaultValue("ForceMode.Force")] ForceMode mode);
        //
        // 摘要:
        //     距离附加碰撞器的边界框最近的点。
        public Vector3 ClosestPointOnBounds(Vector3 position);
        //
        // 摘要:
        //     刚体在全局空间中的点 worldPoint 处的速度。
        public Vector3 GetPointVelocity(Vector3 worldPoint);
        //
        // 摘要:
        //     在点relativePoint 处相对于刚体的速度。
        public Vector3 GetRelativePointVelocity(Vector3 relativePoint);
        //
        // 摘要:
        //     刚体在休眠
        public bool IsSleeping();
        //
        // 摘要:
        //     Moves the kinematic Rigidbody towards position.
        //
        // 参数:
        //   position:
        //     Provides the new position for the Rigidbody object.
        public void MovePosition(Vector3 position);
        //
        // 摘要:
        //     Rotates the rigidbody to rotation.
        //
        // 参数:
        //   rot:
        //     The new rotation for the Rigidbody.
        public void MoveRotation(Quaternion rot);
        //
        // 摘要:
        //     Reset the center of mass of the rigidbody.
        public void ResetCenterOfMass();
        //
        // 摘要:
        //     Reset the inertia tensor value and rotation.
        public void ResetInertiaTensor();
        //
        // 摘要:
        //     Sets the mass based on the attached colliders assuming a constant density.
        //
        // 参数:
        //   density:
        public void SetDensity(float density);
        [Obsolete("Use Rigidbody.maxAngularVelocity instead.")]
        public void SetMaxAngularVelocity(float a);
        //
        // 摘要:
        //     Forces a rigidbody to sleep at least one frame.
        public void Sleep();
        [ExcludeFromDocs]
        public bool SweepTest(Vector3 direction, out RaycastHit hitInfo);
        [ExcludeFromDocs]
        public bool SweepTest(Vector3 direction, out RaycastHit hitInfo, float maxDistance);
        public bool SweepTest(Vector3 direction, out RaycastHit hitInfo, [DefaultValue("Mathf.Infinity")] float maxDistance, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction);
        [ExcludeFromDocs]
        public RaycastHit[] SweepTestAll(Vector3 direction, float maxDistance);
        //
        // 摘要:
        //     Like Rigidbody.SweepTest, but returns all hits.
        //
        // 参数:
        //   direction:
        //     The direction into which to sweep the rigidbody.
        //
        //   maxDistance:
        //     The length of the sweep.
        //
        //   queryTriggerInteraction:
        //     Specifies whether this query should hit Triggers.
        //
        // 返回结果:
        //     An array of all colliders hit in the sweep.
        public RaycastHit[] SweepTestAll(Vector3 direction, [DefaultValue("Mathf.Infinity")] float maxDistance, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction);
        [ExcludeFromDocs]
        public RaycastHit[] SweepTestAll(Vector3 direction);
        //
        // 摘要:
        //     Forces a rigidbody to wake up.
        public void WakeUp();
    }
}
