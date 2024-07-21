// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.graphics.display.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IHdmiDisplayMode.xml' path='doc/member[@name="IHdmiDisplayMode"]/*' />
[Guid("0C06D5AD-1B90-4F51-9981-EF5A1C0DDF66")]
[NativeTypeName("struct IHdmiDisplayMode : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IHdmiDisplayMode : IHdmiDisplayMode.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHdmiDisplayMode));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IHdmiDisplayMode*, Guid*, void**, int>)(lpVtbl[0]))((IHdmiDisplayMode*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IHdmiDisplayMode*, uint>)(lpVtbl[1]))((IHdmiDisplayMode*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IHdmiDisplayMode*, uint>)(lpVtbl[2]))((IHdmiDisplayMode*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IHdmiDisplayMode*, uint*, Guid**, int>)(lpVtbl[3]))((IHdmiDisplayMode*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IHdmiDisplayMode*, HSTRING*, int>)(lpVtbl[4]))((IHdmiDisplayMode*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IHdmiDisplayMode*, TrustLevel*, int>)(lpVtbl[5]))((IHdmiDisplayMode*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IHdmiDisplayMode.xml' path='doc/member[@name="IHdmiDisplayMode.get_ResolutionWidthInRawPixels"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_ResolutionWidthInRawPixels([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHdmiDisplayMode*, uint*, int>)(lpVtbl[6]))((IHdmiDisplayMode*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHdmiDisplayMode.xml' path='doc/member[@name="IHdmiDisplayMode.get_ResolutionHeightInRawPixels"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_ResolutionHeightInRawPixels([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHdmiDisplayMode*, uint*, int>)(lpVtbl[7]))((IHdmiDisplayMode*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHdmiDisplayMode.xml' path='doc/member[@name="IHdmiDisplayMode.get_RefreshRate"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_RefreshRate(double* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHdmiDisplayMode*, double*, int>)(lpVtbl[8]))((IHdmiDisplayMode*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHdmiDisplayMode.xml' path='doc/member[@name="IHdmiDisplayMode.get_StereoEnabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_StereoEnabled([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHdmiDisplayMode*, byte*, int>)(lpVtbl[9]))((IHdmiDisplayMode*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHdmiDisplayMode.xml' path='doc/member[@name="IHdmiDisplayMode.get_BitsPerPixel"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_BitsPerPixel([NativeTypeName("UINT16 *")] ushort* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHdmiDisplayMode*, ushort*, int>)(lpVtbl[10]))((IHdmiDisplayMode*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHdmiDisplayMode.xml' path='doc/member[@name="IHdmiDisplayMode.IsEqual"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT IsEqual([NativeTypeName("ABI::Windows::Graphics::Display::Core::IHdmiDisplayMode *")] IHdmiDisplayMode* mode, [NativeTypeName("boolean *")] byte* result)
    {
        return ((delegate* unmanaged[MemberFunction]<IHdmiDisplayMode*, IHdmiDisplayMode*, byte*, int>)(lpVtbl[11]))((IHdmiDisplayMode*)Unsafe.AsPointer(ref this), mode, result);
    }

    /// <include file='IHdmiDisplayMode.xml' path='doc/member[@name="IHdmiDisplayMode.get_ColorSpace"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_ColorSpace([NativeTypeName("ABI::Windows::Graphics::Display::Core::HdmiDisplayColorSpace *")] HdmiDisplayColorSpace* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHdmiDisplayMode*, HdmiDisplayColorSpace*, int>)(lpVtbl[12]))((IHdmiDisplayMode*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHdmiDisplayMode.xml' path='doc/member[@name="IHdmiDisplayMode.get_PixelEncoding"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_PixelEncoding([NativeTypeName("ABI::Windows::Graphics::Display::Core::HdmiDisplayPixelEncoding *")] HdmiDisplayPixelEncoding* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHdmiDisplayMode*, HdmiDisplayPixelEncoding*, int>)(lpVtbl[13]))((IHdmiDisplayMode*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHdmiDisplayMode.xml' path='doc/member[@name="IHdmiDisplayMode.get_IsSdrLuminanceSupported"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_IsSdrLuminanceSupported([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHdmiDisplayMode*, byte*, int>)(lpVtbl[14]))((IHdmiDisplayMode*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHdmiDisplayMode.xml' path='doc/member[@name="IHdmiDisplayMode.get_IsSmpte2084Supported"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_IsSmpte2084Supported([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHdmiDisplayMode*, byte*, int>)(lpVtbl[15]))((IHdmiDisplayMode*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHdmiDisplayMode.xml' path='doc/member[@name="IHdmiDisplayMode.get_Is2086MetadataSupported"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_Is2086MetadataSupported([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHdmiDisplayMode*, byte*, int>)(lpVtbl[16]))((IHdmiDisplayMode*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_ResolutionWidthInRawPixels([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(7)]
        HRESULT get_ResolutionHeightInRawPixels([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(8)]
        HRESULT get_RefreshRate(double* value);

        [VtblIndex(9)]
        HRESULT get_StereoEnabled([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(10)]
        HRESULT get_BitsPerPixel([NativeTypeName("UINT16 *")] ushort* value);

        [VtblIndex(11)]
        HRESULT IsEqual([NativeTypeName("ABI::Windows::Graphics::Display::Core::IHdmiDisplayMode *")] IHdmiDisplayMode* mode, [NativeTypeName("boolean *")] byte* result);

        [VtblIndex(12)]
        HRESULT get_ColorSpace([NativeTypeName("ABI::Windows::Graphics::Display::Core::HdmiDisplayColorSpace *")] HdmiDisplayColorSpace* value);

        [VtblIndex(13)]
        HRESULT get_PixelEncoding([NativeTypeName("ABI::Windows::Graphics::Display::Core::HdmiDisplayPixelEncoding *")] HdmiDisplayPixelEncoding* value);

        [VtblIndex(14)]
        HRESULT get_IsSdrLuminanceSupported([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(15)]
        HRESULT get_IsSmpte2084Supported([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(16)]
        HRESULT get_Is2086MetadataSupported([NativeTypeName("boolean *")] byte* value);
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

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_ResolutionWidthInRawPixels;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_ResolutionHeightInRawPixels;

        [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double*, int> get_RefreshRate;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_StereoEnabled;

        [NativeTypeName("HRESULT (UINT16 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ushort*, int> get_BitsPerPixel;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Display::Core::IHdmiDisplayMode *, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IHdmiDisplayMode*, byte*, int> IsEqual;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Display::Core::HdmiDisplayColorSpace *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HdmiDisplayColorSpace*, int> get_ColorSpace;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Display::Core::HdmiDisplayPixelEncoding *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HdmiDisplayPixelEncoding*, int> get_PixelEncoding;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsSdrLuminanceSupported;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsSmpte2084Supported;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_Is2086MetadataSupported;
    }
}
