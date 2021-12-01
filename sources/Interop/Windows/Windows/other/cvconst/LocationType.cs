// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from cvconst.h in the Debug Interface Access SDK
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

namespace TerraFX.Interop.Windows;

/// <include file='LocationType.xml' path='doc/member[@name="LocationType"]/*' />
public enum LocationType
{
    /// <include file='LocationType.xml' path='doc/member[@name="LocationType.LocIsNull"]/*' />
    LocIsNull,

    /// <include file='LocationType.xml' path='doc/member[@name="LocationType.LocIsStatic"]/*' />
    LocIsStatic,

    /// <include file='LocationType.xml' path='doc/member[@name="LocationType.LocIsTLS"]/*' />
    LocIsTLS,

    /// <include file='LocationType.xml' path='doc/member[@name="LocationType.LocIsRegRel"]/*' />
    LocIsRegRel,

    /// <include file='LocationType.xml' path='doc/member[@name="LocationType.LocIsThisRel"]/*' />
    LocIsThisRel,

    /// <include file='LocationType.xml' path='doc/member[@name="LocationType.LocIsEnregistered"]/*' />
    LocIsEnregistered,

    /// <include file='LocationType.xml' path='doc/member[@name="LocationType.LocIsBitField"]/*' />
    LocIsBitField,

    /// <include file='LocationType.xml' path='doc/member[@name="LocationType.LocIsSlot"]/*' />
    LocIsSlot,

    /// <include file='LocationType.xml' path='doc/member[@name="LocationType.LocIsIlRel"]/*' />
    LocIsIlRel,

    /// <include file='LocationType.xml' path='doc/member[@name="LocationType.LocInMetaData"]/*' />
    LocInMetaData,

    /// <include file='LocationType.xml' path='doc/member[@name="LocationType.LocIsConstant"]/*' />
    LocIsConstant,

    /// <include file='LocationType.xml' path='doc/member[@name="LocationType.LocIsRegRelAliasIndir"]/*' />
    LocIsRegRelAliasIndir,

    /// <include file='LocationType.xml' path='doc/member[@name="LocationType.LocTypeMax"]/*' />
    LocTypeMax,
}
