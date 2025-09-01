// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.remotesystems.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IRemoteSystem.xml' path='doc/member[@name="IRemoteSystem"]/*' />
[Guid("ED5838CD-1E10-4A8C-B4A6-4E5FD6F97721")]
[NativeTypeName("struct IRemoteSystem : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IRemoteSystem : IRemoteSystem.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IRemoteSystem);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystem*, Guid*, void**, int>)(lpVtbl[0]))((IRemoteSystem*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystem*, uint>)(lpVtbl[1]))((IRemoteSystem*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystem*, uint>)(lpVtbl[2]))((IRemoteSystem*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystem*, uint*, Guid**, int>)(lpVtbl[3]))((IRemoteSystem*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystem*, HSTRING*, int>)(lpVtbl[4]))((IRemoteSystem*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystem*, TrustLevel*, int>)(lpVtbl[5]))((IRemoteSystem*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IRemoteSystem.xml' path='doc/member[@name="IRemoteSystem.get_DisplayName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_DisplayName(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystem*, HSTRING*, int>)(lpVtbl[6]))((IRemoteSystem*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IRemoteSystem.xml' path='doc/member[@name="IRemoteSystem.get_Id"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Id(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystem*, HSTRING*, int>)(lpVtbl[7]))((IRemoteSystem*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IRemoteSystem.xml' path='doc/member[@name="IRemoteSystem.get_Kind"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Kind(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystem*, HSTRING*, int>)(lpVtbl[8]))((IRemoteSystem*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IRemoteSystem.xml' path='doc/member[@name="IRemoteSystem.get_Status"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_Status([NativeTypeName("ABI::Windows::System::RemoteSystems::RemoteSystemStatus *")] RemoteSystemStatus* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystem*, RemoteSystemStatus*, int>)(lpVtbl[9]))((IRemoteSystem*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IRemoteSystem.xml' path='doc/member[@name="IRemoteSystem.get_IsAvailableByProximity"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_IsAvailableByProximity([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystem*, byte*, int>)(lpVtbl[10]))((IRemoteSystem*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_DisplayName(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_Id(HSTRING* value);

        [VtblIndex(8)]
        HRESULT get_Kind(HSTRING* value);

        [VtblIndex(9)]
        HRESULT get_Status([NativeTypeName("ABI::Windows::System::RemoteSystems::RemoteSystemStatus *")] RemoteSystemStatus* value);

        [VtblIndex(10)]
        HRESULT get_IsAvailableByProximity([NativeTypeName("boolean *")] byte* value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_DisplayName;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Id;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Kind;

        [NativeTypeName("HRESULT (ABI::Windows::System::RemoteSystems::RemoteSystemStatus *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, RemoteSystemStatus*, int> get_Status;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsAvailableByProximity;
    }
}
