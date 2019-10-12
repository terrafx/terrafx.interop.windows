// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1svg.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    /// <summary>Interface describing an SVG 'fill' or 'stroke' value.</summary>
    [Guid("D59BAB0A-68A2-455B-A5DC-9EB2854E2490")]
    public unsafe partial struct ID2D1SvgPaint
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ID2D1SvgPaint* This, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ID2D1SvgPaint* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ID2D1SvgPaint* This);

        /// <summary>Retrieve the factory associated with this resource.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetFactory(ID2D1SvgPaint* This, ID2D1Factory** factory);

        /// <summary>Returns the element on which this attribute is set. Returns null if the attribute is not set on any element.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetElement(ID2D1SvgPaint* This, ID2D1SvgElement** element);

        /// <summary>Creates a clone of this attribute value. On creation, the cloned attribute is not set on any element.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Clone(ID2D1SvgPaint* This, ID2D1SvgAttribute** attribute);

        /// <summary>Sets the paint type.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetPaintType(ID2D1SvgPaint* This, D2D1_SVG_PAINT_TYPE paintType);

        /// <summary>Gets the paint type.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate D2D1_SVG_PAINT_TYPE _GetPaintType(ID2D1SvgPaint* This);

        /// <summary>Sets the paint color that is used if the paint type is D2D1_SVG_PAINT_TYPE_COLOR.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetColor(ID2D1SvgPaint* This, [NativeTypeName("D2D1_COLOR_F")] DXGI_RGBA* color);

        /// <summary>Gets the paint color that is used if the paint type is D2D1_SVG_PAINT_TYPE_COLOR.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetColor(ID2D1SvgPaint* This, [NativeTypeName("D2D1_COLOR_F")] DXGI_RGBA* color);

        /// <summary>Sets the element id which acts as the paint server. This id is used if the paint type is D2D1_SVG_PAINT_TYPE_URI.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetId(ID2D1SvgPaint* This, [NativeTypeName("PCWSTR")] ushort* id);

        /// <summary>Gets the element id which acts as the paint server. This id is used if the paint type is D2D1_SVG_PAINT_TYPE_URI.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetId(ID2D1SvgPaint* This, [NativeTypeName("PWSTR")] ushort* id, [NativeTypeName("UINT32")] uint idCount);

        /// <summary>Gets the string length of the element id which acts as the paint server. This id is used if the paint type is D2D1_SVG_PAINT_TYPE_URI. The returned string length does not include room for the null terminator.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("UINT32")]
        public delegate uint _GetIdLength(ID2D1SvgPaint* This);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
        {
            fixed (ID2D1SvgPaint* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(This, riid, ppvObject);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (ID2D1SvgPaint* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(This);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (ID2D1SvgPaint* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(This);
            }
        }

        public void GetFactory(ID2D1Factory** factory)
        {
            fixed (ID2D1SvgPaint* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_GetFactory>(lpVtbl->GetFactory)(This, factory);
            }
        }

        public void GetElement(ID2D1SvgElement** element)
        {
            fixed (ID2D1SvgPaint* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_GetElement>(lpVtbl->GetElement)(This, element);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int Clone(ID2D1SvgAttribute** attribute)
        {
            fixed (ID2D1SvgPaint* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Clone>(lpVtbl->Clone)(This, attribute);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPaintType(D2D1_SVG_PAINT_TYPE paintType)
        {
            fixed (ID2D1SvgPaint* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetPaintType>(lpVtbl->SetPaintType)(This, paintType);
            }
        }

        public D2D1_SVG_PAINT_TYPE GetPaintType()
        {
            fixed (ID2D1SvgPaint* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetPaintType>(lpVtbl->GetPaintType)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetColor([NativeTypeName("D2D1_COLOR_F")] DXGI_RGBA* color)
        {
            fixed (ID2D1SvgPaint* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetColor>(lpVtbl->SetColor)(This, color);
            }
        }

        public void GetColor([NativeTypeName("D2D1_COLOR_F")] DXGI_RGBA* color)
        {
            fixed (ID2D1SvgPaint* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_GetColor>(lpVtbl->GetColor)(This, color);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetId([NativeTypeName("PCWSTR")] ushort* id)
        {
            fixed (ID2D1SvgPaint* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetId>(lpVtbl->SetId)(This, id);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetId([NativeTypeName("PWSTR")] ushort* id, [NativeTypeName("UINT32")] uint idCount)
        {
            fixed (ID2D1SvgPaint* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetId>(lpVtbl->GetId)(This, id, idCount);
            }
        }

        [return: NativeTypeName("UINT32")]
        public uint GetIdLength()
        {
            fixed (ID2D1SvgPaint* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetIdLength>(lpVtbl->GetIdLength)(This);
            }
        }

        public partial struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr GetFactory;

            public IntPtr GetElement;

            public IntPtr Clone;

            public IntPtr SetPaintType;

            public IntPtr GetPaintType;

            public IntPtr SetColor;

            public IntPtr GetColor;

            public IntPtr SetId;

            public IntPtr GetId;

            public IntPtr GetIdLength;
        }
    }
}
