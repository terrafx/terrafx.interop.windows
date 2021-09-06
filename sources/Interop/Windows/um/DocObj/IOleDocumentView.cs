// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DocObj.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("B722BCC6-4E68-101B-A2BC-00AA00404770")]
    [NativeTypeName("struct IOleDocumentView : IUnknown")]
    public unsafe partial struct IOleDocumentView
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IOleDocumentView*, Guid*, void**, int>)(lpVtbl[0]))((IOleDocumentView*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IOleDocumentView*, uint>)(lpVtbl[1]))((IOleDocumentView*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IOleDocumentView*, uint>)(lpVtbl[2]))((IOleDocumentView*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetInPlaceSite(IOleInPlaceSite* pIPSite)
        {
            return ((delegate* unmanaged<IOleDocumentView*, IOleInPlaceSite*, int>)(lpVtbl[3]))((IOleDocumentView*)Unsafe.AsPointer(ref this), pIPSite);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetInPlaceSite(IOleInPlaceSite** ppIPSite)
        {
            return ((delegate* unmanaged<IOleDocumentView*, IOleInPlaceSite**, int>)(lpVtbl[4]))((IOleDocumentView*)Unsafe.AsPointer(ref this), ppIPSite);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDocument(IUnknown** ppunk)
        {
            return ((delegate* unmanaged<IOleDocumentView*, IUnknown**, int>)(lpVtbl[5]))((IOleDocumentView*)Unsafe.AsPointer(ref this), ppunk);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetRect([NativeTypeName("LPRECT")] RECT* prcView)
        {
            return ((delegate* unmanaged<IOleDocumentView*, RECT*, int>)(lpVtbl[6]))((IOleDocumentView*)Unsafe.AsPointer(ref this), prcView);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRect([NativeTypeName("LPRECT")] RECT* prcView)
        {
            return ((delegate* unmanaged<IOleDocumentView*, RECT*, int>)(lpVtbl[7]))((IOleDocumentView*)Unsafe.AsPointer(ref this), prcView);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetRectComplex([NativeTypeName("LPRECT")] RECT* prcView, [NativeTypeName("LPRECT")] RECT* prcHScroll, [NativeTypeName("LPRECT")] RECT* prcVScroll, [NativeTypeName("LPRECT")] RECT* prcSizeBox)
        {
            return ((delegate* unmanaged<IOleDocumentView*, RECT*, RECT*, RECT*, RECT*, int>)(lpVtbl[8]))((IOleDocumentView*)Unsafe.AsPointer(ref this), prcView, prcHScroll, prcVScroll, prcSizeBox);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Show([NativeTypeName("BOOL")] int fShow)
        {
            return ((delegate* unmanaged<IOleDocumentView*, int, int>)(lpVtbl[9]))((IOleDocumentView*)Unsafe.AsPointer(ref this), fShow);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int UIActivate([NativeTypeName("BOOL")] int fUIActivate)
        {
            return ((delegate* unmanaged<IOleDocumentView*, int, int>)(lpVtbl[10]))((IOleDocumentView*)Unsafe.AsPointer(ref this), fUIActivate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Open()
        {
            return ((delegate* unmanaged<IOleDocumentView*, int>)(lpVtbl[11]))((IOleDocumentView*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CloseView([NativeTypeName("DWORD")] uint dwReserved)
        {
            return ((delegate* unmanaged<IOleDocumentView*, uint, int>)(lpVtbl[12]))((IOleDocumentView*)Unsafe.AsPointer(ref this), dwReserved);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SaveViewState([NativeTypeName("LPSTREAM")] IStream* pstm)
        {
            return ((delegate* unmanaged<IOleDocumentView*, IStream*, int>)(lpVtbl[13]))((IOleDocumentView*)Unsafe.AsPointer(ref this), pstm);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ApplyViewState([NativeTypeName("LPSTREAM")] IStream* pstm)
        {
            return ((delegate* unmanaged<IOleDocumentView*, IStream*, int>)(lpVtbl[14]))((IOleDocumentView*)Unsafe.AsPointer(ref this), pstm);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Clone(IOleInPlaceSite* pIPSiteNew, IOleDocumentView** ppViewNew)
        {
            return ((delegate* unmanaged<IOleDocumentView*, IOleInPlaceSite*, IOleDocumentView**, int>)(lpVtbl[15]))((IOleDocumentView*)Unsafe.AsPointer(ref this), pIPSiteNew, ppViewNew);
        }
    }
}
