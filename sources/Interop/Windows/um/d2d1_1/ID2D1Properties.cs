// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1_1.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Security;
using static TerraFX.Utilities.InteropUtilities;

namespace TerraFX.Interop
{
    /// <summary>Represents a set of run-time bindable and discoverable properties that allow a data-driven application to modify the state of a Direct2D effect.</summary>
    [Guid("483473D7-CD46-4F9D-9D3A-3112AA80159D")]
    public unsafe struct ID2D1Properties
    {
        #region Fields
        public readonly Vtbl* lpVtbl;
        #endregion

        #region IUnknown Delegates
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _QueryInterface(
            [In] ID2D1Properties* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _AddRef(
            [In] ID2D1Properties* This
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _Release(
            [In] ID2D1Properties* This
        );
        #endregion

        #region Delegates
        /// <summary>Returns the total number of custom properties in this interface.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("UINT32")]
        public /* static */ delegate uint _GetPropertyCount(
            [In] ID2D1Properties* This
        );

        /// <summary>Retrieves the property name from the given property index.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetPropertyName(
            [In] ID2D1Properties* This,
            [In, NativeTypeName("UINT32")] uint index,
            [Out, NativeTypeName("PWSTR")] char* name,
            [In, NativeTypeName("UINT32")] uint nameCount
        );

        /// <summary>Returns the length of the property name from the given index.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("UINT32")]
        public /* static */ delegate uint _GetPropertyNameLength(
            [In] ID2D1Properties* This,
            [In, NativeTypeName("UINT32")] uint index
        );

        /// <summary>Retrieves the type of the given property.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate D2D1_PROPERTY_TYPE __GetType(
            [In] ID2D1Properties* This,
            [In, NativeTypeName("UINT32")] uint index
        );

        /// <summary>Retrieves the property index for the given property name.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("UINT32")]
        public /* static */ delegate uint _GetPropertyIndex(
            [In] ID2D1Properties* This,
            [In, NativeTypeName("PCWSTR")] char* name
        );

        /// <summary>Sets the value of the given property using its name.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetValueByName(
            [In] ID2D1Properties* This,
            [In, NativeTypeName("PCWSTR")] char* name,
            [In] D2D1_PROPERTY_TYPE type,
            [In, NativeTypeName("BYTE[]")] byte* data,
            [In, NativeTypeName("UINT32")] uint dataSize
        );

        /// <summary>Sets the given value using the property index.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetValue(
            [In] ID2D1Properties* This,
            [In, NativeTypeName("UINT32")] uint index,
            [In] D2D1_PROPERTY_TYPE type,
            [In, NativeTypeName("BYTE[]")] byte* data,
            [In, NativeTypeName("UINT32")] uint dataSize
        );

        /// <summary>Retrieves the given property or sub-property by name. '.' is the delimiter for sub-properties.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetValueByName(
            [In] ID2D1Properties* This,
            [In, NativeTypeName("PCWSTR")] char* name,
            [In] D2D1_PROPERTY_TYPE type,
            [Out, NativeTypeName("BYTE[]")] byte* data,
            [In, NativeTypeName("UINT32")] uint dataSize
        );

        /// <summary>Retrieves the given value by index.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetValue(
            [In] ID2D1Properties* This,
            [In, NativeTypeName("UINT32")] uint index,
            [In] D2D1_PROPERTY_TYPE type,
            [Out, NativeTypeName("BYTE[]")] byte* data,
            [In, NativeTypeName("UINT32")] uint dataSize
        );

        /// <summary>Returns the value size for the given property index.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("UINT32")]
        public /* static */ delegate uint _GetValueSize(
            [In] ID2D1Properties* This,
            [In, NativeTypeName("UINT32")] uint index
        );

        /// <summary>Retrieves the sub-properties of the given property by index.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetSubProperties(
            [In] ID2D1Properties* This,
            [In, NativeTypeName("UINT32")] uint index,
            [Out] ID2D1Properties** subProperties
        );
        #endregion

        #region IUnknown Methods
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (ID2D1Properties* This = &this)
            {
                return MarshalFunction<_QueryInterface>(lpVtbl->QueryInterface)(
                    This,
                    riid,
                    ppvObject
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (ID2D1Properties* This = &this)
            {
                return MarshalFunction<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (ID2D1Properties* This = &this)
            {
                return MarshalFunction<_Release>(lpVtbl->Release)(
                    This
                );
            }
        }
        #endregion

        #region Methods
        [return: NativeTypeName("UINT32")]
        public uint GetPropertyCount()
        {
            fixed (ID2D1Properties* This = &this)
            {
                return MarshalFunction<_GetPropertyCount>(lpVtbl->GetPropertyCount)(
                    This
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPropertyName(
            [In, NativeTypeName("UINT32")] uint index,
            [Out, NativeTypeName("PWSTR")] char* name,
            [In, NativeTypeName("UINT32")] uint nameCount
        )
        {
            fixed (ID2D1Properties* This = &this)
            {
                return MarshalFunction<_GetPropertyName>(lpVtbl->GetPropertyName)(
                    This,
                    index,
                    name,
                    nameCount
                );
            }
        }

        [return: NativeTypeName("UINT32")]
        public uint GetPropertyNameLength(
            [In, NativeTypeName("UINT32")] uint index
        )
        {
            fixed (ID2D1Properties* This = &this)
            {
                return MarshalFunction<_GetPropertyNameLength>(lpVtbl->GetPropertyNameLength)(
                    This,
                    index
                );
            }
        }

        public D2D1_PROPERTY_TYPE _GetType(
            [In, NativeTypeName("UINT32")] uint index
        )
        {
            fixed (ID2D1Properties* This = &this)
            {
                return MarshalFunction<__GetType>(lpVtbl->_GetType)(
                    This,
                    index
                );
            }
        }

        [return: NativeTypeName("UINT32")]
        public uint GetPropertyIndex(
            [In, NativeTypeName("PCWSTR")] char* name
        )
        {
            fixed (ID2D1Properties* This = &this)
            {
                return MarshalFunction<_GetPropertyIndex>(lpVtbl->GetPropertyIndex)(
                    This,
                    name
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetValueByName(
            [In, NativeTypeName("PCWSTR")] char* name,
            [In] D2D1_PROPERTY_TYPE type,
            [In, NativeTypeName("BYTE[]")] byte* data,
            [In, NativeTypeName("UINT32")] uint dataSize
        )
        {
            fixed (ID2D1Properties* This = &this)
            {
                return MarshalFunction<_SetValueByName>(lpVtbl->SetValueByName)(
                    This,
                    name,
                    type,
                    data,
                    dataSize
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetValue(
            [In, NativeTypeName("UINT32")] uint index,
            [In] D2D1_PROPERTY_TYPE type,
            [In, NativeTypeName("BYTE[]")] byte* data,
            [In, NativeTypeName("UINT32")] uint dataSize
        )
        {
            fixed (ID2D1Properties* This = &this)
            {
                return MarshalFunction<_SetValue>(lpVtbl->SetValue)(
                    This,
                    index,
                    type,
                    data,
                    dataSize
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetValueByName(
            [In, NativeTypeName("PCWSTR")] char* name,
            [In] D2D1_PROPERTY_TYPE type,
            [Out, NativeTypeName("BYTE[]")] byte* data,
            [In, NativeTypeName("UINT32")] uint dataSize
        )
        {
            fixed (ID2D1Properties* This = &this)
            {
                return MarshalFunction<_GetValueByName>(lpVtbl->GetValueByName)(
                    This,
                    name,
                    type,
                    data,
                    dataSize
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetValue(
            [In, NativeTypeName("UINT32")] uint index,
            [In] D2D1_PROPERTY_TYPE type,
            [Out, NativeTypeName("BYTE[]")] byte* data,
            [In, NativeTypeName("UINT32")] uint dataSize
        )
        {
            fixed (ID2D1Properties* This = &this)
            {
                return MarshalFunction<_GetValue>(lpVtbl->GetValue)(
                    This,
                    index,
                    type,
                    data,
                    dataSize
                );
            }
        }

        [return: NativeTypeName("UINT32")]
        public uint GetValueSize(
            [In, NativeTypeName("UINT32")] uint index
        )
        {
            fixed (ID2D1Properties* This = &this)
            {
                return MarshalFunction<_GetValueSize>(lpVtbl->GetValueSize)(
                    This,
                    index
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSubProperties(
            [In, NativeTypeName("UINT32")] uint index,
            [Out] ID2D1Properties** subProperties
        )
        {
            fixed (ID2D1Properties* This = &this)
            {
                return MarshalFunction<_GetSubProperties>(lpVtbl->GetSubProperties)(
                    This,
                    index,
                    subProperties
                );
            }
        }
        #endregion

        #region Structs
        public struct Vtbl
        {
            #region IUnknown Fields
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;
            #endregion

            #region Fields
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
            #endregion
        }
        #endregion
    }
}
