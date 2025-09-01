// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IPackageContentGroupStagingEventArgs.xml' path='doc/member[@name="IPackageContentGroupStagingEventArgs"]/*' />
[Guid("3D7BC27E-6F27-446C-986E-D4733D4D9113")]
[NativeTypeName("struct IPackageContentGroupStagingEventArgs : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPackageContentGroupStagingEventArgs : IPackageContentGroupStagingEventArgs.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IPackageContentGroupStagingEventArgs);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IPackageContentGroupStagingEventArgs*, Guid*, void**, int>)(lpVtbl[0]))((IPackageContentGroupStagingEventArgs*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPackageContentGroupStagingEventArgs*, uint>)(lpVtbl[1]))((IPackageContentGroupStagingEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPackageContentGroupStagingEventArgs*, uint>)(lpVtbl[2]))((IPackageContentGroupStagingEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IPackageContentGroupStagingEventArgs*, uint*, Guid**, int>)(lpVtbl[3]))((IPackageContentGroupStagingEventArgs*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IPackageContentGroupStagingEventArgs*, HSTRING*, int>)(lpVtbl[4]))((IPackageContentGroupStagingEventArgs*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IPackageContentGroupStagingEventArgs*, TrustLevel*, int>)(lpVtbl[5]))((IPackageContentGroupStagingEventArgs*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IPackageContentGroupStagingEventArgs.xml' path='doc/member[@name="IPackageContentGroupStagingEventArgs.get_ActivityId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_ActivityId(Guid* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPackageContentGroupStagingEventArgs*, Guid*, int>)(lpVtbl[6]))((IPackageContentGroupStagingEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPackageContentGroupStagingEventArgs.xml' path='doc/member[@name="IPackageContentGroupStagingEventArgs.get_Package"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Package([NativeTypeName("ABI::Windows::ApplicationModel::IPackage **")] IPackage** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPackageContentGroupStagingEventArgs*, IPackage**, int>)(lpVtbl[7]))((IPackageContentGroupStagingEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPackageContentGroupStagingEventArgs.xml' path='doc/member[@name="IPackageContentGroupStagingEventArgs.get_Progress"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Progress(double* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPackageContentGroupStagingEventArgs*, double*, int>)(lpVtbl[8]))((IPackageContentGroupStagingEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPackageContentGroupStagingEventArgs.xml' path='doc/member[@name="IPackageContentGroupStagingEventArgs.get_IsComplete"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_IsComplete([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPackageContentGroupStagingEventArgs*, byte*, int>)(lpVtbl[9]))((IPackageContentGroupStagingEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPackageContentGroupStagingEventArgs.xml' path='doc/member[@name="IPackageContentGroupStagingEventArgs.get_ErrorCode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_ErrorCode(HRESULT* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPackageContentGroupStagingEventArgs*, HRESULT*, int>)(lpVtbl[10]))((IPackageContentGroupStagingEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPackageContentGroupStagingEventArgs.xml' path='doc/member[@name="IPackageContentGroupStagingEventArgs.get_ContentGroupName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_ContentGroupName(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPackageContentGroupStagingEventArgs*, HSTRING*, int>)(lpVtbl[11]))((IPackageContentGroupStagingEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPackageContentGroupStagingEventArgs.xml' path='doc/member[@name="IPackageContentGroupStagingEventArgs.get_IsContentGroupRequired"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_IsContentGroupRequired([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPackageContentGroupStagingEventArgs*, byte*, int>)(lpVtbl[12]))((IPackageContentGroupStagingEventArgs*)Unsafe.AsPointer(ref this), value);
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

        [VtblIndex(11)]
        HRESULT get_ContentGroupName(HSTRING* value);

        [VtblIndex(12)]
        HRESULT get_IsContentGroupRequired([NativeTypeName("boolean *")] byte* value);
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

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_ContentGroupName;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsContentGroupRequired;
    }
}
