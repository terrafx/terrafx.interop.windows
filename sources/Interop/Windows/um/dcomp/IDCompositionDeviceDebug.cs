// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dcomp.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A1A3C64A-224F-4A81-9773-4F03A89D3C6C")]
    [NativeTypeName("struct IDCompositionDeviceDebug : IUnknown")]
    public unsafe partial struct IDCompositionDeviceDebug
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDCompositionDeviceDebug*, Guid*, void**, int>)(lpVtbl[0]))((IDCompositionDeviceDebug*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDCompositionDeviceDebug*, uint>)(lpVtbl[1]))((IDCompositionDeviceDebug*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDCompositionDeviceDebug*, uint>)(lpVtbl[2]))((IDCompositionDeviceDebug*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int EnableDebugCounters()
        {
            return ((delegate* unmanaged<IDCompositionDeviceDebug*, int>)(lpVtbl[3]))((IDCompositionDeviceDebug*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DisableDebugCounters()
        {
            return ((delegate* unmanaged<IDCompositionDeviceDebug*, int>)(lpVtbl[4]))((IDCompositionDeviceDebug*)Unsafe.AsPointer(ref this));
        }
    }
}
