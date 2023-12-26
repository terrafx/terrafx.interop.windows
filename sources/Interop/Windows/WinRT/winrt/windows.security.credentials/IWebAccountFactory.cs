// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.security.credentials.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IWebAccountFactory.xml' path='doc/member[@name="IWebAccountFactory"]/*' />
[Guid("AC9AFB39-1DE9-4E92-B78F-0581A87F6E5C")]
[NativeTypeName("struct IWebAccountFactory : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IWebAccountFactory : IWebAccountFactory.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWebAccountFactory));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAccountFactory*, Guid*, void**, int>)(lpVtbl[0]))((IWebAccountFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAccountFactory*, uint>)(lpVtbl[1]))((IWebAccountFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAccountFactory*, uint>)(lpVtbl[2]))((IWebAccountFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAccountFactory*, uint*, Guid**, int>)(lpVtbl[3]))((IWebAccountFactory*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAccountFactory*, HSTRING*, int>)(lpVtbl[4]))((IWebAccountFactory*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAccountFactory*, TrustLevel*, int>)(lpVtbl[5]))((IWebAccountFactory*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IWebAccountFactory.xml' path='doc/member[@name="IWebAccountFactory.CreateWebAccount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateWebAccount([NativeTypeName("ABI::Windows::Security::Credentials::IWebAccountProvider *")] IWebAccountProvider* webAccountProvider, HSTRING userName, [NativeTypeName("ABI::Windows::Security::Credentials::WebAccountState")] WebAccountState state, [NativeTypeName("ABI::Windows::Security::Credentials::IWebAccount **")] IWebAccount** instance)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAccountFactory*, IWebAccountProvider*, HSTRING, WebAccountState, IWebAccount**, int>)(lpVtbl[6]))((IWebAccountFactory*)Unsafe.AsPointer(ref this), webAccountProvider, userName, state, instance);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateWebAccount([NativeTypeName("ABI::Windows::Security::Credentials::IWebAccountProvider *")] IWebAccountProvider* webAccountProvider, HSTRING userName, [NativeTypeName("ABI::Windows::Security::Credentials::WebAccountState")] WebAccountState state, [NativeTypeName("ABI::Windows::Security::Credentials::IWebAccount **")] IWebAccount** instance);
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

        [NativeTypeName("HRESULT (ABI::Windows::Security::Credentials::IWebAccountProvider *, HSTRING, ABI::Windows::Security::Credentials::WebAccountState, ABI::Windows::Security::Credentials::IWebAccount **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IWebAccountProvider*, HSTRING, WebAccountState, IWebAccount**, int> CreateWebAccount;
    }
}
