// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3050F812-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct IHTMLEditServices2 : IHTMLEditServices")]
    [NativeInheritance("IHTMLEditServices")]
    public unsafe partial struct IHTMLEditServices2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IHTMLEditServices2*, Guid*, void**, int>)(lpVtbl[0]))((IHTMLEditServices2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IHTMLEditServices2*, uint>)(lpVtbl[1]))((IHTMLEditServices2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IHTMLEditServices2*, uint>)(lpVtbl[2]))((IHTMLEditServices2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int AddDesigner(IHTMLEditDesigner* pIDesigner)
        {
            return ((delegate* unmanaged<IHTMLEditServices2*, IHTMLEditDesigner*, int>)(lpVtbl[3]))((IHTMLEditServices2*)Unsafe.AsPointer(ref this), pIDesigner);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int RemoveDesigner(IHTMLEditDesigner* pIDesigner)
        {
            return ((delegate* unmanaged<IHTMLEditServices2*, IHTMLEditDesigner*, int>)(lpVtbl[4]))((IHTMLEditServices2*)Unsafe.AsPointer(ref this), pIDesigner);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetSelectionServices(IMarkupContainer* pIContainer, ISelectionServices** ppSelSvc)
        {
            return ((delegate* unmanaged<IHTMLEditServices2*, IMarkupContainer*, ISelectionServices**, int>)(lpVtbl[5]))((IHTMLEditServices2*)Unsafe.AsPointer(ref this), pIContainer, ppSelSvc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int MoveToSelectionAnchor(IMarkupPointer* pIStartAnchor)
        {
            return ((delegate* unmanaged<IHTMLEditServices2*, IMarkupPointer*, int>)(lpVtbl[6]))((IHTMLEditServices2*)Unsafe.AsPointer(ref this), pIStartAnchor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int MoveToSelectionEnd(IMarkupPointer* pIEndAnchor)
        {
            return ((delegate* unmanaged<IHTMLEditServices2*, IMarkupPointer*, int>)(lpVtbl[7]))((IHTMLEditServices2*)Unsafe.AsPointer(ref this), pIEndAnchor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int SelectRange(IMarkupPointer* pStart, IMarkupPointer* pEnd, SELECTION_TYPE eType)
        {
            return ((delegate* unmanaged<IHTMLEditServices2*, IMarkupPointer*, IMarkupPointer*, SELECTION_TYPE, int>)(lpVtbl[8]))((IHTMLEditServices2*)Unsafe.AsPointer(ref this), pStart, pEnd, eType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int MoveToSelectionAnchorEx(IDisplayPointer* pIStartAnchor)
        {
            return ((delegate* unmanaged<IHTMLEditServices2*, IDisplayPointer*, int>)(lpVtbl[9]))((IHTMLEditServices2*)Unsafe.AsPointer(ref this), pIStartAnchor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int MoveToSelectionEndEx(IDisplayPointer* pIEndAnchor)
        {
            return ((delegate* unmanaged<IHTMLEditServices2*, IDisplayPointer*, int>)(lpVtbl[10]))((IHTMLEditServices2*)Unsafe.AsPointer(ref this), pIEndAnchor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int FreezeVirtualCaretPos(BOOL fReCompute)
        {
            return ((delegate* unmanaged<IHTMLEditServices2*, BOOL, int>)(lpVtbl[11]))((IHTMLEditServices2*)Unsafe.AsPointer(ref this), fReCompute);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int UnFreezeVirtualCaretPos(BOOL fReset)
        {
            return ((delegate* unmanaged<IHTMLEditServices2*, BOOL, int>)(lpVtbl[12]))((IHTMLEditServices2*)Unsafe.AsPointer(ref this), fReset);
        }
    }
}
