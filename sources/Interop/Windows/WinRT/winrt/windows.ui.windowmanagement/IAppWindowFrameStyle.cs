// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.windowmanagement.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAppWindowFrameStyle.xml' path='doc/member[@name="IAppWindowFrameStyle"]/*' />
[Guid("AC412946-E1AC-5230-944A-C60873DCF4A9")]
[NativeTypeName("struct IAppWindowFrameStyle : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAppWindowFrameStyle : IAppWindowFrameStyle.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppWindowFrameStyle));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppWindowFrameStyle*, Guid*, void**, int>)(lpVtbl[0]))((IAppWindowFrameStyle*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppWindowFrameStyle*, uint>)(lpVtbl[1]))((IAppWindowFrameStyle*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppWindowFrameStyle*, uint>)(lpVtbl[2]))((IAppWindowFrameStyle*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppWindowFrameStyle*, uint*, Guid**, int>)(lpVtbl[3]))((IAppWindowFrameStyle*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppWindowFrameStyle*, HSTRING*, int>)(lpVtbl[4]))((IAppWindowFrameStyle*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppWindowFrameStyle*, TrustLevel*, int>)(lpVtbl[5]))((IAppWindowFrameStyle*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAppWindowFrameStyle.xml' path='doc/member[@name="IAppWindowFrameStyle.GetFrameStyle"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetFrameStyle([NativeTypeName("ABI::Windows::UI::WindowManagement::AppWindowFrameStyle *")] AppWindowFrameStyle* result)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppWindowFrameStyle*, AppWindowFrameStyle*, int>)(lpVtbl[6]))((IAppWindowFrameStyle*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IAppWindowFrameStyle.xml' path='doc/member[@name="IAppWindowFrameStyle.SetFrameStyle"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetFrameStyle([NativeTypeName("ABI::Windows::UI::WindowManagement::AppWindowFrameStyle")] AppWindowFrameStyle frameStyle)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppWindowFrameStyle*, AppWindowFrameStyle, int>)(lpVtbl[7]))((IAppWindowFrameStyle*)Unsafe.AsPointer(ref this), frameStyle);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetFrameStyle([NativeTypeName("ABI::Windows::UI::WindowManagement::AppWindowFrameStyle *")] AppWindowFrameStyle* result);

        [VtblIndex(7)]
        HRESULT SetFrameStyle([NativeTypeName("ABI::Windows::UI::WindowManagement::AppWindowFrameStyle")] AppWindowFrameStyle frameStyle);
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

        [NativeTypeName("HRESULT (ABI::Windows::UI::WindowManagement::AppWindowFrameStyle *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, AppWindowFrameStyle*, int> GetFrameStyle;

        [NativeTypeName("HRESULT (ABI::Windows::UI::WindowManagement::AppWindowFrameStyle) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, AppWindowFrameStyle, int> SetFrameStyle;
    }
}
