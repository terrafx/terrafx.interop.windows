// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3050F6A6-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct IHTMLPainter : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IHTMLPainter
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IHTMLPainter*, Guid*, void**, int>)(lpVtbl[0]))((IHTMLPainter*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IHTMLPainter*, uint>)(lpVtbl[1]))((IHTMLPainter*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IHTMLPainter*, uint>)(lpVtbl[2]))((IHTMLPainter*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int Draw(RECT rcBounds, RECT rcUpdate, [NativeTypeName("LONG")] int lDrawFlags, [NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPVOID")] void* pvDrawObject)
        {
            return ((delegate* unmanaged<IHTMLPainter*, RECT, RECT, int, IntPtr, void*, int>)(lpVtbl[3]))((IHTMLPainter*)Unsafe.AsPointer(ref this), rcBounds, rcUpdate, lDrawFlags, hdc, pvDrawObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int OnResize(SIZE size)
        {
            return ((delegate* unmanaged<IHTMLPainter*, SIZE, int>)(lpVtbl[4]))((IHTMLPainter*)Unsafe.AsPointer(ref this), size);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetPainterInfo(HTML_PAINTER_INFO* pInfo)
        {
            return ((delegate* unmanaged<IHTMLPainter*, HTML_PAINTER_INFO*, int>)(lpVtbl[5]))((IHTMLPainter*)Unsafe.AsPointer(ref this), pInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int HitTestPoint(POINT pt, [NativeTypeName("BOOL *")] int* pbHit, [NativeTypeName("LONG *")] int* plPartID)
        {
            return ((delegate* unmanaged<IHTMLPainter*, POINT, int*, int*, int>)(lpVtbl[6]))((IHTMLPainter*)Unsafe.AsPointer(ref this), pt, pbHit, plPartID);
        }
    }
}
