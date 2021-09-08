// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msctf.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("D60A7B49-1B9F-4BE2-B702-47E9DC05DEC3")]
    [NativeTypeName("struct ITfClientId : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ITfClientId
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ITfClientId*, Guid*, void**, int>)(lpVtbl[0]))((ITfClientId*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITfClientId*, uint>)(lpVtbl[1]))((ITfClientId*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITfClientId*, uint>)(lpVtbl[2]))((ITfClientId*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetClientId([NativeTypeName("const IID &")] Guid* rclsid, [NativeTypeName("TfClientId *")] uint* ptid)
        {
            return ((delegate* unmanaged<ITfClientId*, Guid*, uint*, int>)(lpVtbl[3]))((ITfClientId*)Unsafe.AsPointer(ref this), rclsid, ptid);
        }
    }
}
