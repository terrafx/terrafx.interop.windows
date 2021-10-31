// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/imapi2.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("27354132-7F64-5B0F-8F00-5D77AFBE261E")]
    [NativeTypeName("struct IDiscRecorder2Ex : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IDiscRecorder2Ex
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDiscRecorder2Ex*, Guid*, void**, int>)(lpVtbl[0]))((IDiscRecorder2Ex*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDiscRecorder2Ex*, uint>)(lpVtbl[1]))((IDiscRecorder2Ex*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDiscRecorder2Ex*, uint>)(lpVtbl[2]))((IDiscRecorder2Ex*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT SendCommandNoData([NativeTypeName("BYTE *")] byte* Cdb, [NativeTypeName("ULONG")] uint CdbSize, [NativeTypeName("BYTE [18]")] byte* SenseBuffer, [NativeTypeName("ULONG")] uint Timeout)
        {
            return ((delegate* unmanaged<IDiscRecorder2Ex*, byte*, uint, byte*, uint, int>)(lpVtbl[3]))((IDiscRecorder2Ex*)Unsafe.AsPointer(ref this), Cdb, CdbSize, SenseBuffer, Timeout);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT SendCommandSendDataToDevice([NativeTypeName("BYTE *")] byte* Cdb, [NativeTypeName("ULONG")] uint CdbSize, [NativeTypeName("BYTE [18]")] byte* SenseBuffer, [NativeTypeName("ULONG")] uint Timeout, [NativeTypeName("BYTE *")] byte* Buffer, [NativeTypeName("ULONG_IMAPI2_NONZERO")] uint BufferSize)
        {
            return ((delegate* unmanaged<IDiscRecorder2Ex*, byte*, uint, byte*, uint, byte*, uint, int>)(lpVtbl[4]))((IDiscRecorder2Ex*)Unsafe.AsPointer(ref this), Cdb, CdbSize, SenseBuffer, Timeout, Buffer, BufferSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT SendCommandGetDataFromDevice([NativeTypeName("BYTE *")] byte* Cdb, [NativeTypeName("ULONG")] uint CdbSize, [NativeTypeName("BYTE [18]")] byte* SenseBuffer, [NativeTypeName("ULONG")] uint Timeout, [NativeTypeName("BYTE *")] byte* Buffer, [NativeTypeName("ULONG_IMAPI2_NONZERO")] uint BufferSize, [NativeTypeName("ULONG_IMAPI2_NOT_NEGATIVE *")] uint* BufferFetched)
        {
            return ((delegate* unmanaged<IDiscRecorder2Ex*, byte*, uint, byte*, uint, byte*, uint, uint*, int>)(lpVtbl[5]))((IDiscRecorder2Ex*)Unsafe.AsPointer(ref this), Cdb, CdbSize, SenseBuffer, Timeout, Buffer, BufferSize, BufferFetched);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT ReadDvdStructure([NativeTypeName("ULONG")] uint format, [NativeTypeName("ULONG")] uint address, [NativeTypeName("ULONG")] uint layer, [NativeTypeName("ULONG")] uint agid, [NativeTypeName("BYTE **")] byte** data, [NativeTypeName("ULONG_IMAPI2_DVD_STRUCTURE *")] uint* count)
        {
            return ((delegate* unmanaged<IDiscRecorder2Ex*, uint, uint, uint, uint, byte**, uint*, int>)(lpVtbl[6]))((IDiscRecorder2Ex*)Unsafe.AsPointer(ref this), format, address, layer, agid, data, count);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT SendDvdStructure([NativeTypeName("ULONG")] uint format, [NativeTypeName("BYTE *")] byte* data, [NativeTypeName("ULONG_IMAPI2_DVD_STRUCTURE")] uint count)
        {
            return ((delegate* unmanaged<IDiscRecorder2Ex*, uint, byte*, uint, int>)(lpVtbl[7]))((IDiscRecorder2Ex*)Unsafe.AsPointer(ref this), format, data, count);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT GetAdapterDescriptor([NativeTypeName("BYTE **")] byte** data, [NativeTypeName("ULONG_IMAPI2_ADAPTER_DESCRIPTOR *")] uint* byteSize)
        {
            return ((delegate* unmanaged<IDiscRecorder2Ex*, byte**, uint*, int>)(lpVtbl[8]))((IDiscRecorder2Ex*)Unsafe.AsPointer(ref this), data, byteSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT GetDeviceDescriptor([NativeTypeName("BYTE **")] byte** data, [NativeTypeName("ULONG_IMAPI2_DEVICE_DESCRIPTOR *")] uint* byteSize)
        {
            return ((delegate* unmanaged<IDiscRecorder2Ex*, byte**, uint*, int>)(lpVtbl[9]))((IDiscRecorder2Ex*)Unsafe.AsPointer(ref this), data, byteSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT GetDiscInformation([NativeTypeName("BYTE **")] byte** discInformation, [NativeTypeName("ULONG_IMAPI2_DISC_INFORMATION *")] uint* byteSize)
        {
            return ((delegate* unmanaged<IDiscRecorder2Ex*, byte**, uint*, int>)(lpVtbl[10]))((IDiscRecorder2Ex*)Unsafe.AsPointer(ref this), discInformation, byteSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT GetTrackInformation([NativeTypeName("ULONG")] uint address, IMAPI_READ_TRACK_ADDRESS_TYPE addressType, [NativeTypeName("BYTE **")] byte** trackInformation, [NativeTypeName("ULONG_IMAPI2_TRACK_INFORMATION *")] uint* byteSize)
        {
            return ((delegate* unmanaged<IDiscRecorder2Ex*, uint, IMAPI_READ_TRACK_ADDRESS_TYPE, byte**, uint*, int>)(lpVtbl[11]))((IDiscRecorder2Ex*)Unsafe.AsPointer(ref this), address, addressType, trackInformation, byteSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT GetFeaturePage(IMAPI_FEATURE_PAGE_TYPE requestedFeature, [NativeTypeName("BOOLEAN")] byte currentFeatureOnly, [NativeTypeName("BYTE **")] byte** featureData, [NativeTypeName("ULONG_IMAPI2_FEATURE_PAGE *")] uint* byteSize)
        {
            return ((delegate* unmanaged<IDiscRecorder2Ex*, IMAPI_FEATURE_PAGE_TYPE, byte, byte**, uint*, int>)(lpVtbl[12]))((IDiscRecorder2Ex*)Unsafe.AsPointer(ref this), requestedFeature, currentFeatureOnly, featureData, byteSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT GetModePage(IMAPI_MODE_PAGE_TYPE requestedModePage, IMAPI_MODE_PAGE_REQUEST_TYPE requestType, [NativeTypeName("BYTE **")] byte** modePageData, [NativeTypeName("ULONG_IMAPI2_MODE_PAGE *")] uint* byteSize)
        {
            return ((delegate* unmanaged<IDiscRecorder2Ex*, IMAPI_MODE_PAGE_TYPE, IMAPI_MODE_PAGE_REQUEST_TYPE, byte**, uint*, int>)(lpVtbl[13]))((IDiscRecorder2Ex*)Unsafe.AsPointer(ref this), requestedModePage, requestType, modePageData, byteSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT SetModePage(IMAPI_MODE_PAGE_REQUEST_TYPE requestType, [NativeTypeName("BYTE *")] byte* data, [NativeTypeName("ULONG_IMAPI2_MODE_PAGE")] uint byteSize)
        {
            return ((delegate* unmanaged<IDiscRecorder2Ex*, IMAPI_MODE_PAGE_REQUEST_TYPE, byte*, uint, int>)(lpVtbl[14]))((IDiscRecorder2Ex*)Unsafe.AsPointer(ref this), requestType, data, byteSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT GetSupportedFeaturePages([NativeTypeName("BOOLEAN")] byte currentFeatureOnly, IMAPI_FEATURE_PAGE_TYPE** featureData, [NativeTypeName("ULONG_IMAPI2_ALL_FEATURE_PAGES *")] uint* byteSize)
        {
            return ((delegate* unmanaged<IDiscRecorder2Ex*, byte, IMAPI_FEATURE_PAGE_TYPE**, uint*, int>)(lpVtbl[15]))((IDiscRecorder2Ex*)Unsafe.AsPointer(ref this), currentFeatureOnly, featureData, byteSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT GetSupportedProfiles([NativeTypeName("BOOLEAN")] byte currentOnly, IMAPI_PROFILE_TYPE** profileTypes, [NativeTypeName("ULONG_IMAPI2_ALL_PROFILES *")] uint* validProfiles)
        {
            return ((delegate* unmanaged<IDiscRecorder2Ex*, byte, IMAPI_PROFILE_TYPE**, uint*, int>)(lpVtbl[16]))((IDiscRecorder2Ex*)Unsafe.AsPointer(ref this), currentOnly, profileTypes, validProfiles);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT GetSupportedModePages(IMAPI_MODE_PAGE_REQUEST_TYPE requestType, IMAPI_MODE_PAGE_TYPE** modePageTypes, [NativeTypeName("ULONG_IMAPI2_ALL_MODE_PAGES *")] uint* validPages)
        {
            return ((delegate* unmanaged<IDiscRecorder2Ex*, IMAPI_MODE_PAGE_REQUEST_TYPE, IMAPI_MODE_PAGE_TYPE**, uint*, int>)(lpVtbl[17]))((IDiscRecorder2Ex*)Unsafe.AsPointer(ref this), requestType, modePageTypes, validPages);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT GetByteAlignmentMask([NativeTypeName("ULONG *")] uint* value)
        {
            return ((delegate* unmanaged<IDiscRecorder2Ex*, uint*, int>)(lpVtbl[18]))((IDiscRecorder2Ex*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT GetMaximumNonPageAlignedTransferSize([NativeTypeName("ULONG *")] uint* value)
        {
            return ((delegate* unmanaged<IDiscRecorder2Ex*, uint*, int>)(lpVtbl[19]))((IDiscRecorder2Ex*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public HRESULT GetMaximumPageAlignedTransferSize([NativeTypeName("ULONG *")] uint* value)
        {
            return ((delegate* unmanaged<IDiscRecorder2Ex*, uint*, int>)(lpVtbl[20]))((IDiscRecorder2Ex*)Unsafe.AsPointer(ref this), value);
        }
    }
}
