// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/devicetopology.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("45D37C3F-5140-444A-AE24-400789F3CBF3")]
    [NativeTypeName("struct IControlInterface : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IControlInterface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IControlInterface*, Guid*, void**, int>)(lpVtbl[0]))((IControlInterface*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IControlInterface*, uint>)(lpVtbl[1]))((IControlInterface*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IControlInterface*, uint>)(lpVtbl[2]))((IControlInterface*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetName([NativeTypeName("LPWSTR *")] ushort** ppwstrName)
        {
            return ((delegate* unmanaged<IControlInterface*, ushort**, int>)(lpVtbl[3]))((IControlInterface*)Unsafe.AsPointer(ref this), ppwstrName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetIID([NativeTypeName("GUID *")] Guid* pIID)
        {
            return ((delegate* unmanaged<IControlInterface*, Guid*, int>)(lpVtbl[4]))((IControlInterface*)Unsafe.AsPointer(ref this), pIID);
        }
    }
}
