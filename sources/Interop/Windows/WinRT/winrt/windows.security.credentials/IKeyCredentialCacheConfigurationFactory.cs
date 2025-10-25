// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.security.credentials.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IKeyCredentialCacheConfigurationFactory.xml' path='doc/member[@name="IKeyCredentialCacheConfigurationFactory"]/*' />
[Guid("9948C31B-C827-5B58-9442-40ACD8AB1E7D")]
[NativeTypeName("struct IKeyCredentialCacheConfigurationFactory : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IKeyCredentialCacheConfigurationFactory : IKeyCredentialCacheConfigurationFactory.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IKeyCredentialCacheConfigurationFactory);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyCredentialCacheConfigurationFactory*, Guid*, void**, int>)(lpVtbl[0]))((IKeyCredentialCacheConfigurationFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyCredentialCacheConfigurationFactory*, uint>)(lpVtbl[1]))((IKeyCredentialCacheConfigurationFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyCredentialCacheConfigurationFactory*, uint>)(lpVtbl[2]))((IKeyCredentialCacheConfigurationFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyCredentialCacheConfigurationFactory*, uint*, Guid**, int>)(lpVtbl[3]))((IKeyCredentialCacheConfigurationFactory*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyCredentialCacheConfigurationFactory*, HSTRING*, int>)(lpVtbl[4]))((IKeyCredentialCacheConfigurationFactory*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyCredentialCacheConfigurationFactory*, TrustLevel*, int>)(lpVtbl[5]))((IKeyCredentialCacheConfigurationFactory*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IKeyCredentialCacheConfigurationFactory.xml' path='doc/member[@name="IKeyCredentialCacheConfigurationFactory.CreateInstance"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateInstance([NativeTypeName("ABI::Windows::Security::Credentials::KeyCredentialCacheOption")] KeyCredentialCacheOption cacheOption, [NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan timeout, [NativeTypeName("UINT32")] uint usageCount, [NativeTypeName("ABI::Windows::Security::Credentials::IKeyCredentialCacheConfiguration **")] IKeyCredentialCacheConfiguration** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyCredentialCacheConfigurationFactory*, KeyCredentialCacheOption, TimeSpan, uint, IKeyCredentialCacheConfiguration**, int>)(lpVtbl[6]))((IKeyCredentialCacheConfigurationFactory*)Unsafe.AsPointer(ref this), cacheOption, timeout, usageCount, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateInstance([NativeTypeName("ABI::Windows::Security::Credentials::KeyCredentialCacheOption")] KeyCredentialCacheOption cacheOption, [NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan timeout, [NativeTypeName("UINT32")] uint usageCount, [NativeTypeName("ABI::Windows::Security::Credentials::IKeyCredentialCacheConfiguration **")] IKeyCredentialCacheConfiguration** result);
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

        [NativeTypeName("HRESULT (ABI::Windows::Security::Credentials::KeyCredentialCacheOption, ABI::Windows::Foundation::TimeSpan, UINT32, ABI::Windows::Security::Credentials::IKeyCredentialCacheConfiguration **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, KeyCredentialCacheOption, TimeSpan, uint, IKeyCredentialCacheConfiguration**, int> CreateInstance;
    }
}
