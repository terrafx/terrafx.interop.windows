// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.contacts.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IContactConnectedServiceAccount.xml' path='doc/member[@name="IContactConnectedServiceAccount"]/*' />
[Guid("F6F83553-AA27-4731-8E4A-3DEC5CE9EEC9")]
[NativeTypeName("struct IContactConnectedServiceAccount : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IContactConnectedServiceAccount : IContactConnectedServiceAccount.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IContactConnectedServiceAccount));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactConnectedServiceAccount*, Guid*, void**, int>)(lpVtbl[0]))((IContactConnectedServiceAccount*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IContactConnectedServiceAccount*, uint>)(lpVtbl[1]))((IContactConnectedServiceAccount*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IContactConnectedServiceAccount*, uint>)(lpVtbl[2]))((IContactConnectedServiceAccount*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactConnectedServiceAccount*, uint*, Guid**, int>)(lpVtbl[3]))((IContactConnectedServiceAccount*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactConnectedServiceAccount*, HSTRING*, int>)(lpVtbl[4]))((IContactConnectedServiceAccount*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactConnectedServiceAccount*, TrustLevel*, int>)(lpVtbl[5]))((IContactConnectedServiceAccount*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IContactConnectedServiceAccount.xml' path='doc/member[@name="IContactConnectedServiceAccount.get_Id"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Id(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactConnectedServiceAccount*, HSTRING*, int>)(lpVtbl[6]))((IContactConnectedServiceAccount*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactConnectedServiceAccount.xml' path='doc/member[@name="IContactConnectedServiceAccount.put_Id"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_Id(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactConnectedServiceAccount*, HSTRING, int>)(lpVtbl[7]))((IContactConnectedServiceAccount*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactConnectedServiceAccount.xml' path='doc/member[@name="IContactConnectedServiceAccount.get_ServiceName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_ServiceName(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactConnectedServiceAccount*, HSTRING*, int>)(lpVtbl[8]))((IContactConnectedServiceAccount*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactConnectedServiceAccount.xml' path='doc/member[@name="IContactConnectedServiceAccount.put_ServiceName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_ServiceName(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactConnectedServiceAccount*, HSTRING, int>)(lpVtbl[9]))((IContactConnectedServiceAccount*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Id(HSTRING* value);

        [VtblIndex(7)]
        HRESULT put_Id(HSTRING value);

        [VtblIndex(8)]
        HRESULT get_ServiceName(HSTRING* value);

        [VtblIndex(9)]
        HRESULT put_ServiceName(HSTRING value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Id;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_Id;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_ServiceName;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_ServiceName;
    }
}
