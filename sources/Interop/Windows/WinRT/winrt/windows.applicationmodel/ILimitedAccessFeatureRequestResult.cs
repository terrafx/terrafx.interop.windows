// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ILimitedAccessFeatureRequestResult.xml' path='doc/member[@name="ILimitedAccessFeatureRequestResult"]/*' />
[Guid("D45156A6-1E24-5DDD-ABB4-6188ABA4D5BF")]
[NativeTypeName("struct ILimitedAccessFeatureRequestResult : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ILimitedAccessFeatureRequestResult : ILimitedAccessFeatureRequestResult.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ILimitedAccessFeatureRequestResult));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ILimitedAccessFeatureRequestResult*, Guid*, void**, int>)(lpVtbl[0]))((ILimitedAccessFeatureRequestResult*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ILimitedAccessFeatureRequestResult*, uint>)(lpVtbl[1]))((ILimitedAccessFeatureRequestResult*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ILimitedAccessFeatureRequestResult*, uint>)(lpVtbl[2]))((ILimitedAccessFeatureRequestResult*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ILimitedAccessFeatureRequestResult*, uint*, Guid**, int>)(lpVtbl[3]))((ILimitedAccessFeatureRequestResult*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ILimitedAccessFeatureRequestResult*, HSTRING*, int>)(lpVtbl[4]))((ILimitedAccessFeatureRequestResult*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ILimitedAccessFeatureRequestResult*, TrustLevel*, int>)(lpVtbl[5]))((ILimitedAccessFeatureRequestResult*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ILimitedAccessFeatureRequestResult.xml' path='doc/member[@name="ILimitedAccessFeatureRequestResult.get_FeatureId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_FeatureId(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ILimitedAccessFeatureRequestResult*, HSTRING*, int>)(lpVtbl[6]))((ILimitedAccessFeatureRequestResult*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ILimitedAccessFeatureRequestResult.xml' path='doc/member[@name="ILimitedAccessFeatureRequestResult.get_Status"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Status([NativeTypeName("ABI::Windows::ApplicationModel::LimitedAccessFeatureStatus *")] LimitedAccessFeatureStatus* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ILimitedAccessFeatureRequestResult*, LimitedAccessFeatureStatus*, int>)(lpVtbl[7]))((ILimitedAccessFeatureRequestResult*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ILimitedAccessFeatureRequestResult.xml' path='doc/member[@name="ILimitedAccessFeatureRequestResult.get_EstimatedRemovalDate"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_EstimatedRemovalDate([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t **")] IReference<DateTime>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ILimitedAccessFeatureRequestResult*, IReference<DateTime>**, int>)(lpVtbl[8]))((ILimitedAccessFeatureRequestResult*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_FeatureId(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_Status([NativeTypeName("ABI::Windows::ApplicationModel::LimitedAccessFeatureStatus *")] LimitedAccessFeatureStatus* value);

        [VtblIndex(8)]
        HRESULT get_EstimatedRemovalDate([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t **")] IReference<DateTime>** value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_FeatureId;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::LimitedAccessFeatureStatus *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, LimitedAccessFeatureStatus*, int> get_Status;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<DateTime>**, int> get_EstimatedRemovalDate;
    }
}
