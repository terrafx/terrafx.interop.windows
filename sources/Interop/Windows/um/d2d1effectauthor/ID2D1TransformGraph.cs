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

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((ID2D1TransformGraph*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((ID2D1TransformGraph*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((ID2D1TransformGraph*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("UINT32")]
        public uint GetInputCount()
        {
            return lpVtbl->GetInputCount((ID2D1TransformGraph*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetSingleTransformNode([NativeTypeName("ID2D1TransformNode *")] ID2D1TransformNode* node)
        {
            return lpVtbl->SetSingleTransformNode((ID2D1TransformGraph*)Unsafe.AsPointer(ref this), node);
        }

        [return: NativeTypeName("HRESULT")]
        public int AddNode([NativeTypeName("ID2D1TransformNode *")] ID2D1TransformNode* node)
        {
            return lpVtbl->AddNode((ID2D1TransformGraph*)Unsafe.AsPointer(ref this), node);
        }

        [return: NativeTypeName("HRESULT")]
        public int RemoveNode([NativeTypeName("ID2D1TransformNode *")] ID2D1TransformNode* node)
        {
            return lpVtbl->RemoveNode((ID2D1TransformGraph*)Unsafe.AsPointer(ref this), node);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetOutputNode([NativeTypeName("ID2D1TransformNode *")] ID2D1TransformNode* node)
        {
            return lpVtbl->SetOutputNode((ID2D1TransformGraph*)Unsafe.AsPointer(ref this), node);
        }

        [return: NativeTypeName("HRESULT")]
        public int ConnectNode([NativeTypeName("ID2D1TransformNode *")] ID2D1TransformNode* fromNode, [NativeTypeName("ID2D1TransformNode *")] ID2D1TransformNode* toNode, [NativeTypeName("UINT32")] uint toNodeInputIndex)
        {
            return lpVtbl->ConnectNode((ID2D1TransformGraph*)Unsafe.AsPointer(ref this), fromNode, toNode, toNodeInputIndex);
        }

        [return: NativeTypeName("HRESULT")]
        public int ConnectToEffectInput([NativeTypeName("UINT32")] uint toEffectInputIndex, [NativeTypeName("ID2D1TransformNode *")] ID2D1TransformNode* node, [NativeTypeName("UINT32")] uint toNodeInputIndex)
        {
            return lpVtbl->ConnectToEffectInput((ID2D1TransformGraph*)Unsafe.AsPointer(ref this), toEffectInputIndex, node, toNodeInputIndex);
        }

        public void Clear()
        {
            lpVtbl->Clear((ID2D1TransformGraph*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPassthroughGraph([NativeTypeName("UINT32")] uint effectInputIndex)
        {
            return lpVtbl->SetPassthroughGraph((ID2D1TransformGraph*)Unsafe.AsPointer(ref this), effectInputIndex);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1TransformGraph*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1TransformGraph*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1TransformGraph*, uint> Release;

            [NativeTypeName("UINT32 () const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1TransformGraph*, uint> GetInputCount;

            [NativeTypeName("HRESULT (ID2D1TransformNode *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1TransformGraph*, ID2D1TransformNode*, int> SetSingleTransformNode;

            [NativeTypeName("HRESULT (ID2D1TransformNode *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1TransformGraph*, ID2D1TransformNode*, int> AddNode;

            [NativeTypeName("HRESULT (ID2D1TransformNode *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1TransformGraph*, ID2D1TransformNode*, int> RemoveNode;

            [NativeTypeName("HRESULT (ID2D1TransformNode *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1TransformGraph*, ID2D1TransformNode*, int> SetOutputNode;

            [NativeTypeName("HRESULT (ID2D1TransformNode *, ID2D1TransformNode *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1TransformGraph*, ID2D1TransformNode*, ID2D1TransformNode*, uint, int> ConnectNode;

            [NativeTypeName("HRESULT (UINT32, ID2D1TransformNode *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1TransformGraph*, uint, ID2D1TransformNode*, uint, int> ConnectToEffectInput;

            [NativeTypeName("void () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1TransformGraph*, void> Clear;

            [NativeTypeName("HRESULT (UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1TransformGraph*, uint, int> SetPassthroughGraph;
        }
    }
}
