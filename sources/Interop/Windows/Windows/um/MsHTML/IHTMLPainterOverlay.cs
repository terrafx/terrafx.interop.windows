// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("3050F7E3-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct IHTMLPainterOverlay : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IHTMLPainterOverlay : IHTMLPainterOverlay.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IHTMLPainterOverlay*, Guid*, void**, int>)(lpVtbl[0]))((IHTMLPainterOverlay*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IHTMLPainterOverlay*, uint>)(lpVtbl[1]))((IHTMLPainterOverlay*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IHTMLPainterOverlay*, uint>)(lpVtbl[2]))((IHTMLPainterOverlay*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT OnMove(RECT rcDevice)
        {
            return ((delegate* unmanaged<IHTMLPainterOverlay*, RECT, int>)(lpVtbl[3]))((IHTMLPainterOverlay*)Unsafe.AsPointer(ref this), rcDevice);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT OnMove(RECT rcDevice);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLPainterOverlay*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLPainterOverlay*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLPainterOverlay*, uint> Release;

            [NativeTypeName("HRESULT (RECT) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLPainterOverlay*, RECT, int> OnMove;
        }
    }
}
