// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1svg.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    /// <summary>Interface describing an SVG 'stroke-dasharray' value.</summary>
    [Guid("F1C0CA52-92A3-4F00-B4CE-F35691EFD9D9")]
    public unsafe struct ID2D1SvgStrokeDashArray
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ID2D1SvgStrokeDashArray* This, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ID2D1SvgStrokeDashArray* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ID2D1SvgStrokeDashArray* This);

        /// <summary>Retrieve the factory associated with this resource.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetFactory(ID2D1SvgStrokeDashArray* This, ID2D1Factory** factory);

        /// <summary>Returns the element on which this attribute is set. Returns null if the attribute is not set on any element.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetElement(ID2D1SvgStrokeDashArray* This, ID2D1SvgElement** element);

        /// <summary>Creates a clone of this attribute value. On creation, the cloned attribute is not set on any element.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Clone(ID2D1SvgStrokeDashArray* This, ID2D1SvgAttribute** attribute);

        /// <summary>Removes dashes from the end of the array.</summary>
        /// <param name="dashesCount">Specifies how many dashes to remove.</param>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _RemoveDashesAtEnd(ID2D1SvgStrokeDashArray* This, [NativeTypeName("UINT32")] uint dashesCount);

        /// <summary>Updates the array. Existing dashes not updated by this method are preserved. The array is resized larger if necessary to accomodate the new dashes.</summary>
        /// <param name="dashes">The dashes array.</param>
        /// <param name="dashesCount">The number of dashes to update.</param>
        /// <param name="startIndex">The index at which to begin updating dashes. Must be less than or equal to the size of the array.</param>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _UpdateDashes(ID2D1SvgStrokeDashArray* This, [NativeTypeName("FLOAT[]")] float* dashes, [NativeTypeName("UINT32")] uint dashesCount, [NativeTypeName("UINT32")] uint startIndex = 0);

        /// <summary>Updates the array. Existing dashes not updated by this method are preserved. The array is resized larger if necessary to accomodate the new dashes.</summary>
        /// <param name="dashes">The dashes array.</param>
        /// <param name="dashesCount">The number of dashes to update.</param>
        /// <param name="startIndex">The index at which to begin updating dashes. Must be less than or equal to the size of the array.</param>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _UpdateDashes1(ID2D1SvgStrokeDashArray* This, [NativeTypeName("D2D1_SVG_LENGTH[]")] D2D1_SVG_LENGTH* dashes, [NativeTypeName("UINT32")] uint dashesCount, [NativeTypeName("UINT32")] uint startIndex = 0);

        /// <summary>Gets dashes from the array.</summary>
        /// <param name="dashes">Buffer to contain the dashes.</param>
        /// <param name="dashesCount">The element count of buffer.</param>
        /// <param name="startIndex">The index of the first dash to retrieve.</param>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetDashes(ID2D1SvgStrokeDashArray* This, [NativeTypeName("FLOAT[]")] float* dashes, [NativeTypeName("UINT32")] uint dashesCount, [NativeTypeName("UINT32")] uint startIndex = 0);

        /// <summary>Gets dashes from the array.</summary>
        /// <param name="dashes">Buffer to contain the dashes.</param>
        /// <param name="dashesCount">The element count of buffer.</param>
        /// <param name="startIndex">The index of the first dash to retrieve.</param>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetDashes1(ID2D1SvgStrokeDashArray* This, [NativeTypeName("D2D1_SVG_LENGTH[]")] D2D1_SVG_LENGTH* dashes, [NativeTypeName("UINT32")] uint dashesCount, [NativeTypeName("UINT32")] uint startIndex = 0);

        /// <summary>Gets the number of the dashes in the array.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("UINT32")]
        public delegate uint _GetDashesCount(ID2D1SvgStrokeDashArray* This);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
        {
            fixed (ID2D1SvgStrokeDashArray* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(This, riid, ppvObject);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (ID2D1SvgStrokeDashArray* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(This);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (ID2D1SvgStrokeDashArray* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(This);
            }
        }

        public void GetFactory(ID2D1Factory** factory)
        {
            fixed (ID2D1SvgStrokeDashArray* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_GetFactory>(lpVtbl->GetFactory)(This, factory);
            }
        }

        public void GetElement(ID2D1SvgElement** element)
        {
            fixed (ID2D1SvgStrokeDashArray* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_GetElement>(lpVtbl->GetElement)(This, element);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int Clone(ID2D1SvgAttribute** attribute)
        {
            fixed (ID2D1SvgStrokeDashArray* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Clone>(lpVtbl->Clone)(This, attribute);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int RemoveDashesAtEnd([NativeTypeName("UINT32")] uint dashesCount)
        {
            fixed (ID2D1SvgStrokeDashArray* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_RemoveDashesAtEnd>(lpVtbl->RemoveDashesAtEnd)(This, dashesCount);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int UpdateDashes([NativeTypeName("FLOAT[]")] float* dashes, [NativeTypeName("UINT32")] uint dashesCount, [NativeTypeName("UINT32")] uint startIndex = 0)
        {
            fixed (ID2D1SvgStrokeDashArray* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_UpdateDashes>(lpVtbl->UpdateDashes)(This, dashes, dashesCount, startIndex);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int UpdateDashes1([NativeTypeName("D2D1_SVG_LENGTH[]")] D2D1_SVG_LENGTH* dashes, [NativeTypeName("UINT32")] uint dashesCount, [NativeTypeName("UINT32")] uint startIndex = 0)
        {
            fixed (ID2D1SvgStrokeDashArray* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_UpdateDashes1>(lpVtbl->UpdateDashes1)(This, dashes, dashesCount, startIndex);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDashes([NativeTypeName("FLOAT[]")] float* dashes, [NativeTypeName("UINT32")] uint dashesCount, [NativeTypeName("UINT32")] uint startIndex = 0)
        {
            fixed (ID2D1SvgStrokeDashArray* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetDashes>(lpVtbl->GetDashes)(This, dashes, dashesCount, startIndex);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDashes1([NativeTypeName("D2D1_SVG_LENGTH[]")] D2D1_SVG_LENGTH* dashes, [NativeTypeName("UINT32")] uint dashesCount, [NativeTypeName("UINT32")] uint startIndex = 0)
        {
            fixed (ID2D1SvgStrokeDashArray* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetDashes1>(lpVtbl->GetDashes1)(This, dashes, dashesCount, startIndex);
            }
        }

        [return: NativeTypeName("UINT32")]
        public uint GetDashesCount()
        {
            fixed (ID2D1SvgStrokeDashArray* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetDashesCount>(lpVtbl->GetDashesCount)(This);
            }
        }

        public struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr GetFactory;

            public IntPtr GetElement;

            public IntPtr Clone;

            public IntPtr RemoveDashesAtEnd;

            public IntPtr UpdateDashes;

            public IntPtr UpdateDashes1;

            public IntPtr GetDashes;

            public IntPtr GetDashes1;

            public IntPtr GetDashesCount;
        }
    }
}
