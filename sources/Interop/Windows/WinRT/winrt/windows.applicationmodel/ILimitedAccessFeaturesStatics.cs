// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ILimitedAccessFeaturesStatics.xml' path='doc/member[@name="ILimitedAccessFeaturesStatics"]/*' />
[Guid("8BE612D4-302B-5FBF-A632-1A99E43E8925")]
[NativeTypeName("struct ILimitedAccessFeaturesStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ILimitedAccessFeaturesStatics : ILimitedAccessFeaturesStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ILimitedAccessFeaturesStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ILimitedAccessFeaturesStatics*, Guid*, void**, int>)(lpVtbl[0]))((ILimitedAccessFeaturesStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ILimitedAccessFeaturesStatics*, uint>)(lpVtbl[1]))((ILimitedAccessFeaturesStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ILimitedAccessFeaturesStatics*, uint>)(lpVtbl[2]))((ILimitedAccessFeaturesStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ILimitedAccessFeaturesStatics*, uint*, Guid**, int>)(lpVtbl[3]))((ILimitedAccessFeaturesStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ILimitedAccessFeaturesStatics*, HSTRING*, int>)(lpVtbl[4]))((ILimitedAccessFeaturesStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ILimitedAccessFeaturesStatics*, TrustLevel*, int>)(lpVtbl[5]))((ILimitedAccessFeaturesStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ILimitedAccessFeaturesStatics.xml' path='doc/member[@name="ILimitedAccessFeaturesStatics.TryUnlockFeature"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT TryUnlockFeature(HSTRING featureId, HSTRING token, HSTRING attestation, [NativeTypeName("ABI::Windows::ApplicationModel::ILimitedAccessFeatureRequestResult **")] ILimitedAccessFeatureRequestResult** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ILimitedAccessFeaturesStatics*, HSTRING, HSTRING, HSTRING, ILimitedAccessFeatureRequestResult**, int>)(lpVtbl[6]))((ILimitedAccessFeaturesStatics*)Unsafe.AsPointer(ref this), featureId, token, attestation, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT TryUnlockFeature(HSTRING featureId, HSTRING token, HSTRING attestation, [NativeTypeName("ABI::Windows::ApplicationModel::ILimitedAccessFeatureRequestResult **")] ILimitedAccessFeatureRequestResult** result);
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

        [NativeTypeName("HRESULT (HSTRING, HSTRING, HSTRING, ABI::Windows::ApplicationModel::ILimitedAccessFeatureRequestResult **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, HSTRING, HSTRING, ILimitedAccessFeatureRequestResult**, int> TryUnlockFeature;
    }
}
