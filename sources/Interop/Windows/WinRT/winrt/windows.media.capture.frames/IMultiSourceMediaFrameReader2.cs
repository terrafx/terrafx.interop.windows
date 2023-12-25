// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.capture.frames.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IMultiSourceMediaFrameReader2.xml' path='doc/member[@name="IMultiSourceMediaFrameReader2"]/*' />
[Guid("EF5C8ABD-FC5C-4C6B-9D81-3CB9CC637C26")]
[NativeTypeName("struct IMultiSourceMediaFrameReader2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMultiSourceMediaFrameReader2 : IMultiSourceMediaFrameReader2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMultiSourceMediaFrameReader2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMultiSourceMediaFrameReader2*, Guid*, void**, int>)(lpVtbl[0]))((IMultiSourceMediaFrameReader2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMultiSourceMediaFrameReader2*, uint>)(lpVtbl[1]))((IMultiSourceMediaFrameReader2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMultiSourceMediaFrameReader2*, uint>)(lpVtbl[2]))((IMultiSourceMediaFrameReader2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IMultiSourceMediaFrameReader2*, uint*, Guid**, int>)(lpVtbl[3]))((IMultiSourceMediaFrameReader2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IMultiSourceMediaFrameReader2*, HSTRING*, int>)(lpVtbl[4]))((IMultiSourceMediaFrameReader2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IMultiSourceMediaFrameReader2*, TrustLevel*, int>)(lpVtbl[5]))((IMultiSourceMediaFrameReader2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IMultiSourceMediaFrameReader2.xml' path='doc/member[@name="IMultiSourceMediaFrameReader2.put_AcquisitionMode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT put_AcquisitionMode([NativeTypeName("ABI::Windows::Media::Capture::Frames::MediaFrameReaderAcquisitionMode")] MediaFrameReaderAcquisitionMode value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMultiSourceMediaFrameReader2*, MediaFrameReaderAcquisitionMode, int>)(lpVtbl[6]))((IMultiSourceMediaFrameReader2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMultiSourceMediaFrameReader2.xml' path='doc/member[@name="IMultiSourceMediaFrameReader2.get_AcquisitionMode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_AcquisitionMode([NativeTypeName("ABI::Windows::Media::Capture::Frames::MediaFrameReaderAcquisitionMode *")] MediaFrameReaderAcquisitionMode* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMultiSourceMediaFrameReader2*, MediaFrameReaderAcquisitionMode*, int>)(lpVtbl[7]))((IMultiSourceMediaFrameReader2*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT put_AcquisitionMode([NativeTypeName("ABI::Windows::Media::Capture::Frames::MediaFrameReaderAcquisitionMode")] MediaFrameReaderAcquisitionMode value);

        [VtblIndex(7)]
        HRESULT get_AcquisitionMode([NativeTypeName("ABI::Windows::Media::Capture::Frames::MediaFrameReaderAcquisitionMode *")] MediaFrameReaderAcquisitionMode* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Media::Capture::Frames::MediaFrameReaderAcquisitionMode) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, MediaFrameReaderAcquisitionMode, int> put_AcquisitionMode;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Capture::Frames::MediaFrameReaderAcquisitionMode *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, MediaFrameReaderAcquisitionMode*, int> get_AcquisitionMode;
    }
}
