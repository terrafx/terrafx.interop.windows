// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdlbase.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A5029FB6-3C34-11D1-9C99-00C04FB998AA")]
    public unsafe partial struct IAsyncRpcChannelBuffer
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IAsyncRpcChannelBuffer*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IAsyncRpcChannelBuffer*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IAsyncRpcChannelBuffer*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetBuffer([NativeTypeName("RPCOLEMESSAGE *")] RPCOLEMESSAGE* pMessage, [NativeTypeName("const IID &")] Guid* riid)
        {
            return lpVtbl->GetBuffer((IAsyncRpcChannelBuffer*)Unsafe.AsPointer(ref this), pMessage, riid);
        }

        [return: NativeTypeName("HRESULT")]
        public int SendReceive([NativeTypeName("RPCOLEMESSAGE *")] RPCOLEMESSAGE* pMessage, [NativeTypeName("ULONG *")] uint* pStatus)
        {
            return lpVtbl->SendReceive((IAsyncRpcChannelBuffer*)Unsafe.AsPointer(ref this), pMessage, pStatus);
        }

        [return: NativeTypeName("HRESULT")]
        public int FreeBuffer([NativeTypeName("RPCOLEMESSAGE *")] RPCOLEMESSAGE* pMessage)
        {
            return lpVtbl->FreeBuffer((IAsyncRpcChannelBuffer*)Unsafe.AsPointer(ref this), pMessage);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDestCtx([NativeTypeName("DWORD *")] uint* pdwDestContext, [NativeTypeName("void **")] void** ppvDestContext)
        {
            return lpVtbl->GetDestCtx((IAsyncRpcChannelBuffer*)Unsafe.AsPointer(ref this), pdwDestContext, ppvDestContext);
        }

        [return: NativeTypeName("HRESULT")]
        public int IsConnected()
        {
            return lpVtbl->IsConnected((IAsyncRpcChannelBuffer*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetProtocolVersion([NativeTypeName("DWORD *")] uint* pdwVersion)
        {
            return lpVtbl->GetProtocolVersion((IAsyncRpcChannelBuffer*)Unsafe.AsPointer(ref this), pdwVersion);
        }

        [return: NativeTypeName("HRESULT")]
        public int Send([NativeTypeName("RPCOLEMESSAGE *")] RPCOLEMESSAGE* pMsg, [NativeTypeName("ISynchronize *")] ISynchronize* pSync, [NativeTypeName("ULONG *")] uint* pulStatus)
        {
            return lpVtbl->Send((IAsyncRpcChannelBuffer*)Unsafe.AsPointer(ref this), pMsg, pSync, pulStatus);
        }

        [return: NativeTypeName("HRESULT")]
        public int Receive([NativeTypeName("RPCOLEMESSAGE *")] RPCOLEMESSAGE* pMsg, [NativeTypeName("ULONG *")] uint* pulStatus)
        {
            return lpVtbl->Receive((IAsyncRpcChannelBuffer*)Unsafe.AsPointer(ref this), pMsg, pulStatus);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDestCtxEx([NativeTypeName("RPCOLEMESSAGE *")] RPCOLEMESSAGE* pMsg, [NativeTypeName("DWORD *")] uint* pdwDestContext, [NativeTypeName("void **")] void** ppvDestContext)
        {
            return lpVtbl->GetDestCtxEx((IAsyncRpcChannelBuffer*)Unsafe.AsPointer(ref this), pMsg, pdwDestContext, ppvDestContext);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IAsyncRpcChannelBuffer*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IAsyncRpcChannelBuffer*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IAsyncRpcChannelBuffer*, uint> Release;

            [NativeTypeName("HRESULT (RPCOLEMESSAGE *, const IID &) __attribute__((stdcall))")]
            public delegate* stdcall<IAsyncRpcChannelBuffer*, RPCOLEMESSAGE*, Guid*, int> GetBuffer;

            [NativeTypeName("HRESULT (RPCOLEMESSAGE *, ULONG *) __attribute__((stdcall))")]
            public delegate* stdcall<IAsyncRpcChannelBuffer*, RPCOLEMESSAGE*, uint*, int> SendReceive;

            [NativeTypeName("HRESULT (RPCOLEMESSAGE *) __attribute__((stdcall))")]
            public delegate* stdcall<IAsyncRpcChannelBuffer*, RPCOLEMESSAGE*, int> FreeBuffer;

            [NativeTypeName("HRESULT (DWORD *, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IAsyncRpcChannelBuffer*, uint*, void**, int> GetDestCtx;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* stdcall<IAsyncRpcChannelBuffer*, int> IsConnected;

            [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
            public delegate* stdcall<IAsyncRpcChannelBuffer*, uint*, int> GetProtocolVersion;

            [NativeTypeName("HRESULT (RPCOLEMESSAGE *, ISynchronize *, ULONG *) __attribute__((stdcall))")]
            public delegate* stdcall<IAsyncRpcChannelBuffer*, RPCOLEMESSAGE*, ISynchronize*, uint*, int> Send;

            [NativeTypeName("HRESULT (RPCOLEMESSAGE *, ULONG *) __attribute__((stdcall))")]
            public delegate* stdcall<IAsyncRpcChannelBuffer*, RPCOLEMESSAGE*, uint*, int> Receive;

            [NativeTypeName("HRESULT (RPCOLEMESSAGE *, DWORD *, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IAsyncRpcChannelBuffer*, RPCOLEMESSAGE*, uint*, void**, int> GetDestCtxEx;
        }
    }
}
