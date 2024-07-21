// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.web.http.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IHttpCookie.xml' path='doc/member[@name="IHttpCookie"]/*' />
[Guid("1F5488E2-CC2D-4779-86A7-88F10687D249")]
[NativeTypeName("struct IHttpCookie : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IHttpCookie : IHttpCookie.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHttpCookie));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpCookie*, Guid*, void**, int>)(lpVtbl[0]))((IHttpCookie*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpCookie*, uint>)(lpVtbl[1]))((IHttpCookie*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpCookie*, uint>)(lpVtbl[2]))((IHttpCookie*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpCookie*, uint*, Guid**, int>)(lpVtbl[3]))((IHttpCookie*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpCookie*, HSTRING*, int>)(lpVtbl[4]))((IHttpCookie*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpCookie*, TrustLevel*, int>)(lpVtbl[5]))((IHttpCookie*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IHttpCookie.xml' path='doc/member[@name="IHttpCookie.get_Name"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Name(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpCookie*, HSTRING*, int>)(lpVtbl[6]))((IHttpCookie*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHttpCookie.xml' path='doc/member[@name="IHttpCookie.get_Domain"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Domain(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpCookie*, HSTRING*, int>)(lpVtbl[7]))((IHttpCookie*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHttpCookie.xml' path='doc/member[@name="IHttpCookie.get_Path"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Path(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpCookie*, HSTRING*, int>)(lpVtbl[8]))((IHttpCookie*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHttpCookie.xml' path='doc/member[@name="IHttpCookie.get_Expires"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_Expires([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t **")] IReference<DateTime>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpCookie*, IReference<DateTime>**, int>)(lpVtbl[9]))((IHttpCookie*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHttpCookie.xml' path='doc/member[@name="IHttpCookie.put_Expires"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT put_Expires([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t *")] IReference<DateTime>* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpCookie*, IReference<DateTime>*, int>)(lpVtbl[10]))((IHttpCookie*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHttpCookie.xml' path='doc/member[@name="IHttpCookie.get_HttpOnly"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_HttpOnly([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpCookie*, byte*, int>)(lpVtbl[11]))((IHttpCookie*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHttpCookie.xml' path='doc/member[@name="IHttpCookie.put_HttpOnly"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT put_HttpOnly([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpCookie*, byte, int>)(lpVtbl[12]))((IHttpCookie*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHttpCookie.xml' path='doc/member[@name="IHttpCookie.get_Secure"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_Secure([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpCookie*, byte*, int>)(lpVtbl[13]))((IHttpCookie*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHttpCookie.xml' path='doc/member[@name="IHttpCookie.put_Secure"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT put_Secure([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpCookie*, byte, int>)(lpVtbl[14]))((IHttpCookie*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHttpCookie.xml' path='doc/member[@name="IHttpCookie.get_Value"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_Value(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpCookie*, HSTRING*, int>)(lpVtbl[15]))((IHttpCookie*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHttpCookie.xml' path='doc/member[@name="IHttpCookie.put_Value"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT put_Value(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpCookie*, HSTRING, int>)(lpVtbl[16]))((IHttpCookie*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Name(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_Domain(HSTRING* value);

        [VtblIndex(8)]
        HRESULT get_Path(HSTRING* value);

        [VtblIndex(9)]
        HRESULT get_Expires([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t **")] IReference<DateTime>** value);

        [VtblIndex(10)]
        HRESULT put_Expires([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t *")] IReference<DateTime>* value);

        [VtblIndex(11)]
        HRESULT get_HttpOnly([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(12)]
        HRESULT put_HttpOnly([NativeTypeName("boolean")] byte value);

        [VtblIndex(13)]
        HRESULT get_Secure([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(14)]
        HRESULT put_Secure([NativeTypeName("boolean")] byte value);

        [VtblIndex(15)]
        HRESULT get_Value(HSTRING* value);

        [VtblIndex(16)]
        HRESULT put_Value(HSTRING value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Name;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Domain;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Path;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<DateTime>**, int> get_Expires;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<DateTime>*, int> put_Expires;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_HttpOnly;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_HttpOnly;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_Secure;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_Secure;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Value;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_Value;
    }
}
