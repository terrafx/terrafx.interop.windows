// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.contacts.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IContactName.xml' path='doc/member[@name="IContactName"]/*' />
[Guid("F404E97B-9034-453C-8EBF-140A38C86F1D")]
[NativeTypeName("struct IContactName : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IContactName : IContactName.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IContactName));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactName*, Guid*, void**, int>)(lpVtbl[0]))((IContactName*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IContactName*, uint>)(lpVtbl[1]))((IContactName*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IContactName*, uint>)(lpVtbl[2]))((IContactName*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactName*, uint*, Guid**, int>)(lpVtbl[3]))((IContactName*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactName*, HSTRING*, int>)(lpVtbl[4]))((IContactName*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactName*, TrustLevel*, int>)(lpVtbl[5]))((IContactName*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IContactName.xml' path='doc/member[@name="IContactName.get_FirstName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_FirstName(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactName*, HSTRING*, int>)(lpVtbl[6]))((IContactName*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactName.xml' path='doc/member[@name="IContactName.put_FirstName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_FirstName(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactName*, HSTRING, int>)(lpVtbl[7]))((IContactName*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactName.xml' path='doc/member[@name="IContactName.get_LastName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_LastName(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactName*, HSTRING*, int>)(lpVtbl[8]))((IContactName*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactName.xml' path='doc/member[@name="IContactName.put_LastName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_LastName(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactName*, HSTRING, int>)(lpVtbl[9]))((IContactName*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactName.xml' path='doc/member[@name="IContactName.get_MiddleName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_MiddleName(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactName*, HSTRING*, int>)(lpVtbl[10]))((IContactName*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactName.xml' path='doc/member[@name="IContactName.put_MiddleName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_MiddleName(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactName*, HSTRING, int>)(lpVtbl[11]))((IContactName*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactName.xml' path='doc/member[@name="IContactName.get_YomiGivenName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_YomiGivenName(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactName*, HSTRING*, int>)(lpVtbl[12]))((IContactName*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactName.xml' path='doc/member[@name="IContactName.put_YomiGivenName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_YomiGivenName(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactName*, HSTRING, int>)(lpVtbl[13]))((IContactName*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactName.xml' path='doc/member[@name="IContactName.get_YomiFamilyName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_YomiFamilyName(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactName*, HSTRING*, int>)(lpVtbl[14]))((IContactName*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactName.xml' path='doc/member[@name="IContactName.put_YomiFamilyName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_YomiFamilyName(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactName*, HSTRING, int>)(lpVtbl[15]))((IContactName*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactName.xml' path='doc/member[@name="IContactName.get_HonorificNameSuffix"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_HonorificNameSuffix(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactName*, HSTRING*, int>)(lpVtbl[16]))((IContactName*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactName.xml' path='doc/member[@name="IContactName.put_HonorificNameSuffix"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT put_HonorificNameSuffix(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactName*, HSTRING, int>)(lpVtbl[17]))((IContactName*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactName.xml' path='doc/member[@name="IContactName.get_HonorificNamePrefix"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_HonorificNamePrefix(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactName*, HSTRING*, int>)(lpVtbl[18]))((IContactName*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactName.xml' path='doc/member[@name="IContactName.put_HonorificNamePrefix"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT put_HonorificNamePrefix(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactName*, HSTRING, int>)(lpVtbl[19]))((IContactName*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactName.xml' path='doc/member[@name="IContactName.get_DisplayName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_DisplayName(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactName*, HSTRING*, int>)(lpVtbl[20]))((IContactName*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactName.xml' path='doc/member[@name="IContactName.get_YomiDisplayName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT get_YomiDisplayName(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactName*, HSTRING*, int>)(lpVtbl[21]))((IContactName*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_FirstName(HSTRING* value);

        [VtblIndex(7)]
        HRESULT put_FirstName(HSTRING value);

        [VtblIndex(8)]
        HRESULT get_LastName(HSTRING* value);

        [VtblIndex(9)]
        HRESULT put_LastName(HSTRING value);

        [VtblIndex(10)]
        HRESULT get_MiddleName(HSTRING* value);

        [VtblIndex(11)]
        HRESULT put_MiddleName(HSTRING value);

        [VtblIndex(12)]
        HRESULT get_YomiGivenName(HSTRING* value);

        [VtblIndex(13)]
        HRESULT put_YomiGivenName(HSTRING value);

        [VtblIndex(14)]
        HRESULT get_YomiFamilyName(HSTRING* value);

        [VtblIndex(15)]
        HRESULT put_YomiFamilyName(HSTRING value);

        [VtblIndex(16)]
        HRESULT get_HonorificNameSuffix(HSTRING* value);

        [VtblIndex(17)]
        HRESULT put_HonorificNameSuffix(HSTRING value);

        [VtblIndex(18)]
        HRESULT get_HonorificNamePrefix(HSTRING* value);

        [VtblIndex(19)]
        HRESULT put_HonorificNamePrefix(HSTRING value);

        [VtblIndex(20)]
        HRESULT get_DisplayName(HSTRING* value);

        [VtblIndex(21)]
        HRESULT get_YomiDisplayName(HSTRING* value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_FirstName;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_FirstName;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_LastName;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_LastName;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_MiddleName;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_MiddleName;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_YomiGivenName;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_YomiGivenName;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_YomiFamilyName;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_YomiFamilyName;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_HonorificNameSuffix;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_HonorificNameSuffix;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_HonorificNamePrefix;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_HonorificNamePrefix;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_DisplayName;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_YomiDisplayName;
    }
}
