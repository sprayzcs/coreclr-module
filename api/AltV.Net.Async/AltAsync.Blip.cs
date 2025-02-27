using System;
using System.Threading.Tasks;
using AltV.Net.Data;
using AltV.Net.Elements.Entities;

namespace AltV.Net.Async
{
    public static partial class AltAsync
    {
        public static Task<IBlip> CreateBlip(IPlayer player, byte type, Position pos) =>
            AltVAsync.Schedule(() => Alt.CreateBlip(player, type, pos));

        public static Task<IBlip> CreateBlip(IPlayer player, byte type, IEntity entityAttach) =>
            AltVAsync.Schedule(() => Alt.CreateBlip(player, type, entityAttach));

        public static Task<IBlip> CreateBlip(IPlayer player, BlipType type, Position pos) =>
            AltVAsync.Schedule(() => Alt.CreateBlip(player, type, pos));

        public static Task<IBlip> CreateBlip(IPlayer player, BlipType type, IEntity entityAttach) =>
            AltVAsync.Schedule(() => Alt.CreateBlip(player, type, entityAttach));

        public static Task<IBlip> CreateBlip(byte type, Position pos) =>
            AltVAsync.Schedule(() => Alt.CreateBlip(type, pos));

        public static Task<IBlip> CreateBlip(byte type, IEntity entityAttach) =>
            AltVAsync.Schedule(() => Alt.CreateBlip(type, entityAttach));

        public static Task<IBlip> CreateBlip(BlipType type, Position pos) =>
            AltVAsync.Schedule(() => Alt.CreateBlip(type, pos));

        public static Task<IBlip> CreateBlip(BlipType type, IEntity entityAttach) =>
            AltVAsync.Schedule(() => Alt.CreateBlip(type, entityAttach));

        [Obsolete("Use async entities instead")]
        public static Task<bool> IsGlobalAsync(this IBlip blip) =>
            AltVAsync.Schedule(() => blip.IsGlobal);

        [Obsolete("Use async entities instead")]
        public static Task<bool> IsAttachedAsync(this IBlip blip) =>
            AltVAsync.Schedule(() => blip.IsAttached);

        [Obsolete("Use async entities instead")]
        public static Task<IEntity> AttachedToAsync(this IBlip blip) =>
            AltVAsync.Schedule(() => blip.AttachedTo);

        [Obsolete("Use async entities instead")]
        public static Task<BlipType> GetBlipTypeAsync(this IBlip blip) =>
            AltVAsync.Schedule(() => (BlipType) blip.BlipType);

        [Obsolete("Use async entities instead")]
        public static Task SetSpriteAsync(this IBlip blip, ushort sprite) =>
            AltVAsync.Schedule(() => blip.Sprite = sprite);

        [Obsolete("Use async entities instead")]
        public static Task SetColorAsync(this IBlip blip, byte color) =>
            AltVAsync.Schedule(() => blip.Color = color);

        [Obsolete("Use async entities instead")]
        public static Task SetRouteAsync(this IBlip blip, bool route) =>
            AltVAsync.Schedule(() => blip.Route = route);

        [Obsolete("Use async entities instead")]
        public static Task SetRouteColorAsync(this IBlip blip, Rgba color) =>
            AltVAsync.Schedule(() => blip.RouteColor = color);

        [Obsolete("Use async entities instead")]
        public static Task RemoveAsync(this IBlip blip) =>
            AltVAsync.Schedule(blip.RemoveAsync);
    }
}