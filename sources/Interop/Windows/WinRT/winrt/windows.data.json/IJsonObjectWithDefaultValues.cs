// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.data.json.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IJsonObjectWithDefaultValues.xml' path='doc/member[@name="IJsonObjectWithDefaultValues"]/*' />
[Guid("D960D2A2-B7F0-4F00-8E44-D82CF415EA13")]
[NativeTypeName("struct IJsonObjectWithDefaultValues : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IJsonObjectWithDefaultValues : IJsonObjectWithDefaultValues.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IJsonObjectWithDefaultValues);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IJsonObjectWithDefaultValues*, Guid*, void**, int>)(lpVtbl[0]))((IJsonObjectWithDefaultValues*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IJsonObjectWithDefaultValues*, uint>)(lpVtbl[1]))((IJsonObjectWithDefaultValues*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IJsonObjectWithDefaultValues*, uint>)(lpVtbl[2]))((IJsonObjectWithDefaultValues*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IJsonObjectWithDefaultValues*, uint*, Guid**, int>)(lpVtbl[3]))((IJsonObjectWithDefaultValues*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IJsonObjectWithDefaultValues*, HSTRING*, int>)(lpVtbl[4]))((IJsonObjectWithDefaultValues*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IJsonObjectWithDefaultValues*, TrustLevel*, int>)(lpVtbl[5]))((IJsonObjectWithDefaultValues*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IJsonObjectWithDefaultValues.xml' path='doc/member[@name="IJsonObjectWithDefaultValues.GetNamedValueOrDefault"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetNamedValueOrDefault(HSTRING name, [NativeTypeName("ABI::Windows::Data::Json::IJsonValue *")] IJsonValue* defaultValue, [NativeTypeName("ABI::Windows::Data::Json::IJsonValue **")] IJsonValue** returnValue)
    {
        return ((delegate* unmanaged[MemberFunction]<IJsonObjectWithDefaultValues*, HSTRING, IJsonValue*, IJsonValue**, int>)(lpVtbl[6]))((IJsonObjectWithDefaultValues*)Unsafe.AsPointer(ref this), name, defaultValue, returnValue);
    }

    /// <include file='IJsonObjectWithDefaultValues.xml' path='doc/member[@name="IJsonObjectWithDefaultValues.GetNamedObjectOrDefault"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetNamedObjectOrDefault(HSTRING name, [NativeTypeName("ABI::Windows::Data::Json::IJsonObject *")] IJsonObject* defaultValue, [NativeTypeName("ABI::Windows::Data::Json::IJsonObject **")] IJsonObject** returnValue)
    {
        return ((delegate* unmanaged[MemberFunction]<IJsonObjectWithDefaultValues*, HSTRING, IJsonObject*, IJsonObject**, int>)(lpVtbl[7]))((IJsonObjectWithDefaultValues*)Unsafe.AsPointer(ref this), name, defaultValue, returnValue);
    }

    /// <include file='IJsonObjectWithDefaultValues.xml' path='doc/member[@name="IJsonObjectWithDefaultValues.GetNamedStringOrDefault"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetNamedStringOrDefault(HSTRING name, HSTRING defaultValue, HSTRING* returnValue)
    {
        return ((delegate* unmanaged[MemberFunction]<IJsonObjectWithDefaultValues*, HSTRING, HSTRING, HSTRING*, int>)(lpVtbl[8]))((IJsonObjectWithDefaultValues*)Unsafe.AsPointer(ref this), name, defaultValue, returnValue);
    }

    /// <include file='IJsonObjectWithDefaultValues.xml' path='doc/member[@name="IJsonObjectWithDefaultValues.GetNamedArrayOrDefault"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetNamedArrayOrDefault(HSTRING name, [NativeTypeName("ABI::Windows::Data::Json::IJsonArray *")] IJsonArray* defaultValue, [NativeTypeName("ABI::Windows::Data::Json::IJsonArray **")] IJsonArray** returnValue)
    {
        return ((delegate* unmanaged[MemberFunction]<IJsonObjectWithDefaultValues*, HSTRING, IJsonArray*, IJsonArray**, int>)(lpVtbl[9]))((IJsonObjectWithDefaultValues*)Unsafe.AsPointer(ref this), name, defaultValue, returnValue);
    }

    /// <include file='IJsonObjectWithDefaultValues.xml' path='doc/member[@name="IJsonObjectWithDefaultValues.GetNamedNumberOrDefault"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetNamedNumberOrDefault(HSTRING name, double defaultValue, double* returnValue)
    {
        return ((delegate* unmanaged[MemberFunction]<IJsonObjectWithDefaultValues*, HSTRING, double, double*, int>)(lpVtbl[10]))((IJsonObjectWithDefaultValues*)Unsafe.AsPointer(ref this), name, defaultValue, returnValue);
    }

    /// <include file='IJsonObjectWithDefaultValues.xml' path='doc/member[@name="IJsonObjectWithDefaultValues.GetNamedBooleanOrDefault"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetNamedBooleanOrDefault(HSTRING name, [NativeTypeName("boolean")] byte defaultValue, [NativeTypeName("boolean *")] byte* returnValue)
    {
        return ((delegate* unmanaged[MemberFunction]<IJsonObjectWithDefaultValues*, HSTRING, byte, byte*, int>)(lpVtbl[11]))((IJsonObjectWithDefaultValues*)Unsafe.AsPointer(ref this), name, defaultValue, returnValue);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetNamedValueOrDefault(HSTRING name, [NativeTypeName("ABI::Windows::Data::Json::IJsonValue *")] IJsonValue* defaultValue, [NativeTypeName("ABI::Windows::Data::Json::IJsonValue **")] IJsonValue** returnValue);

        [VtblIndex(7)]
        HRESULT GetNamedObjectOrDefault(HSTRING name, [NativeTypeName("ABI::Windows::Data::Json::IJsonObject *")] IJsonObject* defaultValue, [NativeTypeName("ABI::Windows::Data::Json::IJsonObject **")] IJsonObject** returnValue);

        [VtblIndex(8)]
        HRESULT GetNamedStringOrDefault(HSTRING name, HSTRING defaultValue, HSTRING* returnValue);

        [VtblIndex(9)]
        HRESULT GetNamedArrayOrDefault(HSTRING name, [NativeTypeName("ABI::Windows::Data::Json::IJsonArray *")] IJsonArray* defaultValue, [NativeTypeName("ABI::Windows::Data::Json::IJsonArray **")] IJsonArray** returnValue);

        [VtblIndex(10)]
        HRESULT GetNamedNumberOrDefault(HSTRING name, double defaultValue, double* returnValue);

        [VtblIndex(11)]
        HRESULT GetNamedBooleanOrDefault(HSTRING name, [NativeTypeName("boolean")] byte defaultValue, [NativeTypeName("boolean *")] byte* returnValue);
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

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Data::Json::IJsonValue *, ABI::Windows::Data::Json::IJsonValue **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IJsonValue*, IJsonValue**, int> GetNamedValueOrDefault;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Data::Json::IJsonObject *, ABI::Windows::Data::Json::IJsonObject **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IJsonObject*, IJsonObject**, int> GetNamedObjectOrDefault;

        [NativeTypeName("HRESULT (HSTRING, HSTRING, HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, HSTRING, HSTRING*, int> GetNamedStringOrDefault;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Data::Json::IJsonArray *, ABI::Windows::Data::Json::IJsonArray **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IJsonArray*, IJsonArray**, int> GetNamedArrayOrDefault;

        [NativeTypeName("HRESULT (HSTRING, DOUBLE, DOUBLE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, double, double*, int> GetNamedNumberOrDefault;

        [NativeTypeName("HRESULT (HSTRING, boolean, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, byte, byte*, int> GetNamedBooleanOrDefault;
    }
}
