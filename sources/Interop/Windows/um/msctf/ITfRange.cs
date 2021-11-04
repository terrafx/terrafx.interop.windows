// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msctf.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("AA80E7FF-2021-11D2-93E0-0060B067B86E")]
    [NativeTypeName("struct ITfRange : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ITfRange
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ITfRange*, Guid*, void**, int>)(lpVtbl[0]))((ITfRange*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITfRange*, uint>)(lpVtbl[1]))((ITfRange*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITfRange*, uint>)(lpVtbl[2]))((ITfRange*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetText([NativeTypeName("TfEditCookie")] uint ec, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("WCHAR *")] ushort* pchText, [NativeTypeName("ULONG")] uint cchMax, [NativeTypeName("ULONG *")] uint* pcch)
        {
            return ((delegate* unmanaged<ITfRange*, uint, uint, ushort*, uint, uint*, int>)(lpVtbl[3]))((ITfRange*)Unsafe.AsPointer(ref this), ec, dwFlags, pchText, cchMax, pcch);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT SetText([NativeTypeName("TfEditCookie")] uint ec, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("const WCHAR *")] ushort* pchText, [NativeTypeName("LONG")] int cch)
        {
            return ((delegate* unmanaged<ITfRange*, uint, uint, ushort*, int, int>)(lpVtbl[4]))((ITfRange*)Unsafe.AsPointer(ref this), ec, dwFlags, pchText, cch);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetFormattedText([NativeTypeName("TfEditCookie")] uint ec, IDataObject** ppDataObject)
        {
            return ((delegate* unmanaged<ITfRange*, uint, IDataObject**, int>)(lpVtbl[5]))((ITfRange*)Unsafe.AsPointer(ref this), ec, ppDataObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT GetEmbedded([NativeTypeName("TfEditCookie")] uint ec, [NativeTypeName("const GUID &")] Guid* rguidService, [NativeTypeName("const IID &")] Guid* riid, IUnknown** ppunk)
        {
            return ((delegate* unmanaged<ITfRange*, uint, Guid*, Guid*, IUnknown**, int>)(lpVtbl[6]))((ITfRange*)Unsafe.AsPointer(ref this), ec, rguidService, riid, ppunk);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT InsertEmbedded([NativeTypeName("TfEditCookie")] uint ec, [NativeTypeName("DWORD")] uint dwFlags, IDataObject* pDataObject)
        {
            return ((delegate* unmanaged<ITfRange*, uint, uint, IDataObject*, int>)(lpVtbl[7]))((ITfRange*)Unsafe.AsPointer(ref this), ec, dwFlags, pDataObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT ShiftStart([NativeTypeName("TfEditCookie")] uint ec, [NativeTypeName("LONG")] int cchReq, [NativeTypeName("LONG *")] int* pcch, [NativeTypeName("const TF_HALTCOND *")] TF_HALTCOND* pHalt)
        {
            return ((delegate* unmanaged<ITfRange*, uint, int, int*, TF_HALTCOND*, int>)(lpVtbl[8]))((ITfRange*)Unsafe.AsPointer(ref this), ec, cchReq, pcch, pHalt);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT ShiftEnd([NativeTypeName("TfEditCookie")] uint ec, [NativeTypeName("LONG")] int cchReq, [NativeTypeName("LONG *")] int* pcch, [NativeTypeName("const TF_HALTCOND *")] TF_HALTCOND* pHalt)
        {
            return ((delegate* unmanaged<ITfRange*, uint, int, int*, TF_HALTCOND*, int>)(lpVtbl[9]))((ITfRange*)Unsafe.AsPointer(ref this), ec, cchReq, pcch, pHalt);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT ShiftStartToRange([NativeTypeName("TfEditCookie")] uint ec, ITfRange* pRange, TfAnchor aPos)
        {
            return ((delegate* unmanaged<ITfRange*, uint, ITfRange*, TfAnchor, int>)(lpVtbl[10]))((ITfRange*)Unsafe.AsPointer(ref this), ec, pRange, aPos);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT ShiftEndToRange([NativeTypeName("TfEditCookie")] uint ec, ITfRange* pRange, TfAnchor aPos)
        {
            return ((delegate* unmanaged<ITfRange*, uint, ITfRange*, TfAnchor, int>)(lpVtbl[11]))((ITfRange*)Unsafe.AsPointer(ref this), ec, pRange, aPos);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT ShiftStartRegion([NativeTypeName("TfEditCookie")] uint ec, TfShiftDir dir, BOOL* pfNoRegion)
        {
            return ((delegate* unmanaged<ITfRange*, uint, TfShiftDir, BOOL*, int>)(lpVtbl[12]))((ITfRange*)Unsafe.AsPointer(ref this), ec, dir, pfNoRegion);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT ShiftEndRegion([NativeTypeName("TfEditCookie")] uint ec, TfShiftDir dir, BOOL* pfNoRegion)
        {
            return ((delegate* unmanaged<ITfRange*, uint, TfShiftDir, BOOL*, int>)(lpVtbl[13]))((ITfRange*)Unsafe.AsPointer(ref this), ec, dir, pfNoRegion);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT IsEmpty([NativeTypeName("TfEditCookie")] uint ec, BOOL* pfEmpty)
        {
            return ((delegate* unmanaged<ITfRange*, uint, BOOL*, int>)(lpVtbl[14]))((ITfRange*)Unsafe.AsPointer(ref this), ec, pfEmpty);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT Collapse([NativeTypeName("TfEditCookie")] uint ec, TfAnchor aPos)
        {
            return ((delegate* unmanaged<ITfRange*, uint, TfAnchor, int>)(lpVtbl[15]))((ITfRange*)Unsafe.AsPointer(ref this), ec, aPos);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT IsEqualStart([NativeTypeName("TfEditCookie")] uint ec, ITfRange* pWith, TfAnchor aPos, BOOL* pfEqual)
        {
            return ((delegate* unmanaged<ITfRange*, uint, ITfRange*, TfAnchor, BOOL*, int>)(lpVtbl[16]))((ITfRange*)Unsafe.AsPointer(ref this), ec, pWith, aPos, pfEqual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT IsEqualEnd([NativeTypeName("TfEditCookie")] uint ec, ITfRange* pWith, TfAnchor aPos, BOOL* pfEqual)
        {
            return ((delegate* unmanaged<ITfRange*, uint, ITfRange*, TfAnchor, BOOL*, int>)(lpVtbl[17]))((ITfRange*)Unsafe.AsPointer(ref this), ec, pWith, aPos, pfEqual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT CompareStart([NativeTypeName("TfEditCookie")] uint ec, ITfRange* pWith, TfAnchor aPos, [NativeTypeName("LONG *")] int* plResult)
        {
            return ((delegate* unmanaged<ITfRange*, uint, ITfRange*, TfAnchor, int*, int>)(lpVtbl[18]))((ITfRange*)Unsafe.AsPointer(ref this), ec, pWith, aPos, plResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT CompareEnd([NativeTypeName("TfEditCookie")] uint ec, ITfRange* pWith, TfAnchor aPos, [NativeTypeName("LONG *")] int* plResult)
        {
            return ((delegate* unmanaged<ITfRange*, uint, ITfRange*, TfAnchor, int*, int>)(lpVtbl[19]))((ITfRange*)Unsafe.AsPointer(ref this), ec, pWith, aPos, plResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public HRESULT AdjustForInsert([NativeTypeName("TfEditCookie")] uint ec, [NativeTypeName("ULONG")] uint cchInsert, BOOL* pfInsertOk)
        {
            return ((delegate* unmanaged<ITfRange*, uint, uint, BOOL*, int>)(lpVtbl[20]))((ITfRange*)Unsafe.AsPointer(ref this), ec, cchInsert, pfInsertOk);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public HRESULT GetGravity(TfGravity* pgStart, TfGravity* pgEnd)
        {
            return ((delegate* unmanaged<ITfRange*, TfGravity*, TfGravity*, int>)(lpVtbl[21]))((ITfRange*)Unsafe.AsPointer(ref this), pgStart, pgEnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        public HRESULT SetGravity([NativeTypeName("TfEditCookie")] uint ec, TfGravity gStart, TfGravity gEnd)
        {
            return ((delegate* unmanaged<ITfRange*, uint, TfGravity, TfGravity, int>)(lpVtbl[22]))((ITfRange*)Unsafe.AsPointer(ref this), ec, gStart, gEnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        public HRESULT Clone(ITfRange** ppClone)
        {
            return ((delegate* unmanaged<ITfRange*, ITfRange**, int>)(lpVtbl[23]))((ITfRange*)Unsafe.AsPointer(ref this), ppClone);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        public HRESULT GetContext(ITfContext** ppContext)
        {
            return ((delegate* unmanaged<ITfRange*, ITfContext**, int>)(lpVtbl[24]))((ITfRange*)Unsafe.AsPointer(ref this), ppContext);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<ITfRange*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ITfRange*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ITfRange*, uint> Release;

            [NativeTypeName("HRESULT (TfEditCookie, DWORD, WCHAR *, ULONG, ULONG *) __attribute__((stdcall))")]
            public delegate* unmanaged<ITfRange*, uint, uint, ushort*, uint, uint*, int> GetText;

            [NativeTypeName("HRESULT (TfEditCookie, DWORD, const WCHAR *, LONG) __attribute__((stdcall))")]
            public delegate* unmanaged<ITfRange*, uint, uint, ushort*, int, int> SetText;

            [NativeTypeName("HRESULT (TfEditCookie, IDataObject **) __attribute__((stdcall))")]
            public delegate* unmanaged<ITfRange*, uint, IDataObject**, int> GetFormattedText;

            [NativeTypeName("HRESULT (TfEditCookie, const GUID &, const IID &, IUnknown **) __attribute__((stdcall))")]
            public delegate* unmanaged<ITfRange*, uint, Guid*, Guid*, IUnknown**, int> GetEmbedded;

            [NativeTypeName("HRESULT (TfEditCookie, DWORD, IDataObject *) __attribute__((stdcall))")]
            public delegate* unmanaged<ITfRange*, uint, uint, IDataObject*, int> InsertEmbedded;

            [NativeTypeName("HRESULT (TfEditCookie, LONG, LONG *, const TF_HALTCOND *) __attribute__((stdcall))")]
            public delegate* unmanaged<ITfRange*, uint, int, int*, TF_HALTCOND*, int> ShiftStart;

            [NativeTypeName("HRESULT (TfEditCookie, LONG, LONG *, const TF_HALTCOND *) __attribute__((stdcall))")]
            public delegate* unmanaged<ITfRange*, uint, int, int*, TF_HALTCOND*, int> ShiftEnd;

            [NativeTypeName("HRESULT (TfEditCookie, ITfRange *, TfAnchor) __attribute__((stdcall))")]
            public delegate* unmanaged<ITfRange*, uint, ITfRange*, TfAnchor, int> ShiftStartToRange;

            [NativeTypeName("HRESULT (TfEditCookie, ITfRange *, TfAnchor) __attribute__((stdcall))")]
            public delegate* unmanaged<ITfRange*, uint, ITfRange*, TfAnchor, int> ShiftEndToRange;

            [NativeTypeName("HRESULT (TfEditCookie, TfShiftDir, BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<ITfRange*, uint, TfShiftDir, BOOL*, int> ShiftStartRegion;

            [NativeTypeName("HRESULT (TfEditCookie, TfShiftDir, BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<ITfRange*, uint, TfShiftDir, BOOL*, int> ShiftEndRegion;

            [NativeTypeName("HRESULT (TfEditCookie, BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<ITfRange*, uint, BOOL*, int> IsEmpty;

            [NativeTypeName("HRESULT (TfEditCookie, TfAnchor) __attribute__((stdcall))")]
            public delegate* unmanaged<ITfRange*, uint, TfAnchor, int> Collapse;

            [NativeTypeName("HRESULT (TfEditCookie, ITfRange *, TfAnchor, BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<ITfRange*, uint, ITfRange*, TfAnchor, BOOL*, int> IsEqualStart;

            [NativeTypeName("HRESULT (TfEditCookie, ITfRange *, TfAnchor, BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<ITfRange*, uint, ITfRange*, TfAnchor, BOOL*, int> IsEqualEnd;

            [NativeTypeName("HRESULT (TfEditCookie, ITfRange *, TfAnchor, LONG *) __attribute__((stdcall))")]
            public delegate* unmanaged<ITfRange*, uint, ITfRange*, TfAnchor, int*, int> CompareStart;

            [NativeTypeName("HRESULT (TfEditCookie, ITfRange *, TfAnchor, LONG *) __attribute__((stdcall))")]
            public delegate* unmanaged<ITfRange*, uint, ITfRange*, TfAnchor, int*, int> CompareEnd;

            [NativeTypeName("HRESULT (TfEditCookie, ULONG, BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<ITfRange*, uint, uint, BOOL*, int> AdjustForInsert;

            [NativeTypeName("HRESULT (TfGravity *, TfGravity *) __attribute__((stdcall))")]
            public delegate* unmanaged<ITfRange*, TfGravity*, TfGravity*, int> GetGravity;

            [NativeTypeName("HRESULT (TfEditCookie, TfGravity, TfGravity) __attribute__((stdcall))")]
            public delegate* unmanaged<ITfRange*, uint, TfGravity, TfGravity, int> SetGravity;

            [NativeTypeName("HRESULT (ITfRange **) __attribute__((stdcall))")]
            public delegate* unmanaged<ITfRange*, ITfRange**, int> Clone;

            [NativeTypeName("HRESULT (ITfContext **) __attribute__((stdcall))")]
            public delegate* unmanaged<ITfRange*, ITfContext**, int> GetContext;
        }
    }
}
