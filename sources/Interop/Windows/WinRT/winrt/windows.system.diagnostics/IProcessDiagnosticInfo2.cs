// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.diagnostics.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IProcessDiagnosticInfo2.xml' path='doc/member[@name="IProcessDiagnosticInfo2"]/*' />
[Guid("9558CB1A-3D0B-49EC-AB70-4F7A112805DE")]
[NativeTypeName("struct IProcessDiagnosticInfo2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IProcessDiagnosticInfo2 : IProcessDiagnosticInfo2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IProcessDiagnosticInfo2);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IProcessDiagnosticInfo2*, Guid*, void**, int>)(lpVtbl[0]))((IProcessDiagnosticInfo2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IProcessDiagnosticInfo2*, uint>)(lpVtbl[1]))((IProcessDiagnosticInfo2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IProcessDiagnosticInfo2*, uint>)(lpVtbl[2]))((IProcessDiagnosticInfo2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IProcessDiagnosticInfo2*, uint*, Guid**, int>)(lpVtbl[3]))((IProcessDiagnosticInfo2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IProcessDiagnosticInfo2*, HSTRING*, int>)(lpVtbl[4]))((IProcessDiagnosticInfo2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IProcessDiagnosticInfo2*, TrustLevel*, int>)(lpVtbl[5]))((IProcessDiagnosticInfo2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IProcessDiagnosticInfo2.xml' path='doc/member[@name="IProcessDiagnosticInfo2.GetAppDiagnosticInfos"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetAppDiagnosticInfos([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CSystem__CAppDiagnosticInfo_t **")] IVector<Pointer<IAppDiagnosticInfo>>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IProcessDiagnosticInfo2*, IVector<Pointer<IAppDiagnosticInfo>>**, int>)(lpVtbl[6]))((IProcessDiagnosticInfo2*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IProcessDiagnosticInfo2.xml' path='doc/member[@name="IProcessDiagnosticInfo2.get_IsPackaged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_IsPackaged([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IProcessDiagnosticInfo2*, byte*, int>)(lpVtbl[7]))((IProcessDiagnosticInfo2*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetAppDiagnosticInfos([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CSystem__CAppDiagnosticInfo_t **")] IVector<Pointer<IAppDiagnosticInfo>>** result);

        [VtblIndex(7)]
        HRESULT get_IsPackaged([NativeTypeName("boolean *")] byte* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CSystem__CAppDiagnosticInfo_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVector<Pointer<IAppDiagnosticInfo>>**, int> GetAppDiagnosticInfos;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsPackaged;
    }
}
