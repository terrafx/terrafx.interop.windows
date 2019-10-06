// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    /// <summary>Paints an area with a radial gradient.</summary>
    [Guid("2CD906AC-12E2-11DC-9FED-001143A055F9")]
    public unsafe partial struct ID2D1RadialGradientBrush
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ID2D1RadialGradientBrush* This, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ID2D1RadialGradientBrush* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ID2D1RadialGradientBrush* This);

        /// <summary>Retrieve the factory associated with this resource.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetFactory(ID2D1RadialGradientBrush* This, ID2D1Factory** factory);

        /// <summary>Sets the opacity for when the brush is drawn over the entire fill of the brush.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SetOpacity(ID2D1RadialGradientBrush* This, [NativeTypeName("FLOAT")] float opacity);

        /// <summary>Sets the transform that applies to everything drawn by the brush.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SetTransform(ID2D1RadialGradientBrush* This, [NativeTypeName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F* transform);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("FLOAT")]
        public delegate float _GetOpacity(ID2D1RadialGradientBrush* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetTransform(ID2D1RadialGradientBrush* This, [NativeTypeName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F* transform);

        /// <summary>Sets the center of the radial gradient. This will be in local coordinates and will not depend on the geometry being filled.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SetCenter(ID2D1RadialGradientBrush* This, [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F center);

        /// <summary>Sets offset of the origin relative to the radial gradient center.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SetGradientOriginOffset(ID2D1RadialGradientBrush* This, [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F gradientOriginOffset);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SetRadiusX(ID2D1RadialGradientBrush* This, [NativeTypeName("FLOAT")] float radiusX);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SetRadiusY(ID2D1RadialGradientBrush* This, [NativeTypeName("FLOAT")] float radiusY);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("D2D1_POINT_2F")]
        public delegate D2D_POINT_2F* _GetCenter(ID2D1RadialGradientBrush* This, D2D_POINT_2F* _result);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("D2D1_POINT_2F")]
        public delegate D2D_POINT_2F* _GetGradientOriginOffset(ID2D1RadialGradientBrush* This, D2D_POINT_2F* _result);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("FLOAT")]
        public delegate float _GetRadiusX(ID2D1RadialGradientBrush* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("FLOAT")]
        public delegate float _GetRadiusY(ID2D1RadialGradientBrush* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetGradientStopCollection(ID2D1RadialGradientBrush* This, ID2D1GradientStopCollection** gradientStopCollection);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
        {
            fixed (ID2D1RadialGradientBrush* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(This, riid, ppvObject);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (ID2D1RadialGradientBrush* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(This);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (ID2D1RadialGradientBrush* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(This);
            }
        }

        public void GetFactory(ID2D1Factory** factory)
        {
            fixed (ID2D1RadialGradientBrush* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_GetFactory>(lpVtbl->GetFactory)(This, factory);
            }
        }

        public void SetOpacity([NativeTypeName("FLOAT")] float opacity)
        {
            fixed (ID2D1RadialGradientBrush* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_SetOpacity>(lpVtbl->SetOpacity)(This, opacity);
            }
        }

        public void SetTransform([NativeTypeName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F* transform)
        {
            fixed (ID2D1RadialGradientBrush* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_SetTransform>(lpVtbl->SetTransform)(This, transform);
            }
        }

        [return: NativeTypeName("FLOAT")]
        public float GetOpacity()
        {
            fixed (ID2D1RadialGradientBrush* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetOpacity>(lpVtbl->GetOpacity)(This);
            }
        }

        public void GetTransform([NativeTypeName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F* transform)
        {
            fixed (ID2D1RadialGradientBrush* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_GetTransform>(lpVtbl->GetTransform)(This, transform);
            }
        }

        public void SetCenter([NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F center)
        {
            fixed (ID2D1RadialGradientBrush* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_SetCenter>(lpVtbl->SetCenter)(This, center);
            }
        }

        public void SetGradientOriginOffset([NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F gradientOriginOffset)
        {
            fixed (ID2D1RadialGradientBrush* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_SetGradientOriginOffset>(lpVtbl->SetGradientOriginOffset)(This, gradientOriginOffset);
            }
        }

        public void SetRadiusX([NativeTypeName("FLOAT")] float radiusX)
        {
            fixed (ID2D1RadialGradientBrush* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_SetRadiusX>(lpVtbl->SetRadiusX)(This, radiusX);
            }
        }

        public void SetRadiusY([NativeTypeName("FLOAT")] float radiusY)
        {
            fixed (ID2D1RadialGradientBrush* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_SetRadiusY>(lpVtbl->SetRadiusY)(This, radiusY);
            }
        }

        [return: NativeTypeName("D2D1_POINT_2F")]
        public D2D_POINT_2F GetCenter()
        {
            fixed (ID2D1RadialGradientBrush* This = &this)
            {
                D2D_POINT_2F result;
                return *Marshal.GetDelegateForFunctionPointer<_GetCenter>(lpVtbl->GetCenter)(This, &result);
            }
        }

        [return: NativeTypeName("D2D1_POINT_2F")]
        public D2D_POINT_2F GetGradientOriginOffset()
        {
            fixed (ID2D1RadialGradientBrush* This = &this)
            {
                D2D_POINT_2F result;
                return *Marshal.GetDelegateForFunctionPointer<_GetGradientOriginOffset>(lpVtbl->GetGradientOriginOffset)(This, &result);
            }
        }

        [return: NativeTypeName("FLOAT")]
        public float GetRadiusX()
        {
            fixed (ID2D1RadialGradientBrush* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetRadiusX>(lpVtbl->GetRadiusX)(This);
            }
        }

        [return: NativeTypeName("FLOAT")]
        public float GetRadiusY()
        {
            fixed (ID2D1RadialGradientBrush* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetRadiusY>(lpVtbl->GetRadiusY)(This);
            }
        }

        public void GetGradientStopCollection(ID2D1GradientStopCollection** gradientStopCollection)
        {
            fixed (ID2D1RadialGradientBrush* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_GetGradientStopCollection>(lpVtbl->GetGradientStopCollection)(This, gradientStopCollection);
            }
        }

        public partial struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr GetFactory;

            public IntPtr SetOpacity;

            public IntPtr SetTransform;

            public IntPtr GetOpacity;

            public IntPtr GetTransform;

            public IntPtr SetCenter;

            public IntPtr SetGradientOriginOffset;

            public IntPtr SetRadiusX;

            public IntPtr SetRadiusY;

            public IntPtr GetCenter;

            public IntPtr GetGradientOriginOffset;

            public IntPtr GetRadiusX;

            public IntPtr GetRadiusY;

            public IntPtr GetGradientStopCollection;
        }
    }
}
