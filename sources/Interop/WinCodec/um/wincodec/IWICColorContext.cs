// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\wincodec.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3C613A02-34B2-44EA-9A7C-45AEA9C6FD6D")]
    public unsafe partial struct IWICColorContext
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IWICColorContext* This, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IWICColorContext* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IWICColorContext* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _InitializeFromFilename(IWICColorContext* This, [NativeTypeName("LPCWSTR")] ushort* wzFilename);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _InitializeFromMemory(IWICColorContext* This, [NativeTypeName("BYTE[]")] byte* pbBuffer, [NativeTypeName("UINT")] uint cbBufferSize);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _InitializeFromExifColorSpace(IWICColorContext* This, [NativeTypeName("UINT")] uint value);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int __GetType(IWICColorContext* This, WICColorContextType* pType);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetProfileBytes(IWICColorContext* This, [NativeTypeName("UINT")] uint cbBuffer, [Optional, NativeTypeName("BYTE[]")] byte* pbBuffer, [NativeTypeName("UINT")] uint* pcbActual);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetExifColorSpace(IWICColorContext* This, [NativeTypeName("UINT")] uint* pValue);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
        {
            fixed (IWICColorContext* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(This, riid, ppvObject);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (IWICColorContext* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(This);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IWICColorContext* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int InitializeFromFilename([NativeTypeName("LPCWSTR")] ushort* wzFilename)
        {
            fixed (IWICColorContext* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_InitializeFromFilename>(lpVtbl->InitializeFromFilename)(This, wzFilename);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int InitializeFromMemory([NativeTypeName("BYTE[]")] byte* pbBuffer, [NativeTypeName("UINT")] uint cbBufferSize)
        {
            fixed (IWICColorContext* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_InitializeFromMemory>(lpVtbl->InitializeFromMemory)(This, pbBuffer, cbBufferSize);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int InitializeFromExifColorSpace([NativeTypeName("UINT")] uint value)
        {
            fixed (IWICColorContext* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_InitializeFromExifColorSpace>(lpVtbl->InitializeFromExifColorSpace)(This, value);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int _GetType(WICColorContextType* pType)
        {
            fixed (IWICColorContext* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<__GetType>(lpVtbl->_GetType)(This, pType);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetProfileBytes([NativeTypeName("UINT")] uint cbBuffer, [Optional, NativeTypeName("BYTE[]")] byte* pbBuffer, [NativeTypeName("UINT")] uint* pcbActual)
        {
            fixed (IWICColorContext* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetProfileBytes>(lpVtbl->GetProfileBytes)(This, cbBuffer, pbBuffer, pcbActual);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetExifColorSpace([NativeTypeName("UINT")] uint* pValue)
        {
            fixed (IWICColorContext* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetExifColorSpace>(lpVtbl->GetExifColorSpace)(This, pValue);
            }
        }

        public partial struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr InitializeFromFilename;

            public IntPtr InitializeFromMemory;

            public IntPtr InitializeFromExifColorSpace;

            public IntPtr _GetType;

            public IntPtr GetProfileBytes;

            public IntPtr GetExifColorSpace;
        }
    }
}
