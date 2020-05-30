// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/dxc/dxcapi.h in the microsoft/DirectXCompiler commit e0cde072b09b51506c0460697b2695d6cccca59d
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A3F84EAB-0FAA-497E-A39C-EE6ED60B2D84")]
    public unsafe partial struct IDxcBlobUtf16
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IDxcBlobUtf16* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IDxcBlobUtf16* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IDxcBlobUtf16* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("LPVOID")]
        public delegate void* _GetBufferPointer(IDxcBlobUtf16* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("SIZE_T")]
        public delegate nuint _GetBufferSize(IDxcBlobUtf16* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetEncoding(IDxcBlobUtf16* pThis, [NativeTypeName("BOOL *")] int* pKnown, [NativeTypeName("UINT32 *")] uint* pCodePage);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("LPCWSTR")]
        public delegate ushort* _GetStringPointer(IDxcBlobUtf16* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("SIZE_T")]
        public delegate nuint _GetStringLength(IDxcBlobUtf16* pThis);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IDxcBlobUtf16*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IDxcBlobUtf16*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IDxcBlobUtf16*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("LPVOID")]
        public void* GetBufferPointer()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetBufferPointer>(lpVtbl->GetBufferPointer)((IDxcBlobUtf16*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("SIZE_T")]
        public nuint GetBufferSize()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetBufferSize>(lpVtbl->GetBufferSize)((IDxcBlobUtf16*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetEncoding([NativeTypeName("BOOL *")] int* pKnown, [NativeTypeName("UINT32 *")] uint* pCodePage)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetEncoding>(lpVtbl->GetEncoding)((IDxcBlobUtf16*)Unsafe.AsPointer(ref this), pKnown, pCodePage);
        }

        [return: NativeTypeName("LPCWSTR")]
        public ushort* GetStringPointer()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetStringPointer>(lpVtbl->GetStringPointer)((IDxcBlobUtf16*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("SIZE_T")]
        public nuint GetStringLength()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetStringLength>(lpVtbl->GetStringLength)((IDxcBlobUtf16*)Unsafe.AsPointer(ref this));
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

            [NativeTypeName("LPCWSTR () __attribute__((stdcall))")]
            public IntPtr GetStringPointer;

            [NativeTypeName("SIZE_T () __attribute__((stdcall))")]
            public IntPtr GetStringLength;
        }
    }
}
