// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.capture.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAppCaptureAlternateShortcutKeys2.xml' path='doc/member[@name="IAppCaptureAlternateShortcutKeys2"]/*' />
[Guid("C3669090-DD17-47F0-95E5-CE42286CF338")]
[NativeTypeName("struct IAppCaptureAlternateShortcutKeys2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAppCaptureAlternateShortcutKeys2 : IAppCaptureAlternateShortcutKeys2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppCaptureAlternateShortcutKeys2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppCaptureAlternateShortcutKeys2*, Guid*, void**, int>)(lpVtbl[0]))((IAppCaptureAlternateShortcutKeys2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppCaptureAlternateShortcutKeys2*, uint>)(lpVtbl[1]))((IAppCaptureAlternateShortcutKeys2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppCaptureAlternateShortcutKeys2*, uint>)(lpVtbl[2]))((IAppCaptureAlternateShortcutKeys2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppCaptureAlternateShortcutKeys2*, uint*, Guid**, int>)(lpVtbl[3]))((IAppCaptureAlternateShortcutKeys2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppCaptureAlternateShortcutKeys2*, HSTRING*, int>)(lpVtbl[4]))((IAppCaptureAlternateShortcutKeys2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppCaptureAlternateShortcutKeys2*, TrustLevel*, int>)(lpVtbl[5]))((IAppCaptureAlternateShortcutKeys2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAppCaptureAlternateShortcutKeys2.xml' path='doc/member[@name="IAppCaptureAlternateShortcutKeys2.put_ToggleMicrophoneCaptureKey"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT put_ToggleMicrophoneCaptureKey([NativeTypeName("ABI::Windows::System::VirtualKey")] VirtualKey value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppCaptureAlternateShortcutKeys2*, VirtualKey, int>)(lpVtbl[6]))((IAppCaptureAlternateShortcutKeys2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppCaptureAlternateShortcutKeys2.xml' path='doc/member[@name="IAppCaptureAlternateShortcutKeys2.get_ToggleMicrophoneCaptureKey"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_ToggleMicrophoneCaptureKey([NativeTypeName("ABI::Windows::System::VirtualKey *")] VirtualKey* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppCaptureAlternateShortcutKeys2*, VirtualKey*, int>)(lpVtbl[7]))((IAppCaptureAlternateShortcutKeys2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppCaptureAlternateShortcutKeys2.xml' path='doc/member[@name="IAppCaptureAlternateShortcutKeys2.put_ToggleMicrophoneCaptureKeyModifiers"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_ToggleMicrophoneCaptureKeyModifiers([NativeTypeName("ABI::Windows::System::VirtualKeyModifiers")] VirtualKeyModifiers value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppCaptureAlternateShortcutKeys2*, VirtualKeyModifiers, int>)(lpVtbl[8]))((IAppCaptureAlternateShortcutKeys2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppCaptureAlternateShortcutKeys2.xml' path='doc/member[@name="IAppCaptureAlternateShortcutKeys2.get_ToggleMicrophoneCaptureKeyModifiers"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_ToggleMicrophoneCaptureKeyModifiers([NativeTypeName("ABI::Windows::System::VirtualKeyModifiers *")] VirtualKeyModifiers* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppCaptureAlternateShortcutKeys2*, VirtualKeyModifiers*, int>)(lpVtbl[9]))((IAppCaptureAlternateShortcutKeys2*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT put_ToggleMicrophoneCaptureKey([NativeTypeName("ABI::Windows::System::VirtualKey")] VirtualKey value);

        [VtblIndex(7)]
        HRESULT get_ToggleMicrophoneCaptureKey([NativeTypeName("ABI::Windows::System::VirtualKey *")] VirtualKey* value);

        [VtblIndex(8)]
        HRESULT put_ToggleMicrophoneCaptureKeyModifiers([NativeTypeName("ABI::Windows::System::VirtualKeyModifiers")] VirtualKeyModifiers value);

        [VtblIndex(9)]
        HRESULT get_ToggleMicrophoneCaptureKeyModifiers([NativeTypeName("ABI::Windows::System::VirtualKeyModifiers *")] VirtualKeyModifiers* value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, VirtualKey, int> put_ToggleMicrophoneCaptureKey;

        [NativeTypeName("HRESULT (ABI::Windows::System::VirtualKey *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, VirtualKey*, int> get_ToggleMicrophoneCaptureKey;

        [NativeTypeName("HRESULT (ABI::Windows::System::VirtualKeyModifiers) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, VirtualKeyModifiers, int> put_ToggleMicrophoneCaptureKeyModifiers;

        [NativeTypeName("HRESULT (ABI::Windows::System::VirtualKeyModifiers *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, VirtualKeyModifiers*, int> get_ToggleMicrophoneCaptureKeyModifiers;
    }
}
