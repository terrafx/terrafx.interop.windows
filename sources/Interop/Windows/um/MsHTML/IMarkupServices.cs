// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3050F4A0-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct IMarkupServices : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IMarkupServices
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMarkupServices*, Guid*, void**, int>)(lpVtbl[0]))((IMarkupServices*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMarkupServices*, uint>)(lpVtbl[1]))((IMarkupServices*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMarkupServices*, uint>)(lpVtbl[2]))((IMarkupServices*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int CreateMarkupPointer(IMarkupPointer** ppPointer)
        {
            return ((delegate* unmanaged<IMarkupServices*, IMarkupPointer**, int>)(lpVtbl[3]))((IMarkupServices*)Unsafe.AsPointer(ref this), ppPointer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int CreateMarkupContainer(IMarkupContainer** ppMarkupContainer)
        {
            return ((delegate* unmanaged<IMarkupServices*, IMarkupContainer**, int>)(lpVtbl[4]))((IMarkupServices*)Unsafe.AsPointer(ref this), ppMarkupContainer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int CreateElement(ELEMENT_TAG_ID tagID, [NativeTypeName("OLECHAR *")] ushort* pchAttributes, IHTMLElement** ppElement)
        {
            return ((delegate* unmanaged<IMarkupServices*, ELEMENT_TAG_ID, ushort*, IHTMLElement**, int>)(lpVtbl[5]))((IMarkupServices*)Unsafe.AsPointer(ref this), tagID, pchAttributes, ppElement);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int CloneElement(IHTMLElement* pElemCloneThis, IHTMLElement** ppElementTheClone)
        {
            return ((delegate* unmanaged<IMarkupServices*, IHTMLElement*, IHTMLElement**, int>)(lpVtbl[6]))((IMarkupServices*)Unsafe.AsPointer(ref this), pElemCloneThis, ppElementTheClone);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int InsertElement(IHTMLElement* pElementInsert, IMarkupPointer* pPointerStart, IMarkupPointer* pPointerFinish)
        {
            return ((delegate* unmanaged<IMarkupServices*, IHTMLElement*, IMarkupPointer*, IMarkupPointer*, int>)(lpVtbl[7]))((IMarkupServices*)Unsafe.AsPointer(ref this), pElementInsert, pPointerStart, pPointerFinish);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int RemoveElement(IHTMLElement* pElementRemove)
        {
            return ((delegate* unmanaged<IMarkupServices*, IHTMLElement*, int>)(lpVtbl[8]))((IMarkupServices*)Unsafe.AsPointer(ref this), pElementRemove);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int Remove(IMarkupPointer* pPointerStart, IMarkupPointer* pPointerFinish)
        {
            return ((delegate* unmanaged<IMarkupServices*, IMarkupPointer*, IMarkupPointer*, int>)(lpVtbl[9]))((IMarkupServices*)Unsafe.AsPointer(ref this), pPointerStart, pPointerFinish);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int Copy(IMarkupPointer* pPointerSourceStart, IMarkupPointer* pPointerSourceFinish, IMarkupPointer* pPointerTarget)
        {
            return ((delegate* unmanaged<IMarkupServices*, IMarkupPointer*, IMarkupPointer*, IMarkupPointer*, int>)(lpVtbl[10]))((IMarkupServices*)Unsafe.AsPointer(ref this), pPointerSourceStart, pPointerSourceFinish, pPointerTarget);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int Move(IMarkupPointer* pPointerSourceStart, IMarkupPointer* pPointerSourceFinish, IMarkupPointer* pPointerTarget)
        {
            return ((delegate* unmanaged<IMarkupServices*, IMarkupPointer*, IMarkupPointer*, IMarkupPointer*, int>)(lpVtbl[11]))((IMarkupServices*)Unsafe.AsPointer(ref this), pPointerSourceStart, pPointerSourceFinish, pPointerTarget);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int InsertText([NativeTypeName("OLECHAR *")] ushort* pchText, [NativeTypeName("long")] int cch, IMarkupPointer* pPointerTarget)
        {
            return ((delegate* unmanaged<IMarkupServices*, ushort*, int, IMarkupPointer*, int>)(lpVtbl[12]))((IMarkupServices*)Unsafe.AsPointer(ref this), pchText, cch, pPointerTarget);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int ParseString([NativeTypeName("OLECHAR *")] ushort* pchHTML, [NativeTypeName("DWORD")] uint dwFlags, IMarkupContainer** ppContainerResult, IMarkupPointer* ppPointerStart, IMarkupPointer* ppPointerFinish)
        {
            return ((delegate* unmanaged<IMarkupServices*, ushort*, uint, IMarkupContainer**, IMarkupPointer*, IMarkupPointer*, int>)(lpVtbl[13]))((IMarkupServices*)Unsafe.AsPointer(ref this), pchHTML, dwFlags, ppContainerResult, ppPointerStart, ppPointerFinish);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int ParseGlobal([NativeTypeName("HGLOBAL")] IntPtr hglobalHTML, [NativeTypeName("DWORD")] uint dwFlags, IMarkupContainer** ppContainerResult, IMarkupPointer* pPointerStart, IMarkupPointer* pPointerFinish)
        {
            return ((delegate* unmanaged<IMarkupServices*, IntPtr, uint, IMarkupContainer**, IMarkupPointer*, IMarkupPointer*, int>)(lpVtbl[14]))((IMarkupServices*)Unsafe.AsPointer(ref this), hglobalHTML, dwFlags, ppContainerResult, pPointerStart, pPointerFinish);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        public int IsScopedElement(IHTMLElement* pElement, BOOL* pfScoped)
        {
            return ((delegate* unmanaged<IMarkupServices*, IHTMLElement*, BOOL*, int>)(lpVtbl[15]))((IMarkupServices*)Unsafe.AsPointer(ref this), pElement, pfScoped);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("HRESULT")]
        public int GetElementTagId(IHTMLElement* pElement, ELEMENT_TAG_ID* ptagId)
        {
            return ((delegate* unmanaged<IMarkupServices*, IHTMLElement*, ELEMENT_TAG_ID*, int>)(lpVtbl[16]))((IMarkupServices*)Unsafe.AsPointer(ref this), pElement, ptagId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        [return: NativeTypeName("HRESULT")]
        public int GetTagIDForName([NativeTypeName("BSTR")] ushort* bstrName, ELEMENT_TAG_ID* ptagId)
        {
            return ((delegate* unmanaged<IMarkupServices*, ushort*, ELEMENT_TAG_ID*, int>)(lpVtbl[17]))((IMarkupServices*)Unsafe.AsPointer(ref this), bstrName, ptagId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        [return: NativeTypeName("HRESULT")]
        public int GetNameForTagID(ELEMENT_TAG_ID tagId, [NativeTypeName("BSTR *")] ushort** pbstrName)
        {
            return ((delegate* unmanaged<IMarkupServices*, ELEMENT_TAG_ID, ushort**, int>)(lpVtbl[18]))((IMarkupServices*)Unsafe.AsPointer(ref this), tagId, pbstrName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        [return: NativeTypeName("HRESULT")]
        public int MovePointersToRange(IHTMLTxtRange* pIRange, IMarkupPointer* pPointerStart, IMarkupPointer* pPointerFinish)
        {
            return ((delegate* unmanaged<IMarkupServices*, IHTMLTxtRange*, IMarkupPointer*, IMarkupPointer*, int>)(lpVtbl[19]))((IMarkupServices*)Unsafe.AsPointer(ref this), pIRange, pPointerStart, pPointerFinish);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        [return: NativeTypeName("HRESULT")]
        public int MoveRangeToPointers(IMarkupPointer* pPointerStart, IMarkupPointer* pPointerFinish, IHTMLTxtRange* pIRange)
        {
            return ((delegate* unmanaged<IMarkupServices*, IMarkupPointer*, IMarkupPointer*, IHTMLTxtRange*, int>)(lpVtbl[20]))((IMarkupServices*)Unsafe.AsPointer(ref this), pPointerStart, pPointerFinish, pIRange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        [return: NativeTypeName("HRESULT")]
        public int BeginUndoUnit([NativeTypeName("OLECHAR *")] ushort* pchTitle)
        {
            return ((delegate* unmanaged<IMarkupServices*, ushort*, int>)(lpVtbl[21]))((IMarkupServices*)Unsafe.AsPointer(ref this), pchTitle);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        [return: NativeTypeName("HRESULT")]
        public int EndUndoUnit()
        {
            return ((delegate* unmanaged<IMarkupServices*, int>)(lpVtbl[22]))((IMarkupServices*)Unsafe.AsPointer(ref this));
        }
    }
}
