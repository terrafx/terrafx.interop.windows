// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/inkrenderer.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("407FB1DE-F85A-4150-97CF-B7FB274FB4F8")]
    [NativeTypeName("struct IInkD2DRenderer : IUnknown")]
    public unsafe partial struct IInkD2DRenderer
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IInkD2DRenderer*, Guid*, void**, int>)(lpVtbl[0]))((IInkD2DRenderer*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IInkD2DRenderer*, uint>)(lpVtbl[1]))((IInkD2DRenderer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IInkD2DRenderer*, uint>)(lpVtbl[2]))((IInkD2DRenderer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Draw([NativeTypeName("IUnknown *")] IUnknown* pD2D1DeviceContext, [NativeTypeName("IUnknown *")] IUnknown* pInkStrokeIterable, [NativeTypeName("BOOL")] int fHighContrast)
        {
            return ((delegate* unmanaged[Stdcall]<IInkD2DRenderer*, IUnknown*, IUnknown*, int, int>)(lpVtbl[3]))((IInkD2DRenderer*)Unsafe.AsPointer(ref this), pD2D1DeviceContext, pInkStrokeIterable, fHighContrast);
        }
    }
}
