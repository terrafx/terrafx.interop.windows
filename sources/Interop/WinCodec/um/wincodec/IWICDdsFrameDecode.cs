// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\wincodec.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3D4C0C61-18A4-41E4-BD80-481A4FC9F464")]
    public unsafe partial struct IWICDdsFrameDecode
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IWICDdsFrameDecode* This, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IWICDdsFrameDecode* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IWICDdsFrameDecode* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetSizeInBlocks(IWICDdsFrameDecode* This, [NativeTypeName("UINT")] uint* pWidthInBlocks, [NativeTypeName("UINT")] uint* pHeightInBlocks);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFormatInfo(IWICDdsFrameDecode* This, WICDdsFormatInfo* pFormatInfo);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CopyBlocks(IWICDdsFrameDecode* This, WICRect* prcBoundsInBlocks, [NativeTypeName("UINT")] uint cbStride, [NativeTypeName("UINT")] uint cbBufferSize, [NativeTypeName("BYTE[]")] byte* pbBuffer);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
        {
            fixed (IWICDdsFrameDecode* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(This, riid, ppvObject);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (IWICDdsFrameDecode* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(This);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IWICDdsFrameDecode* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSizeInBlocks([NativeTypeName("UINT")] uint* pWidthInBlocks, [NativeTypeName("UINT")] uint* pHeightInBlocks)
        {
            fixed (IWICDdsFrameDecode* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetSizeInBlocks>(lpVtbl->GetSizeInBlocks)(This, pWidthInBlocks, pHeightInBlocks);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFormatInfo(WICDdsFormatInfo* pFormatInfo)
        {
            fixed (IWICDdsFrameDecode* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetFormatInfo>(lpVtbl->GetFormatInfo)(This, pFormatInfo);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CopyBlocks(WICRect* prcBoundsInBlocks, [NativeTypeName("UINT")] uint cbStride, [NativeTypeName("UINT")] uint cbBufferSize, [NativeTypeName("BYTE[]")] byte* pbBuffer)
        {
            fixed (IWICDdsFrameDecode* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CopyBlocks>(lpVtbl->CopyBlocks)(This, prcBoundsInBlocks, cbStride, cbBufferSize, pbBuffer);
            }
        }

        public partial struct Vtbl
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
