// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.contacts.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IContactLocationField.xml' path='doc/member[@name="IContactLocationField"]/*' />
[Guid("9EC00F82-AB6E-4B36-89E3-B23BC0A1DACC")]
[NativeTypeName("struct IContactLocationField : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IContactLocationField : IContactLocationField.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IContactLocationField);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactLocationField*, Guid*, void**, int>)(lpVtbl[0]))((IContactLocationField*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IContactLocationField*, uint>)(lpVtbl[1]))((IContactLocationField*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IContactLocationField*, uint>)(lpVtbl[2]))((IContactLocationField*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactLocationField*, uint*, Guid**, int>)(lpVtbl[3]))((IContactLocationField*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactLocationField*, HSTRING*, int>)(lpVtbl[4]))((IContactLocationField*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactLocationField*, TrustLevel*, int>)(lpVtbl[5]))((IContactLocationField*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IContactLocationField.xml' path='doc/member[@name="IContactLocationField.get_UnstructuredAddress"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_UnstructuredAddress(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactLocationField*, HSTRING*, int>)(lpVtbl[6]))((IContactLocationField*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactLocationField.xml' path='doc/member[@name="IContactLocationField.get_Street"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Street(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactLocationField*, HSTRING*, int>)(lpVtbl[7]))((IContactLocationField*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactLocationField.xml' path='doc/member[@name="IContactLocationField.get_City"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_City(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactLocationField*, HSTRING*, int>)(lpVtbl[8]))((IContactLocationField*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactLocationField.xml' path='doc/member[@name="IContactLocationField.get_Region"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_Region(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactLocationField*, HSTRING*, int>)(lpVtbl[9]))((IContactLocationField*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactLocationField.xml' path='doc/member[@name="IContactLocationField.get_Country"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Country(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactLocationField*, HSTRING*, int>)(lpVtbl[10]))((IContactLocationField*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactLocationField.xml' path='doc/member[@name="IContactLocationField.get_PostalCode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_PostalCode(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactLocationField*, HSTRING*, int>)(lpVtbl[11]))((IContactLocationField*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_UnstructuredAddress(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_Street(HSTRING* value);

        [VtblIndex(8)]
        HRESULT get_City(HSTRING* value);

        [VtblIndex(9)]
        HRESULT get_Region(HSTRING* value);

        [VtblIndex(10)]
        HRESULT get_Country(HSTRING* value);

        [VtblIndex(11)]
        HRESULT get_PostalCode(HSTRING* value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_UnstructuredAddress;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Street;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_City;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Region;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Country;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_PostalCode;
    }
}
