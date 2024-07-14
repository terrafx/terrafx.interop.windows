// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.mediaproperties.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IVideoEncodingPropertiesStatics.xml' path='doc/member[@name="IVideoEncodingPropertiesStatics"]/*' />
[Guid("3CE14D44-1DC5-43DB-9F38-EBEBF90152CB")]
[NativeTypeName("struct IVideoEncodingPropertiesStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IVideoEncodingPropertiesStatics : IVideoEncodingPropertiesStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IVideoEncodingPropertiesStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoEncodingPropertiesStatics*, Guid*, void**, int>)(lpVtbl[0]))((IVideoEncodingPropertiesStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoEncodingPropertiesStatics*, uint>)(lpVtbl[1]))((IVideoEncodingPropertiesStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoEncodingPropertiesStatics*, uint>)(lpVtbl[2]))((IVideoEncodingPropertiesStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoEncodingPropertiesStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IVideoEncodingPropertiesStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoEncodingPropertiesStatics*, HSTRING*, int>)(lpVtbl[4]))((IVideoEncodingPropertiesStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoEncodingPropertiesStatics*, TrustLevel*, int>)(lpVtbl[5]))((IVideoEncodingPropertiesStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IVideoEncodingPropertiesStatics.xml' path='doc/member[@name="IVideoEncodingPropertiesStatics.CreateH264"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateH264([NativeTypeName("ABI::Windows::Media::MediaProperties::IVideoEncodingProperties **")] IVideoEncodingProperties** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoEncodingPropertiesStatics*, IVideoEncodingProperties**, int>)(lpVtbl[6]))((IVideoEncodingPropertiesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IVideoEncodingPropertiesStatics.xml' path='doc/member[@name="IVideoEncodingPropertiesStatics.CreateMpeg2"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateMpeg2([NativeTypeName("ABI::Windows::Media::MediaProperties::IVideoEncodingProperties **")] IVideoEncodingProperties** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoEncodingPropertiesStatics*, IVideoEncodingProperties**, int>)(lpVtbl[7]))((IVideoEncodingPropertiesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IVideoEncodingPropertiesStatics.xml' path='doc/member[@name="IVideoEncodingPropertiesStatics.CreateUncompressed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CreateUncompressed(HSTRING subtype, [NativeTypeName("UINT32")] uint width, [NativeTypeName("UINT32")] uint height, [NativeTypeName("ABI::Windows::Media::MediaProperties::IVideoEncodingProperties **")] IVideoEncodingProperties** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoEncodingPropertiesStatics*, HSTRING, uint, uint, IVideoEncodingProperties**, int>)(lpVtbl[8]))((IVideoEncodingPropertiesStatics*)Unsafe.AsPointer(ref this), subtype, width, height, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateH264([NativeTypeName("ABI::Windows::Media::MediaProperties::IVideoEncodingProperties **")] IVideoEncodingProperties** value);

        [VtblIndex(7)]
        HRESULT CreateMpeg2([NativeTypeName("ABI::Windows::Media::MediaProperties::IVideoEncodingProperties **")] IVideoEncodingProperties** value);

        [VtblIndex(8)]
        HRESULT CreateUncompressed(HSTRING subtype, [NativeTypeName("UINT32")] uint width, [NativeTypeName("UINT32")] uint height, [NativeTypeName("ABI::Windows::Media::MediaProperties::IVideoEncodingProperties **")] IVideoEncodingProperties** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Media::MediaProperties::IVideoEncodingProperties **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVideoEncodingProperties**, int> CreateH264;

        [NativeTypeName("HRESULT (ABI::Windows::Media::MediaProperties::IVideoEncodingProperties **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVideoEncodingProperties**, int> CreateMpeg2;

        [NativeTypeName("HRESULT (HSTRING, UINT32, UINT32, ABI::Windows::Media::MediaProperties::IVideoEncodingProperties **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, uint, uint, IVideoEncodingProperties**, int> CreateUncompressed;
    }
}
