// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.data.json.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IJsonValue.xml' path='doc/member[@name="IJsonValue"]/*' />
[Guid("A3219ECB-F0B3-4DCD-BEEE-19D48CD3ED1E")]
[NativeTypeName("struct IJsonValue : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IJsonValue : IJsonValue.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IJsonValue);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IJsonValue*, Guid*, void**, int>)(lpVtbl[0]))((IJsonValue*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IJsonValue*, uint>)(lpVtbl[1]))((IJsonValue*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IJsonValue*, uint>)(lpVtbl[2]))((IJsonValue*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IJsonValue*, uint*, Guid**, int>)(lpVtbl[3]))((IJsonValue*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IJsonValue*, HSTRING*, int>)(lpVtbl[4]))((IJsonValue*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IJsonValue*, TrustLevel*, int>)(lpVtbl[5]))((IJsonValue*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IJsonValue.xml' path='doc/member[@name="IJsonValue.get_ValueType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_ValueType([NativeTypeName("ABI::Windows::Data::Json::JsonValueType *")] JsonValueType* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IJsonValue*, JsonValueType*, int>)(lpVtbl[6]))((IJsonValue*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IJsonValue.xml' path='doc/member[@name="IJsonValue.Stringify"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT Stringify(HSTRING* returnValue)
    {
        return ((delegate* unmanaged[MemberFunction]<IJsonValue*, HSTRING*, int>)(lpVtbl[7]))((IJsonValue*)Unsafe.AsPointer(ref this), returnValue);
    }

    /// <include file='IJsonValue.xml' path='doc/member[@name="IJsonValue.GetString"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetString(HSTRING* returnValue)
    {
        return ((delegate* unmanaged[MemberFunction]<IJsonValue*, HSTRING*, int>)(lpVtbl[8]))((IJsonValue*)Unsafe.AsPointer(ref this), returnValue);
    }

    /// <include file='IJsonValue.xml' path='doc/member[@name="IJsonValue.GetNumber"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetNumber(double* returnValue)
    {
        return ((delegate* unmanaged[MemberFunction]<IJsonValue*, double*, int>)(lpVtbl[9]))((IJsonValue*)Unsafe.AsPointer(ref this), returnValue);
    }

    /// <include file='IJsonValue.xml' path='doc/member[@name="IJsonValue.GetBoolean"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetBoolean([NativeTypeName("boolean *")] byte* returnValue)
    {
        return ((delegate* unmanaged[MemberFunction]<IJsonValue*, byte*, int>)(lpVtbl[10]))((IJsonValue*)Unsafe.AsPointer(ref this), returnValue);
    }

    /// <include file='IJsonValue.xml' path='doc/member[@name="IJsonValue.GetArray"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetArray([NativeTypeName("ABI::Windows::Data::Json::IJsonArray **")] IJsonArray** returnValue)
    {
        return ((delegate* unmanaged[MemberFunction]<IJsonValue*, IJsonArray**, int>)(lpVtbl[11]))((IJsonValue*)Unsafe.AsPointer(ref this), returnValue);
    }

    /// <include file='IJsonValue.xml' path='doc/member[@name="IJsonValue.GetObjectW"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetObjectW([NativeTypeName("ABI::Windows::Data::Json::IJsonObject **")] IJsonObject** returnValue)
    {
        return ((delegate* unmanaged[MemberFunction]<IJsonValue*, IJsonObject**, int>)(lpVtbl[12]))((IJsonValue*)Unsafe.AsPointer(ref this), returnValue);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_ValueType([NativeTypeName("ABI::Windows::Data::Json::JsonValueType *")] JsonValueType* value);

        [VtblIndex(7)]
        HRESULT Stringify(HSTRING* returnValue);

        [VtblIndex(8)]
        HRESULT GetString(HSTRING* returnValue);

        [VtblIndex(9)]
        HRESULT GetNumber(double* returnValue);

        [VtblIndex(10)]
        HRESULT GetBoolean([NativeTypeName("boolean *")] byte* returnValue);

        [VtblIndex(11)]
        HRESULT GetArray([NativeTypeName("ABI::Windows::Data::Json::IJsonArray **")] IJsonArray** returnValue);

        [VtblIndex(12)]
        HRESULT GetObjectW([NativeTypeName("ABI::Windows::Data::Json::IJsonObject **")] IJsonObject** returnValue);
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

        [NativeTypeName("HRESULT (ABI::Windows::Data::Json::JsonValueType *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, JsonValueType*, int> get_ValueType;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> Stringify;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> GetString;

        [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double*, int> GetNumber;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> GetBoolean;

        [NativeTypeName("HRESULT (ABI::Windows::Data::Json::IJsonArray **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IJsonArray**, int> GetArray;

        [NativeTypeName("HRESULT (ABI::Windows::Data::Json::IJsonObject **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IJsonObject**, int> GetObjectW;
    }
}
