// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msctf.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("057A6296-029B-4154-B79A-0D461D4EA94C")]
    [NativeTypeName("struct ITfRangeACP : ITfRange")]
    public unsafe partial struct ITfRangeACP
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ITfRangeACP*, Guid*, void**, int>)(lpVtbl[0]))((ITfRangeACP*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITfRangeACP*, uint>)(lpVtbl[1]))((ITfRangeACP*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITfRangeACP*, uint>)(lpVtbl[2]))((ITfRangeACP*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetText([NativeTypeName("TfEditCookie")] uint ec, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("WCHAR *")] ushort* pchText, [NativeTypeName("ULONG")] uint cchMax, [NativeTypeName("ULONG *")] uint* pcch)
        {
            return ((delegate* unmanaged<ITfRangeACP*, uint, uint, ushort*, uint, uint*, int>)(lpVtbl[3]))((ITfRangeACP*)Unsafe.AsPointer(ref this), ec, dwFlags, pchText, cchMax, pcch);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetText([NativeTypeName("TfEditCookie")] uint ec, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("const WCHAR *")] ushort* pchText, [NativeTypeName("LONG")] int cch)
        {
            return ((delegate* unmanaged<ITfRangeACP*, uint, uint, ushort*, int, int>)(lpVtbl[4]))((ITfRangeACP*)Unsafe.AsPointer(ref this), ec, dwFlags, pchText, cch);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFormattedText([NativeTypeName("TfEditCookie")] uint ec, IDataObject** ppDataObject)
        {
            return ((delegate* unmanaged<ITfRangeACP*, uint, IDataObject**, int>)(lpVtbl[5]))((ITfRangeACP*)Unsafe.AsPointer(ref this), ec, ppDataObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetEmbedded([NativeTypeName("TfEditCookie")] uint ec, [NativeTypeName("const GUID &")] Guid* rguidService, [NativeTypeName("const IID &")] Guid* riid, IUnknown** ppunk)
        {
            return ((delegate* unmanaged<ITfRangeACP*, uint, Guid*, Guid*, IUnknown**, int>)(lpVtbl[6]))((ITfRangeACP*)Unsafe.AsPointer(ref this), ec, rguidService, riid, ppunk);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int InsertEmbedded([NativeTypeName("TfEditCookie")] uint ec, [NativeTypeName("DWORD")] uint dwFlags, IDataObject* pDataObject)
        {
            return ((delegate* unmanaged<ITfRangeACP*, uint, uint, IDataObject*, int>)(lpVtbl[7]))((ITfRangeACP*)Unsafe.AsPointer(ref this), ec, dwFlags, pDataObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ShiftStart([NativeTypeName("TfEditCookie")] uint ec, [NativeTypeName("LONG")] int cchReq, [NativeTypeName("LONG *")] int* pcch, [NativeTypeName("const TF_HALTCOND *")] TF_HALTCOND* pHalt)
        {
            return ((delegate* unmanaged<ITfRangeACP*, uint, int, int*, TF_HALTCOND*, int>)(lpVtbl[8]))((ITfRangeACP*)Unsafe.AsPointer(ref this), ec, cchReq, pcch, pHalt);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ShiftEnd([NativeTypeName("TfEditCookie")] uint ec, [NativeTypeName("LONG")] int cchReq, [NativeTypeName("LONG *")] int* pcch, [NativeTypeName("const TF_HALTCOND *")] TF_HALTCOND* pHalt)
        {
            return ((delegate* unmanaged<ITfRangeACP*, uint, int, int*, TF_HALTCOND*, int>)(lpVtbl[9]))((ITfRangeACP*)Unsafe.AsPointer(ref this), ec, cchReq, pcch, pHalt);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ShiftStartToRange([NativeTypeName("TfEditCookie")] uint ec, ITfRange* pRange, TfAnchor aPos)
        {
            return ((delegate* unmanaged<ITfRangeACP*, uint, ITfRange*, TfAnchor, int>)(lpVtbl[10]))((ITfRangeACP*)Unsafe.AsPointer(ref this), ec, pRange, aPos);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ShiftEndToRange([NativeTypeName("TfEditCookie")] uint ec, ITfRange* pRange, TfAnchor aPos)
        {
            return ((delegate* unmanaged<ITfRangeACP*, uint, ITfRange*, TfAnchor, int>)(lpVtbl[11]))((ITfRangeACP*)Unsafe.AsPointer(ref this), ec, pRange, aPos);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ShiftStartRegion([NativeTypeName("TfEditCookie")] uint ec, TfShiftDir dir, [NativeTypeName("BOOL *")] int* pfNoRegion)
        {
            return ((delegate* unmanaged<ITfRangeACP*, uint, TfShiftDir, int*, int>)(lpVtbl[12]))((ITfRangeACP*)Unsafe.AsPointer(ref this), ec, dir, pfNoRegion);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ShiftEndRegion([NativeTypeName("TfEditCookie")] uint ec, TfShiftDir dir, [NativeTypeName("BOOL *")] int* pfNoRegion)
        {
            return ((delegate* unmanaged<ITfRangeACP*, uint, TfShiftDir, int*, int>)(lpVtbl[13]))((ITfRangeACP*)Unsafe.AsPointer(ref this), ec, dir, pfNoRegion);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int IsEmpty([NativeTypeName("TfEditCookie")] uint ec, [NativeTypeName("BOOL *")] int* pfEmpty)
        {
            return ((delegate* unmanaged<ITfRangeACP*, uint, int*, int>)(lpVtbl[14]))((ITfRangeACP*)Unsafe.AsPointer(ref this), ec, pfEmpty);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Collapse([NativeTypeName("TfEditCookie")] uint ec, TfAnchor aPos)
        {
            return ((delegate* unmanaged<ITfRangeACP*, uint, TfAnchor, int>)(lpVtbl[15]))((ITfRangeACP*)Unsafe.AsPointer(ref this), ec, aPos);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int IsEqualStart([NativeTypeName("TfEditCookie")] uint ec, ITfRange* pWith, TfAnchor aPos, [NativeTypeName("BOOL *")] int* pfEqual)
        {
            return ((delegate* unmanaged<ITfRangeACP*, uint, ITfRange*, TfAnchor, int*, int>)(lpVtbl[16]))((ITfRangeACP*)Unsafe.AsPointer(ref this), ec, pWith, aPos, pfEqual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int IsEqualEnd([NativeTypeName("TfEditCookie")] uint ec, ITfRange* pWith, TfAnchor aPos, [NativeTypeName("BOOL *")] int* pfEqual)
        {
            return ((delegate* unmanaged<ITfRangeACP*, uint, ITfRange*, TfAnchor, int*, int>)(lpVtbl[17]))((ITfRangeACP*)Unsafe.AsPointer(ref this), ec, pWith, aPos, pfEqual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CompareStart([NativeTypeName("TfEditCookie")] uint ec, ITfRange* pWith, TfAnchor aPos, [NativeTypeName("LONG *")] int* plResult)
        {
            return ((delegate* unmanaged<ITfRangeACP*, uint, ITfRange*, TfAnchor, int*, int>)(lpVtbl[18]))((ITfRangeACP*)Unsafe.AsPointer(ref this), ec, pWith, aPos, plResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CompareEnd([NativeTypeName("TfEditCookie")] uint ec, ITfRange* pWith, TfAnchor aPos, [NativeTypeName("LONG *")] int* plResult)
        {
            return ((delegate* unmanaged<ITfRangeACP*, uint, ITfRange*, TfAnchor, int*, int>)(lpVtbl[19]))((ITfRangeACP*)Unsafe.AsPointer(ref this), ec, pWith, aPos, plResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AdjustForInsert([NativeTypeName("TfEditCookie")] uint ec, [NativeTypeName("ULONG")] uint cchInsert, [NativeTypeName("BOOL *")] int* pfInsertOk)
        {
            return ((delegate* unmanaged<ITfRangeACP*, uint, uint, int*, int>)(lpVtbl[20]))((ITfRangeACP*)Unsafe.AsPointer(ref this), ec, cchInsert, pfInsertOk);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetGravity(TfGravity* pgStart, TfGravity* pgEnd)
        {
            return ((delegate* unmanaged<ITfRangeACP*, TfGravity*, TfGravity*, int>)(lpVtbl[21]))((ITfRangeACP*)Unsafe.AsPointer(ref this), pgStart, pgEnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetGravity([NativeTypeName("TfEditCookie")] uint ec, TfGravity gStart, TfGravity gEnd)
        {
            return ((delegate* unmanaged<ITfRangeACP*, uint, TfGravity, TfGravity, int>)(lpVtbl[22]))((ITfRangeACP*)Unsafe.AsPointer(ref this), ec, gStart, gEnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Clone(ITfRange** ppClone)
        {
            return ((delegate* unmanaged<ITfRangeACP*, ITfRange**, int>)(lpVtbl[23]))((ITfRangeACP*)Unsafe.AsPointer(ref this), ppClone);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetContext(ITfContext** ppContext)
        {
            return ((delegate* unmanaged<ITfRangeACP*, ITfContext**, int>)(lpVtbl[24]))((ITfRangeACP*)Unsafe.AsPointer(ref this), ppContext);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetExtent([NativeTypeName("LONG *")] int* pacpAnchor, [NativeTypeName("LONG *")] int* pcch)
        {
            return ((delegate* unmanaged<ITfRangeACP*, int*, int*, int>)(lpVtbl[25]))((ITfRangeACP*)Unsafe.AsPointer(ref this), pacpAnchor, pcch);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetExtent([NativeTypeName("LONG")] int acpAnchor, [NativeTypeName("LONG")] int cch)
        {
            return ((delegate* unmanaged<ITfRangeACP*, int, int, int>)(lpVtbl[26]))((ITfRangeACP*)Unsafe.AsPointer(ref this), acpAnchor, cch);
        }
    }
}
