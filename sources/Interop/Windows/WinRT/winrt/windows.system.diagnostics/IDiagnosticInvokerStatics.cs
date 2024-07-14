// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.diagnostics.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IDiagnosticInvokerStatics.xml' path='doc/member[@name="IDiagnosticInvokerStatics"]/*' />
[Guid("5CFAD8DE-F15C-4554-A813-C113C3881B09")]
[NativeTypeName("struct IDiagnosticInvokerStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IDiagnosticInvokerStatics : IDiagnosticInvokerStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDiagnosticInvokerStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiagnosticInvokerStatics*, Guid*, void**, int>)(lpVtbl[0]))((IDiagnosticInvokerStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IDiagnosticInvokerStatics*, uint>)(lpVtbl[1]))((IDiagnosticInvokerStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IDiagnosticInvokerStatics*, uint>)(lpVtbl[2]))((IDiagnosticInvokerStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiagnosticInvokerStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IDiagnosticInvokerStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiagnosticInvokerStatics*, HSTRING*, int>)(lpVtbl[4]))((IDiagnosticInvokerStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiagnosticInvokerStatics*, TrustLevel*, int>)(lpVtbl[5]))((IDiagnosticInvokerStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IDiagnosticInvokerStatics.xml' path='doc/member[@name="IDiagnosticInvokerStatics.GetDefault"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetDefault([NativeTypeName("ABI::Windows::System::Diagnostics::IDiagnosticInvoker **")] IDiagnosticInvoker** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiagnosticInvokerStatics*, IDiagnosticInvoker**, int>)(lpVtbl[6]))((IDiagnosticInvokerStatics*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IDiagnosticInvokerStatics.xml' path='doc/member[@name="IDiagnosticInvokerStatics.GetForUser"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetForUser([NativeTypeName("ABI::Windows::System::IUser *")] IUser* user, [NativeTypeName("ABI::Windows::System::Diagnostics::IDiagnosticInvoker **")] IDiagnosticInvoker** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiagnosticInvokerStatics*, IUser*, IDiagnosticInvoker**, int>)(lpVtbl[7]))((IDiagnosticInvokerStatics*)Unsafe.AsPointer(ref this), user, result);
    }

    /// <include file='IDiagnosticInvokerStatics.xml' path='doc/member[@name="IDiagnosticInvokerStatics.get_IsSupported"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_IsSupported([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiagnosticInvokerStatics*, byte*, int>)(lpVtbl[8]))((IDiagnosticInvokerStatics*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetDefault([NativeTypeName("ABI::Windows::System::Diagnostics::IDiagnosticInvoker **")] IDiagnosticInvoker** result);

        [VtblIndex(7)]
        HRESULT GetForUser([NativeTypeName("ABI::Windows::System::IUser *")] IUser* user, [NativeTypeName("ABI::Windows::System::Diagnostics::IDiagnosticInvoker **")] IDiagnosticInvoker** result);

        [VtblIndex(8)]
        HRESULT get_IsSupported([NativeTypeName("boolean *")] byte* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::System::Diagnostics::IDiagnosticInvoker **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDiagnosticInvoker**, int> GetDefault;

        [NativeTypeName("HRESULT (ABI::Windows::System::IUser *, ABI::Windows::System::Diagnostics::IDiagnosticInvoker **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUser*, IDiagnosticInvoker**, int> GetForUser;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsSupported;
    }
}
