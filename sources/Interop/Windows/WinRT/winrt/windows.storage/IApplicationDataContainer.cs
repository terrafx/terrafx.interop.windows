// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IApplicationDataContainer.xml' path='doc/member[@name="IApplicationDataContainer"]/*' />
[Guid("C5AEFD1E-F467-40BA-8566-AB640A441E1D")]
[NativeTypeName("struct IApplicationDataContainer : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IApplicationDataContainer : IApplicationDataContainer.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IApplicationDataContainer));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IApplicationDataContainer*, Guid*, void**, int>)(lpVtbl[0]))((IApplicationDataContainer*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IApplicationDataContainer*, uint>)(lpVtbl[1]))((IApplicationDataContainer*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IApplicationDataContainer*, uint>)(lpVtbl[2]))((IApplicationDataContainer*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IApplicationDataContainer*, uint*, Guid**, int>)(lpVtbl[3]))((IApplicationDataContainer*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IApplicationDataContainer*, HSTRING*, int>)(lpVtbl[4]))((IApplicationDataContainer*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IApplicationDataContainer*, TrustLevel*, int>)(lpVtbl[5]))((IApplicationDataContainer*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IApplicationDataContainer.xml' path='doc/member[@name="IApplicationDataContainer.get_Name"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Name(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IApplicationDataContainer*, HSTRING*, int>)(lpVtbl[6]))((IApplicationDataContainer*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IApplicationDataContainer.xml' path='doc/member[@name="IApplicationDataContainer.get_Locality"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Locality([NativeTypeName("ABI::Windows::Storage::ApplicationDataLocality *")] ApplicationDataLocality* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IApplicationDataContainer*, ApplicationDataLocality*, int>)(lpVtbl[7]))((IApplicationDataContainer*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IApplicationDataContainer.xml' path='doc/member[@name="IApplicationDataContainer.get_Values"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Values([NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet **")] IPropertySet** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IApplicationDataContainer*, IPropertySet**, int>)(lpVtbl[8]))((IApplicationDataContainer*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IApplicationDataContainer.xml' path='doc/member[@name="IApplicationDataContainer.get_Containers"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_Containers([NativeTypeName("ABI::Windows::Foundation::Collections::__FIMapView_2_HSTRING_Windows__CStorage__CApplicationDataContainer_t **")] IMapView<HSTRING, Pointer<IApplicationDataContainer>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IApplicationDataContainer*, IMapView<HSTRING, Pointer<IApplicationDataContainer>>**, int>)(lpVtbl[9]))((IApplicationDataContainer*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IApplicationDataContainer.xml' path='doc/member[@name="IApplicationDataContainer.CreateContainer"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT CreateContainer(HSTRING name, [NativeTypeName("ABI::Windows::Storage::ApplicationDataCreateDisposition")] ApplicationDataCreateDisposition disposition, [NativeTypeName("ABI::Windows::Storage::IApplicationDataContainer **")] IApplicationDataContainer** container)
    {
        return ((delegate* unmanaged[MemberFunction]<IApplicationDataContainer*, HSTRING, ApplicationDataCreateDisposition, IApplicationDataContainer**, int>)(lpVtbl[10]))((IApplicationDataContainer*)Unsafe.AsPointer(ref this), name, disposition, container);
    }

    /// <include file='IApplicationDataContainer.xml' path='doc/member[@name="IApplicationDataContainer.DeleteContainer"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT DeleteContainer(HSTRING name)
    {
        return ((delegate* unmanaged[MemberFunction]<IApplicationDataContainer*, HSTRING, int>)(lpVtbl[11]))((IApplicationDataContainer*)Unsafe.AsPointer(ref this), name);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Name(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_Locality([NativeTypeName("ABI::Windows::Storage::ApplicationDataLocality *")] ApplicationDataLocality* value);

        [VtblIndex(8)]
        HRESULT get_Values([NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet **")] IPropertySet** value);

        [VtblIndex(9)]
        HRESULT get_Containers([NativeTypeName("ABI::Windows::Foundation::Collections::__FIMapView_2_HSTRING_Windows__CStorage__CApplicationDataContainer_t **")] IMapView<HSTRING, Pointer<IApplicationDataContainer>>** value);

        [VtblIndex(10)]
        HRESULT CreateContainer(HSTRING name, [NativeTypeName("ABI::Windows::Storage::ApplicationDataCreateDisposition")] ApplicationDataCreateDisposition disposition, [NativeTypeName("ABI::Windows::Storage::IApplicationDataContainer **")] IApplicationDataContainer** container);

        [VtblIndex(11)]
        HRESULT DeleteContainer(HSTRING name);
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

        [NativeTypeName("HRESULT (ABI::Windows::Storage::ApplicationDataLocality *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ApplicationDataLocality*, int> get_Locality;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::IPropertySet **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IPropertySet**, int> get_Values;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIMapView_2_HSTRING_Windows__CStorage__CApplicationDataContainer_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMapView<HSTRING, Pointer<IApplicationDataContainer>>**, int> get_Containers;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Storage::ApplicationDataCreateDisposition, ABI::Windows::Storage::IApplicationDataContainer **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, ApplicationDataCreateDisposition, IApplicationDataContainer**, int> CreateContainer;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> DeleteContainer;
    }
}
