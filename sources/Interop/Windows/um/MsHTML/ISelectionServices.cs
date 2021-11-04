// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3050F684-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct ISelectionServices : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ISelectionServices
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISelectionServices*, Guid*, void**, int>)(lpVtbl[0]))((ISelectionServices*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISelectionServices*, uint>)(lpVtbl[1]))((ISelectionServices*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISelectionServices*, uint>)(lpVtbl[2]))((ISelectionServices*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT SetSelectionType(SELECTION_TYPE eType, ISelectionServicesListener* pIListener)
        {
            return ((delegate* unmanaged<ISelectionServices*, SELECTION_TYPE, ISelectionServicesListener*, int>)(lpVtbl[3]))((ISelectionServices*)Unsafe.AsPointer(ref this), eType, pIListener);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetMarkupContainer(IMarkupContainer** ppIContainer)
        {
            return ((delegate* unmanaged<ISelectionServices*, IMarkupContainer**, int>)(lpVtbl[4]))((ISelectionServices*)Unsafe.AsPointer(ref this), ppIContainer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT AddSegment(IMarkupPointer* pIStart, IMarkupPointer* pIEnd, ISegment** ppISegmentAdded)
        {
            return ((delegate* unmanaged<ISelectionServices*, IMarkupPointer*, IMarkupPointer*, ISegment**, int>)(lpVtbl[5]))((ISelectionServices*)Unsafe.AsPointer(ref this), pIStart, pIEnd, ppISegmentAdded);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT AddElementSegment(IHTMLElement* pIElement, IElementSegment** ppISegmentAdded)
        {
            return ((delegate* unmanaged<ISelectionServices*, IHTMLElement*, IElementSegment**, int>)(lpVtbl[6]))((ISelectionServices*)Unsafe.AsPointer(ref this), pIElement, ppISegmentAdded);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT RemoveSegment(ISegment* pISegment)
        {
            return ((delegate* unmanaged<ISelectionServices*, ISegment*, int>)(lpVtbl[7]))((ISelectionServices*)Unsafe.AsPointer(ref this), pISegment);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT GetSelectionServicesListener(ISelectionServicesListener** ppISelectionServicesListener)
        {
            return ((delegate* unmanaged<ISelectionServices*, ISelectionServicesListener**, int>)(lpVtbl[8]))((ISelectionServices*)Unsafe.AsPointer(ref this), ppISelectionServicesListener);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<ISelectionServices*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ISelectionServices*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ISelectionServices*, uint> Release;

            [NativeTypeName("HRESULT (SELECTION_TYPE, ISelectionServicesListener *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISelectionServices*, SELECTION_TYPE, ISelectionServicesListener*, int> SetSelectionType;

            [NativeTypeName("HRESULT (IMarkupContainer **) __attribute__((stdcall))")]
            public delegate* unmanaged<ISelectionServices*, IMarkupContainer**, int> GetMarkupContainer;

            [NativeTypeName("HRESULT (IMarkupPointer *, IMarkupPointer *, ISegment **) __attribute__((stdcall))")]
            public delegate* unmanaged<ISelectionServices*, IMarkupPointer*, IMarkupPointer*, ISegment**, int> AddSegment;

            [NativeTypeName("HRESULT (IHTMLElement *, IElementSegment **) __attribute__((stdcall))")]
            public delegate* unmanaged<ISelectionServices*, IHTMLElement*, IElementSegment**, int> AddElementSegment;

            [NativeTypeName("HRESULT (ISegment *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISelectionServices*, ISegment*, int> RemoveSegment;

            [NativeTypeName("HRESULT (ISelectionServicesListener **) __attribute__((stdcall))")]
            public delegate* unmanaged<ISelectionServices*, ISelectionServicesListener**, int> GetSelectionServicesListener;
        }
    }
}
