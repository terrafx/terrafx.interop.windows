// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dxcapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("8BA5FB08-5195-40e2-AC58-0D989C3A0102")]
    public unsafe partial struct IDxcBlob
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IDxcBlob* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IDxcBlob* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IDxcBlob* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("LPVOID")]
        public delegate void* _GetBufferPointer(IDxcBlob* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("SIZE_T")]
        public delegate nuint _GetBufferSize(IDxcBlob* pThis);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IDxcBlob*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IDxcBlob*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IDxcBlob*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("LPVOID")]
        public void* GetBufferPointer()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetBufferPointer>(lpVtbl->GetBufferPointer)((IDxcBlob*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("SIZE_T")]
        public nuint GetBufferSize()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetBufferSize>(lpVtbl->GetBufferSize)((IDxcBlob*)Unsafe.AsPointer(ref this));
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("LPVOID () __attribute__((stdcall))")]
            public IntPtr GetBufferPointer;

            [NativeTypeName("SIZE_T () __attribute__((stdcall))")]
            public IntPtr GetBufferSize;
        }
    }
}
