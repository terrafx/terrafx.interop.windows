// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdlbase.h in the Windows SDK for Windows 10.0.18362.0
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

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IRpcProxyBuffer* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IRpcProxyBuffer* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IRpcProxyBuffer* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Connect(IRpcProxyBuffer* pThis, [NativeTypeName("IRpcChannelBuffer *")] IRpcChannelBuffer* pRpcChannelBuffer);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _Disconnect(IRpcProxyBuffer* pThis);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IRpcProxyBuffer*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IRpcProxyBuffer*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IRpcProxyBuffer*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Connect([NativeTypeName("IRpcChannelBuffer *")] IRpcChannelBuffer* pRpcChannelBuffer)
        {
            return Marshal.GetDelegateForFunctionPointer<_Connect>(lpVtbl->Connect)((IRpcProxyBuffer*)Unsafe.AsPointer(ref this), pRpcChannelBuffer);
        }

        public void Disconnect()
        {
            Marshal.GetDelegateForFunctionPointer<_Disconnect>(lpVtbl->Disconnect)((IRpcProxyBuffer*)Unsafe.AsPointer(ref this));
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (IRpcChannelBuffer *) __attribute__((stdcall))")]
            public IntPtr Connect;

            [NativeTypeName("void () __attribute__((stdcall))")]
            public IntPtr Disconnect;
        }
    }
}
