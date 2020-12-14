// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1effectauthor.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("13D29038-C3E6-4034-9081-13B53A417992")]
    [NativeTypeName("struct ID2D1TransformGraph : IUnknown")]
    public unsafe partial struct ID2D1TransformGraph
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<ID2D1TransformGraph*, Guid*, void**, int>)(lpVtbl[0]))((ID2D1TransformGraph*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID2D1TransformGraph*, uint>)(lpVtbl[1]))((ID2D1TransformGraph*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ID2D1TransformGraph*, uint>)(lpVtbl[2]))((ID2D1TransformGraph*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("UINT32")]
        public uint GetInputCount()
        {
            return ((delegate* unmanaged<ID2D1TransformGraph*, uint>)(lpVtbl[3]))((ID2D1TransformGraph*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetSingleTransformNode([NativeTypeName("ID2D1TransformNode *")] ID2D1TransformNode* node)
        {
            return ((delegate* unmanaged<ID2D1TransformGraph*, ID2D1TransformNode*, int>)(lpVtbl[4]))((ID2D1TransformGraph*)Unsafe.AsPointer(ref this), node);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AddNode([NativeTypeName("ID2D1TransformNode *")] ID2D1TransformNode* node)
        {
            return ((delegate* unmanaged<ID2D1TransformGraph*, ID2D1TransformNode*, int>)(lpVtbl[5]))((ID2D1TransformGraph*)Unsafe.AsPointer(ref this), node);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RemoveNode([NativeTypeName("ID2D1TransformNode *")] ID2D1TransformNode* node)
        {
            return ((delegate* unmanaged<ID2D1TransformGraph*, ID2D1TransformNode*, int>)(lpVtbl[6]))((ID2D1TransformGraph*)Unsafe.AsPointer(ref this), node);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetOutputNode([NativeTypeName("ID2D1TransformNode *")] ID2D1TransformNode* node)
        {
            return ((delegate* unmanaged<ID2D1TransformGraph*, ID2D1TransformNode*, int>)(lpVtbl[7]))((ID2D1TransformGraph*)Unsafe.AsPointer(ref this), node);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ConnectNode([NativeTypeName("ID2D1TransformNode *")] ID2D1TransformNode* fromNode, [NativeTypeName("ID2D1TransformNode *")] ID2D1TransformNode* toNode, [NativeTypeName("UINT32")] uint toNodeInputIndex)
        {
            return ((delegate* unmanaged<ID2D1TransformGraph*, ID2D1TransformNode*, ID2D1TransformNode*, uint, int>)(lpVtbl[8]))((ID2D1TransformGraph*)Unsafe.AsPointer(ref this), fromNode, toNode, toNodeInputIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ConnectToEffectInput([NativeTypeName("UINT32")] uint toEffectInputIndex, [NativeTypeName("ID2D1TransformNode *")] ID2D1TransformNode* node, [NativeTypeName("UINT32")] uint toNodeInputIndex)
        {
            return ((delegate* unmanaged<ID2D1TransformGraph*, uint, ID2D1TransformNode*, uint, int>)(lpVtbl[9]))((ID2D1TransformGraph*)Unsafe.AsPointer(ref this), toEffectInputIndex, node, toNodeInputIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Clear()
        {
            ((delegate* unmanaged<ID2D1TransformGraph*, void>)(lpVtbl[10]))((ID2D1TransformGraph*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetPassthroughGraph([NativeTypeName("UINT32")] uint effectInputIndex)
        {
            return ((delegate* unmanaged<ID2D1TransformGraph*, uint, int>)(lpVtbl[11]))((ID2D1TransformGraph*)Unsafe.AsPointer(ref this), effectInputIndex);
        }
    }
}
