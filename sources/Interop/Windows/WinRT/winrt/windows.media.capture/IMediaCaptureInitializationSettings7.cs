// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.capture.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IMediaCaptureInitializationSettings7.xml' path='doc/member[@name="IMediaCaptureInitializationSettings7"]/*' />
[Guid("41546967-F58A-5D82-9EF4-ED572FB5E34E")]
[NativeTypeName("struct IMediaCaptureInitializationSettings7 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMediaCaptureInitializationSettings7 : IMediaCaptureInitializationSettings7.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMediaCaptureInitializationSettings7));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureInitializationSettings7*, Guid*, void**, int>)(lpVtbl[0]))((IMediaCaptureInitializationSettings7*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureInitializationSettings7*, uint>)(lpVtbl[1]))((IMediaCaptureInitializationSettings7*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureInitializationSettings7*, uint>)(lpVtbl[2]))((IMediaCaptureInitializationSettings7*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureInitializationSettings7*, uint*, Guid**, int>)(lpVtbl[3]))((IMediaCaptureInitializationSettings7*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureInitializationSettings7*, HSTRING*, int>)(lpVtbl[4]))((IMediaCaptureInitializationSettings7*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureInitializationSettings7*, TrustLevel*, int>)(lpVtbl[5]))((IMediaCaptureInitializationSettings7*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IMediaCaptureInitializationSettings7.xml' path='doc/member[@name="IMediaCaptureInitializationSettings7.get_DeviceUriPasswordCredential"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_DeviceUriPasswordCredential([NativeTypeName("ABI::Windows::Security::Credentials::IPasswordCredential **")] IPasswordCredential** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureInitializationSettings7*, IPasswordCredential**, int>)(lpVtbl[6]))((IMediaCaptureInitializationSettings7*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaCaptureInitializationSettings7.xml' path='doc/member[@name="IMediaCaptureInitializationSettings7.put_DeviceUriPasswordCredential"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_DeviceUriPasswordCredential([NativeTypeName("ABI::Windows::Security::Credentials::IPasswordCredential *")] IPasswordCredential* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureInitializationSettings7*, IPasswordCredential*, int>)(lpVtbl[7]))((IMediaCaptureInitializationSettings7*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaCaptureInitializationSettings7.xml' path='doc/member[@name="IMediaCaptureInitializationSettings7.get_DeviceUri"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_DeviceUri([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass **")] IUriRuntimeClass** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureInitializationSettings7*, IUriRuntimeClass**, int>)(lpVtbl[8]))((IMediaCaptureInitializationSettings7*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaCaptureInitializationSettings7.xml' path='doc/member[@name="IMediaCaptureInitializationSettings7.put_DeviceUri"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_DeviceUri([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureInitializationSettings7*, IUriRuntimeClass*, int>)(lpVtbl[9]))((IMediaCaptureInitializationSettings7*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_DeviceUriPasswordCredential([NativeTypeName("ABI::Windows::Security::Credentials::IPasswordCredential **")] IPasswordCredential** value);

        [VtblIndex(7)]
        HRESULT put_DeviceUriPasswordCredential([NativeTypeName("ABI::Windows::Security::Credentials::IPasswordCredential *")] IPasswordCredential* value);

        [VtblIndex(8)]
        HRESULT get_DeviceUri([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass **")] IUriRuntimeClass** value);

        [VtblIndex(9)]
        HRESULT put_DeviceUri([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Security::Credentials::IPasswordCredential **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IPasswordCredential**, int> get_DeviceUriPasswordCredential;

        [NativeTypeName("HRESULT (ABI::Windows::Security::Credentials::IPasswordCredential *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IPasswordCredential*, int> put_DeviceUriPasswordCredential;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IUriRuntimeClass **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUriRuntimeClass**, int> get_DeviceUri;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IUriRuntimeClass *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUriRuntimeClass*, int> put_DeviceUri;
    }
}
