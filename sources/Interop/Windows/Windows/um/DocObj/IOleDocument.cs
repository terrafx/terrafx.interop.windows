// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DocObj.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("B722BCC5-4E68-101B-A2BC-00AA00404770")]
    [NativeTypeName("struct IOleDocument : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IOleDocument : IOleDocument.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IOleDocument*, Guid*, void**, int>)(lpVtbl[0]))((IOleDocument*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IOleDocument*, uint>)(lpVtbl[1]))((IOleDocument*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IOleDocument*, uint>)(lpVtbl[2]))((IOleDocument*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT CreateView(IOleInPlaceSite* pIPSite, IStream* pstm, [NativeTypeName("DWORD")] uint dwReserved, IOleDocumentView** ppView)
        {
            return ((delegate* unmanaged<IOleDocument*, IOleInPlaceSite*, IStream*, uint, IOleDocumentView**, int>)(lpVtbl[3]))((IOleDocument*)Unsafe.AsPointer(ref this), pIPSite, pstm, dwReserved, ppView);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetDocMiscStatus([NativeTypeName("DWORD *")] uint* pdwStatus)
        {
            return ((delegate* unmanaged<IOleDocument*, uint*, int>)(lpVtbl[4]))((IOleDocument*)Unsafe.AsPointer(ref this), pdwStatus);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT EnumViews(IEnumOleDocumentViews** ppEnum, IOleDocumentView** ppView)
        {
            return ((delegate* unmanaged<IOleDocument*, IEnumOleDocumentViews**, IOleDocumentView**, int>)(lpVtbl[5]))((IOleDocument*)Unsafe.AsPointer(ref this), ppEnum, ppView);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT CreateView(IOleInPlaceSite* pIPSite, IStream* pstm, [NativeTypeName("DWORD")] uint dwReserved, IOleDocumentView** ppView);

            [VtblIndex(4)]
            HRESULT GetDocMiscStatus([NativeTypeName("DWORD *")] uint* pdwStatus);

            [VtblIndex(5)]
            HRESULT EnumViews(IEnumOleDocumentViews** ppEnum, IOleDocumentView** ppView);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IOleDocument*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IOleDocument*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IOleDocument*, uint> Release;

            [NativeTypeName("HRESULT (IOleInPlaceSite *, IStream *, DWORD, IOleDocumentView **) __attribute__((stdcall))")]
            public delegate* unmanaged<IOleDocument*, IOleInPlaceSite*, IStream*, uint, IOleDocumentView**, int> CreateView;

            [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged<IOleDocument*, uint*, int> GetDocMiscStatus;

            [NativeTypeName("HRESULT (IEnumOleDocumentViews **, IOleDocumentView **) __attribute__((stdcall))")]
            public delegate* unmanaged<IOleDocument*, IEnumOleDocumentViews**, IOleDocumentView**, int> EnumViews;
        }
    }
}
