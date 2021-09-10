// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mftransform.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("D818FBD8-FC46-42F2-87AC-1EA2D1F9BF32")]
    [NativeTypeName("struct IMFDeviceTransform : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IMFDeviceTransform
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFDeviceTransform*, Guid*, void**, int>)(lpVtbl[0]))((IMFDeviceTransform*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFDeviceTransform*, uint>)(lpVtbl[1]))((IMFDeviceTransform*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFDeviceTransform*, uint>)(lpVtbl[2]))((IMFDeviceTransform*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int InitializeTransform(IMFAttributes* pAttributes)
        {
            return ((delegate* unmanaged<IMFDeviceTransform*, IMFAttributes*, int>)(lpVtbl[3]))((IMFDeviceTransform*)Unsafe.AsPointer(ref this), pAttributes);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetInputAvailableType([NativeTypeName("DWORD")] uint dwInputStreamID, [NativeTypeName("DWORD")] uint dwTypeIndex, IMFMediaType** pMediaType)
        {
            return ((delegate* unmanaged<IMFDeviceTransform*, uint, uint, IMFMediaType**, int>)(lpVtbl[4]))((IMFDeviceTransform*)Unsafe.AsPointer(ref this), dwInputStreamID, dwTypeIndex, pMediaType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetInputCurrentType([NativeTypeName("DWORD")] uint dwInputStreamID, IMFMediaType** pMediaType)
        {
            return ((delegate* unmanaged<IMFDeviceTransform*, uint, IMFMediaType**, int>)(lpVtbl[5]))((IMFDeviceTransform*)Unsafe.AsPointer(ref this), dwInputStreamID, pMediaType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int GetInputStreamAttributes([NativeTypeName("DWORD")] uint dwInputStreamID, IMFAttributes** ppAttributes)
        {
            return ((delegate* unmanaged<IMFDeviceTransform*, uint, IMFAttributes**, int>)(lpVtbl[6]))((IMFDeviceTransform*)Unsafe.AsPointer(ref this), dwInputStreamID, ppAttributes);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int GetOutputAvailableType([NativeTypeName("DWORD")] uint dwOutputStreamID, [NativeTypeName("DWORD")] uint dwTypeIndex, IMFMediaType** pMediaType)
        {
            return ((delegate* unmanaged<IMFDeviceTransform*, uint, uint, IMFMediaType**, int>)(lpVtbl[7]))((IMFDeviceTransform*)Unsafe.AsPointer(ref this), dwOutputStreamID, dwTypeIndex, pMediaType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int GetOutputCurrentType([NativeTypeName("DWORD")] uint dwOutputStreamID, IMFMediaType** pMediaType)
        {
            return ((delegate* unmanaged<IMFDeviceTransform*, uint, IMFMediaType**, int>)(lpVtbl[8]))((IMFDeviceTransform*)Unsafe.AsPointer(ref this), dwOutputStreamID, pMediaType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int GetOutputStreamAttributes([NativeTypeName("DWORD")] uint dwOutputStreamID, IMFAttributes** ppAttributes)
        {
            return ((delegate* unmanaged<IMFDeviceTransform*, uint, IMFAttributes**, int>)(lpVtbl[9]))((IMFDeviceTransform*)Unsafe.AsPointer(ref this), dwOutputStreamID, ppAttributes);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int GetStreamCount([NativeTypeName("DWORD *")] uint* pcInputStreams, [NativeTypeName("DWORD *")] uint* pcOutputStreams)
        {
            return ((delegate* unmanaged<IMFDeviceTransform*, uint*, uint*, int>)(lpVtbl[10]))((IMFDeviceTransform*)Unsafe.AsPointer(ref this), pcInputStreams, pcOutputStreams);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int GetStreamIDs([NativeTypeName("DWORD")] uint dwInputIDArraySize, [NativeTypeName("DWORD *")] uint* pdwInputStreamIds, [NativeTypeName("DWORD")] uint dwOutputIDArraySize, [NativeTypeName("DWORD *")] uint* pdwOutputStreamIds)
        {
            return ((delegate* unmanaged<IMFDeviceTransform*, uint, uint*, uint, uint*, int>)(lpVtbl[11]))((IMFDeviceTransform*)Unsafe.AsPointer(ref this), dwInputIDArraySize, pdwInputStreamIds, dwOutputIDArraySize, pdwOutputStreamIds);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int ProcessEvent([NativeTypeName("DWORD")] uint dwInputStreamID, IMFMediaEvent* pEvent)
        {
            return ((delegate* unmanaged<IMFDeviceTransform*, uint, IMFMediaEvent*, int>)(lpVtbl[12]))((IMFDeviceTransform*)Unsafe.AsPointer(ref this), dwInputStreamID, pEvent);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int ProcessInput([NativeTypeName("DWORD")] uint dwInputStreamID, IMFSample* pSample, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* unmanaged<IMFDeviceTransform*, uint, IMFSample*, uint, int>)(lpVtbl[13]))((IMFDeviceTransform*)Unsafe.AsPointer(ref this), dwInputStreamID, pSample, dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int ProcessMessage(MFT_MESSAGE_TYPE eMessage, [NativeTypeName("ULONG_PTR")] nuint ulParam)
        {
            return ((delegate* unmanaged<IMFDeviceTransform*, MFT_MESSAGE_TYPE, nuint, int>)(lpVtbl[14]))((IMFDeviceTransform*)Unsafe.AsPointer(ref this), eMessage, ulParam);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        public int ProcessOutput([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD")] uint cOutputBufferCount, MFT_OUTPUT_DATA_BUFFER* pOutputSample, [NativeTypeName("DWORD *")] uint* pdwStatus)
        {
            return ((delegate* unmanaged<IMFDeviceTransform*, uint, uint, MFT_OUTPUT_DATA_BUFFER*, uint*, int>)(lpVtbl[15]))((IMFDeviceTransform*)Unsafe.AsPointer(ref this), dwFlags, cOutputBufferCount, pOutputSample, pdwStatus);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("HRESULT")]
        public int SetInputStreamState([NativeTypeName("DWORD")] uint dwStreamID, IMFMediaType* pMediaType, DeviceStreamState value, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* unmanaged<IMFDeviceTransform*, uint, IMFMediaType*, DeviceStreamState, uint, int>)(lpVtbl[16]))((IMFDeviceTransform*)Unsafe.AsPointer(ref this), dwStreamID, pMediaType, value, dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        [return: NativeTypeName("HRESULT")]
        public int GetInputStreamState([NativeTypeName("DWORD")] uint dwStreamID, DeviceStreamState* value)
        {
            return ((delegate* unmanaged<IMFDeviceTransform*, uint, DeviceStreamState*, int>)(lpVtbl[17]))((IMFDeviceTransform*)Unsafe.AsPointer(ref this), dwStreamID, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        [return: NativeTypeName("HRESULT")]
        public int SetOutputStreamState([NativeTypeName("DWORD")] uint dwStreamID, IMFMediaType* pMediaType, DeviceStreamState value, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* unmanaged<IMFDeviceTransform*, uint, IMFMediaType*, DeviceStreamState, uint, int>)(lpVtbl[18]))((IMFDeviceTransform*)Unsafe.AsPointer(ref this), dwStreamID, pMediaType, value, dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        [return: NativeTypeName("HRESULT")]
        public int GetOutputStreamState([NativeTypeName("DWORD")] uint dwStreamID, DeviceStreamState* value)
        {
            return ((delegate* unmanaged<IMFDeviceTransform*, uint, DeviceStreamState*, int>)(lpVtbl[19]))((IMFDeviceTransform*)Unsafe.AsPointer(ref this), dwStreamID, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        [return: NativeTypeName("HRESULT")]
        public int GetInputStreamPreferredState([NativeTypeName("DWORD")] uint dwStreamID, DeviceStreamState* value, IMFMediaType** ppMediaType)
        {
            return ((delegate* unmanaged<IMFDeviceTransform*, uint, DeviceStreamState*, IMFMediaType**, int>)(lpVtbl[20]))((IMFDeviceTransform*)Unsafe.AsPointer(ref this), dwStreamID, value, ppMediaType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        [return: NativeTypeName("HRESULT")]
        public int FlushInputStream([NativeTypeName("DWORD")] uint dwStreamIndex, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* unmanaged<IMFDeviceTransform*, uint, uint, int>)(lpVtbl[21]))((IMFDeviceTransform*)Unsafe.AsPointer(ref this), dwStreamIndex, dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        [return: NativeTypeName("HRESULT")]
        public int FlushOutputStream([NativeTypeName("DWORD")] uint dwStreamIndex, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* unmanaged<IMFDeviceTransform*, uint, uint, int>)(lpVtbl[22]))((IMFDeviceTransform*)Unsafe.AsPointer(ref this), dwStreamIndex, dwFlags);
        }
    }
}
