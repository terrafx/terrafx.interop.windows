// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("2D3BA758-33EE-42D5-BB7B-5F3431D86C78")]
    [NativeTypeName("struct INameSpaceTreeControlCustomDraw : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct INameSpaceTreeControlCustomDraw
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<INameSpaceTreeControlCustomDraw*, Guid*, void**, int>)(lpVtbl[0]))((INameSpaceTreeControlCustomDraw*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<INameSpaceTreeControlCustomDraw*, uint>)(lpVtbl[1]))((INameSpaceTreeControlCustomDraw*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<INameSpaceTreeControlCustomDraw*, uint>)(lpVtbl[2]))((INameSpaceTreeControlCustomDraw*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int PrePaint([NativeTypeName("HDC")] IntPtr hdc, RECT* prc, [NativeTypeName("LRESULT *")] nint* plres)
        {
            return ((delegate* unmanaged<INameSpaceTreeControlCustomDraw*, IntPtr, RECT*, nint*, int>)(lpVtbl[3]))((INameSpaceTreeControlCustomDraw*)Unsafe.AsPointer(ref this), hdc, prc, plres);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int PostPaint([NativeTypeName("HDC")] IntPtr hdc, RECT* prc)
        {
            return ((delegate* unmanaged<INameSpaceTreeControlCustomDraw*, IntPtr, RECT*, int>)(lpVtbl[4]))((INameSpaceTreeControlCustomDraw*)Unsafe.AsPointer(ref this), hdc, prc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int ItemPrePaint([NativeTypeName("HDC")] IntPtr hdc, RECT* prc, NSTCCUSTOMDRAW* pnstccdItem, [NativeTypeName("COLORREF *")] uint* pclrText, [NativeTypeName("COLORREF *")] uint* pclrTextBk, [NativeTypeName("LRESULT *")] nint* plres)
        {
            return ((delegate* unmanaged<INameSpaceTreeControlCustomDraw*, IntPtr, RECT*, NSTCCUSTOMDRAW*, uint*, uint*, nint*, int>)(lpVtbl[5]))((INameSpaceTreeControlCustomDraw*)Unsafe.AsPointer(ref this), hdc, prc, pnstccdItem, pclrText, pclrTextBk, plres);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int ItemPostPaint([NativeTypeName("HDC")] IntPtr hdc, RECT* prc, NSTCCUSTOMDRAW* pnstccdItem)
        {
            return ((delegate* unmanaged<INameSpaceTreeControlCustomDraw*, IntPtr, RECT*, NSTCCUSTOMDRAW*, int>)(lpVtbl[6]))((INameSpaceTreeControlCustomDraw*)Unsafe.AsPointer(ref this), hdc, prc, pnstccdItem);
        }
    }
}
