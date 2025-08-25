// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.capture.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAppCaptureAlternateShortcutKeys.xml' path='doc/member[@name="IAppCaptureAlternateShortcutKeys"]/*' />
[Guid("19E8E0EF-236C-40F9-B38F-9B7DD65D1CCC")]
[NativeTypeName("struct IAppCaptureAlternateShortcutKeys : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAppCaptureAlternateShortcutKeys : IAppCaptureAlternateShortcutKeys.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IAppCaptureAlternateShortcutKeys);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppCaptureAlternateShortcutKeys*, Guid*, void**, int>)(lpVtbl[0]))((IAppCaptureAlternateShortcutKeys*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppCaptureAlternateShortcutKeys*, uint>)(lpVtbl[1]))((IAppCaptureAlternateShortcutKeys*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppCaptureAlternateShortcutKeys*, uint>)(lpVtbl[2]))((IAppCaptureAlternateShortcutKeys*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppCaptureAlternateShortcutKeys*, uint*, Guid**, int>)(lpVtbl[3]))((IAppCaptureAlternateShortcutKeys*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppCaptureAlternateShortcutKeys*, HSTRING*, int>)(lpVtbl[4]))((IAppCaptureAlternateShortcutKeys*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppCaptureAlternateShortcutKeys*, TrustLevel*, int>)(lpVtbl[5]))((IAppCaptureAlternateShortcutKeys*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAppCaptureAlternateShortcutKeys.xml' path='doc/member[@name="IAppCaptureAlternateShortcutKeys.put_ToggleGameBarKey"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT put_ToggleGameBarKey([NativeTypeName("ABI::Windows::System::VirtualKey")] VirtualKey value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppCaptureAlternateShortcutKeys*, VirtualKey, int>)(lpVtbl[6]))((IAppCaptureAlternateShortcutKeys*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppCaptureAlternateShortcutKeys.xml' path='doc/member[@name="IAppCaptureAlternateShortcutKeys.get_ToggleGameBarKey"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_ToggleGameBarKey([NativeTypeName("ABI::Windows::System::VirtualKey *")] VirtualKey* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppCaptureAlternateShortcutKeys*, VirtualKey*, int>)(lpVtbl[7]))((IAppCaptureAlternateShortcutKeys*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppCaptureAlternateShortcutKeys.xml' path='doc/member[@name="IAppCaptureAlternateShortcutKeys.put_ToggleGameBarKeyModifiers"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_ToggleGameBarKeyModifiers([NativeTypeName("ABI::Windows::System::VirtualKeyModifiers")] VirtualKeyModifiers value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppCaptureAlternateShortcutKeys*, VirtualKeyModifiers, int>)(lpVtbl[8]))((IAppCaptureAlternateShortcutKeys*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppCaptureAlternateShortcutKeys.xml' path='doc/member[@name="IAppCaptureAlternateShortcutKeys.get_ToggleGameBarKeyModifiers"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_ToggleGameBarKeyModifiers([NativeTypeName("ABI::Windows::System::VirtualKeyModifiers *")] VirtualKeyModifiers* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppCaptureAlternateShortcutKeys*, VirtualKeyModifiers*, int>)(lpVtbl[9]))((IAppCaptureAlternateShortcutKeys*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppCaptureAlternateShortcutKeys.xml' path='doc/member[@name="IAppCaptureAlternateShortcutKeys.put_SaveHistoricalVideoKey"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT put_SaveHistoricalVideoKey([NativeTypeName("ABI::Windows::System::VirtualKey")] VirtualKey value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppCaptureAlternateShortcutKeys*, VirtualKey, int>)(lpVtbl[10]))((IAppCaptureAlternateShortcutKeys*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppCaptureAlternateShortcutKeys.xml' path='doc/member[@name="IAppCaptureAlternateShortcutKeys.get_SaveHistoricalVideoKey"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_SaveHistoricalVideoKey([NativeTypeName("ABI::Windows::System::VirtualKey *")] VirtualKey* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppCaptureAlternateShortcutKeys*, VirtualKey*, int>)(lpVtbl[11]))((IAppCaptureAlternateShortcutKeys*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppCaptureAlternateShortcutKeys.xml' path='doc/member[@name="IAppCaptureAlternateShortcutKeys.put_SaveHistoricalVideoKeyModifiers"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT put_SaveHistoricalVideoKeyModifiers([NativeTypeName("ABI::Windows::System::VirtualKeyModifiers")] VirtualKeyModifiers value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppCaptureAlternateShortcutKeys*, VirtualKeyModifiers, int>)(lpVtbl[12]))((IAppCaptureAlternateShortcutKeys*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppCaptureAlternateShortcutKeys.xml' path='doc/member[@name="IAppCaptureAlternateShortcutKeys.get_SaveHistoricalVideoKeyModifiers"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_SaveHistoricalVideoKeyModifiers([NativeTypeName("ABI::Windows::System::VirtualKeyModifiers *")] VirtualKeyModifiers* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppCaptureAlternateShortcutKeys*, VirtualKeyModifiers*, int>)(lpVtbl[13]))((IAppCaptureAlternateShortcutKeys*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppCaptureAlternateShortcutKeys.xml' path='doc/member[@name="IAppCaptureAlternateShortcutKeys.put_ToggleRecordingKey"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT put_ToggleRecordingKey([NativeTypeName("ABI::Windows::System::VirtualKey")] VirtualKey value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppCaptureAlternateShortcutKeys*, VirtualKey, int>)(lpVtbl[14]))((IAppCaptureAlternateShortcutKeys*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppCaptureAlternateShortcutKeys.xml' path='doc/member[@name="IAppCaptureAlternateShortcutKeys.get_ToggleRecordingKey"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_ToggleRecordingKey([NativeTypeName("ABI::Windows::System::VirtualKey *")] VirtualKey* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppCaptureAlternateShortcutKeys*, VirtualKey*, int>)(lpVtbl[15]))((IAppCaptureAlternateShortcutKeys*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppCaptureAlternateShortcutKeys.xml' path='doc/member[@name="IAppCaptureAlternateShortcutKeys.put_ToggleRecordingKeyModifiers"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT put_ToggleRecordingKeyModifiers([NativeTypeName("ABI::Windows::System::VirtualKeyModifiers")] VirtualKeyModifiers value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppCaptureAlternateShortcutKeys*, VirtualKeyModifiers, int>)(lpVtbl[16]))((IAppCaptureAlternateShortcutKeys*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppCaptureAlternateShortcutKeys.xml' path='doc/member[@name="IAppCaptureAlternateShortcutKeys.get_ToggleRecordingKeyModifiers"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_ToggleRecordingKeyModifiers([NativeTypeName("ABI::Windows::System::VirtualKeyModifiers *")] VirtualKeyModifiers* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppCaptureAlternateShortcutKeys*, VirtualKeyModifiers*, int>)(lpVtbl[17]))((IAppCaptureAlternateShortcutKeys*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppCaptureAlternateShortcutKeys.xml' path='doc/member[@name="IAppCaptureAlternateShortcutKeys.put_TakeScreenshotKey"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT put_TakeScreenshotKey([NativeTypeName("ABI::Windows::System::VirtualKey")] VirtualKey value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppCaptureAlternateShortcutKeys*, VirtualKey, int>)(lpVtbl[18]))((IAppCaptureAlternateShortcutKeys*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppCaptureAlternateShortcutKeys.xml' path='doc/member[@name="IAppCaptureAlternateShortcutKeys.get_TakeScreenshotKey"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_TakeScreenshotKey([NativeTypeName("ABI::Windows::System::VirtualKey *")] VirtualKey* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppCaptureAlternateShortcutKeys*, VirtualKey*, int>)(lpVtbl[19]))((IAppCaptureAlternateShortcutKeys*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppCaptureAlternateShortcutKeys.xml' path='doc/member[@name="IAppCaptureAlternateShortcutKeys.put_TakeScreenshotKeyModifiers"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT put_TakeScreenshotKeyModifiers([NativeTypeName("ABI::Windows::System::VirtualKeyModifiers")] VirtualKeyModifiers value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppCaptureAlternateShortcutKeys*, VirtualKeyModifiers, int>)(lpVtbl[20]))((IAppCaptureAlternateShortcutKeys*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppCaptureAlternateShortcutKeys.xml' path='doc/member[@name="IAppCaptureAlternateShortcutKeys.get_TakeScreenshotKeyModifiers"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT get_TakeScreenshotKeyModifiers([NativeTypeName("ABI::Windows::System::VirtualKeyModifiers *")] VirtualKeyModifiers* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppCaptureAlternateShortcutKeys*, VirtualKeyModifiers*, int>)(lpVtbl[21]))((IAppCaptureAlternateShortcutKeys*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppCaptureAlternateShortcutKeys.xml' path='doc/member[@name="IAppCaptureAlternateShortcutKeys.put_ToggleRecordingIndicatorKey"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT put_ToggleRecordingIndicatorKey([NativeTypeName("ABI::Windows::System::VirtualKey")] VirtualKey value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppCaptureAlternateShortcutKeys*, VirtualKey, int>)(lpVtbl[22]))((IAppCaptureAlternateShortcutKeys*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppCaptureAlternateShortcutKeys.xml' path='doc/member[@name="IAppCaptureAlternateShortcutKeys.get_ToggleRecordingIndicatorKey"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT get_ToggleRecordingIndicatorKey([NativeTypeName("ABI::Windows::System::VirtualKey *")] VirtualKey* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppCaptureAlternateShortcutKeys*, VirtualKey*, int>)(lpVtbl[23]))((IAppCaptureAlternateShortcutKeys*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppCaptureAlternateShortcutKeys.xml' path='doc/member[@name="IAppCaptureAlternateShortcutKeys.put_ToggleRecordingIndicatorKeyModifiers"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT put_ToggleRecordingIndicatorKeyModifiers([NativeTypeName("ABI::Windows::System::VirtualKeyModifiers")] VirtualKeyModifiers value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppCaptureAlternateShortcutKeys*, VirtualKeyModifiers, int>)(lpVtbl[24]))((IAppCaptureAlternateShortcutKeys*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppCaptureAlternateShortcutKeys.xml' path='doc/member[@name="IAppCaptureAlternateShortcutKeys.get_ToggleRecordingIndicatorKeyModifiers"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT get_ToggleRecordingIndicatorKeyModifiers([NativeTypeName("ABI::Windows::System::VirtualKeyModifiers *")] VirtualKeyModifiers* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppCaptureAlternateShortcutKeys*, VirtualKeyModifiers*, int>)(lpVtbl[25]))((IAppCaptureAlternateShortcutKeys*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT put_ToggleGameBarKey([NativeTypeName("ABI::Windows::System::VirtualKey")] VirtualKey value);

        [VtblIndex(7)]
        HRESULT get_ToggleGameBarKey([NativeTypeName("ABI::Windows::System::VirtualKey *")] VirtualKey* value);

        [VtblIndex(8)]
        HRESULT put_ToggleGameBarKeyModifiers([NativeTypeName("ABI::Windows::System::VirtualKeyModifiers")] VirtualKeyModifiers value);

        [VtblIndex(9)]
        HRESULT get_ToggleGameBarKeyModifiers([NativeTypeName("ABI::Windows::System::VirtualKeyModifiers *")] VirtualKeyModifiers* value);

        [VtblIndex(10)]
        HRESULT put_SaveHistoricalVideoKey([NativeTypeName("ABI::Windows::System::VirtualKey")] VirtualKey value);

        [VtblIndex(11)]
        HRESULT get_SaveHistoricalVideoKey([NativeTypeName("ABI::Windows::System::VirtualKey *")] VirtualKey* value);

        [VtblIndex(12)]
        HRESULT put_SaveHistoricalVideoKeyModifiers([NativeTypeName("ABI::Windows::System::VirtualKeyModifiers")] VirtualKeyModifiers value);

        [VtblIndex(13)]
        HRESULT get_SaveHistoricalVideoKeyModifiers([NativeTypeName("ABI::Windows::System::VirtualKeyModifiers *")] VirtualKeyModifiers* value);

        [VtblIndex(14)]
        HRESULT put_ToggleRecordingKey([NativeTypeName("ABI::Windows::System::VirtualKey")] VirtualKey value);

        [VtblIndex(15)]
        HRESULT get_ToggleRecordingKey([NativeTypeName("ABI::Windows::System::VirtualKey *")] VirtualKey* value);

        [VtblIndex(16)]
        HRESULT put_ToggleRecordingKeyModifiers([NativeTypeName("ABI::Windows::System::VirtualKeyModifiers")] VirtualKeyModifiers value);

        [VtblIndex(17)]
        HRESULT get_ToggleRecordingKeyModifiers([NativeTypeName("ABI::Windows::System::VirtualKeyModifiers *")] VirtualKeyModifiers* value);

        [VtblIndex(18)]
        HRESULT put_TakeScreenshotKey([NativeTypeName("ABI::Windows::System::VirtualKey")] VirtualKey value);

        [VtblIndex(19)]
        HRESULT get_TakeScreenshotKey([NativeTypeName("ABI::Windows::System::VirtualKey *")] VirtualKey* value);

        [VtblIndex(20)]
        HRESULT put_TakeScreenshotKeyModifiers([NativeTypeName("ABI::Windows::System::VirtualKeyModifiers")] VirtualKeyModifiers value);

        [VtblIndex(21)]
        HRESULT get_TakeScreenshotKeyModifiers([NativeTypeName("ABI::Windows::System::VirtualKeyModifiers *")] VirtualKeyModifiers* value);

        [VtblIndex(22)]
        HRESULT put_ToggleRecordingIndicatorKey([NativeTypeName("ABI::Windows::System::VirtualKey")] VirtualKey value);

        [VtblIndex(23)]
        HRESULT get_ToggleRecordingIndicatorKey([NativeTypeName("ABI::Windows::System::VirtualKey *")] VirtualKey* value);

        [VtblIndex(24)]
        HRESULT put_ToggleRecordingIndicatorKeyModifiers([NativeTypeName("ABI::Windows::System::VirtualKeyModifiers")] VirtualKeyModifiers value);

        [VtblIndex(25)]
        HRESULT get_ToggleRecordingIndicatorKeyModifiers([NativeTypeName("ABI::Windows::System::VirtualKeyModifiers *")] VirtualKeyModifiers* value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, VirtualKey, int> put_ToggleGameBarKey;

        [NativeTypeName("HRESULT (ABI::Windows::System::VirtualKey *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, VirtualKey*, int> get_ToggleGameBarKey;

        [NativeTypeName("HRESULT (ABI::Windows::System::VirtualKeyModifiers) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, VirtualKeyModifiers, int> put_ToggleGameBarKeyModifiers;

        [NativeTypeName("HRESULT (ABI::Windows::System::VirtualKeyModifiers *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, VirtualKeyModifiers*, int> get_ToggleGameBarKeyModifiers;

        [NativeTypeName("HRESULT (ABI::Windows::System::VirtualKey) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, VirtualKey, int> put_SaveHistoricalVideoKey;

        [NativeTypeName("HRESULT (ABI::Windows::System::VirtualKey *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, VirtualKey*, int> get_SaveHistoricalVideoKey;

        [NativeTypeName("HRESULT (ABI::Windows::System::VirtualKeyModifiers) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, VirtualKeyModifiers, int> put_SaveHistoricalVideoKeyModifiers;

        [NativeTypeName("HRESULT (ABI::Windows::System::VirtualKeyModifiers *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, VirtualKeyModifiers*, int> get_SaveHistoricalVideoKeyModifiers;

        [NativeTypeName("HRESULT (ABI::Windows::System::VirtualKey) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, VirtualKey, int> put_ToggleRecordingKey;

        [NativeTypeName("HRESULT (ABI::Windows::System::VirtualKey *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, VirtualKey*, int> get_ToggleRecordingKey;

        [NativeTypeName("HRESULT (ABI::Windows::System::VirtualKeyModifiers) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, VirtualKeyModifiers, int> put_ToggleRecordingKeyModifiers;

        [NativeTypeName("HRESULT (ABI::Windows::System::VirtualKeyModifiers *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, VirtualKeyModifiers*, int> get_ToggleRecordingKeyModifiers;

        [NativeTypeName("HRESULT (ABI::Windows::System::VirtualKey) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, VirtualKey, int> put_TakeScreenshotKey;

        [NativeTypeName("HRESULT (ABI::Windows::System::VirtualKey *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, VirtualKey*, int> get_TakeScreenshotKey;

        [NativeTypeName("HRESULT (ABI::Windows::System::VirtualKeyModifiers) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, VirtualKeyModifiers, int> put_TakeScreenshotKeyModifiers;

        [NativeTypeName("HRESULT (ABI::Windows::System::VirtualKeyModifiers *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, VirtualKeyModifiers*, int> get_TakeScreenshotKeyModifiers;

        [NativeTypeName("HRESULT (ABI::Windows::System::VirtualKey) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, VirtualKey, int> put_ToggleRecordingIndicatorKey;

        [NativeTypeName("HRESULT (ABI::Windows::System::VirtualKey *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, VirtualKey*, int> get_ToggleRecordingIndicatorKey;

        [NativeTypeName("HRESULT (ABI::Windows::System::VirtualKeyModifiers) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, VirtualKeyModifiers, int> put_ToggleRecordingIndicatorKeyModifiers;

        [NativeTypeName("HRESULT (ABI::Windows::System::VirtualKeyModifiers *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, VirtualKeyModifiers*, int> get_ToggleRecordingIndicatorKeyModifiers;
    }
}
