// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.audio.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAudioStateMonitor.xml' path='doc/member[@name="IAudioStateMonitor"]/*' />
[Guid("1D13D136-0199-4CDC-B84E-E72C2B581ECE")]
[NativeTypeName("struct IAudioStateMonitor : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAudioStateMonitor : IAudioStateMonitor.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAudioStateMonitor));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioStateMonitor*, Guid*, void**, int>)(lpVtbl[0]))((IAudioStateMonitor*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioStateMonitor*, uint>)(lpVtbl[1]))((IAudioStateMonitor*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioStateMonitor*, uint>)(lpVtbl[2]))((IAudioStateMonitor*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioStateMonitor*, uint*, Guid**, int>)(lpVtbl[3]))((IAudioStateMonitor*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioStateMonitor*, HSTRING*, int>)(lpVtbl[4]))((IAudioStateMonitor*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioStateMonitor*, TrustLevel*, int>)(lpVtbl[5]))((IAudioStateMonitor*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAudioStateMonitor.xml' path='doc/member[@name="IAudioStateMonitor.add_SoundLevelChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT add_SoundLevelChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CAudio__CAudioStateMonitor_IInspectable_t *")] ITypedEventHandler<Pointer<IAudioStateMonitor>, Pointer<IInspectable>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioStateMonitor*, ITypedEventHandler<Pointer<IAudioStateMonitor>, Pointer<IInspectable>>*, EventRegistrationToken*, int>)(lpVtbl[6]))((IAudioStateMonitor*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IAudioStateMonitor.xml' path='doc/member[@name="IAudioStateMonitor.remove_SoundLevelChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT remove_SoundLevelChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioStateMonitor*, EventRegistrationToken, int>)(lpVtbl[7]))((IAudioStateMonitor*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IAudioStateMonitor.xml' path='doc/member[@name="IAudioStateMonitor.get_SoundLevel"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_SoundLevel([NativeTypeName("ABI::Windows::Media::SoundLevel *")] SoundLevel* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioStateMonitor*, SoundLevel*, int>)(lpVtbl[8]))((IAudioStateMonitor*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT add_SoundLevelChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CAudio__CAudioStateMonitor_IInspectable_t *")] ITypedEventHandler<Pointer<IAudioStateMonitor>, Pointer<IInspectable>>* handler, EventRegistrationToken* token);

        [VtblIndex(7)]
        HRESULT remove_SoundLevelChanged(EventRegistrationToken token);

        [VtblIndex(8)]
        HRESULT get_SoundLevel([NativeTypeName("ABI::Windows::Media::SoundLevel *")] SoundLevel* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CAudio__CAudioStateMonitor_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IAudioStateMonitor>, Pointer<IInspectable>>*, EventRegistrationToken*, int> add_SoundLevelChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_SoundLevelChanged;

        [NativeTypeName("HRESULT (ABI::Windows::Media::SoundLevel *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SoundLevel*, int> get_SoundLevel;
    }
}
