// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/inkrenderer.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("407FB1DE-F85A-4150-97CF-B7FB274FB4F8")]
    [NativeTypeName("struct IInkD2DRenderer : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IInkD2DRenderer
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IInkD2DRenderer*, Guid*, void**, int>)(lpVtbl[0]))((IInkD2DRenderer*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IInkD2DRenderer*, uint>)(lpVtbl[1]))((IInkD2DRenderer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IInkD2DRenderer*, uint>)(lpVtbl[2]))((IInkD2DRenderer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int Draw(IUnknown* pD2D1DeviceContext, IUnknown* pInkStrokeIterable, [NativeTypeName("BOOL")] int fHighContrast)
        {
            return ((delegate* unmanaged<IInkD2DRenderer*, IUnknown*, IUnknown*, int, int>)(lpVtbl[3]))((IInkD2DRenderer*)Unsafe.AsPointer(ref this), pD2D1DeviceContext, pInkStrokeIterable, fHighContrast);
        }
    }
}
