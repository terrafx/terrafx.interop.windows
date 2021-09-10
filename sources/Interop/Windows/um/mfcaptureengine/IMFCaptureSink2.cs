// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfcaptureengine.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("F9E4219E-6197-4B5E-B888-BEE310AB2C59")]
    [NativeTypeName("struct IMFCaptureSink2 : IMFCaptureSink")]
    [NativeInheritance("IMFCaptureSink")]
    public unsafe partial struct IMFCaptureSink2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFCaptureSink2*, Guid*, void**, int>)(lpVtbl[0]))((IMFCaptureSink2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFCaptureSink2*, uint>)(lpVtbl[1]))((IMFCaptureSink2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFCaptureSink2*, uint>)(lpVtbl[2]))((IMFCaptureSink2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetOutputMediaType([NativeTypeName("DWORD")] uint dwSinkStreamIndex, IMFMediaType** ppMediaType)
        {
            return ((delegate* unmanaged<IMFCaptureSink2*, uint, IMFMediaType**, int>)(lpVtbl[3]))((IMFCaptureSink2*)Unsafe.AsPointer(ref this), dwSinkStreamIndex, ppMediaType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetService([NativeTypeName("DWORD")] uint dwSinkStreamIndex, [NativeTypeName("const GUID &")] Guid* rguidService, [NativeTypeName("const IID &")] Guid* riid, IUnknown** ppUnknown)
        {
            return ((delegate* unmanaged<IMFCaptureSink2*, uint, Guid*, Guid*, IUnknown**, int>)(lpVtbl[4]))((IMFCaptureSink2*)Unsafe.AsPointer(ref this), dwSinkStreamIndex, rguidService, riid, ppUnknown);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int AddStream([NativeTypeName("DWORD")] uint dwSourceStreamIndex, IMFMediaType* pMediaType, IMFAttributes* pAttributes, [NativeTypeName("DWORD *")] uint* pdwSinkStreamIndex)
        {
            return ((delegate* unmanaged<IMFCaptureSink2*, uint, IMFMediaType*, IMFAttributes*, uint*, int>)(lpVtbl[5]))((IMFCaptureSink2*)Unsafe.AsPointer(ref this), dwSourceStreamIndex, pMediaType, pAttributes, pdwSinkStreamIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int Prepare()
        {
            return ((delegate* unmanaged<IMFCaptureSink2*, int>)(lpVtbl[6]))((IMFCaptureSink2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int RemoveAllStreams()
        {
            return ((delegate* unmanaged<IMFCaptureSink2*, int>)(lpVtbl[7]))((IMFCaptureSink2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int SetOutputMediaType([NativeTypeName("DWORD")] uint dwStreamIndex, IMFMediaType* pMediaType, IMFAttributes* pEncodingAttributes)
        {
            return ((delegate* unmanaged<IMFCaptureSink2*, uint, IMFMediaType*, IMFAttributes*, int>)(lpVtbl[8]))((IMFCaptureSink2*)Unsafe.AsPointer(ref this), dwStreamIndex, pMediaType, pEncodingAttributes);
        }
    }
}
