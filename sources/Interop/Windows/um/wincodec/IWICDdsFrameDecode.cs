// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3D4C0C61-18A4-41E4-BD80-481A4FC9F464")]
    [NativeTypeName("struct IWICDdsFrameDecode : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IWICDdsFrameDecode
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IWICDdsFrameDecode*, Guid*, void**, int>)(lpVtbl[0]))((IWICDdsFrameDecode*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IWICDdsFrameDecode*, uint>)(lpVtbl[1]))((IWICDdsFrameDecode*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IWICDdsFrameDecode*, uint>)(lpVtbl[2]))((IWICDdsFrameDecode*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetSizeInBlocks(uint* pWidthInBlocks, uint* pHeightInBlocks)
        {
            return ((delegate* unmanaged<IWICDdsFrameDecode*, uint*, uint*, int>)(lpVtbl[3]))((IWICDdsFrameDecode*)Unsafe.AsPointer(ref this), pWidthInBlocks, pHeightInBlocks);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetFormatInfo(WICDdsFormatInfo* pFormatInfo)
        {
            return ((delegate* unmanaged<IWICDdsFrameDecode*, WICDdsFormatInfo*, int>)(lpVtbl[4]))((IWICDdsFrameDecode*)Unsafe.AsPointer(ref this), pFormatInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT CopyBlocks([NativeTypeName("const WICRect *")] WICRect* prcBoundsInBlocks, uint cbStride, uint cbBufferSize, byte* pbBuffer)
        {
            return ((delegate* unmanaged<IWICDdsFrameDecode*, WICRect*, uint, uint, byte*, int>)(lpVtbl[5]))((IWICDdsFrameDecode*)Unsafe.AsPointer(ref this), prcBoundsInBlocks, cbStride, cbBufferSize, pbBuffer);
        }
    }
}
