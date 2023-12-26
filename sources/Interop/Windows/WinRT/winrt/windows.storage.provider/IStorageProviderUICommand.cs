// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.provider.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IStorageProviderUICommand.xml' path='doc/member[@name="IStorageProviderUICommand"]/*' />
[Guid("0C3E0760-D846-568F-9484-105CC57B502B")]
[NativeTypeName("struct IStorageProviderUICommand : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IStorageProviderUICommand : IStorageProviderUICommand.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IStorageProviderUICommand));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderUICommand*, Guid*, void**, int>)(lpVtbl[0]))((IStorageProviderUICommand*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderUICommand*, uint>)(lpVtbl[1]))((IStorageProviderUICommand*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderUICommand*, uint>)(lpVtbl[2]))((IStorageProviderUICommand*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderUICommand*, uint*, Guid**, int>)(lpVtbl[3]))((IStorageProviderUICommand*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderUICommand*, HSTRING*, int>)(lpVtbl[4]))((IStorageProviderUICommand*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderUICommand*, TrustLevel*, int>)(lpVtbl[5]))((IStorageProviderUICommand*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IStorageProviderUICommand.xml' path='doc/member[@name="IStorageProviderUICommand.get_Label"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Label(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderUICommand*, HSTRING*, int>)(lpVtbl[6]))((IStorageProviderUICommand*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStorageProviderUICommand.xml' path='doc/member[@name="IStorageProviderUICommand.get_Description"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Description(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderUICommand*, HSTRING*, int>)(lpVtbl[7]))((IStorageProviderUICommand*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStorageProviderUICommand.xml' path='doc/member[@name="IStorageProviderUICommand.get_Icon"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Icon([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass **")] IUriRuntimeClass** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderUICommand*, IUriRuntimeClass**, int>)(lpVtbl[8]))((IStorageProviderUICommand*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStorageProviderUICommand.xml' path='doc/member[@name="IStorageProviderUICommand.get_State"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_State([NativeTypeName("ABI::Windows::Storage::Provider::StorageProviderUICommandState *")] StorageProviderUICommandState* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderUICommand*, StorageProviderUICommandState*, int>)(lpVtbl[9]))((IStorageProviderUICommand*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStorageProviderUICommand.xml' path='doc/member[@name="IStorageProviderUICommand.Invoke"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT Invoke()
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderUICommand*, int>)(lpVtbl[10]))((IStorageProviderUICommand*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Label(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_Description(HSTRING* value);

        [VtblIndex(8)]
        HRESULT get_Icon([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass **")] IUriRuntimeClass** value);

        [VtblIndex(9)]
        HRESULT get_State([NativeTypeName("ABI::Windows::Storage::Provider::StorageProviderUICommandState *")] StorageProviderUICommandState* value);

        [VtblIndex(10)]
        HRESULT Invoke();
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

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Label;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Description;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IUriRuntimeClass **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUriRuntimeClass**, int> get_Icon;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Provider::StorageProviderUICommandState *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, StorageProviderUICommandState*, int> get_State;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Invoke;
    }
}
