// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DirectML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("7D6F3AC9-394A-4AC3-92A7-390CC57A8217")]
    [NativeTypeName("struct IDMLDebugDevice : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IDMLDebugDevice
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDMLDebugDevice*, Guid*, void**, int>)(lpVtbl[0]))((IDMLDebugDevice*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDMLDebugDevice*, uint>)(lpVtbl[1]))((IDMLDebugDevice*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDMLDebugDevice*, uint>)(lpVtbl[2]))((IDMLDebugDevice*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public void SetMuteDebugOutput(BOOL mute)
        {
            ((delegate* unmanaged<IDMLDebugDevice*, BOOL, void>)(lpVtbl[3]))((IDMLDebugDevice*)Unsafe.AsPointer(ref this), mute);
        }
    }
}
