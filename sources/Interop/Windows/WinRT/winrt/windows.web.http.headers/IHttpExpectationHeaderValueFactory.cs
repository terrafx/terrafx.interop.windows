// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.web.http.headers.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IHttpExpectationHeaderValueFactory.xml' path='doc/member[@name="IHttpExpectationHeaderValueFactory"]/*' />
[Guid("4EA275CB-D53E-4868-8856-1E21A5030DC0")]
[NativeTypeName("struct IHttpExpectationHeaderValueFactory : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IHttpExpectationHeaderValueFactory : IHttpExpectationHeaderValueFactory.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IHttpExpectationHeaderValueFactory);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpExpectationHeaderValueFactory*, Guid*, void**, int>)(lpVtbl[0]))((IHttpExpectationHeaderValueFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpExpectationHeaderValueFactory*, uint>)(lpVtbl[1]))((IHttpExpectationHeaderValueFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpExpectationHeaderValueFactory*, uint>)(lpVtbl[2]))((IHttpExpectationHeaderValueFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpExpectationHeaderValueFactory*, uint*, Guid**, int>)(lpVtbl[3]))((IHttpExpectationHeaderValueFactory*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpExpectationHeaderValueFactory*, HSTRING*, int>)(lpVtbl[4]))((IHttpExpectationHeaderValueFactory*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpExpectationHeaderValueFactory*, TrustLevel*, int>)(lpVtbl[5]))((IHttpExpectationHeaderValueFactory*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IHttpExpectationHeaderValueFactory.xml' path='doc/member[@name="IHttpExpectationHeaderValueFactory.CreateFromName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateFromName(HSTRING name, [NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpExpectationHeaderValue **")] IHttpExpectationHeaderValue** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpExpectationHeaderValueFactory*, HSTRING, IHttpExpectationHeaderValue**, int>)(lpVtbl[6]))((IHttpExpectationHeaderValueFactory*)Unsafe.AsPointer(ref this), name, value);
    }

    /// <include file='IHttpExpectationHeaderValueFactory.xml' path='doc/member[@name="IHttpExpectationHeaderValueFactory.CreateFromNameWithValue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateFromNameWithValue(HSTRING name, HSTRING value, [NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpExpectationHeaderValue **")] IHttpExpectationHeaderValue** expectationHeaderValue)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpExpectationHeaderValueFactory*, HSTRING, HSTRING, IHttpExpectationHeaderValue**, int>)(lpVtbl[7]))((IHttpExpectationHeaderValueFactory*)Unsafe.AsPointer(ref this), name, value, expectationHeaderValue);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateFromName(HSTRING name, [NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpExpectationHeaderValue **")] IHttpExpectationHeaderValue** value);

        [VtblIndex(7)]
        HRESULT CreateFromNameWithValue(HSTRING name, HSTRING value, [NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpExpectationHeaderValue **")] IHttpExpectationHeaderValue** expectationHeaderValue);
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

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Web::Http::Headers::IHttpExpectationHeaderValue **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IHttpExpectationHeaderValue**, int> CreateFromName;

        [NativeTypeName("HRESULT (HSTRING, HSTRING, ABI::Windows::Web::Http::Headers::IHttpExpectationHeaderValue **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, HSTRING, IHttpExpectationHeaderValue**, int> CreateFromNameWithValue;
    }
}
