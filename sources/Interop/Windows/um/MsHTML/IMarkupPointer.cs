// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3050F49F-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct IMarkupPointer : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IMarkupPointer
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMarkupPointer*, Guid*, void**, int>)(lpVtbl[0]))((IMarkupPointer*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMarkupPointer*, uint>)(lpVtbl[1]))((IMarkupPointer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMarkupPointer*, uint>)(lpVtbl[2]))((IMarkupPointer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int OwningDoc(IHTMLDocument2** ppDoc)
        {
            return ((delegate* unmanaged<IMarkupPointer*, IHTMLDocument2**, int>)(lpVtbl[3]))((IMarkupPointer*)Unsafe.AsPointer(ref this), ppDoc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int Gravity(POINTER_GRAVITY* pGravity)
        {
            return ((delegate* unmanaged<IMarkupPointer*, POINTER_GRAVITY*, int>)(lpVtbl[4]))((IMarkupPointer*)Unsafe.AsPointer(ref this), pGravity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int SetGravity(POINTER_GRAVITY Gravity)
        {
            return ((delegate* unmanaged<IMarkupPointer*, POINTER_GRAVITY, int>)(lpVtbl[5]))((IMarkupPointer*)Unsafe.AsPointer(ref this), Gravity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int Cling(BOOL* pfCling)
        {
            return ((delegate* unmanaged<IMarkupPointer*, BOOL*, int>)(lpVtbl[6]))((IMarkupPointer*)Unsafe.AsPointer(ref this), pfCling);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int SetCling(BOOL fCLing)
        {
            return ((delegate* unmanaged<IMarkupPointer*, BOOL, int>)(lpVtbl[7]))((IMarkupPointer*)Unsafe.AsPointer(ref this), fCLing);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int Unposition()
        {
            return ((delegate* unmanaged<IMarkupPointer*, int>)(lpVtbl[8]))((IMarkupPointer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int IsPositioned(BOOL* pfPositioned)
        {
            return ((delegate* unmanaged<IMarkupPointer*, BOOL*, int>)(lpVtbl[9]))((IMarkupPointer*)Unsafe.AsPointer(ref this), pfPositioned);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int GetContainer(IMarkupContainer** ppContainer)
        {
            return ((delegate* unmanaged<IMarkupPointer*, IMarkupContainer**, int>)(lpVtbl[10]))((IMarkupPointer*)Unsafe.AsPointer(ref this), ppContainer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int MoveAdjacentToElement(IHTMLElement* pElement, ELEMENT_ADJACENCY eAdj)
        {
            return ((delegate* unmanaged<IMarkupPointer*, IHTMLElement*, ELEMENT_ADJACENCY, int>)(lpVtbl[11]))((IMarkupPointer*)Unsafe.AsPointer(ref this), pElement, eAdj);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int MoveToPointer(IMarkupPointer* pPointer)
        {
            return ((delegate* unmanaged<IMarkupPointer*, IMarkupPointer*, int>)(lpVtbl[12]))((IMarkupPointer*)Unsafe.AsPointer(ref this), pPointer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int MoveToContainer(IMarkupContainer* pContainer, BOOL fAtStart)
        {
            return ((delegate* unmanaged<IMarkupPointer*, IMarkupContainer*, BOOL, int>)(lpVtbl[13]))((IMarkupPointer*)Unsafe.AsPointer(ref this), pContainer, fAtStart);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int Left(BOOL fMove, MARKUP_CONTEXT_TYPE* pContext, IHTMLElement** ppElement, [NativeTypeName("long *")] int* pcch, [NativeTypeName("OLECHAR *")] ushort* pchText)
        {
            return ((delegate* unmanaged<IMarkupPointer*, BOOL, MARKUP_CONTEXT_TYPE*, IHTMLElement**, int*, ushort*, int>)(lpVtbl[14]))((IMarkupPointer*)Unsafe.AsPointer(ref this), fMove, pContext, ppElement, pcch, pchText);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        public int Right(BOOL fMove, MARKUP_CONTEXT_TYPE* pContext, IHTMLElement** ppElement, [NativeTypeName("long *")] int* pcch, [NativeTypeName("OLECHAR *")] ushort* pchText)
        {
            return ((delegate* unmanaged<IMarkupPointer*, BOOL, MARKUP_CONTEXT_TYPE*, IHTMLElement**, int*, ushort*, int>)(lpVtbl[15]))((IMarkupPointer*)Unsafe.AsPointer(ref this), fMove, pContext, ppElement, pcch, pchText);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("HRESULT")]
        public int CurrentScope(IHTMLElement** ppElemCurrent)
        {
            return ((delegate* unmanaged<IMarkupPointer*, IHTMLElement**, int>)(lpVtbl[16]))((IMarkupPointer*)Unsafe.AsPointer(ref this), ppElemCurrent);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        [return: NativeTypeName("HRESULT")]
        public int IsLeftOf(IMarkupPointer* pPointerThat, BOOL* pfResult)
        {
            return ((delegate* unmanaged<IMarkupPointer*, IMarkupPointer*, BOOL*, int>)(lpVtbl[17]))((IMarkupPointer*)Unsafe.AsPointer(ref this), pPointerThat, pfResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        [return: NativeTypeName("HRESULT")]
        public int IsLeftOfOrEqualTo(IMarkupPointer* pPointerThat, BOOL* pfResult)
        {
            return ((delegate* unmanaged<IMarkupPointer*, IMarkupPointer*, BOOL*, int>)(lpVtbl[18]))((IMarkupPointer*)Unsafe.AsPointer(ref this), pPointerThat, pfResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        [return: NativeTypeName("HRESULT")]
        public int IsRightOf(IMarkupPointer* pPointerThat, BOOL* pfResult)
        {
            return ((delegate* unmanaged<IMarkupPointer*, IMarkupPointer*, BOOL*, int>)(lpVtbl[19]))((IMarkupPointer*)Unsafe.AsPointer(ref this), pPointerThat, pfResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        [return: NativeTypeName("HRESULT")]
        public int IsRightOfOrEqualTo(IMarkupPointer* pPointerThat, BOOL* pfResult)
        {
            return ((delegate* unmanaged<IMarkupPointer*, IMarkupPointer*, BOOL*, int>)(lpVtbl[20]))((IMarkupPointer*)Unsafe.AsPointer(ref this), pPointerThat, pfResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        [return: NativeTypeName("HRESULT")]
        public int IsEqualTo(IMarkupPointer* pPointerThat, BOOL* pfAreEqual)
        {
            return ((delegate* unmanaged<IMarkupPointer*, IMarkupPointer*, BOOL*, int>)(lpVtbl[21]))((IMarkupPointer*)Unsafe.AsPointer(ref this), pPointerThat, pfAreEqual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        [return: NativeTypeName("HRESULT")]
        public int MoveUnit(MOVEUNIT_ACTION muAction)
        {
            return ((delegate* unmanaged<IMarkupPointer*, MOVEUNIT_ACTION, int>)(lpVtbl[22]))((IMarkupPointer*)Unsafe.AsPointer(ref this), muAction);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        [return: NativeTypeName("HRESULT")]
        public int FindTextW([NativeTypeName("OLECHAR *")] ushort* pchFindText, [NativeTypeName("DWORD")] uint dwFlags, IMarkupPointer* pIEndMatch, IMarkupPointer* pIEndSearch)
        {
            return ((delegate* unmanaged<IMarkupPointer*, ushort*, uint, IMarkupPointer*, IMarkupPointer*, int>)(lpVtbl[23]))((IMarkupPointer*)Unsafe.AsPointer(ref this), pchFindText, dwFlags, pIEndMatch, pIEndSearch);
        }
    }
}
