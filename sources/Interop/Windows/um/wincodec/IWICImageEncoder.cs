// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("04C75BF8-3CE1-473B-ACC5-3CC4F5E94999")]
    [NativeTypeName("struct IWICImageEncoder : IUnknown")]
    public unsafe partial struct IWICImageEncoder
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IWICImageEncoder*, Guid*, void**, int>)(lpVtbl[0]))((IWICImageEncoder*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IWICImageEncoder*, uint>)(lpVtbl[1]))((IWICImageEncoder*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IWICImageEncoder*, uint>)(lpVtbl[2]))((IWICImageEncoder*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int WriteFrame(ID2D1Image* pImage, IWICBitmapFrameEncode* pFrameEncode, [NativeTypeName("const WICImageParameters *")] WICImageParameters* pImageParameters)
        {
            return ((delegate* unmanaged<IWICImageEncoder*, ID2D1Image*, IWICBitmapFrameEncode*, WICImageParameters*, int>)(lpVtbl[3]))((IWICImageEncoder*)Unsafe.AsPointer(ref this), pImage, pFrameEncode, pImageParameters);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int WriteFrameThumbnail(ID2D1Image* pImage, IWICBitmapFrameEncode* pFrameEncode, [NativeTypeName("const WICImageParameters *")] WICImageParameters* pImageParameters)
        {
            return ((delegate* unmanaged<IWICImageEncoder*, ID2D1Image*, IWICBitmapFrameEncode*, WICImageParameters*, int>)(lpVtbl[4]))((IWICImageEncoder*)Unsafe.AsPointer(ref this), pImage, pFrameEncode, pImageParameters);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int WriteThumbnail(ID2D1Image* pImage, IWICBitmapEncoder* pEncoder, [NativeTypeName("const WICImageParameters *")] WICImageParameters* pImageParameters)
        {
            return ((delegate* unmanaged<IWICImageEncoder*, ID2D1Image*, IWICBitmapEncoder*, WICImageParameters*, int>)(lpVtbl[5]))((IWICImageEncoder*)Unsafe.AsPointer(ref this), pImage, pEncoder, pImageParameters);
        }
    }
}
