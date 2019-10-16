// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3D4C0C61-18A4-41E4-BD80-481A4FC9F464")]
    public unsafe partial struct IWICDdsFrameDecode
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IWICDdsFrameDecode* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IWICDdsFrameDecode* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IWICDdsFrameDecode* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetSizeInBlocks(IWICDdsFrameDecode* pThis, [NativeTypeName("UINT *")] uint* pWidthInBlocks, [NativeTypeName("UINT *")] uint* pHeightInBlocks);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFormatInfo(IWICDdsFrameDecode* pThis, [NativeTypeName("WICDdsFormatInfo *")] WICDdsFormatInfo* pFormatInfo);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CopyBlocks(IWICDdsFrameDecode* pThis, [NativeTypeName("const WICRect *")] WICRect* prcBoundsInBlocks, [NativeTypeName("UINT")] uint cbStride, [NativeTypeName("UINT")] uint cbBufferSize, [NativeTypeName("BYTE *")] byte* pbBuffer);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IWICDdsFrameDecode*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IWICDdsFrameDecode*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IWICDdsFrameDecode*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSizeInBlocks([NativeTypeName("UINT *")] uint* pWidthInBlocks, [NativeTypeName("UINT *")] uint* pHeightInBlocks)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetSizeInBlocks>(lpVtbl->GetSizeInBlocks)((IWICDdsFrameDecode*)Unsafe.AsPointer(ref this), pWidthInBlocks, pHeightInBlocks);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFormatInfo([NativeTypeName("WICDdsFormatInfo *")] WICDdsFormatInfo* pFormatInfo)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetFormatInfo>(lpVtbl->GetFormatInfo)((IWICDdsFrameDecode*)Unsafe.AsPointer(ref this), pFormatInfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int CopyBlocks([NativeTypeName("const WICRect *")] WICRect* prcBoundsInBlocks, [NativeTypeName("UINT")] uint cbStride, [NativeTypeName("UINT")] uint cbBufferSize, [NativeTypeName("BYTE *")] byte* pbBuffer)
        {
            return Marshal.GetDelegateForFunctionPointer<_CopyBlocks>(lpVtbl->CopyBlocks)((IWICDdsFrameDecode*)Unsafe.AsPointer(ref this), prcBoundsInBlocks, cbStride, cbBufferSize, pbBuffer);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (UINT *, UINT *) __attribute__((stdcall))")]
            public IntPtr GetSizeInBlocks;

            [NativeTypeName("HRESULT (WICDdsFormatInfo *) __attribute__((stdcall))")]
            public IntPtr GetFormatInfo;

            [NativeTypeName("HRESULT (const WICRect *, UINT, UINT, BYTE *) __attribute__((stdcall))")]
            public IntPtr CopyBlocks;
        }
    }
}
