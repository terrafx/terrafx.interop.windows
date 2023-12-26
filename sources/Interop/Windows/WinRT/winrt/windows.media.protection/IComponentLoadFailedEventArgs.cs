// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.protection.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IComponentLoadFailedEventArgs.xml' path='doc/member[@name="IComponentLoadFailedEventArgs"]/*' />
[Guid("95972E93-7746-417E-8495-F031BBC5862C")]
[NativeTypeName("struct IComponentLoadFailedEventArgs : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IComponentLoadFailedEventArgs : IComponentLoadFailedEventArgs.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IComponentLoadFailedEventArgs));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IComponentLoadFailedEventArgs*, Guid*, void**, int>)(lpVtbl[0]))((IComponentLoadFailedEventArgs*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IComponentLoadFailedEventArgs*, uint>)(lpVtbl[1]))((IComponentLoadFailedEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IComponentLoadFailedEventArgs*, uint>)(lpVtbl[2]))((IComponentLoadFailedEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IComponentLoadFailedEventArgs*, uint*, Guid**, int>)(lpVtbl[3]))((IComponentLoadFailedEventArgs*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IComponentLoadFailedEventArgs*, HSTRING*, int>)(lpVtbl[4]))((IComponentLoadFailedEventArgs*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IComponentLoadFailedEventArgs*, TrustLevel*, int>)(lpVtbl[5]))((IComponentLoadFailedEventArgs*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IComponentLoadFailedEventArgs.xml' path='doc/member[@name="IComponentLoadFailedEventArgs.get_Information"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Information([NativeTypeName("ABI::Windows::Media::Protection::IRevocationAndRenewalInformation **")] IRevocationAndRenewalInformation** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IComponentLoadFailedEventArgs*, IRevocationAndRenewalInformation**, int>)(lpVtbl[6]))((IComponentLoadFailedEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IComponentLoadFailedEventArgs.xml' path='doc/member[@name="IComponentLoadFailedEventArgs.get_Completion"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Completion([NativeTypeName("ABI::Windows::Media::Protection::IMediaProtectionServiceCompletion **")] IMediaProtectionServiceCompletion** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IComponentLoadFailedEventArgs*, IMediaProtectionServiceCompletion**, int>)(lpVtbl[7]))((IComponentLoadFailedEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Information([NativeTypeName("ABI::Windows::Media::Protection::IRevocationAndRenewalInformation **")] IRevocationAndRenewalInformation** value);

        [VtblIndex(7)]
        HRESULT get_Completion([NativeTypeName("ABI::Windows::Media::Protection::IMediaProtectionServiceCompletion **")] IMediaProtectionServiceCompletion** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Media::Protection::IRevocationAndRenewalInformation **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IRevocationAndRenewalInformation**, int> get_Information;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Protection::IMediaProtectionServiceCompletion **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaProtectionServiceCompletion**, int> get_Completion;
    }
}
