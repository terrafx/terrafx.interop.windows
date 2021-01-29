// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MSAAText.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("B5F8FB3B-393F-4F7C-84CB-504924C2705A")]
    [NativeTypeName("struct ITfMSAAControl : IUnknown")]
    public unsafe partial struct ITfMSAAControl
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<ITfMSAAControl*, Guid*, void**, int>)(lpVtbl[0]))((ITfMSAAControl*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITfMSAAControl*, uint>)(lpVtbl[1]))((ITfMSAAControl*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITfMSAAControl*, uint>)(lpVtbl[2]))((ITfMSAAControl*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SystemEnableMSAA()
        {
            return ((delegate* unmanaged<ITfMSAAControl*, int>)(lpVtbl[3]))((ITfMSAAControl*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SystemDisableMSAA()
        {
            return ((delegate* unmanaged<ITfMSAAControl*, int>)(lpVtbl[4]))((ITfMSAAControl*)Unsafe.AsPointer(ref this));
        }
    }
}
