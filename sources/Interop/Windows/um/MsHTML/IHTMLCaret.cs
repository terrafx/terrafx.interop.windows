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
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
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
        [return: NativeTypeName("HRESULT")]
        public int MoveCaretToPointer(IDisplayPointer* pDispPointer, BOOL fScrollIntoView, CARET_DIRECTION eDir)
        {
            return ((delegate* unmanaged<IHTMLCaret*, IDisplayPointer*, BOOL, CARET_DIRECTION, int>)(lpVtbl[3]))((IHTMLCaret*)Unsafe.AsPointer(ref this), pDispPointer, fScrollIntoView, eDir);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int MoveCaretToPointerEx(IDisplayPointer* pDispPointer, BOOL fVisible, BOOL fScrollIntoView, CARET_DIRECTION eDir)
        {
            return ((delegate* unmanaged<IHTMLCaret*, IDisplayPointer*, BOOL, BOOL, CARET_DIRECTION, int>)(lpVtbl[4]))((IHTMLCaret*)Unsafe.AsPointer(ref this), pDispPointer, fVisible, fScrollIntoView, eDir);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int MoveMarkupPointerToCaret(IMarkupPointer* pIMarkupPointer)
        {
            return ((delegate* unmanaged<IHTMLCaret*, IMarkupPointer*, int>)(lpVtbl[5]))((IHTMLCaret*)Unsafe.AsPointer(ref this), pIMarkupPointer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int MoveDisplayPointerToCaret(IDisplayPointer* pDispPointer)
        {
            return ((delegate* unmanaged<IHTMLCaret*, IDisplayPointer*, int>)(lpVtbl[6]))((IHTMLCaret*)Unsafe.AsPointer(ref this), pDispPointer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int IsVisible(BOOL* pIsVisible)
        {
            return ((delegate* unmanaged<IHTMLCaret*, BOOL*, int>)(lpVtbl[7]))((IHTMLCaret*)Unsafe.AsPointer(ref this), pIsVisible);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int Show(BOOL fScrollIntoView)
        {
            return ((delegate* unmanaged<IHTMLCaret*, BOOL, int>)(lpVtbl[8]))((IHTMLCaret*)Unsafe.AsPointer(ref this), fScrollIntoView);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int Hide()
        {
            return ((delegate* unmanaged<IHTMLCaret*, int>)(lpVtbl[9]))((IHTMLCaret*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int InsertText([NativeTypeName("OLECHAR *")] ushort* pText, [NativeTypeName("LONG")] int lLen)
        {
            return ((delegate* unmanaged<IHTMLCaret*, ushort*, int, int>)(lpVtbl[10]))((IHTMLCaret*)Unsafe.AsPointer(ref this), pText, lLen);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int ScrollIntoView()
        {
            return ((delegate* unmanaged<IHTMLCaret*, int>)(lpVtbl[11]))((IHTMLCaret*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int GetLocation(POINT* pPoint, BOOL fTranslate)
        {
            return ((delegate* unmanaged<IHTMLCaret*, POINT*, BOOL, int>)(lpVtbl[12]))((IHTMLCaret*)Unsafe.AsPointer(ref this), pPoint, fTranslate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int GetCaretDirection(CARET_DIRECTION* peDir)
        {
            return ((delegate* unmanaged<IHTMLCaret*, CARET_DIRECTION*, int>)(lpVtbl[13]))((IHTMLCaret*)Unsafe.AsPointer(ref this), peDir);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int SetCaretDirection(CARET_DIRECTION eDir)
        {
            return ((delegate* unmanaged<IHTMLCaret*, CARET_DIRECTION, int>)(lpVtbl[14]))((IHTMLCaret*)Unsafe.AsPointer(ref this), eDir);
        }
    }
}
