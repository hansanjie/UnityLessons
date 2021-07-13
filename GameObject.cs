using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security;
using UnityEngine.Bindings;
using UnityEngine.Internal;
using UnityEngine.SceneManagement;
using UnityEngine.Scripting;
using UnityEngineInternal;

namespace UnityEngine
{
    //
    // 摘要:
    //     Base class for all entities in Unity Scenes.
    [ExcludeFromPreset]
    [NativeHeader("Runtime/Export/GameObject.bindings.h")]
    [UsedByNativeCode]
    public sealed class GameObject : Object
    {
        
        public GameObject();
        //
        // 摘要:
        //     通过名称新建一个游戏物体.
        public GameObject(string name);
        //
        // 摘要:
        //     通过名称和组件列表新建游戏物体.
        public GameObject(string name, params Type[] components);

        //
        // 摘要:
        //     游戏物体所在的层.
        public int layer { get; set; }
        [Obsolete("GameObject.active is obsolete. Use GameObject.SetActive(), GameObject.activeSelf or GameObject.activeInHierarchy.")]
        public bool active { get; set; }
        //
        // 摘要:
        //     该游戏物体在inspector上是否激活
        public bool activeSelf { get; }
        //
        // 摘要:
        //     该游戏物体在场景中是否激活.
        public bool activeInHierarchy { get; }
        //
        // 摘要:
        //     Editor only API that specifies if a game object is static.
        public bool isStatic { get; set; }
        //
        // 摘要:
        //     该游戏物体的标签.
        public string tag { get; set; }
        //
        // 摘要:
        //     该游戏物体是否是scene的一部分.
        public Scene scene { get; }
        public GameObject gameObject { get; }
        //
        // 摘要:
        //     The Rigidbody attached to this GameObject (Read Only). (Null if there is none
        //     attached).
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Property rigidbody has been deprecated. Use GetComponent<Rigidbody>() instead. (UnityUpgradable)", true)]
        public Component rigidbody { get; }
        //
        // 摘要:
        //     The Rigidbody2D component attached to this GameObject. (Read Only)
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Property rigidbody2D has been deprecated. Use GetComponent<Rigidbody2D>() instead. (UnityUpgradable)", true)]
        public Component rigidbody2D { get; }
        //
        // 摘要:
        //     The Camera attached to this GameObject (Read Only). (Null if there is none attached).
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Property camera has been deprecated. Use GetComponent<Camera>() instead. (UnityUpgradable)", true)]
        public Component camera { get; }
        //
        // 摘要:
        //     The Light attached to this GameObject (Read Only). (Null if there is none attached).
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Property light has been deprecated. Use GetComponent<Light>() instead. (UnityUpgradable)", true)]
        public Component light { get; }
        //
        // 摘要:
        //     The Animation attached to this GameObject (Read Only). (Null if there is none
        //     attached).
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Property animation has been deprecated. Use GetComponent<Animation>() instead. (UnityUpgradable)", true)]
        public Component animation { get; }
        //
        // 摘要:
        //     The ConstantForce attached to this GameObject (Read Only). (Null if there is
        //     none attached).
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Property constantForce has been deprecated. Use GetComponent<ConstantForce>() instead. (UnityUpgradable)", true)]
        public Component constantForce { get; }
        //
        // 摘要:
        //     The Renderer attached to this GameObject (Read Only). (Null if there is none
        //     attached).
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Property renderer has been deprecated. Use GetComponent<Renderer>() instead. (UnityUpgradable)", true)]
        public Component renderer { get; }
        //
        // 摘要:
        //     The AudioSource attached to this GameObject (Read Only). (Null if there is none
        //     attached).
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Property audio has been deprecated. Use GetComponent<AudioSource>() instead. (UnityUpgradable)", true)]
        public Component audio { get; }
        //
        // 摘要:
        //     The GUIText attached to this GameObject (Read Only). (Null if there is none attached).
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Property guiText has been deprecated. Use GetComponent<GUIText>() instead. (UnityUpgradable)", true)]
        public Component guiText { get; }
        //
        // 摘要:
        //     The NetworkView attached to this GameObject (Read Only). (Null if there is none
        //     attached).
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Property networkView has been deprecated. Use GetComponent<NetworkView>() instead. (UnityUpgradable)", true)]
        public Component networkView { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Property guiElement has been deprecated. Use GetComponent<GUIElement>() instead. (UnityUpgradable)", true)]
        public Component guiElement { get; }
        //
        // 摘要:
        //     The GUITexture attached to this GameObject (Read Only). (Null if there is none
        //     attached).
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Property guiTexture has been deprecated. Use GetComponent<GUITexture>() instead. (UnityUpgradable)", true)]
        public Component guiTexture { get; }
        //
        // 摘要:
        //     The Collider attached to this GameObject (Read Only). (Null if there is none
        //     attached).
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Property collider has been deprecated. Use GetComponent<Collider>() instead. (UnityUpgradable)", true)]
        public Component collider { get; }
        //
        // 摘要:
        //     The Collider2D component attached to this object.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Property collider2D has been deprecated. Use GetComponent<Collider2D>() instead. (UnityUpgradable)", true)]
        public Component collider2D { get; }
        //
        // 摘要:
        //     The Transform attached to this GameObject.
        public Transform transform { get; }
        //
        // 摘要:
        //     The HingeJoint attached to this GameObject (Read Only). (Null if there is none
        //     attached).
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Property hingeJoint has been deprecated. Use GetComponent<HingeJoint>() instead. (UnityUpgradable)", true)]
        public Component hingeJoint { get; }
        //
        // 摘要:
        //     The ParticleSystem attached to this GameObject (Read Only). (Null if there is
        //     none attached).
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Property particleSystem has been deprecated. Use GetComponent<ParticleSystem>() instead. (UnityUpgradable)", true)]
        public Component particleSystem { get; }

        //
        // 摘要:
        //   创建基础的游戏物体，并且该游戏物体有碰撞体组件
        [FreeFunction("GameObjectBindings::CreatePrimitive")]
        public static GameObject CreatePrimitive(PrimitiveType type);
        //
        // 摘要:
        //     通过游戏物体的名称查找游戏物体
        [FreeFunction(Name = "GameObjectBindings::Find")]
        public static GameObject Find(string name);
        //
        // 摘要:
        //     通过标签查找含有此标签的所有的游戏物体
        [FreeFunction(Name = "GameObjectBindings::FindGameObjectsWithTag", ThrowsException = true)]
        public static GameObject[] FindGameObjectsWithTag(string tag);
        [FreeFunction(Name = "GameObjectBindings::FindGameObjectWithTag", ThrowsException = true)]
        public static GameObject FindGameObjectWithTag(string tag);
        //
        // 摘要:
        //     通过标签查找并返回一个含有该标签的物体
        public static GameObject FindWithTag(string tag);
        public T AddComponent<T>() where T : Component;
        //
        // 摘要:
        //     根据组件的类型给游戏物体添加标签
        [TypeInferenceRule(TypeInferenceRules.TypeReferencedByFirstArgument)]
        public Component AddComponent(Type componentType);
        //
        // 摘要:
        //     Adds a component class named className to the game object.
        //
        // 参数:
        //   className:
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("GameObject.AddComponent with string argument has been deprecated. Use GameObject.AddComponent<T>() instead. (UnityUpgradable).", true)]
        public Component AddComponent(string className);
        //
        // 摘要:
        //     Calls the method named methodName on every MonoBehaviour in this game object
        //     or any of its children.
        //
        // 参数:
        //   methodName:
        //
        //   parameter:
        //
        //   options:
        [ExcludeFromDocs]
        public void BroadcastMessage(string methodName);
        //
        // 摘要:
        //     Calls the method named methodName on every MonoBehaviour in this game object
        //     or any of its children.
        //
        // 参数:
        //   methodName:
        //
        //   parameter:
        //
        //   options:
        [FreeFunction(Name = "Scripting::BroadcastScriptingMessage", HasExplicitThis = true)]
        public void BroadcastMessage(string methodName, [Internal.DefaultValue("null")] object parameter, [Internal.DefaultValue("SendMessageOptions.RequireReceiver")] SendMessageOptions options);
        //
        // 摘要:
        //     Calls the method named methodName on every MonoBehaviour in this game object
        //     or any of its children.
        //
        // 参数:
        //   methodName:
        //
        //   parameter:
        //
        //   options:
        [ExcludeFromDocs]
        public void BroadcastMessage(string methodName, object parameter);
        //
        // 参数:
        //   methodName:
        //
        //   options:
        public void BroadcastMessage(string methodName, SendMessageOptions options);
        //
        // 摘要:
        //     Is this game object tagged with tag ?
        //
        // 参数:
        //   tag:
        //     The tag to compare.
        [FreeFunction(Name = "GameObjectBindings::CompareTag", HasExplicitThis = true)]
        public bool CompareTag(string tag);
        [SecuritySafeCritical]
        public T GetComponent<T>();
        //
        // 摘要:
        //     Returns the component with name type if the game object has one attached, null
        //     if it doesn't.
        //
        // 参数:
        //   type:
        //     The type of Component to retrieve.
        public Component GetComponent(string type);
        //
        // 摘要:
        //     Returns the component of Type type if the game object has one attached, null
        //     if it doesn't.
        //
        // 参数:
        //   type:
        //     The type of Component to retrieve.
        [FreeFunction(Name = "GameObjectBindings::GetComponentFromType", HasExplicitThis = true, ThrowsException = true)]
        [TypeInferenceRule(TypeInferenceRules.TypeReferencedByFirstArgument)]
        public Component GetComponent(Type type);
        //
        // 摘要:
        //     Returns the component of Type type in the GameObject or any of its children using
        //     depth first search.
        //
        // 参数:
        //   type:
        //     The type of Component to retrieve.
        //
        //   includeInactive:
        //
        // 返回结果:
        //     A component of the matching type, if found.
        [FreeFunction(Name = "GameObjectBindings::GetComponentInChildren", HasExplicitThis = true, ThrowsException = true)]
        [TypeInferenceRule(TypeInferenceRules.TypeReferencedByFirstArgument)]
        public Component GetComponentInChildren(Type type, bool includeInactive);
        //
        // 摘要:
        //     Returns the component of Type type in the GameObject or any of its children using
        //     depth first search.
        //
        // 参数:
        //   type:
        //     The type of Component to retrieve.
        //
        //   includeInactive:
        //
        // 返回结果:
        //     A component of the matching type, if found.
        [TypeInferenceRule(TypeInferenceRules.TypeReferencedByFirstArgument)]
        public Component GetComponentInChildren(Type type);
        [ExcludeFromDocs]
        public T GetComponentInChildren<T>();
        public T GetComponentInChildren<T>([Internal.DefaultValue("false")] bool includeInactive);
        //
        // 摘要:
        //     Returns the component of Type type in the GameObject or any of its parents.
        //
        // 参数:
        //   type:
        //     Type of component to find.
        [FreeFunction(Name = "GameObjectBindings::GetComponentInParent", HasExplicitThis = true, ThrowsException = true)]
        [TypeInferenceRule(TypeInferenceRules.TypeReferencedByFirstArgument)]
        public Component GetComponentInParent(Type type);
        public T GetComponentInParent<T>();
        public void GetComponents<T>(List<T> results);
        public T[] GetComponents<T>();
        //
        // 摘要:
        //     Returns all components of Type type in the GameObject.
        //
        // 参数:
        //   type:
        //     The type of Component to retrieve.
        public Component[] GetComponents(Type type);
        public void GetComponents(Type type, List<Component> results);
        //
        // 摘要:
        //     Returns all components of Type type in the GameObject or any of its children.
        //
        // 参数:
        //   type:
        //     The type of Component to retrieve.
        //
        //   includeInactive:
        //     Should Components on inactive GameObjects be included in the found set?
        [ExcludeFromDocs]
        public Component[] GetComponentsInChildren(Type type);
        //
        // 摘要:
        //     Returns all components of Type type in the GameObject or any of its children.
        //
        // 参数:
        //   type:
        //     The type of Component to retrieve.
        //
        //   includeInactive:
        //     Should Components on inactive GameObjects be included in the found set?
        public Component[] GetComponentsInChildren(Type type, [Internal.DefaultValue("false")] bool includeInactive);
        public void GetComponentsInChildren<T>(bool includeInactive, List<T> results);
        public void GetComponentsInChildren<T>(List<T> results);
        public T[] GetComponentsInChildren<T>();
        public T[] GetComponentsInChildren<T>(bool includeInactive);
        [ExcludeFromDocs]
        public Component[] GetComponentsInParent(Type type);
        public void GetComponentsInParent<T>(bool includeInactive, List<T> results);
        public T[] GetComponentsInParent<T>();
        //
        // 摘要:
        //     Returns all components of Type type in the GameObject or any of its parents.
        //
        // 参数:
        //   type:
        //     The type of Component to retrieve.
        //
        //   includeInactive:
        //     Should inactive Components be included in the found set?
        public Component[] GetComponentsInParent(Type type, [Internal.DefaultValue("false")] bool includeInactive);
        public T[] GetComponentsInParent<T>(bool includeInactive);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("gameObject.PlayAnimation is not supported anymore. Use animation.Play()", true)]
        public void PlayAnimation(Object animation);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("GameObject.SampleAnimation(AnimationClip, float) has been deprecated. Use AnimationClip.SampleAnimation(GameObject, float) instead (UnityUpgradable).", true)]
        public void SampleAnimation(Object clip, float time);
        //
        // 参数:
        //   methodName:
        //
        //   options:
        public void SendMessage(string methodName, SendMessageOptions options);
        //
        // 摘要:
        //     Calls the method named methodName on every MonoBehaviour in this game object.
        //
        // 参数:
        //   methodName:
        //     The name of the method to call.
        //
        //   value:
        //     An optional parameter value to pass to the called method.
        //
        //   options:
        //     Should an error be raised if the method doesn't exist on the target object?
        [ExcludeFromDocs]
        public void SendMessage(string methodName);
        //
        // 摘要:
        //     Calls the method named methodName on every MonoBehaviour in this game object.
        //
        // 参数:
        //   methodName:
        //     The name of the method to call.
        //
        //   value:
        //     An optional parameter value to pass to the called method.
        //
        //   options:
        //     Should an error be raised if the method doesn't exist on the target object?
        [ExcludeFromDocs]
        public void SendMessage(string methodName, object value);
        //
        // 摘要:
        //     Calls the method named methodName on every MonoBehaviour in this game object.
        //
        // 参数:
        //   methodName:
        //     The name of the method to call.
        //
        //   value:
        //     An optional parameter value to pass to the called method.
        //
        //   options:
        //     Should an error be raised if the method doesn't exist on the target object?
        [FreeFunction(Name = "Scripting::SendScriptingMessage", HasExplicitThis = true)]
        public void SendMessage(string methodName, [Internal.DefaultValue("null")] object value, [Internal.DefaultValue("SendMessageOptions.RequireReceiver")] SendMessageOptions options);
        //
        // 参数:
        //   methodName:
        //
        //   options:
        public void SendMessageUpwards(string methodName, SendMessageOptions options);
        //
        // 摘要:
        //     Calls the method named methodName on every MonoBehaviour in this game object
        //     and on every ancestor of the behaviour.
        //
        // 参数:
        //   methodName:
        //     The name of the method to call.
        //
        //   value:
        //     An optional parameter value to pass to the called method.
        //
        //   options:
        //     Should an error be raised if the method doesn't exist on the target object?
        [ExcludeFromDocs]
        public void SendMessageUpwards(string methodName);
        //
        // 摘要:
        //     Calls the method named methodName on every MonoBehaviour in this game object
        //     and on every ancestor of the behaviour.
        //
        // 参数:
        //   methodName:
        //     The name of the method to call.
        //
        //   value:
        //     An optional parameter value to pass to the called method.
        //
        //   options:
        //     Should an error be raised if the method doesn't exist on the target object?
        [ExcludeFromDocs]
        public void SendMessageUpwards(string methodName, object value);
        //
        // 摘要:
        //     Calls the method named methodName on every MonoBehaviour in this game object
        //     and on every ancestor of the behaviour.
        //
        // 参数:
        //   methodName:
        //     The name of the method to call.
        //
        //   value:
        //     An optional parameter value to pass to the called method.
        //
        //   options:
        //     Should an error be raised if the method doesn't exist on the target object?
        [FreeFunction(Name = "Scripting::SendScriptingMessageUpwards", HasExplicitThis = true)]
        public void SendMessageUpwards(string methodName, [Internal.DefaultValue("null")] object value, [Internal.DefaultValue("SendMessageOptions.RequireReceiver")] SendMessageOptions options);
        //
        // 摘要:
        //     ActivatesDeactivates the GameObject, depending on the given true or false/ value.
        //
        // 参数:
        //   value:
        //     Activate or deactivate the object, where true activates the GameObject and false
        //     deactivates the GameObject.
        [NativeMethod(Name = "SetSelfActive")]
        public void SetActive(bool value);
        [NativeMethod(Name = "SetActiveRecursivelyDeprecated")]
        [Obsolete("gameObject.SetActiveRecursively() is obsolete. Use GameObject.SetActive(), which is now inherited by children.")]
        public void SetActiveRecursively(bool state);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("gameObject.StopAnimation is not supported anymore. Use animation.Stop()", true)]
        public void StopAnimation();
    }
}
