// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1svg.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Security;
using TerraFX.Utilities;
using static TerraFX.Utilities.InteropUtilities;

namespace TerraFX.Interop
{
    /// <summary>Interface describing an SVG 'fill' or 'stroke' value.</summary>
    [Guid("D59BAB0A-68A2-455B-A5DC-9EB2854E2490")]
    [Unmanaged]
    public unsafe struct ID2D1SvgPaint
    {
        #region Fields
        public readonly Vtbl* lpVtbl;
        #endregion

        #region IUnknown Delegates
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _QueryInterface(
            [In] ID2D1SvgPaint* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _AddRef(
            [In] ID2D1SvgPaint* This
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _Release(
            [In] ID2D1SvgPaint* This
        );
        #endregion

        #region ID2D1Resource Delegates
        /// <summary>Retrieve the factory associated with this resource.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _GetFactory(
            [In] ID2D1SvgPaint* This,
            [Out] ID2D1Factory** factory
        );
        #endregion

        #region ID2D1SvgAttribute Delegates
        /// <summary>Returns the element on which this attribute is set. Returns null if the attribute is not set on any element.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _GetElement(
            [In] ID2D1SvgPaint* This,
            [Out] ID2D1SvgElement** element
        );

        /// <summary>Creates a clone of this attribute value. On creation, the cloned attribute is not set on any element.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _Clone(
            [In] ID2D1SvgPaint* This,
            [Out] ID2D1SvgAttribute** attribute
        );
        #endregion

        #region Delegates
        /// <summary>Sets the paint type.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetPaintType(
            [In] ID2D1SvgPaint* This,
            [In] D2D1_SVG_PAINT_TYPE paintType
        );

        /// <summary>Gets the paint type.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate D2D1_SVG_PAINT_TYPE _GetPaintType(
            [In] ID2D1SvgPaint* This
        );

        /// <summary>Sets the paint color that is used if the paint type is D2D1_SVG_PAINT_TYPE_COLOR.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetColor(
            [In] ID2D1SvgPaint* This,
            [In, NativeTypeName("D2D1_COLOR_F")] DXGI_RGBA* color
        );

        /// <summary>Gets the paint color that is used if the paint type is D2D1_SVG_PAINT_TYPE_COLOR.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _GetColor(
            [In] ID2D1SvgPaint* This,
            [Out, NativeTypeName("D2D1_COLOR_F")] DXGI_RGBA* color
        );

        /// <summary>Sets the element id which acts as the paint server. This id is used if the paint type is D2D1_SVG_PAINT_TYPE_URI.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetId(
            [In] ID2D1SvgPaint* This,
            [In, NativeTypeName("PCWSTR")] char* id
        );

        /// <summary>Gets the element id which acts as the paint server. This id is used if the paint type is D2D1_SVG_PAINT_TYPE_URI.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetId(
            [In] ID2D1SvgPaint* This,
            [Out, NativeTypeName("PWSTR")] char* id,
            [In, NativeTypeName("UINT32")] uint idCount
        );

        /// <summary>Gets the string length of the element id which acts as the paint server. This id is used if the paint type is D2D1_SVG_PAINT_TYPE_URI. The returned string length does not include room for the null terminator.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("UINT32")]
        public /* static */ delegate uint _GetIdLength(
            [In] ID2D1SvgPaint* This
        );
        #endregion

        #region IUnknown Methods
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (ID2D1SvgPaint* This = &this)
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
            fixed (ID2D1SvgPaint* This = &this)
            {
                return MarshalFunction<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (ID2D1SvgPaint* This = &this)
            {
                return MarshalFunction<_Release>(lpVtbl->Release)(
                    This
                );
            }
        }
        #endregion

        #region ID2D1Resource Methods
        public void GetFactory(
            [Out] ID2D1Factory** factory
        )
        {
            fixed (ID2D1SvgPaint* This = &this)
            {
                MarshalFunction<_GetFactory>(lpVtbl->GetFactory)(
                    This,
                    factory
                );
            }
        }
        #endregion

        #region ID2D1SvgAttribute Methods
        public void GetElement(
            [Out] ID2D1SvgElement** element
        )
        {
            fixed (ID2D1SvgPaint* This = &this)
            {
                MarshalFunction<_GetElement>(lpVtbl->GetElement)(
                    This,
                    element
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int Clone(
            [Out] ID2D1SvgAttribute** attribute
        )
        {
            fixed (ID2D1SvgPaint* This = &this)
            {
                return MarshalFunction<_Clone>(lpVtbl->Clone)(
                    This,
                    attribute
                );
            }
        }
        #endregion

        #region Methods
        [return: NativeTypeName("HRESULT")]
        public int SetPaintType(
            [In] D2D1_SVG_PAINT_TYPE paintType
        )
        {
            fixed (ID2D1SvgPaint* This = &this)
            {
                return MarshalFunction<_SetPaintType>(lpVtbl->SetPaintType)(
                    This,
                    paintType
                );
            }
        }

        public D2D1_SVG_PAINT_TYPE GetPaintType()
        {
            fixed (ID2D1SvgPaint* This = &this)
            {
                return MarshalFunction<_GetPaintType>(lpVtbl->GetPaintType)(
                    This
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetColor(
            [In, NativeTypeName("D2D1_COLOR_F")] DXGI_RGBA* color
        )
        {
            fixed (ID2D1SvgPaint* This = &this)
            {
                return MarshalFunction<_SetColor>(lpVtbl->SetColor)(
                    This,
                    color
                );
            }
        }

        public void GetColor(
            [Out, NativeTypeName("D2D1_COLOR_F")] DXGI_RGBA* color
        )
        {
            fixed (ID2D1SvgPaint* This = &this)
            {
                MarshalFunction<_GetColor>(lpVtbl->GetColor)(
                    This,
                    color
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetId(
            [In, NativeTypeName("PCWSTR")] char* id
        )
        {
            fixed (ID2D1SvgPaint* This = &this)
            {
                return MarshalFunction<_SetId>(lpVtbl->SetId)(
                    This,
                    id
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetId(
            [Out, NativeTypeName("PWSTR")] char* id,
            [In, NativeTypeName("UINT32")] uint idCount
        )
        {
            fixed (ID2D1SvgPaint* This = &this)
            {
                return MarshalFunction<_GetId>(lpVtbl->GetId)(
                    This,
                    id,
                    idCount
                );
            }
        }

        [return: NativeTypeName("UINT32")]
        public uint GetIdLength()
        {
            fixed (ID2D1SvgPaint* This = &this)
            {
                return MarshalFunction<_GetIdLength>(lpVtbl->GetIdLength)(
                    This
                );
            }
        }
        #endregion

        #region Structs
        [Unmanaged]
        public struct Vtbl
        {
            #region IUnknown Fields
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;
            #endregion

            #region ID2D1Resource Fields
            public IntPtr GetFactory;
            #endregion

            #region ID2D1SvgAttribute Fields
            public IntPtr GetElement;

            public IntPtr Clone;
            #endregion

            #region Fields
            public IntPtr SetPaintType;

            public IntPtr GetPaintType;

            public IntPtr SetColor;

            public IntPtr GetColor;

            public IntPtr SetId;

            public IntPtr GetId;

            public IntPtr GetIdLength;
            #endregion
        }
        #endregion
    }
}
