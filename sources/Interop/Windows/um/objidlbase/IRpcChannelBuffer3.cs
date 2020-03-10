// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdlbase.h in the Windows SDK for Windows 10.0.18362.0
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

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IRpcChannelBuffer3* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IRpcChannelBuffer3* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IRpcChannelBuffer3* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetBuffer(IRpcChannelBuffer3* pThis, [NativeTypeName("RPCOLEMESSAGE *")] RPCOLEMESSAGE* pMessage, [NativeTypeName("const IID &")] Guid* riid);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SendReceive(IRpcChannelBuffer3* pThis, [NativeTypeName("RPCOLEMESSAGE *")] RPCOLEMESSAGE* pMessage, [NativeTypeName("ULONG *")] uint* pStatus);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _FreeBuffer(IRpcChannelBuffer3* pThis, [NativeTypeName("RPCOLEMESSAGE *")] RPCOLEMESSAGE* pMessage);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetDestCtx(IRpcChannelBuffer3* pThis, [NativeTypeName("DWORD *")] uint* pdwDestContext, [NativeTypeName("void **")] void** ppvDestContext);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _IsConnected(IRpcChannelBuffer3* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetProtocolVersion(IRpcChannelBuffer3* pThis, [NativeTypeName("DWORD *")] uint* pdwVersion);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Send(IRpcChannelBuffer3* pThis, [NativeTypeName("RPCOLEMESSAGE *")] RPCOLEMESSAGE* pMsg, [NativeTypeName("ULONG *")] uint* pulStatus);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Receive(IRpcChannelBuffer3* pThis, [NativeTypeName("RPCOLEMESSAGE *")] RPCOLEMESSAGE* pMsg, [NativeTypeName("ULONG")] uint ulSize, [NativeTypeName("ULONG *")] uint* pulStatus);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Cancel(IRpcChannelBuffer3* pThis, [NativeTypeName("RPCOLEMESSAGE *")] RPCOLEMESSAGE* pMsg);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetCallContext(IRpcChannelBuffer3* pThis, [NativeTypeName("RPCOLEMESSAGE *")] RPCOLEMESSAGE* pMsg, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** pInterface);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetDestCtxEx(IRpcChannelBuffer3* pThis, [NativeTypeName("RPCOLEMESSAGE *")] RPCOLEMESSAGE* pMsg, [NativeTypeName("DWORD *")] uint* pdwDestContext, [NativeTypeName("void **")] void** ppvDestContext);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetState(IRpcChannelBuffer3* pThis, [NativeTypeName("RPCOLEMESSAGE *")] RPCOLEMESSAGE* pMsg, [NativeTypeName("DWORD *")] uint* pState);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _RegisterAsync(IRpcChannelBuffer3* pThis, [NativeTypeName("RPCOLEMESSAGE *")] RPCOLEMESSAGE* pMsg, [NativeTypeName("IAsyncManager *")] IAsyncManager* pAsyncMgr);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IRpcChannelBuffer3*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IRpcChannelBuffer3*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IRpcChannelBuffer3*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetBuffer([NativeTypeName("RPCOLEMESSAGE *")] RPCOLEMESSAGE* pMessage, [NativeTypeName("const IID &")] Guid* riid)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetBuffer>(lpVtbl->GetBuffer)((IRpcChannelBuffer3*)Unsafe.AsPointer(ref this), pMessage, riid);
        }

        [return: NativeTypeName("HRESULT")]
        public int SendReceive([NativeTypeName("RPCOLEMESSAGE *")] RPCOLEMESSAGE* pMessage, [NativeTypeName("ULONG *")] uint* pStatus)
        {
            return Marshal.GetDelegateForFunctionPointer<_SendReceive>(lpVtbl->SendReceive)((IRpcChannelBuffer3*)Unsafe.AsPointer(ref this), pMessage, pStatus);
        }

        [return: NativeTypeName("HRESULT")]
        public int FreeBuffer([NativeTypeName("RPCOLEMESSAGE *")] RPCOLEMESSAGE* pMessage)
        {
            return Marshal.GetDelegateForFunctionPointer<_FreeBuffer>(lpVtbl->FreeBuffer)((IRpcChannelBuffer3*)Unsafe.AsPointer(ref this), pMessage);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDestCtx([NativeTypeName("DWORD *")] uint* pdwDestContext, [NativeTypeName("void **")] void** ppvDestContext)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetDestCtx>(lpVtbl->GetDestCtx)((IRpcChannelBuffer3*)Unsafe.AsPointer(ref this), pdwDestContext, ppvDestContext);
        }

        [return: NativeTypeName("HRESULT")]
        public int IsConnected()
        {
            return Marshal.GetDelegateForFunctionPointer<_IsConnected>(lpVtbl->IsConnected)((IRpcChannelBuffer3*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetProtocolVersion([NativeTypeName("DWORD *")] uint* pdwVersion)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetProtocolVersion>(lpVtbl->GetProtocolVersion)((IRpcChannelBuffer3*)Unsafe.AsPointer(ref this), pdwVersion);
        }

        [return: NativeTypeName("HRESULT")]
        public int Send([NativeTypeName("RPCOLEMESSAGE *")] RPCOLEMESSAGE* pMsg, [NativeTypeName("ULONG *")] uint* pulStatus)
        {
            return Marshal.GetDelegateForFunctionPointer<_Send>(lpVtbl->Send)((IRpcChannelBuffer3*)Unsafe.AsPointer(ref this), pMsg, pulStatus);
        }

        [return: NativeTypeName("HRESULT")]
        public int Receive([NativeTypeName("RPCOLEMESSAGE *")] RPCOLEMESSAGE* pMsg, [NativeTypeName("ULONG")] uint ulSize, [NativeTypeName("ULONG *")] uint* pulStatus)
        {
            return Marshal.GetDelegateForFunctionPointer<_Receive>(lpVtbl->Receive)((IRpcChannelBuffer3*)Unsafe.AsPointer(ref this), pMsg, ulSize, pulStatus);
        }

        [return: NativeTypeName("HRESULT")]
        public int Cancel([NativeTypeName("RPCOLEMESSAGE *")] RPCOLEMESSAGE* pMsg)
        {
            return Marshal.GetDelegateForFunctionPointer<_Cancel>(lpVtbl->Cancel)((IRpcChannelBuffer3*)Unsafe.AsPointer(ref this), pMsg);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCallContext([NativeTypeName("RPCOLEMESSAGE *")] RPCOLEMESSAGE* pMsg, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** pInterface)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetCallContext>(lpVtbl->GetCallContext)((IRpcChannelBuffer3*)Unsafe.AsPointer(ref this), pMsg, riid, pInterface);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDestCtxEx([NativeTypeName("RPCOLEMESSAGE *")] RPCOLEMESSAGE* pMsg, [NativeTypeName("DWORD *")] uint* pdwDestContext, [NativeTypeName("void **")] void** ppvDestContext)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetDestCtxEx>(lpVtbl->GetDestCtxEx)((IRpcChannelBuffer3*)Unsafe.AsPointer(ref this), pMsg, pdwDestContext, ppvDestContext);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetState([NativeTypeName("RPCOLEMESSAGE *")] RPCOLEMESSAGE* pMsg, [NativeTypeName("DWORD *")] uint* pState)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetState>(lpVtbl->GetState)((IRpcChannelBuffer3*)Unsafe.AsPointer(ref this), pMsg, pState);
        }

        [return: NativeTypeName("HRESULT")]
        public int RegisterAsync([NativeTypeName("RPCOLEMESSAGE *")] RPCOLEMESSAGE* pMsg, [NativeTypeName("IAsyncManager *")] IAsyncManager* pAsyncMgr)
        {
            return Marshal.GetDelegateForFunctionPointer<_RegisterAsync>(lpVtbl->RegisterAsync)((IRpcChannelBuffer3*)Unsafe.AsPointer(ref this), pMsg, pAsyncMgr);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (RPCOLEMESSAGE *, const IID &) __attribute__((stdcall))")]
            public IntPtr GetBuffer;

            [NativeTypeName("HRESULT (RPCOLEMESSAGE *, ULONG *) __attribute__((stdcall))")]
            public IntPtr SendReceive;

            [NativeTypeName("HRESULT (RPCOLEMESSAGE *) __attribute__((stdcall))")]
            public IntPtr FreeBuffer;

            [NativeTypeName("HRESULT (DWORD *, void **) __attribute__((stdcall))")]
            public IntPtr GetDestCtx;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public IntPtr IsConnected;

            [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
            public IntPtr GetProtocolVersion;

            [NativeTypeName("HRESULT (RPCOLEMESSAGE *, ULONG *) __attribute__((stdcall))")]
            public IntPtr Send;

            [NativeTypeName("HRESULT (RPCOLEMESSAGE *, ULONG, ULONG *) __attribute__((stdcall))")]
            public IntPtr Receive;

            [NativeTypeName("HRESULT (RPCOLEMESSAGE *) __attribute__((stdcall))")]
            public IntPtr Cancel;

            [NativeTypeName("HRESULT (RPCOLEMESSAGE *, const IID &, void **) __attribute__((stdcall))")]
            public IntPtr GetCallContext;

            [NativeTypeName("HRESULT (RPCOLEMESSAGE *, DWORD *, void **) __attribute__((stdcall))")]
            public IntPtr GetDestCtxEx;

            [NativeTypeName("HRESULT (RPCOLEMESSAGE *, DWORD *) __attribute__((stdcall))")]
            public IntPtr GetState;

            [NativeTypeName("HRESULT (RPCOLEMESSAGE *, IAsyncManager *) __attribute__((stdcall))")]
            public IntPtr RegisterAsync;
        }
    }
}
