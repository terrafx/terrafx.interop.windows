// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1_1.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    /// <summary>Represents a set of run-time bindable and discoverable properties that allow a data-driven application to modify the state of a Direct2D effect.</summary>
    [Guid("483473D7-CD46-4F9D-9D3A-3112AA80159D")]
    public unsafe struct ID2D1Properties
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ID2D1Properties* This, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ID2D1Properties* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ID2D1Properties* This);

        /// <summary>Returns the total number of custom properties in this interface.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("UINT32")]
        public delegate uint _GetPropertyCount(ID2D1Properties* This);

        /// <summary>Retrieves the property name from the given property index.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetPropertyName(ID2D1Properties* This, [NativeTypeName("UINT32")] uint index, [NativeTypeName("PWSTR")] char* name, [NativeTypeName("UINT32")] uint nameCount);

        /// <summary>Returns the length of the property name from the given index.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("UINT32")]
        public delegate uint _GetPropertyNameLength(ID2D1Properties* This, [NativeTypeName("UINT32")] uint index);

        /// <summary>Retrieves the type of the given property.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate D2D1_PROPERTY_TYPE __GetType(ID2D1Properties* This, [NativeTypeName("UINT32")] uint index);

        /// <summary>Retrieves the property index for the given property name.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("UINT32")]
        public delegate uint _GetPropertyIndex(ID2D1Properties* This, [NativeTypeName("PCWSTR")] char* name);

        /// <summary>Sets the value of the given property using its name.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetValueByName(ID2D1Properties* This, [NativeTypeName("PCWSTR")] char* name, D2D1_PROPERTY_TYPE type, [NativeTypeName("BYTE[]")] byte* data, [NativeTypeName("UINT32")] uint dataSize);

        /// <summary>Sets the given value using the property index.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetValue(ID2D1Properties* This, [NativeTypeName("UINT32")] uint index, D2D1_PROPERTY_TYPE type, [NativeTypeName("BYTE[]")] byte* data, [NativeTypeName("UINT32")] uint dataSize);

        /// <summary>Retrieves the given property or sub-property by name. '.' is the delimiter for sub-properties.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetValueByName(ID2D1Properties* This, [NativeTypeName("PCWSTR")] char* name, D2D1_PROPERTY_TYPE type, [NativeTypeName("BYTE[]")] byte* data, [NativeTypeName("UINT32")] uint dataSize);

        /// <summary>Retrieves the given value by index.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetValue(ID2D1Properties* This, [NativeTypeName("UINT32")] uint index, D2D1_PROPERTY_TYPE type, [NativeTypeName("BYTE[]")] byte* data, [NativeTypeName("UINT32")] uint dataSize);

        /// <summary>Returns the value size for the given property index.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("UINT32")]
        public delegate uint _GetValueSize(ID2D1Properties* This, [NativeTypeName("UINT32")] uint index);

        /// <summary>Retrieves the sub-properties of the given property by index.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetSubProperties(ID2D1Properties* This, [NativeTypeName("UINT32")] uint index, ID2D1Properties** subProperties);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
        {
            fixed (ID2D1Properties* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(This, riid, ppvObject);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (ID2D1Properties* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(This);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (ID2D1Properties* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(This);
            }
        }

        [return: NativeTypeName("UINT32")]
        public uint GetPropertyCount()
        {
            fixed (ID2D1Properties* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetPropertyCount>(lpVtbl->GetPropertyCount)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPropertyName([NativeTypeName("UINT32")] uint index, [NativeTypeName("PWSTR")] char* name, [NativeTypeName("UINT32")] uint nameCount)
        {
            fixed (ID2D1Properties* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetPropertyName>(lpVtbl->GetPropertyName)(This, index, name, nameCount);
            }
        }

        [return: NativeTypeName("UINT32")]
        public uint GetPropertyNameLength([NativeTypeName("UINT32")] uint index)
        {
            fixed (ID2D1Properties* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetPropertyNameLength>(lpVtbl->GetPropertyNameLength)(This, index);
            }
        }

        public D2D1_PROPERTY_TYPE _GetType([NativeTypeName("UINT32")] uint index)
        {
            fixed (ID2D1Properties* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<__GetType>(lpVtbl->_GetType)(This, index);
            }
        }

        [return: NativeTypeName("UINT32")]
        public uint GetPropertyIndex([NativeTypeName("PCWSTR")] char* name)
        {
            fixed (ID2D1Properties* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetPropertyIndex>(lpVtbl->GetPropertyIndex)(This, name);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetValueByName([NativeTypeName("PCWSTR")] char* name, D2D1_PROPERTY_TYPE type, [NativeTypeName("BYTE[]")] byte* data, [NativeTypeName("UINT32")] uint dataSize)
        {
            fixed (ID2D1Properties* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetValueByName>(lpVtbl->SetValueByName)(This, name, type, data, dataSize);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetValue([NativeTypeName("UINT32")] uint index, D2D1_PROPERTY_TYPE type, [NativeTypeName("BYTE[]")] byte* data, [NativeTypeName("UINT32")] uint dataSize)
        {
            fixed (ID2D1Properties* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetValue>(lpVtbl->SetValue)(This, index, type, data, dataSize);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetValueByName([NativeTypeName("PCWSTR")] char* name, D2D1_PROPERTY_TYPE type, [NativeTypeName("BYTE[]")] byte* data, [NativeTypeName("UINT32")] uint dataSize)
        {
            fixed (ID2D1Properties* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetValueByName>(lpVtbl->GetValueByName)(This, name, type, data, dataSize);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetValue([NativeTypeName("UINT32")] uint index, D2D1_PROPERTY_TYPE type, [NativeTypeName("BYTE[]")] byte* data, [NativeTypeName("UINT32")] uint dataSize)
        {
            fixed (ID2D1Properties* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetValue>(lpVtbl->GetValue)(This, index, type, data, dataSize);
            }
        }

        [return: NativeTypeName("UINT32")]
        public uint GetValueSize([NativeTypeName("UINT32")] uint index)
        {
            fixed (ID2D1Properties* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetValueSize>(lpVtbl->GetValueSize)(This, index);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSubProperties([NativeTypeName("UINT32")] uint index, ID2D1Properties** subProperties)
        {
            fixed (ID2D1Properties* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetSubProperties>(lpVtbl->GetSubProperties)(This, index, subProperties);
            }
        }

        public struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr GetPropertyCount;

            public IntPtr GetPropertyName;

            public IntPtr GetPropertyNameLength;

            public IntPtr _GetType;

            public IntPtr GetPropertyIndex;

            public IntPtr SetValueByName;

            public IntPtr SetValue;

            public IntPtr GetValueByName;

            public IntPtr GetValue;

            public IntPtr GetValueSize;

            public IntPtr GetSubProperties;
        }
    }
}
