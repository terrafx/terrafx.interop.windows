// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/dxgi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        public static int D3D_SET_OBJECT_NAME_N_A(IDXGIObject* pObject, uint Chars, sbyte* pName)
        {
            var guid = WKPDID_D3DDebugObjectName;
            return pObject->SetPrivateData(&guid, Chars, pName);
        }

        public static int D3D_SET_OBJECT_NAME_A(IDXGIObject* pObject, sbyte* pName)
        {
            return D3D_SET_OBJECT_NAME_N_A(pObject, (uint)lstrlenA(pName), pName);
        }

        public static int D3D_SET_OBJECT_NAME_N_W(IDXGIObject* pObject, uint Chars, ushort* pName)
        {
            var guid = WKPDID_D3DDebugObjectNameW;
            return pObject->SetPrivateData(&guid, Chars * 2, pName);
        }

        public static int D3D_SET_OBJECT_NAME_W(IDXGIObject* pObject, ushort* pName)
        {
            return D3D_SET_OBJECT_NAME_N_W(pObject, (uint)lstrlenW(pName), pName);
        }
    }
}
