// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.remotesystems.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IRemoteSystemSessionControllerFactory.xml' path='doc/member[@name="IRemoteSystemSessionControllerFactory"]/*' />
[Guid("BFCC2F6B-AC3D-4199-82CD-6670A773EF2E")]
[NativeTypeName("struct IRemoteSystemSessionControllerFactory : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IRemoteSystemSessionControllerFactory : IRemoteSystemSessionControllerFactory.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IRemoteSystemSessionControllerFactory));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemSessionControllerFactory*, Guid*, void**, int>)(lpVtbl[0]))((IRemoteSystemSessionControllerFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemSessionControllerFactory*, uint>)(lpVtbl[1]))((IRemoteSystemSessionControllerFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemSessionControllerFactory*, uint>)(lpVtbl[2]))((IRemoteSystemSessionControllerFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemSessionControllerFactory*, uint*, Guid**, int>)(lpVtbl[3]))((IRemoteSystemSessionControllerFactory*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemSessionControllerFactory*, HSTRING*, int>)(lpVtbl[4]))((IRemoteSystemSessionControllerFactory*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemSessionControllerFactory*, TrustLevel*, int>)(lpVtbl[5]))((IRemoteSystemSessionControllerFactory*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IRemoteSystemSessionControllerFactory.xml' path='doc/member[@name="IRemoteSystemSessionControllerFactory.CreateController"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateController(HSTRING displayName, [NativeTypeName("ABI::Windows::System::RemoteSystems::IRemoteSystemSessionController **")] IRemoteSystemSessionController** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemSessionControllerFactory*, HSTRING, IRemoteSystemSessionController**, int>)(lpVtbl[6]))((IRemoteSystemSessionControllerFactory*)Unsafe.AsPointer(ref this), displayName, value);
    }

    /// <include file='IRemoteSystemSessionControllerFactory.xml' path='doc/member[@name="IRemoteSystemSessionControllerFactory.CreateControllerWithSessionOptions"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateControllerWithSessionOptions(HSTRING displayName, [NativeTypeName("ABI::Windows::System::RemoteSystems::IRemoteSystemSessionOptions *")] IRemoteSystemSessionOptions* options, [NativeTypeName("ABI::Windows::System::RemoteSystems::IRemoteSystemSessionController **")] IRemoteSystemSessionController** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemSessionControllerFactory*, HSTRING, IRemoteSystemSessionOptions*, IRemoteSystemSessionController**, int>)(lpVtbl[7]))((IRemoteSystemSessionControllerFactory*)Unsafe.AsPointer(ref this), displayName, options, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateController(HSTRING displayName, [NativeTypeName("ABI::Windows::System::RemoteSystems::IRemoteSystemSessionController **")] IRemoteSystemSessionController** value);

        [VtblIndex(7)]
        HRESULT CreateControllerWithSessionOptions(HSTRING displayName, [NativeTypeName("ABI::Windows::System::RemoteSystems::IRemoteSystemSessionOptions *")] IRemoteSystemSessionOptions* options, [NativeTypeName("ABI::Windows::System::RemoteSystems::IRemoteSystemSessionController **")] IRemoteSystemSessionController** value);
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

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::System::RemoteSystems::IRemoteSystemSessionController **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IRemoteSystemSessionController**, int> CreateController;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::System::RemoteSystems::IRemoteSystemSessionOptions *, ABI::Windows::System::RemoteSystems::IRemoteSystemSessionController **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IRemoteSystemSessionOptions*, IRemoteSystemSessionController**, int> CreateControllerWithSessionOptions;
    }
}
