// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.618.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;

/// <include file='ID3D12VideoEncoderHeap1.xml' path='doc/member[@name="ID3D12VideoEncoderHeap1"]/*' />
[Guid("EA8F1968-4AA0-43A4-9D30-BA86EC84D4F9")]
[NativeTypeName("struct ID3D12VideoEncoderHeap1 : ID3D12VideoEncoderHeap")]
[NativeInheritance("ID3D12VideoEncoderHeap")]
public unsafe partial struct ID3D12VideoEncoderHeap1 : ID3D12VideoEncoderHeap1.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ID3D12VideoEncoderHeap1);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12VideoEncoderHeap1*, Guid*, void**, int>)(lpVtbl[0]))((ID3D12VideoEncoderHeap1*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12VideoEncoderHeap1*, uint>)(lpVtbl[1]))((ID3D12VideoEncoderHeap1*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12VideoEncoderHeap1*, uint>)(lpVtbl[2]))((ID3D12VideoEncoderHeap1*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="ID3D12Object.GetPrivateData" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, uint* pDataSize, void* pData)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12VideoEncoderHeap1*, Guid*, uint*, void*, int>)(lpVtbl[3]))((ID3D12VideoEncoderHeap1*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
    }

    /// <inheritdoc cref="ID3D12Object.SetPrivateData" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, uint DataSize, [NativeTypeName("const void *")] void* pData)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12VideoEncoderHeap1*, Guid*, uint, void*, int>)(lpVtbl[4]))((ID3D12VideoEncoderHeap1*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
    }

    /// <inheritdoc cref="ID3D12Object.SetPrivateDataInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("const IUnknown *")] IUnknown* pData)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12VideoEncoderHeap1*, Guid*, IUnknown*, int>)(lpVtbl[5]))((ID3D12VideoEncoderHeap1*)Unsafe.AsPointer(ref this), guid, pData);
    }

    /// <inheritdoc cref="ID3D12Object.SetName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetName([NativeTypeName("LPCWSTR")] char* Name)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12VideoEncoderHeap1*, char*, int>)(lpVtbl[6]))((ID3D12VideoEncoderHeap1*)Unsafe.AsPointer(ref this), Name);
    }

    /// <inheritdoc cref="ID3D12DeviceChild.GetDevice" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetDevice([NativeTypeName("const IID &")] Guid* riid, void** ppvDevice)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12VideoEncoderHeap1*, Guid*, void**, int>)(lpVtbl[7]))((ID3D12VideoEncoderHeap1*)Unsafe.AsPointer(ref this), riid, ppvDevice);
    }

    /// <inheritdoc cref="ID3D12VideoEncoderHeap.GetNodeMask" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public uint GetNodeMask()
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12VideoEncoderHeap1*, uint>)(lpVtbl[8]))((ID3D12VideoEncoderHeap1*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="ID3D12VideoEncoderHeap.GetEncoderHeapFlags" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public D3D12_VIDEO_ENCODER_HEAP_FLAGS GetEncoderHeapFlags()
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12VideoEncoderHeap1*, D3D12_VIDEO_ENCODER_HEAP_FLAGS>)(lpVtbl[9]))((ID3D12VideoEncoderHeap1*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="ID3D12VideoEncoderHeap.GetCodec" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public D3D12_VIDEO_ENCODER_CODEC GetCodec()
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12VideoEncoderHeap1*, D3D12_VIDEO_ENCODER_CODEC>)(lpVtbl[10]))((ID3D12VideoEncoderHeap1*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="ID3D12VideoEncoderHeap.GetCodecProfile" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetCodecProfile(D3D12_VIDEO_ENCODER_PROFILE_DESC dstProfile)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12VideoEncoderHeap1*, D3D12_VIDEO_ENCODER_PROFILE_DESC, int>)(lpVtbl[11]))((ID3D12VideoEncoderHeap1*)Unsafe.AsPointer(ref this), dstProfile);
    }

    /// <inheritdoc cref="ID3D12VideoEncoderHeap.GetCodecLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetCodecLevel(D3D12_VIDEO_ENCODER_LEVEL_SETTING dstLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12VideoEncoderHeap1*, D3D12_VIDEO_ENCODER_LEVEL_SETTING, int>)(lpVtbl[12]))((ID3D12VideoEncoderHeap1*)Unsafe.AsPointer(ref this), dstLevel);
    }

    /// <inheritdoc cref="ID3D12VideoEncoderHeap.GetResolutionListCount" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public uint GetResolutionListCount()
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12VideoEncoderHeap1*, uint>)(lpVtbl[13]))((ID3D12VideoEncoderHeap1*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="ID3D12VideoEncoderHeap.GetResolutionList" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetResolutionList([NativeTypeName("const UINT")] uint ResolutionsListCount, D3D12_VIDEO_ENCODER_PICTURE_RESOLUTION_DESC* pResolutionList)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12VideoEncoderHeap1*, uint, D3D12_VIDEO_ENCODER_PICTURE_RESOLUTION_DESC*, int>)(lpVtbl[14]))((ID3D12VideoEncoderHeap1*)Unsafe.AsPointer(ref this), ResolutionsListCount, pResolutionList);
    }

    /// <include file='ID3D12VideoEncoderHeap1.xml' path='doc/member[@name="ID3D12VideoEncoderHeap1.GetPow2DownscaleFactor"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public uint GetPow2DownscaleFactor()
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12VideoEncoderHeap1*, uint>)(lpVtbl[15]))((ID3D12VideoEncoderHeap1*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : ID3D12VideoEncoderHeap.Interface
    {
        [VtblIndex(15)]
        uint GetPow2DownscaleFactor();
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

        [NativeTypeName("D3D12_VIDEO_ENCODER_HEAP_FLAGS () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, D3D12_VIDEO_ENCODER_HEAP_FLAGS> GetEncoderHeapFlags;

        [NativeTypeName("D3D12_VIDEO_ENCODER_CODEC () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, D3D12_VIDEO_ENCODER_CODEC> GetCodec;

        [NativeTypeName("HRESULT (D3D12_VIDEO_ENCODER_PROFILE_DESC) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, D3D12_VIDEO_ENCODER_PROFILE_DESC, int> GetCodecProfile;

        [NativeTypeName("HRESULT (D3D12_VIDEO_ENCODER_LEVEL_SETTING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, D3D12_VIDEO_ENCODER_LEVEL_SETTING, int> GetCodecLevel;

        [NativeTypeName("UINT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> GetResolutionListCount;

        [NativeTypeName("HRESULT (const UINT, D3D12_VIDEO_ENCODER_PICTURE_RESOLUTION_DESC *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, D3D12_VIDEO_ENCODER_PICTURE_RESOLUTION_DESC*, int> GetResolutionList;

        [NativeTypeName("UINT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> GetPow2DownscaleFactor;
    }
}
