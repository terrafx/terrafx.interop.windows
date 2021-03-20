// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.foundation.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("4BD682DD-7554-40E9-9A9B-82654EDE7E62")]
    [NativeTypeName("struct IPropertyValue : IInspectable")]
    public unsafe partial struct IPropertyValue
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IPropertyValue*, Guid*, void**, int>)(lpVtbl[0]))((IPropertyValue*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IPropertyValue*, uint>)(lpVtbl[1]))((IPropertyValue*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IPropertyValue*, uint>)(lpVtbl[2]))((IPropertyValue*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IPropertyValue*, uint*, Guid**, int>)(lpVtbl[3]))((IPropertyValue*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IPropertyValue*, IntPtr*, int>)(lpVtbl[4]))((IPropertyValue*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IPropertyValue*, TrustLevel*, int>)(lpVtbl[5]))((IPropertyValue*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Type([NativeTypeName("ABI::Windows::Foundation::PropertyType *")] PropertyType* value)
        {
            return ((delegate* unmanaged<IPropertyValue*, PropertyType*, int>)(lpVtbl[6]))((IPropertyValue*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_IsNumericScalar([NativeTypeName("boolean *")] byte* value)
        {
            return ((delegate* unmanaged<IPropertyValue*, byte*, int>)(lpVtbl[7]))((IPropertyValue*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetUInt8([NativeTypeName("BYTE *")] byte* value)
        {
            return ((delegate* unmanaged<IPropertyValue*, byte*, int>)(lpVtbl[8]))((IPropertyValue*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetInt16([NativeTypeName("INT16 *")] short* value)
        {
            return ((delegate* unmanaged<IPropertyValue*, short*, int>)(lpVtbl[9]))((IPropertyValue*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetUInt16([NativeTypeName("UINT16 *")] ushort* value)
        {
            return ((delegate* unmanaged<IPropertyValue*, ushort*, int>)(lpVtbl[10]))((IPropertyValue*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetInt32([NativeTypeName("INT32 *")] int* value)
        {
            return ((delegate* unmanaged<IPropertyValue*, int*, int>)(lpVtbl[11]))((IPropertyValue*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetUInt32([NativeTypeName("UINT32 *")] uint* value)
        {
            return ((delegate* unmanaged<IPropertyValue*, uint*, int>)(lpVtbl[12]))((IPropertyValue*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetInt64([NativeTypeName("INT64 *")] long* value)
        {
            return ((delegate* unmanaged<IPropertyValue*, long*, int>)(lpVtbl[13]))((IPropertyValue*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetUInt64([NativeTypeName("UINT64 *")] ulong* value)
        {
            return ((delegate* unmanaged<IPropertyValue*, ulong*, int>)(lpVtbl[14]))((IPropertyValue*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSingle([NativeTypeName("FLOAT *")] float* value)
        {
            return ((delegate* unmanaged<IPropertyValue*, float*, int>)(lpVtbl[15]))((IPropertyValue*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDouble([NativeTypeName("DOUBLE *")] double* value)
        {
            return ((delegate* unmanaged<IPropertyValue*, double*, int>)(lpVtbl[16]))((IPropertyValue*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetChar16([NativeTypeName("WCHAR *")] ushort* value)
        {
            return ((delegate* unmanaged<IPropertyValue*, ushort*, int>)(lpVtbl[17]))((IPropertyValue*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetBoolean([NativeTypeName("boolean *")] byte* value)
        {
            return ((delegate* unmanaged<IPropertyValue*, byte*, int>)(lpVtbl[18]))((IPropertyValue*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetString([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<IPropertyValue*, IntPtr*, int>)(lpVtbl[19]))((IPropertyValue*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetGuid([NativeTypeName("GUID *")] Guid* value)
        {
            return ((delegate* unmanaged<IPropertyValue*, Guid*, int>)(lpVtbl[20]))((IPropertyValue*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDateTime([NativeTypeName("ABI::Windows::Foundation::DateTime *")] DateTime* value)
        {
            return ((delegate* unmanaged<IPropertyValue*, DateTime*, int>)(lpVtbl[21]))((IPropertyValue*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTimeSpan([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value)
        {
            return ((delegate* unmanaged<IPropertyValue*, TimeSpan*, int>)(lpVtbl[22]))((IPropertyValue*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPoint([NativeTypeName("ABI::Windows::Foundation::Point *")] Point* value)
        {
            return ((delegate* unmanaged<IPropertyValue*, Point*, int>)(lpVtbl[23]))((IPropertyValue*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSize([NativeTypeName("ABI::Windows::Foundation::Size *")] Size* value)
        {
            return ((delegate* unmanaged<IPropertyValue*, Size*, int>)(lpVtbl[24]))((IPropertyValue*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRect([NativeTypeName("ABI::Windows::Foundation::Rect *")] Rect* value)
        {
            return ((delegate* unmanaged<IPropertyValue*, Rect*, int>)(lpVtbl[25]))((IPropertyValue*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetUInt8Array([NativeTypeName("UINT32 *")] uint* valueLength, [NativeTypeName("BYTE **")] byte** value)
        {
            return ((delegate* unmanaged<IPropertyValue*, uint*, byte**, int>)(lpVtbl[26]))((IPropertyValue*)Unsafe.AsPointer(ref this), valueLength, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetInt16Array([NativeTypeName("UINT32 *")] uint* valueLength, [NativeTypeName("INT16 **")] short** value)
        {
            return ((delegate* unmanaged<IPropertyValue*, uint*, short**, int>)(lpVtbl[27]))((IPropertyValue*)Unsafe.AsPointer(ref this), valueLength, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetUInt16Array([NativeTypeName("UINT32 *")] uint* valueLength, [NativeTypeName("UINT16 **")] ushort** value)
        {
            return ((delegate* unmanaged<IPropertyValue*, uint*, ushort**, int>)(lpVtbl[28]))((IPropertyValue*)Unsafe.AsPointer(ref this), valueLength, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetInt32Array([NativeTypeName("UINT32 *")] uint* valueLength, [NativeTypeName("INT32 **")] int** value)
        {
            return ((delegate* unmanaged<IPropertyValue*, uint*, int**, int>)(lpVtbl[29]))((IPropertyValue*)Unsafe.AsPointer(ref this), valueLength, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetUInt32Array([NativeTypeName("UINT32 *")] uint* valueLength, [NativeTypeName("UINT32 **")] uint** value)
        {
            return ((delegate* unmanaged<IPropertyValue*, uint*, uint**, int>)(lpVtbl[30]))((IPropertyValue*)Unsafe.AsPointer(ref this), valueLength, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetInt64Array([NativeTypeName("UINT32 *")] uint* valueLength, [NativeTypeName("INT64 **")] long** value)
        {
            return ((delegate* unmanaged<IPropertyValue*, uint*, long**, int>)(lpVtbl[31]))((IPropertyValue*)Unsafe.AsPointer(ref this), valueLength, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetUInt64Array([NativeTypeName("UINT32 *")] uint* valueLength, [NativeTypeName("UINT64 **")] ulong** value)
        {
            return ((delegate* unmanaged<IPropertyValue*, uint*, ulong**, int>)(lpVtbl[32]))((IPropertyValue*)Unsafe.AsPointer(ref this), valueLength, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSingleArray([NativeTypeName("UINT32 *")] uint* valueLength, [NativeTypeName("FLOAT **")] float** value)
        {
            return ((delegate* unmanaged<IPropertyValue*, uint*, float**, int>)(lpVtbl[33]))((IPropertyValue*)Unsafe.AsPointer(ref this), valueLength, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDoubleArray([NativeTypeName("UINT32 *")] uint* valueLength, [NativeTypeName("DOUBLE **")] double** value)
        {
            return ((delegate* unmanaged<IPropertyValue*, uint*, double**, int>)(lpVtbl[34]))((IPropertyValue*)Unsafe.AsPointer(ref this), valueLength, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetChar16Array([NativeTypeName("UINT32 *")] uint* valueLength, [NativeTypeName("WCHAR **")] ushort** value)
        {
            return ((delegate* unmanaged<IPropertyValue*, uint*, ushort**, int>)(lpVtbl[35]))((IPropertyValue*)Unsafe.AsPointer(ref this), valueLength, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetBooleanArray([NativeTypeName("UINT32 *")] uint* valueLength, [NativeTypeName("boolean **")] byte** value)
        {
            return ((delegate* unmanaged<IPropertyValue*, uint*, byte**, int>)(lpVtbl[36]))((IPropertyValue*)Unsafe.AsPointer(ref this), valueLength, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetStringArray([NativeTypeName("UINT32 *")] uint* valueLength, [NativeTypeName("HSTRING **")] IntPtr** value)
        {
            return ((delegate* unmanaged<IPropertyValue*, uint*, IntPtr**, int>)(lpVtbl[37]))((IPropertyValue*)Unsafe.AsPointer(ref this), valueLength, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetInspectableArray([NativeTypeName("UINT32 *")] uint* valueLength, [NativeTypeName("IInspectable ***")] IInspectable*** value)
        {
            return ((delegate* unmanaged<IPropertyValue*, uint*, IInspectable***, int>)(lpVtbl[38]))((IPropertyValue*)Unsafe.AsPointer(ref this), valueLength, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetGuidArray([NativeTypeName("UINT32 *")] uint* valueLength, [NativeTypeName("GUID **")] Guid** value)
        {
            return ((delegate* unmanaged<IPropertyValue*, uint*, Guid**, int>)(lpVtbl[39]))((IPropertyValue*)Unsafe.AsPointer(ref this), valueLength, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDateTimeArray([NativeTypeName("UINT32 *")] uint* valueLength, [NativeTypeName("ABI::Windows::Foundation::DateTime **")] DateTime** value)
        {
            return ((delegate* unmanaged<IPropertyValue*, uint*, DateTime**, int>)(lpVtbl[40]))((IPropertyValue*)Unsafe.AsPointer(ref this), valueLength, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTimeSpanArray([NativeTypeName("UINT32 *")] uint* valueLength, [NativeTypeName("ABI::Windows::Foundation::TimeSpan **")] TimeSpan** value)
        {
            return ((delegate* unmanaged<IPropertyValue*, uint*, TimeSpan**, int>)(lpVtbl[41]))((IPropertyValue*)Unsafe.AsPointer(ref this), valueLength, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPointArray([NativeTypeName("UINT32 *")] uint* valueLength, [NativeTypeName("ABI::Windows::Foundation::Point **")] Point** value)
        {
            return ((delegate* unmanaged<IPropertyValue*, uint*, Point**, int>)(lpVtbl[42]))((IPropertyValue*)Unsafe.AsPointer(ref this), valueLength, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSizeArray([NativeTypeName("UINT32 *")] uint* valueLength, [NativeTypeName("ABI::Windows::Foundation::Size **")] Size** value)
        {
            return ((delegate* unmanaged<IPropertyValue*, uint*, Size**, int>)(lpVtbl[43]))((IPropertyValue*)Unsafe.AsPointer(ref this), valueLength, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRectArray([NativeTypeName("UINT32 *")] uint* valueLength, [NativeTypeName("ABI::Windows::Foundation::Rect **")] Rect** value)
        {
            return ((delegate* unmanaged<IPropertyValue*, uint*, Rect**, int>)(lpVtbl[44]))((IPropertyValue*)Unsafe.AsPointer(ref this), valueLength, value);
        }
    }
}
