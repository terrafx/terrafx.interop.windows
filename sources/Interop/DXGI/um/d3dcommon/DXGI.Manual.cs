// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3dcommon.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using static TerraFX.Interop.D3DCommon;
using static TerraFX.Interop.Kernel32;

namespace TerraFX.Interop
{
    public static unsafe partial class DXGI
    {
        public static int D3D_SET_OBJECT_NAME_N(IDXGIObject* pObject, uint Chars, ushort* pName)
        {
            var guid = WKPDID_D3DDebugObjectNameW;
            return pObject->SetPrivateData(&guid, Chars * 2, pName);
        }

        public static int D3D_SET_OBJECT_NAME(IDXGIObject* pObject, ushort* pName)
        {
            return D3D_SET_OBJECT_NAME_N(pObject, (uint)lstrlen(pName), pName);
        }
    }
}
