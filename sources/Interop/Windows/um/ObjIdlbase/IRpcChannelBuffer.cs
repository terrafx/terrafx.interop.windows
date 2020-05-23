// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdlbase.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("D5F56B60-593B-101A-B569-08002B2DBF7A")]
    public unsafe partial struct IRpcChannelBuffer
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IRpcChannelBuffer* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IRpcChannelBuffer* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IRpcChannelBuffer* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetBuffer(IRpcChannelBuffer* pThis, [NativeTypeName("RPCOLEMESSAGE *")] RPCOLEMESSAGE* pMessage, [NativeTypeName("const IID &")] Guid* riid);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SendReceive(IRpcChannelBuffer* pThis, [NativeTypeName("RPCOLEMESSAGE *")] RPCOLEMESSAGE* pMessage, [NativeTypeName("ULONG *")] uint* pStatus);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _FreeBuffer(IRpcChannelBuffer* pThis, [NativeTypeName("RPCOLEMESSAGE *")] RPCOLEMESSAGE* pMessage);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetDestCtx(IRpcChannelBuffer* pThis, [NativeTypeName("DWORD *")] uint* pdwDestContext, [NativeTypeName("void **")] void** ppvDestContext);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _IsConnected(IRpcChannelBuffer* pThis);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IRpcChannelBuffer*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IRpcChannelBuffer*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IRpcChannelBuffer*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetBuffer([NativeTypeName("RPCOLEMESSAGE *")] RPCOLEMESSAGE* pMessage, [NativeTypeName("const IID &")] Guid* riid)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetBuffer>(lpVtbl->GetBuffer)((IRpcChannelBuffer*)Unsafe.AsPointer(ref this), pMessage, riid);
        }

        [return: NativeTypeName("HRESULT")]
        public int SendReceive([NativeTypeName("RPCOLEMESSAGE *")] RPCOLEMESSAGE* pMessage, [NativeTypeName("ULONG *")] uint* pStatus)
        {
            return Marshal.GetDelegateForFunctionPointer<_SendReceive>(lpVtbl->SendReceive)((IRpcChannelBuffer*)Unsafe.AsPointer(ref this), pMessage, pStatus);
        }

        [return: NativeTypeName("HRESULT")]
        public int FreeBuffer([NativeTypeName("RPCOLEMESSAGE *")] RPCOLEMESSAGE* pMessage)
        {
            return Marshal.GetDelegateForFunctionPointer<_FreeBuffer>(lpVtbl->FreeBuffer)((IRpcChannelBuffer*)Unsafe.AsPointer(ref this), pMessage);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDestCtx([NativeTypeName("DWORD *")] uint* pdwDestContext, [NativeTypeName("void **")] void** ppvDestContext)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetDestCtx>(lpVtbl->GetDestCtx)((IRpcChannelBuffer*)Unsafe.AsPointer(ref this), pdwDestContext, ppvDestContext);
        }

        [return: NativeTypeName("HRESULT")]
        public int IsConnected()
        {
            return Marshal.GetDelegateForFunctionPointer<_IsConnected>(lpVtbl->IsConnected)((IRpcChannelBuffer*)Unsafe.AsPointer(ref this));
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
        }
    }
}
