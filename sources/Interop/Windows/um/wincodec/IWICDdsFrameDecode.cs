// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\wincodec.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3D4C0C61-18A4-41E4-BD80-481A4FC9F464")]
    public unsafe struct IWICDdsFrameDecode
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(
            [In] IWICDdsFrameDecode* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(
            [In] IWICDdsFrameDecode* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(
            [In] IWICDdsFrameDecode* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetSizeInBlocks(
            [In] IWICDdsFrameDecode* This,
            [Out, NativeTypeName("UINT")] uint* pWidthInBlocks,
            [Out, NativeTypeName("UINT")] uint* pHeightInBlocks
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFormatInfo(
            [In] IWICDdsFrameDecode* This,
            [Out] WICDdsFormatInfo* pFormatInfo
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CopyBlocks(
            [In] IWICDdsFrameDecode* This,
            [In] WICRect* prcBoundsInBlocks,
            [In, NativeTypeName("UINT")] uint cbStride,
            [In, NativeTypeName("UINT")] uint cbBufferSize,
            [Out, NativeTypeName("BYTE[]")] byte* pbBuffer
        );

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (IWICDdsFrameDecode* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(
                    This,
                    riid,
                    ppvObject
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (IWICDdsFrameDecode* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IWICDdsFrameDecode* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(
                    This
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSizeInBlocks(
            [Out, NativeTypeName("UINT")] uint* pWidthInBlocks,
            [Out, NativeTypeName("UINT")] uint* pHeightInBlocks
        )
        {
            fixed (IWICDdsFrameDecode* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetSizeInBlocks>(lpVtbl->GetSizeInBlocks)(
                    This,
                    pWidthInBlocks,
                    pHeightInBlocks
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFormatInfo(
            [Out] WICDdsFormatInfo* pFormatInfo
        )
        {
            fixed (IWICDdsFrameDecode* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetFormatInfo>(lpVtbl->GetFormatInfo)(
                    This,
                    pFormatInfo
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CopyBlocks(
            [In] WICRect* prcBoundsInBlocks,
            [In, NativeTypeName("UINT")] uint cbStride,
            [In, NativeTypeName("UINT")] uint cbBufferSize,
            [Out, NativeTypeName("BYTE[]")] byte* pbBuffer
        )
        {
            fixed (IWICDdsFrameDecode* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CopyBlocks>(lpVtbl->CopyBlocks)(
                    This,
                    prcBoundsInBlocks,
                    cbStride,
                    cbBufferSize,
                    pbBuffer
                );
            }
        }

        public struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr GetSizeInBlocks;

            public IntPtr GetFormatInfo;

            public IntPtr CopyBlocks;
        }
    }
}
