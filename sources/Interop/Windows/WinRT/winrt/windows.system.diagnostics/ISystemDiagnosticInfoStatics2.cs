// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.diagnostics.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ISystemDiagnosticInfoStatics2.xml' path='doc/member[@name="ISystemDiagnosticInfoStatics2"]/*' />
[Guid("79DED189-6AF9-4DA9-A422-15F73255B3EB")]
[NativeTypeName("struct ISystemDiagnosticInfoStatics2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISystemDiagnosticInfoStatics2 : ISystemDiagnosticInfoStatics2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISystemDiagnosticInfoStatics2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemDiagnosticInfoStatics2*, Guid*, void**, int>)(lpVtbl[0]))((ISystemDiagnosticInfoStatics2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemDiagnosticInfoStatics2*, uint>)(lpVtbl[1]))((ISystemDiagnosticInfoStatics2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemDiagnosticInfoStatics2*, uint>)(lpVtbl[2]))((ISystemDiagnosticInfoStatics2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemDiagnosticInfoStatics2*, uint*, Guid**, int>)(lpVtbl[3]))((ISystemDiagnosticInfoStatics2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemDiagnosticInfoStatics2*, HSTRING*, int>)(lpVtbl[4]))((ISystemDiagnosticInfoStatics2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemDiagnosticInfoStatics2*, TrustLevel*, int>)(lpVtbl[5]))((ISystemDiagnosticInfoStatics2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ISystemDiagnosticInfoStatics2.xml' path='doc/member[@name="ISystemDiagnosticInfoStatics2.IsArchitectureSupported"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT IsArchitectureSupported([NativeTypeName("ABI::Windows::System::ProcessorArchitecture")] ProcessorArchitecture type, [NativeTypeName("boolean *")] byte* result)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemDiagnosticInfoStatics2*, ProcessorArchitecture, byte*, int>)(lpVtbl[6]))((ISystemDiagnosticInfoStatics2*)Unsafe.AsPointer(ref this), type, result);
    }

    /// <include file='ISystemDiagnosticInfoStatics2.xml' path='doc/member[@name="ISystemDiagnosticInfoStatics2.get_PreferredArchitecture"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_PreferredArchitecture([NativeTypeName("ABI::Windows::System::ProcessorArchitecture *")] ProcessorArchitecture* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemDiagnosticInfoStatics2*, ProcessorArchitecture*, int>)(lpVtbl[7]))((ISystemDiagnosticInfoStatics2*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT IsArchitectureSupported([NativeTypeName("ABI::Windows::System::ProcessorArchitecture")] ProcessorArchitecture type, [NativeTypeName("boolean *")] byte* result);

        [VtblIndex(7)]
        HRESULT get_PreferredArchitecture([NativeTypeName("ABI::Windows::System::ProcessorArchitecture *")] ProcessorArchitecture* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::System::ProcessorArchitecture, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ProcessorArchitecture, byte*, int> IsArchitectureSupported;

        [NativeTypeName("HRESULT (ABI::Windows::System::ProcessorArchitecture *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ProcessorArchitecture*, int> get_PreferredArchitecture;
    }
}
