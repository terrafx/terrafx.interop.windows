// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.data.json.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IJsonValueStatics.xml' path='doc/member[@name="IJsonValueStatics"]/*' />
[Guid("5F6B544A-2F53-48E1-91A3-F78B50A6345C")]
[NativeTypeName("struct IJsonValueStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IJsonValueStatics : IJsonValueStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IJsonValueStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IJsonValueStatics*, Guid*, void**, int>)(lpVtbl[0]))((IJsonValueStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IJsonValueStatics*, uint>)(lpVtbl[1]))((IJsonValueStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IJsonValueStatics*, uint>)(lpVtbl[2]))((IJsonValueStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IJsonValueStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IJsonValueStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IJsonValueStatics*, HSTRING*, int>)(lpVtbl[4]))((IJsonValueStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IJsonValueStatics*, TrustLevel*, int>)(lpVtbl[5]))((IJsonValueStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IJsonValueStatics.xml' path='doc/member[@name="IJsonValueStatics.Parse"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Parse(HSTRING input, [NativeTypeName("ABI::Windows::Data::Json::IJsonValue **")] IJsonValue** jsonValue)
    {
        return ((delegate* unmanaged[MemberFunction]<IJsonValueStatics*, HSTRING, IJsonValue**, int>)(lpVtbl[6]))((IJsonValueStatics*)Unsafe.AsPointer(ref this), input, jsonValue);
    }

    /// <include file='IJsonValueStatics.xml' path='doc/member[@name="IJsonValueStatics.TryParse"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT TryParse(HSTRING input, [NativeTypeName("ABI::Windows::Data::Json::IJsonValue **")] IJsonValue** result, [NativeTypeName("boolean *")] byte* succeeded)
    {
        return ((delegate* unmanaged[MemberFunction]<IJsonValueStatics*, HSTRING, IJsonValue**, byte*, int>)(lpVtbl[7]))((IJsonValueStatics*)Unsafe.AsPointer(ref this), input, result, succeeded);
    }

    /// <include file='IJsonValueStatics.xml' path='doc/member[@name="IJsonValueStatics.CreateBooleanValue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CreateBooleanValue([NativeTypeName("boolean")] byte input, [NativeTypeName("ABI::Windows::Data::Json::IJsonValue **")] IJsonValue** jsonValue)
    {
        return ((delegate* unmanaged[MemberFunction]<IJsonValueStatics*, byte, IJsonValue**, int>)(lpVtbl[8]))((IJsonValueStatics*)Unsafe.AsPointer(ref this), input, jsonValue);
    }

    /// <include file='IJsonValueStatics.xml' path='doc/member[@name="IJsonValueStatics.CreateNumberValue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT CreateNumberValue(double input, [NativeTypeName("ABI::Windows::Data::Json::IJsonValue **")] IJsonValue** jsonValue)
    {
        return ((delegate* unmanaged[MemberFunction]<IJsonValueStatics*, double, IJsonValue**, int>)(lpVtbl[9]))((IJsonValueStatics*)Unsafe.AsPointer(ref this), input, jsonValue);
    }

    /// <include file='IJsonValueStatics.xml' path='doc/member[@name="IJsonValueStatics.CreateStringValue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT CreateStringValue(HSTRING input, [NativeTypeName("ABI::Windows::Data::Json::IJsonValue **")] IJsonValue** jsonValue)
    {
        return ((delegate* unmanaged[MemberFunction]<IJsonValueStatics*, HSTRING, IJsonValue**, int>)(lpVtbl[10]))((IJsonValueStatics*)Unsafe.AsPointer(ref this), input, jsonValue);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT Parse(HSTRING input, [NativeTypeName("ABI::Windows::Data::Json::IJsonValue **")] IJsonValue** jsonValue);

        [VtblIndex(7)]
        HRESULT TryParse(HSTRING input, [NativeTypeName("ABI::Windows::Data::Json::IJsonValue **")] IJsonValue** result, [NativeTypeName("boolean *")] byte* succeeded);

        [VtblIndex(8)]
        HRESULT CreateBooleanValue([NativeTypeName("boolean")] byte input, [NativeTypeName("ABI::Windows::Data::Json::IJsonValue **")] IJsonValue** jsonValue);

        [VtblIndex(9)]
        HRESULT CreateNumberValue(double input, [NativeTypeName("ABI::Windows::Data::Json::IJsonValue **")] IJsonValue** jsonValue);

        [VtblIndex(10)]
        HRESULT CreateStringValue(HSTRING input, [NativeTypeName("ABI::Windows::Data::Json::IJsonValue **")] IJsonValue** jsonValue);
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

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Data::Json::IJsonValue **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IJsonValue**, int> Parse;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Data::Json::IJsonValue **, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IJsonValue**, byte*, int> TryParse;

        [NativeTypeName("HRESULT (boolean, ABI::Windows::Data::Json::IJsonValue **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, IJsonValue**, int> CreateBooleanValue;

        [NativeTypeName("HRESULT (DOUBLE, ABI::Windows::Data::Json::IJsonValue **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double, IJsonValue**, int> CreateNumberValue;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Data::Json::IJsonValue **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IJsonValue**, int> CreateStringValue;
    }
}
