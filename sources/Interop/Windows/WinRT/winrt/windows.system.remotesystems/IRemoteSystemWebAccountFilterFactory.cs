// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.remotesystems.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IRemoteSystemWebAccountFilterFactory.xml' path='doc/member[@name="IRemoteSystemWebAccountFilterFactory"]/*' />
[Guid("348A2709-5F4D-5127-B4A7-BF99D5252B1B")]
[NativeTypeName("struct IRemoteSystemWebAccountFilterFactory : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IRemoteSystemWebAccountFilterFactory : IRemoteSystemWebAccountFilterFactory.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IRemoteSystemWebAccountFilterFactory);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemWebAccountFilterFactory*, Guid*, void**, int>)(lpVtbl[0]))((IRemoteSystemWebAccountFilterFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemWebAccountFilterFactory*, uint>)(lpVtbl[1]))((IRemoteSystemWebAccountFilterFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemWebAccountFilterFactory*, uint>)(lpVtbl[2]))((IRemoteSystemWebAccountFilterFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemWebAccountFilterFactory*, uint*, Guid**, int>)(lpVtbl[3]))((IRemoteSystemWebAccountFilterFactory*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemWebAccountFilterFactory*, HSTRING*, int>)(lpVtbl[4]))((IRemoteSystemWebAccountFilterFactory*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemWebAccountFilterFactory*, TrustLevel*, int>)(lpVtbl[5]))((IRemoteSystemWebAccountFilterFactory*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IRemoteSystemWebAccountFilterFactory.xml' path='doc/member[@name="IRemoteSystemWebAccountFilterFactory.Create"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Create([NativeTypeName("ABI::Windows::Security::Credentials::IWebAccount *")] IWebAccount* account, [NativeTypeName("ABI::Windows::System::RemoteSystems::IRemoteSystemWebAccountFilter **")] IRemoteSystemWebAccountFilter** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemWebAccountFilterFactory*, IWebAccount*, IRemoteSystemWebAccountFilter**, int>)(lpVtbl[6]))((IRemoteSystemWebAccountFilterFactory*)Unsafe.AsPointer(ref this), account, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT Create([NativeTypeName("ABI::Windows::Security::Credentials::IWebAccount *")] IWebAccount* account, [NativeTypeName("ABI::Windows::System::RemoteSystems::IRemoteSystemWebAccountFilter **")] IRemoteSystemWebAccountFilter** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Security::Credentials::IWebAccount *, ABI::Windows::System::RemoteSystems::IRemoteSystemWebAccountFilter **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IWebAccount*, IRemoteSystemWebAccountFilter**, int> Create;
    }
}
