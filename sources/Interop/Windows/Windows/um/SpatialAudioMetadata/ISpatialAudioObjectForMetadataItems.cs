// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SpatialAudioMetadata.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;

[SupportedOSPlatform("windows10.0.15063.0")]
[Guid("DDEA49FF-3BC0-4377-8AAD-9FBCFD808566")]
[NativeTypeName("struct ISpatialAudioObjectForMetadataItems : ISpatialAudioObjectBase")]
[NativeInheritance("ISpatialAudioObjectBase")]
public unsafe partial struct ISpatialAudioObjectForMetadataItems : ISpatialAudioObjectForMetadataItems.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISpatialAudioObjectForMetadataItems*, Guid*, void**, int>)(lpVtbl[0]))((ISpatialAudioObjectForMetadataItems*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISpatialAudioObjectForMetadataItems*, uint>)(lpVtbl[1]))((ISpatialAudioObjectForMetadataItems*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISpatialAudioObjectForMetadataItems*, uint>)(lpVtbl[2]))((ISpatialAudioObjectForMetadataItems*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetBuffer(byte** buffer, [NativeTypeName("UINT32 *")] uint* bufferLength)
    {
        return ((delegate* unmanaged<ISpatialAudioObjectForMetadataItems*, byte**, uint*, int>)(lpVtbl[3]))((ISpatialAudioObjectForMetadataItems*)Unsafe.AsPointer(ref this), buffer, bufferLength);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetEndOfStream([NativeTypeName("UINT32")] uint frameCount)
    {
        return ((delegate* unmanaged<ISpatialAudioObjectForMetadataItems*, uint, int>)(lpVtbl[4]))((ISpatialAudioObjectForMetadataItems*)Unsafe.AsPointer(ref this), frameCount);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT IsActive(BOOL* isActive)
    {
        return ((delegate* unmanaged<ISpatialAudioObjectForMetadataItems*, BOOL*, int>)(lpVtbl[5]))((ISpatialAudioObjectForMetadataItems*)Unsafe.AsPointer(ref this), isActive);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetAudioObjectType(AudioObjectType* audioObjectType)
    {
        return ((delegate* unmanaged<ISpatialAudioObjectForMetadataItems*, AudioObjectType*, int>)(lpVtbl[6]))((ISpatialAudioObjectForMetadataItems*)Unsafe.AsPointer(ref this), audioObjectType);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetSpatialAudioMetadataItems(ISpatialAudioMetadataItems** metadataItems)
    {
        return ((delegate* unmanaged<ISpatialAudioObjectForMetadataItems*, ISpatialAudioMetadataItems**, int>)(lpVtbl[7]))((ISpatialAudioObjectForMetadataItems*)Unsafe.AsPointer(ref this), metadataItems);
    }

    public interface Interface : ISpatialAudioObjectBase.Interface
    {
        [VtblIndex(7)]
        HRESULT GetSpatialAudioMetadataItems(ISpatialAudioMetadataItems** metadataItems);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<ISpatialAudioObjectForMetadataItems*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<ISpatialAudioObjectForMetadataItems*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<ISpatialAudioObjectForMetadataItems*, uint> Release;

        [NativeTypeName("HRESULT (BYTE **, UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<ISpatialAudioObjectForMetadataItems*, byte**, uint*, int> GetBuffer;

        [NativeTypeName("HRESULT (UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged<ISpatialAudioObjectForMetadataItems*, uint, int> SetEndOfStream;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<ISpatialAudioObjectForMetadataItems*, BOOL*, int> IsActive;

        [NativeTypeName("HRESULT (AudioObjectType *) __attribute__((stdcall))")]
        public delegate* unmanaged<ISpatialAudioObjectForMetadataItems*, AudioObjectType*, int> GetAudioObjectType;

        [NativeTypeName("HRESULT (ISpatialAudioMetadataItems **) __attribute__((stdcall))")]
        public delegate* unmanaged<ISpatialAudioObjectForMetadataItems*, ISpatialAudioMetadataItems**, int> GetSpatialAudioMetadataItems;
    }
}
