// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/audiopolicy.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("C3B284D4-6D39-4359-B3CF-B56DDB3BB39C")]
    [NativeTypeName("struct IAudioVolumeDuckNotification : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IAudioVolumeDuckNotification
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAudioVolumeDuckNotification*, Guid*, void**, int>)(lpVtbl[0]))((IAudioVolumeDuckNotification*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAudioVolumeDuckNotification*, uint>)(lpVtbl[1]))((IAudioVolumeDuckNotification*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAudioVolumeDuckNotification*, uint>)(lpVtbl[2]))((IAudioVolumeDuckNotification*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int OnVolumeDuckNotification([NativeTypeName("LPCWSTR")] ushort* sessionID, [NativeTypeName("UINT32")] uint countCommunicationSessions)
        {
            return ((delegate* unmanaged<IAudioVolumeDuckNotification*, ushort*, uint, int>)(lpVtbl[3]))((IAudioVolumeDuckNotification*)Unsafe.AsPointer(ref this), sessionID, countCommunicationSessions);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int OnVolumeUnduckNotification([NativeTypeName("LPCWSTR")] ushort* sessionID)
        {
            return ((delegate* unmanaged<IAudioVolumeDuckNotification*, ushort*, int>)(lpVtbl[4]))((IAudioVolumeDuckNotification*)Unsafe.AsPointer(ref this), sessionID);
        }
    }
}
