// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.email.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IEmailQueryOptionsFactory.xml' path='doc/member[@name="IEmailQueryOptionsFactory"]/*' />
[Guid("88F1A1B8-78AB-4EE8-B4E3-046D6E2FE5E2")]
[NativeTypeName("struct IEmailQueryOptionsFactory : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IEmailQueryOptionsFactory : IEmailQueryOptionsFactory.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IEmailQueryOptionsFactory));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailQueryOptionsFactory*, Guid*, void**, int>)(lpVtbl[0]))((IEmailQueryOptionsFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailQueryOptionsFactory*, uint>)(lpVtbl[1]))((IEmailQueryOptionsFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailQueryOptionsFactory*, uint>)(lpVtbl[2]))((IEmailQueryOptionsFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailQueryOptionsFactory*, uint*, Guid**, int>)(lpVtbl[3]))((IEmailQueryOptionsFactory*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailQueryOptionsFactory*, HSTRING*, int>)(lpVtbl[4]))((IEmailQueryOptionsFactory*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailQueryOptionsFactory*, TrustLevel*, int>)(lpVtbl[5]))((IEmailQueryOptionsFactory*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IEmailQueryOptionsFactory.xml' path='doc/member[@name="IEmailQueryOptionsFactory.CreateWithText"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateWithText(HSTRING text, [NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailQueryOptions **")] IEmailQueryOptions** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailQueryOptionsFactory*, HSTRING, IEmailQueryOptions**, int>)(lpVtbl[6]))((IEmailQueryOptionsFactory*)Unsafe.AsPointer(ref this), text, result);
    }

    /// <include file='IEmailQueryOptionsFactory.xml' path='doc/member[@name="IEmailQueryOptionsFactory.CreateWithTextAndFields"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateWithTextAndFields(HSTRING text, [NativeTypeName("ABI::Windows::ApplicationModel::Email::EmailQuerySearchFields")] EmailQuerySearchFields fields, [NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailQueryOptions **")] IEmailQueryOptions** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailQueryOptionsFactory*, HSTRING, EmailQuerySearchFields, IEmailQueryOptions**, int>)(lpVtbl[7]))((IEmailQueryOptionsFactory*)Unsafe.AsPointer(ref this), text, fields, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateWithText(HSTRING text, [NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailQueryOptions **")] IEmailQueryOptions** result);

        [VtblIndex(7)]
        HRESULT CreateWithTextAndFields(HSTRING text, [NativeTypeName("ABI::Windows::ApplicationModel::Email::EmailQuerySearchFields")] EmailQuerySearchFields fields, [NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailQueryOptions **")] IEmailQueryOptions** result);
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

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::ApplicationModel::Email::IEmailQueryOptions **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IEmailQueryOptions**, int> CreateWithText;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::ApplicationModel::Email::EmailQuerySearchFields, ABI::Windows::ApplicationModel::Email::IEmailQueryOptions **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, EmailQuerySearchFields, IEmailQueryOptions**, int> CreateWithTextAndFields;
    }
}
