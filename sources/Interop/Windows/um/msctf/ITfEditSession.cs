// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msctf.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("AA80E803-2021-11D2-93E0-0060B067B86E")]
    [NativeTypeName("struct ITfEditSession : IUnknown")]
    public unsafe partial struct ITfEditSession
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<ITfEditSession*, Guid*, void**, int>)(lpVtbl[0]))((ITfEditSession*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITfEditSession*, uint>)(lpVtbl[1]))((ITfEditSession*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITfEditSession*, uint>)(lpVtbl[2]))((ITfEditSession*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DoEditSession([NativeTypeName("TfEditCookie")] uint ec)
        {
            return ((delegate* unmanaged<ITfEditSession*, uint, int>)(lpVtbl[3]))((ITfEditSession*)Unsafe.AsPointer(ref this), ec);
        }
    }
}
