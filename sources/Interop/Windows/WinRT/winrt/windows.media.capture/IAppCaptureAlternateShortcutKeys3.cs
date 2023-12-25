// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.capture.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAppCaptureAlternateShortcutKeys3.xml' path='doc/member[@name="IAppCaptureAlternateShortcutKeys3"]/*' />
[Guid("7B81448C-418E-469C-A49A-45B597C826B6")]
[NativeTypeName("struct IAppCaptureAlternateShortcutKeys3 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAppCaptureAlternateShortcutKeys3 : IAppCaptureAlternateShortcutKeys3.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppCaptureAlternateShortcutKeys3));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppCaptureAlternateShortcutKeys3*, Guid*, void**, int>)(lpVtbl[0]))((IAppCaptureAlternateShortcutKeys3*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppCaptureAlternateShortcutKeys3*, uint>)(lpVtbl[1]))((IAppCaptureAlternateShortcutKeys3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppCaptureAlternateShortcutKeys3*, uint>)(lpVtbl[2]))((IAppCaptureAlternateShortcutKeys3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppCaptureAlternateShortcutKeys3*, uint*, Guid**, int>)(lpVtbl[3]))((IAppCaptureAlternateShortcutKeys3*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppCaptureAlternateShortcutKeys3*, HSTRING*, int>)(lpVtbl[4]))((IAppCaptureAlternateShortcutKeys3*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppCaptureAlternateShortcutKeys3*, TrustLevel*, int>)(lpVtbl[5]))((IAppCaptureAlternateShortcutKeys3*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAppCaptureAlternateShortcutKeys3.xml' path='doc/member[@name="IAppCaptureAlternateShortcutKeys3.put_ToggleCameraCaptureKey"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT put_ToggleCameraCaptureKey([NativeTypeName("ABI::Windows::System::VirtualKey")] VirtualKey value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppCaptureAlternateShortcutKeys3*, VirtualKey, int>)(lpVtbl[6]))((IAppCaptureAlternateShortcutKeys3*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppCaptureAlternateShortcutKeys3.xml' path='doc/member[@name="IAppCaptureAlternateShortcutKeys3.get_ToggleCameraCaptureKey"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_ToggleCameraCaptureKey([NativeTypeName("ABI::Windows::System::VirtualKey *")] VirtualKey* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppCaptureAlternateShortcutKeys3*, VirtualKey*, int>)(lpVtbl[7]))((IAppCaptureAlternateShortcutKeys3*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppCaptureAlternateShortcutKeys3.xml' path='doc/member[@name="IAppCaptureAlternateShortcutKeys3.put_ToggleCameraCaptureKeyModifiers"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_ToggleCameraCaptureKeyModifiers([NativeTypeName("ABI::Windows::System::VirtualKeyModifiers")] VirtualKeyModifiers value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppCaptureAlternateShortcutKeys3*, VirtualKeyModifiers, int>)(lpVtbl[8]))((IAppCaptureAlternateShortcutKeys3*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppCaptureAlternateShortcutKeys3.xml' path='doc/member[@name="IAppCaptureAlternateShortcutKeys3.get_ToggleCameraCaptureKeyModifiers"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_ToggleCameraCaptureKeyModifiers([NativeTypeName("ABI::Windows::System::VirtualKeyModifiers *")] VirtualKeyModifiers* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppCaptureAlternateShortcutKeys3*, VirtualKeyModifiers*, int>)(lpVtbl[9]))((IAppCaptureAlternateShortcutKeys3*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppCaptureAlternateShortcutKeys3.xml' path='doc/member[@name="IAppCaptureAlternateShortcutKeys3.put_ToggleBroadcastKey"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT put_ToggleBroadcastKey([NativeTypeName("ABI::Windows::System::VirtualKey")] VirtualKey value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppCaptureAlternateShortcutKeys3*, VirtualKey, int>)(lpVtbl[10]))((IAppCaptureAlternateShortcutKeys3*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppCaptureAlternateShortcutKeys3.xml' path='doc/member[@name="IAppCaptureAlternateShortcutKeys3.get_ToggleBroadcastKey"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_ToggleBroadcastKey([NativeTypeName("ABI::Windows::System::VirtualKey *")] VirtualKey* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppCaptureAlternateShortcutKeys3*, VirtualKey*, int>)(lpVtbl[11]))((IAppCaptureAlternateShortcutKeys3*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppCaptureAlternateShortcutKeys3.xml' path='doc/member[@name="IAppCaptureAlternateShortcutKeys3.put_ToggleBroadcastKeyModifiers"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT put_ToggleBroadcastKeyModifiers([NativeTypeName("ABI::Windows::System::VirtualKeyModifiers")] VirtualKeyModifiers value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppCaptureAlternateShortcutKeys3*, VirtualKeyModifiers, int>)(lpVtbl[12]))((IAppCaptureAlternateShortcutKeys3*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppCaptureAlternateShortcutKeys3.xml' path='doc/member[@name="IAppCaptureAlternateShortcutKeys3.get_ToggleBroadcastKeyModifiers"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_ToggleBroadcastKeyModifiers([NativeTypeName("ABI::Windows::System::VirtualKeyModifiers *")] VirtualKeyModifiers* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppCaptureAlternateShortcutKeys3*, VirtualKeyModifiers*, int>)(lpVtbl[13]))((IAppCaptureAlternateShortcutKeys3*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT put_ToggleCameraCaptureKey([NativeTypeName("ABI::Windows::System::VirtualKey")] VirtualKey value);

        [VtblIndex(7)]
        HRESULT get_ToggleCameraCaptureKey([NativeTypeName("ABI::Windows::System::VirtualKey *")] VirtualKey* value);

        [VtblIndex(8)]
        HRESULT put_ToggleCameraCaptureKeyModifiers([NativeTypeName("ABI::Windows::System::VirtualKeyModifiers")] VirtualKeyModifiers value);

        [VtblIndex(9)]
        HRESULT get_ToggleCameraCaptureKeyModifiers([NativeTypeName("ABI::Windows::System::VirtualKeyModifiers *")] VirtualKeyModifiers* value);

        [VtblIndex(10)]
        HRESULT put_ToggleBroadcastKey([NativeTypeName("ABI::Windows::System::VirtualKey")] VirtualKey value);

        [VtblIndex(11)]
        HRESULT get_ToggleBroadcastKey([NativeTypeName("ABI::Windows::System::VirtualKey *")] VirtualKey* value);

        [VtblIndex(12)]
        HRESULT put_ToggleBroadcastKeyModifiers([NativeTypeName("ABI::Windows::System::VirtualKeyModifiers")] VirtualKeyModifiers value);

        [VtblIndex(13)]
        HRESULT get_ToggleBroadcastKeyModifiers([NativeTypeName("ABI::Windows::System::VirtualKeyModifiers *")] VirtualKeyModifiers* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::System::VirtualKey) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, VirtualKey, int> put_ToggleCameraCaptureKey;

        [NativeTypeName("HRESULT (ABI::Windows::System::VirtualKey *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, VirtualKey*, int> get_ToggleCameraCaptureKey;

        [NativeTypeName("HRESULT (ABI::Windows::System::VirtualKeyModifiers) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, VirtualKeyModifiers, int> put_ToggleCameraCaptureKeyModifiers;

        [NativeTypeName("HRESULT (ABI::Windows::System::VirtualKeyModifiers *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, VirtualKeyModifiers*, int> get_ToggleCameraCaptureKeyModifiers;

        [NativeTypeName("HRESULT (ABI::Windows::System::VirtualKey) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, VirtualKey, int> put_ToggleBroadcastKey;

        [NativeTypeName("HRESULT (ABI::Windows::System::VirtualKey *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, VirtualKey*, int> get_ToggleBroadcastKey;

        [NativeTypeName("HRESULT (ABI::Windows::System::VirtualKeyModifiers) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, VirtualKeyModifiers, int> put_ToggleBroadcastKeyModifiers;

        [NativeTypeName("HRESULT (ABI::Windows::System::VirtualKeyModifiers *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, VirtualKeyModifiers*, int> get_ToggleBroadcastKeyModifiers;
    }
}
