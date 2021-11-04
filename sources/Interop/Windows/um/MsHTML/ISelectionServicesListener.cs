// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3050F699-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct ISelectionServicesListener : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ISelectionServicesListener
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISelectionServicesListener*, Guid*, void**, int>)(lpVtbl[0]))((ISelectionServicesListener*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISelectionServicesListener*, uint>)(lpVtbl[1]))((ISelectionServicesListener*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISelectionServicesListener*, uint>)(lpVtbl[2]))((ISelectionServicesListener*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT BeginSelectionUndo()
        {
            return ((delegate* unmanaged<ISelectionServicesListener*, int>)(lpVtbl[3]))((ISelectionServicesListener*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT EndSelectionUndo()
        {
            return ((delegate* unmanaged<ISelectionServicesListener*, int>)(lpVtbl[4]))((ISelectionServicesListener*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT OnSelectedElementExit(IMarkupPointer* pIElementStart, IMarkupPointer* pIElementEnd, IMarkupPointer* pIElementContentStart, IMarkupPointer* pIElementContentEnd)
        {
            return ((delegate* unmanaged<ISelectionServicesListener*, IMarkupPointer*, IMarkupPointer*, IMarkupPointer*, IMarkupPointer*, int>)(lpVtbl[5]))((ISelectionServicesListener*)Unsafe.AsPointer(ref this), pIElementStart, pIElementEnd, pIElementContentStart, pIElementContentEnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT OnChangeType(SELECTION_TYPE eType, ISelectionServicesListener* pIListener)
        {
            return ((delegate* unmanaged<ISelectionServicesListener*, SELECTION_TYPE, ISelectionServicesListener*, int>)(lpVtbl[6]))((ISelectionServicesListener*)Unsafe.AsPointer(ref this), eType, pIListener);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT GetTypeDetail([NativeTypeName("BSTR *")] ushort** pTypeDetail)
        {
            return ((delegate* unmanaged<ISelectionServicesListener*, ushort**, int>)(lpVtbl[7]))((ISelectionServicesListener*)Unsafe.AsPointer(ref this), pTypeDetail);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<ISelectionServicesListener*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ISelectionServicesListener*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ISelectionServicesListener*, uint> Release;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<ISelectionServicesListener*, int> BeginSelectionUndo;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<ISelectionServicesListener*, int> EndSelectionUndo;

            [NativeTypeName("HRESULT (IMarkupPointer *, IMarkupPointer *, IMarkupPointer *, IMarkupPointer *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISelectionServicesListener*, IMarkupPointer*, IMarkupPointer*, IMarkupPointer*, IMarkupPointer*, int> OnSelectedElementExit;

            [NativeTypeName("HRESULT (SELECTION_TYPE, ISelectionServicesListener *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISelectionServicesListener*, SELECTION_TYPE, ISelectionServicesListener*, int> OnChangeType;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISelectionServicesListener*, ushort**, int> GetTypeDetail;
        }
    }
}
