// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("19108294-0441-4AFF-8013-FA0A730B0BEA")]
    [NativeTypeName("struct IUserNotificationCallback : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IUserNotificationCallback
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IUserNotificationCallback*, Guid*, void**, int>)(lpVtbl[0]))((IUserNotificationCallback*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IUserNotificationCallback*, uint>)(lpVtbl[1]))((IUserNotificationCallback*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IUserNotificationCallback*, uint>)(lpVtbl[2]))((IUserNotificationCallback*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT OnBalloonUserClick(POINT* pt)
        {
            return ((delegate* unmanaged<IUserNotificationCallback*, POINT*, int>)(lpVtbl[3]))((IUserNotificationCallback*)Unsafe.AsPointer(ref this), pt);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT OnLeftClick(POINT* pt)
        {
            return ((delegate* unmanaged<IUserNotificationCallback*, POINT*, int>)(lpVtbl[4]))((IUserNotificationCallback*)Unsafe.AsPointer(ref this), pt);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT OnContextMenu(POINT* pt)
        {
            return ((delegate* unmanaged<IUserNotificationCallback*, POINT*, int>)(lpVtbl[5]))((IUserNotificationCallback*)Unsafe.AsPointer(ref this), pt);
        }
    }
}
