// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3D4C0C61-18A4-41E4-BD80-481A4FC9F464")]
    [NativeTypeName("struct IWICDdsFrameDecode : IUnknown")]
    public unsafe partial struct IWICDdsFrameDecode
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IWICDdsFrameDecode*, Guid*, void**, int>)(lpVtbl[0]))((IWICDdsFrameDecode*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IWICDdsFrameDecode*, uint>)(lpVtbl[1]))((IWICDdsFrameDecode*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IWICDdsFrameDecode*, uint>)(lpVtbl[2]))((IWICDdsFrameDecode*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSizeInBlocks([NativeTypeName("UINT *")] uint* pWidthInBlocks, [NativeTypeName("UINT *")] uint* pHeightInBlocks)
        {
            return ((delegate* stdcall<IWICDdsFrameDecode*, uint*, uint*, int>)(lpVtbl[3]))((IWICDdsFrameDecode*)Unsafe.AsPointer(ref this), pWidthInBlocks, pHeightInBlocks);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFormatInfo([NativeTypeName("WICDdsFormatInfo *")] WICDdsFormatInfo* pFormatInfo)
        {
            return ((delegate* stdcall<IWICDdsFrameDecode*, WICDdsFormatInfo*, int>)(lpVtbl[4]))((IWICDdsFrameDecode*)Unsafe.AsPointer(ref this), pFormatInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CopyBlocks([NativeTypeName("const WICRect *")] WICRect* prcBoundsInBlocks, [NativeTypeName("UINT")] uint cbStride, [NativeTypeName("UINT")] uint cbBufferSize, [NativeTypeName("BYTE *")] byte* pbBuffer)
        {
            return ((delegate* stdcall<IWICDdsFrameDecode*, WICRect*, uint, uint, byte*, int>)(lpVtbl[5]))((IWICDdsFrameDecode*)Unsafe.AsPointer(ref this), prcBoundsInBlocks, cbStride, cbBufferSize, pbBuffer);
        }
    }
}
