// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.datatransfer.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IShareProvider.xml' path='doc/member[@name="IShareProvider"]/*' />
[Guid("2FABE026-443E-4CDA-AF25-8D81070EFD80")]
[NativeTypeName("struct IShareProvider : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IShareProvider : IShareProvider.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IShareProvider));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IShareProvider*, Guid*, void**, int>)(lpVtbl[0]))((IShareProvider*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IShareProvider*, uint>)(lpVtbl[1]))((IShareProvider*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IShareProvider*, uint>)(lpVtbl[2]))((IShareProvider*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IShareProvider*, uint*, Guid**, int>)(lpVtbl[3]))((IShareProvider*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IShareProvider*, HSTRING*, int>)(lpVtbl[4]))((IShareProvider*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IShareProvider*, TrustLevel*, int>)(lpVtbl[5]))((IShareProvider*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IShareProvider.xml' path='doc/member[@name="IShareProvider.get_Title"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Title(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IShareProvider*, HSTRING*, int>)(lpVtbl[6]))((IShareProvider*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IShareProvider.xml' path='doc/member[@name="IShareProvider.get_DisplayIcon"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_DisplayIcon([NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference **")] IRandomAccessStreamReference** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IShareProvider*, IRandomAccessStreamReference**, int>)(lpVtbl[7]))((IShareProvider*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IShareProvider.xml' path='doc/member[@name="IShareProvider.get_BackgroundColor"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_BackgroundColor([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IShareProvider*, Color*, int>)(lpVtbl[8]))((IShareProvider*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IShareProvider.xml' path='doc/member[@name="IShareProvider.get_Tag"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_Tag(IInspectable** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IShareProvider*, IInspectable**, int>)(lpVtbl[9]))((IShareProvider*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IShareProvider.xml' path='doc/member[@name="IShareProvider.put_Tag"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT put_Tag(IInspectable* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IShareProvider*, IInspectable*, int>)(lpVtbl[10]))((IShareProvider*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Title(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_DisplayIcon([NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference **")] IRandomAccessStreamReference** value);

        [VtblIndex(8)]
        HRESULT get_BackgroundColor([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(9)]
        HRESULT get_Tag(IInspectable** value);

        [VtblIndex(10)]
        HRESULT put_Tag(IInspectable* value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Title;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IRandomAccessStreamReference **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IRandomAccessStreamReference**, int> get_DisplayIcon;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Color*, int> get_BackgroundColor;

        [NativeTypeName("HRESULT (IInspectable **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IInspectable**, int> get_Tag;

        [NativeTypeName("HRESULT (IInspectable *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IInspectable*, int> put_Tag;
    }
}
