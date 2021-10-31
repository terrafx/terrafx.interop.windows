// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/imapi2.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("25983550-9D65-49CE-B335-40630D901227")]
    [NativeTypeName("struct IRawCDImageCreator : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct IRawCDImageCreator
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IRawCDImageCreator*, Guid*, void**, int>)(lpVtbl[0]))((IRawCDImageCreator*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IRawCDImageCreator*, uint>)(lpVtbl[1]))((IRawCDImageCreator*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IRawCDImageCreator*, uint>)(lpVtbl[2]))((IRawCDImageCreator*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetTypeInfoCount(uint* pctinfo)
        {
            return ((delegate* unmanaged<IRawCDImageCreator*, uint*, int>)(lpVtbl[3]))((IRawCDImageCreator*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IRawCDImageCreator*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IRawCDImageCreator*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IRawCDImageCreator*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IRawCDImageCreator*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
        {
            return ((delegate* unmanaged<IRawCDImageCreator*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IRawCDImageCreator*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT CreateResultImage(IStream** resultStream)
        {
            return ((delegate* unmanaged<IRawCDImageCreator*, IStream**, int>)(lpVtbl[7]))((IRawCDImageCreator*)Unsafe.AsPointer(ref this), resultStream);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT AddTrack(IMAPI_CD_SECTOR_TYPE dataType, IStream* data, [NativeTypeName("LONG *")] int* trackIndex)
        {
            return ((delegate* unmanaged<IRawCDImageCreator*, IMAPI_CD_SECTOR_TYPE, IStream*, int*, int>)(lpVtbl[8]))((IRawCDImageCreator*)Unsafe.AsPointer(ref this), dataType, data, trackIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT AddSpecialPregap(IStream* data)
        {
            return ((delegate* unmanaged<IRawCDImageCreator*, IStream*, int>)(lpVtbl[9]))((IRawCDImageCreator*)Unsafe.AsPointer(ref this), data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT AddSubcodeRWGenerator(IStream* subcode)
        {
            return ((delegate* unmanaged<IRawCDImageCreator*, IStream*, int>)(lpVtbl[10]))((IRawCDImageCreator*)Unsafe.AsPointer(ref this), subcode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT put_ResultingImageType(IMAPI_FORMAT2_RAW_CD_DATA_SECTOR_TYPE value)
        {
            return ((delegate* unmanaged<IRawCDImageCreator*, IMAPI_FORMAT2_RAW_CD_DATA_SECTOR_TYPE, int>)(lpVtbl[11]))((IRawCDImageCreator*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT get_ResultingImageType(IMAPI_FORMAT2_RAW_CD_DATA_SECTOR_TYPE* value)
        {
            return ((delegate* unmanaged<IRawCDImageCreator*, IMAPI_FORMAT2_RAW_CD_DATA_SECTOR_TYPE*, int>)(lpVtbl[12]))((IRawCDImageCreator*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT get_StartOfLeadout([NativeTypeName("LONG *")] int* value)
        {
            return ((delegate* unmanaged<IRawCDImageCreator*, int*, int>)(lpVtbl[13]))((IRawCDImageCreator*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT put_StartOfLeadoutLimit([NativeTypeName("LONG")] int value)
        {
            return ((delegate* unmanaged<IRawCDImageCreator*, int, int>)(lpVtbl[14]))((IRawCDImageCreator*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT get_StartOfLeadoutLimit([NativeTypeName("LONG *")] int* value)
        {
            return ((delegate* unmanaged<IRawCDImageCreator*, int*, int>)(lpVtbl[15]))((IRawCDImageCreator*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT put_DisableGaplessAudio([NativeTypeName("VARIANT_BOOL")] short value)
        {
            return ((delegate* unmanaged<IRawCDImageCreator*, short, int>)(lpVtbl[16]))((IRawCDImageCreator*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT get_DisableGaplessAudio([NativeTypeName("VARIANT_BOOL *")] short* value)
        {
            return ((delegate* unmanaged<IRawCDImageCreator*, short*, int>)(lpVtbl[17]))((IRawCDImageCreator*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT put_MediaCatalogNumber([NativeTypeName("BSTR")] ushort* value)
        {
            return ((delegate* unmanaged<IRawCDImageCreator*, ushort*, int>)(lpVtbl[18]))((IRawCDImageCreator*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT get_MediaCatalogNumber([NativeTypeName("BSTR *")] ushort** value)
        {
            return ((delegate* unmanaged<IRawCDImageCreator*, ushort**, int>)(lpVtbl[19]))((IRawCDImageCreator*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public HRESULT put_StartingTrackNumber([NativeTypeName("LONG")] int value)
        {
            return ((delegate* unmanaged<IRawCDImageCreator*, int, int>)(lpVtbl[20]))((IRawCDImageCreator*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public HRESULT get_StartingTrackNumber([NativeTypeName("LONG *")] int* value)
        {
            return ((delegate* unmanaged<IRawCDImageCreator*, int*, int>)(lpVtbl[21]))((IRawCDImageCreator*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        public HRESULT get_TrackInfo([NativeTypeName("LONG")] int trackIndex, IRawCDImageTrackInfo** value)
        {
            return ((delegate* unmanaged<IRawCDImageCreator*, int, IRawCDImageTrackInfo**, int>)(lpVtbl[22]))((IRawCDImageCreator*)Unsafe.AsPointer(ref this), trackIndex, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        public HRESULT get_NumberOfExistingTracks([NativeTypeName("LONG *")] int* value)
        {
            return ((delegate* unmanaged<IRawCDImageCreator*, int*, int>)(lpVtbl[23]))((IRawCDImageCreator*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        public HRESULT get_LastUsedUserSectorInImage([NativeTypeName("LONG *")] int* value)
        {
            return ((delegate* unmanaged<IRawCDImageCreator*, int*, int>)(lpVtbl[24]))((IRawCDImageCreator*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        public HRESULT get_ExpectedTableOfContents(SAFEARRAY** value)
        {
            return ((delegate* unmanaged<IRawCDImageCreator*, SAFEARRAY**, int>)(lpVtbl[25]))((IRawCDImageCreator*)Unsafe.AsPointer(ref this), value);
        }
    }
}
