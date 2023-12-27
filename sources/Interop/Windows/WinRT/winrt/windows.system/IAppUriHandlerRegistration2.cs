// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAppUriHandlerRegistration2.xml' path='doc/member[@name="IAppUriHandlerRegistration2"]/*' />
[Guid("D54DAC97-CB39-5F1F-883E-01853730BD6D")]
[NativeTypeName("struct IAppUriHandlerRegistration2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAppUriHandlerRegistration2 : IAppUriHandlerRegistration2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppUriHandlerRegistration2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppUriHandlerRegistration2*, Guid*, void**, int>)(lpVtbl[0]))((IAppUriHandlerRegistration2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppUriHandlerRegistration2*, uint>)(lpVtbl[1]))((IAppUriHandlerRegistration2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppUriHandlerRegistration2*, uint>)(lpVtbl[2]))((IAppUriHandlerRegistration2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppUriHandlerRegistration2*, uint*, Guid**, int>)(lpVtbl[3]))((IAppUriHandlerRegistration2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppUriHandlerRegistration2*, HSTRING*, int>)(lpVtbl[4]))((IAppUriHandlerRegistration2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppUriHandlerRegistration2*, TrustLevel*, int>)(lpVtbl[5]))((IAppUriHandlerRegistration2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAppUriHandlerRegistration2.xml' path='doc/member[@name="IAppUriHandlerRegistration2.GetAllHosts"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetAllHosts([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CSystem__CAppUriHandlerHost_t **")] IVector<Pointer<IAppUriHandlerHost>>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppUriHandlerRegistration2*, IVector<Pointer<IAppUriHandlerHost>>**, int>)(lpVtbl[6]))((IAppUriHandlerRegistration2*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IAppUriHandlerRegistration2.xml' path='doc/member[@name="IAppUriHandlerRegistration2.UpdateHosts"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT UpdateHosts([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CSystem__CAppUriHandlerHost_t *")] IIterable<Pointer<IAppUriHandlerHost>>* hosts)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppUriHandlerRegistration2*, IIterable<Pointer<IAppUriHandlerHost>>*, int>)(lpVtbl[7]))((IAppUriHandlerRegistration2*)Unsafe.AsPointer(ref this), hosts);
    }

    /// <include file='IAppUriHandlerRegistration2.xml' path='doc/member[@name="IAppUriHandlerRegistration2.get_PackageFamilyName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_PackageFamilyName(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppUriHandlerRegistration2*, HSTRING*, int>)(lpVtbl[8]))((IAppUriHandlerRegistration2*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetAllHosts([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CSystem__CAppUriHandlerHost_t **")] IVector<Pointer<IAppUriHandlerHost>>** result);

        [VtblIndex(7)]
        HRESULT UpdateHosts([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CSystem__CAppUriHandlerHost_t *")] IIterable<Pointer<IAppUriHandlerHost>>* hosts);

        [VtblIndex(8)]
        HRESULT get_PackageFamilyName(HSTRING* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CSystem__CAppUriHandlerHost_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVector<Pointer<IAppUriHandlerHost>>**, int> GetAllHosts;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CSystem__CAppUriHandlerHost_t *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IIterable<Pointer<IAppUriHandlerHost>>*, int> UpdateHosts;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_PackageFamilyName;
    }
}
