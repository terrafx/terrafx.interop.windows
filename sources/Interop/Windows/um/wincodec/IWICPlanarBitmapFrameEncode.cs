// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop
{
    [SupportedOSPlatform("windows8.1")]
    [Guid("F928B7B8-2221-40C1-B72E-7E82F1974D1A")]
    [NativeTypeName("struct IWICPlanarBitmapFrameEncode : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IWICPlanarBitmapFrameEncode : IWICPlanarBitmapFrameEncode.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IWICPlanarBitmapFrameEncode*, Guid*, void**, int>)(lpVtbl[0]))((IWICPlanarBitmapFrameEncode*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IWICPlanarBitmapFrameEncode*, uint>)(lpVtbl[1]))((IWICPlanarBitmapFrameEncode*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IWICPlanarBitmapFrameEncode*, uint>)(lpVtbl[2]))((IWICPlanarBitmapFrameEncode*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT WritePixels(uint lineCount, WICBitmapPlane* pPlanes, uint cPlanes)
        {
            return ((delegate* unmanaged<IWICPlanarBitmapFrameEncode*, uint, WICBitmapPlane*, uint, int>)(lpVtbl[3]))((IWICPlanarBitmapFrameEncode*)Unsafe.AsPointer(ref this), lineCount, pPlanes, cPlanes);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT WriteSource(IWICBitmapSource** ppPlanes, uint cPlanes, WICRect* prcSource)
        {
            return ((delegate* unmanaged<IWICPlanarBitmapFrameEncode*, IWICBitmapSource**, uint, WICRect*, int>)(lpVtbl[4]))((IWICPlanarBitmapFrameEncode*)Unsafe.AsPointer(ref this), ppPlanes, cPlanes, prcSource);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT WritePixels(uint lineCount, WICBitmapPlane* pPlanes, uint cPlanes);

            [VtblIndex(4)]
            HRESULT WriteSource(IWICBitmapSource** ppPlanes, uint cPlanes, WICRect* prcSource);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IWICPlanarBitmapFrameEncode*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IWICPlanarBitmapFrameEncode*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IWICPlanarBitmapFrameEncode*, uint> Release;

            [NativeTypeName("HRESULT (UINT, WICBitmapPlane *, UINT) __attribute__((stdcall))")]
            public delegate* unmanaged<IWICPlanarBitmapFrameEncode*, uint, WICBitmapPlane*, uint, int> WritePixels;

            [NativeTypeName("HRESULT (IWICBitmapSource **, UINT, WICRect *) __attribute__((stdcall))")]
            public delegate* unmanaged<IWICPlanarBitmapFrameEncode*, IWICBitmapSource**, uint, WICRect*, int> WriteSource;
        }
    }
}
