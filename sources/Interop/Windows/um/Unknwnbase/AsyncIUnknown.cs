// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Unknwnbase.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("000E0000-0000-0000-C000-000000000046")]
    public unsafe partial struct AsyncIUnknown
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(AsyncIUnknown* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(AsyncIUnknown* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(AsyncIUnknown* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Begin_QueryInterface(AsyncIUnknown* pThis, [NativeTypeName("const IID &")] Guid* riid);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Finish_QueryInterface(AsyncIUnknown* pThis, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Begin_AddRef(AsyncIUnknown* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Finish_AddRef(AsyncIUnknown* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Begin_Release(AsyncIUnknown* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Finish_Release(AsyncIUnknown* pThis);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((AsyncIUnknown*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((AsyncIUnknown*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((AsyncIUnknown*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Begin_QueryInterface([NativeTypeName("const IID &")] Guid* riid)
        {
            return Marshal.GetDelegateForFunctionPointer<_Begin_QueryInterface>(lpVtbl->Begin_QueryInterface)((AsyncIUnknown*)Unsafe.AsPointer(ref this), riid);
        }

        [return: NativeTypeName("HRESULT")]
        public int Finish_QueryInterface([NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_Finish_QueryInterface>(lpVtbl->Finish_QueryInterface)((AsyncIUnknown*)Unsafe.AsPointer(ref this), ppvObject);
        }

        [return: NativeTypeName("HRESULT")]
        public int Begin_AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_Begin_AddRef>(lpVtbl->Begin_AddRef)((AsyncIUnknown*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Finish_AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_Finish_AddRef>(lpVtbl->Finish_AddRef)((AsyncIUnknown*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Begin_Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Begin_Release>(lpVtbl->Begin_Release)((AsyncIUnknown*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Finish_Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Finish_Release>(lpVtbl->Finish_Release)((AsyncIUnknown*)Unsafe.AsPointer(ref this));
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (const IID &) __attribute__((stdcall))")]
            public IntPtr Begin_QueryInterface;

            [NativeTypeName("HRESULT (void **) __attribute__((stdcall))")]
            public IntPtr Finish_QueryInterface;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public IntPtr Begin_AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Finish_AddRef;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public IntPtr Begin_Release;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Finish_Release;
        }
    }
}
