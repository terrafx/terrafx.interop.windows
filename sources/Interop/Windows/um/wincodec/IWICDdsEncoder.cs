// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\wincodec.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("5CACDB4C-407E-41B3-B936-D0F010CD6732")]
    public unsafe struct IWICDdsEncoder
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IWICDdsEncoder* This, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IWICDdsEncoder* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IWICDdsEncoder* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetParameters(IWICDdsEncoder* This, WICDdsParameters* pParameters);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetParameters(IWICDdsEncoder* This, WICDdsParameters* pParameters);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateNewFrame(IWICDdsEncoder* This, IWICBitmapFrameEncode** ppIFrameEncode = null, [NativeTypeName("UINT")] uint* pArrayIndex = null, [NativeTypeName("UINT")] uint* pMipLevel = null, [NativeTypeName("UINT")] uint* pSliceIndex = null);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
        {
            fixed (IWICDdsEncoder* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(This, riid, ppvObject);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (IWICDdsEncoder* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(This);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IWICDdsEncoder* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetParameters(WICDdsParameters* pParameters)
        {
            fixed (IWICDdsEncoder* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetParameters>(lpVtbl->SetParameters)(This, pParameters);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetParameters(WICDdsParameters* pParameters)
        {
            fixed (IWICDdsEncoder* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetParameters>(lpVtbl->GetParameters)(This, pParameters);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateNewFrame(IWICBitmapFrameEncode** ppIFrameEncode = null, [NativeTypeName("UINT")] uint* pArrayIndex = null, [NativeTypeName("UINT")] uint* pMipLevel = null, [NativeTypeName("UINT")] uint* pSliceIndex = null)
        {
            fixed (IWICDdsEncoder* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateNewFrame>(lpVtbl->CreateNewFrame)(This, ppIFrameEncode, pArrayIndex, pMipLevel, pSliceIndex);
            }
        }

        public struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr SetParameters;

            public IntPtr GetParameters;

            public IntPtr CreateNewFrame;
        }
    }
}
