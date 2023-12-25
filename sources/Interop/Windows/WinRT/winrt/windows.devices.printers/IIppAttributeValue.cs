// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.printers.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IIppAttributeValue.xml' path='doc/member[@name="IIppAttributeValue"]/*' />
[Guid("99407FED-E2BB-59A3-988B-28A974052A26")]
[NativeTypeName("struct IIppAttributeValue : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IIppAttributeValue : IIppAttributeValue.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IIppAttributeValue));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IIppAttributeValue*, Guid*, void**, int>)(lpVtbl[0]))((IIppAttributeValue*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IIppAttributeValue*, uint>)(lpVtbl[1]))((IIppAttributeValue*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IIppAttributeValue*, uint>)(lpVtbl[2]))((IIppAttributeValue*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IIppAttributeValue*, uint*, Guid**, int>)(lpVtbl[3]))((IIppAttributeValue*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IIppAttributeValue*, HSTRING*, int>)(lpVtbl[4]))((IIppAttributeValue*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IIppAttributeValue*, TrustLevel*, int>)(lpVtbl[5]))((IIppAttributeValue*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IIppAttributeValue.xml' path='doc/member[@name="IIppAttributeValue.get_Kind"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Kind([NativeTypeName("ABI::Windows::Devices::Printers::IppAttributeValueKind *")] IppAttributeValueKind* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IIppAttributeValue*, IppAttributeValueKind*, int>)(lpVtbl[6]))((IIppAttributeValue*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IIppAttributeValue.xml' path='doc/member[@name="IIppAttributeValue.GetIntegerArray"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetIntegerArray([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_int_t **")] IVector<int>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IIppAttributeValue*, IVector<int>**, int>)(lpVtbl[7]))((IIppAttributeValue*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IIppAttributeValue.xml' path='doc/member[@name="IIppAttributeValue.GetBooleanArray"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetBooleanArray([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_boolean_t **")] IVector<bool>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IIppAttributeValue*, IVector<bool>**, int>)(lpVtbl[8]))((IIppAttributeValue*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IIppAttributeValue.xml' path='doc/member[@name="IIppAttributeValue.GetEnumArray"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetEnumArray([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_int_t **")] IVector<int>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IIppAttributeValue*, IVector<int>**, int>)(lpVtbl[9]))((IIppAttributeValue*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IIppAttributeValue.xml' path='doc/member[@name="IIppAttributeValue.GetOctetStringArray"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetOctetStringArray([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CStorage__CStreams__CIBuffer_t **")] IVector<IntPtr>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IIppAttributeValue*, IVector<IntPtr>**, int>)(lpVtbl[10]))((IIppAttributeValue*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IIppAttributeValue.xml' path='doc/member[@name="IIppAttributeValue.GetDateTimeArray"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetDateTimeArray([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CFoundation__CDateTime_t **")] IVector<DateTime>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IIppAttributeValue*, IVector<DateTime>**, int>)(lpVtbl[11]))((IIppAttributeValue*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IIppAttributeValue.xml' path='doc/member[@name="IIppAttributeValue.GetResolutionArray"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetResolutionArray([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CDevices__CPrinters__CIppResolution_t **")] IVector<IntPtr>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IIppAttributeValue*, IVector<IntPtr>**, int>)(lpVtbl[12]))((IIppAttributeValue*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IIppAttributeValue.xml' path='doc/member[@name="IIppAttributeValue.GetRangeOfIntegerArray"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetRangeOfIntegerArray([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CDevices__CPrinters__CIppIntegerRange_t **")] IVector<IntPtr>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IIppAttributeValue*, IVector<IntPtr>**, int>)(lpVtbl[13]))((IIppAttributeValue*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IIppAttributeValue.xml' path='doc/member[@name="IIppAttributeValue.GetCollectionArray"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetCollectionArray([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1___FIMapView_2_HSTRING_Windows__CDevices__CPrinters__CIppAttributeValue_t **")] IVector<IntPtr>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IIppAttributeValue*, IVector<IntPtr>**, int>)(lpVtbl[14]))((IIppAttributeValue*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IIppAttributeValue.xml' path='doc/member[@name="IIppAttributeValue.GetTextWithLanguageArray"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT GetTextWithLanguageArray([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CDevices__CPrinters__CIppTextWithLanguage_t **")] IVector<IntPtr>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IIppAttributeValue*, IVector<IntPtr>**, int>)(lpVtbl[15]))((IIppAttributeValue*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IIppAttributeValue.xml' path='doc/member[@name="IIppAttributeValue.GetNameWithLanguageArray"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT GetNameWithLanguageArray([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CDevices__CPrinters__CIppTextWithLanguage_t **")] IVector<IntPtr>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IIppAttributeValue*, IVector<IntPtr>**, int>)(lpVtbl[16]))((IIppAttributeValue*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IIppAttributeValue.xml' path='doc/member[@name="IIppAttributeValue.GetTextWithoutLanguageArray"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT GetTextWithoutLanguageArray([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")] IVector<HSTRING>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IIppAttributeValue*, IVector<HSTRING>**, int>)(lpVtbl[17]))((IIppAttributeValue*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IIppAttributeValue.xml' path='doc/member[@name="IIppAttributeValue.GetNameWithoutLanguageArray"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT GetNameWithoutLanguageArray([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")] IVector<HSTRING>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IIppAttributeValue*, IVector<HSTRING>**, int>)(lpVtbl[18]))((IIppAttributeValue*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IIppAttributeValue.xml' path='doc/member[@name="IIppAttributeValue.GetKeywordArray"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT GetKeywordArray([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")] IVector<HSTRING>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IIppAttributeValue*, IVector<HSTRING>**, int>)(lpVtbl[19]))((IIppAttributeValue*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IIppAttributeValue.xml' path='doc/member[@name="IIppAttributeValue.GetUriArray"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT GetUriArray([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CFoundation__CUri_t **")] IVector<IntPtr>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IIppAttributeValue*, IVector<IntPtr>**, int>)(lpVtbl[20]))((IIppAttributeValue*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IIppAttributeValue.xml' path='doc/member[@name="IIppAttributeValue.GetUriSchemaArray"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT GetUriSchemaArray([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")] IVector<HSTRING>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IIppAttributeValue*, IVector<HSTRING>**, int>)(lpVtbl[21]))((IIppAttributeValue*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IIppAttributeValue.xml' path='doc/member[@name="IIppAttributeValue.GetCharsetArray"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT GetCharsetArray([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")] IVector<HSTRING>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IIppAttributeValue*, IVector<HSTRING>**, int>)(lpVtbl[22]))((IIppAttributeValue*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IIppAttributeValue.xml' path='doc/member[@name="IIppAttributeValue.GetNaturalLanguageArray"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT GetNaturalLanguageArray([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")] IVector<HSTRING>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IIppAttributeValue*, IVector<HSTRING>**, int>)(lpVtbl[23]))((IIppAttributeValue*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IIppAttributeValue.xml' path='doc/member[@name="IIppAttributeValue.GetMimeMediaTypeArray"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT GetMimeMediaTypeArray([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")] IVector<HSTRING>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IIppAttributeValue*, IVector<HSTRING>**, int>)(lpVtbl[24]))((IIppAttributeValue*)Unsafe.AsPointer(ref this), result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Kind([NativeTypeName("ABI::Windows::Devices::Printers::IppAttributeValueKind *")] IppAttributeValueKind* value);

        [VtblIndex(7)]
        HRESULT GetIntegerArray([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_int_t **")] IVector<int>** result);

        [VtblIndex(8)]
        HRESULT GetBooleanArray([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_boolean_t **")] IVector<bool>** result);

        [VtblIndex(9)]
        HRESULT GetEnumArray([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_int_t **")] IVector<int>** result);

        [VtblIndex(10)]
        HRESULT GetOctetStringArray([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CStorage__CStreams__CIBuffer_t **")] IVector<IntPtr>** result);

        [VtblIndex(11)]
        HRESULT GetDateTimeArray([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CFoundation__CDateTime_t **")] IVector<DateTime>** result);

        [VtblIndex(12)]
        HRESULT GetResolutionArray([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CDevices__CPrinters__CIppResolution_t **")] IVector<IntPtr>** result);

        [VtblIndex(13)]
        HRESULT GetRangeOfIntegerArray([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CDevices__CPrinters__CIppIntegerRange_t **")] IVector<IntPtr>** result);

        [VtblIndex(14)]
        HRESULT GetCollectionArray([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1___FIMapView_2_HSTRING_Windows__CDevices__CPrinters__CIppAttributeValue_t **")] IVector<IntPtr>** result);

        [VtblIndex(15)]
        HRESULT GetTextWithLanguageArray([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CDevices__CPrinters__CIppTextWithLanguage_t **")] IVector<IntPtr>** result);

        [VtblIndex(16)]
        HRESULT GetNameWithLanguageArray([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CDevices__CPrinters__CIppTextWithLanguage_t **")] IVector<IntPtr>** result);

        [VtblIndex(17)]
        HRESULT GetTextWithoutLanguageArray([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")] IVector<HSTRING>** result);

        [VtblIndex(18)]
        HRESULT GetNameWithoutLanguageArray([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")] IVector<HSTRING>** result);

        [VtblIndex(19)]
        HRESULT GetKeywordArray([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")] IVector<HSTRING>** result);

        [VtblIndex(20)]
        HRESULT GetUriArray([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CFoundation__CUri_t **")] IVector<IntPtr>** result);

        [VtblIndex(21)]
        HRESULT GetUriSchemaArray([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")] IVector<HSTRING>** result);

        [VtblIndex(22)]
        HRESULT GetCharsetArray([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")] IVector<HSTRING>** result);

        [VtblIndex(23)]
        HRESULT GetNaturalLanguageArray([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")] IVector<HSTRING>** result);

        [VtblIndex(24)]
        HRESULT GetMimeMediaTypeArray([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")] IVector<HSTRING>** result);
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

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Printers::IppAttributeValueKind *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IppAttributeValueKind*, int> get_Kind;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_int_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVector<int>**, int> GetIntegerArray;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_boolean_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVector<bool>**, int> GetBooleanArray;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_int_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVector<int>**, int> GetEnumArray;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CStorage__CStreams__CIBuffer_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVector<IntPtr>**, int> GetOctetStringArray;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CFoundation__CDateTime_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVector<DateTime>**, int> GetDateTimeArray;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CDevices__CPrinters__CIppResolution_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVector<IntPtr>**, int> GetResolutionArray;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CDevices__CPrinters__CIppIntegerRange_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVector<IntPtr>**, int> GetRangeOfIntegerArray;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1___FIMapView_2_HSTRING_Windows__CDevices__CPrinters__CIppAttributeValue_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVector<IntPtr>**, int> GetCollectionArray;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CDevices__CPrinters__CIppTextWithLanguage_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVector<IntPtr>**, int> GetTextWithLanguageArray;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CDevices__CPrinters__CIppTextWithLanguage_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVector<IntPtr>**, int> GetNameWithLanguageArray;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVector<HSTRING>**, int> GetTextWithoutLanguageArray;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVector<HSTRING>**, int> GetNameWithoutLanguageArray;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVector<HSTRING>**, int> GetKeywordArray;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CFoundation__CUri_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVector<IntPtr>**, int> GetUriArray;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVector<HSTRING>**, int> GetUriSchemaArray;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVector<HSTRING>**, int> GetCharsetArray;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVector<HSTRING>**, int> GetNaturalLanguageArray;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVector<HSTRING>**, int> GetMimeMediaTypeArray;
    }
}
