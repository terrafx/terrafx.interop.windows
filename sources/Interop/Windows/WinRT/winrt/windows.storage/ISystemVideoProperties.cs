// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ISystemVideoProperties.xml' path='doc/member[@name="ISystemVideoProperties"]/*' />
[Guid("2040F715-67F8-4322-9B80-4FA9FEFB83E8")]
[NativeTypeName("struct ISystemVideoProperties : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISystemVideoProperties : ISystemVideoProperties.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ISystemVideoProperties);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemVideoProperties*, Guid*, void**, int>)(lpVtbl[0]))((ISystemVideoProperties*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemVideoProperties*, uint>)(lpVtbl[1]))((ISystemVideoProperties*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemVideoProperties*, uint>)(lpVtbl[2]))((ISystemVideoProperties*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemVideoProperties*, uint*, Guid**, int>)(lpVtbl[3]))((ISystemVideoProperties*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemVideoProperties*, HSTRING*, int>)(lpVtbl[4]))((ISystemVideoProperties*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemVideoProperties*, TrustLevel*, int>)(lpVtbl[5]))((ISystemVideoProperties*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ISystemVideoProperties.xml' path='doc/member[@name="ISystemVideoProperties.get_Director"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Director(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemVideoProperties*, HSTRING*, int>)(lpVtbl[6]))((ISystemVideoProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISystemVideoProperties.xml' path='doc/member[@name="ISystemVideoProperties.get_FrameHeight"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_FrameHeight(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemVideoProperties*, HSTRING*, int>)(lpVtbl[7]))((ISystemVideoProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISystemVideoProperties.xml' path='doc/member[@name="ISystemVideoProperties.get_FrameWidth"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_FrameWidth(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemVideoProperties*, HSTRING*, int>)(lpVtbl[8]))((ISystemVideoProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISystemVideoProperties.xml' path='doc/member[@name="ISystemVideoProperties.get_Orientation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_Orientation(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemVideoProperties*, HSTRING*, int>)(lpVtbl[9]))((ISystemVideoProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISystemVideoProperties.xml' path='doc/member[@name="ISystemVideoProperties.get_TotalBitrate"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_TotalBitrate(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemVideoProperties*, HSTRING*, int>)(lpVtbl[10]))((ISystemVideoProperties*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Director(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_FrameHeight(HSTRING* value);

        [VtblIndex(8)]
        HRESULT get_FrameWidth(HSTRING* value);

        [VtblIndex(9)]
        HRESULT get_Orientation(HSTRING* value);

        [VtblIndex(10)]
        HRESULT get_TotalBitrate(HSTRING* value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Director;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_FrameHeight;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_FrameWidth;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Orientation;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_TotalBitrate;
    }
}
