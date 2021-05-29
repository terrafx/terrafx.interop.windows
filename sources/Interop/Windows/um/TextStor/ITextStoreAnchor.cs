// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/TextStor.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("9B2077B0-5F18-4DEC-BEE9-3CC722F5DFE0")]
    [NativeTypeName("struct ITextStoreAnchor : IUnknown")]
    public unsafe partial struct ITextStoreAnchor
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ITextStoreAnchor*, Guid*, void**, int>)(lpVtbl[0]))((ITextStoreAnchor*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITextStoreAnchor*, uint>)(lpVtbl[1]))((ITextStoreAnchor*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITextStoreAnchor*, uint>)(lpVtbl[2]))((ITextStoreAnchor*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AdviseSink([NativeTypeName("const IID &")] Guid* riid, IUnknown* punk, [NativeTypeName("DWORD")] uint dwMask)
        {
            return ((delegate* unmanaged<ITextStoreAnchor*, Guid*, IUnknown*, uint, int>)(lpVtbl[3]))((ITextStoreAnchor*)Unsafe.AsPointer(ref this), riid, punk, dwMask);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int UnadviseSink(IUnknown* punk)
        {
            return ((delegate* unmanaged<ITextStoreAnchor*, IUnknown*, int>)(lpVtbl[4]))((ITextStoreAnchor*)Unsafe.AsPointer(ref this), punk);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RequestLock([NativeTypeName("DWORD")] uint dwLockFlags, [NativeTypeName("HRESULT *")] int* phrSession)
        {
            return ((delegate* unmanaged<ITextStoreAnchor*, uint, int*, int>)(lpVtbl[5]))((ITextStoreAnchor*)Unsafe.AsPointer(ref this), dwLockFlags, phrSession);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetStatus(TS_STATUS* pdcs)
        {
            return ((delegate* unmanaged<ITextStoreAnchor*, TS_STATUS*, int>)(lpVtbl[6]))((ITextStoreAnchor*)Unsafe.AsPointer(ref this), pdcs);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInsert(IAnchor* paTestStart, IAnchor* paTestEnd, [NativeTypeName("ULONG")] uint cch, IAnchor** ppaResultStart, IAnchor** ppaResultEnd)
        {
            return ((delegate* unmanaged<ITextStoreAnchor*, IAnchor*, IAnchor*, uint, IAnchor**, IAnchor**, int>)(lpVtbl[7]))((ITextStoreAnchor*)Unsafe.AsPointer(ref this), paTestStart, paTestEnd, cch, ppaResultStart, ppaResultEnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSelection([NativeTypeName("ULONG")] uint ulIndex, [NativeTypeName("ULONG")] uint ulCount, TS_SELECTION_ANCHOR* pSelection, [NativeTypeName("ULONG *")] uint* pcFetched)
        {
            return ((delegate* unmanaged<ITextStoreAnchor*, uint, uint, TS_SELECTION_ANCHOR*, uint*, int>)(lpVtbl[8]))((ITextStoreAnchor*)Unsafe.AsPointer(ref this), ulIndex, ulCount, pSelection, pcFetched);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetSelection([NativeTypeName("ULONG")] uint ulCount, [NativeTypeName("const TS_SELECTION_ANCHOR *")] TS_SELECTION_ANCHOR* pSelection)
        {
            return ((delegate* unmanaged<ITextStoreAnchor*, uint, TS_SELECTION_ANCHOR*, int>)(lpVtbl[9]))((ITextStoreAnchor*)Unsafe.AsPointer(ref this), ulCount, pSelection);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetText([NativeTypeName("DWORD")] uint dwFlags, IAnchor* paStart, IAnchor* paEnd, [NativeTypeName("WCHAR *")] ushort* pchText, [NativeTypeName("ULONG")] uint cchReq, [NativeTypeName("ULONG *")] uint* pcch, [NativeTypeName("BOOL")] int fUpdateAnchor)
        {
            return ((delegate* unmanaged<ITextStoreAnchor*, uint, IAnchor*, IAnchor*, ushort*, uint, uint*, int, int>)(lpVtbl[10]))((ITextStoreAnchor*)Unsafe.AsPointer(ref this), dwFlags, paStart, paEnd, pchText, cchReq, pcch, fUpdateAnchor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetText([NativeTypeName("DWORD")] uint dwFlags, IAnchor* paStart, IAnchor* paEnd, [NativeTypeName("const WCHAR *")] ushort* pchText, [NativeTypeName("ULONG")] uint cch)
        {
            return ((delegate* unmanaged<ITextStoreAnchor*, uint, IAnchor*, IAnchor*, ushort*, uint, int>)(lpVtbl[11]))((ITextStoreAnchor*)Unsafe.AsPointer(ref this), dwFlags, paStart, paEnd, pchText, cch);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFormattedText(IAnchor* paStart, IAnchor* paEnd, IDataObject** ppDataObject)
        {
            return ((delegate* unmanaged<ITextStoreAnchor*, IAnchor*, IAnchor*, IDataObject**, int>)(lpVtbl[12]))((ITextStoreAnchor*)Unsafe.AsPointer(ref this), paStart, paEnd, ppDataObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetEmbedded([NativeTypeName("DWORD")] uint dwFlags, IAnchor* paPos, [NativeTypeName("const GUID &")] Guid* rguidService, [NativeTypeName("const IID &")] Guid* riid, IUnknown** ppunk)
        {
            return ((delegate* unmanaged<ITextStoreAnchor*, uint, IAnchor*, Guid*, Guid*, IUnknown**, int>)(lpVtbl[13]))((ITextStoreAnchor*)Unsafe.AsPointer(ref this), dwFlags, paPos, rguidService, riid, ppunk);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int InsertEmbedded([NativeTypeName("DWORD")] uint dwFlags, IAnchor* paStart, IAnchor* paEnd, IDataObject* pDataObject)
        {
            return ((delegate* unmanaged<ITextStoreAnchor*, uint, IAnchor*, IAnchor*, IDataObject*, int>)(lpVtbl[14]))((ITextStoreAnchor*)Unsafe.AsPointer(ref this), dwFlags, paStart, paEnd, pDataObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RequestSupportedAttrs([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("ULONG")] uint cFilterAttrs, [NativeTypeName("const TS_ATTRID *")] Guid* paFilterAttrs)
        {
            return ((delegate* unmanaged<ITextStoreAnchor*, uint, uint, Guid*, int>)(lpVtbl[15]))((ITextStoreAnchor*)Unsafe.AsPointer(ref this), dwFlags, cFilterAttrs, paFilterAttrs);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RequestAttrsAtPosition(IAnchor* paPos, [NativeTypeName("ULONG")] uint cFilterAttrs, [NativeTypeName("const TS_ATTRID *")] Guid* paFilterAttrs, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* unmanaged<ITextStoreAnchor*, IAnchor*, uint, Guid*, uint, int>)(lpVtbl[16]))((ITextStoreAnchor*)Unsafe.AsPointer(ref this), paPos, cFilterAttrs, paFilterAttrs, dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RequestAttrsTransitioningAtPosition(IAnchor* paPos, [NativeTypeName("ULONG")] uint cFilterAttrs, [NativeTypeName("const TS_ATTRID *")] Guid* paFilterAttrs, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* unmanaged<ITextStoreAnchor*, IAnchor*, uint, Guid*, uint, int>)(lpVtbl[17]))((ITextStoreAnchor*)Unsafe.AsPointer(ref this), paPos, cFilterAttrs, paFilterAttrs, dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int FindNextAttrTransition(IAnchor* paStart, IAnchor* paHalt, [NativeTypeName("ULONG")] uint cFilterAttrs, [NativeTypeName("const TS_ATTRID *")] Guid* paFilterAttrs, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("BOOL *")] int* pfFound, [NativeTypeName("LONG *")] int* plFoundOffset)
        {
            return ((delegate* unmanaged<ITextStoreAnchor*, IAnchor*, IAnchor*, uint, Guid*, uint, int*, int*, int>)(lpVtbl[18]))((ITextStoreAnchor*)Unsafe.AsPointer(ref this), paStart, paHalt, cFilterAttrs, paFilterAttrs, dwFlags, pfFound, plFoundOffset);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RetrieveRequestedAttrs([NativeTypeName("ULONG")] uint ulCount, TS_ATTRVAL* paAttrVals, [NativeTypeName("ULONG *")] uint* pcFetched)
        {
            return ((delegate* unmanaged<ITextStoreAnchor*, uint, TS_ATTRVAL*, uint*, int>)(lpVtbl[19]))((ITextStoreAnchor*)Unsafe.AsPointer(ref this), ulCount, paAttrVals, pcFetched);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetStart(IAnchor** ppaStart)
        {
            return ((delegate* unmanaged<ITextStoreAnchor*, IAnchor**, int>)(lpVtbl[20]))((ITextStoreAnchor*)Unsafe.AsPointer(ref this), ppaStart);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetEnd(IAnchor** ppaEnd)
        {
            return ((delegate* unmanaged<ITextStoreAnchor*, IAnchor**, int>)(lpVtbl[21]))((ITextStoreAnchor*)Unsafe.AsPointer(ref this), ppaEnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetActiveView([NativeTypeName("TsViewCookie *")] uint* pvcView)
        {
            return ((delegate* unmanaged<ITextStoreAnchor*, uint*, int>)(lpVtbl[22]))((ITextStoreAnchor*)Unsafe.AsPointer(ref this), pvcView);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetAnchorFromPoint([NativeTypeName("TsViewCookie")] uint vcView, [NativeTypeName("const POINT *")] POINT* ptScreen, [NativeTypeName("DWORD")] uint dwFlags, IAnchor** ppaSite)
        {
            return ((delegate* unmanaged<ITextStoreAnchor*, uint, POINT*, uint, IAnchor**, int>)(lpVtbl[23]))((ITextStoreAnchor*)Unsafe.AsPointer(ref this), vcView, ptScreen, dwFlags, ppaSite);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTextExt([NativeTypeName("TsViewCookie")] uint vcView, IAnchor* paStart, IAnchor* paEnd, RECT* prc, [NativeTypeName("BOOL *")] int* pfClipped)
        {
            return ((delegate* unmanaged<ITextStoreAnchor*, uint, IAnchor*, IAnchor*, RECT*, int*, int>)(lpVtbl[24]))((ITextStoreAnchor*)Unsafe.AsPointer(ref this), vcView, paStart, paEnd, prc, pfClipped);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetScreenExt([NativeTypeName("TsViewCookie")] uint vcView, RECT* prc)
        {
            return ((delegate* unmanaged<ITextStoreAnchor*, uint, RECT*, int>)(lpVtbl[25]))((ITextStoreAnchor*)Unsafe.AsPointer(ref this), vcView, prc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetWnd([NativeTypeName("TsViewCookie")] uint vcView, [NativeTypeName("HWND *")] IntPtr* phwnd)
        {
            return ((delegate* unmanaged<ITextStoreAnchor*, uint, IntPtr*, int>)(lpVtbl[26]))((ITextStoreAnchor*)Unsafe.AsPointer(ref this), vcView, phwnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInsertEmbedded([NativeTypeName("const GUID *")] Guid* pguidService, [NativeTypeName("const FORMATETC *")] FORMATETC* pFormatEtc, [NativeTypeName("BOOL *")] int* pfInsertable)
        {
            return ((delegate* unmanaged<ITextStoreAnchor*, Guid*, FORMATETC*, int*, int>)(lpVtbl[27]))((ITextStoreAnchor*)Unsafe.AsPointer(ref this), pguidService, pFormatEtc, pfInsertable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int InsertTextAtSelection([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("const WCHAR *")] ushort* pchText, [NativeTypeName("ULONG")] uint cch, IAnchor** ppaStart, IAnchor** ppaEnd)
        {
            return ((delegate* unmanaged<ITextStoreAnchor*, uint, ushort*, uint, IAnchor**, IAnchor**, int>)(lpVtbl[28]))((ITextStoreAnchor*)Unsafe.AsPointer(ref this), dwFlags, pchText, cch, ppaStart, ppaEnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int InsertEmbeddedAtSelection([NativeTypeName("DWORD")] uint dwFlags, IDataObject* pDataObject, IAnchor** ppaStart, IAnchor** ppaEnd)
        {
            return ((delegate* unmanaged<ITextStoreAnchor*, uint, IDataObject*, IAnchor**, IAnchor**, int>)(lpVtbl[29]))((ITextStoreAnchor*)Unsafe.AsPointer(ref this), dwFlags, pDataObject, ppaStart, ppaEnd);
        }
    }
}
