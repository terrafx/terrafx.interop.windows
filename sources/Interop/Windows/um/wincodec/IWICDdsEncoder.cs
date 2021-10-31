// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("5CACDB4C-407E-41B3-B936-D0F010CD6732")]
    [NativeTypeName("struct IWICDdsEncoder : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IWICDdsEncoder
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IWICDdsEncoder*, Guid*, void**, int>)(lpVtbl[0]))((IWICDdsEncoder*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IWICDdsEncoder*, uint>)(lpVtbl[1]))((IWICDdsEncoder*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IWICDdsEncoder*, uint>)(lpVtbl[2]))((IWICDdsEncoder*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT SetParameters(WICDdsParameters* pParameters)
        {
            return ((delegate* unmanaged<IWICDdsEncoder*, WICDdsParameters*, int>)(lpVtbl[3]))((IWICDdsEncoder*)Unsafe.AsPointer(ref this), pParameters);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetParameters(WICDdsParameters* pParameters)
        {
            return ((delegate* unmanaged<IWICDdsEncoder*, WICDdsParameters*, int>)(lpVtbl[4]))((IWICDdsEncoder*)Unsafe.AsPointer(ref this), pParameters);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT CreateNewFrame(IWICBitmapFrameEncode** ppIFrameEncode, [NativeTypeName("UINT *")] uint* pArrayIndex, [NativeTypeName("UINT *")] uint* pMipLevel, [NativeTypeName("UINT *")] uint* pSliceIndex)
        {
            return ((delegate* unmanaged<IWICDdsEncoder*, IWICBitmapFrameEncode**, uint*, uint*, uint*, int>)(lpVtbl[5]))((IWICDdsEncoder*)Unsafe.AsPointer(ref this), ppIFrameEncode, pArrayIndex, pMipLevel, pSliceIndex);
        }
    }
}
