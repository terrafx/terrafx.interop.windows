// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/dxc/dxcapi.h in the microsoft/DirectXCompiler commit e0cde072b09b51506c0460697b2695d6cccca59d
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3DA636C9-BA71-4024-A301-30CBF125305B")]
    public unsafe partial struct IDxcBlobUtf8
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IDxcBlobUtf8* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IDxcBlobUtf8* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IDxcBlobUtf8* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("LPVOID")]
        public delegate void* _GetBufferPointer(IDxcBlobUtf8* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("SIZE_T")]
        public delegate nuint _GetBufferSize(IDxcBlobUtf8* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetEncoding(IDxcBlobUtf8* pThis, [NativeTypeName("BOOL *")] int* pKnown, [NativeTypeName("UINT32 *")] uint* pCodePage);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("LPCSTR")]
        public delegate sbyte* _GetStringPointer(IDxcBlobUtf8* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("SIZE_T")]
        public delegate nuint _GetStringLength(IDxcBlobUtf8* pThis);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IDxcBlobUtf8*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IDxcBlobUtf8*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IDxcBlobUtf8*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("LPVOID")]
        public void* GetBufferPointer()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetBufferPointer>(lpVtbl->GetBufferPointer)((IDxcBlobUtf8*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("SIZE_T")]
        public nuint GetBufferSize()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetBufferSize>(lpVtbl->GetBufferSize)((IDxcBlobUtf8*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetEncoding([NativeTypeName("BOOL *")] int* pKnown, [NativeTypeName("UINT32 *")] uint* pCodePage)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetEncoding>(lpVtbl->GetEncoding)((IDxcBlobUtf8*)Unsafe.AsPointer(ref this), pKnown, pCodePage);
        }

        [return: NativeTypeName("LPCSTR")]
        public sbyte* GetStringPointer()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetStringPointer>(lpVtbl->GetStringPointer)((IDxcBlobUtf8*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("SIZE_T")]
        public nuint GetStringLength()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetStringLength>(lpVtbl->GetStringLength)((IDxcBlobUtf8*)Unsafe.AsPointer(ref this));
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

            [NativeTypeName("LPCSTR () __attribute__((stdcall))")]
            public IntPtr GetStringPointer;

            [NativeTypeName("SIZE_T () __attribute__((stdcall))")]
            public IntPtr GetStringLength;
        }
    }
}
