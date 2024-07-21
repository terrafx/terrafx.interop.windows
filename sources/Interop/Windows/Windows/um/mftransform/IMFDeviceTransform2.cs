// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mftransform.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IMFDeviceTransform2.xml' path='doc/member[@name="IMFDeviceTransform2"]/*' />
[Guid("F5980FED-B521-488F-909F-1A5FCECEDB14")]
[NativeTypeName("struct IMFDeviceTransform2 : IMFDeviceTransform")]
[NativeInheritance("IMFDeviceTransform")]
public unsafe partial struct IMFDeviceTransform2 : IMFDeviceTransform2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFDeviceTransform2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMFDeviceTransform2*, Guid*, void**, int>)(lpVtbl[0]))((IMFDeviceTransform2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMFDeviceTransform2*, uint>)(lpVtbl[1]))((IMFDeviceTransform2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMFDeviceTransform2*, uint>)(lpVtbl[2]))((IMFDeviceTransform2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IMFDeviceTransform.InitializeTransform" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT InitializeTransform(IMFAttributes* pAttributes)
    {
        return ((delegate* unmanaged[MemberFunction]<IMFDeviceTransform2*, IMFAttributes*, int>)(lpVtbl[3]))((IMFDeviceTransform2*)Unsafe.AsPointer(ref this), pAttributes);
    }

    /// <inheritdoc cref="IMFDeviceTransform.GetInputAvailableType" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetInputAvailableType([NativeTypeName("DWORD")] uint dwInputStreamID, [NativeTypeName("DWORD")] uint dwTypeIndex, IMFMediaType** pMediaType)
    {
        return ((delegate* unmanaged[MemberFunction]<IMFDeviceTransform2*, uint, uint, IMFMediaType**, int>)(lpVtbl[4]))((IMFDeviceTransform2*)Unsafe.AsPointer(ref this), dwInputStreamID, dwTypeIndex, pMediaType);
    }

    /// <inheritdoc cref="IMFDeviceTransform.GetInputCurrentType" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetInputCurrentType([NativeTypeName("DWORD")] uint dwInputStreamID, IMFMediaType** pMediaType)
    {
        return ((delegate* unmanaged[MemberFunction]<IMFDeviceTransform2*, uint, IMFMediaType**, int>)(lpVtbl[5]))((IMFDeviceTransform2*)Unsafe.AsPointer(ref this), dwInputStreamID, pMediaType);
    }

    /// <inheritdoc cref="IMFDeviceTransform.GetInputStreamAttributes" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetInputStreamAttributes([NativeTypeName("DWORD")] uint dwInputStreamID, IMFAttributes** ppAttributes)
    {
        return ((delegate* unmanaged[MemberFunction]<IMFDeviceTransform2*, uint, IMFAttributes**, int>)(lpVtbl[6]))((IMFDeviceTransform2*)Unsafe.AsPointer(ref this), dwInputStreamID, ppAttributes);
    }

    /// <inheritdoc cref="IMFDeviceTransform.GetOutputAvailableType" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetOutputAvailableType([NativeTypeName("DWORD")] uint dwOutputStreamID, [NativeTypeName("DWORD")] uint dwTypeIndex, IMFMediaType** pMediaType)
    {
        return ((delegate* unmanaged[MemberFunction]<IMFDeviceTransform2*, uint, uint, IMFMediaType**, int>)(lpVtbl[7]))((IMFDeviceTransform2*)Unsafe.AsPointer(ref this), dwOutputStreamID, dwTypeIndex, pMediaType);
    }

    /// <inheritdoc cref="IMFDeviceTransform.GetOutputCurrentType" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetOutputCurrentType([NativeTypeName("DWORD")] uint dwOutputStreamID, IMFMediaType** pMediaType)
    {
        return ((delegate* unmanaged[MemberFunction]<IMFDeviceTransform2*, uint, IMFMediaType**, int>)(lpVtbl[8]))((IMFDeviceTransform2*)Unsafe.AsPointer(ref this), dwOutputStreamID, pMediaType);
    }

    /// <inheritdoc cref="IMFDeviceTransform.GetOutputStreamAttributes" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetOutputStreamAttributes([NativeTypeName("DWORD")] uint dwOutputStreamID, IMFAttributes** ppAttributes)
    {
        return ((delegate* unmanaged[MemberFunction]<IMFDeviceTransform2*, uint, IMFAttributes**, int>)(lpVtbl[9]))((IMFDeviceTransform2*)Unsafe.AsPointer(ref this), dwOutputStreamID, ppAttributes);
    }

    /// <inheritdoc cref="IMFDeviceTransform.GetStreamCount" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetStreamCount([NativeTypeName("DWORD *")] uint* pcInputStreams, [NativeTypeName("DWORD *")] uint* pcOutputStreams)
    {
        return ((delegate* unmanaged[MemberFunction]<IMFDeviceTransform2*, uint*, uint*, int>)(lpVtbl[10]))((IMFDeviceTransform2*)Unsafe.AsPointer(ref this), pcInputStreams, pcOutputStreams);
    }

    /// <inheritdoc cref="IMFDeviceTransform.GetStreamIDs" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetStreamIDs([NativeTypeName("DWORD")] uint dwInputIDArraySize, [NativeTypeName("DWORD *")] uint* pdwInputStreamIds, [NativeTypeName("DWORD")] uint dwOutputIDArraySize, [NativeTypeName("DWORD *")] uint* pdwOutputStreamIds)
    {
        return ((delegate* unmanaged[MemberFunction]<IMFDeviceTransform2*, uint, uint*, uint, uint*, int>)(lpVtbl[11]))((IMFDeviceTransform2*)Unsafe.AsPointer(ref this), dwInputIDArraySize, pdwInputStreamIds, dwOutputIDArraySize, pdwOutputStreamIds);
    }

    /// <inheritdoc cref="IMFDeviceTransform.ProcessEvent" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT ProcessEvent([NativeTypeName("DWORD")] uint dwInputStreamID, IMFMediaEvent* pEvent)
    {
        return ((delegate* unmanaged[MemberFunction]<IMFDeviceTransform2*, uint, IMFMediaEvent*, int>)(lpVtbl[12]))((IMFDeviceTransform2*)Unsafe.AsPointer(ref this), dwInputStreamID, pEvent);
    }

    /// <inheritdoc cref="IMFDeviceTransform.ProcessInput" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT ProcessInput([NativeTypeName("DWORD")] uint dwInputStreamID, IMFSample* pSample, [NativeTypeName("DWORD")] uint dwFlags)
    {
        return ((delegate* unmanaged[MemberFunction]<IMFDeviceTransform2*, uint, IMFSample*, uint, int>)(lpVtbl[13]))((IMFDeviceTransform2*)Unsafe.AsPointer(ref this), dwInputStreamID, pSample, dwFlags);
    }

    /// <inheritdoc cref="IMFDeviceTransform.ProcessMessage" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT ProcessMessage(MFT_MESSAGE_TYPE eMessage, [NativeTypeName("ULONG_PTR")] nuint ulParam)
    {
        return ((delegate* unmanaged[MemberFunction]<IMFDeviceTransform2*, MFT_MESSAGE_TYPE, nuint, int>)(lpVtbl[14]))((IMFDeviceTransform2*)Unsafe.AsPointer(ref this), eMessage, ulParam);
    }

    /// <inheritdoc cref="IMFDeviceTransform.ProcessOutput" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT ProcessOutput([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD")] uint cOutputBufferCount, MFT_OUTPUT_DATA_BUFFER* pOutputSample, [NativeTypeName("DWORD *")] uint* pdwStatus)
    {
        return ((delegate* unmanaged[MemberFunction]<IMFDeviceTransform2*, uint, uint, MFT_OUTPUT_DATA_BUFFER*, uint*, int>)(lpVtbl[15]))((IMFDeviceTransform2*)Unsafe.AsPointer(ref this), dwFlags, cOutputBufferCount, pOutputSample, pdwStatus);
    }

    /// <inheritdoc cref="IMFDeviceTransform.SetInputStreamState" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT SetInputStreamState([NativeTypeName("DWORD")] uint dwStreamID, IMFMediaType* pMediaType, DeviceStreamState value, [NativeTypeName("DWORD")] uint dwFlags)
    {
        return ((delegate* unmanaged[MemberFunction]<IMFDeviceTransform2*, uint, IMFMediaType*, DeviceStreamState, uint, int>)(lpVtbl[16]))((IMFDeviceTransform2*)Unsafe.AsPointer(ref this), dwStreamID, pMediaType, value, dwFlags);
    }

    /// <inheritdoc cref="IMFDeviceTransform.GetInputStreamState" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT GetInputStreamState([NativeTypeName("DWORD")] uint dwStreamID, DeviceStreamState* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMFDeviceTransform2*, uint, DeviceStreamState*, int>)(lpVtbl[17]))((IMFDeviceTransform2*)Unsafe.AsPointer(ref this), dwStreamID, value);
    }

    /// <inheritdoc cref="IMFDeviceTransform.SetOutputStreamState" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT SetOutputStreamState([NativeTypeName("DWORD")] uint dwStreamID, IMFMediaType* pMediaType, DeviceStreamState value, [NativeTypeName("DWORD")] uint dwFlags)
    {
        return ((delegate* unmanaged[MemberFunction]<IMFDeviceTransform2*, uint, IMFMediaType*, DeviceStreamState, uint, int>)(lpVtbl[18]))((IMFDeviceTransform2*)Unsafe.AsPointer(ref this), dwStreamID, pMediaType, value, dwFlags);
    }

    /// <inheritdoc cref="IMFDeviceTransform.GetOutputStreamState" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT GetOutputStreamState([NativeTypeName("DWORD")] uint dwStreamID, DeviceStreamState* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMFDeviceTransform2*, uint, DeviceStreamState*, int>)(lpVtbl[19]))((IMFDeviceTransform2*)Unsafe.AsPointer(ref this), dwStreamID, value);
    }

    /// <inheritdoc cref="IMFDeviceTransform.GetInputStreamPreferredState" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT GetInputStreamPreferredState([NativeTypeName("DWORD")] uint dwStreamID, DeviceStreamState* value, IMFMediaType** ppMediaType)
    {
        return ((delegate* unmanaged[MemberFunction]<IMFDeviceTransform2*, uint, DeviceStreamState*, IMFMediaType**, int>)(lpVtbl[20]))((IMFDeviceTransform2*)Unsafe.AsPointer(ref this), dwStreamID, value, ppMediaType);
    }

    /// <inheritdoc cref="IMFDeviceTransform.FlushInputStream" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT FlushInputStream([NativeTypeName("DWORD")] uint dwStreamIndex, [NativeTypeName("DWORD")] uint dwFlags)
    {
        return ((delegate* unmanaged[MemberFunction]<IMFDeviceTransform2*, uint, uint, int>)(lpVtbl[21]))((IMFDeviceTransform2*)Unsafe.AsPointer(ref this), dwStreamIndex, dwFlags);
    }

    /// <inheritdoc cref="IMFDeviceTransform.FlushOutputStream" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT FlushOutputStream([NativeTypeName("DWORD")] uint dwStreamIndex, [NativeTypeName("DWORD")] uint dwFlags)
    {
        return ((delegate* unmanaged[MemberFunction]<IMFDeviceTransform2*, uint, uint, int>)(lpVtbl[22]))((IMFDeviceTransform2*)Unsafe.AsPointer(ref this), dwStreamIndex, dwFlags);
    }

    /// <include file='IMFDeviceTransform2.xml' path='doc/member[@name="IMFDeviceTransform2.GetTransformAttributes"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT GetTransformAttributes(IMFAttributes** ppAttributes)
    {
        return ((delegate* unmanaged[MemberFunction]<IMFDeviceTransform2*, IMFAttributes**, int>)(lpVtbl[23]))((IMFDeviceTransform2*)Unsafe.AsPointer(ref this), ppAttributes);
    }

    public interface Interface : IMFDeviceTransform.Interface
    {
        [VtblIndex(23)]
        HRESULT GetTransformAttributes(IMFAttributes** ppAttributes);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

        [NativeTypeName("HRESULT (IMFAttributes *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMFAttributes*, int> InitializeTransform;

        [NativeTypeName("HRESULT (DWORD, DWORD, IMFMediaType **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, IMFMediaType**, int> GetInputAvailableType;

        [NativeTypeName("HRESULT (DWORD, IMFMediaType **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, IMFMediaType**, int> GetInputCurrentType;

        [NativeTypeName("HRESULT (DWORD, IMFAttributes **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, IMFAttributes**, int> GetInputStreamAttributes;

        [NativeTypeName("HRESULT (DWORD, DWORD, IMFMediaType **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, IMFMediaType**, int> GetOutputAvailableType;

        [NativeTypeName("HRESULT (DWORD, IMFMediaType **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, IMFMediaType**, int> GetOutputCurrentType;

        [NativeTypeName("HRESULT (DWORD, IMFAttributes **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, IMFAttributes**, int> GetOutputStreamAttributes;

        [NativeTypeName("HRESULT (DWORD *, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, uint*, int> GetStreamCount;

        [NativeTypeName("HRESULT (DWORD, DWORD *, DWORD, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint*, uint, uint*, int> GetStreamIDs;

        [NativeTypeName("HRESULT (DWORD, IMFMediaEvent *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, IMFMediaEvent*, int> ProcessEvent;

        [NativeTypeName("HRESULT (DWORD, IMFSample *, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, IMFSample*, uint, int> ProcessInput;

        [NativeTypeName("HRESULT (MFT_MESSAGE_TYPE, ULONG_PTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, MFT_MESSAGE_TYPE, nuint, int> ProcessMessage;

        [NativeTypeName("HRESULT (DWORD, DWORD, MFT_OUTPUT_DATA_BUFFER *, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, MFT_OUTPUT_DATA_BUFFER*, uint*, int> ProcessOutput;

        [NativeTypeName("HRESULT (DWORD, IMFMediaType *, DeviceStreamState, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, IMFMediaType*, DeviceStreamState, uint, int> SetInputStreamState;

        [NativeTypeName("HRESULT (DWORD, DeviceStreamState *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, DeviceStreamState*, int> GetInputStreamState;

        [NativeTypeName("HRESULT (DWORD, IMFMediaType *, DeviceStreamState, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, IMFMediaType*, DeviceStreamState, uint, int> SetOutputStreamState;

        [NativeTypeName("HRESULT (DWORD, DeviceStreamState *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, DeviceStreamState*, int> GetOutputStreamState;

        [NativeTypeName("HRESULT (DWORD, DeviceStreamState *, IMFMediaType **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, DeviceStreamState*, IMFMediaType**, int> GetInputStreamPreferredState;

        [NativeTypeName("HRESULT (DWORD, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, int> FlushInputStream;

        [NativeTypeName("HRESULT (DWORD, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, int> FlushOutputStream;

        [NativeTypeName("HRESULT (IMFAttributes **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMFAttributes**, int> GetTransformAttributes;
    }
}
