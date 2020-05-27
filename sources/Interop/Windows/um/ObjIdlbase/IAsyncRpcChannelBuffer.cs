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

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IAsyncRpcChannelBuffer* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IAsyncRpcChannelBuffer* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IAsyncRpcChannelBuffer* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetBuffer(IAsyncRpcChannelBuffer* pThis, [NativeTypeName("RPCOLEMESSAGE *")] RPCOLEMESSAGE* pMessage, [NativeTypeName("const IID &")] Guid* riid);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SendReceive(IAsyncRpcChannelBuffer* pThis, [NativeTypeName("RPCOLEMESSAGE *")] RPCOLEMESSAGE* pMessage, [NativeTypeName("ULONG *")] uint* pStatus);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _FreeBuffer(IAsyncRpcChannelBuffer* pThis, [NativeTypeName("RPCOLEMESSAGE *")] RPCOLEMESSAGE* pMessage);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetDestCtx(IAsyncRpcChannelBuffer* pThis, [NativeTypeName("DWORD *")] uint* pdwDestContext, [NativeTypeName("void **")] void** ppvDestContext);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _IsConnected(IAsyncRpcChannelBuffer* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetProtocolVersion(IAsyncRpcChannelBuffer* pThis, [NativeTypeName("DWORD *")] uint* pdwVersion);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Send(IAsyncRpcChannelBuffer* pThis, [NativeTypeName("RPCOLEMESSAGE *")] RPCOLEMESSAGE* pMsg, [NativeTypeName("ISynchronize *")] ISynchronize* pSync, [NativeTypeName("ULONG *")] uint* pulStatus);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Receive(IAsyncRpcChannelBuffer* pThis, [NativeTypeName("RPCOLEMESSAGE *")] RPCOLEMESSAGE* pMsg, [NativeTypeName("ULONG *")] uint* pulStatus);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetDestCtxEx(IAsyncRpcChannelBuffer* pThis, [NativeTypeName("RPCOLEMESSAGE *")] RPCOLEMESSAGE* pMsg, [NativeTypeName("DWORD *")] uint* pdwDestContext, [NativeTypeName("void **")] void** ppvDestContext);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IAsyncRpcChannelBuffer*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IAsyncRpcChannelBuffer*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IAsyncRpcChannelBuffer*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetBuffer([NativeTypeName("RPCOLEMESSAGE *")] RPCOLEMESSAGE* pMessage, [NativeTypeName("const IID &")] Guid* riid)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetBuffer>(lpVtbl->GetBuffer)((IAsyncRpcChannelBuffer*)Unsafe.AsPointer(ref this), pMessage, riid);
        }

        [return: NativeTypeName("HRESULT")]
        public int SendReceive([NativeTypeName("RPCOLEMESSAGE *")] RPCOLEMESSAGE* pMessage, [NativeTypeName("ULONG *")] uint* pStatus)
        {
            return Marshal.GetDelegateForFunctionPointer<_SendReceive>(lpVtbl->SendReceive)((IAsyncRpcChannelBuffer*)Unsafe.AsPointer(ref this), pMessage, pStatus);
        }

        [return: NativeTypeName("HRESULT")]
        public int FreeBuffer([NativeTypeName("RPCOLEMESSAGE *")] RPCOLEMESSAGE* pMessage)
        {
            return Marshal.GetDelegateForFunctionPointer<_FreeBuffer>(lpVtbl->FreeBuffer)((IAsyncRpcChannelBuffer*)Unsafe.AsPointer(ref this), pMessage);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDestCtx([NativeTypeName("DWORD *")] uint* pdwDestContext, [NativeTypeName("void **")] void** ppvDestContext)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetDestCtx>(lpVtbl->GetDestCtx)((IAsyncRpcChannelBuffer*)Unsafe.AsPointer(ref this), pdwDestContext, ppvDestContext);
        }

        [return: NativeTypeName("HRESULT")]
        public int IsConnected()
        {
            return Marshal.GetDelegateForFunctionPointer<_IsConnected>(lpVtbl->IsConnected)((IAsyncRpcChannelBuffer*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetProtocolVersion([NativeTypeName("DWORD *")] uint* pdwVersion)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetProtocolVersion>(lpVtbl->GetProtocolVersion)((IAsyncRpcChannelBuffer*)Unsafe.AsPointer(ref this), pdwVersion);
        }

        [return: NativeTypeName("HRESULT")]
        public int Send([NativeTypeName("RPCOLEMESSAGE *")] RPCOLEMESSAGE* pMsg, [NativeTypeName("ISynchronize *")] ISynchronize* pSync, [NativeTypeName("ULONG *")] uint* pulStatus)
        {
            return Marshal.GetDelegateForFunctionPointer<_Send>(lpVtbl->Send)((IAsyncRpcChannelBuffer*)Unsafe.AsPointer(ref this), pMsg, pSync, pulStatus);
        }

        [return: NativeTypeName("HRESULT")]
        public int Receive([NativeTypeName("RPCOLEMESSAGE *")] RPCOLEMESSAGE* pMsg, [NativeTypeName("ULONG *")] uint* pulStatus)
        {
            return Marshal.GetDelegateForFunctionPointer<_Receive>(lpVtbl->Receive)((IAsyncRpcChannelBuffer*)Unsafe.AsPointer(ref this), pMsg, pulStatus);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDestCtxEx([NativeTypeName("RPCOLEMESSAGE *")] RPCOLEMESSAGE* pMsg, [NativeTypeName("DWORD *")] uint* pdwDestContext, [NativeTypeName("void **")] void** ppvDestContext)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetDestCtxEx>(lpVtbl->GetDestCtxEx)((IAsyncRpcChannelBuffer*)Unsafe.AsPointer(ref this), pMsg, pdwDestContext, ppvDestContext);
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

            [NativeTypeName("HRESULT (RPCOLEMESSAGE *, ISynchronize *, ULONG *) __attribute__((stdcall))")]
            public IntPtr Send;

            [NativeTypeName("HRESULT (RPCOLEMESSAGE *, ULONG *) __attribute__((stdcall))")]
            public IntPtr Receive;

            [NativeTypeName("HRESULT (RPCOLEMESSAGE *, DWORD *, void **) __attribute__((stdcall))")]
            public IntPtr GetDestCtxEx;
        }
    }
}
