// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.remotesystems.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IRemoteSystemStatics3.xml' path='doc/member[@name="IRemoteSystemStatics3"]/*' />
[Guid("9995F16F-0B3C-5AC5-B325-CC73F437DFCD")]
[NativeTypeName("struct IRemoteSystemStatics3 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IRemoteSystemStatics3 : IRemoteSystemStatics3.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IRemoteSystemStatics3));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemStatics3*, Guid*, void**, int>)(lpVtbl[0]))((IRemoteSystemStatics3*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemStatics3*, uint>)(lpVtbl[1]))((IRemoteSystemStatics3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemStatics3*, uint>)(lpVtbl[2]))((IRemoteSystemStatics3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemStatics3*, uint*, Guid**, int>)(lpVtbl[3]))((IRemoteSystemStatics3*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemStatics3*, HSTRING*, int>)(lpVtbl[4]))((IRemoteSystemStatics3*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemStatics3*, TrustLevel*, int>)(lpVtbl[5]))((IRemoteSystemStatics3*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IRemoteSystemStatics3.xml' path='doc/member[@name="IRemoteSystemStatics3.CreateWatcherForUser"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateWatcherForUser([NativeTypeName("ABI::Windows::System::IUser *")] IUser* user, [NativeTypeName("ABI::Windows::System::RemoteSystems::IRemoteSystemWatcher **")] IRemoteSystemWatcher** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemStatics3*, IUser*, IRemoteSystemWatcher**, int>)(lpVtbl[6]))((IRemoteSystemStatics3*)Unsafe.AsPointer(ref this), user, result);
    }

    /// <include file='IRemoteSystemStatics3.xml' path='doc/member[@name="IRemoteSystemStatics3.CreateWatcherWithFiltersForUser"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateWatcherWithFiltersForUser([NativeTypeName("ABI::Windows::System::IUser *")] IUser* user, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CSystem__CRemoteSystems__CIRemoteSystemFilter_t *")] IIterable<Pointer<IRemoteSystemFilter>>* filters, [NativeTypeName("ABI::Windows::System::RemoteSystems::IRemoteSystemWatcher **")] IRemoteSystemWatcher** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemStatics3*, IUser*, IIterable<Pointer<IRemoteSystemFilter>>*, IRemoteSystemWatcher**, int>)(lpVtbl[7]))((IRemoteSystemStatics3*)Unsafe.AsPointer(ref this), user, filters, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateWatcherForUser([NativeTypeName("ABI::Windows::System::IUser *")] IUser* user, [NativeTypeName("ABI::Windows::System::RemoteSystems::IRemoteSystemWatcher **")] IRemoteSystemWatcher** result);

        [VtblIndex(7)]
        HRESULT CreateWatcherWithFiltersForUser([NativeTypeName("ABI::Windows::System::IUser *")] IUser* user, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CSystem__CRemoteSystems__CIRemoteSystemFilter_t *")] IIterable<Pointer<IRemoteSystemFilter>>* filters, [NativeTypeName("ABI::Windows::System::RemoteSystems::IRemoteSystemWatcher **")] IRemoteSystemWatcher** result);
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

        [NativeTypeName("HRESULT (ABI::Windows::System::IUser *, ABI::Windows::System::RemoteSystems::IRemoteSystemWatcher **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUser*, IRemoteSystemWatcher**, int> CreateWatcherForUser;

        [NativeTypeName("HRESULT (ABI::Windows::System::IUser *, ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CSystem__CRemoteSystems__CIRemoteSystemFilter_t *, ABI::Windows::System::RemoteSystems::IRemoteSystemWatcher **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUser*, IIterable<Pointer<IRemoteSystemFilter>>*, IRemoteSystemWatcher**, int> CreateWatcherWithFiltersForUser;
    }
}
