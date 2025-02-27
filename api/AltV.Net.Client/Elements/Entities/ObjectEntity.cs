﻿using AltV.Net.Client.Elements.Interfaces;
using AltV.Net.Data;
using AltV.Net.Elements.Entities;
using AltV.Net.Shared.Elements.Entities;

namespace AltV.Net.Client.Elements.Entities;

public class ObjectEntity : Entity, IObject
{
    private static IntPtr GetEntityPointer(ICore core, IntPtr objectNativePointer)
    {
        unsafe
        {
            return core.Library.Client.Object_GetEntity(objectNativePointer);
        }
    }

    public IntPtr ObjectNativePointer { get; }
    public override IntPtr NativePointer => ObjectNativePointer;

    public ObjectEntity(ICore core, IntPtr objectPointer, uint id) : base(core, GetEntityPointer(core, objectPointer), id, BaseObjectType.Object)
    {
        ObjectNativePointer = objectPointer;
    }

    public static uint GetId(IntPtr objectPointer)
    {
        unsafe
        {
            return Alt.Core.Library.Client.Object_GetID(objectPointer);
        }
    }

    public new uint Model
    {
        get => base.Model;
        set
        {
            unsafe
            {
                CheckIfEntityExists();
                Core.Library.Client.Object_SetModel(ObjectNativePointer, value);
            }
        }
    }

    public byte Alpha
    {
        get
        {
            unsafe
            {
                CheckIfEntityExists();
                return Core.Library.Client.Object_GetAlpha(ObjectNativePointer);
            }
        }
        set
        {
            unsafe
            {
                CheckIfEntityExists();
                Core.Library.Client.Object_SetAlpha(ObjectNativePointer, value);
            }
        }
    }

    public void ResetAlpha()
    {
        unsafe
        {
            CheckIfEntityExists();
            Alt.Core.Library.Client.Object_ResetAlpha(ObjectNativePointer);
        }
    }

    public bool IsDynamic
    {
        get
        {
            unsafe
            {
                CheckIfEntityExists();
                return Alt.Core.Library.Client.Object_IsDynamic(ObjectNativePointer) == 1;
            }
        }
    }

    public ushort LodDistance
    {
        get
        {
            unsafe
            {
                CheckIfEntityExists();
                return Alt.Core.Library.Client.Object_GetLodDistance(ObjectNativePointer);
            }
        }
        set
        {
            unsafe
            {
                CheckIfEntityExists();
                Alt.Core.Library.Client.Object_SetLodDistance(ObjectNativePointer, value);
            }
        }
    }

    public bool Gravity
    {
        get
        {
            unsafe
            {
                CheckIfEntityExists();
                return Alt.Core.Library.Client.Object_HasGravity(ObjectNativePointer) == 1;
            }
        }
        set
        {
            unsafe
            {
                CheckIfEntityExists();
                Alt.Core.Library.Client.Object_ToggleGravity(ObjectNativePointer, value ? (byte)1 : (byte)0);
            }
        }
    }

    public void AttachToEntity(ISharedEntity entity, short bone, Position position, Rotation rotation, bool useSoftPinning,
        bool collision, bool fixedRotation)
    {
        unsafe
        {
            CheckIfEntityExists();
            Alt.Core.Library.Client.Object_AttachToEntity(ObjectNativePointer, entity.EntityNativePointer, bone, position, rotation,
                useSoftPinning? (byte)1 : (byte)0, collision? (byte)1 : (byte)0, fixedRotation? (byte)1 : (byte)0);
        }
    }

    public void AttachToEntity(uint scriptId, short bone, Position position, Rotation rotation, bool useSoftPinning,
        bool collision, bool fixedRotation)
    {
        unsafe
        {
            CheckIfEntityExists();
            Alt.Core.Library.Client.Object_AttachToEntity_ScriptId(ObjectNativePointer, scriptId, bone, position, rotation,
                useSoftPinning? (byte)1 : (byte)0, collision? (byte)1 : (byte)0, fixedRotation? (byte)1 : (byte)0);
        }
    }

    public void Detach(bool dynamic)
    {
        unsafe
        {
            CheckIfEntityExists();
            Alt.Core.Library.Client.Object_Detach(ObjectNativePointer, dynamic ? (byte)1 : (byte)0);
        }
    }

    public bool Collision
    {
        get
        {
            unsafe
            {
                CheckIfEntityExists();
                return Alt.Core.Library.Client.Object_IsCollisionEnabled(ObjectNativePointer) == 1;
            }
        }
    }

    public void ToggleCollision(bool toggle, bool keepPhysics)
    {
        unsafe
        {
            CheckIfEntityExists();
            Alt.Core.Library.Client.Object_ToggleCollision(ObjectNativePointer, toggle ? (byte) 1 : (byte) 0,
                keepPhysics ? (byte) 1 : (byte) 0);
        }
    }

    public void PlaceOnGroundProperly()
    {
        unsafe
        {
            CheckIfEntityExists();
            Alt.Core.Library.Client.Object_PlaceOnGroundProperly(ObjectNativePointer);
        }
    }

    public void SetPositionFrozen(bool state)
    {
        unsafe
        {
            CheckIfEntityExists();
            Alt.Core.Library.Client.Object_SetPositionFrozen(ObjectNativePointer, state ? (byte)1:(byte)0);
        }
    }

    public void ActivatePhysics()
    {
        unsafe
        {
            CheckIfEntityExists();
            Alt.Core.Library.Client.Object_ActivatePhysics(ObjectNativePointer);
        }
    }

    public byte TextureVariation
    {
        get
        {
            unsafe
            {
                CheckIfEntityExists();
                return Alt.Core.Library.Client.Object_GetTextureVariation(ObjectNativePointer);
            }
        }
        set
        {
            unsafe
            {
                CheckIfEntityExists();
                Alt.Core.Library.Client.Object_SetTextureVariation(ObjectNativePointer, value);
            }
        }
    }

    public bool IsWorldObject
    {
        get
        {
            unsafe
            {
                CheckIfEntityExists();
                return Alt.Core.Library.Client.Object_IsWorldObject(ObjectNativePointer) == 1;
            }
        }
    }

    public uint StreamingDistance
    {
        get
        {
            unsafe
            {
                CheckIfEntityExists();
                return Alt.Core.Library.Client.Object_GetStreamingDistance(ObjectNativePointer);
            }
        }
    }

    public bool IsStreamedIn
    {
        get
        {
            unsafe
            {
                CheckIfEntityExists();
                return Alt.Core.Library.Client.Object_IsStreamedIn(ObjectNativePointer) == 1;
            }
        }
    }

    public bool UsesStreaming
    {
        get
        {
            unsafe
            {
                CheckIfEntityExists();
                return Alt.Core.Library.Client.Object_UsesStreaming(ObjectNativePointer) == 1;
            }
        }
    }

    public bool Visible
    {
        get
        {
            unsafe
            {
                CheckIfEntityExists();
                return Core.Library.Client.Object_IsVisible(ObjectNativePointer) == 1;
            }
        }
        set
        {
            unsafe
            {
                CheckIfEntityExists();
                Core.Library.Client.Object_SetVisible(ObjectNativePointer, value ? (byte)1:(byte)0);
            }
        }
    }
}