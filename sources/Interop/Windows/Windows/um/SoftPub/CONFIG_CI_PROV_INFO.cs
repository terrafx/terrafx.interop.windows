// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SoftPub.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public unsafe partial struct CONFIG_CI_PROV_INFO
{
    [NativeTypeName("DWORD")]
    public uint cbSize;

    [NativeTypeName("DWORD")]
    public uint dwPolicies;

    public CRYPT_DATA_BLOB* pPolicies;

    public CONFIG_CI_PROV_INFO_RESULT result;

    [NativeTypeName("DWORD")]
    public uint dwScenario;
}
