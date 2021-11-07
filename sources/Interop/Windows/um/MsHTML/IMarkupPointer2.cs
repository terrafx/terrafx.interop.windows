// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3050F675-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct IMarkupPointer2 : IMarkupPointer")]
    [NativeInheritance("IMarkupPointer")]
    public unsafe partial struct IMarkupPointer2 : IMarkupPointer2.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMarkupPointer2*, Guid*, void**, int>)(lpVtbl[0]))((IMarkupPointer2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMarkupPointer2*, uint>)(lpVtbl[1]))((IMarkupPointer2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMarkupPointer2*, uint>)(lpVtbl[2]))((IMarkupPointer2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT OwningDoc(IHTMLDocument2** ppDoc)
        {
            return ((delegate* unmanaged<IMarkupPointer2*, IHTMLDocument2**, int>)(lpVtbl[3]))((IMarkupPointer2*)Unsafe.AsPointer(ref this), ppDoc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT Gravity(POINTER_GRAVITY* pGravity)
        {
            return ((delegate* unmanaged<IMarkupPointer2*, POINTER_GRAVITY*, int>)(lpVtbl[4]))((IMarkupPointer2*)Unsafe.AsPointer(ref this), pGravity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT SetGravity(POINTER_GRAVITY Gravity)
        {
            return ((delegate* unmanaged<IMarkupPointer2*, POINTER_GRAVITY, int>)(lpVtbl[5]))((IMarkupPointer2*)Unsafe.AsPointer(ref this), Gravity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Cling(BOOL* pfCling)
        {
            return ((delegate* unmanaged<IMarkupPointer2*, BOOL*, int>)(lpVtbl[6]))((IMarkupPointer2*)Unsafe.AsPointer(ref this), pfCling);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT SetCling(BOOL fCLing)
        {
            return ((delegate* unmanaged<IMarkupPointer2*, BOOL, int>)(lpVtbl[7]))((IMarkupPointer2*)Unsafe.AsPointer(ref this), fCLing);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT Unposition()
        {
            return ((delegate* unmanaged<IMarkupPointer2*, int>)(lpVtbl[8]))((IMarkupPointer2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT IsPositioned(BOOL* pfPositioned)
        {
            return ((delegate* unmanaged<IMarkupPointer2*, BOOL*, int>)(lpVtbl[9]))((IMarkupPointer2*)Unsafe.AsPointer(ref this), pfPositioned);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT GetContainer(IMarkupContainer** ppContainer)
        {
            return ((delegate* unmanaged<IMarkupPointer2*, IMarkupContainer**, int>)(lpVtbl[10]))((IMarkupPointer2*)Unsafe.AsPointer(ref this), ppContainer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT MoveAdjacentToElement(IHTMLElement* pElement, ELEMENT_ADJACENCY eAdj)
        {
            return ((delegate* unmanaged<IMarkupPointer2*, IHTMLElement*, ELEMENT_ADJACENCY, int>)(lpVtbl[11]))((IMarkupPointer2*)Unsafe.AsPointer(ref this), pElement, eAdj);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT MoveToPointer(IMarkupPointer* pPointer)
        {
            return ((delegate* unmanaged<IMarkupPointer2*, IMarkupPointer*, int>)(lpVtbl[12]))((IMarkupPointer2*)Unsafe.AsPointer(ref this), pPointer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT MoveToContainer(IMarkupContainer* pContainer, BOOL fAtStart)
        {
            return ((delegate* unmanaged<IMarkupPointer2*, IMarkupContainer*, BOOL, int>)(lpVtbl[13]))((IMarkupPointer2*)Unsafe.AsPointer(ref this), pContainer, fAtStart);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT Left(BOOL fMove, MARKUP_CONTEXT_TYPE* pContext, IHTMLElement** ppElement, [NativeTypeName("long *")] int* pcch, [NativeTypeName("OLECHAR *")] ushort* pchText)
        {
            return ((delegate* unmanaged<IMarkupPointer2*, BOOL, MARKUP_CONTEXT_TYPE*, IHTMLElement**, int*, ushort*, int>)(lpVtbl[14]))((IMarkupPointer2*)Unsafe.AsPointer(ref this), fMove, pContext, ppElement, pcch, pchText);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT Right(BOOL fMove, MARKUP_CONTEXT_TYPE* pContext, IHTMLElement** ppElement, [NativeTypeName("long *")] int* pcch, [NativeTypeName("OLECHAR *")] ushort* pchText)
        {
            return ((delegate* unmanaged<IMarkupPointer2*, BOOL, MARKUP_CONTEXT_TYPE*, IHTMLElement**, int*, ushort*, int>)(lpVtbl[15]))((IMarkupPointer2*)Unsafe.AsPointer(ref this), fMove, pContext, ppElement, pcch, pchText);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT CurrentScope(IHTMLElement** ppElemCurrent)
        {
            return ((delegate* unmanaged<IMarkupPointer2*, IHTMLElement**, int>)(lpVtbl[16]))((IMarkupPointer2*)Unsafe.AsPointer(ref this), ppElemCurrent);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT IsLeftOf(IMarkupPointer* pPointerThat, BOOL* pfResult)
        {
            return ((delegate* unmanaged<IMarkupPointer2*, IMarkupPointer*, BOOL*, int>)(lpVtbl[17]))((IMarkupPointer2*)Unsafe.AsPointer(ref this), pPointerThat, pfResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT IsLeftOfOrEqualTo(IMarkupPointer* pPointerThat, BOOL* pfResult)
        {
            return ((delegate* unmanaged<IMarkupPointer2*, IMarkupPointer*, BOOL*, int>)(lpVtbl[18]))((IMarkupPointer2*)Unsafe.AsPointer(ref this), pPointerThat, pfResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT IsRightOf(IMarkupPointer* pPointerThat, BOOL* pfResult)
        {
            return ((delegate* unmanaged<IMarkupPointer2*, IMarkupPointer*, BOOL*, int>)(lpVtbl[19]))((IMarkupPointer2*)Unsafe.AsPointer(ref this), pPointerThat, pfResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public HRESULT IsRightOfOrEqualTo(IMarkupPointer* pPointerThat, BOOL* pfResult)
        {
            return ((delegate* unmanaged<IMarkupPointer2*, IMarkupPointer*, BOOL*, int>)(lpVtbl[20]))((IMarkupPointer2*)Unsafe.AsPointer(ref this), pPointerThat, pfResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public HRESULT IsEqualTo(IMarkupPointer* pPointerThat, BOOL* pfAreEqual)
        {
            return ((delegate* unmanaged<IMarkupPointer2*, IMarkupPointer*, BOOL*, int>)(lpVtbl[21]))((IMarkupPointer2*)Unsafe.AsPointer(ref this), pPointerThat, pfAreEqual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        public HRESULT MoveUnit(MOVEUNIT_ACTION muAction)
        {
            return ((delegate* unmanaged<IMarkupPointer2*, MOVEUNIT_ACTION, int>)(lpVtbl[22]))((IMarkupPointer2*)Unsafe.AsPointer(ref this), muAction);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        public HRESULT FindTextW([NativeTypeName("OLECHAR *")] ushort* pchFindText, [NativeTypeName("DWORD")] uint dwFlags, IMarkupPointer* pIEndMatch, IMarkupPointer* pIEndSearch)
        {
            return ((delegate* unmanaged<IMarkupPointer2*, ushort*, uint, IMarkupPointer*, IMarkupPointer*, int>)(lpVtbl[23]))((IMarkupPointer2*)Unsafe.AsPointer(ref this), pchFindText, dwFlags, pIEndMatch, pIEndSearch);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        public HRESULT IsAtWordBreak(BOOL* pfAtBreak)
        {
            return ((delegate* unmanaged<IMarkupPointer2*, BOOL*, int>)(lpVtbl[24]))((IMarkupPointer2*)Unsafe.AsPointer(ref this), pfAtBreak);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        public HRESULT GetMarkupPosition([NativeTypeName("long *")] int* plMP)
        {
            return ((delegate* unmanaged<IMarkupPointer2*, int*, int>)(lpVtbl[25]))((IMarkupPointer2*)Unsafe.AsPointer(ref this), plMP);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        public HRESULT MoveToMarkupPosition(IMarkupContainer* pContainer, [NativeTypeName("long")] int lMP)
        {
            return ((delegate* unmanaged<IMarkupPointer2*, IMarkupContainer*, int, int>)(lpVtbl[26]))((IMarkupPointer2*)Unsafe.AsPointer(ref this), pContainer, lMP);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        public HRESULT MoveUnitBounded(MOVEUNIT_ACTION muAction, IMarkupPointer* pIBoundary)
        {
            return ((delegate* unmanaged<IMarkupPointer2*, MOVEUNIT_ACTION, IMarkupPointer*, int>)(lpVtbl[27]))((IMarkupPointer2*)Unsafe.AsPointer(ref this), muAction, pIBoundary);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        public HRESULT IsInsideURL(IMarkupPointer* pRight, BOOL* pfResult)
        {
            return ((delegate* unmanaged<IMarkupPointer2*, IMarkupPointer*, BOOL*, int>)(lpVtbl[28]))((IMarkupPointer2*)Unsafe.AsPointer(ref this), pRight, pfResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        public HRESULT MoveToContent(IHTMLElement* pIElement, BOOL fAtStart)
        {
            return ((delegate* unmanaged<IMarkupPointer2*, IHTMLElement*, BOOL, int>)(lpVtbl[29]))((IMarkupPointer2*)Unsafe.AsPointer(ref this), pIElement, fAtStart);
        }

        public interface Interface : IMarkupPointer.Interface
        {
            [VtblIndex(24)]
            HRESULT IsAtWordBreak(BOOL* pfAtBreak);

            [VtblIndex(25)]
            HRESULT GetMarkupPosition([NativeTypeName("long *")] int* plMP);

            [VtblIndex(26)]
            HRESULT MoveToMarkupPosition(IMarkupContainer* pContainer, [NativeTypeName("long")] int lMP);

            [VtblIndex(27)]
            HRESULT MoveUnitBounded(MOVEUNIT_ACTION muAction, IMarkupPointer* pIBoundary);

            [VtblIndex(28)]
            HRESULT IsInsideURL(IMarkupPointer* pRight, BOOL* pfResult);

            [VtblIndex(29)]
            HRESULT MoveToContent(IHTMLElement* pIElement, BOOL fAtStart);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMarkupPointer2*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMarkupPointer2*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMarkupPointer2*, uint> Release;

            [NativeTypeName("HRESULT (IHTMLDocument2 **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMarkupPointer2*, IHTMLDocument2**, int> OwningDoc;

            [NativeTypeName("HRESULT (POINTER_GRAVITY *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMarkupPointer2*, POINTER_GRAVITY*, int> Gravity;

            [NativeTypeName("HRESULT (POINTER_GRAVITY) __attribute__((stdcall))")]
            public delegate* unmanaged<IMarkupPointer2*, POINTER_GRAVITY, int> SetGravity;

            [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMarkupPointer2*, BOOL*, int> Cling;

            [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
            public delegate* unmanaged<IMarkupPointer2*, BOOL, int> SetCling;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IMarkupPointer2*, int> Unposition;

            [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMarkupPointer2*, BOOL*, int> IsPositioned;

            [NativeTypeName("HRESULT (IMarkupContainer **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMarkupPointer2*, IMarkupContainer**, int> GetContainer;

            [NativeTypeName("HRESULT (IHTMLElement *, ELEMENT_ADJACENCY) __attribute__((stdcall))")]
            public delegate* unmanaged<IMarkupPointer2*, IHTMLElement*, ELEMENT_ADJACENCY, int> MoveAdjacentToElement;

            [NativeTypeName("HRESULT (IMarkupPointer *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMarkupPointer2*, IMarkupPointer*, int> MoveToPointer;

            [NativeTypeName("HRESULT (IMarkupContainer *, BOOL) __attribute__((stdcall))")]
            public delegate* unmanaged<IMarkupPointer2*, IMarkupContainer*, BOOL, int> MoveToContainer;

            [NativeTypeName("HRESULT (BOOL, MARKUP_CONTEXT_TYPE *, IHTMLElement **, long *, OLECHAR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMarkupPointer2*, BOOL, MARKUP_CONTEXT_TYPE*, IHTMLElement**, int*, ushort*, int> Left;

            [NativeTypeName("HRESULT (BOOL, MARKUP_CONTEXT_TYPE *, IHTMLElement **, long *, OLECHAR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMarkupPointer2*, BOOL, MARKUP_CONTEXT_TYPE*, IHTMLElement**, int*, ushort*, int> Right;

            [NativeTypeName("HRESULT (IHTMLElement **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMarkupPointer2*, IHTMLElement**, int> CurrentScope;

            [NativeTypeName("HRESULT (IMarkupPointer *, BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMarkupPointer2*, IMarkupPointer*, BOOL*, int> IsLeftOf;

            [NativeTypeName("HRESULT (IMarkupPointer *, BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMarkupPointer2*, IMarkupPointer*, BOOL*, int> IsLeftOfOrEqualTo;

            [NativeTypeName("HRESULT (IMarkupPointer *, BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMarkupPointer2*, IMarkupPointer*, BOOL*, int> IsRightOf;

            [NativeTypeName("HRESULT (IMarkupPointer *, BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMarkupPointer2*, IMarkupPointer*, BOOL*, int> IsRightOfOrEqualTo;

            [NativeTypeName("HRESULT (IMarkupPointer *, BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMarkupPointer2*, IMarkupPointer*, BOOL*, int> IsEqualTo;

            [NativeTypeName("HRESULT (MOVEUNIT_ACTION) __attribute__((stdcall))")]
            public delegate* unmanaged<IMarkupPointer2*, MOVEUNIT_ACTION, int> MoveUnit;

            [NativeTypeName("HRESULT (OLECHAR *, DWORD, IMarkupPointer *, IMarkupPointer *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMarkupPointer2*, ushort*, uint, IMarkupPointer*, IMarkupPointer*, int> FindTextW;

            [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMarkupPointer2*, BOOL*, int> IsAtWordBreak;

            [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMarkupPointer2*, int*, int> GetMarkupPosition;

            [NativeTypeName("HRESULT (IMarkupContainer *, long) __attribute__((stdcall))")]
            public delegate* unmanaged<IMarkupPointer2*, IMarkupContainer*, int, int> MoveToMarkupPosition;

            [NativeTypeName("HRESULT (MOVEUNIT_ACTION, IMarkupPointer *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMarkupPointer2*, MOVEUNIT_ACTION, IMarkupPointer*, int> MoveUnitBounded;

            [NativeTypeName("HRESULT (IMarkupPointer *, BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMarkupPointer2*, IMarkupPointer*, BOOL*, int> IsInsideURL;

            [NativeTypeName("HRESULT (IHTMLElement *, BOOL) __attribute__((stdcall))")]
            public delegate* unmanaged<IMarkupPointer2*, IHTMLElement*, BOOL, int> MoveToContent;
        }
    }
}
