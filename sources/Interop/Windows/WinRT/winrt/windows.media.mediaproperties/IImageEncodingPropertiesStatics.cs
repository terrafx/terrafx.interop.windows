// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.mediaproperties.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IImageEncodingPropertiesStatics.xml' path='doc/member[@name="IImageEncodingPropertiesStatics"]/*' />
[Guid("257C68DC-8B99-439E-AA59-913A36161297")]
[NativeTypeName("struct IImageEncodingPropertiesStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IImageEncodingPropertiesStatics : IImageEncodingPropertiesStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IImageEncodingPropertiesStatics);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IImageEncodingPropertiesStatics*, Guid*, void**, int>)(lpVtbl[0]))((IImageEncodingPropertiesStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IImageEncodingPropertiesStatics*, uint>)(lpVtbl[1]))((IImageEncodingPropertiesStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IImageEncodingPropertiesStatics*, uint>)(lpVtbl[2]))((IImageEncodingPropertiesStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IImageEncodingPropertiesStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IImageEncodingPropertiesStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IImageEncodingPropertiesStatics*, HSTRING*, int>)(lpVtbl[4]))((IImageEncodingPropertiesStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IImageEncodingPropertiesStatics*, TrustLevel*, int>)(lpVtbl[5]))((IImageEncodingPropertiesStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IImageEncodingPropertiesStatics.xml' path='doc/member[@name="IImageEncodingPropertiesStatics.CreateJpeg"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateJpeg([NativeTypeName("ABI::Windows::Media::MediaProperties::IImageEncodingProperties **")] IImageEncodingProperties** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IImageEncodingPropertiesStatics*, IImageEncodingProperties**, int>)(lpVtbl[6]))((IImageEncodingPropertiesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IImageEncodingPropertiesStatics.xml' path='doc/member[@name="IImageEncodingPropertiesStatics.CreatePng"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreatePng([NativeTypeName("ABI::Windows::Media::MediaProperties::IImageEncodingProperties **")] IImageEncodingProperties** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IImageEncodingPropertiesStatics*, IImageEncodingProperties**, int>)(lpVtbl[7]))((IImageEncodingPropertiesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IImageEncodingPropertiesStatics.xml' path='doc/member[@name="IImageEncodingPropertiesStatics.CreateJpegXR"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CreateJpegXR([NativeTypeName("ABI::Windows::Media::MediaProperties::IImageEncodingProperties **")] IImageEncodingProperties** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IImageEncodingPropertiesStatics*, IImageEncodingProperties**, int>)(lpVtbl[8]))((IImageEncodingPropertiesStatics*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateJpeg([NativeTypeName("ABI::Windows::Media::MediaProperties::IImageEncodingProperties **")] IImageEncodingProperties** value);

        [VtblIndex(7)]
        HRESULT CreatePng([NativeTypeName("ABI::Windows::Media::MediaProperties::IImageEncodingProperties **")] IImageEncodingProperties** value);

        [VtblIndex(8)]
        HRESULT CreateJpegXR([NativeTypeName("ABI::Windows::Media::MediaProperties::IImageEncodingProperties **")] IImageEncodingProperties** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Media::MediaProperties::IImageEncodingProperties **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IImageEncodingProperties**, int> CreateJpeg;

        [NativeTypeName("HRESULT (ABI::Windows::Media::MediaProperties::IImageEncodingProperties **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IImageEncodingProperties**, int> CreatePng;

        [NativeTypeName("HRESULT (ABI::Windows::Media::MediaProperties::IImageEncodingProperties **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IImageEncodingProperties**, int> CreateJpegXR;
    }
}
