// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3050F604-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct IHTMLCaret : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IHTMLCaret
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IHTMLCaret*, Guid*, void**, int>)(lpVtbl[0]))((IHTMLCaret*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IHTMLCaret*, uint>)(lpVtbl[1]))((IHTMLCaret*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IHTMLCaret*, uint>)(lpVtbl[2]))((IHTMLCaret*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT MoveCaretToPointer(IDisplayPointer* pDispPointer, BOOL fScrollIntoView, CARET_DIRECTION eDir)
        {
            return ((delegate* unmanaged<IHTMLCaret*, IDisplayPointer*, BOOL, CARET_DIRECTION, int>)(lpVtbl[3]))((IHTMLCaret*)Unsafe.AsPointer(ref this), pDispPointer, fScrollIntoView, eDir);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT MoveCaretToPointerEx(IDisplayPointer* pDispPointer, BOOL fVisible, BOOL fScrollIntoView, CARET_DIRECTION eDir)
        {
            return ((delegate* unmanaged<IHTMLCaret*, IDisplayPointer*, BOOL, BOOL, CARET_DIRECTION, int>)(lpVtbl[4]))((IHTMLCaret*)Unsafe.AsPointer(ref this), pDispPointer, fVisible, fScrollIntoView, eDir);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT MoveMarkupPointerToCaret(IMarkupPointer* pIMarkupPointer)
        {
            return ((delegate* unmanaged<IHTMLCaret*, IMarkupPointer*, int>)(lpVtbl[5]))((IHTMLCaret*)Unsafe.AsPointer(ref this), pIMarkupPointer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT MoveDisplayPointerToCaret(IDisplayPointer* pDispPointer)
        {
            return ((delegate* unmanaged<IHTMLCaret*, IDisplayPointer*, int>)(lpVtbl[6]))((IHTMLCaret*)Unsafe.AsPointer(ref this), pDispPointer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT IsVisible(BOOL* pIsVisible)
        {
            return ((delegate* unmanaged<IHTMLCaret*, BOOL*, int>)(lpVtbl[7]))((IHTMLCaret*)Unsafe.AsPointer(ref this), pIsVisible);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT Show(BOOL fScrollIntoView)
        {
            return ((delegate* unmanaged<IHTMLCaret*, BOOL, int>)(lpVtbl[8]))((IHTMLCaret*)Unsafe.AsPointer(ref this), fScrollIntoView);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT Hide()
        {
            return ((delegate* unmanaged<IHTMLCaret*, int>)(lpVtbl[9]))((IHTMLCaret*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT InsertText([NativeTypeName("OLECHAR *")] ushort* pText, [NativeTypeName("LONG")] int lLen)
        {
            return ((delegate* unmanaged<IHTMLCaret*, ushort*, int, int>)(lpVtbl[10]))((IHTMLCaret*)Unsafe.AsPointer(ref this), pText, lLen);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT ScrollIntoView()
        {
            return ((delegate* unmanaged<IHTMLCaret*, int>)(lpVtbl[11]))((IHTMLCaret*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT GetLocation(POINT* pPoint, BOOL fTranslate)
        {
            return ((delegate* unmanaged<IHTMLCaret*, POINT*, BOOL, int>)(lpVtbl[12]))((IHTMLCaret*)Unsafe.AsPointer(ref this), pPoint, fTranslate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT GetCaretDirection(CARET_DIRECTION* peDir)
        {
            return ((delegate* unmanaged<IHTMLCaret*, CARET_DIRECTION*, int>)(lpVtbl[13]))((IHTMLCaret*)Unsafe.AsPointer(ref this), peDir);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT SetCaretDirection(CARET_DIRECTION eDir)
        {
            return ((delegate* unmanaged<IHTMLCaret*, CARET_DIRECTION, int>)(lpVtbl[14]))((IHTMLCaret*)Unsafe.AsPointer(ref this), eDir);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLCaret*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLCaret*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLCaret*, uint> Release;

            [NativeTypeName("HRESULT (IDisplayPointer *, BOOL, CARET_DIRECTION) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLCaret*, IDisplayPointer*, BOOL, CARET_DIRECTION, int> MoveCaretToPointer;

            [NativeTypeName("HRESULT (IDisplayPointer *, BOOL, BOOL, CARET_DIRECTION) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLCaret*, IDisplayPointer*, BOOL, BOOL, CARET_DIRECTION, int> MoveCaretToPointerEx;

            [NativeTypeName("HRESULT (IMarkupPointer *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLCaret*, IMarkupPointer*, int> MoveMarkupPointerToCaret;

            [NativeTypeName("HRESULT (IDisplayPointer *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLCaret*, IDisplayPointer*, int> MoveDisplayPointerToCaret;

            [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLCaret*, BOOL*, int> IsVisible;

            [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLCaret*, BOOL, int> Show;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLCaret*, int> Hide;

            [NativeTypeName("HRESULT (OLECHAR *, LONG) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLCaret*, ushort*, int, int> InsertText;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLCaret*, int> ScrollIntoView;

            [NativeTypeName("HRESULT (POINT *, BOOL) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLCaret*, POINT*, BOOL, int> GetLocation;

            [NativeTypeName("HRESULT (CARET_DIRECTION *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLCaret*, CARET_DIRECTION*, int> GetCaretDirection;

            [NativeTypeName("HRESULT (CARET_DIRECTION) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLCaret*, CARET_DIRECTION, int> SetCaretDirection;
        }
    }
}
