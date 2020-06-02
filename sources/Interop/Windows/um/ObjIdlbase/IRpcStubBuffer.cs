// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdlbase.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("D5F56AFC-593B-101A-B569-08002B2DBF7A")]
    public unsafe partial struct IRpcStubBuffer
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IRpcStubBuffer*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IRpcStubBuffer*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IRpcStubBuffer*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Connect([NativeTypeName("IUnknown *")] IUnknown* pUnkServer)
        {
            return lpVtbl->Connect((IRpcStubBuffer*)Unsafe.AsPointer(ref this), pUnkServer);
        }

        public void Disconnect()
        {
            lpVtbl->Disconnect((IRpcStubBuffer*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("RPCOLEMESSAGE *")] RPCOLEMESSAGE* _prpcmsg, [NativeTypeName("IRpcChannelBuffer *")] IRpcChannelBuffer* _pRpcChannelBuffer)
        {
            return lpVtbl->Invoke((IRpcStubBuffer*)Unsafe.AsPointer(ref this), _prpcmsg, _pRpcChannelBuffer);
        }

        [return: NativeTypeName("IRpcStubBuffer *")]
        public IRpcStubBuffer* IsIIDSupported([NativeTypeName("const IID &")] Guid* riid)
        {
            return lpVtbl->IsIIDSupported((IRpcStubBuffer*)Unsafe.AsPointer(ref this), riid);
        }

        [return: NativeTypeName("ULONG")]
        public uint CountRefs()
        {
            return lpVtbl->CountRefs((IRpcStubBuffer*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int DebugServerQueryInterface([NativeTypeName("void **")] void** ppv)
        {
            return lpVtbl->DebugServerQueryInterface((IRpcStubBuffer*)Unsafe.AsPointer(ref this), ppv);
        }

        public void DebugServerRelease([NativeTypeName("void *")] void* pv)
        {
            lpVtbl->DebugServerRelease((IRpcStubBuffer*)Unsafe.AsPointer(ref this), pv);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IRpcStubBuffer*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IRpcStubBuffer*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IRpcStubBuffer*, uint> Release;

            [NativeTypeName("HRESULT (IUnknown *) __attribute__((stdcall))")]
            public delegate* stdcall<IRpcStubBuffer*, IUnknown*, int> Connect;

            [NativeTypeName("void () __attribute__((stdcall))")]
            public delegate* stdcall<IRpcStubBuffer*, void> Disconnect;

            [NativeTypeName("HRESULT (RPCOLEMESSAGE *, IRpcChannelBuffer *) __attribute__((stdcall))")]
            public delegate* stdcall<IRpcStubBuffer*, RPCOLEMESSAGE*, IRpcChannelBuffer*, int> Invoke;

            [NativeTypeName("IRpcStubBuffer *(const IID &) __attribute__((stdcall))")]
            public delegate* stdcall<IRpcStubBuffer*, Guid*, IRpcStubBuffer*> IsIIDSupported;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IRpcStubBuffer*, uint> CountRefs;

            [NativeTypeName("HRESULT (void **) __attribute__((stdcall))")]
            public delegate* stdcall<IRpcStubBuffer*, void**, int> DebugServerQueryInterface;

            [NativeTypeName("void (void *) __attribute__((stdcall))")]
            public delegate* stdcall<IRpcStubBuffer*, void*, void> DebugServerRelease;
        }
    }
}
