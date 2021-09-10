// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Audioclient.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("6F49FF73-6727-49AC-A008-D98CF5E70048")]
    [NativeTypeName("struct IAudioClock2 : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IAudioClock2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAudioClock2*, Guid*, void**, int>)(lpVtbl[0]))((IAudioClock2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAudioClock2*, uint>)(lpVtbl[1]))((IAudioClock2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAudioClock2*, uint>)(lpVtbl[2]))((IAudioClock2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetDevicePosition([NativeTypeName("UINT64 *")] ulong* DevicePosition, [NativeTypeName("UINT64 *")] ulong* QPCPosition)
        {
            return ((delegate* unmanaged<IAudioClock2*, ulong*, ulong*, int>)(lpVtbl[3]))((IAudioClock2*)Unsafe.AsPointer(ref this), DevicePosition, QPCPosition);
        }
    }
}
