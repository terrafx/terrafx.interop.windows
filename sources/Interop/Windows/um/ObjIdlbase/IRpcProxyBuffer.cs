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
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IRpcProxyBuffer*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IRpcProxyBuffer*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IRpcProxyBuffer*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Connect([NativeTypeName("IRpcChannelBuffer *")] IRpcChannelBuffer* pRpcChannelBuffer)
        {
            return lpVtbl->Connect((IRpcProxyBuffer*)Unsafe.AsPointer(ref this), pRpcChannelBuffer);
        }

        public void Disconnect()
        {
            lpVtbl->Disconnect((IRpcProxyBuffer*)Unsafe.AsPointer(ref this));
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IRpcProxyBuffer*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IRpcProxyBuffer*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IRpcProxyBuffer*, uint> Release;

            [NativeTypeName("HRESULT (IRpcChannelBuffer *) __attribute__((stdcall))")]
            public delegate* stdcall<IRpcProxyBuffer*, IRpcChannelBuffer*, int> Connect;

            [NativeTypeName("void () __attribute__((stdcall))")]
            public delegate* stdcall<IRpcProxyBuffer*, void> Disconnect;
        }
    }
}
