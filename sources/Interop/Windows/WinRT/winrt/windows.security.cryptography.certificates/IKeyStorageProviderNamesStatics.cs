// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.security.cryptography.certificates.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IKeyStorageProviderNamesStatics.xml' path='doc/member[@name="IKeyStorageProviderNamesStatics"]/*' />
[Guid("AF186AE0-5529-4602-BD94-0AAB91957B5C")]
[NativeTypeName("struct IKeyStorageProviderNamesStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IKeyStorageProviderNamesStatics : IKeyStorageProviderNamesStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IKeyStorageProviderNamesStatics);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyStorageProviderNamesStatics*, Guid*, void**, int>)(lpVtbl[0]))((IKeyStorageProviderNamesStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyStorageProviderNamesStatics*, uint>)(lpVtbl[1]))((IKeyStorageProviderNamesStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyStorageProviderNamesStatics*, uint>)(lpVtbl[2]))((IKeyStorageProviderNamesStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyStorageProviderNamesStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IKeyStorageProviderNamesStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyStorageProviderNamesStatics*, HSTRING*, int>)(lpVtbl[4]))((IKeyStorageProviderNamesStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyStorageProviderNamesStatics*, TrustLevel*, int>)(lpVtbl[5]))((IKeyStorageProviderNamesStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IKeyStorageProviderNamesStatics.xml' path='doc/member[@name="IKeyStorageProviderNamesStatics.get_SoftwareKeyStorageProvider"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_SoftwareKeyStorageProvider(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyStorageProviderNamesStatics*, HSTRING*, int>)(lpVtbl[6]))((IKeyStorageProviderNamesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IKeyStorageProviderNamesStatics.xml' path='doc/member[@name="IKeyStorageProviderNamesStatics.get_SmartcardKeyStorageProvider"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_SmartcardKeyStorageProvider(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyStorageProviderNamesStatics*, HSTRING*, int>)(lpVtbl[7]))((IKeyStorageProviderNamesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IKeyStorageProviderNamesStatics.xml' path='doc/member[@name="IKeyStorageProviderNamesStatics.get_PlatformKeyStorageProvider"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_PlatformKeyStorageProvider(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyStorageProviderNamesStatics*, HSTRING*, int>)(lpVtbl[8]))((IKeyStorageProviderNamesStatics*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_SoftwareKeyStorageProvider(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_SmartcardKeyStorageProvider(HSTRING* value);

        [VtblIndex(8)]
        HRESULT get_PlatformKeyStorageProvider(HSTRING* value);
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

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_SoftwareKeyStorageProvider;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_SmartcardKeyStorageProvider;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_PlatformKeyStorageProvider;
    }
}
