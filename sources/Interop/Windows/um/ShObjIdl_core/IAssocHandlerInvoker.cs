// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("92218CAB-ECAA-4335-8133-807FD234C2EE")]
    [NativeTypeName("struct IAssocHandlerInvoker : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IAssocHandlerInvoker
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAssocHandlerInvoker*, Guid*, void**, int>)(lpVtbl[0]))((IAssocHandlerInvoker*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAssocHandlerInvoker*, uint>)(lpVtbl[1]))((IAssocHandlerInvoker*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAssocHandlerInvoker*, uint>)(lpVtbl[2]))((IAssocHandlerInvoker*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int SupportsSelection()
        {
            return ((delegate* unmanaged<IAssocHandlerInvoker*, int>)(lpVtbl[3]))((IAssocHandlerInvoker*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke()
        {
            return ((delegate* unmanaged<IAssocHandlerInvoker*, int>)(lpVtbl[4]))((IAssocHandlerInvoker*)Unsafe.AsPointer(ref this));
        }
    }
}
