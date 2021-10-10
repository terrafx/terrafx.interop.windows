// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/devicetopology.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("C99AF463-D629-4EC4-8C00-E54D68154248")]
    [NativeTypeName("struct IKsJackContainerId : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IKsJackContainerId
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IKsJackContainerId*, Guid*, void**, int>)(lpVtbl[0]))((IKsJackContainerId*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IKsJackContainerId*, uint>)(lpVtbl[1]))((IKsJackContainerId*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IKsJackContainerId*, uint>)(lpVtbl[2]))((IKsJackContainerId*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetJackContainerId([NativeTypeName("GUID *")] Guid* pJackContainerId)
        {
            return ((delegate* unmanaged<IKsJackContainerId*, Guid*, int>)(lpVtbl[3]))((IKsJackContainerId*)Unsafe.AsPointer(ref this), pJackContainerId);
        }
    }
}
