// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.graphics.imaging.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ISoftwareBitmap.xml' path='doc/member[@name="ISoftwareBitmap"]/*' />
[Guid("689E0708-7EEF-483F-963F-DA938818E073")]
[NativeTypeName("struct ISoftwareBitmap : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISoftwareBitmap : ISoftwareBitmap.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISoftwareBitmap));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISoftwareBitmap*, Guid*, void**, int>)(lpVtbl[0]))((ISoftwareBitmap*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISoftwareBitmap*, uint>)(lpVtbl[1]))((ISoftwareBitmap*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISoftwareBitmap*, uint>)(lpVtbl[2]))((ISoftwareBitmap*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ISoftwareBitmap*, uint*, Guid**, int>)(lpVtbl[3]))((ISoftwareBitmap*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ISoftwareBitmap*, HSTRING*, int>)(lpVtbl[4]))((ISoftwareBitmap*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ISoftwareBitmap*, TrustLevel*, int>)(lpVtbl[5]))((ISoftwareBitmap*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ISoftwareBitmap.xml' path='doc/member[@name="ISoftwareBitmap.get_BitmapPixelFormat"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_BitmapPixelFormat([NativeTypeName("ABI::Windows::Graphics::Imaging::BitmapPixelFormat *")] BitmapPixelFormat* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISoftwareBitmap*, BitmapPixelFormat*, int>)(lpVtbl[6]))((ISoftwareBitmap*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISoftwareBitmap.xml' path='doc/member[@name="ISoftwareBitmap.get_BitmapAlphaMode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_BitmapAlphaMode([NativeTypeName("ABI::Windows::Graphics::Imaging::BitmapAlphaMode *")] BitmapAlphaMode* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISoftwareBitmap*, BitmapAlphaMode*, int>)(lpVtbl[7]))((ISoftwareBitmap*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISoftwareBitmap.xml' path='doc/member[@name="ISoftwareBitmap.get_PixelWidth"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_PixelWidth([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISoftwareBitmap*, int*, int>)(lpVtbl[8]))((ISoftwareBitmap*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISoftwareBitmap.xml' path='doc/member[@name="ISoftwareBitmap.get_PixelHeight"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_PixelHeight([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISoftwareBitmap*, int*, int>)(lpVtbl[9]))((ISoftwareBitmap*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISoftwareBitmap.xml' path='doc/member[@name="ISoftwareBitmap.get_IsReadOnly"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_IsReadOnly([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISoftwareBitmap*, byte*, int>)(lpVtbl[10]))((ISoftwareBitmap*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISoftwareBitmap.xml' path='doc/member[@name="ISoftwareBitmap.put_DpiX"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_DpiX(double value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISoftwareBitmap*, double, int>)(lpVtbl[11]))((ISoftwareBitmap*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISoftwareBitmap.xml' path='doc/member[@name="ISoftwareBitmap.get_DpiX"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_DpiX(double* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISoftwareBitmap*, double*, int>)(lpVtbl[12]))((ISoftwareBitmap*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISoftwareBitmap.xml' path='doc/member[@name="ISoftwareBitmap.put_DpiY"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_DpiY(double value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISoftwareBitmap*, double, int>)(lpVtbl[13]))((ISoftwareBitmap*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISoftwareBitmap.xml' path='doc/member[@name="ISoftwareBitmap.get_DpiY"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_DpiY(double* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISoftwareBitmap*, double*, int>)(lpVtbl[14]))((ISoftwareBitmap*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISoftwareBitmap.xml' path='doc/member[@name="ISoftwareBitmap.LockBuffer"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT LockBuffer([NativeTypeName("ABI::Windows::Graphics::Imaging::BitmapBufferAccessMode")] BitmapBufferAccessMode mode, [NativeTypeName("ABI::Windows::Graphics::Imaging::IBitmapBuffer **")] IBitmapBuffer** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISoftwareBitmap*, BitmapBufferAccessMode, IBitmapBuffer**, int>)(lpVtbl[15]))((ISoftwareBitmap*)Unsafe.AsPointer(ref this), mode, value);
    }

    /// <include file='ISoftwareBitmap.xml' path='doc/member[@name="ISoftwareBitmap.CopyTo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT CopyTo([NativeTypeName("ABI::Windows::Graphics::Imaging::ISoftwareBitmap *")] ISoftwareBitmap* bitmap)
    {
        return ((delegate* unmanaged[MemberFunction]<ISoftwareBitmap*, ISoftwareBitmap*, int>)(lpVtbl[16]))((ISoftwareBitmap*)Unsafe.AsPointer(ref this), bitmap);
    }

    /// <include file='ISoftwareBitmap.xml' path='doc/member[@name="ISoftwareBitmap.CopyFromBuffer"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT CopyFromBuffer([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* buffer)
    {
        return ((delegate* unmanaged[MemberFunction]<ISoftwareBitmap*, IBuffer*, int>)(lpVtbl[17]))((ISoftwareBitmap*)Unsafe.AsPointer(ref this), buffer);
    }

    /// <include file='ISoftwareBitmap.xml' path='doc/member[@name="ISoftwareBitmap.CopyToBuffer"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT CopyToBuffer([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* buffer)
    {
        return ((delegate* unmanaged[MemberFunction]<ISoftwareBitmap*, IBuffer*, int>)(lpVtbl[18]))((ISoftwareBitmap*)Unsafe.AsPointer(ref this), buffer);
    }

    /// <include file='ISoftwareBitmap.xml' path='doc/member[@name="ISoftwareBitmap.GetReadOnlyView"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT GetReadOnlyView([NativeTypeName("ABI::Windows::Graphics::Imaging::ISoftwareBitmap **")] ISoftwareBitmap** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISoftwareBitmap*, ISoftwareBitmap**, int>)(lpVtbl[19]))((ISoftwareBitmap*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_BitmapPixelFormat([NativeTypeName("ABI::Windows::Graphics::Imaging::BitmapPixelFormat *")] BitmapPixelFormat* value);

        [VtblIndex(7)]
        HRESULT get_BitmapAlphaMode([NativeTypeName("ABI::Windows::Graphics::Imaging::BitmapAlphaMode *")] BitmapAlphaMode* value);

        [VtblIndex(8)]
        HRESULT get_PixelWidth([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(9)]
        HRESULT get_PixelHeight([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(10)]
        HRESULT get_IsReadOnly([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(11)]
        HRESULT put_DpiX(double value);

        [VtblIndex(12)]
        HRESULT get_DpiX(double* value);

        [VtblIndex(13)]
        HRESULT put_DpiY(double value);

        [VtblIndex(14)]
        HRESULT get_DpiY(double* value);

        [VtblIndex(15)]
        HRESULT LockBuffer([NativeTypeName("ABI::Windows::Graphics::Imaging::BitmapBufferAccessMode")] BitmapBufferAccessMode mode, [NativeTypeName("ABI::Windows::Graphics::Imaging::IBitmapBuffer **")] IBitmapBuffer** value);

        [VtblIndex(16)]
        HRESULT CopyTo([NativeTypeName("ABI::Windows::Graphics::Imaging::ISoftwareBitmap *")] ISoftwareBitmap* bitmap);

        [VtblIndex(17)]
        HRESULT CopyFromBuffer([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* buffer);

        [VtblIndex(18)]
        HRESULT CopyToBuffer([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* buffer);

        [VtblIndex(19)]
        HRESULT GetReadOnlyView([NativeTypeName("ABI::Windows::Graphics::Imaging::ISoftwareBitmap **")] ISoftwareBitmap** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Imaging::BitmapPixelFormat *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BitmapPixelFormat*, int> get_BitmapPixelFormat;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Imaging::BitmapAlphaMode *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BitmapAlphaMode*, int> get_BitmapAlphaMode;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_PixelWidth;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_PixelHeight;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsReadOnly;

        [NativeTypeName("HRESULT (DOUBLE) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double, int> put_DpiX;

        [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double*, int> get_DpiX;

        [NativeTypeName("HRESULT (DOUBLE) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double, int> put_DpiY;

        [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double*, int> get_DpiY;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Imaging::BitmapBufferAccessMode, ABI::Windows::Graphics::Imaging::IBitmapBuffer **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BitmapBufferAccessMode, IBitmapBuffer**, int> LockBuffer;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Imaging::ISoftwareBitmap *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ISoftwareBitmap*, int> CopyTo;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IBuffer *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBuffer*, int> CopyFromBuffer;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IBuffer *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBuffer*, int> CopyToBuffer;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Imaging::ISoftwareBitmap **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ISoftwareBitmap**, int> GetReadOnlyView;
    }
}
