// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.foundation.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("629BDBC8-D932-4FF4-96B9-8D96C5C1E858")]
    [NativeTypeName("struct IPropertyValueStatics : IInspectable")]
    public unsafe partial struct IPropertyValueStatics
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IPropertyValueStatics*, Guid*, void**, int>)(lpVtbl[0]))((IPropertyValueStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IPropertyValueStatics*, uint>)(lpVtbl[1]))((IPropertyValueStatics*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IPropertyValueStatics*, uint>)(lpVtbl[2]))((IPropertyValueStatics*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IPropertyValueStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IPropertyValueStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IPropertyValueStatics*, IntPtr*, int>)(lpVtbl[4]))((IPropertyValueStatics*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IPropertyValueStatics*, TrustLevel*, int>)(lpVtbl[5]))((IPropertyValueStatics*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateEmpty([NativeTypeName("IInspectable **")] IInspectable** propertyValue)
        {
            return ((delegate* unmanaged<IPropertyValueStatics*, IInspectable**, int>)(lpVtbl[6]))((IPropertyValueStatics*)Unsafe.AsPointer(ref this), propertyValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateUInt8([NativeTypeName("BYTE")] byte value, [NativeTypeName("IInspectable **")] IInspectable** propertyValue)
        {
            return ((delegate* unmanaged<IPropertyValueStatics*, byte, IInspectable**, int>)(lpVtbl[7]))((IPropertyValueStatics*)Unsafe.AsPointer(ref this), value, propertyValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateInt16([NativeTypeName("INT16")] short value, [NativeTypeName("IInspectable **")] IInspectable** propertyValue)
        {
            return ((delegate* unmanaged<IPropertyValueStatics*, short, IInspectable**, int>)(lpVtbl[8]))((IPropertyValueStatics*)Unsafe.AsPointer(ref this), value, propertyValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateUInt16([NativeTypeName("UINT16")] ushort value, [NativeTypeName("IInspectable **")] IInspectable** propertyValue)
        {
            return ((delegate* unmanaged<IPropertyValueStatics*, ushort, IInspectable**, int>)(lpVtbl[9]))((IPropertyValueStatics*)Unsafe.AsPointer(ref this), value, propertyValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateInt32([NativeTypeName("INT32")] int value, [NativeTypeName("IInspectable **")] IInspectable** propertyValue)
        {
            return ((delegate* unmanaged<IPropertyValueStatics*, int, IInspectable**, int>)(lpVtbl[10]))((IPropertyValueStatics*)Unsafe.AsPointer(ref this), value, propertyValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateUInt32([NativeTypeName("UINT32")] uint value, [NativeTypeName("IInspectable **")] IInspectable** propertyValue)
        {
            return ((delegate* unmanaged<IPropertyValueStatics*, uint, IInspectable**, int>)(lpVtbl[11]))((IPropertyValueStatics*)Unsafe.AsPointer(ref this), value, propertyValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateInt64([NativeTypeName("INT64")] long value, [NativeTypeName("IInspectable **")] IInspectable** propertyValue)
        {
            return ((delegate* unmanaged<IPropertyValueStatics*, long, IInspectable**, int>)(lpVtbl[12]))((IPropertyValueStatics*)Unsafe.AsPointer(ref this), value, propertyValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateUInt64([NativeTypeName("UINT64")] ulong value, [NativeTypeName("IInspectable **")] IInspectable** propertyValue)
        {
            return ((delegate* unmanaged<IPropertyValueStatics*, ulong, IInspectable**, int>)(lpVtbl[13]))((IPropertyValueStatics*)Unsafe.AsPointer(ref this), value, propertyValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateSingle([NativeTypeName("FLOAT")] float value, [NativeTypeName("IInspectable **")] IInspectable** propertyValue)
        {
            return ((delegate* unmanaged<IPropertyValueStatics*, float, IInspectable**, int>)(lpVtbl[14]))((IPropertyValueStatics*)Unsafe.AsPointer(ref this), value, propertyValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateDouble([NativeTypeName("DOUBLE")] double value, [NativeTypeName("IInspectable **")] IInspectable** propertyValue)
        {
            return ((delegate* unmanaged<IPropertyValueStatics*, double, IInspectable**, int>)(lpVtbl[15]))((IPropertyValueStatics*)Unsafe.AsPointer(ref this), value, propertyValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateChar16([NativeTypeName("WCHAR")] ushort value, [NativeTypeName("IInspectable **")] IInspectable** propertyValue)
        {
            return ((delegate* unmanaged<IPropertyValueStatics*, ushort, IInspectable**, int>)(lpVtbl[16]))((IPropertyValueStatics*)Unsafe.AsPointer(ref this), value, propertyValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateBoolean([NativeTypeName("boolean")] byte value, [NativeTypeName("IInspectable **")] IInspectable** propertyValue)
        {
            return ((delegate* unmanaged<IPropertyValueStatics*, byte, IInspectable**, int>)(lpVtbl[17]))((IPropertyValueStatics*)Unsafe.AsPointer(ref this), value, propertyValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateString([NativeTypeName("HSTRING")] IntPtr value, [NativeTypeName("IInspectable **")] IInspectable** propertyValue)
        {
            return ((delegate* unmanaged<IPropertyValueStatics*, IntPtr, IInspectable**, int>)(lpVtbl[18]))((IPropertyValueStatics*)Unsafe.AsPointer(ref this), value, propertyValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateInspectable([NativeTypeName("IInspectable *")] IInspectable* value, [NativeTypeName("IInspectable **")] IInspectable** propertyValue)
        {
            return ((delegate* unmanaged<IPropertyValueStatics*, IInspectable*, IInspectable**, int>)(lpVtbl[19]))((IPropertyValueStatics*)Unsafe.AsPointer(ref this), value, propertyValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateGuid([NativeTypeName("GUID")] Guid value, [NativeTypeName("IInspectable **")] IInspectable** propertyValue)
        {
            return ((delegate* unmanaged<IPropertyValueStatics*, Guid, IInspectable**, int>)(lpVtbl[20]))((IPropertyValueStatics*)Unsafe.AsPointer(ref this), value, propertyValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateDateTime([NativeTypeName("ABI::Windows::Foundation::DateTime")] DateTime value, [NativeTypeName("IInspectable **")] IInspectable** propertyValue)
        {
            return ((delegate* unmanaged<IPropertyValueStatics*, DateTime, IInspectable**, int>)(lpVtbl[21]))((IPropertyValueStatics*)Unsafe.AsPointer(ref this), value, propertyValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateTimeSpan([NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan value, [NativeTypeName("IInspectable **")] IInspectable** propertyValue)
        {
            return ((delegate* unmanaged<IPropertyValueStatics*, TimeSpan, IInspectable**, int>)(lpVtbl[22]))((IPropertyValueStatics*)Unsafe.AsPointer(ref this), value, propertyValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreatePoint([NativeTypeName("ABI::Windows::Foundation::Point")] Point value, [NativeTypeName("IInspectable **")] IInspectable** propertyValue)
        {
            return ((delegate* unmanaged<IPropertyValueStatics*, Point, IInspectable**, int>)(lpVtbl[23]))((IPropertyValueStatics*)Unsafe.AsPointer(ref this), value, propertyValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateSize([NativeTypeName("ABI::Windows::Foundation::Size")] Size value, [NativeTypeName("IInspectable **")] IInspectable** propertyValue)
        {
            return ((delegate* unmanaged<IPropertyValueStatics*, Size, IInspectable**, int>)(lpVtbl[24]))((IPropertyValueStatics*)Unsafe.AsPointer(ref this), value, propertyValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateRect([NativeTypeName("ABI::Windows::Foundation::Rect")] Rect value, [NativeTypeName("IInspectable **")] IInspectable** propertyValue)
        {
            return ((delegate* unmanaged<IPropertyValueStatics*, Rect, IInspectable**, int>)(lpVtbl[25]))((IPropertyValueStatics*)Unsafe.AsPointer(ref this), value, propertyValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateUInt8Array([NativeTypeName("UINT32")] uint valueLength, [NativeTypeName("BYTE *")] byte* value, [NativeTypeName("IInspectable **")] IInspectable** propertyValue)
        {
            return ((delegate* unmanaged<IPropertyValueStatics*, uint, byte*, IInspectable**, int>)(lpVtbl[26]))((IPropertyValueStatics*)Unsafe.AsPointer(ref this), valueLength, value, propertyValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateInt16Array([NativeTypeName("UINT32")] uint valueLength, [NativeTypeName("INT16 *")] short* value, [NativeTypeName("IInspectable **")] IInspectable** propertyValue)
        {
            return ((delegate* unmanaged<IPropertyValueStatics*, uint, short*, IInspectable**, int>)(lpVtbl[27]))((IPropertyValueStatics*)Unsafe.AsPointer(ref this), valueLength, value, propertyValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateUInt16Array([NativeTypeName("UINT32")] uint valueLength, [NativeTypeName("UINT16 *")] ushort* value, [NativeTypeName("IInspectable **")] IInspectable** propertyValue)
        {
            return ((delegate* unmanaged<IPropertyValueStatics*, uint, ushort*, IInspectable**, int>)(lpVtbl[28]))((IPropertyValueStatics*)Unsafe.AsPointer(ref this), valueLength, value, propertyValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateInt32Array([NativeTypeName("UINT32")] uint valueLength, [NativeTypeName("INT32 *")] int* value, [NativeTypeName("IInspectable **")] IInspectable** propertyValue)
        {
            return ((delegate* unmanaged<IPropertyValueStatics*, uint, int*, IInspectable**, int>)(lpVtbl[29]))((IPropertyValueStatics*)Unsafe.AsPointer(ref this), valueLength, value, propertyValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateUInt32Array([NativeTypeName("UINT32")] uint valueLength, [NativeTypeName("UINT32 *")] uint* value, [NativeTypeName("IInspectable **")] IInspectable** propertyValue)
        {
            return ((delegate* unmanaged<IPropertyValueStatics*, uint, uint*, IInspectable**, int>)(lpVtbl[30]))((IPropertyValueStatics*)Unsafe.AsPointer(ref this), valueLength, value, propertyValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateInt64Array([NativeTypeName("UINT32")] uint valueLength, [NativeTypeName("INT64 *")] long* value, [NativeTypeName("IInspectable **")] IInspectable** propertyValue)
        {
            return ((delegate* unmanaged<IPropertyValueStatics*, uint, long*, IInspectable**, int>)(lpVtbl[31]))((IPropertyValueStatics*)Unsafe.AsPointer(ref this), valueLength, value, propertyValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateUInt64Array([NativeTypeName("UINT32")] uint valueLength, [NativeTypeName("UINT64 *")] ulong* value, [NativeTypeName("IInspectable **")] IInspectable** propertyValue)
        {
            return ((delegate* unmanaged<IPropertyValueStatics*, uint, ulong*, IInspectable**, int>)(lpVtbl[32]))((IPropertyValueStatics*)Unsafe.AsPointer(ref this), valueLength, value, propertyValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateSingleArray([NativeTypeName("UINT32")] uint valueLength, [NativeTypeName("FLOAT *")] float* value, [NativeTypeName("IInspectable **")] IInspectable** propertyValue)
        {
            return ((delegate* unmanaged<IPropertyValueStatics*, uint, float*, IInspectable**, int>)(lpVtbl[33]))((IPropertyValueStatics*)Unsafe.AsPointer(ref this), valueLength, value, propertyValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateDoubleArray([NativeTypeName("UINT32")] uint valueLength, [NativeTypeName("DOUBLE *")] double* value, [NativeTypeName("IInspectable **")] IInspectable** propertyValue)
        {
            return ((delegate* unmanaged<IPropertyValueStatics*, uint, double*, IInspectable**, int>)(lpVtbl[34]))((IPropertyValueStatics*)Unsafe.AsPointer(ref this), valueLength, value, propertyValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateChar16Array([NativeTypeName("UINT32")] uint valueLength, [NativeTypeName("WCHAR *")] ushort* value, [NativeTypeName("IInspectable **")] IInspectable** propertyValue)
        {
            return ((delegate* unmanaged<IPropertyValueStatics*, uint, ushort*, IInspectable**, int>)(lpVtbl[35]))((IPropertyValueStatics*)Unsafe.AsPointer(ref this), valueLength, value, propertyValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateBooleanArray([NativeTypeName("UINT32")] uint valueLength, [NativeTypeName("boolean *")] byte* value, [NativeTypeName("IInspectable **")] IInspectable** propertyValue)
        {
            return ((delegate* unmanaged<IPropertyValueStatics*, uint, byte*, IInspectable**, int>)(lpVtbl[36]))((IPropertyValueStatics*)Unsafe.AsPointer(ref this), valueLength, value, propertyValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateStringArray([NativeTypeName("UINT32")] uint valueLength, [NativeTypeName("HSTRING *")] IntPtr* value, [NativeTypeName("IInspectable **")] IInspectable** propertyValue)
        {
            return ((delegate* unmanaged<IPropertyValueStatics*, uint, IntPtr*, IInspectable**, int>)(lpVtbl[37]))((IPropertyValueStatics*)Unsafe.AsPointer(ref this), valueLength, value, propertyValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateInspectableArray([NativeTypeName("UINT32")] uint valueLength, [NativeTypeName("IInspectable **")] IInspectable** value, [NativeTypeName("IInspectable **")] IInspectable** propertyValue)
        {
            return ((delegate* unmanaged<IPropertyValueStatics*, uint, IInspectable**, IInspectable**, int>)(lpVtbl[38]))((IPropertyValueStatics*)Unsafe.AsPointer(ref this), valueLength, value, propertyValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateGuidArray([NativeTypeName("UINT32")] uint valueLength, [NativeTypeName("GUID *")] Guid* value, [NativeTypeName("IInspectable **")] IInspectable** propertyValue)
        {
            return ((delegate* unmanaged<IPropertyValueStatics*, uint, Guid*, IInspectable**, int>)(lpVtbl[39]))((IPropertyValueStatics*)Unsafe.AsPointer(ref this), valueLength, value, propertyValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateDateTimeArray([NativeTypeName("UINT32")] uint valueLength, [NativeTypeName("ABI::Windows::Foundation::DateTime *")] DateTime* value, [NativeTypeName("IInspectable **")] IInspectable** propertyValue)
        {
            return ((delegate* unmanaged<IPropertyValueStatics*, uint, DateTime*, IInspectable**, int>)(lpVtbl[40]))((IPropertyValueStatics*)Unsafe.AsPointer(ref this), valueLength, value, propertyValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateTimeSpanArray([NativeTypeName("UINT32")] uint valueLength, [NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value, [NativeTypeName("IInspectable **")] IInspectable** propertyValue)
        {
            return ((delegate* unmanaged<IPropertyValueStatics*, uint, TimeSpan*, IInspectable**, int>)(lpVtbl[41]))((IPropertyValueStatics*)Unsafe.AsPointer(ref this), valueLength, value, propertyValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreatePointArray([NativeTypeName("UINT32")] uint valueLength, [NativeTypeName("ABI::Windows::Foundation::Point *")] Point* value, [NativeTypeName("IInspectable **")] IInspectable** propertyValue)
        {
            return ((delegate* unmanaged<IPropertyValueStatics*, uint, Point*, IInspectable**, int>)(lpVtbl[42]))((IPropertyValueStatics*)Unsafe.AsPointer(ref this), valueLength, value, propertyValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateSizeArray([NativeTypeName("UINT32")] uint valueLength, [NativeTypeName("ABI::Windows::Foundation::Size *")] Size* value, [NativeTypeName("IInspectable **")] IInspectable** propertyValue)
        {
            return ((delegate* unmanaged<IPropertyValueStatics*, uint, Size*, IInspectable**, int>)(lpVtbl[43]))((IPropertyValueStatics*)Unsafe.AsPointer(ref this), valueLength, value, propertyValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateRectArray([NativeTypeName("UINT32")] uint valueLength, [NativeTypeName("ABI::Windows::Foundation::Rect *")] Rect* value, [NativeTypeName("IInspectable **")] IInspectable** propertyValue)
        {
            return ((delegate* unmanaged<IPropertyValueStatics*, uint, Rect*, IInspectable**, int>)(lpVtbl[44]))((IPropertyValueStatics*)Unsafe.AsPointer(ref this), valueLength, value, propertyValue);
        }
    }
}
