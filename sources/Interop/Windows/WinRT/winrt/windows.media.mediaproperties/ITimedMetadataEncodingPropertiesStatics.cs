// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.mediaproperties.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ITimedMetadataEncodingPropertiesStatics.xml' path='doc/member[@name="ITimedMetadataEncodingPropertiesStatics"]/*' />
[Guid("6629BB67-6E55-5643-89A0-7A7E8D85B52C")]
[NativeTypeName("struct ITimedMetadataEncodingPropertiesStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ITimedMetadataEncodingPropertiesStatics : ITimedMetadataEncodingPropertiesStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITimedMetadataEncodingPropertiesStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedMetadataEncodingPropertiesStatics*, Guid*, void**, int>)(lpVtbl[0]))((ITimedMetadataEncodingPropertiesStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedMetadataEncodingPropertiesStatics*, uint>)(lpVtbl[1]))((ITimedMetadataEncodingPropertiesStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedMetadataEncodingPropertiesStatics*, uint>)(lpVtbl[2]))((ITimedMetadataEncodingPropertiesStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedMetadataEncodingPropertiesStatics*, uint*, Guid**, int>)(lpVtbl[3]))((ITimedMetadataEncodingPropertiesStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedMetadataEncodingPropertiesStatics*, HSTRING*, int>)(lpVtbl[4]))((ITimedMetadataEncodingPropertiesStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedMetadataEncodingPropertiesStatics*, TrustLevel*, int>)(lpVtbl[5]))((ITimedMetadataEncodingPropertiesStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ITimedMetadataEncodingPropertiesStatics.xml' path='doc/member[@name="ITimedMetadataEncodingPropertiesStatics.CreatePgs"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreatePgs([NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaEncodingProperties **")] IMediaEncodingProperties** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedMetadataEncodingPropertiesStatics*, IMediaEncodingProperties**, int>)(lpVtbl[6]))((ITimedMetadataEncodingPropertiesStatics*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='ITimedMetadataEncodingPropertiesStatics.xml' path='doc/member[@name="ITimedMetadataEncodingPropertiesStatics.CreateSrt"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateSrt([NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaEncodingProperties **")] IMediaEncodingProperties** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedMetadataEncodingPropertiesStatics*, IMediaEncodingProperties**, int>)(lpVtbl[7]))((ITimedMetadataEncodingPropertiesStatics*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='ITimedMetadataEncodingPropertiesStatics.xml' path='doc/member[@name="ITimedMetadataEncodingPropertiesStatics.CreateSsa"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CreateSsa([NativeTypeName("UINT32")] uint formatUserDataLength, byte* formatUserData, [NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaEncodingProperties **")] IMediaEncodingProperties** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedMetadataEncodingPropertiesStatics*, uint, byte*, IMediaEncodingProperties**, int>)(lpVtbl[8]))((ITimedMetadataEncodingPropertiesStatics*)Unsafe.AsPointer(ref this), formatUserDataLength, formatUserData, result);
    }

    /// <include file='ITimedMetadataEncodingPropertiesStatics.xml' path='doc/member[@name="ITimedMetadataEncodingPropertiesStatics.CreateVobSub"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT CreateVobSub([NativeTypeName("UINT32")] uint formatUserDataLength, byte* formatUserData, [NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaEncodingProperties **")] IMediaEncodingProperties** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedMetadataEncodingPropertiesStatics*, uint, byte*, IMediaEncodingProperties**, int>)(lpVtbl[9]))((ITimedMetadataEncodingPropertiesStatics*)Unsafe.AsPointer(ref this), formatUserDataLength, formatUserData, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreatePgs([NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaEncodingProperties **")] IMediaEncodingProperties** result);

        [VtblIndex(7)]
        HRESULT CreateSrt([NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaEncodingProperties **")] IMediaEncodingProperties** result);

        [VtblIndex(8)]
        HRESULT CreateSsa([NativeTypeName("UINT32")] uint formatUserDataLength, byte* formatUserData, [NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaEncodingProperties **")] IMediaEncodingProperties** result);

        [VtblIndex(9)]
        HRESULT CreateVobSub([NativeTypeName("UINT32")] uint formatUserDataLength, byte* formatUserData, [NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaEncodingProperties **")] IMediaEncodingProperties** result);
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

        [NativeTypeName("HRESULT (ULONG *, IID **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, Guid**, int> GetIids;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> GetRuntimeClassName;

        [NativeTypeName("HRESULT (TrustLevel *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TrustLevel*, int> GetTrustLevel;

        [NativeTypeName("HRESULT (ABI::Windows::Media::MediaProperties::IMediaEncodingProperties **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaEncodingProperties**, int> CreatePgs;

        [NativeTypeName("HRESULT (ABI::Windows::Media::MediaProperties::IMediaEncodingProperties **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaEncodingProperties**, int> CreateSrt;

        [NativeTypeName("HRESULT (UINT32, BYTE *, ABI::Windows::Media::MediaProperties::IMediaEncodingProperties **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, byte*, IMediaEncodingProperties**, int> CreateSsa;

        [NativeTypeName("HRESULT (UINT32, BYTE *, ABI::Windows::Media::MediaProperties::IMediaEncodingProperties **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, byte*, IMediaEncodingProperties**, int> CreateVobSub;
    }
}
