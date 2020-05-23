// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdlbase.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("000E0020-0000-0000-C000-000000000046")]
    public unsafe partial struct AsyncIMultiQI
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(AsyncIMultiQI* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(AsyncIMultiQI* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(AsyncIMultiQI* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Begin_QueryMultipleInterfaces(AsyncIMultiQI* pThis, [NativeTypeName("ULONG")] uint cMQIs, [NativeTypeName("MULTI_QI *")] MULTI_QI* pMQIs);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Finish_QueryMultipleInterfaces(AsyncIMultiQI* pThis, [NativeTypeName("MULTI_QI *")] MULTI_QI* pMQIs);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((AsyncIMultiQI*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((AsyncIMultiQI*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((AsyncIMultiQI*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Begin_QueryMultipleInterfaces([NativeTypeName("ULONG")] uint cMQIs, [NativeTypeName("MULTI_QI *")] MULTI_QI* pMQIs)
        {
            return Marshal.GetDelegateForFunctionPointer<_Begin_QueryMultipleInterfaces>(lpVtbl->Begin_QueryMultipleInterfaces)((AsyncIMultiQI*)Unsafe.AsPointer(ref this), cMQIs, pMQIs);
        }

        [return: NativeTypeName("HRESULT")]
        public int Finish_QueryMultipleInterfaces([NativeTypeName("MULTI_QI *")] MULTI_QI* pMQIs)
        {
            return Marshal.GetDelegateForFunctionPointer<_Finish_QueryMultipleInterfaces>(lpVtbl->Finish_QueryMultipleInterfaces)((AsyncIMultiQI*)Unsafe.AsPointer(ref this), pMQIs);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (ULONG, MULTI_QI *) __attribute__((stdcall))")]
            public IntPtr Begin_QueryMultipleInterfaces;

            [NativeTypeName("HRESULT (MULTI_QI *) __attribute__((stdcall))")]
            public IntPtr Finish_QueryMultipleInterfaces;
        }
    }
}
