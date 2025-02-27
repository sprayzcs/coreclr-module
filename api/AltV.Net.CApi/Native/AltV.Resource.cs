using System;
using System.Runtime.InteropServices;
using System.Security;
using AltV.Net.CApi.ClientEvents;
using AltV.Net.Data;
using AltV.Net.Elements.Entities;

namespace AltV.Net.Native
{
    //TODO: refactor to function pointers
    internal static partial class AltNative
    {
        [SuppressUnmanagedCodeSecurity]
        internal static class Resource
        {
            internal delegate void MainDelegate(IntPtr serverPointer, IntPtr resourcePointer, string resourceName,
                string entryPoint);

            internal delegate void StopDelegate();

            internal delegate void TickDelegate();

            internal delegate void CheckpointDelegate(IntPtr checkpointPointer, IntPtr entityPointer,
                BaseObjectType baseObjectType,
                bool state);

            internal delegate void PlayerConnectDelegate(IntPtr playerPointer, ushort playerId, string reason);

            internal delegate void PlayerConnectDeniedDelegate(PlayerConnectDeniedReason reason, string name, string ip,
                ulong passwordHash, bool isDebug, string branch, uint majorVersion, string cdnUrl, long discordId);

            internal delegate void ResourceEventDelegate(IntPtr resourcePointer);

            internal delegate void PlayerDamageDelegate(IntPtr playerPointer, IntPtr attackerEntityPointer,
                BaseObjectType attackerBaseObjectType,
                ushort attackerEntityId, uint weapon, ushort healthDamage, ushort armourDamage);

            internal delegate void PlayerDeathDelegate(IntPtr playerPointer, IntPtr killerEntityPointer,
                BaseObjectType killerBaseObjectType, uint weapon);

            internal delegate void PlayerChangeVehicleSeatDelegate(IntPtr vehiclePointer, IntPtr playerPointer,
                byte oldSeat,
                byte newSeat);

            internal delegate void PlayerEnterVehicleDelegate(IntPtr vehiclePointer, IntPtr playerPointer, byte seat);

            internal delegate void PlayerEnteringVehicleDelegate(IntPtr vehiclePointer, IntPtr playerPointer, byte seat);

            internal delegate void PlayerLeaveVehicleDelegate(IntPtr vehiclePointer, IntPtr playerPointer, byte seat);

            internal delegate void PlayerDisconnectDelegate(IntPtr playerPointer, string reason);

            internal delegate void ClientEventDelegate(IntPtr playerPointer, string name, IntPtr args, ulong size);

            internal delegate void ServerEventDelegate(string name, IntPtr args, ulong size);

            internal delegate void ColShapeDelegate(IntPtr colShapePointer, IntPtr targetEntityPointer,
                BaseObjectType entityType, bool state);

            internal delegate void VehicleDestroyDelegate(IntPtr vehiclePointer);

            internal delegate void ConsoleCommandDelegate(string name,
                [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)]
                string[] args, int argsSize);

            internal delegate void MetaChangeDelegate(IntPtr entityPointer, BaseObjectType entityType, string key,
                IntPtr value);

            internal delegate void ExplosionDelegate(IntPtr eventPointer, IntPtr playerPointer,
                ExplosionType explosionType,
                Position position, uint explosionFx, IntPtr targetEntityPointer, BaseObjectType targetEntityType);

            internal delegate void WeaponDamageDelegate(IntPtr eventPointer, IntPtr playerPointer, IntPtr entityPointer,
                BaseObjectType entityType, uint weapon, ushort damage, Position shotOffset, BodyPart bodyPart);

            internal delegate void FireDelegate(IntPtr eventPointer, IntPtr playerPointer,
                [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)]
                FireInfo[] fires, int length);

            internal delegate void StartProjectileDelegate(IntPtr eventPointer, IntPtr sourcePlayerPointer, Position startPosition, Position direction, uint ammoHash, uint weaponHash);

            internal delegate void PlayerWeaponChangeDelegate(IntPtr eventPointer, IntPtr targetPlayerPointer, uint oldWeapon, uint newWeapon);

            internal delegate void NetOwnerChangeDelegate(IntPtr eventPointer, IntPtr targetEntityPointer, BaseObjectType targetEntityType, IntPtr oldNetOwnerPointer, IntPtr newNetOwnerPointer);

            internal delegate void VehicleAttachDelegate(IntPtr eventPointer, IntPtr targetPointer, IntPtr attachedPointer);

            internal delegate void VehicleDetachDelegate(IntPtr eventPointer, IntPtr targetPointer, IntPtr detachedPointer);

            internal delegate void VehicleDamageDelegate(IntPtr eventPointer, IntPtr targetPointer, IntPtr sourcePointer, BaseObjectType sourceType, uint bodyHealthDamage, uint additionalBodyHealthDamage, uint engineHealthDamage, uint petrolTankDamage, uint weaponHash);

            internal delegate void VehicleHornDelegate(IntPtr eventPointer, IntPtr targetPointer,
                IntPtr reporterPointer, bool state);

            internal delegate void ConnectionQueueAddDelegate(IntPtr connectionInfoPointer);

            internal delegate void ConnectionQueueRemoveDelegate(IntPtr connectionInfoPointer);

            internal delegate void ServerStartedDelegate();

            internal delegate void PlayerRequestControlDelegate(IntPtr target, BaseObjectType targetType, IntPtr player);
            internal delegate void PlayerChangeAnimationDelegate(IntPtr target, uint oldDict, uint newDict, uint oldName, uint newName);
            internal delegate void PlayerChangeInteriorDelegate(IntPtr target, uint oldIntLoc, uint newIntLoc);
            internal delegate void PlayerDimensionChangeDelegate(IntPtr player, int oldDimension, int newDimension);

            internal delegate void VehicleSirenDelegate(IntPtr targetVehicle, bool state);

            internal delegate void PlayerSpawnDelegate(IntPtr player);

            internal delegate void CreateBaseObjectDelegate(IntPtr baseObject, BaseObjectType type, uint id);

            internal delegate void RemoveBaseObjectDelegate(IntPtr baseObject, BaseObjectType type);


            [DllImport(DllName, CallingConvention = NativeCallingConvention)]
            internal static extern void CSharpResourceImpl_SetMainDelegate(IntPtr resource,
                MainDelegate @delegate);

            [DllImport(DllName, CallingConvention = NativeCallingConvention)]
            internal static extern void CSharpResourceImpl_SetStopDelegate(IntPtr resource,
                StopDelegate @delegate);

            [DllImport(DllName, CallingConvention = NativeCallingConvention)]
            internal static extern void CSharpResourceImpl_SetTickDelegate(IntPtr resource,
                TickDelegate @delegate);

            [DllImport(DllName, CallingConvention = NativeCallingConvention)]
            internal static extern void CSharpResourceImpl_SetServerEventDelegate(IntPtr resource,
                ServerEventDelegate @delegate);

            [DllImport(DllName, CallingConvention = NativeCallingConvention)]
            internal static extern void CSharpResourceImpl_SetCheckpointDelegate(IntPtr resource,
                CheckpointDelegate @delegate);

            [DllImport(DllName, CallingConvention = NativeCallingConvention)]
            internal static extern void CSharpResourceImpl_SetClientEventDelegate(IntPtr resource,
                ClientEventDelegate @delegate);

            [DllImport(DllName, CallingConvention = NativeCallingConvention)]
            internal static extern void CSharpResourceImpl_SetPlayerDamageDelegate(IntPtr resource,
                PlayerDamageDelegate @delegate);

            [DllImport(DllName, CallingConvention = NativeCallingConvention)]
            internal static extern void CSharpResourceImpl_SetPlayerConnectDelegate(IntPtr resource,
                PlayerConnectDelegate @delegate);

            [DllImport(DllName, CallingConvention = NativeCallingConvention)]
            internal static extern void CSharpResourceImpl_SetPlayerConnectDeniedDelegate(IntPtr resource,
                PlayerConnectDeniedDelegate @delegate);

            [DllImport(DllName, CallingConvention = NativeCallingConvention)]
            internal static extern void CSharpResourceImpl_SetResourceStartDelegate(IntPtr resource,
                ResourceEventDelegate @delegate);

            [DllImport(DllName, CallingConvention = NativeCallingConvention)]
            internal static extern void CSharpResourceImpl_SetResourceStopDelegate(IntPtr resource,
                ResourceEventDelegate @delegate);

            [DllImport(DllName, CallingConvention = NativeCallingConvention)]
            internal static extern void CSharpResourceImpl_SetResourceErrorDelegate(IntPtr resource,
                ResourceEventDelegate @delegate);

            [DllImport(DllName, CallingConvention = NativeCallingConvention)]
            internal static extern void CSharpResourceImpl_SetPlayerDeathDelegate(IntPtr resource,
                PlayerDeathDelegate @delegate);

            [DllImport(DllName, CallingConvention = NativeCallingConvention)]
            internal static extern void CSharpResourceImpl_SetExplosionDelegate(IntPtr resource,
                ExplosionDelegate @delegate);

            [DllImport(DllName, CallingConvention = NativeCallingConvention)]
            internal static extern void CSharpResourceImpl_SetWeaponDamageDelegate(IntPtr resource,
                WeaponDamageDelegate @delegate);

            [DllImport(DllName, CallingConvention = NativeCallingConvention)]
            internal static extern void CSharpResourceImpl_SetPlayerDisconnectDelegate(IntPtr resource,
                PlayerDisconnectDelegate @delegate);

            [DllImport(DllName, CallingConvention = NativeCallingConvention)]
            internal static extern void CSharpResourceImpl_SetPlayerChangeVehicleSeatDelegate(IntPtr resource,
                PlayerChangeVehicleSeatDelegate @delegate);

            [DllImport(DllName, CallingConvention = NativeCallingConvention)]
            internal static extern void CSharpResourceImpl_SetPlayerEnterVehicleDelegate(IntPtr resource,
                PlayerEnterVehicleDelegate @delegate);

            [DllImport(DllName, CallingConvention = NativeCallingConvention)]
            internal static extern void CSharpResourceImpl_SetPlayerEnteringVehicleDelegate(IntPtr resource,
                PlayerEnteringVehicleDelegate @delegate);

            [DllImport(DllName, CallingConvention = NativeCallingConvention)]
            internal static extern void CSharpResourceImpl_SetPlayerLeaveVehicleDelegate(IntPtr resource,
                PlayerLeaveVehicleDelegate @delegate);

            [DllImport(DllName, CallingConvention = NativeCallingConvention)]
            internal static extern void CSharpResourceImpl_SetConsoleCommandDelegate(IntPtr resource,
                ConsoleCommandDelegate @delegate);

            [DllImport(DllName, CallingConvention = NativeCallingConvention)]
            internal static extern void CSharpResourceImpl_SetMetaChangeDelegate(IntPtr resource,
                MetaChangeDelegate @delegate);

            [DllImport(DllName, CallingConvention = NativeCallingConvention)]
            internal static extern void CSharpResourceImpl_SetSyncedMetaChangeDelegate(IntPtr resource,
                MetaChangeDelegate @delegate);

            [DllImport(DllName, CallingConvention = NativeCallingConvention)]
            internal static extern void CSharpResourceImpl_SetColShapeDelegate(IntPtr resource,
                ColShapeDelegate @delegate);

            [DllImport(DllName, CallingConvention = NativeCallingConvention)]
            internal static extern void CSharpResourceImpl_SetVehicleDestroyDelegate(IntPtr resource,
                VehicleDestroyDelegate @delegate);

            [DllImport(DllName, CallingConvention = NativeCallingConvention)]
            internal static extern void CSharpResourceImpl_SetFireDelegate(IntPtr resource,
                FireDelegate @delegate);

            [DllImport(DllName, CallingConvention = NativeCallingConvention)]
            internal static extern void CSharpResourceImpl_SetStartProjectileDelegate(IntPtr resource,
                StartProjectileDelegate @delegate);

            [DllImport(DllName, CallingConvention = NativeCallingConvention)]
            internal static extern void CSharpResourceImpl_SetPlayerWeaponChangeDelegate(IntPtr resource,
                PlayerWeaponChangeDelegate @delegate);

            [DllImport(DllName, CallingConvention = NativeCallingConvention)]
            internal static extern void CSharpResourceImpl_SetNetOwnerChangeDelegate(IntPtr resource,
                NetOwnerChangeDelegate @delegate);

            [DllImport(DllName, CallingConvention = NativeCallingConvention)]
            internal static extern void CSharpResourceImpl_SetVehicleAttachDelegate(IntPtr resource,
                VehicleAttachDelegate @delegate);

            [DllImport(DllName, CallingConvention = NativeCallingConvention)]
            internal static extern void CSharpResourceImpl_SetVehicleDetachDelegate(IntPtr resource,
                VehicleDetachDelegate @delegate);

            [DllImport(DllName, CallingConvention = NativeCallingConvention)]
            internal static extern void CSharpResourceImpl_SetVehicleDamageDelegate(IntPtr resource,
                VehicleDamageDelegate @delegate);

            [DllImport(DllName, CallingConvention = NativeCallingConvention)]
            internal static extern void CSharpResourceImpl_SetVehicleHornDelegate(IntPtr resource,
                VehicleHornDelegate @delegate);

            [DllImport(DllName, CallingConvention = NativeCallingConvention)]
            internal static extern void CSharpResourceImpl_SetConnectionQueueAddDelegate(IntPtr resource,
                ConnectionQueueAddDelegate @delegate);

            [DllImport(DllName, CallingConvention = NativeCallingConvention)]
            internal static extern void CSharpResourceImpl_SetConnectionQueueRemoveDelegate(IntPtr resource,
                ConnectionQueueRemoveDelegate @delegate);

            [DllImport(DllName, CallingConvention = NativeCallingConvention)]
            internal static extern void CSharpResourceImpl_SetServerStartedDelegate(IntPtr resource,
                ServerStartedDelegate @delegate);

            [DllImport(DllName, CallingConvention = NativeCallingConvention)]
            internal static extern void CSharpResourceImpl_SetPlayerRequestControlDelegate(IntPtr resource,
                PlayerRequestControlDelegate @delegate);

            [DllImport(DllName, CallingConvention = NativeCallingConvention)]
            internal static extern void CSharpResourceImpl_SetPlayerChangeAnimationDelegate(IntPtr resource,
                PlayerChangeAnimationDelegate @delegate);

            [DllImport(DllName, CallingConvention = NativeCallingConvention)]
            internal static extern void CSharpResourceImpl_SetPlayerChangeInteriorDelegate(IntPtr resource,
                PlayerChangeInteriorDelegate @delegate);

            [DllImport(DllName, CallingConvention = NativeCallingConvention)]
            internal static extern void CSharpResourceImpl_SetPlayerDimensionChangeDelegate(IntPtr resource,
                PlayerDimensionChangeDelegate @delegate);

            [DllImport(DllName, CallingConvention = NativeCallingConvention)]
            internal static extern void CSharpResourceImpl_SetVehicleSirenDelegate(IntPtr resource,
                VehicleSirenDelegate @delegate);

            [DllImport(DllName, CallingConvention = NativeCallingConvention)]
            internal static extern void CSharpResourceImpl_SetPlayerSpawnDelegate(IntPtr resource,
                PlayerSpawnDelegate @delegate);

            [DllImport(DllName, CallingConvention = NativeCallingConvention)]
            internal static extern void CSharpResourceImpl_SetCreateBaseObjectDelegate(IntPtr resource,
                CreateBaseObjectDelegate @delegate);

            [DllImport(DllName, CallingConvention = NativeCallingConvention)]
            internal static extern void CSharpResourceImpl_SetRemoveBaseObjectDelegate(IntPtr resource,
                RemoveBaseObjectDelegate @delegate);
        }
    }
}