// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.email.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IEmailMailboxChangeReader.xml' path='doc/member[@name="IEmailMailboxChangeReader"]/*' />
[Guid("BDBD0EBB-C53D-4331-97BE-BE75A2146A75")]
[NativeTypeName("struct IEmailMailboxChangeReader : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IEmailMailboxChangeReader : IEmailMailboxChangeReader.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IEmailMailboxChangeReader);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailboxChangeReader*, Guid*, void**, int>)(lpVtbl[0]))((IEmailMailboxChangeReader*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailboxChangeReader*, uint>)(lpVtbl[1]))((IEmailMailboxChangeReader*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailboxChangeReader*, uint>)(lpVtbl[2]))((IEmailMailboxChangeReader*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailboxChangeReader*, uint*, Guid**, int>)(lpVtbl[3]))((IEmailMailboxChangeReader*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailboxChangeReader*, HSTRING*, int>)(lpVtbl[4]))((IEmailMailboxChangeReader*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailboxChangeReader*, TrustLevel*, int>)(lpVtbl[5]))((IEmailMailboxChangeReader*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IEmailMailboxChangeReader.xml' path='doc/member[@name="IEmailMailboxChangeReader.AcceptChanges"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT AcceptChanges()
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailboxChangeReader*, int>)(lpVtbl[6]))((IEmailMailboxChangeReader*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IEmailMailboxChangeReader.xml' path='doc/member[@name="IEmailMailboxChangeReader.AcceptChangesThrough"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT AcceptChangesThrough([NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailMailboxChange *")] IEmailMailboxChange* lastChangeToAcknowledge)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailboxChangeReader*, IEmailMailboxChange*, int>)(lpVtbl[7]))((IEmailMailboxChangeReader*)Unsafe.AsPointer(ref this), lastChangeToAcknowledge);
    }

    /// <include file='IEmailMailboxChangeReader.xml' path='doc/member[@name="IEmailMailboxChangeReader.ReadBatchAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT ReadBatchAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CEmail__CEmailMailboxChange_t **")] IAsyncOperation<Pointer<IVectorView<Pointer<IEmailMailboxChange>>>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailboxChangeReader*, IAsyncOperation<Pointer<IVectorView<Pointer<IEmailMailboxChange>>>>**, int>)(lpVtbl[8]))((IEmailMailboxChangeReader*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT AcceptChanges();

        [VtblIndex(7)]
        HRESULT AcceptChangesThrough([NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailMailboxChange *")] IEmailMailboxChange* lastChangeToAcknowledge);

        [VtblIndex(8)]
        HRESULT ReadBatchAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CEmail__CEmailMailboxChange_t **")] IAsyncOperation<Pointer<IVectorView<Pointer<IEmailMailboxChange>>>>** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Email::IEmailMailboxChange *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IEmailMailboxChange*, int> AcceptChangesThrough;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CEmail__CEmailMailboxChange_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<Pointer<IVectorView<Pointer<IEmailMailboxChange>>>>**, int> ReadBatchAsync;
    }
}
