// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("E982CE48-0B96-440C-BC37-0C869B27A29E")]
    public unsafe partial struct IUriBuilderFactory
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IUriBuilderFactory* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IUriBuilderFactory* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IUriBuilderFactory* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateIUriBuilder(IUriBuilderFactory* pThis, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD_PTR")] nuint dwReserved, [NativeTypeName("IUriBuilder **")] IUriBuilder** ppIUriBuilder);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateInitializedIUriBuilder(IUriBuilderFactory* pThis, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD_PTR")] nuint dwReserved, [NativeTypeName("IUriBuilder **")] IUriBuilder** ppIUriBuilder);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IUriBuilderFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IUriBuilderFactory*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IUriBuilderFactory*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateIUriBuilder([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD_PTR")] nuint dwReserved, [NativeTypeName("IUriBuilder **")] IUriBuilder** ppIUriBuilder)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateIUriBuilder>(lpVtbl->CreateIUriBuilder)((IUriBuilderFactory*)Unsafe.AsPointer(ref this), dwFlags, dwReserved, ppIUriBuilder);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateInitializedIUriBuilder([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD_PTR")] nuint dwReserved, [NativeTypeName("IUriBuilder **")] IUriBuilder** ppIUriBuilder)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateInitializedIUriBuilder>(lpVtbl->CreateInitializedIUriBuilder)((IUriBuilderFactory*)Unsafe.AsPointer(ref this), dwFlags, dwReserved, ppIUriBuilder);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (DWORD, DWORD_PTR, IUriBuilder **) __attribute__((stdcall))")]
            public IntPtr CreateIUriBuilder;

            [NativeTypeName("HRESULT (DWORD, DWORD_PTR, IUriBuilder **) __attribute__((stdcall))")]
            public IntPtr CreateInitializedIUriBuilder;
        }
    }
}
