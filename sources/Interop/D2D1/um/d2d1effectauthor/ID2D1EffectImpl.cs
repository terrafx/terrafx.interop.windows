// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1effectauthor.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    /// <summary>This is the interface implemented by an effect author, along with the constructor and registration information.</summary>
    [Guid("A248FD3F-3E6C-4E63-9F03-7F68ECC91DB9")]
    public unsafe partial struct ID2D1EffectImpl
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ID2D1EffectImpl* This, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ID2D1EffectImpl* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ID2D1EffectImpl* This);

        /// <summary>Initialize the effect with a context and a transform graph. The effect must populate the transform graph with a topology and can update it later.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Initialize(ID2D1EffectImpl* This, ID2D1EffectContext* effectContext, ID2D1TransformGraph* transformGraph);

        /// <summary>Initialize the effect with a context and a transform graph. The effect must populate the transform graph with a topology and can update it later.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _PrepareForRender(ID2D1EffectImpl* This, D2D1_CHANGE_TYPE changeType);

        /// <summary>Sets a new transform graph to the effect.  This happens when the number of inputs to the effect changes, if the effect support a variable number of inputs.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetGraph(ID2D1EffectImpl* This, ID2D1TransformGraph* transformGraph);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
        {
            fixed (ID2D1EffectImpl* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(This, riid, ppvObject);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (ID2D1EffectImpl* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(This);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (ID2D1EffectImpl* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int Initialize(ID2D1EffectContext* effectContext, ID2D1TransformGraph* transformGraph)
        {
            fixed (ID2D1EffectImpl* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Initialize>(lpVtbl->Initialize)(This, effectContext, transformGraph);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int PrepareForRender(D2D1_CHANGE_TYPE changeType)
        {
            fixed (ID2D1EffectImpl* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_PrepareForRender>(lpVtbl->PrepareForRender)(This, changeType);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetGraph(ID2D1TransformGraph* transformGraph)
        {
            fixed (ID2D1EffectImpl* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetGraph>(lpVtbl->SetGraph)(This, transformGraph);
            }
        }

        public partial struct Vtbl
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
