// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/roparameterizediid.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop
{
    public unsafe partial struct IRoMetaDataLocator
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT Locate([NativeTypeName("PCWSTR")] ushort* nameElement, [NativeTypeName("IRoSimpleMetaDataBuilder &")] IRoSimpleMetaDataBuilder* metaDataDestination)
        {
            return ((delegate* unmanaged<IRoMetaDataLocator*, ushort*, IRoSimpleMetaDataBuilder*, int>)(lpVtbl[0]))((IRoMetaDataLocator*)Unsafe.AsPointer(ref this), nameElement, metaDataDestination);
        }
    }
}
