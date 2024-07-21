// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.networking.connectivity.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IConnectionProfileFilter2.xml' path='doc/member[@name="IConnectionProfileFilter2"]/*' />
[Guid("CD068EE1-C3FC-4FAD-9DDC-593FAA4B7885")]
[NativeTypeName("struct IConnectionProfileFilter2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IConnectionProfileFilter2 : IConnectionProfileFilter2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IConnectionProfileFilter2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IConnectionProfileFilter2*, Guid*, void**, int>)(lpVtbl[0]))((IConnectionProfileFilter2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IConnectionProfileFilter2*, uint>)(lpVtbl[1]))((IConnectionProfileFilter2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IConnectionProfileFilter2*, uint>)(lpVtbl[2]))((IConnectionProfileFilter2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IConnectionProfileFilter2*, uint*, Guid**, int>)(lpVtbl[3]))((IConnectionProfileFilter2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IConnectionProfileFilter2*, HSTRING*, int>)(lpVtbl[4]))((IConnectionProfileFilter2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IConnectionProfileFilter2*, TrustLevel*, int>)(lpVtbl[5]))((IConnectionProfileFilter2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IConnectionProfileFilter2.xml' path='doc/member[@name="IConnectionProfileFilter2.put_IsRoaming"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT put_IsRoaming([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_boolean_t *")] IReference<bool>* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IConnectionProfileFilter2*, IReference<bool>*, int>)(lpVtbl[6]))((IConnectionProfileFilter2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IConnectionProfileFilter2.xml' path='doc/member[@name="IConnectionProfileFilter2.get_IsRoaming"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_IsRoaming([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_boolean_t **")] IReference<bool>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IConnectionProfileFilter2*, IReference<bool>**, int>)(lpVtbl[7]))((IConnectionProfileFilter2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IConnectionProfileFilter2.xml' path='doc/member[@name="IConnectionProfileFilter2.put_IsOverDataLimit"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_IsOverDataLimit([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_boolean_t *")] IReference<bool>* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IConnectionProfileFilter2*, IReference<bool>*, int>)(lpVtbl[8]))((IConnectionProfileFilter2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IConnectionProfileFilter2.xml' path='doc/member[@name="IConnectionProfileFilter2.get_IsOverDataLimit"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_IsOverDataLimit([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_boolean_t **")] IReference<bool>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IConnectionProfileFilter2*, IReference<bool>**, int>)(lpVtbl[9]))((IConnectionProfileFilter2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IConnectionProfileFilter2.xml' path='doc/member[@name="IConnectionProfileFilter2.put_IsBackgroundDataUsageRestricted"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT put_IsBackgroundDataUsageRestricted([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_boolean_t *")] IReference<bool>* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IConnectionProfileFilter2*, IReference<bool>*, int>)(lpVtbl[10]))((IConnectionProfileFilter2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IConnectionProfileFilter2.xml' path='doc/member[@name="IConnectionProfileFilter2.get_IsBackgroundDataUsageRestricted"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_IsBackgroundDataUsageRestricted([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_boolean_t **")] IReference<bool>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IConnectionProfileFilter2*, IReference<bool>**, int>)(lpVtbl[11]))((IConnectionProfileFilter2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IConnectionProfileFilter2.xml' path='doc/member[@name="IConnectionProfileFilter2.get_RawData"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_RawData([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IConnectionProfileFilter2*, IBuffer**, int>)(lpVtbl[12]))((IConnectionProfileFilter2*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT put_IsRoaming([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_boolean_t *")] IReference<bool>* value);

        [VtblIndex(7)]
        HRESULT get_IsRoaming([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_boolean_t **")] IReference<bool>** value);

        [VtblIndex(8)]
        HRESULT put_IsOverDataLimit([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_boolean_t *")] IReference<bool>* value);

        [VtblIndex(9)]
        HRESULT get_IsOverDataLimit([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_boolean_t **")] IReference<bool>** value);

        [VtblIndex(10)]
        HRESULT put_IsBackgroundDataUsageRestricted([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_boolean_t *")] IReference<bool>* value);

        [VtblIndex(11)]
        HRESULT get_IsBackgroundDataUsageRestricted([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_boolean_t **")] IReference<bool>** value);

        [VtblIndex(12)]
        HRESULT get_RawData([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_boolean_t *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<bool>*, int> put_IsRoaming;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_boolean_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<bool>**, int> get_IsRoaming;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_boolean_t *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<bool>*, int> put_IsOverDataLimit;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_boolean_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<bool>**, int> get_IsOverDataLimit;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_boolean_t *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<bool>*, int> put_IsBackgroundDataUsageRestricted;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_boolean_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<bool>**, int> get_IsBackgroundDataUsageRestricted;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IBuffer **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBuffer**, int> get_RawData;
    }
}
