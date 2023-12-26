// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.provider.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IStorageProviderMoreInfoUI.xml' path='doc/member[@name="IStorageProviderMoreInfoUI"]/*' />
[Guid("EF38E591-A7CB-5E7D-9B5E-22749842697C")]
[NativeTypeName("struct IStorageProviderMoreInfoUI : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IStorageProviderMoreInfoUI : IStorageProviderMoreInfoUI.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IStorageProviderMoreInfoUI));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderMoreInfoUI*, Guid*, void**, int>)(lpVtbl[0]))((IStorageProviderMoreInfoUI*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderMoreInfoUI*, uint>)(lpVtbl[1]))((IStorageProviderMoreInfoUI*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderMoreInfoUI*, uint>)(lpVtbl[2]))((IStorageProviderMoreInfoUI*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderMoreInfoUI*, uint*, Guid**, int>)(lpVtbl[3]))((IStorageProviderMoreInfoUI*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderMoreInfoUI*, HSTRING*, int>)(lpVtbl[4]))((IStorageProviderMoreInfoUI*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderMoreInfoUI*, TrustLevel*, int>)(lpVtbl[5]))((IStorageProviderMoreInfoUI*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IStorageProviderMoreInfoUI.xml' path='doc/member[@name="IStorageProviderMoreInfoUI.get_Message"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Message(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderMoreInfoUI*, HSTRING*, int>)(lpVtbl[6]))((IStorageProviderMoreInfoUI*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStorageProviderMoreInfoUI.xml' path='doc/member[@name="IStorageProviderMoreInfoUI.put_Message"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_Message(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderMoreInfoUI*, HSTRING, int>)(lpVtbl[7]))((IStorageProviderMoreInfoUI*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStorageProviderMoreInfoUI.xml' path='doc/member[@name="IStorageProviderMoreInfoUI.get_Command"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Command([NativeTypeName("ABI::Windows::Storage::Provider::IStorageProviderUICommand **")] IStorageProviderUICommand** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderMoreInfoUI*, IStorageProviderUICommand**, int>)(lpVtbl[8]))((IStorageProviderMoreInfoUI*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStorageProviderMoreInfoUI.xml' path='doc/member[@name="IStorageProviderMoreInfoUI.put_Command"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_Command([NativeTypeName("ABI::Windows::Storage::Provider::IStorageProviderUICommand *")] IStorageProviderUICommand* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderMoreInfoUI*, IStorageProviderUICommand*, int>)(lpVtbl[9]))((IStorageProviderMoreInfoUI*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Message(HSTRING* value);

        [VtblIndex(7)]
        HRESULT put_Message(HSTRING value);

        [VtblIndex(8)]
        HRESULT get_Command([NativeTypeName("ABI::Windows::Storage::Provider::IStorageProviderUICommand **")] IStorageProviderUICommand** value);

        [VtblIndex(9)]
        HRESULT put_Command([NativeTypeName("ABI::Windows::Storage::Provider::IStorageProviderUICommand *")] IStorageProviderUICommand* value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Message;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_Message;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Provider::IStorageProviderUICommand **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStorageProviderUICommand**, int> get_Command;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Provider::IStorageProviderUICommand *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStorageProviderUICommand*, int> put_Command;
    }
}
