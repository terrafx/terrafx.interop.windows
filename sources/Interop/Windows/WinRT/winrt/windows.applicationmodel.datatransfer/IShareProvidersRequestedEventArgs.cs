// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.datatransfer.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IShareProvidersRequestedEventArgs.xml' path='doc/member[@name="IShareProvidersRequestedEventArgs"]/*' />
[Guid("F888F356-A3F8-4FCE-85E4-8826E63BE799")]
[NativeTypeName("struct IShareProvidersRequestedEventArgs : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IShareProvidersRequestedEventArgs : IShareProvidersRequestedEventArgs.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IShareProvidersRequestedEventArgs));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IShareProvidersRequestedEventArgs*, Guid*, void**, int>)(lpVtbl[0]))((IShareProvidersRequestedEventArgs*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IShareProvidersRequestedEventArgs*, uint>)(lpVtbl[1]))((IShareProvidersRequestedEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IShareProvidersRequestedEventArgs*, uint>)(lpVtbl[2]))((IShareProvidersRequestedEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IShareProvidersRequestedEventArgs*, uint*, Guid**, int>)(lpVtbl[3]))((IShareProvidersRequestedEventArgs*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IShareProvidersRequestedEventArgs*, HSTRING*, int>)(lpVtbl[4]))((IShareProvidersRequestedEventArgs*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IShareProvidersRequestedEventArgs*, TrustLevel*, int>)(lpVtbl[5]))((IShareProvidersRequestedEventArgs*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IShareProvidersRequestedEventArgs.xml' path='doc/member[@name="IShareProvidersRequestedEventArgs.get_Providers"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Providers([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CApplicationModel__CDataTransfer__CShareProvider_t **")] IVector<IntPtr>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IShareProvidersRequestedEventArgs*, IVector<IntPtr>**, int>)(lpVtbl[6]))((IShareProvidersRequestedEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IShareProvidersRequestedEventArgs.xml' path='doc/member[@name="IShareProvidersRequestedEventArgs.get_Data"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Data([NativeTypeName("ABI::Windows::ApplicationModel::DataTransfer::IDataPackageView **")] IDataPackageView** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IShareProvidersRequestedEventArgs*, IDataPackageView**, int>)(lpVtbl[7]))((IShareProvidersRequestedEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IShareProvidersRequestedEventArgs.xml' path='doc/member[@name="IShareProvidersRequestedEventArgs.GetDeferral"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetDeferral([NativeTypeName("ABI::Windows::Foundation::IDeferral **")] IDeferral** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IShareProvidersRequestedEventArgs*, IDeferral**, int>)(lpVtbl[8]))((IShareProvidersRequestedEventArgs*)Unsafe.AsPointer(ref this), result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Providers([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CApplicationModel__CDataTransfer__CShareProvider_t **")] IVector<IntPtr>** value);

        [VtblIndex(7)]
        HRESULT get_Data([NativeTypeName("ABI::Windows::ApplicationModel::DataTransfer::IDataPackageView **")] IDataPackageView** value);

        [VtblIndex(8)]
        HRESULT GetDeferral([NativeTypeName("ABI::Windows::Foundation::IDeferral **")] IDeferral** result);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CApplicationModel__CDataTransfer__CShareProvider_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVector<IntPtr>**, int> get_Providers;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::DataTransfer::IDataPackageView **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDataPackageView**, int> get_Data;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IDeferral **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDeferral**, int> GetDeferral;
    }
}
