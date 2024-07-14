// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.contacts.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IContactChangeReader.xml' path='doc/member[@name="IContactChangeReader"]/*' />
[Guid("217319FA-2D0C-42E0-A9DA-3ECD56A78A47")]
[NativeTypeName("struct IContactChangeReader : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IContactChangeReader : IContactChangeReader.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IContactChangeReader));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactChangeReader*, Guid*, void**, int>)(lpVtbl[0]))((IContactChangeReader*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IContactChangeReader*, uint>)(lpVtbl[1]))((IContactChangeReader*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IContactChangeReader*, uint>)(lpVtbl[2]))((IContactChangeReader*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactChangeReader*, uint*, Guid**, int>)(lpVtbl[3]))((IContactChangeReader*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactChangeReader*, HSTRING*, int>)(lpVtbl[4]))((IContactChangeReader*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactChangeReader*, TrustLevel*, int>)(lpVtbl[5]))((IContactChangeReader*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IContactChangeReader.xml' path='doc/member[@name="IContactChangeReader.AcceptChanges"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT AcceptChanges()
    {
        return ((delegate* unmanaged[MemberFunction]<IContactChangeReader*, int>)(lpVtbl[6]))((IContactChangeReader*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IContactChangeReader.xml' path='doc/member[@name="IContactChangeReader.AcceptChangesThrough"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT AcceptChangesThrough([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContactChange *")] IContactChange* lastChangeToAccept)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactChangeReader*, IContactChange*, int>)(lpVtbl[7]))((IContactChangeReader*)Unsafe.AsPointer(ref this), lastChangeToAccept);
    }

    /// <include file='IContactChangeReader.xml' path='doc/member[@name="IContactChangeReader.ReadBatchAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT ReadBatchAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CContacts__CContactChange_t **")] IAsyncOperation<Pointer<IVectorView<Pointer<IContactChange>>>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactChangeReader*, IAsyncOperation<Pointer<IVectorView<Pointer<IContactChange>>>>**, int>)(lpVtbl[8]))((IContactChangeReader*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT AcceptChanges();

        [VtblIndex(7)]
        HRESULT AcceptChangesThrough([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContactChange *")] IContactChange* lastChangeToAccept);

        [VtblIndex(8)]
        HRESULT ReadBatchAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CContacts__CContactChange_t **")] IAsyncOperation<Pointer<IVectorView<Pointer<IContactChange>>>>** value);
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

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> AcceptChanges;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Contacts::IContactChange *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IContactChange*, int> AcceptChangesThrough;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CContacts__CContactChange_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<Pointer<IVectorView<Pointer<IContactChange>>>>**, int> ReadBatchAsync;
    }
}
