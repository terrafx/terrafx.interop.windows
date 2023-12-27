// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAppDiagnosticInfo2.xml' path='doc/member[@name="IAppDiagnosticInfo2"]/*' />
[Guid("DF46FBD7-191A-446C-9473-8FBC2374A354")]
[NativeTypeName("struct IAppDiagnosticInfo2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAppDiagnosticInfo2 : IAppDiagnosticInfo2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppDiagnosticInfo2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppDiagnosticInfo2*, Guid*, void**, int>)(lpVtbl[0]))((IAppDiagnosticInfo2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppDiagnosticInfo2*, uint>)(lpVtbl[1]))((IAppDiagnosticInfo2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppDiagnosticInfo2*, uint>)(lpVtbl[2]))((IAppDiagnosticInfo2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppDiagnosticInfo2*, uint*, Guid**, int>)(lpVtbl[3]))((IAppDiagnosticInfo2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppDiagnosticInfo2*, HSTRING*, int>)(lpVtbl[4]))((IAppDiagnosticInfo2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppDiagnosticInfo2*, TrustLevel*, int>)(lpVtbl[5]))((IAppDiagnosticInfo2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAppDiagnosticInfo2.xml' path='doc/member[@name="IAppDiagnosticInfo2.GetResourceGroups"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetResourceGroups([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CSystem__CAppResourceGroupInfo_t **")] IVector<Pointer<IAppResourceGroupInfo>>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppDiagnosticInfo2*, IVector<Pointer<IAppResourceGroupInfo>>**, int>)(lpVtbl[6]))((IAppDiagnosticInfo2*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IAppDiagnosticInfo2.xml' path='doc/member[@name="IAppDiagnosticInfo2.CreateResourceGroupWatcher"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateResourceGroupWatcher([NativeTypeName("ABI::Windows::System::IAppResourceGroupInfoWatcher **")] IAppResourceGroupInfoWatcher** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppDiagnosticInfo2*, IAppResourceGroupInfoWatcher**, int>)(lpVtbl[7]))((IAppDiagnosticInfo2*)Unsafe.AsPointer(ref this), result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetResourceGroups([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CSystem__CAppResourceGroupInfo_t **")] IVector<Pointer<IAppResourceGroupInfo>>** result);

        [VtblIndex(7)]
        HRESULT CreateResourceGroupWatcher([NativeTypeName("ABI::Windows::System::IAppResourceGroupInfoWatcher **")] IAppResourceGroupInfoWatcher** result);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CSystem__CAppResourceGroupInfo_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVector<Pointer<IAppResourceGroupInfo>>**, int> GetResourceGroups;

        [NativeTypeName("HRESULT (ABI::Windows::System::IAppResourceGroupInfoWatcher **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAppResourceGroupInfoWatcher**, int> CreateResourceGroupWatcher;
    }
}
