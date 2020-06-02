// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdlbase.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("25B15600-0115-11D0-BF0D-00AA00B8DFD2")]
    public unsafe partial struct IRpcChannelBuffer3
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IRpcChannelBuffer3*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IRpcChannelBuffer3*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IRpcChannelBuffer3*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetBuffer([NativeTypeName("RPCOLEMESSAGE *")] RPCOLEMESSAGE* pMessage, [NativeTypeName("const IID &")] Guid* riid)
        {
            return lpVtbl->GetBuffer((IRpcChannelBuffer3*)Unsafe.AsPointer(ref this), pMessage, riid);
        }

        [return: NativeTypeName("HRESULT")]
        public int SendReceive([NativeTypeName("RPCOLEMESSAGE *")] RPCOLEMESSAGE* pMessage, [NativeTypeName("ULONG *")] uint* pStatus)
        {
            return lpVtbl->SendReceive((IRpcChannelBuffer3*)Unsafe.AsPointer(ref this), pMessage, pStatus);
        }

        [return: NativeTypeName("HRESULT")]
        public int FreeBuffer([NativeTypeName("RPCOLEMESSAGE *")] RPCOLEMESSAGE* pMessage)
        {
            return lpVtbl->FreeBuffer((IRpcChannelBuffer3*)Unsafe.AsPointer(ref this), pMessage);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDestCtx([NativeTypeName("DWORD *")] uint* pdwDestContext, [NativeTypeName("void **")] void** ppvDestContext)
        {
            return lpVtbl->GetDestCtx((IRpcChannelBuffer3*)Unsafe.AsPointer(ref this), pdwDestContext, ppvDestContext);
        }

        [return: NativeTypeName("HRESULT")]
        public int IsConnected()
        {
            return lpVtbl->IsConnected((IRpcChannelBuffer3*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetProtocolVersion([NativeTypeName("DWORD *")] uint* pdwVersion)
        {
            return lpVtbl->GetProtocolVersion((IRpcChannelBuffer3*)Unsafe.AsPointer(ref this), pdwVersion);
        }

        [return: NativeTypeName("HRESULT")]
        public int Send([NativeTypeName("RPCOLEMESSAGE *")] RPCOLEMESSAGE* pMsg, [NativeTypeName("ULONG *")] uint* pulStatus)
        {
            return lpVtbl->Send((IRpcChannelBuffer3*)Unsafe.AsPointer(ref this), pMsg, pulStatus);
        }

        [return: NativeTypeName("HRESULT")]
        public int Receive([NativeTypeName("RPCOLEMESSAGE *")] RPCOLEMESSAGE* pMsg, [NativeTypeName("ULONG")] uint ulSize, [NativeTypeName("ULONG *")] uint* pulStatus)
        {
            return lpVtbl->Receive((IRpcChannelBuffer3*)Unsafe.AsPointer(ref this), pMsg, ulSize, pulStatus);
        }

        [return: NativeTypeName("HRESULT")]
        public int Cancel([NativeTypeName("RPCOLEMESSAGE *")] RPCOLEMESSAGE* pMsg)
        {
            return lpVtbl->Cancel((IRpcChannelBuffer3*)Unsafe.AsPointer(ref this), pMsg);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCallContext([NativeTypeName("RPCOLEMESSAGE *")] RPCOLEMESSAGE* pMsg, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** pInterface)
        {
            return lpVtbl->GetCallContext((IRpcChannelBuffer3*)Unsafe.AsPointer(ref this), pMsg, riid, pInterface);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDestCtxEx([NativeTypeName("RPCOLEMESSAGE *")] RPCOLEMESSAGE* pMsg, [NativeTypeName("DWORD *")] uint* pdwDestContext, [NativeTypeName("void **")] void** ppvDestContext)
        {
            return lpVtbl->GetDestCtxEx((IRpcChannelBuffer3*)Unsafe.AsPointer(ref this), pMsg, pdwDestContext, ppvDestContext);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetState([NativeTypeName("RPCOLEMESSAGE *")] RPCOLEMESSAGE* pMsg, [NativeTypeName("DWORD *")] uint* pState)
        {
            return lpVtbl->GetState((IRpcChannelBuffer3*)Unsafe.AsPointer(ref this), pMsg, pState);
        }

        [return: NativeTypeName("HRESULT")]
        public int RegisterAsync([NativeTypeName("RPCOLEMESSAGE *")] RPCOLEMESSAGE* pMsg, [NativeTypeName("IAsyncManager *")] IAsyncManager* pAsyncMgr)
        {
            return lpVtbl->RegisterAsync((IRpcChannelBuffer3*)Unsafe.AsPointer(ref this), pMsg, pAsyncMgr);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IRpcChannelBuffer3*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IRpcChannelBuffer3*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IRpcChannelBuffer3*, uint> Release;

            [NativeTypeName("HRESULT (RPCOLEMESSAGE *, const IID &) __attribute__((stdcall))")]
            public delegate* stdcall<IRpcChannelBuffer3*, RPCOLEMESSAGE*, Guid*, int> GetBuffer;

            [NativeTypeName("HRESULT (RPCOLEMESSAGE *, ULONG *) __attribute__((stdcall))")]
            public delegate* stdcall<IRpcChannelBuffer3*, RPCOLEMESSAGE*, uint*, int> SendReceive;

            [NativeTypeName("HRESULT (RPCOLEMESSAGE *) __attribute__((stdcall))")]
            public delegate* stdcall<IRpcChannelBuffer3*, RPCOLEMESSAGE*, int> FreeBuffer;

            [NativeTypeName("HRESULT (DWORD *, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IRpcChannelBuffer3*, uint*, void**, int> GetDestCtx;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* stdcall<IRpcChannelBuffer3*, int> IsConnected;

            [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
            public delegate* stdcall<IRpcChannelBuffer3*, uint*, int> GetProtocolVersion;

            [NativeTypeName("HRESULT (RPCOLEMESSAGE *, ULONG *) __attribute__((stdcall))")]
            public delegate* stdcall<IRpcChannelBuffer3*, RPCOLEMESSAGE*, uint*, int> Send;

            [NativeTypeName("HRESULT (RPCOLEMESSAGE *, ULONG, ULONG *) __attribute__((stdcall))")]
            public delegate* stdcall<IRpcChannelBuffer3*, RPCOLEMESSAGE*, uint, uint*, int> Receive;

            [NativeTypeName("HRESULT (RPCOLEMESSAGE *) __attribute__((stdcall))")]
            public delegate* stdcall<IRpcChannelBuffer3*, RPCOLEMESSAGE*, int> Cancel;

            [NativeTypeName("HRESULT (RPCOLEMESSAGE *, const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IRpcChannelBuffer3*, RPCOLEMESSAGE*, Guid*, void**, int> GetCallContext;

            [NativeTypeName("HRESULT (RPCOLEMESSAGE *, DWORD *, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IRpcChannelBuffer3*, RPCOLEMESSAGE*, uint*, void**, int> GetDestCtxEx;

            [NativeTypeName("HRESULT (RPCOLEMESSAGE *, DWORD *) __attribute__((stdcall))")]
            public delegate* stdcall<IRpcChannelBuffer3*, RPCOLEMESSAGE*, uint*, int> GetState;

            [NativeTypeName("HRESULT (RPCOLEMESSAGE *, IAsyncManager *) __attribute__((stdcall))")]
            public delegate* stdcall<IRpcChannelBuffer3*, RPCOLEMESSAGE*, IAsyncManager*, int> RegisterAsync;
        }
    }
}
