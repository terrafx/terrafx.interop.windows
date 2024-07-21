// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IPackageInstallingEventArgs.xml' path='doc/member[@name="IPackageInstallingEventArgs"]/*' />
[Guid("97741EB7-AB7A-401A-8B61-EB0E7FAFF237")]
[NativeTypeName("struct IPackageInstallingEventArgs : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPackageInstallingEventArgs : IPackageInstallingEventArgs.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPackageInstallingEventArgs));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IPackageInstallingEventArgs*, Guid*, void**, int>)(lpVtbl[0]))((IPackageInstallingEventArgs*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPackageInstallingEventArgs*, uint>)(lpVtbl[1]))((IPackageInstallingEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPackageInstallingEventArgs*, uint>)(lpVtbl[2]))((IPackageInstallingEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IPackageInstallingEventArgs*, uint*, Guid**, int>)(lpVtbl[3]))((IPackageInstallingEventArgs*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IPackageInstallingEventArgs*, HSTRING*, int>)(lpVtbl[4]))((IPackageInstallingEventArgs*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IPackageInstallingEventArgs*, TrustLevel*, int>)(lpVtbl[5]))((IPackageInstallingEventArgs*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IPackageInstallingEventArgs.xml' path='doc/member[@name="IPackageInstallingEventArgs.get_ActivityId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_ActivityId(Guid* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPackageInstallingEventArgs*, Guid*, int>)(lpVtbl[6]))((IPackageInstallingEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPackageInstallingEventArgs.xml' path='doc/member[@name="IPackageInstallingEventArgs.get_Package"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Package([NativeTypeName("ABI::Windows::ApplicationModel::IPackage **")] IPackage** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPackageInstallingEventArgs*, IPackage**, int>)(lpVtbl[7]))((IPackageInstallingEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPackageInstallingEventArgs.xml' path='doc/member[@name="IPackageInstallingEventArgs.get_Progress"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Progress(double* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPackageInstallingEventArgs*, double*, int>)(lpVtbl[8]))((IPackageInstallingEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPackageInstallingEventArgs.xml' path='doc/member[@name="IPackageInstallingEventArgs.get_IsComplete"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_IsComplete([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPackageInstallingEventArgs*, byte*, int>)(lpVtbl[9]))((IPackageInstallingEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPackageInstallingEventArgs.xml' path='doc/member[@name="IPackageInstallingEventArgs.get_ErrorCode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_ErrorCode(HRESULT* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPackageInstallingEventArgs*, HRESULT*, int>)(lpVtbl[10]))((IPackageInstallingEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_ActivityId(Guid* value);

        [VtblIndex(7)]
        HRESULT get_Package([NativeTypeName("ABI::Windows::ApplicationModel::IPackage **")] IPackage** value);

        [VtblIndex(8)]
        HRESULT get_Progress(double* value);

        [VtblIndex(9)]
        HRESULT get_IsComplete([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(10)]
        HRESULT get_ErrorCode(HRESULT* value);
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

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> get_ActivityId;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::IPackage **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IPackage**, int> get_Package;

        [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double*, int> get_Progress;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsComplete;

        [NativeTypeName("HRESULT (HRESULT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HRESULT*, int> get_ErrorCode;
    }
}
