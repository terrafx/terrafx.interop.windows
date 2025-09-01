// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.streams.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IPropertySetSerializer.xml' path='doc/member[@name="IPropertySetSerializer"]/*' />
[Guid("6E8EBF1C-EF3D-4376-B20E-5BE638AEAC77")]
[NativeTypeName("struct IPropertySetSerializer : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPropertySetSerializer : IPropertySetSerializer.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IPropertySetSerializer);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IPropertySetSerializer*, Guid*, void**, int>)(lpVtbl[0]))((IPropertySetSerializer*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPropertySetSerializer*, uint>)(lpVtbl[1]))((IPropertySetSerializer*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPropertySetSerializer*, uint>)(lpVtbl[2]))((IPropertySetSerializer*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IPropertySetSerializer*, uint*, Guid**, int>)(lpVtbl[3]))((IPropertySetSerializer*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IPropertySetSerializer*, HSTRING*, int>)(lpVtbl[4]))((IPropertySetSerializer*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IPropertySetSerializer*, TrustLevel*, int>)(lpVtbl[5]))((IPropertySetSerializer*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IPropertySetSerializer.xml' path='doc/member[@name="IPropertySetSerializer.Serialize"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Serialize([NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet *")] IPropertySet* propertySet, [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IPropertySetSerializer*, IPropertySet*, IBuffer**, int>)(lpVtbl[6]))((IPropertySetSerializer*)Unsafe.AsPointer(ref this), propertySet, result);
    }

    /// <include file='IPropertySetSerializer.xml' path='doc/member[@name="IPropertySetSerializer.Deserialize"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT Deserialize([NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet *")] IPropertySet* propertySet, [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* buffer)
    {
        return ((delegate* unmanaged[MemberFunction]<IPropertySetSerializer*, IPropertySet*, IBuffer*, int>)(lpVtbl[7]))((IPropertySetSerializer*)Unsafe.AsPointer(ref this), propertySet, buffer);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT Serialize([NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet *")] IPropertySet* propertySet, [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer** result);

        [VtblIndex(7)]
        HRESULT Deserialize([NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet *")] IPropertySet* propertySet, [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* buffer);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::IPropertySet *, ABI::Windows::Storage::Streams::IBuffer **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IPropertySet*, IBuffer**, int> Serialize;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::IPropertySet *, ABI::Windows::Storage::Streams::IBuffer *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IPropertySet*, IBuffer*, int> Deserialize;
    }
}
