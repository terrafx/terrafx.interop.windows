// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.input.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ITouchpadGesturesControllerStatics.xml' path='doc/member[@name="ITouchpadGesturesControllerStatics"]/*' />
[Guid("207EF171-1A73-51CD-A694-8840E09DBAFA")]
[NativeTypeName("struct ITouchpadGesturesControllerStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ITouchpadGesturesControllerStatics : ITouchpadGesturesControllerStatics.Interface, INativeGuid
{
    /// <include file='ITouchpadGesturesControllerStatics.xml' path='doc/member[@name="ITouchpadGesturesControllerStatics.INativeGuid.NativeGuid"]/*' />
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ITouchpadGesturesControllerStatics);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ITouchpadGesturesControllerStatics*, Guid*, void**, int>)(lpVtbl[0]))((ITouchpadGesturesControllerStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ITouchpadGesturesControllerStatics*, uint>)(lpVtbl[1]))((ITouchpadGesturesControllerStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ITouchpadGesturesControllerStatics*, uint>)(lpVtbl[2]))((ITouchpadGesturesControllerStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ITouchpadGesturesControllerStatics*, uint*, Guid**, int>)(lpVtbl[3]))((ITouchpadGesturesControllerStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ITouchpadGesturesControllerStatics*, HSTRING*, int>)(lpVtbl[4]))((ITouchpadGesturesControllerStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ITouchpadGesturesControllerStatics*, TrustLevel*, int>)(lpVtbl[5]))((ITouchpadGesturesControllerStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ITouchpadGesturesControllerStatics.xml' path='doc/member[@name="ITouchpadGesturesControllerStatics.IsSupported"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT IsSupported([NativeTypeName("boolean *")] byte* result)
    {
        return ((delegate* unmanaged[MemberFunction]<ITouchpadGesturesControllerStatics*, byte*, int>)(lpVtbl[6]))((ITouchpadGesturesControllerStatics*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='ITouchpadGesturesControllerStatics.xml' path='doc/member[@name="ITouchpadGesturesControllerStatics.CreateForProcess"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateForProcess([NativeTypeName("ABI::Windows::UI::Input::ITouchpadGesturesController **")] ITouchpadGesturesController** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ITouchpadGesturesControllerStatics*, ITouchpadGesturesController**, int>)(lpVtbl[7]))((ITouchpadGesturesControllerStatics*)Unsafe.AsPointer(ref this), result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT IsSupported([NativeTypeName("boolean *")] byte* result);

        [VtblIndex(7)]
        HRESULT CreateForProcess([NativeTypeName("ABI::Windows::UI::Input::ITouchpadGesturesController **")] ITouchpadGesturesController** result);
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

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> IsSupported;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Input::ITouchpadGesturesController **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITouchpadGesturesController**, int> CreateForProcess;
    }
}
