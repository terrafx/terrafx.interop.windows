// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdlbase.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("D5F56A34-593B-101A-B569-08002B2DBF7A")]
    public unsafe partial struct IRpcProxyBuffer
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IRpcProxyBuffer*, Guid*, void**, int>)(lpVtbl[0]))((IRpcProxyBuffer*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IRpcProxyBuffer*, uint>)(lpVtbl[1]))((IRpcProxyBuffer*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IRpcProxyBuffer*, uint>)(lpVtbl[2]))((IRpcProxyBuffer*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Connect([NativeTypeName("IRpcChannelBuffer *")] IRpcChannelBuffer* pRpcChannelBuffer)
        {
            return ((delegate* stdcall<IRpcProxyBuffer*, IRpcChannelBuffer*, int>)(lpVtbl[3]))((IRpcProxyBuffer*)Unsafe.AsPointer(ref this), pRpcChannelBuffer);
        }

        public void Disconnect()
        {
            ((delegate* stdcall<IRpcProxyBuffer*, void>)(lpVtbl[4]))((IRpcProxyBuffer*)Unsafe.AsPointer(ref this));
        }
    }
}
