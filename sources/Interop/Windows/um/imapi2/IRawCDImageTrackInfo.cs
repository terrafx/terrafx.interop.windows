// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/imapi2.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("25983551-9D65-49CE-B335-40630D901227")]
    [NativeTypeName("struct IRawCDImageTrackInfo : IDispatch")]
    public unsafe partial struct IRawCDImageTrackInfo
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IRawCDImageTrackInfo*, Guid*, void**, int>)(lpVtbl[0]))((IRawCDImageTrackInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IRawCDImageTrackInfo*, uint>)(lpVtbl[1]))((IRawCDImageTrackInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IRawCDImageTrackInfo*, uint>)(lpVtbl[2]))((IRawCDImageTrackInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<IRawCDImageTrackInfo*, uint*, int>)(lpVtbl[3]))((IRawCDImageTrackInfo*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IRawCDImageTrackInfo*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IRawCDImageTrackInfo*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IRawCDImageTrackInfo*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IRawCDImageTrackInfo*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<IRawCDImageTrackInfo*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IRawCDImageTrackInfo*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_StartingLba([NativeTypeName("LONG *")] int* value)
        {
            return ((delegate* unmanaged<IRawCDImageTrackInfo*, int*, int>)(lpVtbl[7]))((IRawCDImageTrackInfo*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_SectorCount([NativeTypeName("LONG *")] int* value)
        {
            return ((delegate* unmanaged<IRawCDImageTrackInfo*, int*, int>)(lpVtbl[8]))((IRawCDImageTrackInfo*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_TrackNumber([NativeTypeName("LONG *")] int* value)
        {
            return ((delegate* unmanaged<IRawCDImageTrackInfo*, int*, int>)(lpVtbl[9]))((IRawCDImageTrackInfo*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_SectorType(IMAPI_CD_SECTOR_TYPE* value)
        {
            return ((delegate* unmanaged<IRawCDImageTrackInfo*, IMAPI_CD_SECTOR_TYPE*, int>)(lpVtbl[10]))((IRawCDImageTrackInfo*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_ISRC([NativeTypeName("BSTR *")] ushort** value)
        {
            return ((delegate* unmanaged<IRawCDImageTrackInfo*, ushort**, int>)(lpVtbl[11]))((IRawCDImageTrackInfo*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_ISRC([NativeTypeName("BSTR")] ushort* value)
        {
            return ((delegate* unmanaged<IRawCDImageTrackInfo*, ushort*, int>)(lpVtbl[12]))((IRawCDImageTrackInfo*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_DigitalAudioCopySetting(IMAPI_CD_TRACK_DIGITAL_COPY_SETTING* value)
        {
            return ((delegate* unmanaged<IRawCDImageTrackInfo*, IMAPI_CD_TRACK_DIGITAL_COPY_SETTING*, int>)(lpVtbl[13]))((IRawCDImageTrackInfo*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_DigitalAudioCopySetting(IMAPI_CD_TRACK_DIGITAL_COPY_SETTING value)
        {
            return ((delegate* unmanaged<IRawCDImageTrackInfo*, IMAPI_CD_TRACK_DIGITAL_COPY_SETTING, int>)(lpVtbl[14]))((IRawCDImageTrackInfo*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_AudioHasPreemphasis([NativeTypeName("VARIANT_BOOL *")] short* value)
        {
            return ((delegate* unmanaged<IRawCDImageTrackInfo*, short*, int>)(lpVtbl[15]))((IRawCDImageTrackInfo*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_AudioHasPreemphasis([NativeTypeName("VARIANT_BOOL")] short value)
        {
            return ((delegate* unmanaged<IRawCDImageTrackInfo*, short, int>)(lpVtbl[16]))((IRawCDImageTrackInfo*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_TrackIndexes(SAFEARRAY** value)
        {
            return ((delegate* unmanaged<IRawCDImageTrackInfo*, SAFEARRAY**, int>)(lpVtbl[17]))((IRawCDImageTrackInfo*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AddTrackIndex([NativeTypeName("LONG")] int lbaOffset)
        {
            return ((delegate* unmanaged<IRawCDImageTrackInfo*, int, int>)(lpVtbl[18]))((IRawCDImageTrackInfo*)Unsafe.AsPointer(ref this), lbaOffset);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ClearTrackIndex([NativeTypeName("LONG")] int lbaOffset)
        {
            return ((delegate* unmanaged<IRawCDImageTrackInfo*, int, int>)(lpVtbl[19]))((IRawCDImageTrackInfo*)Unsafe.AsPointer(ref this), lbaOffset);
        }
    }
}
