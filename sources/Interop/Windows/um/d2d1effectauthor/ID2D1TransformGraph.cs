// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1effectauthor.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("13D29038-C3E6-4034-9081-13B53A417992")]
    public unsafe partial struct ID2D1TransformGraph
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ID2D1TransformGraph* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ID2D1TransformGraph* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ID2D1TransformGraph* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("UINT32")]
        public delegate uint _GetInputCount(ID2D1TransformGraph* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetSingleTransformNode(ID2D1TransformGraph* pThis, [NativeTypeName("ID2D1TransformNode *")] ID2D1TransformNode* node);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _AddNode(ID2D1TransformGraph* pThis, [NativeTypeName("ID2D1TransformNode *")] ID2D1TransformNode* node);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _RemoveNode(ID2D1TransformGraph* pThis, [NativeTypeName("ID2D1TransformNode *")] ID2D1TransformNode* node);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetOutputNode(ID2D1TransformGraph* pThis, [NativeTypeName("ID2D1TransformNode *")] ID2D1TransformNode* node);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _ConnectNode(ID2D1TransformGraph* pThis, [NativeTypeName("ID2D1TransformNode *")] ID2D1TransformNode* fromNode, [NativeTypeName("ID2D1TransformNode *")] ID2D1TransformNode* toNode, [NativeTypeName("UINT32")] uint toNodeInputIndex);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _ConnectToEffectInput(ID2D1TransformGraph* pThis, [NativeTypeName("UINT32")] uint toEffectInputIndex, [NativeTypeName("ID2D1TransformNode *")] ID2D1TransformNode* node, [NativeTypeName("UINT32")] uint toNodeInputIndex);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _Clear(ID2D1TransformGraph* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetPassthroughGraph(ID2D1TransformGraph* pThis, [NativeTypeName("UINT32")] uint effectInputIndex);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((ID2D1TransformGraph*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((ID2D1TransformGraph*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((ID2D1TransformGraph*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("UINT32")]
        public uint GetInputCount()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetInputCount>(lpVtbl->GetInputCount)((ID2D1TransformGraph*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetSingleTransformNode([NativeTypeName("ID2D1TransformNode *")] ID2D1TransformNode* node)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetSingleTransformNode>(lpVtbl->SetSingleTransformNode)((ID2D1TransformGraph*)Unsafe.AsPointer(ref this), node);
        }

        [return: NativeTypeName("HRESULT")]
        public int AddNode([NativeTypeName("ID2D1TransformNode *")] ID2D1TransformNode* node)
        {
            return Marshal.GetDelegateForFunctionPointer<_AddNode>(lpVtbl->AddNode)((ID2D1TransformGraph*)Unsafe.AsPointer(ref this), node);
        }

        [return: NativeTypeName("HRESULT")]
        public int RemoveNode([NativeTypeName("ID2D1TransformNode *")] ID2D1TransformNode* node)
        {
            return Marshal.GetDelegateForFunctionPointer<_RemoveNode>(lpVtbl->RemoveNode)((ID2D1TransformGraph*)Unsafe.AsPointer(ref this), node);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetOutputNode([NativeTypeName("ID2D1TransformNode *")] ID2D1TransformNode* node)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetOutputNode>(lpVtbl->SetOutputNode)((ID2D1TransformGraph*)Unsafe.AsPointer(ref this), node);
        }

        [return: NativeTypeName("HRESULT")]
        public int ConnectNode([NativeTypeName("ID2D1TransformNode *")] ID2D1TransformNode* fromNode, [NativeTypeName("ID2D1TransformNode *")] ID2D1TransformNode* toNode, [NativeTypeName("UINT32")] uint toNodeInputIndex)
        {
            return Marshal.GetDelegateForFunctionPointer<_ConnectNode>(lpVtbl->ConnectNode)((ID2D1TransformGraph*)Unsafe.AsPointer(ref this), fromNode, toNode, toNodeInputIndex);
        }

        [return: NativeTypeName("HRESULT")]
        public int ConnectToEffectInput([NativeTypeName("UINT32")] uint toEffectInputIndex, [NativeTypeName("ID2D1TransformNode *")] ID2D1TransformNode* node, [NativeTypeName("UINT32")] uint toNodeInputIndex)
        {
            return Marshal.GetDelegateForFunctionPointer<_ConnectToEffectInput>(lpVtbl->ConnectToEffectInput)((ID2D1TransformGraph*)Unsafe.AsPointer(ref this), toEffectInputIndex, node, toNodeInputIndex);
        }

        public void Clear()
        {
            Marshal.GetDelegateForFunctionPointer<_Clear>(lpVtbl->Clear)((ID2D1TransformGraph*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPassthroughGraph([NativeTypeName("UINT32")] uint effectInputIndex)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetPassthroughGraph>(lpVtbl->SetPassthroughGraph)((ID2D1TransformGraph*)Unsafe.AsPointer(ref this), effectInputIndex);
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
            public IntPtr GetInputCount;

            [NativeTypeName("HRESULT (ID2D1TransformNode *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetSingleTransformNode;

            [NativeTypeName("HRESULT (ID2D1TransformNode *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr AddNode;

            [NativeTypeName("HRESULT (ID2D1TransformNode *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr RemoveNode;

            [NativeTypeName("HRESULT (ID2D1TransformNode *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetOutputNode;

            [NativeTypeName("HRESULT (ID2D1TransformNode *, ID2D1TransformNode *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr ConnectNode;

            [NativeTypeName("HRESULT (UINT32, ID2D1TransformNode *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr ConnectToEffectInput;

            [NativeTypeName("void () __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr Clear;

            [NativeTypeName("HRESULT (UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetPassthroughGraph;
        }
    }
}
