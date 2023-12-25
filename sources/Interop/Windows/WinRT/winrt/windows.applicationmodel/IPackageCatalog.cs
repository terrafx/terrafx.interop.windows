// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IPackageCatalog.xml' path='doc/member[@name="IPackageCatalog"]/*' />
[Guid("230A3751-9DE3-4445-BE74-91FB325ABEFE")]
[NativeTypeName("struct IPackageCatalog : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPackageCatalog : IPackageCatalog.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPackageCatalog));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IPackageCatalog*, Guid*, void**, int>)(lpVtbl[0]))((IPackageCatalog*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPackageCatalog*, uint>)(lpVtbl[1]))((IPackageCatalog*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPackageCatalog*, uint>)(lpVtbl[2]))((IPackageCatalog*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IPackageCatalog*, uint*, Guid**, int>)(lpVtbl[3]))((IPackageCatalog*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IPackageCatalog*, HSTRING*, int>)(lpVtbl[4]))((IPackageCatalog*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IPackageCatalog*, TrustLevel*, int>)(lpVtbl[5]))((IPackageCatalog*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IPackageCatalog.xml' path='doc/member[@name="IPackageCatalog.add_PackageStaging"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT add_PackageStaging([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CPackageCatalog_Windows__CApplicationModel__CPackageStagingEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IPackageCatalog*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[6]))((IPackageCatalog*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IPackageCatalog.xml' path='doc/member[@name="IPackageCatalog.remove_PackageStaging"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT remove_PackageStaging(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IPackageCatalog*, EventRegistrationToken, int>)(lpVtbl[7]))((IPackageCatalog*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IPackageCatalog.xml' path='doc/member[@name="IPackageCatalog.add_PackageInstalling"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT add_PackageInstalling([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CPackageCatalog_Windows__CApplicationModel__CPackageInstallingEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IPackageCatalog*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[8]))((IPackageCatalog*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IPackageCatalog.xml' path='doc/member[@name="IPackageCatalog.remove_PackageInstalling"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT remove_PackageInstalling(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IPackageCatalog*, EventRegistrationToken, int>)(lpVtbl[9]))((IPackageCatalog*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IPackageCatalog.xml' path='doc/member[@name="IPackageCatalog.add_PackageUpdating"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT add_PackageUpdating([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CPackageCatalog_Windows__CApplicationModel__CPackageUpdatingEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IPackageCatalog*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[10]))((IPackageCatalog*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IPackageCatalog.xml' path='doc/member[@name="IPackageCatalog.remove_PackageUpdating"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT remove_PackageUpdating(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IPackageCatalog*, EventRegistrationToken, int>)(lpVtbl[11]))((IPackageCatalog*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IPackageCatalog.xml' path='doc/member[@name="IPackageCatalog.add_PackageUninstalling"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT add_PackageUninstalling([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CPackageCatalog_Windows__CApplicationModel__CPackageUninstallingEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IPackageCatalog*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[12]))((IPackageCatalog*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IPackageCatalog.xml' path='doc/member[@name="IPackageCatalog.remove_PackageUninstalling"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT remove_PackageUninstalling(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IPackageCatalog*, EventRegistrationToken, int>)(lpVtbl[13]))((IPackageCatalog*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IPackageCatalog.xml' path='doc/member[@name="IPackageCatalog.add_PackageStatusChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT add_PackageStatusChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CPackageCatalog_Windows__CApplicationModel__CPackageStatusChangedEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IPackageCatalog*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[14]))((IPackageCatalog*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IPackageCatalog.xml' path='doc/member[@name="IPackageCatalog.remove_PackageStatusChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT remove_PackageStatusChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IPackageCatalog*, EventRegistrationToken, int>)(lpVtbl[15]))((IPackageCatalog*)Unsafe.AsPointer(ref this), token);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT add_PackageStaging([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CPackageCatalog_Windows__CApplicationModel__CPackageStagingEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, EventRegistrationToken* token);

        [VtblIndex(7)]
        HRESULT remove_PackageStaging(EventRegistrationToken token);

        [VtblIndex(8)]
        HRESULT add_PackageInstalling([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CPackageCatalog_Windows__CApplicationModel__CPackageInstallingEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, EventRegistrationToken* token);

        [VtblIndex(9)]
        HRESULT remove_PackageInstalling(EventRegistrationToken token);

        [VtblIndex(10)]
        HRESULT add_PackageUpdating([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CPackageCatalog_Windows__CApplicationModel__CPackageUpdatingEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, EventRegistrationToken* token);

        [VtblIndex(11)]
        HRESULT remove_PackageUpdating(EventRegistrationToken token);

        [VtblIndex(12)]
        HRESULT add_PackageUninstalling([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CPackageCatalog_Windows__CApplicationModel__CPackageUninstallingEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, EventRegistrationToken* token);

        [VtblIndex(13)]
        HRESULT remove_PackageUninstalling(EventRegistrationToken token);

        [VtblIndex(14)]
        HRESULT add_PackageStatusChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CPackageCatalog_Windows__CApplicationModel__CPackageStatusChangedEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, EventRegistrationToken* token);

        [VtblIndex(15)]
        HRESULT remove_PackageStatusChanged(EventRegistrationToken token);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CPackageCatalog_Windows__CApplicationModel__CPackageStagingEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int> add_PackageStaging;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_PackageStaging;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CPackageCatalog_Windows__CApplicationModel__CPackageInstallingEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int> add_PackageInstalling;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_PackageInstalling;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CPackageCatalog_Windows__CApplicationModel__CPackageUpdatingEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int> add_PackageUpdating;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_PackageUpdating;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CPackageCatalog_Windows__CApplicationModel__CPackageUninstallingEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int> add_PackageUninstalling;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_PackageUninstalling;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CPackageCatalog_Windows__CApplicationModel__CPackageStatusChangedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int> add_PackageStatusChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_PackageStatusChanged;
    }
}
