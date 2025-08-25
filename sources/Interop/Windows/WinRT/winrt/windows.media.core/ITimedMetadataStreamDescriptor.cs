// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ITimedMetadataStreamDescriptor.xml' path='doc/member[@name="ITimedMetadataStreamDescriptor"]/*' />
[Guid("133336BF-296A-463E-9FF9-01CD25691408")]
[NativeTypeName("struct ITimedMetadataStreamDescriptor : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ITimedMetadataStreamDescriptor : ITimedMetadataStreamDescriptor.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ITimedMetadataStreamDescriptor);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedMetadataStreamDescriptor*, Guid*, void**, int>)(lpVtbl[0]))((ITimedMetadataStreamDescriptor*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedMetadataStreamDescriptor*, uint>)(lpVtbl[1]))((ITimedMetadataStreamDescriptor*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedMetadataStreamDescriptor*, uint>)(lpVtbl[2]))((ITimedMetadataStreamDescriptor*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedMetadataStreamDescriptor*, uint*, Guid**, int>)(lpVtbl[3]))((ITimedMetadataStreamDescriptor*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedMetadataStreamDescriptor*, HSTRING*, int>)(lpVtbl[4]))((ITimedMetadataStreamDescriptor*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedMetadataStreamDescriptor*, TrustLevel*, int>)(lpVtbl[5]))((ITimedMetadataStreamDescriptor*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ITimedMetadataStreamDescriptor.xml' path='doc/member[@name="ITimedMetadataStreamDescriptor.get_EncodingProperties"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_EncodingProperties([NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaEncodingProperties **")] IMediaEncodingProperties** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedMetadataStreamDescriptor*, IMediaEncodingProperties**, int>)(lpVtbl[6]))((ITimedMetadataStreamDescriptor*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITimedMetadataStreamDescriptor.xml' path='doc/member[@name="ITimedMetadataStreamDescriptor.Copy"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT Copy([NativeTypeName("ABI::Windows::Media::Core::IMediaStreamDescriptor **")] IMediaStreamDescriptor** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedMetadataStreamDescriptor*, IMediaStreamDescriptor**, int>)(lpVtbl[7]))((ITimedMetadataStreamDescriptor*)Unsafe.AsPointer(ref this), result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_EncodingProperties([NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaEncodingProperties **")] IMediaEncodingProperties** value);

        [VtblIndex(7)]
        HRESULT Copy([NativeTypeName("ABI::Windows::Media::Core::IMediaStreamDescriptor **")] IMediaStreamDescriptor** result);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaEncodingProperties**, int> get_EncodingProperties;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Core::IMediaStreamDescriptor **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaStreamDescriptor**, int> Copy;
    }
}
