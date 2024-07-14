// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.capture.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAdvancedCapturedPhoto.xml' path='doc/member[@name="IAdvancedCapturedPhoto"]/*' />
[Guid("F072728B-B292-4491-9D41-99807A550BBF")]
[NativeTypeName("struct IAdvancedCapturedPhoto : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAdvancedCapturedPhoto : IAdvancedCapturedPhoto.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAdvancedCapturedPhoto));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdvancedCapturedPhoto*, Guid*, void**, int>)(lpVtbl[0]))((IAdvancedCapturedPhoto*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAdvancedCapturedPhoto*, uint>)(lpVtbl[1]))((IAdvancedCapturedPhoto*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAdvancedCapturedPhoto*, uint>)(lpVtbl[2]))((IAdvancedCapturedPhoto*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdvancedCapturedPhoto*, uint*, Guid**, int>)(lpVtbl[3]))((IAdvancedCapturedPhoto*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdvancedCapturedPhoto*, HSTRING*, int>)(lpVtbl[4]))((IAdvancedCapturedPhoto*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdvancedCapturedPhoto*, TrustLevel*, int>)(lpVtbl[5]))((IAdvancedCapturedPhoto*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAdvancedCapturedPhoto.xml' path='doc/member[@name="IAdvancedCapturedPhoto.get_Frame"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Frame([NativeTypeName("ABI::Windows::Media::Capture::ICapturedFrame **")] ICapturedFrame** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdvancedCapturedPhoto*, ICapturedFrame**, int>)(lpVtbl[6]))((IAdvancedCapturedPhoto*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAdvancedCapturedPhoto.xml' path='doc/member[@name="IAdvancedCapturedPhoto.get_Mode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Mode([NativeTypeName("ABI::Windows::Media::Devices::AdvancedPhotoMode *")] AdvancedPhotoMode* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdvancedCapturedPhoto*, AdvancedPhotoMode*, int>)(lpVtbl[7]))((IAdvancedCapturedPhoto*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAdvancedCapturedPhoto.xml' path='doc/member[@name="IAdvancedCapturedPhoto.get_Context"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Context(IInspectable** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdvancedCapturedPhoto*, IInspectable**, int>)(lpVtbl[8]))((IAdvancedCapturedPhoto*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Frame([NativeTypeName("ABI::Windows::Media::Capture::ICapturedFrame **")] ICapturedFrame** value);

        [VtblIndex(7)]
        HRESULT get_Mode([NativeTypeName("ABI::Windows::Media::Devices::AdvancedPhotoMode *")] AdvancedPhotoMode* value);

        [VtblIndex(8)]
        HRESULT get_Context(IInspectable** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Media::Capture::ICapturedFrame **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ICapturedFrame**, int> get_Frame;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Devices::AdvancedPhotoMode *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, AdvancedPhotoMode*, int> get_Mode;

        [NativeTypeName("HRESULT (IInspectable **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IInspectable**, int> get_Context;
    }
}
