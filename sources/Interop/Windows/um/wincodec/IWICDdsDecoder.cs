// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("409CD537-8532-40CB-9774-E2FEB2DF4E9C")]
    [NativeTypeName("struct IWICDdsDecoder : IUnknown")]
    public unsafe partial struct IWICDdsDecoder
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IWICDdsDecoder*, Guid*, void**, int>)(lpVtbl[0]))((IWICDdsDecoder*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IWICDdsDecoder*, uint>)(lpVtbl[1]))((IWICDdsDecoder*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IWICDdsDecoder*, uint>)(lpVtbl[2]))((IWICDdsDecoder*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetParameters([NativeTypeName("WICDdsParameters *")] WICDdsParameters* pParameters)
        {
            return ((delegate* unmanaged<IWICDdsDecoder*, WICDdsParameters*, int>)(lpVtbl[3]))((IWICDdsDecoder*)Unsafe.AsPointer(ref this), pParameters);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFrame([NativeTypeName("UINT")] uint arrayIndex, [NativeTypeName("UINT")] uint mipLevel, [NativeTypeName("UINT")] uint sliceIndex, [NativeTypeName("IWICBitmapFrameDecode **")] IWICBitmapFrameDecode** ppIBitmapFrame)
        {
            return ((delegate* unmanaged<IWICDdsDecoder*, uint, uint, uint, IWICBitmapFrameDecode**, int>)(lpVtbl[4]))((IWICDdsDecoder*)Unsafe.AsPointer(ref this), arrayIndex, mipLevel, sliceIndex, ppIBitmapFrame);
        }
    }
}
