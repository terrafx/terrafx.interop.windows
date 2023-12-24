// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.foundation.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IPropertyValue.xml' path='doc/member[@name="IPropertyValue"]/*' />
[Guid("4BD682DD-7554-40E9-9A9B-82654EDE7E62")]
[NativeTypeName("struct IPropertyValue : IInspectable")]
[NativeInheritance("IInspectable")]
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct IPropertyValue : IPropertyValue.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPropertyValue));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IPropertyValue*, Guid*, void**, int>)(lpVtbl[0]))((IPropertyValue*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPropertyValue*, uint>)(lpVtbl[1]))((IPropertyValue*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPropertyValue*, uint>)(lpVtbl[2]))((IPropertyValue*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IPropertyValue*, uint*, Guid**, int>)(lpVtbl[3]))((IPropertyValue*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IPropertyValue*, HSTRING*, int>)(lpVtbl[4]))((IPropertyValue*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IPropertyValue*, TrustLevel*, int>)(lpVtbl[5]))((IPropertyValue*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IPropertyValue.xml' path='doc/member[@name="IPropertyValue.get_Type"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Type([NativeTypeName("ABI::Windows::Foundation::PropertyType *")] PropertyType* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPropertyValue*, PropertyType*, int>)(lpVtbl[6]))((IPropertyValue*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPropertyValue.xml' path='doc/member[@name="IPropertyValue.get_IsNumericScalar"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_IsNumericScalar([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPropertyValue*, byte*, int>)(lpVtbl[7]))((IPropertyValue*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPropertyValue.xml' path='doc/member[@name="IPropertyValue.GetUInt8"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetUInt8(byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPropertyValue*, byte*, int>)(lpVtbl[8]))((IPropertyValue*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPropertyValue.xml' path='doc/member[@name="IPropertyValue.GetInt16"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetInt16([NativeTypeName("INT16 *")] short* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPropertyValue*, short*, int>)(lpVtbl[9]))((IPropertyValue*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPropertyValue.xml' path='doc/member[@name="IPropertyValue.GetUInt16"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetUInt16([NativeTypeName("UINT16 *")] ushort* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPropertyValue*, ushort*, int>)(lpVtbl[10]))((IPropertyValue*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPropertyValue.xml' path='doc/member[@name="IPropertyValue.GetInt32"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetInt32([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPropertyValue*, int*, int>)(lpVtbl[11]))((IPropertyValue*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPropertyValue.xml' path='doc/member[@name="IPropertyValue.GetUInt32"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetUInt32([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPropertyValue*, uint*, int>)(lpVtbl[12]))((IPropertyValue*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPropertyValue.xml' path='doc/member[@name="IPropertyValue.GetInt64"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetInt64([NativeTypeName("INT64 *")] long* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPropertyValue*, long*, int>)(lpVtbl[13]))((IPropertyValue*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPropertyValue.xml' path='doc/member[@name="IPropertyValue.GetUInt64"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetUInt64([NativeTypeName("UINT64 *")] ulong* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPropertyValue*, ulong*, int>)(lpVtbl[14]))((IPropertyValue*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPropertyValue.xml' path='doc/member[@name="IPropertyValue.GetSingle"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT GetSingle(float* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPropertyValue*, float*, int>)(lpVtbl[15]))((IPropertyValue*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPropertyValue.xml' path='doc/member[@name="IPropertyValue.GetDouble"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT GetDouble(double* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPropertyValue*, double*, int>)(lpVtbl[16]))((IPropertyValue*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPropertyValue.xml' path='doc/member[@name="IPropertyValue.GetChar16"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT GetChar16([NativeTypeName("WCHAR *")] char* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPropertyValue*, char*, int>)(lpVtbl[17]))((IPropertyValue*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPropertyValue.xml' path='doc/member[@name="IPropertyValue.GetBoolean"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT GetBoolean([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPropertyValue*, byte*, int>)(lpVtbl[18]))((IPropertyValue*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPropertyValue.xml' path='doc/member[@name="IPropertyValue.GetString"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT GetString(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPropertyValue*, HSTRING*, int>)(lpVtbl[19]))((IPropertyValue*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPropertyValue.xml' path='doc/member[@name="IPropertyValue.GetGuid"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT GetGuid(Guid* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPropertyValue*, Guid*, int>)(lpVtbl[20]))((IPropertyValue*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPropertyValue.xml' path='doc/member[@name="IPropertyValue.GetDateTime"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT GetDateTime([NativeTypeName("ABI::Windows::Foundation::DateTime *")] DateTime* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPropertyValue*, DateTime*, int>)(lpVtbl[21]))((IPropertyValue*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPropertyValue.xml' path='doc/member[@name="IPropertyValue.GetTimeSpan"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT GetTimeSpan([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPropertyValue*, TimeSpan*, int>)(lpVtbl[22]))((IPropertyValue*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPropertyValue.xml' path='doc/member[@name="IPropertyValue.GetPoint"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT GetPoint([NativeTypeName("ABI::Windows::Foundation::Point *")] Point* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPropertyValue*, Point*, int>)(lpVtbl[23]))((IPropertyValue*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPropertyValue.xml' path='doc/member[@name="IPropertyValue.GetSize"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT GetSize([NativeTypeName("ABI::Windows::Foundation::Size *")] Size* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPropertyValue*, Size*, int>)(lpVtbl[24]))((IPropertyValue*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPropertyValue.xml' path='doc/member[@name="IPropertyValue.GetRect"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT GetRect([NativeTypeName("ABI::Windows::Foundation::Rect *")] Rect* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPropertyValue*, Rect*, int>)(lpVtbl[25]))((IPropertyValue*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPropertyValue.xml' path='doc/member[@name="IPropertyValue.GetUInt8Array"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT GetUInt8Array([NativeTypeName("UINT32 *")] uint* valueLength, byte** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPropertyValue*, uint*, byte**, int>)(lpVtbl[26]))((IPropertyValue*)Unsafe.AsPointer(ref this), valueLength, value);
    }

    /// <include file='IPropertyValue.xml' path='doc/member[@name="IPropertyValue.GetInt16Array"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT GetInt16Array([NativeTypeName("UINT32 *")] uint* valueLength, [NativeTypeName("INT16 **")] short** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPropertyValue*, uint*, short**, int>)(lpVtbl[27]))((IPropertyValue*)Unsafe.AsPointer(ref this), valueLength, value);
    }

    /// <include file='IPropertyValue.xml' path='doc/member[@name="IPropertyValue.GetUInt16Array"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT GetUInt16Array([NativeTypeName("UINT32 *")] uint* valueLength, [NativeTypeName("UINT16 **")] ushort** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPropertyValue*, uint*, ushort**, int>)(lpVtbl[28]))((IPropertyValue*)Unsafe.AsPointer(ref this), valueLength, value);
    }

    /// <include file='IPropertyValue.xml' path='doc/member[@name="IPropertyValue.GetInt32Array"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT GetInt32Array([NativeTypeName("UINT32 *")] uint* valueLength, [NativeTypeName("INT32 **")] int** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPropertyValue*, uint*, int**, int>)(lpVtbl[29]))((IPropertyValue*)Unsafe.AsPointer(ref this), valueLength, value);
    }

    /// <include file='IPropertyValue.xml' path='doc/member[@name="IPropertyValue.GetUInt32Array"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT GetUInt32Array([NativeTypeName("UINT32 *")] uint* valueLength, [NativeTypeName("UINT32 **")] uint** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPropertyValue*, uint*, uint**, int>)(lpVtbl[30]))((IPropertyValue*)Unsafe.AsPointer(ref this), valueLength, value);
    }

    /// <include file='IPropertyValue.xml' path='doc/member[@name="IPropertyValue.GetInt64Array"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT GetInt64Array([NativeTypeName("UINT32 *")] uint* valueLength, [NativeTypeName("INT64 **")] long** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPropertyValue*, uint*, long**, int>)(lpVtbl[31]))((IPropertyValue*)Unsafe.AsPointer(ref this), valueLength, value);
    }

    /// <include file='IPropertyValue.xml' path='doc/member[@name="IPropertyValue.GetUInt64Array"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT GetUInt64Array([NativeTypeName("UINT32 *")] uint* valueLength, [NativeTypeName("UINT64 **")] ulong** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPropertyValue*, uint*, ulong**, int>)(lpVtbl[32]))((IPropertyValue*)Unsafe.AsPointer(ref this), valueLength, value);
    }

    /// <include file='IPropertyValue.xml' path='doc/member[@name="IPropertyValue.GetSingleArray"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT GetSingleArray([NativeTypeName("UINT32 *")] uint* valueLength, float** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPropertyValue*, uint*, float**, int>)(lpVtbl[33]))((IPropertyValue*)Unsafe.AsPointer(ref this), valueLength, value);
    }

    /// <include file='IPropertyValue.xml' path='doc/member[@name="IPropertyValue.GetDoubleArray"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT GetDoubleArray([NativeTypeName("UINT32 *")] uint* valueLength, double** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPropertyValue*, uint*, double**, int>)(lpVtbl[34]))((IPropertyValue*)Unsafe.AsPointer(ref this), valueLength, value);
    }

    /// <include file='IPropertyValue.xml' path='doc/member[@name="IPropertyValue.GetChar16Array"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT GetChar16Array([NativeTypeName("UINT32 *")] uint* valueLength, [NativeTypeName("WCHAR **")] char** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPropertyValue*, uint*, char**, int>)(lpVtbl[35]))((IPropertyValue*)Unsafe.AsPointer(ref this), valueLength, value);
    }

    /// <include file='IPropertyValue.xml' path='doc/member[@name="IPropertyValue.GetBooleanArray"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public HRESULT GetBooleanArray([NativeTypeName("UINT32 *")] uint* valueLength, [NativeTypeName("boolean **")] byte** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPropertyValue*, uint*, byte**, int>)(lpVtbl[36]))((IPropertyValue*)Unsafe.AsPointer(ref this), valueLength, value);
    }

    /// <include file='IPropertyValue.xml' path='doc/member[@name="IPropertyValue.GetStringArray"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public HRESULT GetStringArray([NativeTypeName("UINT32 *")] uint* valueLength, HSTRING** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPropertyValue*, uint*, HSTRING**, int>)(lpVtbl[37]))((IPropertyValue*)Unsafe.AsPointer(ref this), valueLength, value);
    }

    /// <include file='IPropertyValue.xml' path='doc/member[@name="IPropertyValue.GetInspectableArray"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    public HRESULT GetInspectableArray([NativeTypeName("UINT32 *")] uint* valueLength, IInspectable*** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPropertyValue*, uint*, IInspectable***, int>)(lpVtbl[38]))((IPropertyValue*)Unsafe.AsPointer(ref this), valueLength, value);
    }

    /// <include file='IPropertyValue.xml' path='doc/member[@name="IPropertyValue.GetGuidArray"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(39)]
    public HRESULT GetGuidArray([NativeTypeName("UINT32 *")] uint* valueLength, Guid** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPropertyValue*, uint*, Guid**, int>)(lpVtbl[39]))((IPropertyValue*)Unsafe.AsPointer(ref this), valueLength, value);
    }

    /// <include file='IPropertyValue.xml' path='doc/member[@name="IPropertyValue.GetDateTimeArray"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(40)]
    public HRESULT GetDateTimeArray([NativeTypeName("UINT32 *")] uint* valueLength, [NativeTypeName("ABI::Windows::Foundation::DateTime **")] DateTime** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPropertyValue*, uint*, DateTime**, int>)(lpVtbl[40]))((IPropertyValue*)Unsafe.AsPointer(ref this), valueLength, value);
    }

    /// <include file='IPropertyValue.xml' path='doc/member[@name="IPropertyValue.GetTimeSpanArray"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(41)]
    public HRESULT GetTimeSpanArray([NativeTypeName("UINT32 *")] uint* valueLength, [NativeTypeName("ABI::Windows::Foundation::TimeSpan **")] TimeSpan** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPropertyValue*, uint*, TimeSpan**, int>)(lpVtbl[41]))((IPropertyValue*)Unsafe.AsPointer(ref this), valueLength, value);
    }

    /// <include file='IPropertyValue.xml' path='doc/member[@name="IPropertyValue.GetPointArray"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(42)]
    public HRESULT GetPointArray([NativeTypeName("UINT32 *")] uint* valueLength, [NativeTypeName("ABI::Windows::Foundation::Point **")] Point** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPropertyValue*, uint*, Point**, int>)(lpVtbl[42]))((IPropertyValue*)Unsafe.AsPointer(ref this), valueLength, value);
    }

    /// <include file='IPropertyValue.xml' path='doc/member[@name="IPropertyValue.GetSizeArray"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(43)]
    public HRESULT GetSizeArray([NativeTypeName("UINT32 *")] uint* valueLength, [NativeTypeName("ABI::Windows::Foundation::Size **")] Size** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPropertyValue*, uint*, Size**, int>)(lpVtbl[43]))((IPropertyValue*)Unsafe.AsPointer(ref this), valueLength, value);
    }

    /// <include file='IPropertyValue.xml' path='doc/member[@name="IPropertyValue.GetRectArray"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(44)]
    public HRESULT GetRectArray([NativeTypeName("UINT32 *")] uint* valueLength, [NativeTypeName("ABI::Windows::Foundation::Rect **")] Rect** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPropertyValue*, uint*, Rect**, int>)(lpVtbl[44]))((IPropertyValue*)Unsafe.AsPointer(ref this), valueLength, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Type([NativeTypeName("ABI::Windows::Foundation::PropertyType *")] PropertyType* value);

        [VtblIndex(7)]
        HRESULT get_IsNumericScalar([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(8)]
        HRESULT GetUInt8(byte* value);

        [VtblIndex(9)]
        HRESULT GetInt16([NativeTypeName("INT16 *")] short* value);

        [VtblIndex(10)]
        HRESULT GetUInt16([NativeTypeName("UINT16 *")] ushort* value);

        [VtblIndex(11)]
        HRESULT GetInt32([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(12)]
        HRESULT GetUInt32([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(13)]
        HRESULT GetInt64([NativeTypeName("INT64 *")] long* value);

        [VtblIndex(14)]
        HRESULT GetUInt64([NativeTypeName("UINT64 *")] ulong* value);

        [VtblIndex(15)]
        HRESULT GetSingle(float* value);

        [VtblIndex(16)]
        HRESULT GetDouble(double* value);

        [VtblIndex(17)]
        HRESULT GetChar16([NativeTypeName("WCHAR *")] char* value);

        [VtblIndex(18)]
        HRESULT GetBoolean([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(19)]
        HRESULT GetString(HSTRING* value);

        [VtblIndex(20)]
        HRESULT GetGuid(Guid* value);

        [VtblIndex(21)]
        HRESULT GetDateTime([NativeTypeName("ABI::Windows::Foundation::DateTime *")] DateTime* value);

        [VtblIndex(22)]
        HRESULT GetTimeSpan([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value);

        [VtblIndex(23)]
        HRESULT GetPoint([NativeTypeName("ABI::Windows::Foundation::Point *")] Point* value);

        [VtblIndex(24)]
        HRESULT GetSize([NativeTypeName("ABI::Windows::Foundation::Size *")] Size* value);

        [VtblIndex(25)]
        HRESULT GetRect([NativeTypeName("ABI::Windows::Foundation::Rect *")] Rect* value);

        [VtblIndex(26)]
        HRESULT GetUInt8Array([NativeTypeName("UINT32 *")] uint* valueLength, byte** value);

        [VtblIndex(27)]
        HRESULT GetInt16Array([NativeTypeName("UINT32 *")] uint* valueLength, [NativeTypeName("INT16 **")] short** value);

        [VtblIndex(28)]
        HRESULT GetUInt16Array([NativeTypeName("UINT32 *")] uint* valueLength, [NativeTypeName("UINT16 **")] ushort** value);

        [VtblIndex(29)]
        HRESULT GetInt32Array([NativeTypeName("UINT32 *")] uint* valueLength, [NativeTypeName("INT32 **")] int** value);

        [VtblIndex(30)]
        HRESULT GetUInt32Array([NativeTypeName("UINT32 *")] uint* valueLength, [NativeTypeName("UINT32 **")] uint** value);

        [VtblIndex(31)]
        HRESULT GetInt64Array([NativeTypeName("UINT32 *")] uint* valueLength, [NativeTypeName("INT64 **")] long** value);

        [VtblIndex(32)]
        HRESULT GetUInt64Array([NativeTypeName("UINT32 *")] uint* valueLength, [NativeTypeName("UINT64 **")] ulong** value);

        [VtblIndex(33)]
        HRESULT GetSingleArray([NativeTypeName("UINT32 *")] uint* valueLength, float** value);

        [VtblIndex(34)]
        HRESULT GetDoubleArray([NativeTypeName("UINT32 *")] uint* valueLength, double** value);

        [VtblIndex(35)]
        HRESULT GetChar16Array([NativeTypeName("UINT32 *")] uint* valueLength, [NativeTypeName("WCHAR **")] char** value);

        [VtblIndex(36)]
        HRESULT GetBooleanArray([NativeTypeName("UINT32 *")] uint* valueLength, [NativeTypeName("boolean **")] byte** value);

        [VtblIndex(37)]
        HRESULT GetStringArray([NativeTypeName("UINT32 *")] uint* valueLength, HSTRING** value);

        [VtblIndex(38)]
        HRESULT GetInspectableArray([NativeTypeName("UINT32 *")] uint* valueLength, IInspectable*** value);

        [VtblIndex(39)]
        HRESULT GetGuidArray([NativeTypeName("UINT32 *")] uint* valueLength, Guid** value);

        [VtblIndex(40)]
        HRESULT GetDateTimeArray([NativeTypeName("UINT32 *")] uint* valueLength, [NativeTypeName("ABI::Windows::Foundation::DateTime **")] DateTime** value);

        [VtblIndex(41)]
        HRESULT GetTimeSpanArray([NativeTypeName("UINT32 *")] uint* valueLength, [NativeTypeName("ABI::Windows::Foundation::TimeSpan **")] TimeSpan** value);

        [VtblIndex(42)]
        HRESULT GetPointArray([NativeTypeName("UINT32 *")] uint* valueLength, [NativeTypeName("ABI::Windows::Foundation::Point **")] Point** value);

        [VtblIndex(43)]
        HRESULT GetSizeArray([NativeTypeName("UINT32 *")] uint* valueLength, [NativeTypeName("ABI::Windows::Foundation::Size **")] Size** value);

        [VtblIndex(44)]
        HRESULT GetRectArray([NativeTypeName("UINT32 *")] uint* valueLength, [NativeTypeName("ABI::Windows::Foundation::Rect **")] Rect** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::PropertyType *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, PropertyType*, int> get_Type;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsNumericScalar;

        [NativeTypeName("HRESULT (BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> GetUInt8;

        [NativeTypeName("HRESULT (INT16 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, short*, int> GetInt16;

        [NativeTypeName("HRESULT (UINT16 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ushort*, int> GetUInt16;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> GetInt32;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> GetUInt32;

        [NativeTypeName("HRESULT (INT64 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, long*, int> GetInt64;

        [NativeTypeName("HRESULT (UINT64 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ulong*, int> GetUInt64;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float*, int> GetSingle;

        [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double*, int> GetDouble;

        [NativeTypeName("HRESULT (WCHAR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> GetChar16;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> GetBoolean;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> GetString;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> GetGuid;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::DateTime *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, DateTime*, int> GetDateTime;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TimeSpan*, int> GetTimeSpan;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Point *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Point*, int> GetPoint;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Size *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Size*, int> GetSize;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Rect *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Rect*, int> GetRect;

        [NativeTypeName("HRESULT (UINT32 *, BYTE **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, byte**, int> GetUInt8Array;

        [NativeTypeName("HRESULT (UINT32 *, INT16 **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, short**, int> GetInt16Array;

        [NativeTypeName("HRESULT (UINT32 *, UINT16 **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, ushort**, int> GetUInt16Array;

        [NativeTypeName("HRESULT (UINT32 *, INT32 **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int**, int> GetInt32Array;

        [NativeTypeName("HRESULT (UINT32 *, UINT32 **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, uint**, int> GetUInt32Array;

        [NativeTypeName("HRESULT (UINT32 *, INT64 **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, long**, int> GetInt64Array;

        [NativeTypeName("HRESULT (UINT32 *, UINT64 **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, ulong**, int> GetUInt64Array;

        [NativeTypeName("HRESULT (UINT32 *, FLOAT **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, float**, int> GetSingleArray;

        [NativeTypeName("HRESULT (UINT32 *, DOUBLE **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, double**, int> GetDoubleArray;

        [NativeTypeName("HRESULT (UINT32 *, WCHAR **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, char**, int> GetChar16Array;

        [NativeTypeName("HRESULT (UINT32 *, boolean **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, byte**, int> GetBooleanArray;

        [NativeTypeName("HRESULT (UINT32 *, HSTRING **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, HSTRING**, int> GetStringArray;

        [NativeTypeName("HRESULT (UINT32 *, IInspectable ***) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, IInspectable***, int> GetInspectableArray;

        [NativeTypeName("HRESULT (UINT32 *, GUID **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, Guid**, int> GetGuidArray;

        [NativeTypeName("HRESULT (UINT32 *, ABI::Windows::Foundation::DateTime **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, DateTime**, int> GetDateTimeArray;

        [NativeTypeName("HRESULT (UINT32 *, ABI::Windows::Foundation::TimeSpan **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, TimeSpan**, int> GetTimeSpanArray;

        [NativeTypeName("HRESULT (UINT32 *, ABI::Windows::Foundation::Point **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, Point**, int> GetPointArray;

        [NativeTypeName("HRESULT (UINT32 *, ABI::Windows::Foundation::Size **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, Size**, int> GetSizeArray;

        [NativeTypeName("HRESULT (UINT32 *, ABI::Windows::Foundation::Rect **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, Rect**, int> GetRectArray;
    }
}
