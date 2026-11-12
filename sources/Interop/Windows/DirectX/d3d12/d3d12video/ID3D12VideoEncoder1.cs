// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.620.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;

/// <include file='ID3D12VideoEncoder1.xml' path='doc/member[@name="ID3D12VideoEncoder1"]/*' />
[Guid("B84DE40C-5B43-4B5F-9A75-DA29F1B3C833")]
[NativeTypeName("struct ID3D12VideoEncoder1 : ID3D12VideoEncoder")]
[NativeInheritance("ID3D12VideoEncoder")]
public unsafe partial struct ID3D12VideoEncoder1 : ID3D12VideoEncoder1.Interface, INativeGuid
{
    /// <include file='ID3D12VideoEncoder1.xml' path='doc/member[@name="ID3D12VideoEncoder1.INativeGuid.NativeGuid"]/*' />
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ID3D12VideoEncoder1);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12VideoEncoder1*, Guid*, void**, int>)(lpVtbl[0]))((ID3D12VideoEncoder1*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12VideoEncoder1*, uint>)(lpVtbl[1]))((ID3D12VideoEncoder1*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12VideoEncoder1*, uint>)(lpVtbl[2]))((ID3D12VideoEncoder1*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="ID3D12Object.GetPrivateData" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, uint* pDataSize, void* pData)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12VideoEncoder1*, Guid*, uint*, void*, int>)(lpVtbl[3]))((ID3D12VideoEncoder1*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
    }

    /// <inheritdoc cref="ID3D12Object.SetPrivateData" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, uint DataSize, [NativeTypeName("const void *")] void* pData)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12VideoEncoder1*, Guid*, uint, void*, int>)(lpVtbl[4]))((ID3D12VideoEncoder1*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
    }

    /// <inheritdoc cref="ID3D12Object.SetPrivateDataInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("const IUnknown *")] IUnknown* pData)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12VideoEncoder1*, Guid*, IUnknown*, int>)(lpVtbl[5]))((ID3D12VideoEncoder1*)Unsafe.AsPointer(ref this), guid, pData);
    }

    /// <inheritdoc cref="ID3D12Object.SetName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetName([NativeTypeName("LPCWSTR")] char* Name)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12VideoEncoder1*, char*, int>)(lpVtbl[6]))((ID3D12VideoEncoder1*)Unsafe.AsPointer(ref this), Name);
    }

    /// <inheritdoc cref="ID3D12DeviceChild.GetDevice" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetDevice([NativeTypeName("const IID &")] Guid* riid, void** ppvDevice)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12VideoEncoder1*, Guid*, void**, int>)(lpVtbl[7]))((ID3D12VideoEncoder1*)Unsafe.AsPointer(ref this), riid, ppvDevice);
    }

    /// <inheritdoc cref="ID3D12VideoEncoder.GetNodeMask" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public uint GetNodeMask()
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12VideoEncoder1*, uint>)(lpVtbl[8]))((ID3D12VideoEncoder1*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="ID3D12VideoEncoder.GetEncoderFlags" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public D3D12_VIDEO_ENCODER_FLAGS GetEncoderFlags()
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12VideoEncoder1*, D3D12_VIDEO_ENCODER_FLAGS>)(lpVtbl[9]))((ID3D12VideoEncoder1*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="ID3D12VideoEncoder.GetCodec" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public D3D12_VIDEO_ENCODER_CODEC GetCodec()
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12VideoEncoder1*, D3D12_VIDEO_ENCODER_CODEC>)(lpVtbl[10]))((ID3D12VideoEncoder1*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="ID3D12VideoEncoder.GetCodecProfile" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetCodecProfile(D3D12_VIDEO_ENCODER_PROFILE_DESC dstProfile)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12VideoEncoder1*, D3D12_VIDEO_ENCODER_PROFILE_DESC, int>)(lpVtbl[11]))((ID3D12VideoEncoder1*)Unsafe.AsPointer(ref this), dstProfile);
    }

    /// <inheritdoc cref="ID3D12VideoEncoder.GetCodecConfiguration" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetCodecConfiguration(D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION dstCodecConfig)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12VideoEncoder1*, D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION, int>)(lpVtbl[12]))((ID3D12VideoEncoder1*)Unsafe.AsPointer(ref this), dstCodecConfig);
    }

    /// <inheritdoc cref="ID3D12VideoEncoder.GetInputFormat" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public DXGI_FORMAT GetInputFormat()
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12VideoEncoder1*, DXGI_FORMAT>)(lpVtbl[13]))((ID3D12VideoEncoder1*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="ID3D12VideoEncoder.GetMaxMotionEstimationPrecision" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public D3D12_VIDEO_ENCODER_MOTION_ESTIMATION_PRECISION_MODE GetMaxMotionEstimationPrecision()
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12VideoEncoder1*, D3D12_VIDEO_ENCODER_MOTION_ESTIMATION_PRECISION_MODE>)(lpVtbl[14]))((ID3D12VideoEncoder1*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID3D12VideoEncoder1.xml' path='doc/member[@name="ID3D12VideoEncoder1.ResolveEncoderOutputMetadataCPU"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT ResolveEncoderOutputMetadataCPU([NativeTypeName("const D3D12_VIDEO_ENCODER_RESOLVE_METADATA_CPU_INPUT_ARGUMENTS *")] D3D12_VIDEO_ENCODER_RESOLVE_METADATA_CPU_INPUT_ARGUMENTS* pInputArguments, [NativeTypeName("const D3D12_VIDEO_ENCODER_RESOLVE_METADATA_CPU_OUTPUT_ARGUMENTS *")] D3D12_VIDEO_ENCODER_RESOLVE_METADATA_CPU_OUTPUT_ARGUMENTS* pOutputArguments)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12VideoEncoder1*, D3D12_VIDEO_ENCODER_RESOLVE_METADATA_CPU_INPUT_ARGUMENTS*, D3D12_VIDEO_ENCODER_RESOLVE_METADATA_CPU_OUTPUT_ARGUMENTS*, int>)(lpVtbl[15]))((ID3D12VideoEncoder1*)Unsafe.AsPointer(ref this), pInputArguments, pOutputArguments);
    }

    public interface Interface : ID3D12VideoEncoder.Interface
    {
        [VtblIndex(15)]
        HRESULT ResolveEncoderOutputMetadataCPU([NativeTypeName("const D3D12_VIDEO_ENCODER_RESOLVE_METADATA_CPU_INPUT_ARGUMENTS *")] D3D12_VIDEO_ENCODER_RESOLVE_METADATA_CPU_INPUT_ARGUMENTS* pInputArguments, [NativeTypeName("const D3D12_VIDEO_ENCODER_RESOLVE_METADATA_CPU_OUTPUT_ARGUMENTS *")] D3D12_VIDEO_ENCODER_RESOLVE_METADATA_CPU_OUTPUT_ARGUMENTS* pOutputArguments);
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

        [NativeTypeName("HRESULT (const GUID &, UINT *, void *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, uint*, void*, int> GetPrivateData;

        [NativeTypeName("HRESULT (const GUID &, UINT, const void *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, uint, void*, int> SetPrivateData;

        [NativeTypeName("HRESULT (const GUID &, const IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, IUnknown*, int> SetPrivateDataInterface;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> SetName;

        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> GetDevice;

        [NativeTypeName("UINT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> GetNodeMask;

        [NativeTypeName("D3D12_VIDEO_ENCODER_FLAGS () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, D3D12_VIDEO_ENCODER_FLAGS> GetEncoderFlags;

        [NativeTypeName("D3D12_VIDEO_ENCODER_CODEC () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, D3D12_VIDEO_ENCODER_CODEC> GetCodec;

        [NativeTypeName("HRESULT (D3D12_VIDEO_ENCODER_PROFILE_DESC) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, D3D12_VIDEO_ENCODER_PROFILE_DESC, int> GetCodecProfile;

        [NativeTypeName("HRESULT (D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION, int> GetCodecConfiguration;

        [NativeTypeName("DXGI_FORMAT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, DXGI_FORMAT> GetInputFormat;

        [NativeTypeName("D3D12_VIDEO_ENCODER_MOTION_ESTIMATION_PRECISION_MODE () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, D3D12_VIDEO_ENCODER_MOTION_ESTIMATION_PRECISION_MODE> GetMaxMotionEstimationPrecision;

        [NativeTypeName("HRESULT (const D3D12_VIDEO_ENCODER_RESOLVE_METADATA_CPU_INPUT_ARGUMENTS *, const D3D12_VIDEO_ENCODER_RESOLVE_METADATA_CPU_OUTPUT_ARGUMENTS *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, D3D12_VIDEO_ENCODER_RESOLVE_METADATA_CPU_INPUT_ARGUMENTS*, D3D12_VIDEO_ENCODER_RESOLVE_METADATA_CPU_OUTPUT_ARGUMENTS*, int> ResolveEncoderOutputMetadataCPU;
    }
}
