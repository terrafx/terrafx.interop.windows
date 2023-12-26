// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.contacts.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IContactInstantMessageField.xml' path='doc/member[@name="IContactInstantMessageField"]/*' />
[Guid("CCE33B37-0D85-41FA-B43D-DA599C3EB009")]
[NativeTypeName("struct IContactInstantMessageField : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IContactInstantMessageField : IContactInstantMessageField.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IContactInstantMessageField));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactInstantMessageField*, Guid*, void**, int>)(lpVtbl[0]))((IContactInstantMessageField*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IContactInstantMessageField*, uint>)(lpVtbl[1]))((IContactInstantMessageField*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IContactInstantMessageField*, uint>)(lpVtbl[2]))((IContactInstantMessageField*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactInstantMessageField*, uint*, Guid**, int>)(lpVtbl[3]))((IContactInstantMessageField*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactInstantMessageField*, HSTRING*, int>)(lpVtbl[4]))((IContactInstantMessageField*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactInstantMessageField*, TrustLevel*, int>)(lpVtbl[5]))((IContactInstantMessageField*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IContactInstantMessageField.xml' path='doc/member[@name="IContactInstantMessageField.get_UserName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_UserName(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactInstantMessageField*, HSTRING*, int>)(lpVtbl[6]))((IContactInstantMessageField*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactInstantMessageField.xml' path='doc/member[@name="IContactInstantMessageField.get_Service"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Service(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactInstantMessageField*, HSTRING*, int>)(lpVtbl[7]))((IContactInstantMessageField*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactInstantMessageField.xml' path='doc/member[@name="IContactInstantMessageField.get_DisplayText"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_DisplayText(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactInstantMessageField*, HSTRING*, int>)(lpVtbl[8]))((IContactInstantMessageField*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactInstantMessageField.xml' path='doc/member[@name="IContactInstantMessageField.get_LaunchUri"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_LaunchUri([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass **")] IUriRuntimeClass** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactInstantMessageField*, IUriRuntimeClass**, int>)(lpVtbl[9]))((IContactInstantMessageField*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_UserName(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_Service(HSTRING* value);

        [VtblIndex(8)]
        HRESULT get_DisplayText(HSTRING* value);

        [VtblIndex(9)]
        HRESULT get_LaunchUri([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass **")] IUriRuntimeClass** value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_UserName;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Service;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_DisplayText;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IUriRuntimeClass **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUriRuntimeClass**, int> get_LaunchUri;
    }
}
