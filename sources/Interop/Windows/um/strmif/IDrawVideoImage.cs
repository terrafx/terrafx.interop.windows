// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("48EFB120-AB49-11D2-AED2-00A0C995E8D5")]
    [NativeTypeName("struct IDrawVideoImage : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IDrawVideoImage
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDrawVideoImage*, Guid*, void**, int>)(lpVtbl[0]))((IDrawVideoImage*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDrawVideoImage*, uint>)(lpVtbl[1]))((IDrawVideoImage*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDrawVideoImage*, uint>)(lpVtbl[2]))((IDrawVideoImage*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT DrawVideoImageBegin()
        {
            return ((delegate* unmanaged<IDrawVideoImage*, int>)(lpVtbl[3]))((IDrawVideoImage*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT DrawVideoImageEnd()
        {
            return ((delegate* unmanaged<IDrawVideoImage*, int>)(lpVtbl[4]))((IDrawVideoImage*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT DrawVideoImageDraw(HDC hdc, [NativeTypeName("LPRECT")] RECT* lprcSrc, [NativeTypeName("LPRECT")] RECT* lprcDst)
        {
            return ((delegate* unmanaged<IDrawVideoImage*, HDC, RECT*, RECT*, int>)(lpVtbl[5]))((IDrawVideoImage*)Unsafe.AsPointer(ref this), hdc, lprcSrc, lprcDst);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IDrawVideoImage*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDrawVideoImage*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDrawVideoImage*, uint> Release;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IDrawVideoImage*, int> DrawVideoImageBegin;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IDrawVideoImage*, int> DrawVideoImageEnd;

            [NativeTypeName("HRESULT (HDC, LPRECT, LPRECT) __attribute__((stdcall))")]
            public delegate* unmanaged<IDrawVideoImage*, HDC, RECT*, RECT*, int> DrawVideoImageDraw;
        }
    }
}
