// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1_3.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Security;

namespace TerraFX.Interop
{
    /// <summary>Represents a device-dependent representation of a gradient mesh composed of patches. Use the ID2D1DeviceContext2::CreateGradientMesh method to create an instance of ID2D1GradientMesh.</summary>
    [Guid("F292E401-C050-4CDE-83D7-04962D3B23C2")]
    public unsafe struct ID2D1GradientMesh
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _QueryInterface(
            [In] ID2D1GradientMesh* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _AddRef(
            [In] ID2D1GradientMesh* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _Release(
            [In] ID2D1GradientMesh* This
        );

        /// <summary>Retrieve the factory associated with this resource.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _GetFactory(
            [In] ID2D1GradientMesh* This,
            [Out] ID2D1Factory** factory
        );

        /// <summary>Returns the number of patches of the gradient mesh.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("UINT32")]
        public /* static */ delegate uint _GetPatchCount(
            [In] ID2D1GradientMesh* This
        );

        /// <summary>Retrieve the patch data stored in the gradient mesh.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetPatches(
            [In] ID2D1GradientMesh* This,
            [In, NativeTypeName("UINT32")] uint startIndex,
            [Out, NativeTypeName("D2D1_GRADIENT_MESH_PATCH[]")] D2D1_GRADIENT_MESH_PATCH* patches,
            [In, NativeTypeName("UINT32")] uint patchesCount
        );

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (ID2D1GradientMesh* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(
                    This,
                    riid,
                    ppvObject
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (ID2D1GradientMesh* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (ID2D1GradientMesh* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(
                    This
                );
            }
        }

        public void GetFactory(
            [Out] ID2D1Factory** factory
        )
        {
            fixed (ID2D1GradientMesh* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_GetFactory>(lpVtbl->GetFactory)(
                    This,
                    factory
                );
            }
        }

        [return: NativeTypeName("UINT32")]
        public uint GetPatchCount()
        {
            fixed (ID2D1GradientMesh* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetPatchCount>(lpVtbl->GetPatchCount)(
                    This
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPatches(
            [In, NativeTypeName("UINT32")] uint startIndex,
            [Out, NativeTypeName("D2D1_GRADIENT_MESH_PATCH[]")] D2D1_GRADIENT_MESH_PATCH* patches,
            [In, NativeTypeName("UINT32")] uint patchesCount
        )
        {
            fixed (ID2D1GradientMesh* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetPatches>(lpVtbl->GetPatches)(
                    This,
                    startIndex,
                    patches,
                    patchesCount
                );
            }
        }

        public struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr GetFactory;

            public IntPtr GetPatchCount;

            public IntPtr GetPatches;
        }
    }
}
