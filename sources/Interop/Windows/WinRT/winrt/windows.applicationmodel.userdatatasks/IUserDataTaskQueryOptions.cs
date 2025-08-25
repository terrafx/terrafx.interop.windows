// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.userdatatasks.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IUserDataTaskQueryOptions.xml' path='doc/member[@name="IUserDataTaskQueryOptions"]/*' />
[Guid("959F27ED-909A-4D30-8C1B-331D8FE667E2")]
[NativeTypeName("struct IUserDataTaskQueryOptions : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IUserDataTaskQueryOptions : IUserDataTaskQueryOptions.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IUserDataTaskQueryOptions);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataTaskQueryOptions*, Guid*, void**, int>)(lpVtbl[0]))((IUserDataTaskQueryOptions*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataTaskQueryOptions*, uint>)(lpVtbl[1]))((IUserDataTaskQueryOptions*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataTaskQueryOptions*, uint>)(lpVtbl[2]))((IUserDataTaskQueryOptions*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataTaskQueryOptions*, uint*, Guid**, int>)(lpVtbl[3]))((IUserDataTaskQueryOptions*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataTaskQueryOptions*, HSTRING*, int>)(lpVtbl[4]))((IUserDataTaskQueryOptions*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataTaskQueryOptions*, TrustLevel*, int>)(lpVtbl[5]))((IUserDataTaskQueryOptions*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IUserDataTaskQueryOptions.xml' path='doc/member[@name="IUserDataTaskQueryOptions.get_SortProperty"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_SortProperty([NativeTypeName("ABI::Windows::ApplicationModel::UserDataTasks::UserDataTaskQuerySortProperty *")] UserDataTaskQuerySortProperty* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataTaskQueryOptions*, UserDataTaskQuerySortProperty*, int>)(lpVtbl[6]))((IUserDataTaskQueryOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IUserDataTaskQueryOptions.xml' path='doc/member[@name="IUserDataTaskQueryOptions.put_SortProperty"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_SortProperty([NativeTypeName("ABI::Windows::ApplicationModel::UserDataTasks::UserDataTaskQuerySortProperty")] UserDataTaskQuerySortProperty value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataTaskQueryOptions*, UserDataTaskQuerySortProperty, int>)(lpVtbl[7]))((IUserDataTaskQueryOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IUserDataTaskQueryOptions.xml' path='doc/member[@name="IUserDataTaskQueryOptions.get_Kind"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Kind([NativeTypeName("ABI::Windows::ApplicationModel::UserDataTasks::UserDataTaskQueryKind *")] UserDataTaskQueryKind* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataTaskQueryOptions*, UserDataTaskQueryKind*, int>)(lpVtbl[8]))((IUserDataTaskQueryOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IUserDataTaskQueryOptions.xml' path='doc/member[@name="IUserDataTaskQueryOptions.put_Kind"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_Kind([NativeTypeName("ABI::Windows::ApplicationModel::UserDataTasks::UserDataTaskQueryKind")] UserDataTaskQueryKind value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataTaskQueryOptions*, UserDataTaskQueryKind, int>)(lpVtbl[9]))((IUserDataTaskQueryOptions*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_SortProperty([NativeTypeName("ABI::Windows::ApplicationModel::UserDataTasks::UserDataTaskQuerySortProperty *")] UserDataTaskQuerySortProperty* value);

        [VtblIndex(7)]
        HRESULT put_SortProperty([NativeTypeName("ABI::Windows::ApplicationModel::UserDataTasks::UserDataTaskQuerySortProperty")] UserDataTaskQuerySortProperty value);

        [VtblIndex(8)]
        HRESULT get_Kind([NativeTypeName("ABI::Windows::ApplicationModel::UserDataTasks::UserDataTaskQueryKind *")] UserDataTaskQueryKind* value);

        [VtblIndex(9)]
        HRESULT put_Kind([NativeTypeName("ABI::Windows::ApplicationModel::UserDataTasks::UserDataTaskQueryKind")] UserDataTaskQueryKind value);
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

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::UserDataTasks::UserDataTaskQuerySortProperty *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, UserDataTaskQuerySortProperty*, int> get_SortProperty;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::UserDataTasks::UserDataTaskQuerySortProperty) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, UserDataTaskQuerySortProperty, int> put_SortProperty;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::UserDataTasks::UserDataTaskQueryKind *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, UserDataTaskQueryKind*, int> get_Kind;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::UserDataTasks::UserDataTaskQueryKind) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, UserDataTaskQueryKind, int> put_Kind;
    }
}
