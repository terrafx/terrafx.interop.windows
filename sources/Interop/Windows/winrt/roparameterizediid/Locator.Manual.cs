// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/roparameterizediid.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace TerraFX.Interop
{
    public unsafe struct _Locator
    {
        void** lpVtbl;
        delegate*<ushort*, IRoSimpleMetaDataBuilder*, int> _fn;

        public _Locator(delegate*<ushort*, IRoSimpleMetaDataBuilder*, int> fn)
        {
            lpVtbl = computedVtbl;
            _fn = fn;
        }

        static void** computedVtbl;
        static _Locator()
        {
            computedVtbl = (void**) RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(_Locator), sizeof(void*) * 1);
            computedVtbl[0] = (delegate* unmanaged<_Locator*, ushort*, IRoSimpleMetaDataBuilder*, int>) &Locate;
        }

        [UnmanagedCallersOnly]
        static int Locate(_Locator* @this, ushort* name, IRoSimpleMetaDataBuilder* pushMetaData)
        {
            return @this->_fn(name, pushMetaData);
        }
    }
}
