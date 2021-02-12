// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/TextStor.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("F86AD89F-5FE4-4B8D-BB9F-EF3797A84F1F")]
    [NativeTypeName("struct ITextStoreACP2 : IUnknown")]
    public unsafe partial struct ITextStoreACP2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<ITextStoreACP2*, Guid*, void**, int>)(lpVtbl[0]))((ITextStoreACP2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITextStoreACP2*, uint>)(lpVtbl[1]))((ITextStoreACP2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITextStoreACP2*, uint>)(lpVtbl[2]))((ITextStoreACP2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AdviseSink([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("IUnknown *")] IUnknown* punk, [NativeTypeName("DWORD")] uint dwMask)
        {
            return ((delegate* unmanaged<ITextStoreACP2*, Guid*, IUnknown*, uint, int>)(lpVtbl[3]))((ITextStoreACP2*)Unsafe.AsPointer(ref this), riid, punk, dwMask);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int UnadviseSink([NativeTypeName("IUnknown *")] IUnknown* punk)
        {
            return ((delegate* unmanaged<ITextStoreACP2*, IUnknown*, int>)(lpVtbl[4]))((ITextStoreACP2*)Unsafe.AsPointer(ref this), punk);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RequestLock([NativeTypeName("DWORD")] uint dwLockFlags, [NativeTypeName("HRESULT *")] int* phrSession)
        {
            return ((delegate* unmanaged<ITextStoreACP2*, uint, int*, int>)(lpVtbl[5]))((ITextStoreACP2*)Unsafe.AsPointer(ref this), dwLockFlags, phrSession);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetStatus([NativeTypeName("TS_STATUS *")] TS_STATUS* pdcs)
        {
            return ((delegate* unmanaged<ITextStoreACP2*, TS_STATUS*, int>)(lpVtbl[6]))((ITextStoreACP2*)Unsafe.AsPointer(ref this), pdcs);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInsert([NativeTypeName("LONG")] int acpTestStart, [NativeTypeName("LONG")] int acpTestEnd, [NativeTypeName("ULONG")] uint cch, [NativeTypeName("LONG *")] int* pacpResultStart, [NativeTypeName("LONG *")] int* pacpResultEnd)
        {
            return ((delegate* unmanaged<ITextStoreACP2*, int, int, uint, int*, int*, int>)(lpVtbl[7]))((ITextStoreACP2*)Unsafe.AsPointer(ref this), acpTestStart, acpTestEnd, cch, pacpResultStart, pacpResultEnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSelection([NativeTypeName("ULONG")] uint ulIndex, [NativeTypeName("ULONG")] uint ulCount, [NativeTypeName("TS_SELECTION_ACP *")] TS_SELECTION_ACP* pSelection, [NativeTypeName("ULONG *")] uint* pcFetched)
        {
            return ((delegate* unmanaged<ITextStoreACP2*, uint, uint, TS_SELECTION_ACP*, uint*, int>)(lpVtbl[8]))((ITextStoreACP2*)Unsafe.AsPointer(ref this), ulIndex, ulCount, pSelection, pcFetched);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetSelection([NativeTypeName("ULONG")] uint ulCount, [NativeTypeName("const TS_SELECTION_ACP *")] TS_SELECTION_ACP* pSelection)
        {
            return ((delegate* unmanaged<ITextStoreACP2*, uint, TS_SELECTION_ACP*, int>)(lpVtbl[9]))((ITextStoreACP2*)Unsafe.AsPointer(ref this), ulCount, pSelection);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetText([NativeTypeName("LONG")] int acpStart, [NativeTypeName("LONG")] int acpEnd, [NativeTypeName("WCHAR *")] ushort* pchPlain, [NativeTypeName("ULONG")] uint cchPlainReq, [NativeTypeName("ULONG *")] uint* pcchPlainRet, [NativeTypeName("TS_RUNINFO *")] TS_RUNINFO* prgRunInfo, [NativeTypeName("ULONG")] uint cRunInfoReq, [NativeTypeName("ULONG *")] uint* pcRunInfoRet, [NativeTypeName("LONG *")] int* pacpNext)
        {
            return ((delegate* unmanaged<ITextStoreACP2*, int, int, ushort*, uint, uint*, TS_RUNINFO*, uint, uint*, int*, int>)(lpVtbl[10]))((ITextStoreACP2*)Unsafe.AsPointer(ref this), acpStart, acpEnd, pchPlain, cchPlainReq, pcchPlainRet, prgRunInfo, cRunInfoReq, pcRunInfoRet, pacpNext);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetText([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LONG")] int acpStart, [NativeTypeName("LONG")] int acpEnd, [NativeTypeName("const WCHAR *")] ushort* pchText, [NativeTypeName("ULONG")] uint cch, [NativeTypeName("TS_TEXTCHANGE *")] TS_TEXTCHANGE* pChange)
        {
            return ((delegate* unmanaged<ITextStoreACP2*, uint, int, int, ushort*, uint, TS_TEXTCHANGE*, int>)(lpVtbl[11]))((ITextStoreACP2*)Unsafe.AsPointer(ref this), dwFlags, acpStart, acpEnd, pchText, cch, pChange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFormattedText([NativeTypeName("LONG")] int acpStart, [NativeTypeName("LONG")] int acpEnd, [NativeTypeName("IDataObject **")] IDataObject** ppDataObject)
        {
            return ((delegate* unmanaged<ITextStoreACP2*, int, int, IDataObject**, int>)(lpVtbl[12]))((ITextStoreACP2*)Unsafe.AsPointer(ref this), acpStart, acpEnd, ppDataObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetEmbedded([NativeTypeName("LONG")] int acpPos, [NativeTypeName("const GUID &")] Guid* rguidService, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("IUnknown **")] IUnknown** ppunk)
        {
            return ((delegate* unmanaged<ITextStoreACP2*, int, Guid*, Guid*, IUnknown**, int>)(lpVtbl[13]))((ITextStoreACP2*)Unsafe.AsPointer(ref this), acpPos, rguidService, riid, ppunk);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInsertEmbedded([NativeTypeName("const GUID *")] Guid* pguidService, [NativeTypeName("const FORMATETC *")] FORMATETC* pFormatEtc, [NativeTypeName("BOOL *")] int* pfInsertable)
        {
            return ((delegate* unmanaged<ITextStoreACP2*, Guid*, FORMATETC*, int*, int>)(lpVtbl[14]))((ITextStoreACP2*)Unsafe.AsPointer(ref this), pguidService, pFormatEtc, pfInsertable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int InsertEmbedded([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LONG")] int acpStart, [NativeTypeName("LONG")] int acpEnd, [NativeTypeName("IDataObject *")] IDataObject* pDataObject, [NativeTypeName("TS_TEXTCHANGE *")] TS_TEXTCHANGE* pChange)
        {
            return ((delegate* unmanaged<ITextStoreACP2*, uint, int, int, IDataObject*, TS_TEXTCHANGE*, int>)(lpVtbl[15]))((ITextStoreACP2*)Unsafe.AsPointer(ref this), dwFlags, acpStart, acpEnd, pDataObject, pChange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int InsertTextAtSelection([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("const WCHAR *")] ushort* pchText, [NativeTypeName("ULONG")] uint cch, [NativeTypeName("LONG *")] int* pacpStart, [NativeTypeName("LONG *")] int* pacpEnd, [NativeTypeName("TS_TEXTCHANGE *")] TS_TEXTCHANGE* pChange)
        {
            return ((delegate* unmanaged<ITextStoreACP2*, uint, ushort*, uint, int*, int*, TS_TEXTCHANGE*, int>)(lpVtbl[16]))((ITextStoreACP2*)Unsafe.AsPointer(ref this), dwFlags, pchText, cch, pacpStart, pacpEnd, pChange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int InsertEmbeddedAtSelection([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("IDataObject *")] IDataObject* pDataObject, [NativeTypeName("LONG *")] int* pacpStart, [NativeTypeName("LONG *")] int* pacpEnd, [NativeTypeName("TS_TEXTCHANGE *")] TS_TEXTCHANGE* pChange)
        {
            return ((delegate* unmanaged<ITextStoreACP2*, uint, IDataObject*, int*, int*, TS_TEXTCHANGE*, int>)(lpVtbl[17]))((ITextStoreACP2*)Unsafe.AsPointer(ref this), dwFlags, pDataObject, pacpStart, pacpEnd, pChange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RequestSupportedAttrs([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("ULONG")] uint cFilterAttrs, [NativeTypeName("const TS_ATTRID *")] Guid* paFilterAttrs)
        {
            return ((delegate* unmanaged<ITextStoreACP2*, uint, uint, Guid*, int>)(lpVtbl[18]))((ITextStoreACP2*)Unsafe.AsPointer(ref this), dwFlags, cFilterAttrs, paFilterAttrs);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RequestAttrsAtPosition([NativeTypeName("LONG")] int acpPos, [NativeTypeName("ULONG")] uint cFilterAttrs, [NativeTypeName("const TS_ATTRID *")] Guid* paFilterAttrs, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* unmanaged<ITextStoreACP2*, int, uint, Guid*, uint, int>)(lpVtbl[19]))((ITextStoreACP2*)Unsafe.AsPointer(ref this), acpPos, cFilterAttrs, paFilterAttrs, dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RequestAttrsTransitioningAtPosition([NativeTypeName("LONG")] int acpPos, [NativeTypeName("ULONG")] uint cFilterAttrs, [NativeTypeName("const TS_ATTRID *")] Guid* paFilterAttrs, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* unmanaged<ITextStoreACP2*, int, uint, Guid*, uint, int>)(lpVtbl[20]))((ITextStoreACP2*)Unsafe.AsPointer(ref this), acpPos, cFilterAttrs, paFilterAttrs, dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int FindNextAttrTransition([NativeTypeName("LONG")] int acpStart, [NativeTypeName("LONG")] int acpHalt, [NativeTypeName("ULONG")] uint cFilterAttrs, [NativeTypeName("const TS_ATTRID *")] Guid* paFilterAttrs, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LONG *")] int* pacpNext, [NativeTypeName("BOOL *")] int* pfFound, [NativeTypeName("LONG *")] int* plFoundOffset)
        {
            return ((delegate* unmanaged<ITextStoreACP2*, int, int, uint, Guid*, uint, int*, int*, int*, int>)(lpVtbl[21]))((ITextStoreACP2*)Unsafe.AsPointer(ref this), acpStart, acpHalt, cFilterAttrs, paFilterAttrs, dwFlags, pacpNext, pfFound, plFoundOffset);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RetrieveRequestedAttrs([NativeTypeName("ULONG")] uint ulCount, [NativeTypeName("TS_ATTRVAL *")] TS_ATTRVAL* paAttrVals, [NativeTypeName("ULONG *")] uint* pcFetched)
        {
            return ((delegate* unmanaged<ITextStoreACP2*, uint, TS_ATTRVAL*, uint*, int>)(lpVtbl[22]))((ITextStoreACP2*)Unsafe.AsPointer(ref this), ulCount, paAttrVals, pcFetched);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetEndACP([NativeTypeName("LONG *")] int* pacp)
        {
            return ((delegate* unmanaged<ITextStoreACP2*, int*, int>)(lpVtbl[23]))((ITextStoreACP2*)Unsafe.AsPointer(ref this), pacp);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetActiveView([NativeTypeName("TsViewCookie *")] uint* pvcView)
        {
            return ((delegate* unmanaged<ITextStoreACP2*, uint*, int>)(lpVtbl[24]))((ITextStoreACP2*)Unsafe.AsPointer(ref this), pvcView);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetACPFromPoint([NativeTypeName("TsViewCookie")] uint vcView, [NativeTypeName("const POINT *")] POINT* ptScreen, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LONG *")] int* pacp)
        {
            return ((delegate* unmanaged<ITextStoreACP2*, uint, POINT*, uint, int*, int>)(lpVtbl[25]))((ITextStoreACP2*)Unsafe.AsPointer(ref this), vcView, ptScreen, dwFlags, pacp);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTextExt([NativeTypeName("TsViewCookie")] uint vcView, [NativeTypeName("LONG")] int acpStart, [NativeTypeName("LONG")] int acpEnd, [NativeTypeName("RECT *")] RECT* prc, [NativeTypeName("BOOL *")] int* pfClipped)
        {
            return ((delegate* unmanaged<ITextStoreACP2*, uint, int, int, RECT*, int*, int>)(lpVtbl[26]))((ITextStoreACP2*)Unsafe.AsPointer(ref this), vcView, acpStart, acpEnd, prc, pfClipped);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetScreenExt([NativeTypeName("TsViewCookie")] uint vcView, [NativeTypeName("RECT *")] RECT* prc)
        {
            return ((delegate* unmanaged<ITextStoreACP2*, uint, RECT*, int>)(lpVtbl[27]))((ITextStoreACP2*)Unsafe.AsPointer(ref this), vcView, prc);
        }
    }
}
