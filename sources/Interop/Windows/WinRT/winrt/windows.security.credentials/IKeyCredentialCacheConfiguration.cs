// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.security.credentials.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IKeyCredentialCacheConfiguration.xml' path='doc/member[@name="IKeyCredentialCacheConfiguration"]/*' />
[Guid("438BD21A-61FF-5468-95A6-B1D5216E458D")]
[NativeTypeName("struct IKeyCredentialCacheConfiguration : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IKeyCredentialCacheConfiguration : IKeyCredentialCacheConfiguration.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IKeyCredentialCacheConfiguration);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyCredentialCacheConfiguration*, Guid*, void**, int>)(lpVtbl[0]))((IKeyCredentialCacheConfiguration*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyCredentialCacheConfiguration*, uint>)(lpVtbl[1]))((IKeyCredentialCacheConfiguration*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyCredentialCacheConfiguration*, uint>)(lpVtbl[2]))((IKeyCredentialCacheConfiguration*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyCredentialCacheConfiguration*, uint*, Guid**, int>)(lpVtbl[3]))((IKeyCredentialCacheConfiguration*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyCredentialCacheConfiguration*, HSTRING*, int>)(lpVtbl[4]))((IKeyCredentialCacheConfiguration*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyCredentialCacheConfiguration*, TrustLevel*, int>)(lpVtbl[5]))((IKeyCredentialCacheConfiguration*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IKeyCredentialCacheConfiguration.xml' path='doc/member[@name="IKeyCredentialCacheConfiguration.get_CacheOption"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_CacheOption([NativeTypeName("ABI::Windows::Security::Credentials::KeyCredentialCacheOption *")] KeyCredentialCacheOption* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyCredentialCacheConfiguration*, KeyCredentialCacheOption*, int>)(lpVtbl[6]))((IKeyCredentialCacheConfiguration*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IKeyCredentialCacheConfiguration.xml' path='doc/member[@name="IKeyCredentialCacheConfiguration.get_Timeout"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Timeout([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyCredentialCacheConfiguration*, TimeSpan*, int>)(lpVtbl[7]))((IKeyCredentialCacheConfiguration*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IKeyCredentialCacheConfiguration.xml' path='doc/member[@name="IKeyCredentialCacheConfiguration.get_UsageCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_UsageCount([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyCredentialCacheConfiguration*, uint*, int>)(lpVtbl[8]))((IKeyCredentialCacheConfiguration*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_CacheOption([NativeTypeName("ABI::Windows::Security::Credentials::KeyCredentialCacheOption *")] KeyCredentialCacheOption* value);

        [VtblIndex(7)]
        HRESULT get_Timeout([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value);

        [VtblIndex(8)]
        HRESULT get_UsageCount([NativeTypeName("UINT32 *")] uint* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Security::Credentials::KeyCredentialCacheOption *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, KeyCredentialCacheOption*, int> get_CacheOption;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TimeSpan*, int> get_Timeout;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_UsageCount;
    }
}
