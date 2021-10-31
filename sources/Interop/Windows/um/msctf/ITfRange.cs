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
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
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
        [return: NativeTypeName("HRESULT")]
        public int GetText([NativeTypeName("TfEditCookie")] uint ec, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("WCHAR *")] ushort* pchText, [NativeTypeName("ULONG")] uint cchMax, [NativeTypeName("ULONG *")] uint* pcch)
        {
            return ((delegate* unmanaged<ITfRange*, uint, uint, ushort*, uint, uint*, int>)(lpVtbl[3]))((ITfRange*)Unsafe.AsPointer(ref this), ec, dwFlags, pchText, cchMax, pcch);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int SetText([NativeTypeName("TfEditCookie")] uint ec, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("const WCHAR *")] ushort* pchText, [NativeTypeName("LONG")] int cch)
        {
            return ((delegate* unmanaged<ITfRange*, uint, uint, ushort*, int, int>)(lpVtbl[4]))((ITfRange*)Unsafe.AsPointer(ref this), ec, dwFlags, pchText, cch);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetFormattedText([NativeTypeName("TfEditCookie")] uint ec, IDataObject** ppDataObject)
        {
            return ((delegate* unmanaged<ITfRange*, uint, IDataObject**, int>)(lpVtbl[5]))((ITfRange*)Unsafe.AsPointer(ref this), ec, ppDataObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int GetEmbedded([NativeTypeName("TfEditCookie")] uint ec, [NativeTypeName("const GUID &")] Guid* rguidService, [NativeTypeName("const IID &")] Guid* riid, IUnknown** ppunk)
        {
            return ((delegate* unmanaged<ITfRange*, uint, Guid*, Guid*, IUnknown**, int>)(lpVtbl[6]))((ITfRange*)Unsafe.AsPointer(ref this), ec, rguidService, riid, ppunk);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int InsertEmbedded([NativeTypeName("TfEditCookie")] uint ec, [NativeTypeName("DWORD")] uint dwFlags, IDataObject* pDataObject)
        {
            return ((delegate* unmanaged<ITfRange*, uint, uint, IDataObject*, int>)(lpVtbl[7]))((ITfRange*)Unsafe.AsPointer(ref this), ec, dwFlags, pDataObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int ShiftStart([NativeTypeName("TfEditCookie")] uint ec, [NativeTypeName("LONG")] int cchReq, [NativeTypeName("LONG *")] int* pcch, [NativeTypeName("const TF_HALTCOND *")] TF_HALTCOND* pHalt)
        {
            return ((delegate* unmanaged<ITfRange*, uint, int, int*, TF_HALTCOND*, int>)(lpVtbl[8]))((ITfRange*)Unsafe.AsPointer(ref this), ec, cchReq, pcch, pHalt);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int ShiftEnd([NativeTypeName("TfEditCookie")] uint ec, [NativeTypeName("LONG")] int cchReq, [NativeTypeName("LONG *")] int* pcch, [NativeTypeName("const TF_HALTCOND *")] TF_HALTCOND* pHalt)
        {
            return ((delegate* unmanaged<ITfRange*, uint, int, int*, TF_HALTCOND*, int>)(lpVtbl[9]))((ITfRange*)Unsafe.AsPointer(ref this), ec, cchReq, pcch, pHalt);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int ShiftStartToRange([NativeTypeName("TfEditCookie")] uint ec, ITfRange* pRange, TfAnchor aPos)
        {
            return ((delegate* unmanaged<ITfRange*, uint, ITfRange*, TfAnchor, int>)(lpVtbl[10]))((ITfRange*)Unsafe.AsPointer(ref this), ec, pRange, aPos);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int ShiftEndToRange([NativeTypeName("TfEditCookie")] uint ec, ITfRange* pRange, TfAnchor aPos)
        {
            return ((delegate* unmanaged<ITfRange*, uint, ITfRange*, TfAnchor, int>)(lpVtbl[11]))((ITfRange*)Unsafe.AsPointer(ref this), ec, pRange, aPos);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int ShiftStartRegion([NativeTypeName("TfEditCookie")] uint ec, TfShiftDir dir, BOOL* pfNoRegion)
        {
            return ((delegate* unmanaged<ITfRange*, uint, TfShiftDir, BOOL*, int>)(lpVtbl[12]))((ITfRange*)Unsafe.AsPointer(ref this), ec, dir, pfNoRegion);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int ShiftEndRegion([NativeTypeName("TfEditCookie")] uint ec, TfShiftDir dir, BOOL* pfNoRegion)
        {
            return ((delegate* unmanaged<ITfRange*, uint, TfShiftDir, BOOL*, int>)(lpVtbl[13]))((ITfRange*)Unsafe.AsPointer(ref this), ec, dir, pfNoRegion);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int IsEmpty([NativeTypeName("TfEditCookie")] uint ec, BOOL* pfEmpty)
        {
            return ((delegate* unmanaged<ITfRange*, uint, BOOL*, int>)(lpVtbl[14]))((ITfRange*)Unsafe.AsPointer(ref this), ec, pfEmpty);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        public int Collapse([NativeTypeName("TfEditCookie")] uint ec, TfAnchor aPos)
        {
            return ((delegate* unmanaged<ITfRange*, uint, TfAnchor, int>)(lpVtbl[15]))((ITfRange*)Unsafe.AsPointer(ref this), ec, aPos);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("HRESULT")]
        public int IsEqualStart([NativeTypeName("TfEditCookie")] uint ec, ITfRange* pWith, TfAnchor aPos, BOOL* pfEqual)
        {
            return ((delegate* unmanaged<ITfRange*, uint, ITfRange*, TfAnchor, BOOL*, int>)(lpVtbl[16]))((ITfRange*)Unsafe.AsPointer(ref this), ec, pWith, aPos, pfEqual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        [return: NativeTypeName("HRESULT")]
        public int IsEqualEnd([NativeTypeName("TfEditCookie")] uint ec, ITfRange* pWith, TfAnchor aPos, BOOL* pfEqual)
        {
            return ((delegate* unmanaged<ITfRange*, uint, ITfRange*, TfAnchor, BOOL*, int>)(lpVtbl[17]))((ITfRange*)Unsafe.AsPointer(ref this), ec, pWith, aPos, pfEqual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        [return: NativeTypeName("HRESULT")]
        public int CompareStart([NativeTypeName("TfEditCookie")] uint ec, ITfRange* pWith, TfAnchor aPos, [NativeTypeName("LONG *")] int* plResult)
        {
            return ((delegate* unmanaged<ITfRange*, uint, ITfRange*, TfAnchor, int*, int>)(lpVtbl[18]))((ITfRange*)Unsafe.AsPointer(ref this), ec, pWith, aPos, plResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        [return: NativeTypeName("HRESULT")]
        public int CompareEnd([NativeTypeName("TfEditCookie")] uint ec, ITfRange* pWith, TfAnchor aPos, [NativeTypeName("LONG *")] int* plResult)
        {
            return ((delegate* unmanaged<ITfRange*, uint, ITfRange*, TfAnchor, int*, int>)(lpVtbl[19]))((ITfRange*)Unsafe.AsPointer(ref this), ec, pWith, aPos, plResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        [return: NativeTypeName("HRESULT")]
        public int AdjustForInsert([NativeTypeName("TfEditCookie")] uint ec, [NativeTypeName("ULONG")] uint cchInsert, BOOL* pfInsertOk)
        {
            return ((delegate* unmanaged<ITfRange*, uint, uint, BOOL*, int>)(lpVtbl[20]))((ITfRange*)Unsafe.AsPointer(ref this), ec, cchInsert, pfInsertOk);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        [return: NativeTypeName("HRESULT")]
        public int GetGravity(TfGravity* pgStart, TfGravity* pgEnd)
        {
            return ((delegate* unmanaged<ITfRange*, TfGravity*, TfGravity*, int>)(lpVtbl[21]))((ITfRange*)Unsafe.AsPointer(ref this), pgStart, pgEnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        [return: NativeTypeName("HRESULT")]
        public int SetGravity([NativeTypeName("TfEditCookie")] uint ec, TfGravity gStart, TfGravity gEnd)
        {
            return ((delegate* unmanaged<ITfRange*, uint, TfGravity, TfGravity, int>)(lpVtbl[22]))((ITfRange*)Unsafe.AsPointer(ref this), ec, gStart, gEnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        [return: NativeTypeName("HRESULT")]
        public int Clone(ITfRange** ppClone)
        {
            return ((delegate* unmanaged<ITfRange*, ITfRange**, int>)(lpVtbl[23]))((ITfRange*)Unsafe.AsPointer(ref this), ppClone);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        [return: NativeTypeName("HRESULT")]
        public int GetContext(ITfContext** ppContext)
        {
            return ((delegate* unmanaged<ITfRange*, ITfContext**, int>)(lpVtbl[24]))((ITfRange*)Unsafe.AsPointer(ref this), ppContext);
        }
    }
}
