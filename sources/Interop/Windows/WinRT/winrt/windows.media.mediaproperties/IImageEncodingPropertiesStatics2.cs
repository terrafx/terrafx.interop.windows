// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.mediaproperties.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IImageEncodingPropertiesStatics2.xml' path='doc/member[@name="IImageEncodingPropertiesStatics2"]/*' />
[Guid("F6C25B29-3824-46B0-956E-501329E1BE3C")]
[NativeTypeName("struct IImageEncodingPropertiesStatics2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IImageEncodingPropertiesStatics2 : IImageEncodingPropertiesStatics2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IImageEncodingPropertiesStatics2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IImageEncodingPropertiesStatics2*, Guid*, void**, int>)(lpVtbl[0]))((IImageEncodingPropertiesStatics2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IImageEncodingPropertiesStatics2*, uint>)(lpVtbl[1]))((IImageEncodingPropertiesStatics2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IImageEncodingPropertiesStatics2*, uint>)(lpVtbl[2]))((IImageEncodingPropertiesStatics2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IImageEncodingPropertiesStatics2*, uint*, Guid**, int>)(lpVtbl[3]))((IImageEncodingPropertiesStatics2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IImageEncodingPropertiesStatics2*, HSTRING*, int>)(lpVtbl[4]))((IImageEncodingPropertiesStatics2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IImageEncodingPropertiesStatics2*, TrustLevel*, int>)(lpVtbl[5]))((IImageEncodingPropertiesStatics2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IImageEncodingPropertiesStatics2.xml' path='doc/member[@name="IImageEncodingPropertiesStatics2.CreateUncompressed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateUncompressed([NativeTypeName("ABI::Windows::Media::MediaProperties::MediaPixelFormat")] MediaPixelFormat format, [NativeTypeName("ABI::Windows::Media::MediaProperties::IImageEncodingProperties **")] IImageEncodingProperties** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IImageEncodingPropertiesStatics2*, MediaPixelFormat, IImageEncodingProperties**, int>)(lpVtbl[6]))((IImageEncodingPropertiesStatics2*)Unsafe.AsPointer(ref this), format, value);
    }

    /// <include file='IImageEncodingPropertiesStatics2.xml' path='doc/member[@name="IImageEncodingPropertiesStatics2.CreateBmp"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateBmp([NativeTypeName("ABI::Windows::Media::MediaProperties::IImageEncodingProperties **")] IImageEncodingProperties** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IImageEncodingPropertiesStatics2*, IImageEncodingProperties**, int>)(lpVtbl[7]))((IImageEncodingPropertiesStatics2*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateUncompressed([NativeTypeName("ABI::Windows::Media::MediaProperties::MediaPixelFormat")] MediaPixelFormat format, [NativeTypeName("ABI::Windows::Media::MediaProperties::IImageEncodingProperties **")] IImageEncodingProperties** value);

        [VtblIndex(7)]
        HRESULT CreateBmp([NativeTypeName("ABI::Windows::Media::MediaProperties::IImageEncodingProperties **")] IImageEncodingProperties** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Media::MediaProperties::MediaPixelFormat, ABI::Windows::Media::MediaProperties::IImageEncodingProperties **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, MediaPixelFormat, IImageEncodingProperties**, int> CreateUncompressed;

        [NativeTypeName("HRESULT (ABI::Windows::Media::MediaProperties::IImageEncodingProperties **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IImageEncodingProperties**, int> CreateBmp;
    }
}
