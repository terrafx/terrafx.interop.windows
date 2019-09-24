// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1effectauthor.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    /// <summary>This is the interface implemented by an effect author, along with the constructor and registration information.</summary>
    [Guid("A248FD3F-3E6C-4E63-9F03-7F68ECC91DB9")]
    public unsafe struct ID2D1EffectImpl
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(
            [In] ID2D1EffectImpl* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(
            [In] ID2D1EffectImpl* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(
            [In] ID2D1EffectImpl* This
        );

        /// <summary>Initialize the effect with a context and a transform graph. The effect must populate the transform graph with a topology and can update it later.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Initialize(
            [In] ID2D1EffectImpl* This,
            [In] ID2D1EffectContext* effectContext,
            [In] ID2D1TransformGraph* transformGraph
        );

        /// <summary>Initialize the effect with a context and a transform graph. The effect must populate the transform graph with a topology and can update it later.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _PrepareForRender(
            [In] ID2D1EffectImpl* This,
            [In] D2D1_CHANGE_TYPE changeType
        );

        /// <summary>Sets a new transform graph to the effect.  This happens when the number of inputs to the effect changes, if the effect support a variable number of inputs.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetGraph(
            [In] ID2D1EffectImpl* This,
            [In] ID2D1TransformGraph* transformGraph
        );

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (ID2D1EffectImpl* This = &this)
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
            fixed (ID2D1EffectImpl* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (ID2D1EffectImpl* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(
                    This
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int Initialize(
            [In] ID2D1EffectContext* effectContext,
            [In] ID2D1TransformGraph* transformGraph
        )
        {
            fixed (ID2D1EffectImpl* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Initialize>(lpVtbl->Initialize)(
                    This,
                    effectContext,
                    transformGraph
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int PrepareForRender(
            [In] D2D1_CHANGE_TYPE changeType
        )
        {
            fixed (ID2D1EffectImpl* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_PrepareForRender>(lpVtbl->PrepareForRender)(
                    This,
                    changeType
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetGraph(
            [In] ID2D1TransformGraph* transformGraph
        )
        {
            fixed (ID2D1EffectImpl* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetGraph>(lpVtbl->SetGraph)(
                    This,
                    transformGraph
                );
            }
        }

        public struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr Initialize;

            public IntPtr PrepareForRender;

            public IntPtr SetGraph;
        }
    }
}
