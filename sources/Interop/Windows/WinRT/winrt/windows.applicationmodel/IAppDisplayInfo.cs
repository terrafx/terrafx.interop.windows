// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAppDisplayInfo.xml' path='doc/member[@name="IAppDisplayInfo"]/*' />
[Guid("1AEB1103-E4D4-41AA-A4F6-C4A276E79EAC")]
[NativeTypeName("struct IAppDisplayInfo : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAppDisplayInfo : IAppDisplayInfo.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppDisplayInfo));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppDisplayInfo*, Guid*, void**, int>)(lpVtbl[0]))((IAppDisplayInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppDisplayInfo*, uint>)(lpVtbl[1]))((IAppDisplayInfo*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppDisplayInfo*, uint>)(lpVtbl[2]))((IAppDisplayInfo*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppDisplayInfo*, uint*, Guid**, int>)(lpVtbl[3]))((IAppDisplayInfo*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppDisplayInfo*, HSTRING*, int>)(lpVtbl[4]))((IAppDisplayInfo*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppDisplayInfo*, TrustLevel*, int>)(lpVtbl[5]))((IAppDisplayInfo*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAppDisplayInfo.xml' path='doc/member[@name="IAppDisplayInfo.get_DisplayName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_DisplayName(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppDisplayInfo*, HSTRING*, int>)(lpVtbl[6]))((IAppDisplayInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppDisplayInfo.xml' path='doc/member[@name="IAppDisplayInfo.get_Description"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Description(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppDisplayInfo*, HSTRING*, int>)(lpVtbl[7]))((IAppDisplayInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppDisplayInfo.xml' path='doc/member[@name="IAppDisplayInfo.GetLogo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetLogo([NativeTypeName("ABI::Windows::Foundation::Size")] Size size, [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference **")] IRandomAccessStreamReference** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppDisplayInfo*, Size, IRandomAccessStreamReference**, int>)(lpVtbl[8]))((IAppDisplayInfo*)Unsafe.AsPointer(ref this), size, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_DisplayName(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_Description(HSTRING* value);

        [VtblIndex(8)]
        HRESULT GetLogo([NativeTypeName("ABI::Windows::Foundation::Size")] Size size, [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference **")] IRandomAccessStreamReference** value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_DisplayName;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Description;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Size, ABI::Windows::Storage::Streams::IRandomAccessStreamReference **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Size, IRandomAccessStreamReference**, int> GetLogo;
    }
}
