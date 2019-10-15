// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1_1.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.D2D1_PROPERTY_TYPE;

namespace TerraFX.Interop
{
    [Guid("483473D7-CD46-4F9D-9D3A-3112AA80159D")]
    public unsafe partial struct ID2D1Properties
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ID2D1Properties* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ID2D1Properties* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ID2D1Properties* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("UINT32")]
        public delegate uint _GetPropertyCount(ID2D1Properties* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetPropertyName(ID2D1Properties* pThis, [NativeTypeName("UINT32")] uint index, [NativeTypeName("PWSTR")] ushort* name, [NativeTypeName("UINT32")] uint nameCount);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("UINT32")]
        public delegate uint _GetPropertyNameLength(ID2D1Properties* pThis, [NativeTypeName("UINT32")] uint index);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate D2D1_PROPERTY_TYPE _GetType(ID2D1Properties* pThis, [NativeTypeName("UINT32")] uint index);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("UINT32")]
        public delegate uint _GetPropertyIndex(ID2D1Properties* pThis, [NativeTypeName("PCWSTR")] ushort* name);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetValueByName(ID2D1Properties* pThis, [NativeTypeName("PCWSTR")] ushort* name, D2D1_PROPERTY_TYPE type, [NativeTypeName("const BYTE *")] byte* data, [NativeTypeName("UINT32")] uint dataSize);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetValue(ID2D1Properties* pThis, [NativeTypeName("UINT32")] uint index, D2D1_PROPERTY_TYPE type, [NativeTypeName("const BYTE *")] byte* data, [NativeTypeName("UINT32")] uint dataSize);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetValueByName(ID2D1Properties* pThis, [NativeTypeName("PCWSTR")] ushort* name, D2D1_PROPERTY_TYPE type, [NativeTypeName("BYTE *")] byte* data, [NativeTypeName("UINT32")] uint dataSize);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetValue(ID2D1Properties* pThis, [NativeTypeName("UINT32")] uint index, D2D1_PROPERTY_TYPE type, [NativeTypeName("BYTE *")] byte* data, [NativeTypeName("UINT32")] uint dataSize);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("UINT32")]
        public delegate uint _GetValueSize(ID2D1Properties* pThis, [NativeTypeName("UINT32")] uint index);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetSubProperties(ID2D1Properties* pThis, [NativeTypeName("UINT32")] uint index, [NativeTypeName("ID2D1Properties **")] ID2D1Properties** subProperties);

        [return: NativeTypeName("HRESULT")]
        public int SetValueByName([NativeTypeName("PCWSTR")] ushort* name, [NativeTypeName("const BYTE *")] byte* data, [NativeTypeName("UINT32")] uint dataSize)
        {
            return SetValueByName(name, D2D1_PROPERTY_TYPE_UNKNOWN, data, dataSize);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetValue([NativeTypeName("UINT32")] uint index, [NativeTypeName("const BYTE *")] byte* data, [NativeTypeName("UINT32")] uint dataSize)
        {
            return SetValue(index, D2D1_PROPERTY_TYPE_UNKNOWN, data, dataSize);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetValueByName([NativeTypeName("PCWSTR")] ushort* name, [NativeTypeName("BYTE *")] byte* data, [NativeTypeName("UINT32")] uint dataSize)
        {
            return GetValueByName(name, D2D1_PROPERTY_TYPE_UNKNOWN, data, dataSize);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetValue([NativeTypeName("UINT32")] uint index, [NativeTypeName("BYTE *")] byte* data, [NativeTypeName("UINT32")] uint dataSize)
        {
            return GetValue(index, D2D1_PROPERTY_TYPE_UNKNOWN, data, dataSize);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetValueByName<T>([NativeTypeName("PCWSTR")] ushort* propertyName, T* value)
            where T : unmanaged
        {
            return GetValueByName(propertyName, D2D1_PROPERTY_TYPE_UNKNOWN, (byte*)value, unchecked((uint)sizeof(T)));
        }

        public T GetValueByName<T>([NativeTypeName("PCWSTR")] ushort* propertyName)
            where T : unmanaged
        {
            T value;
            _ = GetValueByName(propertyName, D2D1_PROPERTY_TYPE_UNKNOWN, (byte*)&value, unchecked((uint)sizeof(T)));
            return value;
        }

        [return: NativeTypeName("HRESULT")]
        public int SetValueByName<T>([NativeTypeName("PCWSTR")] ushort* propertyName, [NativeTypeName("const T &")] T* value)
            where T : unmanaged
        {
            return SetValueByName(propertyName, (byte*)value, unchecked((uint)sizeof(T)));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetValue<U>(U index, [NativeTypeName("BYTE *")] byte* data, [NativeTypeName("UINT32")] uint dataSize)
            where U : unmanaged
        {
            return GetValue((uint)(object)index, data, dataSize);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetValue<T, U>(U index, T* value)
            where T : unmanaged
            where U : unmanaged
        {
            return GetValue((uint)(object)index, (byte*)value, unchecked((uint)sizeof(T)));
        }

        public T GetValue<T, U>(U index)
            where T : unmanaged
            where U : unmanaged
        {
            T value;
            _ = GetValue((uint)(object)index, (byte*)&value, unchecked((uint)sizeof(T)));
            return value;
        }

        [return: NativeTypeName("HRESULT")]
        public int SetValue<U>(U index, [NativeTypeName("const BYTE *")] byte* data, [NativeTypeName("UINT32")] uint dataSize)
            where U : unmanaged
        {
            return SetValue((uint)(object)index, data, dataSize);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetValue<T, U>(U index, [NativeTypeName("const T &")] T* value)
            where T : unmanaged
            where U : unmanaged
        {
            return SetValue((uint)(object)index, (byte*)value, unchecked((uint)sizeof(T)));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPropertyName<U>(U index, [NativeTypeName("PWSTR")] ushort* name, [NativeTypeName("UINT32")] uint nameCount)
            where U : unmanaged
        {
            return GetPropertyName((uint)(object)index, name, nameCount);
        }

        [return: NativeTypeName("UINT32")]
        public uint GetPropertyNameLength<U>(U index)
            where U : unmanaged
        {
            return GetPropertyNameLength((uint)(object)index);
        }
    
        public D2D1_PROPERTY_TYPE GetType<U>(U index)
            where U : unmanaged
        {
            return GetType((uint)(object)index);
        }


        [return: NativeTypeName("UINT32")]
        public uint GetValueSize<U>(U index)
            where U : unmanaged
        {
            return GetValueSize((uint)(object)index);
        }
    
        [return: NativeTypeName("HRESULT")]
        public int GetSubProperties<U>(U index, ID2D1Properties **subProperties)
            where U : unmanaged
        {
            return GetSubProperties((uint)(object)index, subProperties);
        }

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((ID2D1Properties*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((ID2D1Properties*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((ID2D1Properties*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("UINT32")]
        public uint GetPropertyCount()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetPropertyCount>(lpVtbl->GetPropertyCount)((ID2D1Properties*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPropertyName([NativeTypeName("UINT32")] uint index, [NativeTypeName("PWSTR")] ushort* name, [NativeTypeName("UINT32")] uint nameCount)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetPropertyName>(lpVtbl->GetPropertyName)((ID2D1Properties*)Unsafe.AsPointer(ref this), index, name, nameCount);
        }

        [return: NativeTypeName("UINT32")]
        public uint GetPropertyNameLength([NativeTypeName("UINT32")] uint index)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetPropertyNameLength>(lpVtbl->GetPropertyNameLength)((ID2D1Properties*)Unsafe.AsPointer(ref this), index);
        }

        public D2D1_PROPERTY_TYPE GetType([NativeTypeName("UINT32")] uint index)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetType>(lpVtbl->GetType)((ID2D1Properties*)Unsafe.AsPointer(ref this), index);
        }

        [return: NativeTypeName("UINT32")]
        public uint GetPropertyIndex([NativeTypeName("PCWSTR")] ushort* name)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetPropertyIndex>(lpVtbl->GetPropertyIndex)((ID2D1Properties*)Unsafe.AsPointer(ref this), name);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetValueByName([NativeTypeName("PCWSTR")] ushort* name, D2D1_PROPERTY_TYPE type, [NativeTypeName("const BYTE *")] byte* data, [NativeTypeName("UINT32")] uint dataSize)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetValueByName>(lpVtbl->SetValueByName)((ID2D1Properties*)Unsafe.AsPointer(ref this), name, type, data, dataSize);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetValue([NativeTypeName("UINT32")] uint index, D2D1_PROPERTY_TYPE type, [NativeTypeName("const BYTE *")] byte* data, [NativeTypeName("UINT32")] uint dataSize)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetValue>(lpVtbl->SetValue)((ID2D1Properties*)Unsafe.AsPointer(ref this), index, type, data, dataSize);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetValueByName([NativeTypeName("PCWSTR")] ushort* name, D2D1_PROPERTY_TYPE type, [NativeTypeName("BYTE *")] byte* data, [NativeTypeName("UINT32")] uint dataSize)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetValueByName>(lpVtbl->GetValueByName)((ID2D1Properties*)Unsafe.AsPointer(ref this), name, type, data, dataSize);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetValue([NativeTypeName("UINT32")] uint index, D2D1_PROPERTY_TYPE type, [NativeTypeName("BYTE *")] byte* data, [NativeTypeName("UINT32")] uint dataSize)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetValue>(lpVtbl->GetValue)((ID2D1Properties*)Unsafe.AsPointer(ref this), index, type, data, dataSize);
        }

        [return: NativeTypeName("UINT32")]
        public uint GetValueSize([NativeTypeName("UINT32")] uint index)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetValueSize>(lpVtbl->GetValueSize)((ID2D1Properties*)Unsafe.AsPointer(ref this), index);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSubProperties([NativeTypeName("UINT32")] uint index, [NativeTypeName("ID2D1Properties **")] ID2D1Properties** subProperties)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetSubProperties>(lpVtbl->GetSubProperties)((ID2D1Properties*)Unsafe.AsPointer(ref this), index, subProperties);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("UINT32 () const __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetPropertyCount;

            [NativeTypeName("HRESULT (UINT32, PWSTR, UINT32) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetPropertyName;

            [NativeTypeName("UINT32 (UINT32) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetPropertyNameLength;

            [NativeTypeName("D2D1_PROPERTY_TYPE (UINT32) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public new IntPtr GetType;

            [NativeTypeName("UINT32 (PCWSTR) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetPropertyIndex;

            [NativeTypeName("HRESULT (PCWSTR, D2D1_PROPERTY_TYPE, const BYTE *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetValueByName;

            [NativeTypeName("HRESULT (UINT32, D2D1_PROPERTY_TYPE, const BYTE *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetValue;

            [NativeTypeName("HRESULT (PCWSTR, D2D1_PROPERTY_TYPE, BYTE *, UINT32) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetValueByName;

            [NativeTypeName("HRESULT (UINT32, D2D1_PROPERTY_TYPE, BYTE *, UINT32) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetValue;

            [NativeTypeName("UINT32 (UINT32) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetValueSize;

            [NativeTypeName("HRESULT (UINT32, ID2D1Properties **) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetSubProperties;
        }
    }
}
