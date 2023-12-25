// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.web.http.headers.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IHttpCacheDirectiveHeaderValueCollection.xml' path='doc/member[@name="IHttpCacheDirectiveHeaderValueCollection"]/*' />
[Guid("9A586B89-D5D0-4FBE-BD9D-B5B3636811B4")]
[NativeTypeName("struct IHttpCacheDirectiveHeaderValueCollection : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IHttpCacheDirectiveHeaderValueCollection : IHttpCacheDirectiveHeaderValueCollection.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHttpCacheDirectiveHeaderValueCollection));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpCacheDirectiveHeaderValueCollection*, Guid*, void**, int>)(lpVtbl[0]))((IHttpCacheDirectiveHeaderValueCollection*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpCacheDirectiveHeaderValueCollection*, uint>)(lpVtbl[1]))((IHttpCacheDirectiveHeaderValueCollection*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpCacheDirectiveHeaderValueCollection*, uint>)(lpVtbl[2]))((IHttpCacheDirectiveHeaderValueCollection*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpCacheDirectiveHeaderValueCollection*, uint*, Guid**, int>)(lpVtbl[3]))((IHttpCacheDirectiveHeaderValueCollection*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpCacheDirectiveHeaderValueCollection*, HSTRING*, int>)(lpVtbl[4]))((IHttpCacheDirectiveHeaderValueCollection*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpCacheDirectiveHeaderValueCollection*, TrustLevel*, int>)(lpVtbl[5]))((IHttpCacheDirectiveHeaderValueCollection*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IHttpCacheDirectiveHeaderValueCollection.xml' path='doc/member[@name="IHttpCacheDirectiveHeaderValueCollection.get_MaxAge"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_MaxAge([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t **")] IReference<TimeSpan>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpCacheDirectiveHeaderValueCollection*, IReference<TimeSpan>**, int>)(lpVtbl[6]))((IHttpCacheDirectiveHeaderValueCollection*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHttpCacheDirectiveHeaderValueCollection.xml' path='doc/member[@name="IHttpCacheDirectiveHeaderValueCollection.put_MaxAge"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_MaxAge([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t *")] IReference<TimeSpan>* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpCacheDirectiveHeaderValueCollection*, IReference<TimeSpan>*, int>)(lpVtbl[7]))((IHttpCacheDirectiveHeaderValueCollection*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHttpCacheDirectiveHeaderValueCollection.xml' path='doc/member[@name="IHttpCacheDirectiveHeaderValueCollection.get_MaxStale"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_MaxStale([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t **")] IReference<TimeSpan>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpCacheDirectiveHeaderValueCollection*, IReference<TimeSpan>**, int>)(lpVtbl[8]))((IHttpCacheDirectiveHeaderValueCollection*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHttpCacheDirectiveHeaderValueCollection.xml' path='doc/member[@name="IHttpCacheDirectiveHeaderValueCollection.put_MaxStale"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_MaxStale([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t *")] IReference<TimeSpan>* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpCacheDirectiveHeaderValueCollection*, IReference<TimeSpan>*, int>)(lpVtbl[9]))((IHttpCacheDirectiveHeaderValueCollection*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHttpCacheDirectiveHeaderValueCollection.xml' path='doc/member[@name="IHttpCacheDirectiveHeaderValueCollection.get_MinFresh"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_MinFresh([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t **")] IReference<TimeSpan>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpCacheDirectiveHeaderValueCollection*, IReference<TimeSpan>**, int>)(lpVtbl[10]))((IHttpCacheDirectiveHeaderValueCollection*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHttpCacheDirectiveHeaderValueCollection.xml' path='doc/member[@name="IHttpCacheDirectiveHeaderValueCollection.put_MinFresh"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_MinFresh([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t *")] IReference<TimeSpan>* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpCacheDirectiveHeaderValueCollection*, IReference<TimeSpan>*, int>)(lpVtbl[11]))((IHttpCacheDirectiveHeaderValueCollection*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHttpCacheDirectiveHeaderValueCollection.xml' path='doc/member[@name="IHttpCacheDirectiveHeaderValueCollection.get_SharedMaxAge"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_SharedMaxAge([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t **")] IReference<TimeSpan>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpCacheDirectiveHeaderValueCollection*, IReference<TimeSpan>**, int>)(lpVtbl[12]))((IHttpCacheDirectiveHeaderValueCollection*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHttpCacheDirectiveHeaderValueCollection.xml' path='doc/member[@name="IHttpCacheDirectiveHeaderValueCollection.put_SharedMaxAge"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_SharedMaxAge([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t *")] IReference<TimeSpan>* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpCacheDirectiveHeaderValueCollection*, IReference<TimeSpan>*, int>)(lpVtbl[13]))((IHttpCacheDirectiveHeaderValueCollection*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHttpCacheDirectiveHeaderValueCollection.xml' path='doc/member[@name="IHttpCacheDirectiveHeaderValueCollection.ParseAdd"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT ParseAdd(HSTRING input)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpCacheDirectiveHeaderValueCollection*, HSTRING, int>)(lpVtbl[14]))((IHttpCacheDirectiveHeaderValueCollection*)Unsafe.AsPointer(ref this), input);
    }

    /// <include file='IHttpCacheDirectiveHeaderValueCollection.xml' path='doc/member[@name="IHttpCacheDirectiveHeaderValueCollection.TryParseAdd"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT TryParseAdd(HSTRING input, [NativeTypeName("boolean *")] byte* result)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpCacheDirectiveHeaderValueCollection*, HSTRING, byte*, int>)(lpVtbl[15]))((IHttpCacheDirectiveHeaderValueCollection*)Unsafe.AsPointer(ref this), input, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_MaxAge([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t **")] IReference<TimeSpan>** value);

        [VtblIndex(7)]
        HRESULT put_MaxAge([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t *")] IReference<TimeSpan>* value);

        [VtblIndex(8)]
        HRESULT get_MaxStale([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t **")] IReference<TimeSpan>** value);

        [VtblIndex(9)]
        HRESULT put_MaxStale([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t *")] IReference<TimeSpan>* value);

        [VtblIndex(10)]
        HRESULT get_MinFresh([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t **")] IReference<TimeSpan>** value);

        [VtblIndex(11)]
        HRESULT put_MinFresh([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t *")] IReference<TimeSpan>* value);

        [VtblIndex(12)]
        HRESULT get_SharedMaxAge([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t **")] IReference<TimeSpan>** value);

        [VtblIndex(13)]
        HRESULT put_SharedMaxAge([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t *")] IReference<TimeSpan>* value);

        [VtblIndex(14)]
        HRESULT ParseAdd(HSTRING input);

        [VtblIndex(15)]
        HRESULT TryParseAdd(HSTRING input, [NativeTypeName("boolean *")] byte* result);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<TimeSpan>**, int> get_MaxAge;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<TimeSpan>*, int> put_MaxAge;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<TimeSpan>**, int> get_MaxStale;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<TimeSpan>*, int> put_MaxStale;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<TimeSpan>**, int> get_MinFresh;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<TimeSpan>*, int> put_MinFresh;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<TimeSpan>**, int> get_SharedMaxAge;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<TimeSpan>*, int> put_SharedMaxAge;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> ParseAdd;

        [NativeTypeName("HRESULT (HSTRING, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, byte*, int> TryParseAdd;
    }
}
