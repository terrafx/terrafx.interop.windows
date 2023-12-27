// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.email.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IEmailRecipientFactory.xml' path='doc/member[@name="IEmailRecipientFactory"]/*' />
[Guid("5500B84D-C79A-4EF8-B909-722E18E3935D")]
[NativeTypeName("struct IEmailRecipientFactory : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IEmailRecipientFactory : IEmailRecipientFactory.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IEmailRecipientFactory));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailRecipientFactory*, Guid*, void**, int>)(lpVtbl[0]))((IEmailRecipientFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailRecipientFactory*, uint>)(lpVtbl[1]))((IEmailRecipientFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailRecipientFactory*, uint>)(lpVtbl[2]))((IEmailRecipientFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailRecipientFactory*, uint*, Guid**, int>)(lpVtbl[3]))((IEmailRecipientFactory*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailRecipientFactory*, HSTRING*, int>)(lpVtbl[4]))((IEmailRecipientFactory*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailRecipientFactory*, TrustLevel*, int>)(lpVtbl[5]))((IEmailRecipientFactory*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IEmailRecipientFactory.xml' path='doc/member[@name="IEmailRecipientFactory.Create"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Create(HSTRING address, [NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailRecipient **")] IEmailRecipient** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailRecipientFactory*, HSTRING, IEmailRecipient**, int>)(lpVtbl[6]))((IEmailRecipientFactory*)Unsafe.AsPointer(ref this), address, result);
    }

    /// <include file='IEmailRecipientFactory.xml' path='doc/member[@name="IEmailRecipientFactory.CreateWithName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateWithName(HSTRING address, HSTRING name, [NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailRecipient **")] IEmailRecipient** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailRecipientFactory*, HSTRING, HSTRING, IEmailRecipient**, int>)(lpVtbl[7]))((IEmailRecipientFactory*)Unsafe.AsPointer(ref this), address, name, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT Create(HSTRING address, [NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailRecipient **")] IEmailRecipient** result);

        [VtblIndex(7)]
        HRESULT CreateWithName(HSTRING address, HSTRING name, [NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailRecipient **")] IEmailRecipient** result);
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

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::ApplicationModel::Email::IEmailRecipient **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IEmailRecipient**, int> Create;

        [NativeTypeName("HRESULT (HSTRING, HSTRING, ABI::Windows::ApplicationModel::Email::IEmailRecipient **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, HSTRING, IEmailRecipient**, int> CreateWithName;
    }
}
