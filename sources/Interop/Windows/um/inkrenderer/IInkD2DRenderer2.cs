// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/inkrenderer.h and um/inkrenderer_i.c in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0A95DCD9-4578-4B71-B20B-BF664D4BFEEE")]
    [NativeTypeName("struct IInkD2DRenderer2 : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IInkD2DRenderer2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IInkD2DRenderer2*, Guid*, void**, int>)(lpVtbl[0]))((IInkD2DRenderer2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IInkD2DRenderer2*, uint>)(lpVtbl[1]))((IInkD2DRenderer2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IInkD2DRenderer2*, uint>)(lpVtbl[2]))((IInkD2DRenderer2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT Draw(IUnknown* pD2D1DeviceContext, IUnknown* pInkStrokeIterable, INK_HIGH_CONTRAST_ADJUSTMENT highContrastAdjustment)
        {
            return ((delegate* unmanaged<IInkD2DRenderer2*, IUnknown*, IUnknown*, INK_HIGH_CONTRAST_ADJUSTMENT, int>)(lpVtbl[3]))((IInkD2DRenderer2*)Unsafe.AsPointer(ref this), pD2D1DeviceContext, pInkStrokeIterable, highContrastAdjustment);
        }
    }
}
