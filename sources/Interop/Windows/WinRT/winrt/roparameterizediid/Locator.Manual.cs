// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/roparameterizediid.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace TerraFX.Interop.WinRT;

public unsafe struct _Locator
{
    private static readonly void** Vtbl = InitVtbl();

    private static void** InitVtbl()
    {
        var vtbl = (void**)RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(_Locator), sizeof(void*) * 1);
        vtbl[0] = (delegate* unmanaged<_Locator*, char*, IRoSimpleMetaDataBuilder*, int>)&Locate;
        return vtbl;
    }

    public void** lpVtbl;

    public delegate*<char*, IRoSimpleMetaDataBuilder*, int> _fn;

    public _Locator(delegate*<char*, IRoSimpleMetaDataBuilder*, int> fn)
    {
        lpVtbl = Vtbl;
        _fn = fn;
    }

    [UnmanagedCallersOnly]
    private static int Locate(_Locator* @this, char* name, IRoSimpleMetaDataBuilder* pushMetaData)
    {
        return @this->_fn(name, pushMetaData);
    }
}
