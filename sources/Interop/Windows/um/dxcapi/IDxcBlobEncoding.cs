// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from DirectXShaderCompiler, include/dxc/dxcapi.h, at commit d356a8bc546da38612cac13d1e643de17a0ba38f
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct IDxcBlobEncoding
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IDxcBlobEncoding* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IDxcBlobEncoding* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IDxcBlobEncoding* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("LPVOID")]
        public delegate void* _GetBufferPointer(IDxcBlobEncoding* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("SIZE_T")]
        public delegate uint _GetBufferSize(IDxcBlobEncoding* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetEncoding(IDxcBlobEncoding* pThis, [NativeTypeName("BOOL *")] int* pKnown, [NativeTypeName("UINT32 *")] uint* pCodePage);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IDxcBlobEncoding*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IDxcBlobEncoding*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IDxcBlobEncoding*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("LPVOID")]
        public void* GetBufferPointer()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetBufferPointer>(lpVtbl->GetBufferPointer)((IDxcBlobEncoding*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("SIZE_T")]
        public uint GetBufferSize()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetBufferSize>(lpVtbl->GetBufferSize)((IDxcBlobEncoding*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetEncoding([NativeTypeName("BOOL *")] int* pKnown, [NativeTypeName("UINT32 *")] uint* pCodePage)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetEncoding>(lpVtbl->GetEncoding)((IDxcBlobEncoding*)Unsafe.AsPointer(ref this), pKnown, pCodePage);
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

            [NativeTypeName("HRESULT (BOOL *, UINT32 *) __attribute__((stdcall))")]
            public IntPtr GetEncoding;
        }
    }
}
