// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.data.json.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IJsonObject.xml' path='doc/member[@name="IJsonObject"]/*' />
[Guid("064E24DD-29C2-4F83-9AC1-9EE11578BEB3")]
[NativeTypeName("struct IJsonObject : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IJsonObject : IJsonObject.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IJsonObject));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IJsonObject*, Guid*, void**, int>)(lpVtbl[0]))((IJsonObject*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IJsonObject*, uint>)(lpVtbl[1]))((IJsonObject*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IJsonObject*, uint>)(lpVtbl[2]))((IJsonObject*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IJsonObject*, uint*, Guid**, int>)(lpVtbl[3]))((IJsonObject*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IJsonObject*, HSTRING*, int>)(lpVtbl[4]))((IJsonObject*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IJsonObject*, TrustLevel*, int>)(lpVtbl[5]))((IJsonObject*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IJsonObject.xml' path='doc/member[@name="IJsonObject.GetNamedValue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetNamedValue(HSTRING name, [NativeTypeName("ABI::Windows::Data::Json::IJsonValue **")] IJsonValue** returnValue)
    {
        return ((delegate* unmanaged[MemberFunction]<IJsonObject*, HSTRING, IJsonValue**, int>)(lpVtbl[6]))((IJsonObject*)Unsafe.AsPointer(ref this), name, returnValue);
    }

    /// <include file='IJsonObject.xml' path='doc/member[@name="IJsonObject.SetNamedValue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetNamedValue(HSTRING name, [NativeTypeName("ABI::Windows::Data::Json::IJsonValue *")] IJsonValue* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IJsonObject*, HSTRING, IJsonValue*, int>)(lpVtbl[7]))((IJsonObject*)Unsafe.AsPointer(ref this), name, value);
    }

    /// <include file='IJsonObject.xml' path='doc/member[@name="IJsonObject.GetNamedObject"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetNamedObject(HSTRING name, [NativeTypeName("ABI::Windows::Data::Json::IJsonObject **")] IJsonObject** returnValue)
    {
        return ((delegate* unmanaged[MemberFunction]<IJsonObject*, HSTRING, IJsonObject**, int>)(lpVtbl[8]))((IJsonObject*)Unsafe.AsPointer(ref this), name, returnValue);
    }

    /// <include file='IJsonObject.xml' path='doc/member[@name="IJsonObject.GetNamedArray"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetNamedArray(HSTRING name, [NativeTypeName("ABI::Windows::Data::Json::IJsonArray **")] IJsonArray** returnValue)
    {
        return ((delegate* unmanaged[MemberFunction]<IJsonObject*, HSTRING, IJsonArray**, int>)(lpVtbl[9]))((IJsonObject*)Unsafe.AsPointer(ref this), name, returnValue);
    }

    /// <include file='IJsonObject.xml' path='doc/member[@name="IJsonObject.GetNamedString"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetNamedString(HSTRING name, HSTRING* returnValue)
    {
        return ((delegate* unmanaged[MemberFunction]<IJsonObject*, HSTRING, HSTRING*, int>)(lpVtbl[10]))((IJsonObject*)Unsafe.AsPointer(ref this), name, returnValue);
    }

    /// <include file='IJsonObject.xml' path='doc/member[@name="IJsonObject.GetNamedNumber"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetNamedNumber(HSTRING name, double* returnValue)
    {
        return ((delegate* unmanaged[MemberFunction]<IJsonObject*, HSTRING, double*, int>)(lpVtbl[11]))((IJsonObject*)Unsafe.AsPointer(ref this), name, returnValue);
    }

    /// <include file='IJsonObject.xml' path='doc/member[@name="IJsonObject.GetNamedBoolean"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetNamedBoolean(HSTRING name, [NativeTypeName("boolean *")] byte* returnValue)
    {
        return ((delegate* unmanaged[MemberFunction]<IJsonObject*, HSTRING, byte*, int>)(lpVtbl[12]))((IJsonObject*)Unsafe.AsPointer(ref this), name, returnValue);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetNamedValue(HSTRING name, [NativeTypeName("ABI::Windows::Data::Json::IJsonValue **")] IJsonValue** returnValue);

        [VtblIndex(7)]
        HRESULT SetNamedValue(HSTRING name, [NativeTypeName("ABI::Windows::Data::Json::IJsonValue *")] IJsonValue* value);

        [VtblIndex(8)]
        HRESULT GetNamedObject(HSTRING name, [NativeTypeName("ABI::Windows::Data::Json::IJsonObject **")] IJsonObject** returnValue);

        [VtblIndex(9)]
        HRESULT GetNamedArray(HSTRING name, [NativeTypeName("ABI::Windows::Data::Json::IJsonArray **")] IJsonArray** returnValue);

        [VtblIndex(10)]
        HRESULT GetNamedString(HSTRING name, HSTRING* returnValue);

        [VtblIndex(11)]
        HRESULT GetNamedNumber(HSTRING name, double* returnValue);

        [VtblIndex(12)]
        HRESULT GetNamedBoolean(HSTRING name, [NativeTypeName("boolean *")] byte* returnValue);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IJsonValue**, int> GetNamedValue;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Data::Json::IJsonValue *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IJsonValue*, int> SetNamedValue;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Data::Json::IJsonObject **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IJsonObject**, int> GetNamedObject;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Data::Json::IJsonArray **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IJsonArray**, int> GetNamedArray;

        [NativeTypeName("HRESULT (HSTRING, HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, HSTRING*, int> GetNamedString;

        [NativeTypeName("HRESULT (HSTRING, DOUBLE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, double*, int> GetNamedNumber;

        [NativeTypeName("HRESULT (HSTRING, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, byte*, int> GetNamedBoolean;
    }
}
