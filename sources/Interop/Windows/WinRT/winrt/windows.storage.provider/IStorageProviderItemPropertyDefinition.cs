// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.provider.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IStorageProviderItemPropertyDefinition.xml' path='doc/member[@name="IStorageProviderItemPropertyDefinition"]/*' />
[Guid("C5B383BB-FF1F-4298-831E-FF1C08089690")]
[NativeTypeName("struct IStorageProviderItemPropertyDefinition : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IStorageProviderItemPropertyDefinition : IStorageProviderItemPropertyDefinition.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IStorageProviderItemPropertyDefinition));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderItemPropertyDefinition*, Guid*, void**, int>)(lpVtbl[0]))((IStorageProviderItemPropertyDefinition*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderItemPropertyDefinition*, uint>)(lpVtbl[1]))((IStorageProviderItemPropertyDefinition*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderItemPropertyDefinition*, uint>)(lpVtbl[2]))((IStorageProviderItemPropertyDefinition*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderItemPropertyDefinition*, uint*, Guid**, int>)(lpVtbl[3]))((IStorageProviderItemPropertyDefinition*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderItemPropertyDefinition*, HSTRING*, int>)(lpVtbl[4]))((IStorageProviderItemPropertyDefinition*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderItemPropertyDefinition*, TrustLevel*, int>)(lpVtbl[5]))((IStorageProviderItemPropertyDefinition*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IStorageProviderItemPropertyDefinition.xml' path='doc/member[@name="IStorageProviderItemPropertyDefinition.get_Id"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Id([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderItemPropertyDefinition*, int*, int>)(lpVtbl[6]))((IStorageProviderItemPropertyDefinition*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStorageProviderItemPropertyDefinition.xml' path='doc/member[@name="IStorageProviderItemPropertyDefinition.put_Id"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_Id([NativeTypeName("INT32")] int value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderItemPropertyDefinition*, int, int>)(lpVtbl[7]))((IStorageProviderItemPropertyDefinition*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStorageProviderItemPropertyDefinition.xml' path='doc/member[@name="IStorageProviderItemPropertyDefinition.get_DisplayNameResource"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_DisplayNameResource(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderItemPropertyDefinition*, HSTRING*, int>)(lpVtbl[8]))((IStorageProviderItemPropertyDefinition*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStorageProviderItemPropertyDefinition.xml' path='doc/member[@name="IStorageProviderItemPropertyDefinition.put_DisplayNameResource"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_DisplayNameResource(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderItemPropertyDefinition*, HSTRING, int>)(lpVtbl[9]))((IStorageProviderItemPropertyDefinition*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Id([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(7)]
        HRESULT put_Id([NativeTypeName("INT32")] int value);

        [VtblIndex(8)]
        HRESULT get_DisplayNameResource(HSTRING* value);

        [VtblIndex(9)]
        HRESULT put_DisplayNameResource(HSTRING value);
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

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_Id;

        [NativeTypeName("HRESULT (INT32) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, int> put_Id;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_DisplayNameResource;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_DisplayNameResource;
    }
}
