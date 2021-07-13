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
        // 摘要:
        //     The Transform attached to this GameObject.
        public Transform transform { get; }        
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
        //     Calls the method named methodName on every MonoBehaviour in this game object
        //     or any of its children.      
        [ExcludeFromDocs]
        public void BroadcastMessage(string methodName);
        //
        // 摘要:
        //     Calls the method named methodName on every MonoBehaviour in this game object
        //     or any of its children.        
        [FreeFunction(Name = "Scripting::BroadcastScriptingMessage", HasExplicitThis = true)]
        public void BroadcastMessage(string methodName, [Internal.DefaultValue("null")] object parameter, [Internal.DefaultValue("SendMessageOptions.RequireReceiver")] SendMessageOptions options);
        //
        // 摘要:
        //     Calls the method named methodName on every MonoBehaviour in this game object
        //     or any of its children.      
        [ExcludeFromDocs]
        public void BroadcastMessage(string methodName, object parameter);
        //
        // 参数:
        
        public void BroadcastMessage(string methodName, SendMessageOptions options);
        //
        // 摘要:
        //     Is this game object tagged with tag ?
        //
        
        [FreeFunction(Name = "GameObjectBindings::CompareTag", HasExplicitThis = true)]
        public bool CompareTag(string tag);
        [SecuritySafeCritical]
        public T GetComponent<T>();
        //
        // 摘要:
        //     Returns the component with name type if the game object has one attached, null
        //     if it doesn't.
        //
       
        public Component GetComponent(string type);
        //
        // 摘要:
        //     Returns the component of Type type if the game object has one attached, null
        //     if it doesn't.
        //
        [FreeFunction(Name = "GameObjectBindings::GetComponentFromType", HasExplicitThis = true, ThrowsException = true)]
        [TypeInferenceRule(TypeInferenceRules.TypeReferencedByFirstArgument)]
        public Component GetComponent(Type type);
        //
        // 摘要:
        //     Returns the component of Type type in the GameObject or any of its children using
        //     depth first search.
        //
       
        [FreeFunction(Name = "GameObjectBindings::GetComponentInChildren", HasExplicitThis = true, ThrowsException = true)]
        [TypeInferenceRule(TypeInferenceRules.TypeReferencedByFirstArgument)]
        public Component GetComponentInChildren(Type type, bool includeInactive);
        //
        // 摘要:
        //     Returns the component of Type type in the GameObject or any of its children using
        //     depth first search.
        //
       
        [TypeInferenceRule(TypeInferenceRules.TypeReferencedByFirstArgument)]
        public Component GetComponentInChildren(Type type);
        [ExcludeFromDocs]
        public T GetComponentInChildren<T>();
        public T GetComponentInChildren<T>([Internal.DefaultValue("false")] bool includeInactive);
        //
        // 摘要:
        //     Returns the component of Type type in the GameObject or any of its parents.
        //
       
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
        public Component[] GetComponents(Type type);
        public void GetComponents(Type type, List<Component> results);
        //
        // 摘要:
        //     Returns all components of Type type in the GameObject or any of its children.
        //        
        [ExcludeFromDocs]
        public Component[] GetComponentsInChildren(Type type);
        //
        // 摘要:
        //     Returns all components of Type type in the GameObject or any of its children.
        //
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
        
        [ExcludeFromDocs]
        public void SendMessage(string methodName);
        //
        // 摘要:
        //     Calls the method named methodName on every MonoBehaviour in this game object.
        //
        
        [ExcludeFromDocs]
        public void SendMessage(string methodName, object value);
        //
        // 摘要:
        //     Calls the method named methodName on every MonoBehaviour in this game object.
        //        
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
       
        [ExcludeFromDocs]
        public void SendMessageUpwards(string methodName);
        //
        // 摘要:
        //     Calls the method named methodName on every MonoBehaviour in this game object
        //     and on every ancestor of the behaviour.
        //
        
        [ExcludeFromDocs]
        public void SendMessageUpwards(string methodName, object value);
        //
        // 摘要:
        //     Calls the method named methodName on every MonoBehaviour in this game object
        //     and on every ancestor of the behaviour.
        //       
        [FreeFunction(Name = "Scripting::SendScriptingMessageUpwards", HasExplicitThis = true)]
        public void SendMessageUpwards(string methodName, [Internal.DefaultValue("null")] object value, [Internal.DefaultValue("SendMessageOptions.RequireReceiver")] SendMessageOptions options);
        //
        // 摘要:
        //     ActivatesDeactivates the GameObject, depending on the given true or false/ value.
        //        
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
