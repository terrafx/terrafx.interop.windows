// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.background.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IBackgroundTaskRegistrationStatics2.xml' path='doc/member[@name="IBackgroundTaskRegistrationStatics2"]/*' />
[Guid("174B671E-B20D-4FA9-AD9A-E93AD6C71E01")]
[NativeTypeName("struct IBackgroundTaskRegistrationStatics2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IBackgroundTaskRegistrationStatics2 : IBackgroundTaskRegistrationStatics2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IBackgroundTaskRegistrationStatics2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTaskRegistrationStatics2*, Guid*, void**, int>)(lpVtbl[0]))((IBackgroundTaskRegistrationStatics2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTaskRegistrationStatics2*, uint>)(lpVtbl[1]))((IBackgroundTaskRegistrationStatics2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTaskRegistrationStatics2*, uint>)(lpVtbl[2]))((IBackgroundTaskRegistrationStatics2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTaskRegistrationStatics2*, uint*, Guid**, int>)(lpVtbl[3]))((IBackgroundTaskRegistrationStatics2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTaskRegistrationStatics2*, HSTRING*, int>)(lpVtbl[4]))((IBackgroundTaskRegistrationStatics2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTaskRegistrationStatics2*, TrustLevel*, int>)(lpVtbl[5]))((IBackgroundTaskRegistrationStatics2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IBackgroundTaskRegistrationStatics2.xml' path='doc/member[@name="IBackgroundTaskRegistrationStatics2.get_AllTaskGroups"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_AllTaskGroups([NativeTypeName("ABI::Windows::Foundation::Collections::__FIMapView_2_HSTRING_Windows__CApplicationModel__CBackground__CBackgroundTaskRegistrationGroup_t **")] IMapView<HSTRING, Pointer<IBackgroundTaskRegistrationGroup>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTaskRegistrationStatics2*, IMapView<HSTRING, Pointer<IBackgroundTaskRegistrationGroup>>**, int>)(lpVtbl[6]))((IBackgroundTaskRegistrationStatics2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBackgroundTaskRegistrationStatics2.xml' path='doc/member[@name="IBackgroundTaskRegistrationStatics2.GetTaskGroup"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetTaskGroup(HSTRING groupId, [NativeTypeName("ABI::Windows::ApplicationModel::Background::IBackgroundTaskRegistrationGroup **")] IBackgroundTaskRegistrationGroup** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTaskRegistrationStatics2*, HSTRING, IBackgroundTaskRegistrationGroup**, int>)(lpVtbl[7]))((IBackgroundTaskRegistrationStatics2*)Unsafe.AsPointer(ref this), groupId, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_AllTaskGroups([NativeTypeName("ABI::Windows::Foundation::Collections::__FIMapView_2_HSTRING_Windows__CApplicationModel__CBackground__CBackgroundTaskRegistrationGroup_t **")] IMapView<HSTRING, Pointer<IBackgroundTaskRegistrationGroup>>** value);

        [VtblIndex(7)]
        HRESULT GetTaskGroup(HSTRING groupId, [NativeTypeName("ABI::Windows::ApplicationModel::Background::IBackgroundTaskRegistrationGroup **")] IBackgroundTaskRegistrationGroup** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIMapView_2_HSTRING_Windows__CApplicationModel__CBackground__CBackgroundTaskRegistrationGroup_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMapView<HSTRING, Pointer<IBackgroundTaskRegistrationGroup>>**, int> get_AllTaskGroups;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::ApplicationModel::Background::IBackgroundTaskRegistrationGroup **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IBackgroundTaskRegistrationGroup**, int> GetTaskGroup;
    }
}
