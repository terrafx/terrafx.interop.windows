// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/control.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("56A868B7-0AD4-11CE-B03A-0020AF0BA770")]
    [NativeTypeName("struct IQueueCommand : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IQueueCommand
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IQueueCommand*, Guid*, void**, int>)(lpVtbl[0]))((IQueueCommand*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IQueueCommand*, uint>)(lpVtbl[1]))((IQueueCommand*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IQueueCommand*, uint>)(lpVtbl[2]))((IQueueCommand*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int InvokeAtStreamTime(IDeferredCommand** pCmd, [NativeTypeName("REFTIME")] double time, [NativeTypeName("GUID *")] Guid* iid, [NativeTypeName("long")] int dispidMethod, short wFlags, [NativeTypeName("long")] int cArgs, VARIANT* pDispParams, VARIANT* pvarResult, short* puArgErr)
        {
            return ((delegate* unmanaged<IQueueCommand*, IDeferredCommand**, double, Guid*, int, short, int, VARIANT*, VARIANT*, short*, int>)(lpVtbl[3]))((IQueueCommand*)Unsafe.AsPointer(ref this), pCmd, time, iid, dispidMethod, wFlags, cArgs, pDispParams, pvarResult, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int InvokeAtPresentationTime(IDeferredCommand** pCmd, [NativeTypeName("REFTIME")] double time, [NativeTypeName("GUID *")] Guid* iid, [NativeTypeName("long")] int dispidMethod, short wFlags, [NativeTypeName("long")] int cArgs, VARIANT* pDispParams, VARIANT* pvarResult, short* puArgErr)
        {
            return ((delegate* unmanaged<IQueueCommand*, IDeferredCommand**, double, Guid*, int, short, int, VARIANT*, VARIANT*, short*, int>)(lpVtbl[4]))((IQueueCommand*)Unsafe.AsPointer(ref this), pCmd, time, iid, dispidMethod, wFlags, cArgs, pDispParams, pvarResult, puArgErr);
        }
    }
}
