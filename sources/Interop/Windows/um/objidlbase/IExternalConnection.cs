// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdlbase.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00000019-0000-0000-C000-000000000046")]
    public unsafe partial struct IExternalConnection
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IExternalConnection* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IExternalConnection* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IExternalConnection* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("DWORD")]
        public delegate uint _AddConnection(IExternalConnection* pThis, [NativeTypeName("DWORD")] uint extconn, [NativeTypeName("DWORD")] uint reserved);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("DWORD")]
        public delegate uint _ReleaseConnection(IExternalConnection* pThis, [NativeTypeName("DWORD")] uint extconn, [NativeTypeName("DWORD")] uint reserved, [NativeTypeName("BOOL")] int fLastReleaseCloses);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IExternalConnection*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IExternalConnection*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IExternalConnection*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("DWORD")]
        public uint AddConnection([NativeTypeName("DWORD")] uint extconn, [NativeTypeName("DWORD")] uint reserved)
        {
            return Marshal.GetDelegateForFunctionPointer<_AddConnection>(lpVtbl->AddConnection)((IExternalConnection*)Unsafe.AsPointer(ref this), extconn, reserved);
        }

        [return: NativeTypeName("DWORD")]
        public uint ReleaseConnection([NativeTypeName("DWORD")] uint extconn, [NativeTypeName("DWORD")] uint reserved, [NativeTypeName("BOOL")] int fLastReleaseCloses)
        {
            return Marshal.GetDelegateForFunctionPointer<_ReleaseConnection>(lpVtbl->ReleaseConnection)((IExternalConnection*)Unsafe.AsPointer(ref this), extconn, reserved, fLastReleaseCloses);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("DWORD (DWORD, DWORD) __attribute__((stdcall))")]
            public IntPtr AddConnection;

            [NativeTypeName("DWORD (DWORD, DWORD, BOOL) __attribute__((stdcall))")]
            public IntPtr ReleaseConnection;
        }
    }
}
