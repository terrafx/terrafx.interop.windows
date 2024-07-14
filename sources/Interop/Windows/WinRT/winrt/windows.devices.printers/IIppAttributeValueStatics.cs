// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.printers.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IIppAttributeValueStatics.xml' path='doc/member[@name="IIppAttributeValueStatics"]/*' />
[Guid("10D43942-DD94-5998-B235-AFAFB6FA7935")]
[NativeTypeName("struct IIppAttributeValueStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IIppAttributeValueStatics : IIppAttributeValueStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IIppAttributeValueStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IIppAttributeValueStatics*, Guid*, void**, int>)(lpVtbl[0]))((IIppAttributeValueStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IIppAttributeValueStatics*, uint>)(lpVtbl[1]))((IIppAttributeValueStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IIppAttributeValueStatics*, uint>)(lpVtbl[2]))((IIppAttributeValueStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IIppAttributeValueStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IIppAttributeValueStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IIppAttributeValueStatics*, HSTRING*, int>)(lpVtbl[4]))((IIppAttributeValueStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IIppAttributeValueStatics*, TrustLevel*, int>)(lpVtbl[5]))((IIppAttributeValueStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IIppAttributeValueStatics.xml' path='doc/member[@name="IIppAttributeValueStatics.CreateUnsupported"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateUnsupported([NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")] IIppAttributeValue** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IIppAttributeValueStatics*, IIppAttributeValue**, int>)(lpVtbl[6]))((IIppAttributeValueStatics*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IIppAttributeValueStatics.xml' path='doc/member[@name="IIppAttributeValueStatics.CreateUnknown"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateUnknown([NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")] IIppAttributeValue** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IIppAttributeValueStatics*, IIppAttributeValue**, int>)(lpVtbl[7]))((IIppAttributeValueStatics*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IIppAttributeValueStatics.xml' path='doc/member[@name="IIppAttributeValueStatics.CreateNoValue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CreateNoValue([NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")] IIppAttributeValue** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IIppAttributeValueStatics*, IIppAttributeValue**, int>)(lpVtbl[8]))((IIppAttributeValueStatics*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IIppAttributeValueStatics.xml' path='doc/member[@name="IIppAttributeValueStatics.CreateInteger"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT CreateInteger([NativeTypeName("INT32")] int value, [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")] IIppAttributeValue** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IIppAttributeValueStatics*, int, IIppAttributeValue**, int>)(lpVtbl[9]))((IIppAttributeValueStatics*)Unsafe.AsPointer(ref this), value, result);
    }

    /// <include file='IIppAttributeValueStatics.xml' path='doc/member[@name="IIppAttributeValueStatics.CreateIntegerArray"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT CreateIntegerArray([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_int_t *")] IIterable<int>* values, [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")] IIppAttributeValue** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IIppAttributeValueStatics*, IIterable<int>*, IIppAttributeValue**, int>)(lpVtbl[10]))((IIppAttributeValueStatics*)Unsafe.AsPointer(ref this), values, result);
    }

    /// <include file='IIppAttributeValueStatics.xml' path='doc/member[@name="IIppAttributeValueStatics.CreateBoolean"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT CreateBoolean([NativeTypeName("boolean")] byte value, [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")] IIppAttributeValue** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IIppAttributeValueStatics*, byte, IIppAttributeValue**, int>)(lpVtbl[11]))((IIppAttributeValueStatics*)Unsafe.AsPointer(ref this), value, result);
    }

    /// <include file='IIppAttributeValueStatics.xml' path='doc/member[@name="IIppAttributeValueStatics.CreateBooleanArray"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT CreateBooleanArray([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_boolean_t *")] IIterable<bool>* values, [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")] IIppAttributeValue** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IIppAttributeValueStatics*, IIterable<bool>*, IIppAttributeValue**, int>)(lpVtbl[12]))((IIppAttributeValueStatics*)Unsafe.AsPointer(ref this), values, result);
    }

    /// <include file='IIppAttributeValueStatics.xml' path='doc/member[@name="IIppAttributeValueStatics.CreateEnum"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT CreateEnum([NativeTypeName("INT32")] int value, [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")] IIppAttributeValue** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IIppAttributeValueStatics*, int, IIppAttributeValue**, int>)(lpVtbl[13]))((IIppAttributeValueStatics*)Unsafe.AsPointer(ref this), value, result);
    }

    /// <include file='IIppAttributeValueStatics.xml' path='doc/member[@name="IIppAttributeValueStatics.CreateEnumArray"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT CreateEnumArray([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_int_t *")] IIterable<int>* values, [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")] IIppAttributeValue** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IIppAttributeValueStatics*, IIterable<int>*, IIppAttributeValue**, int>)(lpVtbl[14]))((IIppAttributeValueStatics*)Unsafe.AsPointer(ref this), values, result);
    }

    /// <include file='IIppAttributeValueStatics.xml' path='doc/member[@name="IIppAttributeValueStatics.CreateOctetString"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT CreateOctetString([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* value, [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")] IIppAttributeValue** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IIppAttributeValueStatics*, IBuffer*, IIppAttributeValue**, int>)(lpVtbl[15]))((IIppAttributeValueStatics*)Unsafe.AsPointer(ref this), value, result);
    }

    /// <include file='IIppAttributeValueStatics.xml' path='doc/member[@name="IIppAttributeValueStatics.CreateOctetStringArray"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT CreateOctetStringArray([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CStorage__CStreams__CIBuffer_t *")] IIterable<Pointer<IBuffer>>* values, [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")] IIppAttributeValue** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IIppAttributeValueStatics*, IIterable<Pointer<IBuffer>>*, IIppAttributeValue**, int>)(lpVtbl[16]))((IIppAttributeValueStatics*)Unsafe.AsPointer(ref this), values, result);
    }

    /// <include file='IIppAttributeValueStatics.xml' path='doc/member[@name="IIppAttributeValueStatics.CreateDateTime"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT CreateDateTime([NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime value, [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")] IIppAttributeValue** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IIppAttributeValueStatics*, WinRTDateTime, IIppAttributeValue**, int>)(lpVtbl[17]))((IIppAttributeValueStatics*)Unsafe.AsPointer(ref this), value, result);
    }

    /// <include file='IIppAttributeValueStatics.xml' path='doc/member[@name="IIppAttributeValueStatics.CreateDateTimeArray"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT CreateDateTimeArray([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CFoundation__CDateTime_t *")] IIterable<DateTime>* values, [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")] IIppAttributeValue** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IIppAttributeValueStatics*, IIterable<DateTime>*, IIppAttributeValue**, int>)(lpVtbl[18]))((IIppAttributeValueStatics*)Unsafe.AsPointer(ref this), values, result);
    }

    /// <include file='IIppAttributeValueStatics.xml' path='doc/member[@name="IIppAttributeValueStatics.CreateResolution"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT CreateResolution([NativeTypeName("ABI::Windows::Devices::Printers::IIppResolution *")] IIppResolution* value, [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")] IIppAttributeValue** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IIppAttributeValueStatics*, IIppResolution*, IIppAttributeValue**, int>)(lpVtbl[19]))((IIppAttributeValueStatics*)Unsafe.AsPointer(ref this), value, result);
    }

    /// <include file='IIppAttributeValueStatics.xml' path='doc/member[@name="IIppAttributeValueStatics.CreateResolutionArray"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT CreateResolutionArray([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CDevices__CPrinters__CIppResolution_t *")] IIterable<Pointer<IIppResolution>>* values, [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")] IIppAttributeValue** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IIppAttributeValueStatics*, IIterable<Pointer<IIppResolution>>*, IIppAttributeValue**, int>)(lpVtbl[20]))((IIppAttributeValueStatics*)Unsafe.AsPointer(ref this), values, result);
    }

    /// <include file='IIppAttributeValueStatics.xml' path='doc/member[@name="IIppAttributeValueStatics.CreateRangeOfInteger"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT CreateRangeOfInteger([NativeTypeName("ABI::Windows::Devices::Printers::IIppIntegerRange *")] IIppIntegerRange* value, [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")] IIppAttributeValue** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IIppAttributeValueStatics*, IIppIntegerRange*, IIppAttributeValue**, int>)(lpVtbl[21]))((IIppAttributeValueStatics*)Unsafe.AsPointer(ref this), value, result);
    }

    /// <include file='IIppAttributeValueStatics.xml' path='doc/member[@name="IIppAttributeValueStatics.CreateRangeOfIntegerArray"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT CreateRangeOfIntegerArray([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CDevices__CPrinters__CIppIntegerRange_t *")] IIterable<Pointer<IIppIntegerRange>>* values, [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")] IIppAttributeValue** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IIppAttributeValueStatics*, IIterable<Pointer<IIppIntegerRange>>*, IIppAttributeValue**, int>)(lpVtbl[22]))((IIppAttributeValueStatics*)Unsafe.AsPointer(ref this), values, result);
    }

    /// <include file='IIppAttributeValueStatics.xml' path='doc/member[@name="IIppAttributeValueStatics.CreateCollection"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT CreateCollection([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1___FIKeyValuePair_2_HSTRING_Windows__CDevices__CPrinters__CIppAttributeValue_t *")] IIterable<Pointer<IKeyValuePair<HSTRING, Pointer<IIppAttributeValue>>>>* memberAttributes, [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")] IIppAttributeValue** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IIppAttributeValueStatics*, IIterable<Pointer<IKeyValuePair<HSTRING, Pointer<IIppAttributeValue>>>>*, IIppAttributeValue**, int>)(lpVtbl[23]))((IIppAttributeValueStatics*)Unsafe.AsPointer(ref this), memberAttributes, result);
    }

    /// <include file='IIppAttributeValueStatics.xml' path='doc/member[@name="IIppAttributeValueStatics.CreateCollectionArray"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT CreateCollectionArray([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1___FIIterable_1___FIKeyValuePair_2_HSTRING_Windows__CDevices__CPrinters__CIppAttributeValue_t *")] IIterable<Pointer<IIterable<Pointer<IKeyValuePair<HSTRING, Pointer<IIppAttributeValue>>>>>>* memberAttributesArray, [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")] IIppAttributeValue** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IIppAttributeValueStatics*, IIterable<Pointer<IIterable<Pointer<IKeyValuePair<HSTRING, Pointer<IIppAttributeValue>>>>>>*, IIppAttributeValue**, int>)(lpVtbl[24]))((IIppAttributeValueStatics*)Unsafe.AsPointer(ref this), memberAttributesArray, result);
    }

    /// <include file='IIppAttributeValueStatics.xml' path='doc/member[@name="IIppAttributeValueStatics.CreateTextWithLanguage"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT CreateTextWithLanguage([NativeTypeName("ABI::Windows::Devices::Printers::IIppTextWithLanguage *")] IIppTextWithLanguage* value, [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")] IIppAttributeValue** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IIppAttributeValueStatics*, IIppTextWithLanguage*, IIppAttributeValue**, int>)(lpVtbl[25]))((IIppAttributeValueStatics*)Unsafe.AsPointer(ref this), value, result);
    }

    /// <include file='IIppAttributeValueStatics.xml' path='doc/member[@name="IIppAttributeValueStatics.CreateTextWithLanguageArray"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT CreateTextWithLanguageArray([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CDevices__CPrinters__CIppTextWithLanguage_t *")] IIterable<Pointer<IIppTextWithLanguage>>* values, [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")] IIppAttributeValue** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IIppAttributeValueStatics*, IIterable<Pointer<IIppTextWithLanguage>>*, IIppAttributeValue**, int>)(lpVtbl[26]))((IIppAttributeValueStatics*)Unsafe.AsPointer(ref this), values, result);
    }

    /// <include file='IIppAttributeValueStatics.xml' path='doc/member[@name="IIppAttributeValueStatics.CreateNameWithLanguage"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT CreateNameWithLanguage([NativeTypeName("ABI::Windows::Devices::Printers::IIppTextWithLanguage *")] IIppTextWithLanguage* value, [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")] IIppAttributeValue** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IIppAttributeValueStatics*, IIppTextWithLanguage*, IIppAttributeValue**, int>)(lpVtbl[27]))((IIppAttributeValueStatics*)Unsafe.AsPointer(ref this), value, result);
    }

    /// <include file='IIppAttributeValueStatics.xml' path='doc/member[@name="IIppAttributeValueStatics.CreateNameWithLanguageArray"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT CreateNameWithLanguageArray([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CDevices__CPrinters__CIppTextWithLanguage_t *")] IIterable<Pointer<IIppTextWithLanguage>>* values, [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")] IIppAttributeValue** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IIppAttributeValueStatics*, IIterable<Pointer<IIppTextWithLanguage>>*, IIppAttributeValue**, int>)(lpVtbl[28]))((IIppAttributeValueStatics*)Unsafe.AsPointer(ref this), values, result);
    }

    /// <include file='IIppAttributeValueStatics.xml' path='doc/member[@name="IIppAttributeValueStatics.CreateTextWithoutLanguage"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT CreateTextWithoutLanguage(HSTRING value, [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")] IIppAttributeValue** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IIppAttributeValueStatics*, HSTRING, IIppAttributeValue**, int>)(lpVtbl[29]))((IIppAttributeValueStatics*)Unsafe.AsPointer(ref this), value, result);
    }

    /// <include file='IIppAttributeValueStatics.xml' path='doc/member[@name="IIppAttributeValueStatics.CreateTextWithoutLanguageArray"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT CreateTextWithoutLanguageArray([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")] IIterable<HSTRING>* values, [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")] IIppAttributeValue** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IIppAttributeValueStatics*, IIterable<HSTRING>*, IIppAttributeValue**, int>)(lpVtbl[30]))((IIppAttributeValueStatics*)Unsafe.AsPointer(ref this), values, result);
    }

    /// <include file='IIppAttributeValueStatics.xml' path='doc/member[@name="IIppAttributeValueStatics.CreateNameWithoutLanguage"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT CreateNameWithoutLanguage(HSTRING value, [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")] IIppAttributeValue** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IIppAttributeValueStatics*, HSTRING, IIppAttributeValue**, int>)(lpVtbl[31]))((IIppAttributeValueStatics*)Unsafe.AsPointer(ref this), value, result);
    }

    /// <include file='IIppAttributeValueStatics.xml' path='doc/member[@name="IIppAttributeValueStatics.CreateNameWithoutLanguageArray"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT CreateNameWithoutLanguageArray([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")] IIterable<HSTRING>* values, [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")] IIppAttributeValue** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IIppAttributeValueStatics*, IIterable<HSTRING>*, IIppAttributeValue**, int>)(lpVtbl[32]))((IIppAttributeValueStatics*)Unsafe.AsPointer(ref this), values, result);
    }

    /// <include file='IIppAttributeValueStatics.xml' path='doc/member[@name="IIppAttributeValueStatics.CreateKeyword"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT CreateKeyword(HSTRING value, [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")] IIppAttributeValue** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IIppAttributeValueStatics*, HSTRING, IIppAttributeValue**, int>)(lpVtbl[33]))((IIppAttributeValueStatics*)Unsafe.AsPointer(ref this), value, result);
    }

    /// <include file='IIppAttributeValueStatics.xml' path='doc/member[@name="IIppAttributeValueStatics.CreateKeywordArray"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT CreateKeywordArray([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")] IIterable<HSTRING>* values, [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")] IIppAttributeValue** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IIppAttributeValueStatics*, IIterable<HSTRING>*, IIppAttributeValue**, int>)(lpVtbl[34]))((IIppAttributeValueStatics*)Unsafe.AsPointer(ref this), values, result);
    }

    /// <include file='IIppAttributeValueStatics.xml' path='doc/member[@name="IIppAttributeValueStatics.CreateUri"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT CreateUri([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* value, [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")] IIppAttributeValue** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IIppAttributeValueStatics*, IUriRuntimeClass*, IIppAttributeValue**, int>)(lpVtbl[35]))((IIppAttributeValueStatics*)Unsafe.AsPointer(ref this), value, result);
    }

    /// <include file='IIppAttributeValueStatics.xml' path='doc/member[@name="IIppAttributeValueStatics.CreateUriArray"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public HRESULT CreateUriArray([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CFoundation__CUri_t *")] IIterable<Pointer<IUri>>* values, [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")] IIppAttributeValue** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IIppAttributeValueStatics*, IIterable<Pointer<IUri>>*, IIppAttributeValue**, int>)(lpVtbl[36]))((IIppAttributeValueStatics*)Unsafe.AsPointer(ref this), values, result);
    }

    /// <include file='IIppAttributeValueStatics.xml' path='doc/member[@name="IIppAttributeValueStatics.CreateUriSchema"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public HRESULT CreateUriSchema(HSTRING value, [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")] IIppAttributeValue** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IIppAttributeValueStatics*, HSTRING, IIppAttributeValue**, int>)(lpVtbl[37]))((IIppAttributeValueStatics*)Unsafe.AsPointer(ref this), value, result);
    }

    /// <include file='IIppAttributeValueStatics.xml' path='doc/member[@name="IIppAttributeValueStatics.CreateUriSchemaArray"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    public HRESULT CreateUriSchemaArray([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")] IIterable<HSTRING>* values, [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")] IIppAttributeValue** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IIppAttributeValueStatics*, IIterable<HSTRING>*, IIppAttributeValue**, int>)(lpVtbl[38]))((IIppAttributeValueStatics*)Unsafe.AsPointer(ref this), values, result);
    }

    /// <include file='IIppAttributeValueStatics.xml' path='doc/member[@name="IIppAttributeValueStatics.CreateCharset"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(39)]
    public HRESULT CreateCharset(HSTRING value, [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")] IIppAttributeValue** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IIppAttributeValueStatics*, HSTRING, IIppAttributeValue**, int>)(lpVtbl[39]))((IIppAttributeValueStatics*)Unsafe.AsPointer(ref this), value, result);
    }

    /// <include file='IIppAttributeValueStatics.xml' path='doc/member[@name="IIppAttributeValueStatics.CreateCharsetArray"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(40)]
    public HRESULT CreateCharsetArray([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")] IIterable<HSTRING>* values, [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")] IIppAttributeValue** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IIppAttributeValueStatics*, IIterable<HSTRING>*, IIppAttributeValue**, int>)(lpVtbl[40]))((IIppAttributeValueStatics*)Unsafe.AsPointer(ref this), values, result);
    }

    /// <include file='IIppAttributeValueStatics.xml' path='doc/member[@name="IIppAttributeValueStatics.CreateNaturalLanguage"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(41)]
    public HRESULT CreateNaturalLanguage(HSTRING value, [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")] IIppAttributeValue** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IIppAttributeValueStatics*, HSTRING, IIppAttributeValue**, int>)(lpVtbl[41]))((IIppAttributeValueStatics*)Unsafe.AsPointer(ref this), value, result);
    }

    /// <include file='IIppAttributeValueStatics.xml' path='doc/member[@name="IIppAttributeValueStatics.CreateNaturalLanguageArray"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(42)]
    public HRESULT CreateNaturalLanguageArray([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")] IIterable<HSTRING>* values, [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")] IIppAttributeValue** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IIppAttributeValueStatics*, IIterable<HSTRING>*, IIppAttributeValue**, int>)(lpVtbl[42]))((IIppAttributeValueStatics*)Unsafe.AsPointer(ref this), values, result);
    }

    /// <include file='IIppAttributeValueStatics.xml' path='doc/member[@name="IIppAttributeValueStatics.CreateMimeMedia"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(43)]
    public HRESULT CreateMimeMedia(HSTRING value, [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")] IIppAttributeValue** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IIppAttributeValueStatics*, HSTRING, IIppAttributeValue**, int>)(lpVtbl[43]))((IIppAttributeValueStatics*)Unsafe.AsPointer(ref this), value, result);
    }

    /// <include file='IIppAttributeValueStatics.xml' path='doc/member[@name="IIppAttributeValueStatics.CreateMimeMediaArray"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(44)]
    public HRESULT CreateMimeMediaArray([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")] IIterable<HSTRING>* values, [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")] IIppAttributeValue** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IIppAttributeValueStatics*, IIterable<HSTRING>*, IIppAttributeValue**, int>)(lpVtbl[44]))((IIppAttributeValueStatics*)Unsafe.AsPointer(ref this), values, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateUnsupported([NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")] IIppAttributeValue** result);

        [VtblIndex(7)]
        HRESULT CreateUnknown([NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")] IIppAttributeValue** result);

        [VtblIndex(8)]
        HRESULT CreateNoValue([NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")] IIppAttributeValue** result);

        [VtblIndex(9)]
        HRESULT CreateInteger([NativeTypeName("INT32")] int value, [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")] IIppAttributeValue** result);

        [VtblIndex(10)]
        HRESULT CreateIntegerArray([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_int_t *")] IIterable<int>* values, [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")] IIppAttributeValue** result);

        [VtblIndex(11)]
        HRESULT CreateBoolean([NativeTypeName("boolean")] byte value, [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")] IIppAttributeValue** result);

        [VtblIndex(12)]
        HRESULT CreateBooleanArray([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_boolean_t *")] IIterable<bool>* values, [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")] IIppAttributeValue** result);

        [VtblIndex(13)]
        HRESULT CreateEnum([NativeTypeName("INT32")] int value, [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")] IIppAttributeValue** result);

        [VtblIndex(14)]
        HRESULT CreateEnumArray([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_int_t *")] IIterable<int>* values, [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")] IIppAttributeValue** result);

        [VtblIndex(15)]
        HRESULT CreateOctetString([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* value, [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")] IIppAttributeValue** result);

        [VtblIndex(16)]
        HRESULT CreateOctetStringArray([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CStorage__CStreams__CIBuffer_t *")] IIterable<Pointer<IBuffer>>* values, [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")] IIppAttributeValue** result);

        [VtblIndex(17)]
        HRESULT CreateDateTime([NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime value, [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")] IIppAttributeValue** result);

        [VtblIndex(18)]
        HRESULT CreateDateTimeArray([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CFoundation__CDateTime_t *")] IIterable<DateTime>* values, [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")] IIppAttributeValue** result);

        [VtblIndex(19)]
        HRESULT CreateResolution([NativeTypeName("ABI::Windows::Devices::Printers::IIppResolution *")] IIppResolution* value, [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")] IIppAttributeValue** result);

        [VtblIndex(20)]
        HRESULT CreateResolutionArray([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CDevices__CPrinters__CIppResolution_t *")] IIterable<Pointer<IIppResolution>>* values, [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")] IIppAttributeValue** result);

        [VtblIndex(21)]
        HRESULT CreateRangeOfInteger([NativeTypeName("ABI::Windows::Devices::Printers::IIppIntegerRange *")] IIppIntegerRange* value, [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")] IIppAttributeValue** result);

        [VtblIndex(22)]
        HRESULT CreateRangeOfIntegerArray([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CDevices__CPrinters__CIppIntegerRange_t *")] IIterable<Pointer<IIppIntegerRange>>* values, [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")] IIppAttributeValue** result);

        [VtblIndex(23)]
        HRESULT CreateCollection([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1___FIKeyValuePair_2_HSTRING_Windows__CDevices__CPrinters__CIppAttributeValue_t *")] IIterable<Pointer<IKeyValuePair<HSTRING, Pointer<IIppAttributeValue>>>>* memberAttributes, [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")] IIppAttributeValue** result);

        [VtblIndex(24)]
        HRESULT CreateCollectionArray([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1___FIIterable_1___FIKeyValuePair_2_HSTRING_Windows__CDevices__CPrinters__CIppAttributeValue_t *")] IIterable<Pointer<IIterable<Pointer<IKeyValuePair<HSTRING, Pointer<IIppAttributeValue>>>>>>* memberAttributesArray, [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")] IIppAttributeValue** result);

        [VtblIndex(25)]
        HRESULT CreateTextWithLanguage([NativeTypeName("ABI::Windows::Devices::Printers::IIppTextWithLanguage *")] IIppTextWithLanguage* value, [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")] IIppAttributeValue** result);

        [VtblIndex(26)]
        HRESULT CreateTextWithLanguageArray([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CDevices__CPrinters__CIppTextWithLanguage_t *")] IIterable<Pointer<IIppTextWithLanguage>>* values, [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")] IIppAttributeValue** result);

        [VtblIndex(27)]
        HRESULT CreateNameWithLanguage([NativeTypeName("ABI::Windows::Devices::Printers::IIppTextWithLanguage *")] IIppTextWithLanguage* value, [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")] IIppAttributeValue** result);

        [VtblIndex(28)]
        HRESULT CreateNameWithLanguageArray([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CDevices__CPrinters__CIppTextWithLanguage_t *")] IIterable<Pointer<IIppTextWithLanguage>>* values, [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")] IIppAttributeValue** result);

        [VtblIndex(29)]
        HRESULT CreateTextWithoutLanguage(HSTRING value, [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")] IIppAttributeValue** result);

        [VtblIndex(30)]
        HRESULT CreateTextWithoutLanguageArray([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")] IIterable<HSTRING>* values, [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")] IIppAttributeValue** result);

        [VtblIndex(31)]
        HRESULT CreateNameWithoutLanguage(HSTRING value, [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")] IIppAttributeValue** result);

        [VtblIndex(32)]
        HRESULT CreateNameWithoutLanguageArray([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")] IIterable<HSTRING>* values, [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")] IIppAttributeValue** result);

        [VtblIndex(33)]
        HRESULT CreateKeyword(HSTRING value, [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")] IIppAttributeValue** result);

        [VtblIndex(34)]
        HRESULT CreateKeywordArray([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")] IIterable<HSTRING>* values, [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")] IIppAttributeValue** result);

        [VtblIndex(35)]
        HRESULT CreateUri([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* value, [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")] IIppAttributeValue** result);

        [VtblIndex(36)]
        HRESULT CreateUriArray([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CFoundation__CUri_t *")] IIterable<Pointer<IUri>>* values, [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")] IIppAttributeValue** result);

        [VtblIndex(37)]
        HRESULT CreateUriSchema(HSTRING value, [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")] IIppAttributeValue** result);

        [VtblIndex(38)]
        HRESULT CreateUriSchemaArray([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")] IIterable<HSTRING>* values, [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")] IIppAttributeValue** result);

        [VtblIndex(39)]
        HRESULT CreateCharset(HSTRING value, [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")] IIppAttributeValue** result);

        [VtblIndex(40)]
        HRESULT CreateCharsetArray([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")] IIterable<HSTRING>* values, [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")] IIppAttributeValue** result);

        [VtblIndex(41)]
        HRESULT CreateNaturalLanguage(HSTRING value, [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")] IIppAttributeValue** result);

        [VtblIndex(42)]
        HRESULT CreateNaturalLanguageArray([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")] IIterable<HSTRING>* values, [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")] IIppAttributeValue** result);

        [VtblIndex(43)]
        HRESULT CreateMimeMedia(HSTRING value, [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")] IIppAttributeValue** result);

        [VtblIndex(44)]
        HRESULT CreateMimeMediaArray([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")] IIterable<HSTRING>* values, [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")] IIppAttributeValue** result);
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

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Printers::IIppAttributeValue **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IIppAttributeValue**, int> CreateUnsupported;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Printers::IIppAttributeValue **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IIppAttributeValue**, int> CreateUnknown;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Printers::IIppAttributeValue **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IIppAttributeValue**, int> CreateNoValue;

        [NativeTypeName("HRESULT (INT32, ABI::Windows::Devices::Printers::IIppAttributeValue **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, IIppAttributeValue**, int> CreateInteger;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIIterable_1_int_t *, ABI::Windows::Devices::Printers::IIppAttributeValue **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IIterable<int>*, IIppAttributeValue**, int> CreateIntegerArray;

        [NativeTypeName("HRESULT (boolean, ABI::Windows::Devices::Printers::IIppAttributeValue **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, IIppAttributeValue**, int> CreateBoolean;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIIterable_1_boolean_t *, ABI::Windows::Devices::Printers::IIppAttributeValue **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IIterable<bool>*, IIppAttributeValue**, int> CreateBooleanArray;

        [NativeTypeName("HRESULT (INT32, ABI::Windows::Devices::Printers::IIppAttributeValue **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, IIppAttributeValue**, int> CreateEnum;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIIterable_1_int_t *, ABI::Windows::Devices::Printers::IIppAttributeValue **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IIterable<int>*, IIppAttributeValue**, int> CreateEnumArray;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IBuffer *, ABI::Windows::Devices::Printers::IIppAttributeValue **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBuffer*, IIppAttributeValue**, int> CreateOctetString;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CStorage__CStreams__CIBuffer_t *, ABI::Windows::Devices::Printers::IIppAttributeValue **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IIterable<Pointer<IBuffer>>*, IIppAttributeValue**, int> CreateOctetStringArray;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::DateTime, ABI::Windows::Devices::Printers::IIppAttributeValue **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, WinRTDateTime, IIppAttributeValue**, int> CreateDateTime;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CFoundation__CDateTime_t *, ABI::Windows::Devices::Printers::IIppAttributeValue **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IIterable<DateTime>*, IIppAttributeValue**, int> CreateDateTimeArray;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Printers::IIppResolution *, ABI::Windows::Devices::Printers::IIppAttributeValue **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IIppResolution*, IIppAttributeValue**, int> CreateResolution;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CDevices__CPrinters__CIppResolution_t *, ABI::Windows::Devices::Printers::IIppAttributeValue **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IIterable<Pointer<IIppResolution>>*, IIppAttributeValue**, int> CreateResolutionArray;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Printers::IIppIntegerRange *, ABI::Windows::Devices::Printers::IIppAttributeValue **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IIppIntegerRange*, IIppAttributeValue**, int> CreateRangeOfInteger;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CDevices__CPrinters__CIppIntegerRange_t *, ABI::Windows::Devices::Printers::IIppAttributeValue **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IIterable<Pointer<IIppIntegerRange>>*, IIppAttributeValue**, int> CreateRangeOfIntegerArray;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIIterable_1___FIKeyValuePair_2_HSTRING_Windows__CDevices__CPrinters__CIppAttributeValue_t *, ABI::Windows::Devices::Printers::IIppAttributeValue **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IIterable<Pointer<IKeyValuePair<HSTRING, Pointer<IIppAttributeValue>>>>*, IIppAttributeValue**, int> CreateCollection;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIIterable_1___FIIterable_1___FIKeyValuePair_2_HSTRING_Windows__CDevices__CPrinters__CIppAttributeValue_t *, ABI::Windows::Devices::Printers::IIppAttributeValue **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IIterable<Pointer<IIterable<Pointer<IKeyValuePair<HSTRING, Pointer<IIppAttributeValue>>>>>>*, IIppAttributeValue**, int> CreateCollectionArray;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Printers::IIppTextWithLanguage *, ABI::Windows::Devices::Printers::IIppAttributeValue **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IIppTextWithLanguage*, IIppAttributeValue**, int> CreateTextWithLanguage;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CDevices__CPrinters__CIppTextWithLanguage_t *, ABI::Windows::Devices::Printers::IIppAttributeValue **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IIterable<Pointer<IIppTextWithLanguage>>*, IIppAttributeValue**, int> CreateTextWithLanguageArray;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Printers::IIppTextWithLanguage *, ABI::Windows::Devices::Printers::IIppAttributeValue **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IIppTextWithLanguage*, IIppAttributeValue**, int> CreateNameWithLanguage;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CDevices__CPrinters__CIppTextWithLanguage_t *, ABI::Windows::Devices::Printers::IIppAttributeValue **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IIterable<Pointer<IIppTextWithLanguage>>*, IIppAttributeValue**, int> CreateNameWithLanguageArray;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Devices::Printers::IIppAttributeValue **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IIppAttributeValue**, int> CreateTextWithoutLanguage;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *, ABI::Windows::Devices::Printers::IIppAttributeValue **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IIterable<HSTRING>*, IIppAttributeValue**, int> CreateTextWithoutLanguageArray;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Devices::Printers::IIppAttributeValue **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IIppAttributeValue**, int> CreateNameWithoutLanguage;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *, ABI::Windows::Devices::Printers::IIppAttributeValue **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IIterable<HSTRING>*, IIppAttributeValue**, int> CreateNameWithoutLanguageArray;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Devices::Printers::IIppAttributeValue **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IIppAttributeValue**, int> CreateKeyword;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *, ABI::Windows::Devices::Printers::IIppAttributeValue **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IIterable<HSTRING>*, IIppAttributeValue**, int> CreateKeywordArray;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IUriRuntimeClass *, ABI::Windows::Devices::Printers::IIppAttributeValue **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUriRuntimeClass*, IIppAttributeValue**, int> CreateUri;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CFoundation__CUri_t *, ABI::Windows::Devices::Printers::IIppAttributeValue **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IIterable<Pointer<IUri>>*, IIppAttributeValue**, int> CreateUriArray;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Devices::Printers::IIppAttributeValue **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IIppAttributeValue**, int> CreateUriSchema;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *, ABI::Windows::Devices::Printers::IIppAttributeValue **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IIterable<HSTRING>*, IIppAttributeValue**, int> CreateUriSchemaArray;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Devices::Printers::IIppAttributeValue **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IIppAttributeValue**, int> CreateCharset;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *, ABI::Windows::Devices::Printers::IIppAttributeValue **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IIterable<HSTRING>*, IIppAttributeValue**, int> CreateCharsetArray;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Devices::Printers::IIppAttributeValue **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IIppAttributeValue**, int> CreateNaturalLanguage;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *, ABI::Windows::Devices::Printers::IIppAttributeValue **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IIterable<HSTRING>*, IIppAttributeValue**, int> CreateNaturalLanguageArray;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Devices::Printers::IIppAttributeValue **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IIppAttributeValue**, int> CreateMimeMedia;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *, ABI::Windows::Devices::Printers::IIppAttributeValue **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IIterable<HSTRING>*, IIppAttributeValue**, int> CreateMimeMediaArray;
    }
}
