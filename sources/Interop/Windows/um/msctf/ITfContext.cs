// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msctf.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("AA80E7FD-2021-11D2-93E0-0060B067B86E")]
    [NativeTypeName("struct ITfContext : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ITfContext
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ITfContext*, Guid*, void**, int>)(lpVtbl[0]))((ITfContext*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITfContext*, uint>)(lpVtbl[1]))((ITfContext*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITfContext*, uint>)(lpVtbl[2]))((ITfContext*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT RequestEditSession([NativeTypeName("TfClientId")] uint tid, ITfEditSession* pes, [NativeTypeName("DWORD")] uint dwFlags, HRESULT* phrSession)
        {
            return ((delegate* unmanaged<ITfContext*, uint, ITfEditSession*, uint, HRESULT*, int>)(lpVtbl[3]))((ITfContext*)Unsafe.AsPointer(ref this), tid, pes, dwFlags, phrSession);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT InWriteSession([NativeTypeName("TfClientId")] uint tid, BOOL* pfWriteSession)
        {
            return ((delegate* unmanaged<ITfContext*, uint, BOOL*, int>)(lpVtbl[4]))((ITfContext*)Unsafe.AsPointer(ref this), tid, pfWriteSession);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetSelection([NativeTypeName("TfEditCookie")] uint ec, [NativeTypeName("ULONG")] uint ulIndex, [NativeTypeName("ULONG")] uint ulCount, TF_SELECTION* pSelection, [NativeTypeName("ULONG *")] uint* pcFetched)
        {
            return ((delegate* unmanaged<ITfContext*, uint, uint, uint, TF_SELECTION*, uint*, int>)(lpVtbl[5]))((ITfContext*)Unsafe.AsPointer(ref this), ec, ulIndex, ulCount, pSelection, pcFetched);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT SetSelection([NativeTypeName("TfEditCookie")] uint ec, [NativeTypeName("ULONG")] uint ulCount, [NativeTypeName("const TF_SELECTION *")] TF_SELECTION* pSelection)
        {
            return ((delegate* unmanaged<ITfContext*, uint, uint, TF_SELECTION*, int>)(lpVtbl[6]))((ITfContext*)Unsafe.AsPointer(ref this), ec, ulCount, pSelection);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT GetStart([NativeTypeName("TfEditCookie")] uint ec, ITfRange** ppStart)
        {
            return ((delegate* unmanaged<ITfContext*, uint, ITfRange**, int>)(lpVtbl[7]))((ITfContext*)Unsafe.AsPointer(ref this), ec, ppStart);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT GetEnd([NativeTypeName("TfEditCookie")] uint ec, ITfRange** ppEnd)
        {
            return ((delegate* unmanaged<ITfContext*, uint, ITfRange**, int>)(lpVtbl[8]))((ITfContext*)Unsafe.AsPointer(ref this), ec, ppEnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT GetActiveView(ITfContextView** ppView)
        {
            return ((delegate* unmanaged<ITfContext*, ITfContextView**, int>)(lpVtbl[9]))((ITfContext*)Unsafe.AsPointer(ref this), ppView);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT EnumViews(IEnumTfContextViews** ppEnum)
        {
            return ((delegate* unmanaged<ITfContext*, IEnumTfContextViews**, int>)(lpVtbl[10]))((ITfContext*)Unsafe.AsPointer(ref this), ppEnum);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT GetStatus([NativeTypeName("TF_STATUS *")] TS_STATUS* pdcs)
        {
            return ((delegate* unmanaged<ITfContext*, TS_STATUS*, int>)(lpVtbl[11]))((ITfContext*)Unsafe.AsPointer(ref this), pdcs);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT GetProperty([NativeTypeName("const GUID &")] Guid* guidProp, ITfProperty** ppProp)
        {
            return ((delegate* unmanaged<ITfContext*, Guid*, ITfProperty**, int>)(lpVtbl[12]))((ITfContext*)Unsafe.AsPointer(ref this), guidProp, ppProp);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT GetAppProperty([NativeTypeName("const GUID &")] Guid* guidProp, ITfReadOnlyProperty** ppProp)
        {
            return ((delegate* unmanaged<ITfContext*, Guid*, ITfReadOnlyProperty**, int>)(lpVtbl[13]))((ITfContext*)Unsafe.AsPointer(ref this), guidProp, ppProp);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT TrackProperties([NativeTypeName("const GUID **")] Guid** prgProp, [NativeTypeName("ULONG")] uint cProp, [NativeTypeName("const GUID **")] Guid** prgAppProp, [NativeTypeName("ULONG")] uint cAppProp, ITfReadOnlyProperty** ppProperty)
        {
            return ((delegate* unmanaged<ITfContext*, Guid**, uint, Guid**, uint, ITfReadOnlyProperty**, int>)(lpVtbl[14]))((ITfContext*)Unsafe.AsPointer(ref this), prgProp, cProp, prgAppProp, cAppProp, ppProperty);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT EnumProperties(IEnumTfProperties** ppEnum)
        {
            return ((delegate* unmanaged<ITfContext*, IEnumTfProperties**, int>)(lpVtbl[15]))((ITfContext*)Unsafe.AsPointer(ref this), ppEnum);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT GetDocumentMgr(ITfDocumentMgr** ppDm)
        {
            return ((delegate* unmanaged<ITfContext*, ITfDocumentMgr**, int>)(lpVtbl[16]))((ITfContext*)Unsafe.AsPointer(ref this), ppDm);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT CreateRangeBackup([NativeTypeName("TfEditCookie")] uint ec, ITfRange* pRange, ITfRangeBackup** ppBackup)
        {
            return ((delegate* unmanaged<ITfContext*, uint, ITfRange*, ITfRangeBackup**, int>)(lpVtbl[17]))((ITfContext*)Unsafe.AsPointer(ref this), ec, pRange, ppBackup);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<ITfContext*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ITfContext*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ITfContext*, uint> Release;

            [NativeTypeName("HRESULT (TfClientId, ITfEditSession *, DWORD, HRESULT *) __attribute__((stdcall))")]
            public delegate* unmanaged<ITfContext*, uint, ITfEditSession*, uint, HRESULT*, int> RequestEditSession;

            [NativeTypeName("HRESULT (TfClientId, BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<ITfContext*, uint, BOOL*, int> InWriteSession;

            [NativeTypeName("HRESULT (TfEditCookie, ULONG, ULONG, TF_SELECTION *, ULONG *) __attribute__((stdcall))")]
            public delegate* unmanaged<ITfContext*, uint, uint, uint, TF_SELECTION*, uint*, int> GetSelection;

            [NativeTypeName("HRESULT (TfEditCookie, ULONG, const TF_SELECTION *) __attribute__((stdcall))")]
            public delegate* unmanaged<ITfContext*, uint, uint, TF_SELECTION*, int> SetSelection;

            [NativeTypeName("HRESULT (TfEditCookie, ITfRange **) __attribute__((stdcall))")]
            public delegate* unmanaged<ITfContext*, uint, ITfRange**, int> GetStart;

            [NativeTypeName("HRESULT (TfEditCookie, ITfRange **) __attribute__((stdcall))")]
            public delegate* unmanaged<ITfContext*, uint, ITfRange**, int> GetEnd;

            [NativeTypeName("HRESULT (ITfContextView **) __attribute__((stdcall))")]
            public delegate* unmanaged<ITfContext*, ITfContextView**, int> GetActiveView;

            [NativeTypeName("HRESULT (IEnumTfContextViews **) __attribute__((stdcall))")]
            public delegate* unmanaged<ITfContext*, IEnumTfContextViews**, int> EnumViews;

            [NativeTypeName("HRESULT (TF_STATUS *) __attribute__((stdcall))")]
            public delegate* unmanaged<ITfContext*, TS_STATUS*, int> GetStatus;

            [NativeTypeName("HRESULT (const GUID &, ITfProperty **) __attribute__((stdcall))")]
            public delegate* unmanaged<ITfContext*, Guid*, ITfProperty**, int> GetProperty;

            [NativeTypeName("HRESULT (const GUID &, ITfReadOnlyProperty **) __attribute__((stdcall))")]
            public delegate* unmanaged<ITfContext*, Guid*, ITfReadOnlyProperty**, int> GetAppProperty;

            [NativeTypeName("HRESULT (const GUID **, ULONG, const GUID **, ULONG, ITfReadOnlyProperty **) __attribute__((stdcall))")]
            public delegate* unmanaged<ITfContext*, Guid**, uint, Guid**, uint, ITfReadOnlyProperty**, int> TrackProperties;

            [NativeTypeName("HRESULT (IEnumTfProperties **) __attribute__((stdcall))")]
            public delegate* unmanaged<ITfContext*, IEnumTfProperties**, int> EnumProperties;

            [NativeTypeName("HRESULT (ITfDocumentMgr **) __attribute__((stdcall))")]
            public delegate* unmanaged<ITfContext*, ITfDocumentMgr**, int> GetDocumentMgr;

            [NativeTypeName("HRESULT (TfEditCookie, ITfRange *, ITfRangeBackup **) __attribute__((stdcall))")]
            public delegate* unmanaged<ITfContext*, uint, ITfRange*, ITfRangeBackup**, int> CreateRangeBackup;
        }
    }
}
