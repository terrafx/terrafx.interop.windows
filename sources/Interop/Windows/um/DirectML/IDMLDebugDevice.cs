// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DirectML.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("7D6F3AC9-394A-4AC3-92A7-390CC57A8217")]
    [NativeTypeName("struct IDMLDebugDevice : IUnknown")]
    public unsafe partial struct IDMLDebugDevice
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IDMLDebugDevice*, Guid*, void**, int>)(lpVtbl[0]))((IDMLDebugDevice*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IDMLDebugDevice*, uint>)(lpVtbl[1]))((IDMLDebugDevice*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IDMLDebugDevice*, uint>)(lpVtbl[2]))((IDMLDebugDevice*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetMuteDebugOutput([NativeTypeName("BOOL")] int mute)
        {
            ((delegate* unmanaged[Stdcall]<IDMLDebugDevice*, int, void>)(lpVtbl[3]))((IDMLDebugDevice*)Unsafe.AsPointer(ref this), mute);
        }
    }
}
