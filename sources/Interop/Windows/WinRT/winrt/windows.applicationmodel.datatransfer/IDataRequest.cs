// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.datatransfer.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IDataRequest.xml' path='doc/member[@name="IDataRequest"]/*' />
[Guid("4341AE3B-FC12-4E53-8C02-AC714C415A27")]
[NativeTypeName("struct IDataRequest : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IDataRequest : IDataRequest.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDataRequest));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IDataRequest*, Guid*, void**, int>)(lpVtbl[0]))((IDataRequest*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IDataRequest*, uint>)(lpVtbl[1]))((IDataRequest*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IDataRequest*, uint>)(lpVtbl[2]))((IDataRequest*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IDataRequest*, uint*, Guid**, int>)(lpVtbl[3]))((IDataRequest*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IDataRequest*, HSTRING*, int>)(lpVtbl[4]))((IDataRequest*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IDataRequest*, TrustLevel*, int>)(lpVtbl[5]))((IDataRequest*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IDataRequest.xml' path='doc/member[@name="IDataRequest.get_Data"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Data([NativeTypeName("ABI::Windows::ApplicationModel::DataTransfer::IDataPackage **")] IDataPackage** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDataRequest*, IDataPackage**, int>)(lpVtbl[6]))((IDataRequest*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDataRequest.xml' path='doc/member[@name="IDataRequest.put_Data"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_Data([NativeTypeName("ABI::Windows::ApplicationModel::DataTransfer::IDataPackage *")] IDataPackage* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDataRequest*, IDataPackage*, int>)(lpVtbl[7]))((IDataRequest*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDataRequest.xml' path='doc/member[@name="IDataRequest.get_Deadline"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Deadline([NativeTypeName("ABI::Windows::Foundation::DateTime *")] DateTime* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDataRequest*, DateTime*, int>)(lpVtbl[8]))((IDataRequest*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDataRequest.xml' path='doc/member[@name="IDataRequest.FailWithDisplayText"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT FailWithDisplayText(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDataRequest*, HSTRING, int>)(lpVtbl[9]))((IDataRequest*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDataRequest.xml' path='doc/member[@name="IDataRequest.GetDeferral"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetDeferral([NativeTypeName("ABI::Windows::ApplicationModel::DataTransfer::IDataRequestDeferral **")] IDataRequestDeferral** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IDataRequest*, IDataRequestDeferral**, int>)(lpVtbl[10]))((IDataRequest*)Unsafe.AsPointer(ref this), result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Data([NativeTypeName("ABI::Windows::ApplicationModel::DataTransfer::IDataPackage **")] IDataPackage** value);

        [VtblIndex(7)]
        HRESULT put_Data([NativeTypeName("ABI::Windows::ApplicationModel::DataTransfer::IDataPackage *")] IDataPackage* value);

        [VtblIndex(8)]
        HRESULT get_Deadline([NativeTypeName("ABI::Windows::Foundation::DateTime *")] DateTime* value);

        [VtblIndex(9)]
        HRESULT FailWithDisplayText(HSTRING value);

        [VtblIndex(10)]
        HRESULT GetDeferral([NativeTypeName("ABI::Windows::ApplicationModel::DataTransfer::IDataRequestDeferral **")] IDataRequestDeferral** result);
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

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::DataTransfer::IDataPackage **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDataPackage**, int> get_Data;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::DataTransfer::IDataPackage *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDataPackage*, int> put_Data;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::DateTime *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, DateTime*, int> get_Deadline;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> FailWithDisplayText;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::DataTransfer::IDataRequestDeferral **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDataRequestDeferral**, int> GetDeferral;
    }
}
