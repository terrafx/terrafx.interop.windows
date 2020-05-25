// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3C613A02-34B2-44EA-9A7C-45AEA9C6FD6D")]
    public unsafe partial struct IWICColorContext
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IWICColorContext* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IWICColorContext* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IWICColorContext* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _InitializeFromFilename(IWICColorContext* pThis, [NativeTypeName("LPCWSTR")] ushort* wzFilename);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _InitializeFromMemory(IWICColorContext* pThis, [NativeTypeName("const BYTE *")] byte* pbBuffer, [NativeTypeName("UINT")] uint cbBufferSize);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _InitializeFromExifColorSpace(IWICColorContext* pThis, [NativeTypeName("UINT")] uint value);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetType(IWICColorContext* pThis, [NativeTypeName("WICColorContextType *")] WICColorContextType* pType);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetProfileBytes(IWICColorContext* pThis, [NativeTypeName("UINT")] uint cbBuffer, [NativeTypeName("BYTE *")] byte* pbBuffer, [NativeTypeName("UINT *")] uint* pcbActual);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetExifColorSpace(IWICColorContext* pThis, [NativeTypeName("UINT *")] uint* pValue);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IWICColorContext*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IWICColorContext*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IWICColorContext*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int InitializeFromFilename([NativeTypeName("LPCWSTR")] ushort* wzFilename)
        {
            return Marshal.GetDelegateForFunctionPointer<_InitializeFromFilename>(lpVtbl->InitializeFromFilename)((IWICColorContext*)Unsafe.AsPointer(ref this), wzFilename);
        }

        [return: NativeTypeName("HRESULT")]
        public int InitializeFromMemory([NativeTypeName("const BYTE *")] byte* pbBuffer, [NativeTypeName("UINT")] uint cbBufferSize)
        {
            return Marshal.GetDelegateForFunctionPointer<_InitializeFromMemory>(lpVtbl->InitializeFromMemory)((IWICColorContext*)Unsafe.AsPointer(ref this), pbBuffer, cbBufferSize);
        }

        [return: NativeTypeName("HRESULT")]
        public int InitializeFromExifColorSpace([NativeTypeName("UINT")] uint value)
        {
            return Marshal.GetDelegateForFunctionPointer<_InitializeFromExifColorSpace>(lpVtbl->InitializeFromExifColorSpace)((IWICColorContext*)Unsafe.AsPointer(ref this), value);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetType([NativeTypeName("WICColorContextType *")] WICColorContextType* pType)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetType>(lpVtbl->GetType)((IWICColorContext*)Unsafe.AsPointer(ref this), pType);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetProfileBytes([NativeTypeName("UINT")] uint cbBuffer, [NativeTypeName("BYTE *")] byte* pbBuffer, [NativeTypeName("UINT *")] uint* pcbActual)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetProfileBytes>(lpVtbl->GetProfileBytes)((IWICColorContext*)Unsafe.AsPointer(ref this), cbBuffer, pbBuffer, pcbActual);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetExifColorSpace([NativeTypeName("UINT *")] uint* pValue)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetExifColorSpace>(lpVtbl->GetExifColorSpace)((IWICColorContext*)Unsafe.AsPointer(ref this), pValue);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
            public IntPtr InitializeFromFilename;

            [NativeTypeName("HRESULT (const BYTE *, UINT) __attribute__((stdcall))")]
            public IntPtr InitializeFromMemory;

            [NativeTypeName("HRESULT (UINT) __attribute__((stdcall))")]
            public IntPtr InitializeFromExifColorSpace;

            [NativeTypeName("HRESULT (WICColorContextType *) __attribute__((stdcall))")]
            public new IntPtr GetType;

            [NativeTypeName("HRESULT (UINT, BYTE *, UINT *) __attribute__((stdcall))")]
            public IntPtr GetProfileBytes;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public IntPtr GetExifColorSpace;
        }
    }
}
