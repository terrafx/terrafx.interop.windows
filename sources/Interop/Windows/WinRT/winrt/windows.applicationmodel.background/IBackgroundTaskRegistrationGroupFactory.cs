// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.background.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IBackgroundTaskRegistrationGroupFactory.xml' path='doc/member[@name="IBackgroundTaskRegistrationGroupFactory"]/*' />
[Guid("83D92B69-44CF-4631-9740-03C7D8741BC5")]
[NativeTypeName("struct IBackgroundTaskRegistrationGroupFactory : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IBackgroundTaskRegistrationGroupFactory : IBackgroundTaskRegistrationGroupFactory.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IBackgroundTaskRegistrationGroupFactory);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTaskRegistrationGroupFactory*, Guid*, void**, int>)(lpVtbl[0]))((IBackgroundTaskRegistrationGroupFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTaskRegistrationGroupFactory*, uint>)(lpVtbl[1]))((IBackgroundTaskRegistrationGroupFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTaskRegistrationGroupFactory*, uint>)(lpVtbl[2]))((IBackgroundTaskRegistrationGroupFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTaskRegistrationGroupFactory*, uint*, Guid**, int>)(lpVtbl[3]))((IBackgroundTaskRegistrationGroupFactory*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTaskRegistrationGroupFactory*, HSTRING*, int>)(lpVtbl[4]))((IBackgroundTaskRegistrationGroupFactory*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTaskRegistrationGroupFactory*, TrustLevel*, int>)(lpVtbl[5]))((IBackgroundTaskRegistrationGroupFactory*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IBackgroundTaskRegistrationGroupFactory.xml' path='doc/member[@name="IBackgroundTaskRegistrationGroupFactory.Create"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Create(HSTRING id, [NativeTypeName("ABI::Windows::ApplicationModel::Background::IBackgroundTaskRegistrationGroup **")] IBackgroundTaskRegistrationGroup** group)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTaskRegistrationGroupFactory*, HSTRING, IBackgroundTaskRegistrationGroup**, int>)(lpVtbl[6]))((IBackgroundTaskRegistrationGroupFactory*)Unsafe.AsPointer(ref this), id, group);
    }

    /// <include file='IBackgroundTaskRegistrationGroupFactory.xml' path='doc/member[@name="IBackgroundTaskRegistrationGroupFactory.CreateWithName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateWithName(HSTRING id, HSTRING name, [NativeTypeName("ABI::Windows::ApplicationModel::Background::IBackgroundTaskRegistrationGroup **")] IBackgroundTaskRegistrationGroup** group)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTaskRegistrationGroupFactory*, HSTRING, HSTRING, IBackgroundTaskRegistrationGroup**, int>)(lpVtbl[7]))((IBackgroundTaskRegistrationGroupFactory*)Unsafe.AsPointer(ref this), id, name, group);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT Create(HSTRING id, [NativeTypeName("ABI::Windows::ApplicationModel::Background::IBackgroundTaskRegistrationGroup **")] IBackgroundTaskRegistrationGroup** group);

        [VtblIndex(7)]
        HRESULT CreateWithName(HSTRING id, HSTRING name, [NativeTypeName("ABI::Windows::ApplicationModel::Background::IBackgroundTaskRegistrationGroup **")] IBackgroundTaskRegistrationGroup** group);
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

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::ApplicationModel::Background::IBackgroundTaskRegistrationGroup **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IBackgroundTaskRegistrationGroup**, int> Create;

        [NativeTypeName("HRESULT (HSTRING, HSTRING, ABI::Windows::ApplicationModel::Background::IBackgroundTaskRegistrationGroup **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, HSTRING, IBackgroundTaskRegistrationGroup**, int> CreateWithName;
    }
}
