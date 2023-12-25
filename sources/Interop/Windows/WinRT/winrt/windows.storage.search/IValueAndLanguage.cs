// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.search.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IValueAndLanguage.xml' path='doc/member[@name="IValueAndLanguage"]/*' />
[Guid("B9914881-A1EE-4BC4-92A5-466968E30436")]
[NativeTypeName("struct IValueAndLanguage : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IValueAndLanguage : IValueAndLanguage.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IValueAndLanguage));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IValueAndLanguage*, Guid*, void**, int>)(lpVtbl[0]))((IValueAndLanguage*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IValueAndLanguage*, uint>)(lpVtbl[1]))((IValueAndLanguage*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IValueAndLanguage*, uint>)(lpVtbl[2]))((IValueAndLanguage*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IValueAndLanguage*, uint*, Guid**, int>)(lpVtbl[3]))((IValueAndLanguage*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IValueAndLanguage*, HSTRING*, int>)(lpVtbl[4]))((IValueAndLanguage*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IValueAndLanguage*, TrustLevel*, int>)(lpVtbl[5]))((IValueAndLanguage*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IValueAndLanguage.xml' path='doc/member[@name="IValueAndLanguage.get_Language"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Language(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IValueAndLanguage*, HSTRING*, int>)(lpVtbl[6]))((IValueAndLanguage*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IValueAndLanguage.xml' path='doc/member[@name="IValueAndLanguage.put_Language"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_Language(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IValueAndLanguage*, HSTRING, int>)(lpVtbl[7]))((IValueAndLanguage*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IValueAndLanguage.xml' path='doc/member[@name="IValueAndLanguage.get_Value"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Value(IInspectable** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IValueAndLanguage*, IInspectable**, int>)(lpVtbl[8]))((IValueAndLanguage*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IValueAndLanguage.xml' path='doc/member[@name="IValueAndLanguage.put_Value"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_Value(IInspectable* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IValueAndLanguage*, IInspectable*, int>)(lpVtbl[9]))((IValueAndLanguage*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Language(HSTRING* value);

        [VtblIndex(7)]
        HRESULT put_Language(HSTRING value);

        [VtblIndex(8)]
        HRESULT get_Value(IInspectable** value);

        [VtblIndex(9)]
        HRESULT put_Value(IInspectable* value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Language;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_Language;

        [NativeTypeName("HRESULT (IInspectable **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IInspectable**, int> get_Value;

        [NativeTypeName("HRESULT (IInspectable *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IInspectable*, int> put_Value;
    }
}
