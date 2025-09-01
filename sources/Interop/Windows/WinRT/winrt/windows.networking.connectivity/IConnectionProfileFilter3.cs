// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.networking.connectivity.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IConnectionProfileFilter3.xml' path='doc/member[@name="IConnectionProfileFilter3"]/*' />
[Guid("0AAA09C0-5014-447C-8809-AEE4CB0AF94A")]
[NativeTypeName("struct IConnectionProfileFilter3 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IConnectionProfileFilter3 : IConnectionProfileFilter3.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IConnectionProfileFilter3);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IConnectionProfileFilter3*, Guid*, void**, int>)(lpVtbl[0]))((IConnectionProfileFilter3*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IConnectionProfileFilter3*, uint>)(lpVtbl[1]))((IConnectionProfileFilter3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IConnectionProfileFilter3*, uint>)(lpVtbl[2]))((IConnectionProfileFilter3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IConnectionProfileFilter3*, uint*, Guid**, int>)(lpVtbl[3]))((IConnectionProfileFilter3*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IConnectionProfileFilter3*, HSTRING*, int>)(lpVtbl[4]))((IConnectionProfileFilter3*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IConnectionProfileFilter3*, TrustLevel*, int>)(lpVtbl[5]))((IConnectionProfileFilter3*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IConnectionProfileFilter3.xml' path='doc/member[@name="IConnectionProfileFilter3.put_PurposeGuid"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT put_PurposeGuid([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_GUID_t *")] IReference<Guid>* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IConnectionProfileFilter3*, IReference<Guid>*, int>)(lpVtbl[6]))((IConnectionProfileFilter3*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IConnectionProfileFilter3.xml' path='doc/member[@name="IConnectionProfileFilter3.get_PurposeGuid"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_PurposeGuid([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_GUID_t **")] IReference<Guid>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IConnectionProfileFilter3*, IReference<Guid>**, int>)(lpVtbl[7]))((IConnectionProfileFilter3*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT put_PurposeGuid([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_GUID_t *")] IReference<Guid>* value);

        [VtblIndex(7)]
        HRESULT get_PurposeGuid([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_GUID_t **")] IReference<Guid>** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_GUID_t *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<Guid>*, int> put_PurposeGuid;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_GUID_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<Guid>**, int> get_PurposeGuid;
    }
}
