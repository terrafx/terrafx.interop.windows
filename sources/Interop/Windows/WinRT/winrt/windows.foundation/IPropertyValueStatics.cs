// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.foundation.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IPropertyValueStatics.xml' path='doc/member[@name="IPropertyValueStatics"]/*' />
[Guid("629BDBC8-D932-4FF4-96B9-8D96C5C1E858")]
[NativeTypeName("struct IPropertyValueStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPropertyValueStatics : IPropertyValueStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPropertyValueStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IPropertyValueStatics*, Guid*, void**, int>)(lpVtbl[0]))((IPropertyValueStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPropertyValueStatics*, uint>)(lpVtbl[1]))((IPropertyValueStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPropertyValueStatics*, uint>)(lpVtbl[2]))((IPropertyValueStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IPropertyValueStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IPropertyValueStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IPropertyValueStatics*, HSTRING*, int>)(lpVtbl[4]))((IPropertyValueStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IPropertyValueStatics*, TrustLevel*, int>)(lpVtbl[5]))((IPropertyValueStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IPropertyValueStatics.xml' path='doc/member[@name="IPropertyValueStatics.CreateEmpty"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateEmpty(IInspectable** propertyValue)
    {
        return ((delegate* unmanaged[MemberFunction]<IPropertyValueStatics*, IInspectable**, int>)(lpVtbl[6]))((IPropertyValueStatics*)Unsafe.AsPointer(ref this), propertyValue);
    }

    /// <include file='IPropertyValueStatics.xml' path='doc/member[@name="IPropertyValueStatics.CreateUInt8"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateUInt8(byte value, IInspectable** propertyValue)
    {
        return ((delegate* unmanaged[MemberFunction]<IPropertyValueStatics*, byte, IInspectable**, int>)(lpVtbl[7]))((IPropertyValueStatics*)Unsafe.AsPointer(ref this), value, propertyValue);
    }

    /// <include file='IPropertyValueStatics.xml' path='doc/member[@name="IPropertyValueStatics.CreateInt16"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CreateInt16([NativeTypeName("INT16")] short value, IInspectable** propertyValue)
    {
        return ((delegate* unmanaged[MemberFunction]<IPropertyValueStatics*, short, IInspectable**, int>)(lpVtbl[8]))((IPropertyValueStatics*)Unsafe.AsPointer(ref this), value, propertyValue);
    }

    /// <include file='IPropertyValueStatics.xml' path='doc/member[@name="IPropertyValueStatics.CreateUInt16"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT CreateUInt16([NativeTypeName("UINT16")] ushort value, IInspectable** propertyValue)
    {
        return ((delegate* unmanaged[MemberFunction]<IPropertyValueStatics*, ushort, IInspectable**, int>)(lpVtbl[9]))((IPropertyValueStatics*)Unsafe.AsPointer(ref this), value, propertyValue);
    }

    /// <include file='IPropertyValueStatics.xml' path='doc/member[@name="IPropertyValueStatics.CreateInt32"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT CreateInt32([NativeTypeName("INT32")] int value, IInspectable** propertyValue)
    {
        return ((delegate* unmanaged[MemberFunction]<IPropertyValueStatics*, int, IInspectable**, int>)(lpVtbl[10]))((IPropertyValueStatics*)Unsafe.AsPointer(ref this), value, propertyValue);
    }

    /// <include file='IPropertyValueStatics.xml' path='doc/member[@name="IPropertyValueStatics.CreateUInt32"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT CreateUInt32([NativeTypeName("UINT32")] uint value, IInspectable** propertyValue)
    {
        return ((delegate* unmanaged[MemberFunction]<IPropertyValueStatics*, uint, IInspectable**, int>)(lpVtbl[11]))((IPropertyValueStatics*)Unsafe.AsPointer(ref this), value, propertyValue);
    }

    /// <include file='IPropertyValueStatics.xml' path='doc/member[@name="IPropertyValueStatics.CreateInt64"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT CreateInt64([NativeTypeName("INT64")] long value, IInspectable** propertyValue)
    {
        return ((delegate* unmanaged[MemberFunction]<IPropertyValueStatics*, long, IInspectable**, int>)(lpVtbl[12]))((IPropertyValueStatics*)Unsafe.AsPointer(ref this), value, propertyValue);
    }

    /// <include file='IPropertyValueStatics.xml' path='doc/member[@name="IPropertyValueStatics.CreateUInt64"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT CreateUInt64([NativeTypeName("UINT64")] ulong value, IInspectable** propertyValue)
    {
        return ((delegate* unmanaged[MemberFunction]<IPropertyValueStatics*, ulong, IInspectable**, int>)(lpVtbl[13]))((IPropertyValueStatics*)Unsafe.AsPointer(ref this), value, propertyValue);
    }

    /// <include file='IPropertyValueStatics.xml' path='doc/member[@name="IPropertyValueStatics.CreateSingle"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT CreateSingle(float value, IInspectable** propertyValue)
    {
        return ((delegate* unmanaged[MemberFunction]<IPropertyValueStatics*, float, IInspectable**, int>)(lpVtbl[14]))((IPropertyValueStatics*)Unsafe.AsPointer(ref this), value, propertyValue);
    }

    /// <include file='IPropertyValueStatics.xml' path='doc/member[@name="IPropertyValueStatics.CreateDouble"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT CreateDouble(double value, IInspectable** propertyValue)
    {
        return ((delegate* unmanaged[MemberFunction]<IPropertyValueStatics*, double, IInspectable**, int>)(lpVtbl[15]))((IPropertyValueStatics*)Unsafe.AsPointer(ref this), value, propertyValue);
    }

    /// <include file='IPropertyValueStatics.xml' path='doc/member[@name="IPropertyValueStatics.CreateChar16"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT CreateChar16([NativeTypeName("WCHAR")] char value, IInspectable** propertyValue)
    {
        return ((delegate* unmanaged[MemberFunction]<IPropertyValueStatics*, char, IInspectable**, int>)(lpVtbl[16]))((IPropertyValueStatics*)Unsafe.AsPointer(ref this), value, propertyValue);
    }

    /// <include file='IPropertyValueStatics.xml' path='doc/member[@name="IPropertyValueStatics.CreateBoolean"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT CreateBoolean([NativeTypeName("boolean")] byte value, IInspectable** propertyValue)
    {
        return ((delegate* unmanaged[MemberFunction]<IPropertyValueStatics*, byte, IInspectable**, int>)(lpVtbl[17]))((IPropertyValueStatics*)Unsafe.AsPointer(ref this), value, propertyValue);
    }

    /// <include file='IPropertyValueStatics.xml' path='doc/member[@name="IPropertyValueStatics.CreateString"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT CreateString(HSTRING value, IInspectable** propertyValue)
    {
        return ((delegate* unmanaged[MemberFunction]<IPropertyValueStatics*, HSTRING, IInspectable**, int>)(lpVtbl[18]))((IPropertyValueStatics*)Unsafe.AsPointer(ref this), value, propertyValue);
    }

    /// <include file='IPropertyValueStatics.xml' path='doc/member[@name="IPropertyValueStatics.CreateInspectable"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT CreateInspectable(IInspectable* value, IInspectable** propertyValue)
    {
        return ((delegate* unmanaged[MemberFunction]<IPropertyValueStatics*, IInspectable*, IInspectable**, int>)(lpVtbl[19]))((IPropertyValueStatics*)Unsafe.AsPointer(ref this), value, propertyValue);
    }

    /// <include file='IPropertyValueStatics.xml' path='doc/member[@name="IPropertyValueStatics.CreateGuid"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT CreateGuid(Guid value, IInspectable** propertyValue)
    {
        return ((delegate* unmanaged[MemberFunction]<IPropertyValueStatics*, Guid, IInspectable**, int>)(lpVtbl[20]))((IPropertyValueStatics*)Unsafe.AsPointer(ref this), value, propertyValue);
    }

    /// <include file='IPropertyValueStatics.xml' path='doc/member[@name="IPropertyValueStatics.CreateDateTime"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT CreateDateTime([NativeTypeName("ABI::Windows::Foundation::DateTime")] DateTime value, IInspectable** propertyValue)
    {
        return ((delegate* unmanaged[MemberFunction]<IPropertyValueStatics*, DateTime, IInspectable**, int>)(lpVtbl[21]))((IPropertyValueStatics*)Unsafe.AsPointer(ref this), value, propertyValue);
    }

    /// <include file='IPropertyValueStatics.xml' path='doc/member[@name="IPropertyValueStatics.CreateTimeSpan"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT CreateTimeSpan([NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan value, IInspectable** propertyValue)
    {
        return ((delegate* unmanaged[MemberFunction]<IPropertyValueStatics*, TimeSpan, IInspectable**, int>)(lpVtbl[22]))((IPropertyValueStatics*)Unsafe.AsPointer(ref this), value, propertyValue);
    }

    /// <include file='IPropertyValueStatics.xml' path='doc/member[@name="IPropertyValueStatics.CreatePoint"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT CreatePoint([NativeTypeName("ABI::Windows::Foundation::Point")] Point value, IInspectable** propertyValue)
    {
        return ((delegate* unmanaged[MemberFunction]<IPropertyValueStatics*, Point, IInspectable**, int>)(lpVtbl[23]))((IPropertyValueStatics*)Unsafe.AsPointer(ref this), value, propertyValue);
    }

    /// <include file='IPropertyValueStatics.xml' path='doc/member[@name="IPropertyValueStatics.CreateSize"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT CreateSize([NativeTypeName("ABI::Windows::Foundation::Size")] Size value, IInspectable** propertyValue)
    {
        return ((delegate* unmanaged[MemberFunction]<IPropertyValueStatics*, Size, IInspectable**, int>)(lpVtbl[24]))((IPropertyValueStatics*)Unsafe.AsPointer(ref this), value, propertyValue);
    }

    /// <include file='IPropertyValueStatics.xml' path='doc/member[@name="IPropertyValueStatics.CreateRect"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT CreateRect([NativeTypeName("ABI::Windows::Foundation::Rect")] Rect value, IInspectable** propertyValue)
    {
        return ((delegate* unmanaged[MemberFunction]<IPropertyValueStatics*, Rect, IInspectable**, int>)(lpVtbl[25]))((IPropertyValueStatics*)Unsafe.AsPointer(ref this), value, propertyValue);
    }

    /// <include file='IPropertyValueStatics.xml' path='doc/member[@name="IPropertyValueStatics.CreateUInt8Array"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT CreateUInt8Array([NativeTypeName("UINT32")] uint valueLength, byte* value, IInspectable** propertyValue)
    {
        return ((delegate* unmanaged[MemberFunction]<IPropertyValueStatics*, uint, byte*, IInspectable**, int>)(lpVtbl[26]))((IPropertyValueStatics*)Unsafe.AsPointer(ref this), valueLength, value, propertyValue);
    }

    /// <include file='IPropertyValueStatics.xml' path='doc/member[@name="IPropertyValueStatics.CreateInt16Array"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT CreateInt16Array([NativeTypeName("UINT32")] uint valueLength, [NativeTypeName("INT16 *")] short* value, IInspectable** propertyValue)
    {
        return ((delegate* unmanaged[MemberFunction]<IPropertyValueStatics*, uint, short*, IInspectable**, int>)(lpVtbl[27]))((IPropertyValueStatics*)Unsafe.AsPointer(ref this), valueLength, value, propertyValue);
    }

    /// <include file='IPropertyValueStatics.xml' path='doc/member[@name="IPropertyValueStatics.CreateUInt16Array"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT CreateUInt16Array([NativeTypeName("UINT32")] uint valueLength, [NativeTypeName("UINT16 *")] ushort* value, IInspectable** propertyValue)
    {
        return ((delegate* unmanaged[MemberFunction]<IPropertyValueStatics*, uint, ushort*, IInspectable**, int>)(lpVtbl[28]))((IPropertyValueStatics*)Unsafe.AsPointer(ref this), valueLength, value, propertyValue);
    }

    /// <include file='IPropertyValueStatics.xml' path='doc/member[@name="IPropertyValueStatics.CreateInt32Array"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT CreateInt32Array([NativeTypeName("UINT32")] uint valueLength, [NativeTypeName("INT32 *")] int* value, IInspectable** propertyValue)
    {
        return ((delegate* unmanaged[MemberFunction]<IPropertyValueStatics*, uint, int*, IInspectable**, int>)(lpVtbl[29]))((IPropertyValueStatics*)Unsafe.AsPointer(ref this), valueLength, value, propertyValue);
    }

    /// <include file='IPropertyValueStatics.xml' path='doc/member[@name="IPropertyValueStatics.CreateUInt32Array"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT CreateUInt32Array([NativeTypeName("UINT32")] uint valueLength, [NativeTypeName("UINT32 *")] uint* value, IInspectable** propertyValue)
    {
        return ((delegate* unmanaged[MemberFunction]<IPropertyValueStatics*, uint, uint*, IInspectable**, int>)(lpVtbl[30]))((IPropertyValueStatics*)Unsafe.AsPointer(ref this), valueLength, value, propertyValue);
    }

    /// <include file='IPropertyValueStatics.xml' path='doc/member[@name="IPropertyValueStatics.CreateInt64Array"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT CreateInt64Array([NativeTypeName("UINT32")] uint valueLength, [NativeTypeName("INT64 *")] long* value, IInspectable** propertyValue)
    {
        return ((delegate* unmanaged[MemberFunction]<IPropertyValueStatics*, uint, long*, IInspectable**, int>)(lpVtbl[31]))((IPropertyValueStatics*)Unsafe.AsPointer(ref this), valueLength, value, propertyValue);
    }

    /// <include file='IPropertyValueStatics.xml' path='doc/member[@name="IPropertyValueStatics.CreateUInt64Array"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT CreateUInt64Array([NativeTypeName("UINT32")] uint valueLength, [NativeTypeName("UINT64 *")] ulong* value, IInspectable** propertyValue)
    {
        return ((delegate* unmanaged[MemberFunction]<IPropertyValueStatics*, uint, ulong*, IInspectable**, int>)(lpVtbl[32]))((IPropertyValueStatics*)Unsafe.AsPointer(ref this), valueLength, value, propertyValue);
    }

    /// <include file='IPropertyValueStatics.xml' path='doc/member[@name="IPropertyValueStatics.CreateSingleArray"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT CreateSingleArray([NativeTypeName("UINT32")] uint valueLength, float* value, IInspectable** propertyValue)
    {
        return ((delegate* unmanaged[MemberFunction]<IPropertyValueStatics*, uint, float*, IInspectable**, int>)(lpVtbl[33]))((IPropertyValueStatics*)Unsafe.AsPointer(ref this), valueLength, value, propertyValue);
    }

    /// <include file='IPropertyValueStatics.xml' path='doc/member[@name="IPropertyValueStatics.CreateDoubleArray"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT CreateDoubleArray([NativeTypeName("UINT32")] uint valueLength, double* value, IInspectable** propertyValue)
    {
        return ((delegate* unmanaged[MemberFunction]<IPropertyValueStatics*, uint, double*, IInspectable**, int>)(lpVtbl[34]))((IPropertyValueStatics*)Unsafe.AsPointer(ref this), valueLength, value, propertyValue);
    }

    /// <include file='IPropertyValueStatics.xml' path='doc/member[@name="IPropertyValueStatics.CreateChar16Array"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT CreateChar16Array([NativeTypeName("UINT32")] uint valueLength, [NativeTypeName("WCHAR *")] char* value, IInspectable** propertyValue)
    {
        return ((delegate* unmanaged[MemberFunction]<IPropertyValueStatics*, uint, char*, IInspectable**, int>)(lpVtbl[35]))((IPropertyValueStatics*)Unsafe.AsPointer(ref this), valueLength, value, propertyValue);
    }

    /// <include file='IPropertyValueStatics.xml' path='doc/member[@name="IPropertyValueStatics.CreateBooleanArray"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public HRESULT CreateBooleanArray([NativeTypeName("UINT32")] uint valueLength, [NativeTypeName("boolean *")] byte* value, IInspectable** propertyValue)
    {
        return ((delegate* unmanaged[MemberFunction]<IPropertyValueStatics*, uint, byte*, IInspectable**, int>)(lpVtbl[36]))((IPropertyValueStatics*)Unsafe.AsPointer(ref this), valueLength, value, propertyValue);
    }

    /// <include file='IPropertyValueStatics.xml' path='doc/member[@name="IPropertyValueStatics.CreateStringArray"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public HRESULT CreateStringArray([NativeTypeName("UINT32")] uint valueLength, HSTRING* value, IInspectable** propertyValue)
    {
        return ((delegate* unmanaged[MemberFunction]<IPropertyValueStatics*, uint, HSTRING*, IInspectable**, int>)(lpVtbl[37]))((IPropertyValueStatics*)Unsafe.AsPointer(ref this), valueLength, value, propertyValue);
    }

    /// <include file='IPropertyValueStatics.xml' path='doc/member[@name="IPropertyValueStatics.CreateInspectableArray"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    public HRESULT CreateInspectableArray([NativeTypeName("UINT32")] uint valueLength, IInspectable** value, IInspectable** propertyValue)
    {
        return ((delegate* unmanaged[MemberFunction]<IPropertyValueStatics*, uint, IInspectable**, IInspectable**, int>)(lpVtbl[38]))((IPropertyValueStatics*)Unsafe.AsPointer(ref this), valueLength, value, propertyValue);
    }

    /// <include file='IPropertyValueStatics.xml' path='doc/member[@name="IPropertyValueStatics.CreateGuidArray"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(39)]
    public HRESULT CreateGuidArray([NativeTypeName("UINT32")] uint valueLength, Guid* value, IInspectable** propertyValue)
    {
        return ((delegate* unmanaged[MemberFunction]<IPropertyValueStatics*, uint, Guid*, IInspectable**, int>)(lpVtbl[39]))((IPropertyValueStatics*)Unsafe.AsPointer(ref this), valueLength, value, propertyValue);
    }

    /// <include file='IPropertyValueStatics.xml' path='doc/member[@name="IPropertyValueStatics.CreateDateTimeArray"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(40)]
    public HRESULT CreateDateTimeArray([NativeTypeName("UINT32")] uint valueLength, [NativeTypeName("ABI::Windows::Foundation::DateTime *")] DateTime* value, IInspectable** propertyValue)
    {
        return ((delegate* unmanaged[MemberFunction]<IPropertyValueStatics*, uint, DateTime*, IInspectable**, int>)(lpVtbl[40]))((IPropertyValueStatics*)Unsafe.AsPointer(ref this), valueLength, value, propertyValue);
    }

    /// <include file='IPropertyValueStatics.xml' path='doc/member[@name="IPropertyValueStatics.CreateTimeSpanArray"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(41)]
    public HRESULT CreateTimeSpanArray([NativeTypeName("UINT32")] uint valueLength, [NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value, IInspectable** propertyValue)
    {
        return ((delegate* unmanaged[MemberFunction]<IPropertyValueStatics*, uint, TimeSpan*, IInspectable**, int>)(lpVtbl[41]))((IPropertyValueStatics*)Unsafe.AsPointer(ref this), valueLength, value, propertyValue);
    }

    /// <include file='IPropertyValueStatics.xml' path='doc/member[@name="IPropertyValueStatics.CreatePointArray"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(42)]
    public HRESULT CreatePointArray([NativeTypeName("UINT32")] uint valueLength, [NativeTypeName("ABI::Windows::Foundation::Point *")] Point* value, IInspectable** propertyValue)
    {
        return ((delegate* unmanaged[MemberFunction]<IPropertyValueStatics*, uint, Point*, IInspectable**, int>)(lpVtbl[42]))((IPropertyValueStatics*)Unsafe.AsPointer(ref this), valueLength, value, propertyValue);
    }

    /// <include file='IPropertyValueStatics.xml' path='doc/member[@name="IPropertyValueStatics.CreateSizeArray"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(43)]
    public HRESULT CreateSizeArray([NativeTypeName("UINT32")] uint valueLength, [NativeTypeName("ABI::Windows::Foundation::Size *")] Size* value, IInspectable** propertyValue)
    {
        return ((delegate* unmanaged[MemberFunction]<IPropertyValueStatics*, uint, Size*, IInspectable**, int>)(lpVtbl[43]))((IPropertyValueStatics*)Unsafe.AsPointer(ref this), valueLength, value, propertyValue);
    }

    /// <include file='IPropertyValueStatics.xml' path='doc/member[@name="IPropertyValueStatics.CreateRectArray"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(44)]
    public HRESULT CreateRectArray([NativeTypeName("UINT32")] uint valueLength, [NativeTypeName("ABI::Windows::Foundation::Rect *")] Rect* value, IInspectable** propertyValue)
    {
        return ((delegate* unmanaged[MemberFunction]<IPropertyValueStatics*, uint, Rect*, IInspectable**, int>)(lpVtbl[44]))((IPropertyValueStatics*)Unsafe.AsPointer(ref this), valueLength, value, propertyValue);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateEmpty(IInspectable** propertyValue);

        [VtblIndex(7)]
        HRESULT CreateUInt8(byte value, IInspectable** propertyValue);

        [VtblIndex(8)]
        HRESULT CreateInt16([NativeTypeName("INT16")] short value, IInspectable** propertyValue);

        [VtblIndex(9)]
        HRESULT CreateUInt16([NativeTypeName("UINT16")] ushort value, IInspectable** propertyValue);

        [VtblIndex(10)]
        HRESULT CreateInt32([NativeTypeName("INT32")] int value, IInspectable** propertyValue);

        [VtblIndex(11)]
        HRESULT CreateUInt32([NativeTypeName("UINT32")] uint value, IInspectable** propertyValue);

        [VtblIndex(12)]
        HRESULT CreateInt64([NativeTypeName("INT64")] long value, IInspectable** propertyValue);

        [VtblIndex(13)]
        HRESULT CreateUInt64([NativeTypeName("UINT64")] ulong value, IInspectable** propertyValue);

        [VtblIndex(14)]
        HRESULT CreateSingle(float value, IInspectable** propertyValue);

        [VtblIndex(15)]
        HRESULT CreateDouble(double value, IInspectable** propertyValue);

        [VtblIndex(16)]
        HRESULT CreateChar16([NativeTypeName("WCHAR")] char value, IInspectable** propertyValue);

        [VtblIndex(17)]
        HRESULT CreateBoolean([NativeTypeName("boolean")] byte value, IInspectable** propertyValue);

        [VtblIndex(18)]
        HRESULT CreateString(HSTRING value, IInspectable** propertyValue);

        [VtblIndex(19)]
        HRESULT CreateInspectable(IInspectable* value, IInspectable** propertyValue);

        [VtblIndex(20)]
        HRESULT CreateGuid(Guid value, IInspectable** propertyValue);

        [VtblIndex(21)]
        HRESULT CreateDateTime([NativeTypeName("ABI::Windows::Foundation::DateTime")] DateTime value, IInspectable** propertyValue);

        [VtblIndex(22)]
        HRESULT CreateTimeSpan([NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan value, IInspectable** propertyValue);

        [VtblIndex(23)]
        HRESULT CreatePoint([NativeTypeName("ABI::Windows::Foundation::Point")] Point value, IInspectable** propertyValue);

        [VtblIndex(24)]
        HRESULT CreateSize([NativeTypeName("ABI::Windows::Foundation::Size")] Size value, IInspectable** propertyValue);

        [VtblIndex(25)]
        HRESULT CreateRect([NativeTypeName("ABI::Windows::Foundation::Rect")] Rect value, IInspectable** propertyValue);

        [VtblIndex(26)]
        HRESULT CreateUInt8Array([NativeTypeName("UINT32")] uint valueLength, byte* value, IInspectable** propertyValue);

        [VtblIndex(27)]
        HRESULT CreateInt16Array([NativeTypeName("UINT32")] uint valueLength, [NativeTypeName("INT16 *")] short* value, IInspectable** propertyValue);

        [VtblIndex(28)]
        HRESULT CreateUInt16Array([NativeTypeName("UINT32")] uint valueLength, [NativeTypeName("UINT16 *")] ushort* value, IInspectable** propertyValue);

        [VtblIndex(29)]
        HRESULT CreateInt32Array([NativeTypeName("UINT32")] uint valueLength, [NativeTypeName("INT32 *")] int* value, IInspectable** propertyValue);

        [VtblIndex(30)]
        HRESULT CreateUInt32Array([NativeTypeName("UINT32")] uint valueLength, [NativeTypeName("UINT32 *")] uint* value, IInspectable** propertyValue);

        [VtblIndex(31)]
        HRESULT CreateInt64Array([NativeTypeName("UINT32")] uint valueLength, [NativeTypeName("INT64 *")] long* value, IInspectable** propertyValue);

        [VtblIndex(32)]
        HRESULT CreateUInt64Array([NativeTypeName("UINT32")] uint valueLength, [NativeTypeName("UINT64 *")] ulong* value, IInspectable** propertyValue);

        [VtblIndex(33)]
        HRESULT CreateSingleArray([NativeTypeName("UINT32")] uint valueLength, float* value, IInspectable** propertyValue);

        [VtblIndex(34)]
        HRESULT CreateDoubleArray([NativeTypeName("UINT32")] uint valueLength, double* value, IInspectable** propertyValue);

        [VtblIndex(35)]
        HRESULT CreateChar16Array([NativeTypeName("UINT32")] uint valueLength, [NativeTypeName("WCHAR *")] char* value, IInspectable** propertyValue);

        [VtblIndex(36)]
        HRESULT CreateBooleanArray([NativeTypeName("UINT32")] uint valueLength, [NativeTypeName("boolean *")] byte* value, IInspectable** propertyValue);

        [VtblIndex(37)]
        HRESULT CreateStringArray([NativeTypeName("UINT32")] uint valueLength, HSTRING* value, IInspectable** propertyValue);

        [VtblIndex(38)]
        HRESULT CreateInspectableArray([NativeTypeName("UINT32")] uint valueLength, IInspectable** value, IInspectable** propertyValue);

        [VtblIndex(39)]
        HRESULT CreateGuidArray([NativeTypeName("UINT32")] uint valueLength, Guid* value, IInspectable** propertyValue);

        [VtblIndex(40)]
        HRESULT CreateDateTimeArray([NativeTypeName("UINT32")] uint valueLength, [NativeTypeName("ABI::Windows::Foundation::DateTime *")] DateTime* value, IInspectable** propertyValue);

        [VtblIndex(41)]
        HRESULT CreateTimeSpanArray([NativeTypeName("UINT32")] uint valueLength, [NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value, IInspectable** propertyValue);

        [VtblIndex(42)]
        HRESULT CreatePointArray([NativeTypeName("UINT32")] uint valueLength, [NativeTypeName("ABI::Windows::Foundation::Point *")] Point* value, IInspectable** propertyValue);

        [VtblIndex(43)]
        HRESULT CreateSizeArray([NativeTypeName("UINT32")] uint valueLength, [NativeTypeName("ABI::Windows::Foundation::Size *")] Size* value, IInspectable** propertyValue);

        [VtblIndex(44)]
        HRESULT CreateRectArray([NativeTypeName("UINT32")] uint valueLength, [NativeTypeName("ABI::Windows::Foundation::Rect *")] Rect* value, IInspectable** propertyValue);
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

        [NativeTypeName("HRESULT (IInspectable **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IInspectable**, int> CreateEmpty;

        [NativeTypeName("HRESULT (BYTE, IInspectable **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, IInspectable**, int> CreateUInt8;

        [NativeTypeName("HRESULT (INT16, IInspectable **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, short, IInspectable**, int> CreateInt16;

        [NativeTypeName("HRESULT (UINT16, IInspectable **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ushort, IInspectable**, int> CreateUInt16;

        [NativeTypeName("HRESULT (INT32, IInspectable **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, IInspectable**, int> CreateInt32;

        [NativeTypeName("HRESULT (UINT32, IInspectable **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, IInspectable**, int> CreateUInt32;

        [NativeTypeName("HRESULT (INT64, IInspectable **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, long, IInspectable**, int> CreateInt64;

        [NativeTypeName("HRESULT (UINT64, IInspectable **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ulong, IInspectable**, int> CreateUInt64;

        [NativeTypeName("HRESULT (FLOAT, IInspectable **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float, IInspectable**, int> CreateSingle;

        [NativeTypeName("HRESULT (DOUBLE, IInspectable **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double, IInspectable**, int> CreateDouble;

        [NativeTypeName("HRESULT (WCHAR, IInspectable **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char, IInspectable**, int> CreateChar16;

        [NativeTypeName("HRESULT (boolean, IInspectable **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, IInspectable**, int> CreateBoolean;

        [NativeTypeName("HRESULT (HSTRING, IInspectable **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IInspectable**, int> CreateString;

        [NativeTypeName("HRESULT (IInspectable *, IInspectable **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IInspectable*, IInspectable**, int> CreateInspectable;

        [NativeTypeName("HRESULT (GUID, IInspectable **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid, IInspectable**, int> CreateGuid;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::DateTime, IInspectable **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, DateTime, IInspectable**, int> CreateDateTime;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan, IInspectable **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TimeSpan, IInspectable**, int> CreateTimeSpan;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Point, IInspectable **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Point, IInspectable**, int> CreatePoint;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Size, IInspectable **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Size, IInspectable**, int> CreateSize;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Rect, IInspectable **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Rect, IInspectable**, int> CreateRect;

        [NativeTypeName("HRESULT (UINT32, BYTE *, IInspectable **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, byte*, IInspectable**, int> CreateUInt8Array;

        [NativeTypeName("HRESULT (UINT32, INT16 *, IInspectable **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, short*, IInspectable**, int> CreateInt16Array;

        [NativeTypeName("HRESULT (UINT32, UINT16 *, IInspectable **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, ushort*, IInspectable**, int> CreateUInt16Array;

        [NativeTypeName("HRESULT (UINT32, INT32 *, IInspectable **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, int*, IInspectable**, int> CreateInt32Array;

        [NativeTypeName("HRESULT (UINT32, UINT32 *, IInspectable **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint*, IInspectable**, int> CreateUInt32Array;

        [NativeTypeName("HRESULT (UINT32, INT64 *, IInspectable **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, long*, IInspectable**, int> CreateInt64Array;

        [NativeTypeName("HRESULT (UINT32, UINT64 *, IInspectable **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, ulong*, IInspectable**, int> CreateUInt64Array;

        [NativeTypeName("HRESULT (UINT32, FLOAT *, IInspectable **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, float*, IInspectable**, int> CreateSingleArray;

        [NativeTypeName("HRESULT (UINT32, DOUBLE *, IInspectable **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, double*, IInspectable**, int> CreateDoubleArray;

        [NativeTypeName("HRESULT (UINT32, WCHAR *, IInspectable **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, char*, IInspectable**, int> CreateChar16Array;

        [NativeTypeName("HRESULT (UINT32, boolean *, IInspectable **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, byte*, IInspectable**, int> CreateBooleanArray;

        [NativeTypeName("HRESULT (UINT32, HSTRING *, IInspectable **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, HSTRING*, IInspectable**, int> CreateStringArray;

        [NativeTypeName("HRESULT (UINT32, IInspectable **, IInspectable **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, IInspectable**, IInspectable**, int> CreateInspectableArray;

        [NativeTypeName("HRESULT (UINT32, GUID *, IInspectable **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, Guid*, IInspectable**, int> CreateGuidArray;

        [NativeTypeName("HRESULT (UINT32, ABI::Windows::Foundation::DateTime *, IInspectable **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, DateTime*, IInspectable**, int> CreateDateTimeArray;

        [NativeTypeName("HRESULT (UINT32, ABI::Windows::Foundation::TimeSpan *, IInspectable **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, TimeSpan*, IInspectable**, int> CreateTimeSpanArray;

        [NativeTypeName("HRESULT (UINT32, ABI::Windows::Foundation::Point *, IInspectable **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, Point*, IInspectable**, int> CreatePointArray;

        [NativeTypeName("HRESULT (UINT32, ABI::Windows::Foundation::Size *, IInspectable **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, Size*, IInspectable**, int> CreateSizeArray;

        [NativeTypeName("HRESULT (UINT32, ABI::Windows::Foundation::Rect *, IInspectable **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, Rect*, IInspectable**, int> CreateRectArray;
    }
}
