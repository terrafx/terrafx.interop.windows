// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/UIAnimation.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("2D3B15A4-4762-47AB-A030-B23221DF3AE0")]
    [NativeTypeName("struct IUIAnimationLoopIterationChangeHandler2 : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IUIAnimationLoopIterationChangeHandler2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IUIAnimationLoopIterationChangeHandler2*, Guid*, void**, int>)(lpVtbl[0]))((IUIAnimationLoopIterationChangeHandler2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IUIAnimationLoopIterationChangeHandler2*, uint>)(lpVtbl[1]))((IUIAnimationLoopIterationChangeHandler2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IUIAnimationLoopIterationChangeHandler2*, uint>)(lpVtbl[2]))((IUIAnimationLoopIterationChangeHandler2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT OnLoopIterationChanged(IUIAnimationStoryboard2* storyboard, [NativeTypeName("UINT_PTR")] nuint id, [NativeTypeName("UINT32")] uint newIterationCount, [NativeTypeName("UINT32")] uint oldIterationCount)
        {
            return ((delegate* unmanaged<IUIAnimationLoopIterationChangeHandler2*, IUIAnimationStoryboard2*, nuint, uint, uint, int>)(lpVtbl[3]))((IUIAnimationLoopIterationChangeHandler2*)Unsafe.AsPointer(ref this), storyboard, id, newIterationCount, oldIterationCount);
        }
    }
}
