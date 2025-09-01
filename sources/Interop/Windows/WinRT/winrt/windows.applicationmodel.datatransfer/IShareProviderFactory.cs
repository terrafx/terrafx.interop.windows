// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.datatransfer.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IShareProviderFactory.xml' path='doc/member[@name="IShareProviderFactory"]/*' />
[Guid("172A174C-E79E-4F6D-B07D-128F469E0296")]
[NativeTypeName("struct IShareProviderFactory : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IShareProviderFactory : IShareProviderFactory.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IShareProviderFactory);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IShareProviderFactory*, Guid*, void**, int>)(lpVtbl[0]))((IShareProviderFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IShareProviderFactory*, uint>)(lpVtbl[1]))((IShareProviderFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IShareProviderFactory*, uint>)(lpVtbl[2]))((IShareProviderFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IShareProviderFactory*, uint*, Guid**, int>)(lpVtbl[3]))((IShareProviderFactory*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IShareProviderFactory*, HSTRING*, int>)(lpVtbl[4]))((IShareProviderFactory*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IShareProviderFactory*, TrustLevel*, int>)(lpVtbl[5]))((IShareProviderFactory*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IShareProviderFactory.xml' path='doc/member[@name="IShareProviderFactory.Create"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Create(HSTRING title, [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference *")] IRandomAccessStreamReference* displayIcon, [NativeTypeName("ABI::Windows::UI::Color")] Color backgroundColor, [NativeTypeName("ABI::Windows::ApplicationModel::DataTransfer::IShareProviderHandler *")] IShareProviderHandler* handler, [NativeTypeName("ABI::Windows::ApplicationModel::DataTransfer::IShareProvider **")] IShareProvider** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IShareProviderFactory*, HSTRING, IRandomAccessStreamReference*, Color, IShareProviderHandler*, IShareProvider**, int>)(lpVtbl[6]))((IShareProviderFactory*)Unsafe.AsPointer(ref this), title, displayIcon, backgroundColor, handler, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT Create(HSTRING title, [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference *")] IRandomAccessStreamReference* displayIcon, [NativeTypeName("ABI::Windows::UI::Color")] Color backgroundColor, [NativeTypeName("ABI::Windows::ApplicationModel::DataTransfer::IShareProviderHandler *")] IShareProviderHandler* handler, [NativeTypeName("ABI::Windows::ApplicationModel::DataTransfer::IShareProvider **")] IShareProvider** result);
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

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Storage::Streams::IRandomAccessStreamReference *, ABI::Windows::UI::Color, ABI::Windows::ApplicationModel::DataTransfer::IShareProviderHandler *, ABI::Windows::ApplicationModel::DataTransfer::IShareProvider **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IRandomAccessStreamReference*, Color, IShareProviderHandler*, IShareProvider**, int> Create;
    }
}
