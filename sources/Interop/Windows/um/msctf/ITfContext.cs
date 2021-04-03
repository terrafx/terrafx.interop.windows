// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msctf.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("AA80E7FD-2021-11D2-93E0-0060B067B86E")]
    [NativeTypeName("struct ITfContext : IUnknown")]
    public unsafe partial struct ITfContext
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ITfContext*, Guid*, void**, int>)(lpVtbl[0]))((ITfContext*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITfContext*, uint>)(lpVtbl[1]))((ITfContext*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITfContext*, uint>)(lpVtbl[2]))((ITfContext*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RequestEditSession([NativeTypeName("TfClientId")] uint tid, ITfEditSession* pes, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("HRESULT *")] int* phrSession)
        {
            return ((delegate* unmanaged<ITfContext*, uint, ITfEditSession*, uint, int*, int>)(lpVtbl[3]))((ITfContext*)Unsafe.AsPointer(ref this), tid, pes, dwFlags, phrSession);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int InWriteSession([NativeTypeName("TfClientId")] uint tid, [NativeTypeName("BOOL *")] int* pfWriteSession)
        {
            return ((delegate* unmanaged<ITfContext*, uint, int*, int>)(lpVtbl[4]))((ITfContext*)Unsafe.AsPointer(ref this), tid, pfWriteSession);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSelection([NativeTypeName("TfEditCookie")] uint ec, [NativeTypeName("ULONG")] uint ulIndex, [NativeTypeName("ULONG")] uint ulCount, TF_SELECTION* pSelection, [NativeTypeName("ULONG *")] uint* pcFetched)
        {
            return ((delegate* unmanaged<ITfContext*, uint, uint, uint, TF_SELECTION*, uint*, int>)(lpVtbl[5]))((ITfContext*)Unsafe.AsPointer(ref this), ec, ulIndex, ulCount, pSelection, pcFetched);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetSelection([NativeTypeName("TfEditCookie")] uint ec, [NativeTypeName("ULONG")] uint ulCount, [NativeTypeName("const TF_SELECTION *")] TF_SELECTION* pSelection)
        {
            return ((delegate* unmanaged<ITfContext*, uint, uint, TF_SELECTION*, int>)(lpVtbl[6]))((ITfContext*)Unsafe.AsPointer(ref this), ec, ulCount, pSelection);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetStart([NativeTypeName("TfEditCookie")] uint ec, ITfRange** ppStart)
        {
            return ((delegate* unmanaged<ITfContext*, uint, ITfRange**, int>)(lpVtbl[7]))((ITfContext*)Unsafe.AsPointer(ref this), ec, ppStart);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetEnd([NativeTypeName("TfEditCookie")] uint ec, ITfRange** ppEnd)
        {
            return ((delegate* unmanaged<ITfContext*, uint, ITfRange**, int>)(lpVtbl[8]))((ITfContext*)Unsafe.AsPointer(ref this), ec, ppEnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetActiveView(ITfContextView** ppView)
        {
            return ((delegate* unmanaged<ITfContext*, ITfContextView**, int>)(lpVtbl[9]))((ITfContext*)Unsafe.AsPointer(ref this), ppView);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int EnumViews(IEnumTfContextViews** ppEnum)
        {
            return ((delegate* unmanaged<ITfContext*, IEnumTfContextViews**, int>)(lpVtbl[10]))((ITfContext*)Unsafe.AsPointer(ref this), ppEnum);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetStatus([NativeTypeName("TF_STATUS *")] TS_STATUS* pdcs)
        {
            return ((delegate* unmanaged<ITfContext*, TS_STATUS*, int>)(lpVtbl[11]))((ITfContext*)Unsafe.AsPointer(ref this), pdcs);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetProperty([NativeTypeName("const GUID &")] Guid* guidProp, ITfProperty** ppProp)
        {
            return ((delegate* unmanaged<ITfContext*, Guid*, ITfProperty**, int>)(lpVtbl[12]))((ITfContext*)Unsafe.AsPointer(ref this), guidProp, ppProp);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetAppProperty([NativeTypeName("const GUID &")] Guid* guidProp, ITfReadOnlyProperty** ppProp)
        {
            return ((delegate* unmanaged<ITfContext*, Guid*, ITfReadOnlyProperty**, int>)(lpVtbl[13]))((ITfContext*)Unsafe.AsPointer(ref this), guidProp, ppProp);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int TrackProperties([NativeTypeName("const GUID **")] Guid** prgProp, [NativeTypeName("ULONG")] uint cProp, [NativeTypeName("const GUID **")] Guid** prgAppProp, [NativeTypeName("ULONG")] uint cAppProp, ITfReadOnlyProperty** ppProperty)
        {
            return ((delegate* unmanaged<ITfContext*, Guid**, uint, Guid**, uint, ITfReadOnlyProperty**, int>)(lpVtbl[14]))((ITfContext*)Unsafe.AsPointer(ref this), prgProp, cProp, prgAppProp, cAppProp, ppProperty);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int EnumProperties(IEnumTfProperties** ppEnum)
        {
            return ((delegate* unmanaged<ITfContext*, IEnumTfProperties**, int>)(lpVtbl[15]))((ITfContext*)Unsafe.AsPointer(ref this), ppEnum);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDocumentMgr(ITfDocumentMgr** ppDm)
        {
            return ((delegate* unmanaged<ITfContext*, ITfDocumentMgr**, int>)(lpVtbl[16]))((ITfContext*)Unsafe.AsPointer(ref this), ppDm);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateRangeBackup([NativeTypeName("TfEditCookie")] uint ec, ITfRange* pRange, ITfRangeBackup** ppBackup)
        {
            return ((delegate* unmanaged<ITfContext*, uint, ITfRange*, ITfRangeBackup**, int>)(lpVtbl[17]))((ITfContext*)Unsafe.AsPointer(ref this), ec, pRange, ppBackup);
        }
    }
}
