// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.mediaproperties.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IVideoEncodingPropertiesStatics3.xml' path='doc/member[@name="IVideoEncodingPropertiesStatics3"]/*' />
[Guid("65B46685-60DA-5E51-91A2-B38C4763B872")]
[NativeTypeName("struct IVideoEncodingPropertiesStatics3 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IVideoEncodingPropertiesStatics3 : IVideoEncodingPropertiesStatics3.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IVideoEncodingPropertiesStatics3));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoEncodingPropertiesStatics3*, Guid*, void**, int>)(lpVtbl[0]))((IVideoEncodingPropertiesStatics3*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoEncodingPropertiesStatics3*, uint>)(lpVtbl[1]))((IVideoEncodingPropertiesStatics3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoEncodingPropertiesStatics3*, uint>)(lpVtbl[2]))((IVideoEncodingPropertiesStatics3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoEncodingPropertiesStatics3*, uint*, Guid**, int>)(lpVtbl[3]))((IVideoEncodingPropertiesStatics3*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoEncodingPropertiesStatics3*, HSTRING*, int>)(lpVtbl[4]))((IVideoEncodingPropertiesStatics3*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoEncodingPropertiesStatics3*, TrustLevel*, int>)(lpVtbl[5]))((IVideoEncodingPropertiesStatics3*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IVideoEncodingPropertiesStatics3.xml' path='doc/member[@name="IVideoEncodingPropertiesStatics3.CreateVp9"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateVp9([NativeTypeName("ABI::Windows::Media::MediaProperties::IVideoEncodingProperties **")] IVideoEncodingProperties** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoEncodingPropertiesStatics3*, IVideoEncodingProperties**, int>)(lpVtbl[6]))((IVideoEncodingPropertiesStatics3*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IVideoEncodingPropertiesStatics3.xml' path='doc/member[@name="IVideoEncodingPropertiesStatics3.CreateAv1"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateAv1([NativeTypeName("ABI::Windows::Media::MediaProperties::IVideoEncodingProperties **")] IVideoEncodingProperties** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoEncodingPropertiesStatics3*, IVideoEncodingProperties**, int>)(lpVtbl[7]))((IVideoEncodingPropertiesStatics3*)Unsafe.AsPointer(ref this), result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateVp9([NativeTypeName("ABI::Windows::Media::MediaProperties::IVideoEncodingProperties **")] IVideoEncodingProperties** result);

        [VtblIndex(7)]
        HRESULT CreateAv1([NativeTypeName("ABI::Windows::Media::MediaProperties::IVideoEncodingProperties **")] IVideoEncodingProperties** result);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, IVideoEncodingProperties**, int> CreateVp9;

        [NativeTypeName("HRESULT (ABI::Windows::Media::MediaProperties::IVideoEncodingProperties **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVideoEncodingProperties**, int> CreateAv1;
    }
}
