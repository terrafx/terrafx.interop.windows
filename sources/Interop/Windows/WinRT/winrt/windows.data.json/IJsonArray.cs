// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.data.json.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IJsonArray.xml' path='doc/member[@name="IJsonArray"]/*' />
[Guid("08C1DDB6-0CBD-4A9A-B5D3-2F852DC37E81")]
[NativeTypeName("struct IJsonArray : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IJsonArray : IJsonArray.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IJsonArray));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IJsonArray*, Guid*, void**, int>)(lpVtbl[0]))((IJsonArray*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IJsonArray*, uint>)(lpVtbl[1]))((IJsonArray*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IJsonArray*, uint>)(lpVtbl[2]))((IJsonArray*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IJsonArray*, uint*, Guid**, int>)(lpVtbl[3]))((IJsonArray*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IJsonArray*, HSTRING*, int>)(lpVtbl[4]))((IJsonArray*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IJsonArray*, TrustLevel*, int>)(lpVtbl[5]))((IJsonArray*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IJsonArray.xml' path='doc/member[@name="IJsonArray.GetObjectAt"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetObjectAt([NativeTypeName("UINT32")] uint index, [NativeTypeName("ABI::Windows::Data::Json::IJsonObject **")] IJsonObject** returnValue)
    {
        return ((delegate* unmanaged[MemberFunction]<IJsonArray*, uint, IJsonObject**, int>)(lpVtbl[6]))((IJsonArray*)Unsafe.AsPointer(ref this), index, returnValue);
    }

    /// <include file='IJsonArray.xml' path='doc/member[@name="IJsonArray.GetArrayAt"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetArrayAt([NativeTypeName("UINT32")] uint index, [NativeTypeName("ABI::Windows::Data::Json::IJsonArray **")] IJsonArray** returnValue)
    {
        return ((delegate* unmanaged[MemberFunction]<IJsonArray*, uint, IJsonArray**, int>)(lpVtbl[7]))((IJsonArray*)Unsafe.AsPointer(ref this), index, returnValue);
    }

    /// <include file='IJsonArray.xml' path='doc/member[@name="IJsonArray.GetStringAt"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetStringAt([NativeTypeName("UINT32")] uint index, HSTRING* returnValue)
    {
        return ((delegate* unmanaged[MemberFunction]<IJsonArray*, uint, HSTRING*, int>)(lpVtbl[8]))((IJsonArray*)Unsafe.AsPointer(ref this), index, returnValue);
    }

    /// <include file='IJsonArray.xml' path='doc/member[@name="IJsonArray.GetNumberAt"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetNumberAt([NativeTypeName("UINT32")] uint index, double* returnValue)
    {
        return ((delegate* unmanaged[MemberFunction]<IJsonArray*, uint, double*, int>)(lpVtbl[9]))((IJsonArray*)Unsafe.AsPointer(ref this), index, returnValue);
    }

    /// <include file='IJsonArray.xml' path='doc/member[@name="IJsonArray.GetBooleanAt"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetBooleanAt([NativeTypeName("UINT32")] uint index, [NativeTypeName("boolean *")] byte* returnValue)
    {
        return ((delegate* unmanaged[MemberFunction]<IJsonArray*, uint, byte*, int>)(lpVtbl[10]))((IJsonArray*)Unsafe.AsPointer(ref this), index, returnValue);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetObjectAt([NativeTypeName("UINT32")] uint index, [NativeTypeName("ABI::Windows::Data::Json::IJsonObject **")] IJsonObject** returnValue);

        [VtblIndex(7)]
        HRESULT GetArrayAt([NativeTypeName("UINT32")] uint index, [NativeTypeName("ABI::Windows::Data::Json::IJsonArray **")] IJsonArray** returnValue);

        [VtblIndex(8)]
        HRESULT GetStringAt([NativeTypeName("UINT32")] uint index, HSTRING* returnValue);

        [VtblIndex(9)]
        HRESULT GetNumberAt([NativeTypeName("UINT32")] uint index, double* returnValue);

        [VtblIndex(10)]
        HRESULT GetBooleanAt([NativeTypeName("UINT32")] uint index, [NativeTypeName("boolean *")] byte* returnValue);
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

        [NativeTypeName("HRESULT (UINT32, ABI::Windows::Data::Json::IJsonObject **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, IJsonObject**, int> GetObjectAt;

        [NativeTypeName("HRESULT (UINT32, ABI::Windows::Data::Json::IJsonArray **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, IJsonArray**, int> GetArrayAt;

        [NativeTypeName("HRESULT (UINT32, HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, HSTRING*, int> GetStringAt;

        [NativeTypeName("HRESULT (UINT32, DOUBLE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, double*, int> GetNumberAt;

        [NativeTypeName("HRESULT (UINT32, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, byte*, int> GetBooleanAt;
    }
}
