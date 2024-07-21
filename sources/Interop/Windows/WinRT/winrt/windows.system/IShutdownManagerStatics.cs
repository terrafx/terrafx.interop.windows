// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IShutdownManagerStatics.xml' path='doc/member[@name="IShutdownManagerStatics"]/*' />
[Guid("72E247ED-DD5B-4D6C-B1D0-C57A7BBB5F94")]
[NativeTypeName("struct IShutdownManagerStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IShutdownManagerStatics : IShutdownManagerStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IShutdownManagerStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IShutdownManagerStatics*, Guid*, void**, int>)(lpVtbl[0]))((IShutdownManagerStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IShutdownManagerStatics*, uint>)(lpVtbl[1]))((IShutdownManagerStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IShutdownManagerStatics*, uint>)(lpVtbl[2]))((IShutdownManagerStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IShutdownManagerStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IShutdownManagerStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IShutdownManagerStatics*, HSTRING*, int>)(lpVtbl[4]))((IShutdownManagerStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IShutdownManagerStatics*, TrustLevel*, int>)(lpVtbl[5]))((IShutdownManagerStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IShutdownManagerStatics.xml' path='doc/member[@name="IShutdownManagerStatics.BeginShutdown"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT BeginShutdown([NativeTypeName("ABI::Windows::System::ShutdownKind")] ShutdownKind shutdownKind, [NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan timeout)
    {
        return ((delegate* unmanaged[MemberFunction]<IShutdownManagerStatics*, ShutdownKind, TimeSpan, int>)(lpVtbl[6]))((IShutdownManagerStatics*)Unsafe.AsPointer(ref this), shutdownKind, timeout);
    }

    /// <include file='IShutdownManagerStatics.xml' path='doc/member[@name="IShutdownManagerStatics.CancelShutdown"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CancelShutdown()
    {
        return ((delegate* unmanaged[MemberFunction]<IShutdownManagerStatics*, int>)(lpVtbl[7]))((IShutdownManagerStatics*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT BeginShutdown([NativeTypeName("ABI::Windows::System::ShutdownKind")] ShutdownKind shutdownKind, [NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan timeout);

        [VtblIndex(7)]
        HRESULT CancelShutdown();
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

        [NativeTypeName("HRESULT (ABI::Windows::System::ShutdownKind, ABI::Windows::Foundation::TimeSpan) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ShutdownKind, TimeSpan, int> BeginShutdown;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> CancelShutdown;
    }
}
