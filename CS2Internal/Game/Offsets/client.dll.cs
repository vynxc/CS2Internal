/*
 * Created using https://github.com/a2x/cs2-dumper
 * Tue, 21 Nov 2023 00:47:43 +0000
 */

public static class ActiveModelConfig_t
{
    public const int m_Handle = 0x28; // ModelConfigHandle_t
    public const int m_Name = 0x30; // CUtlSymbolLarge
    public const int m_AssociatedEntities = 0x38; // C_NetworkUtlVectorBase<CHandle<C_BaseModelEntity>>
    public const int m_AssociatedEntityNames = 0x50; // C_NetworkUtlVectorBase<CUtlSymbolLarge>
}

public static class CAnimGraphNetworkedVariables
{
    public const int m_PredNetBoolVariables = 0x8; // C_NetworkUtlVectorBase<uint32_t>
    public const int m_PredNetByteVariables = 0x20; // C_NetworkUtlVectorBase<uint8_t>
    public const int m_PredNetUInt16Variables = 0x38; // C_NetworkUtlVectorBase<uint16_t>
    public const int m_PredNetIntVariables = 0x50; // C_NetworkUtlVectorBase<int32_t>
    public const int m_PredNetUInt32Variables = 0x68; // C_NetworkUtlVectorBase<uint32_t>
    public const int m_PredNetUInt64Variables = 0x80; // C_NetworkUtlVectorBase<uint64_t>
    public const int m_PredNetFloatVariables = 0x98; // C_NetworkUtlVectorBase<float>
    public const int m_PredNetVectorVariables = 0xB0; // C_NetworkUtlVectorBase<Vector>
    public const int m_PredNetQuaternionVariables = 0xC8; // C_NetworkUtlVectorBase<Quaternion>
    public const int m_OwnerOnlyPredNetBoolVariables = 0xE0; // C_NetworkUtlVectorBase<uint32_t>
    public const int m_OwnerOnlyPredNetByteVariables = 0xF8; // C_NetworkUtlVectorBase<uint8_t>
    public const int m_OwnerOnlyPredNetUInt16Variables = 0x110; // C_NetworkUtlVectorBase<uint16_t>
    public const int m_OwnerOnlyPredNetIntVariables = 0x128; // C_NetworkUtlVectorBase<int32_t>
    public const int m_OwnerOnlyPredNetUInt32Variables = 0x140; // C_NetworkUtlVectorBase<uint32_t>
    public const int m_OwnerOnlyPredNetUInt64Variables = 0x158; // C_NetworkUtlVectorBase<uint64_t>
    public const int m_OwnerOnlyPredNetFloatVariables = 0x170; // C_NetworkUtlVectorBase<float>
    public const int m_OwnerOnlyPredNetVectorVariables = 0x188; // C_NetworkUtlVectorBase<Vector>
    public const int m_OwnerOnlyPredNetQuaternionVariables = 0x1A0; // C_NetworkUtlVectorBase<Quaternion>
    public const int m_nBoolVariablesCount = 0x1B8; // int32_t
    public const int m_nOwnerOnlyBoolVariablesCount = 0x1BC; // int32_t
    public const int m_nRandomSeedOffset = 0x1C0; // int32_t
    public const int m_flLastTeleportTime = 0x1C4; // float
}

public static class CAttributeList
{
    public const int m_Attributes = 0x8; // C_UtlVectorEmbeddedNetworkVar<CEconItemAttribute>
    public const int m_pManager = 0x58; // CAttributeManager*
}

public static class CAttributeManager
{
    public const int m_Providers = 0x8; // CUtlVector<CHandle<C_BaseEntity>>
    public const int m_iReapplyProvisionParity = 0x20; // int32_t
    public const int m_hOuter = 0x24; // CHandle<C_BaseEntity>
    public const int m_bPreventLoopback = 0x28; // bool
    public const int m_ProviderType = 0x2C; // attributeprovidertypes_t
    public const int m_CachedResults = 0x30; // CUtlVector<CAttributeManager::cached_attribute_float_t>
}

public static class CAttributeManager_cached_attribute_float_t
{
    public const int flIn = 0x0; // float
    public const int iAttribHook = 0x8; // CUtlSymbolLarge
    public const int flOut = 0x10; // float
}

public static class CBaseAnimGraph
{
    // C_BaseModelEntity
    public const int m_bInitiallyPopulateInterpHistory = 0xCC0; // bool
    public const int m_bShouldAnimateDuringGameplayPause = 0xCC1; // bool
    public const int m_bSuppressAnimEventSounds = 0xCC3; // bool
    public const int m_bAnimGraphUpdateEnabled = 0xCD0; // bool
    public const int m_flMaxSlopeDistance = 0xCD4; // float
    public const int m_vLastSlopeCheckPos = 0xCD8; // Vector
    public const int m_vecForce = 0xCE8; // Vector
    public const int m_nForceBone = 0xCF4; // int32_t
    public const int m_pClientsideRagdoll = 0xCF8; // CBaseAnimGraph*
    public const int m_bBuiltRagdoll = 0xD00; // bool
    public const int m_pRagdollPose = 0xD18; // PhysicsRagdollPose_t*
    public const int m_bClientRagdoll = 0xD20; // bool
    public const int m_bHasAnimatedMaterialAttributes = 0xD30; // bool
}

public static class CBaseAnimGraphController
{
    // CSkeletonAnimationController
    public const int m_baseLayer = 0x18; // CNetworkedSequenceOperation
    public const int m_animGraphNetworkedVars = 0x40; // CAnimGraphNetworkedVariables
    public const int m_bSequenceFinished = 0x1320; // bool
    public const int m_flLastEventCycle = 0x1324; // float
    public const int m_flLastEventAnimTime = 0x1328; // float
    public const int m_flPlaybackRate = 0x132C; // CNetworkedQuantizedFloat
    public const int m_flPrevAnimTime = 0x1334; // float
    public const int m_bClientSideAnimation = 0x1338; // bool
    public const int m_bNetworkedAnimationInputsChanged = 0x1339; // bool
    public const int m_nPrevNewSequenceParity = 0x133A; // uint8_t
    public const int m_nPrevResetEventsParity = 0x133B; // uint8_t
    public const int m_nNewSequenceParity = 0x133C; // int32_t
    public const int m_nResetEventsParity = 0x1340; // int32_t
    public const int m_nAnimLoopMode = 0x1344; // AnimLoopMode_t
    public const int m_hAnimationUpdate = 0x13E4; // AnimationUpdateListHandle_t
    public const int m_hLastAnimEventSequence = 0x13E8; // HSequence
}

public static class CBasePlayerController
{
    // C_BaseEntity
    public const int m_nFinalPredictedTick = 0x548; // int32_t
    public const int m_CommandContext = 0x550; // C_CommandContext
    public const int m_nInButtonsWhichAreToggles = 0x600; // uint64_t
    public const int m_nTickBase = 0x608; // uint32_t
    public const int m_hPawn = 0x60C; // CHandle<C_BasePlayerPawn>
    public const int m_hPredictedPawn = 0x610; // CHandle<C_BasePlayerPawn>
    public const int m_nSplitScreenSlot = 0x614; // CSplitScreenSlot
    public const int m_hSplitOwner = 0x618; // CHandle<CBasePlayerController>
    public const int m_hSplitScreenPlayers = 0x620; // CUtlVector<CHandle<CBasePlayerController>>
    public const int m_bIsHLTV = 0x638; // bool
    public const int m_iConnected = 0x63C; // PlayerConnectedState
    public const int m_iszPlayerName = 0x640; // char[128]
    public const int m_steamID = 0x6C8; // uint64_t
    public const int m_bIsLocalPlayerController = 0x6D0; // bool
    public const int m_iDesiredFOV = 0x6D4; // uint32_t
}

public static class CBasePlayerVData
{
    // CEntitySubclassVDataBase
    public const int m_sModelName = 0x28; // CResourceNameTyped<CWeakHandle<InfoForResourceTypeCModel>>
    public const int m_flHeadDamageMultiplier = 0x108; // CSkillFloat
    public const int m_flChestDamageMultiplier = 0x118; // CSkillFloat
    public const int m_flStomachDamageMultiplier = 0x128; // CSkillFloat
    public const int m_flArmDamageMultiplier = 0x138; // CSkillFloat
    public const int m_flLegDamageMultiplier = 0x148; // CSkillFloat
    public const int m_flHoldBreathTime = 0x158; // float
    public const int m_flDrowningDamageInterval = 0x15C; // float
    public const int m_nDrowningDamageInitial = 0x160; // int32_t
    public const int m_nDrowningDamageMax = 0x164; // int32_t
    public const int m_nWaterSpeed = 0x168; // int32_t
    public const int m_flUseRange = 0x16C; // float
    public const int m_flUseAngleTolerance = 0x170; // float
    public const int m_flCrouchTime = 0x174; // float
}

public static class CBasePlayerWeaponVData
{
    // CEntitySubclassVDataBase
    public const int m_szWorldModel = 0x28; // CResourceNameTyped<CWeakHandle<InfoForResourceTypeCModel>>
    public const int m_bBuiltRightHanded = 0x108; // bool
    public const int m_bAllowFlipping = 0x109; // bool
    public const int m_bIsFullAuto = 0x10A; // bool
    public const int m_nNumBullets = 0x10C; // int32_t
    public const int m_sMuzzleAttachment = 0x110; // CUtlString

    public const int
        m_szMuzzleFlashParticle =
            0x118; // CResourceNameTyped<CWeakHandle<InfoForResourceTypeIParticleSystemDefinition>>

    public const int m_iFlags = 0x1F8; // ItemFlagTypes_t
    public const int m_nPrimaryAmmoType = 0x1F9; // AmmoIndex_t
    public const int m_nSecondaryAmmoType = 0x1FA; // AmmoIndex_t
    public const int m_iMaxClip1 = 0x1FC; // int32_t
    public const int m_iMaxClip2 = 0x200; // int32_t
    public const int m_iDefaultClip1 = 0x204; // int32_t
    public const int m_iDefaultClip2 = 0x208; // int32_t
    public const int m_iWeight = 0x20C; // int32_t
    public const int m_bAutoSwitchTo = 0x210; // bool
    public const int m_bAutoSwitchFrom = 0x211; // bool
    public const int m_iRumbleEffect = 0x214; // RumbleEffect_t
    public const int m_aShootSounds = 0x218; // CUtlMap<WeaponSound_t,CSoundEventName>
    public const int m_iSlot = 0x238; // int32_t
    public const int m_iPosition = 0x23C; // int32_t
}

public static class CBaseProp
{
    // CBaseAnimGraph
    public const int m_bModelOverrodeBlockLOS = 0xE80; // bool
    public const int m_iShapeType = 0xE84; // int32_t
    public const int m_bConformToCollisionBounds = 0xE88; // bool
    public const int m_mPreferredCatchTransform = 0xE8C; // matrix3x4_t
}

public static class CBodyComponent
{
    // CEntityComponent
    public const int m_pSceneNode = 0x8; // CGameSceneNode*
    public const int __m_pChainEntity = 0x20; // CNetworkVarChainer
}

public static class CBodyComponentBaseAnimGraph
{
    // CBodyComponentSkeletonInstance
    public const int m_animationController = 0x480; // CBaseAnimGraphController
    public const int __m_pChainEntity = 0x18C0; // CNetworkVarChainer
}

public static class CBodyComponentBaseModelEntity
{
    // CBodyComponentSkeletonInstance
    public const int __m_pChainEntity = 0x480; // CNetworkVarChainer
}

public static class CBodyComponentPoint
{
    // CBodyComponent
    public const int m_sceneNode = 0x50; // CGameSceneNode
    public const int __m_pChainEntity = 0x1A0; // CNetworkVarChainer
}

public static class CBodyComponentSkeletonInstance
{
    // CBodyComponent
    public const int m_skeletonInstance = 0x50; // CSkeletonInstance
    public const int __m_pChainEntity = 0x450; // CNetworkVarChainer
}

public static class CBombTarget
{
    // C_BaseTrigger
    public const int m_bBombPlantedHere = 0xCC8; // bool
}

public static class CBreachCharge
{
    // C_CSWeaponBase
}

public static class CBreachChargeProjectile
{
    // C_BaseGrenade
}

public static class CBumpMine
{
    // C_CSWeaponBase
}

public static class CBumpMineProjectile
{
    // C_BaseGrenade
}

public static class CBuoyancyHelper
{
    public const int m_flFluidDensity = 0x18; // float
}

public static class CCSGO_WingmaintroCharacterPosition
{
    // C_CSGO_TeamIntroCharacterPosition
}

public static class CCSGO_WingmaintroCounterTerroristPosition
{
    // CCSGO_WingmaintroCharacterPosition
}

public static class CCSGO_WingmaintroTerroristPosition
{
    // CCSGO_WingmaintroCharacterPosition
}

public static class CCSGameModeRules
{
    public const int __m_pChainEntity = 0x8; // CNetworkVarChainer
}

public static class CCSGameModeRules_Deathmatch
{
    // CCSGameModeRules
    public const int m_bFirstThink = 0x30; // bool
    public const int m_bFirstThinkAfterConnected = 0x31; // bool
    public const int m_flDMBonusStartTime = 0x34; // GameTime_t
    public const int m_flDMBonusTimeLength = 0x38; // float
    public const int m_nDMBonusWeaponLoadoutSlot = 0x3C; // int16_t
}

public static class CCSGameModeRules_Noop
{
    // CCSGameModeRules
}

public static class CCSGameModeRules_Scripted
{
    // CCSGameModeRules
}

public static class CCSGameModeScript
{
    // CBasePulseGraphInstance
}

public static class CCSObserver_CameraServices
{
    // CCSPlayerBase_CameraServices
}

public static class CCSObserver_MovementServices
{
    // CPlayer_MovementServices
}

public static class CCSObserver_ObserverServices
{
    // CPlayer_ObserverServices
    public const int m_hLastObserverTarget = 0x58; // CEntityHandle
    public const int m_vecObserverInterpolateOffset = 0x5C; // Vector
    public const int m_vecObserverInterpStartPos = 0x68; // Vector
    public const int m_flObsInterp_PathLength = 0x74; // float
    public const int m_qObsInterp_OrientationStart = 0x80; // Quaternion
    public const int m_qObsInterp_OrientationTravelDir = 0x90; // Quaternion
    public const int m_obsInterpState = 0xA0; // ObserverInterpState_t
    public const int m_bObserverInterpolationNeedsDeferredSetup = 0xA4; // bool
}

public static class CCSObserver_UseServices
{
    // CPlayer_UseServices
}

public static class CCSObserver_ViewModelServices
{
    // CPlayer_ViewModelServices
}

public static class CCSPlayerBase_CameraServices
{
    // CPlayer_CameraServices
    public const int m_iFOV = 0x210; // uint32_t
    public const int m_iFOVStart = 0x214; // uint32_t
    public const int m_flFOVTime = 0x218; // GameTime_t
    public const int m_flFOVRate = 0x21C; // float
    public const int m_hZoomOwner = 0x220; // CHandle<C_BaseEntity>
    public const int m_flLastShotFOV = 0x224; // float
}

public static class CCSPlayerController
{
    // CBasePlayerController
    public const int m_pInGameMoneyServices = 0x700; // CCSPlayerController_InGameMoneyServices*
    public const int m_pInventoryServices = 0x708; // CCSPlayerController_InventoryServices*
    public const int m_pActionTrackingServices = 0x710; // CCSPlayerController_ActionTrackingServices*
    public const int m_pDamageServices = 0x718; // CCSPlayerController_DamageServices*
    public const int m_iPing = 0x720; // uint32_t
    public const int m_bHasCommunicationAbuseMute = 0x724; // bool
    public const int m_szCrosshairCodes = 0x728; // CUtlSymbolLarge
    public const int m_iPendingTeamNum = 0x730; // uint8_t
    public const int m_flForceTeamTime = 0x734; // GameTime_t
    public const int m_iCompTeammateColor = 0x738; // int32_t
    public const int m_bEverPlayedOnTeam = 0x73C; // bool
    public const int m_flPreviousForceJoinTeamTime = 0x740; // GameTime_t
    public const int m_szClan = 0x748; // CUtlSymbolLarge
    public const int m_sSanitizedPlayerName = 0x750; // CUtlString
    public const int m_iCoachingTeam = 0x758; // int32_t
    public const int m_nPlayerDominated = 0x760; // uint64_t
    public const int m_nPlayerDominatingMe = 0x768; // uint64_t
    public const int m_iCompetitiveRanking = 0x770; // int32_t
    public const int m_iCompetitiveWins = 0x774; // int32_t
    public const int m_iCompetitiveRankType = 0x778; // int8_t
    public const int m_iCompetitiveRankingPredicted_Win = 0x77C; // int32_t
    public const int m_iCompetitiveRankingPredicted_Loss = 0x780; // int32_t
    public const int m_iCompetitiveRankingPredicted_Tie = 0x784; // int32_t
    public const int m_nEndMatchNextMapVote = 0x788; // int32_t
    public const int m_unActiveQuestId = 0x78C; // uint16_t
    public const int m_nQuestProgressReason = 0x790; // QuestProgress::Reason
    public const int m_unPlayerTvControlFlags = 0x794; // uint32_t
    public const int m_iDraftIndex = 0x7C0; // int32_t
    public const int m_msQueuedModeDisconnectionTimestamp = 0x7C4; // uint32_t
    public const int m_uiAbandonRecordedReason = 0x7C8; // uint32_t
    public const int m_bCannotBeKicked = 0x7CC; // bool
    public const int m_bEverFullyConnected = 0x7CD; // bool
    public const int m_bAbandonAllowsSurrender = 0x7CE; // bool
    public const int m_bAbandonOffersInstantSurrender = 0x7CF; // bool
    public const int m_bDisconnection1MinWarningPrinted = 0x7D0; // bool
    public const int m_bScoreReported = 0x7D1; // bool
    public const int m_nDisconnectionTick = 0x7D4; // int32_t
    public const int m_bControllingBot = 0x7E0; // bool
    public const int m_bHasControlledBotThisRound = 0x7E1; // bool
    public const int m_bHasBeenControlledByPlayerThisRound = 0x7E2; // bool
    public const int m_nBotsControlledThisRound = 0x7E4; // int32_t
    public const int m_bCanControlObservedBot = 0x7E8; // bool
    public const int m_hPlayerPawn = 0x7EC; // CHandle<C_CSPlayerPawn>
    public const int m_hObserverPawn = 0x7F0; // CHandle<C_CSObserverPawn>
    public const int m_bPawnIsAlive = 0x7F4; // bool
    public const int m_iPawnHealth = 0x7F8; // uint32_t
    public const int m_iPawnArmor = 0x7FC; // int32_t
    public const int m_bPawnHasDefuser = 0x800; // bool
    public const int m_bPawnHasHelmet = 0x801; // bool
    public const int m_nPawnCharacterDefIndex = 0x802; // uint16_t
    public const int m_iPawnLifetimeStart = 0x804; // int32_t
    public const int m_iPawnLifetimeEnd = 0x808; // int32_t
    public const int m_iPawnBotDifficulty = 0x80C; // int32_t
    public const int m_hOriginalControllerOfCurrentPawn = 0x810; // CHandle<CCSPlayerController>
    public const int m_iScore = 0x814; // int32_t
    public const int m_vecKills = 0x818; // C_NetworkUtlVectorBase<EKillTypes_t>
    public const int m_iMVPs = 0x830; // int32_t
    public const int m_bIsPlayerNameDirty = 0x834; // bool
}

public static class CCSPlayerController_ActionTrackingServices
{
    // CPlayerControllerComponent
    public const int m_perRoundStats = 0x40; // C_UtlVectorEmbeddedNetworkVar<CSPerRoundStats_t>
    public const int m_matchStats = 0x90; // CSMatchStats_t
    public const int m_iNumRoundKills = 0x108; // int32_t
    public const int m_iNumRoundKillsHeadshots = 0x10C; // int32_t
    public const int m_unTotalRoundDamageDealt = 0x110; // uint32_t
}

public static class CCSPlayerController_DamageServices
{
    // CPlayerControllerComponent
    public const int m_nSendUpdate = 0x40; // int32_t
    public const int m_DamageList = 0x48; // C_UtlVectorEmbeddedNetworkVar<CDamageRecord>
}

public static class CCSPlayerController_InGameMoneyServices
{
    // CPlayerControllerComponent
    public const int m_iAccount = 0x40; // int32_t
    public const int m_iStartAccount = 0x44; // int32_t
    public const int m_iTotalCashSpent = 0x48; // int32_t
    public const int m_iCashSpentThisRound = 0x4C; // int32_t
    public const int m_nPreviousAccount = 0x50; // int32_t
}

public static class CCSPlayerController_InventoryServices
{
    // CPlayerControllerComponent
    public const int m_unMusicID = 0x40; // uint16_t
    public const int m_rank = 0x44; // MedalRank_t[6]
    public const int m_nPersonaDataPublicLevel = 0x5C; // int32_t
    public const int m_nPersonaDataPublicCommendsLeader = 0x60; // int32_t
    public const int m_nPersonaDataPublicCommendsTeacher = 0x64; // int32_t
    public const int m_nPersonaDataPublicCommendsFriendly = 0x68; // int32_t

    public const int
        m_vecServerAuthoritativeWeaponSlots = 0x70; // C_UtlVectorEmbeddedNetworkVar<ServerAuthoritativeWeaponSlot_t>
}

public static class CCSPlayer_ActionTrackingServices
{
    // CPlayerPawnComponent
    public const int m_hLastWeaponBeforeC4AutoSwitch = 0x40; // CHandle<C_BasePlayerWeapon>
    public const int m_bIsRescuing = 0x44; // bool
    public const int m_weaponPurchasesThisMatch = 0x48; // WeaponPurchaseTracker_t
    public const int m_weaponPurchasesThisRound = 0xA0; // WeaponPurchaseTracker_t
}

public static class CCSPlayer_BulletServices
{
    // CPlayerPawnComponent
    public const int m_totalHitsOnServer = 0x40; // int32_t
}

public static class CCSPlayer_BuyServices
{
    // CPlayerPawnComponent
    public const int m_vecSellbackPurchaseEntries = 0x40; // C_UtlVectorEmbeddedNetworkVar<SellbackPurchaseEntry_t>
}

public static class CCSPlayer_CameraServices
{
    // CCSPlayerBase_CameraServices
    public const int m_flDeathCamTilt = 0x228; // float
}

public static class CCSPlayer_GlowServices
{
    // CPlayerPawnComponent
}

public static class CCSPlayer_HostageServices
{
    // CPlayerPawnComponent
    public const int m_hCarriedHostage = 0x40; // CHandle<C_BaseEntity>
    public const int m_hCarriedHostageProp = 0x44; // CHandle<C_BaseEntity>
}

public static class CCSPlayer_ItemServices
{
    // CPlayer_ItemServices
    public const int m_bHasDefuser = 0x40; // bool
    public const int m_bHasHelmet = 0x41; // bool
    public const int m_bHasHeavyArmor = 0x42; // bool
}

public static class CCSPlayer_MovementServices
{
    // CPlayer_MovementServices_Humanoid
    public const int m_flMaxFallVelocity = 0x210; // float
    public const int m_vecLadderNormal = 0x214; // Vector
    public const int m_nLadderSurfacePropIndex = 0x220; // int32_t
    public const int m_flDuckAmount = 0x224; // float
    public const int m_flDuckSpeed = 0x228; // float
    public const int m_bDuckOverride = 0x22C; // bool
    public const int m_bDesiresDuck = 0x22D; // bool
    public const int m_flDuckOffset = 0x230; // float
    public const int m_nDuckTimeMsecs = 0x234; // uint32_t
    public const int m_nDuckJumpTimeMsecs = 0x238; // uint32_t
    public const int m_nJumpTimeMsecs = 0x23C; // uint32_t
    public const int m_flLastDuckTime = 0x240; // float
    public const int m_vecLastPositionAtFullCrouchSpeed = 0x250; // Vector2D
    public const int m_duckUntilOnGround = 0x258; // bool
    public const int m_bHasWalkMovedSinceLastJump = 0x259; // bool
    public const int m_bInStuckTest = 0x25A; // bool
    public const int m_flStuckCheckTime = 0x268; // float[64][2]
    public const int m_nTraceCount = 0x468; // int32_t
    public const int m_StuckLast = 0x46C; // int32_t
    public const int m_bSpeedCropped = 0x470; // bool
    public const int m_nOldWaterLevel = 0x474; // int32_t
    public const int m_flWaterEntryTime = 0x478; // float
    public const int m_vecForward = 0x47C; // Vector
    public const int m_vecLeft = 0x488; // Vector
    public const int m_vecUp = 0x494; // Vector
    public const int m_vecPreviouslyPredictedOrigin = 0x4A0; // Vector
    public const int m_bOldJumpPressed = 0x4AC; // bool
    public const int m_flJumpPressedTime = 0x4B0; // float
    public const int m_flJumpUntil = 0x4B4; // float
    public const int m_flJumpVel = 0x4B8; // float
    public const int m_fStashGrenadeParameterWhen = 0x4BC; // GameTime_t
    public const int m_nButtonDownMaskPrev = 0x4C0; // uint64_t
    public const int m_flOffsetTickCompleteTime = 0x4C8; // float
    public const int m_flOffsetTickStashedSpeed = 0x4CC; // float
    public const int m_flStamina = 0x4D0; // float
    public const int m_bUpdatePredictedOriginAfterDataUpdate = 0x4D4; // bool
    public const int m_flHeightAtJumpStart = 0x4D8; // float
    public const int m_flMaxJumpHeightThisJump = 0x4DC; // float
}

public static class CCSPlayer_PingServices
{
    // CPlayerPawnComponent
    public const int m_hPlayerPing = 0x40; // CHandle<C_BaseEntity>
}

public static class CCSPlayer_UseServices
{
    // CPlayer_UseServices
}

public static class CCSPlayer_ViewModelServices
{
    // CPlayer_ViewModelServices
    public const int m_hViewModel = 0x40; // CHandle<C_BaseViewModel>[3]
}

public static class CCSPlayer_WaterServices
{
    // CPlayer_WaterServices
    public const int m_flWaterJumpTime = 0x40; // float
    public const int m_vecWaterJumpVel = 0x44; // Vector
    public const int m_flSwimSoundTime = 0x50; // float
}

public static class CCSPlayer_WeaponServices
{
    // CPlayer_WeaponServices
    public const int m_flNextAttack = 0xC0; // GameTime_t
    public const int m_bIsLookingAtWeapon = 0xC4; // bool
    public const int m_bIsHoldingLookAtWeapon = 0xC5; // bool
}

public static class CCSWeaponBaseVData
{
    // CBasePlayerWeaponVData
    public const int m_WeaponType = 0x240; // CSWeaponType
    public const int m_WeaponCategory = 0x244; // CSWeaponCategory
    public const int m_szViewModel = 0x248; // CResourceNameTyped<CWeakHandle<InfoForResourceTypeCModel>>
    public const int m_szPlayerModel = 0x328; // CResourceNameTyped<CWeakHandle<InfoForResourceTypeCModel>>
    public const int m_szWorldDroppedModel = 0x408; // CResourceNameTyped<CWeakHandle<InfoForResourceTypeCModel>>
    public const int m_szAimsightLensMaskModel = 0x4E8; // CResourceNameTyped<CWeakHandle<InfoForResourceTypeCModel>>
    public const int m_szMagazineModel = 0x5C8; // CResourceNameTyped<CWeakHandle<InfoForResourceTypeCModel>>

    public const int
        m_szHeatEffect = 0x6A8; // CResourceNameTyped<CWeakHandle<InfoForResourceTypeIParticleSystemDefinition>>

    public const int
        m_szEjectBrassEffect = 0x788; // CResourceNameTyped<CWeakHandle<InfoForResourceTypeIParticleSystemDefinition>>

    public const int
        m_szMuzzleFlashParticleAlt =
            0x868; // CResourceNameTyped<CWeakHandle<InfoForResourceTypeIParticleSystemDefinition>>

    public const int
        m_szMuzzleFlashThirdPersonParticle =
            0x948; // CResourceNameTyped<CWeakHandle<InfoForResourceTypeIParticleSystemDefinition>>

    public const int
        m_szMuzzleFlashThirdPersonParticleAlt =
            0xA28; // CResourceNameTyped<CWeakHandle<InfoForResourceTypeIParticleSystemDefinition>>

    public const int
        m_szTracerParticle = 0xB08; // CResourceNameTyped<CWeakHandle<InfoForResourceTypeIParticleSystemDefinition>>

    public const int m_GearSlot = 0xBE8; // gear_slot_t
    public const int m_GearSlotPosition = 0xBEC; // int32_t
    public const int m_DefaultLoadoutSlot = 0xBF0; // loadout_slot_t
    public const int m_sWrongTeamMsg = 0xBF8; // CUtlString
    public const int m_nPrice = 0xC00; // int32_t
    public const int m_nKillAward = 0xC04; // int32_t
    public const int m_nPrimaryReserveAmmoMax = 0xC08; // int32_t
    public const int m_nSecondaryReserveAmmoMax = 0xC0C; // int32_t
    public const int m_bMeleeWeapon = 0xC10; // bool
    public const int m_bHasBurstMode = 0xC11; // bool
    public const int m_bIsRevolver = 0xC12; // bool
    public const int m_bCannotShootUnderwater = 0xC13; // bool
    public const int m_szName = 0xC18; // CUtlString
    public const int m_szAnimExtension = 0xC20; // CUtlString
    public const int m_eSilencerType = 0xC28; // CSWeaponSilencerType
    public const int m_nCrosshairMinDistance = 0xC2C; // int32_t
    public const int m_nCrosshairDeltaDistance = 0xC30; // int32_t
    public const int m_flCycleTime = 0xC34; // CFiringModeFloat
    public const int m_flMaxSpeed = 0xC3C; // CFiringModeFloat
    public const int m_flSpread = 0xC44; // CFiringModeFloat
    public const int m_flInaccuracyCrouch = 0xC4C; // CFiringModeFloat
    public const int m_flInaccuracyStand = 0xC54; // CFiringModeFloat
    public const int m_flInaccuracyJump = 0xC5C; // CFiringModeFloat
    public const int m_flInaccuracyLand = 0xC64; // CFiringModeFloat
    public const int m_flInaccuracyLadder = 0xC6C; // CFiringModeFloat
    public const int m_flInaccuracyFire = 0xC74; // CFiringModeFloat
    public const int m_flInaccuracyMove = 0xC7C; // CFiringModeFloat
    public const int m_flRecoilAngle = 0xC84; // CFiringModeFloat
    public const int m_flRecoilAngleVariance = 0xC8C; // CFiringModeFloat
    public const int m_flRecoilMagnitude = 0xC94; // CFiringModeFloat
    public const int m_flRecoilMagnitudeVariance = 0xC9C; // CFiringModeFloat
    public const int m_nTracerFrequency = 0xCA4; // CFiringModeInt
    public const int m_flInaccuracyJumpInitial = 0xCAC; // float
    public const int m_flInaccuracyJumpApex = 0xCB0; // float
    public const int m_flInaccuracyReload = 0xCB4; // float
    public const int m_nRecoilSeed = 0xCB8; // int32_t
    public const int m_nSpreadSeed = 0xCBC; // int32_t
    public const int m_flTimeToIdleAfterFire = 0xCC0; // float
    public const int m_flIdleInterval = 0xCC4; // float
    public const int m_flAttackMovespeedFactor = 0xCC8; // float
    public const int m_flHeatPerShot = 0xCCC; // float
    public const int m_flInaccuracyPitchShift = 0xCD0; // float
    public const int m_flInaccuracyAltSoundThreshold = 0xCD4; // float
    public const int m_flBotAudibleRange = 0xCD8; // float
    public const int m_szUseRadioSubtitle = 0xCE0; // CUtlString
    public const int m_bUnzoomsAfterShot = 0xCE8; // bool
    public const int m_bHideViewModelWhenZoomed = 0xCE9; // bool
    public const int m_nZoomLevels = 0xCEC; // int32_t
    public const int m_nZoomFOV1 = 0xCF0; // int32_t
    public const int m_nZoomFOV2 = 0xCF4; // int32_t
    public const int m_flZoomTime0 = 0xCF8; // float
    public const int m_flZoomTime1 = 0xCFC; // float
    public const int m_flZoomTime2 = 0xD00; // float
    public const int m_flIronSightPullUpSpeed = 0xD04; // float
    public const int m_flIronSightPutDownSpeed = 0xD08; // float
    public const int m_flIronSightFOV = 0xD0C; // float
    public const int m_flIronSightPivotForward = 0xD10; // float
    public const int m_flIronSightLooseness = 0xD14; // float
    public const int m_angPivotAngle = 0xD18; // QAngle
    public const int m_vecIronSightEyePos = 0xD24; // Vector
    public const int m_nDamage = 0xD30; // int32_t
    public const int m_flHeadshotMultiplier = 0xD34; // float
    public const int m_flArmorRatio = 0xD38; // float
    public const int m_flPenetration = 0xD3C; // float
    public const int m_flRange = 0xD40; // float
    public const int m_flRangeModifier = 0xD44; // float
    public const int m_flFlinchVelocityModifierLarge = 0xD48; // float
    public const int m_flFlinchVelocityModifierSmall = 0xD4C; // float
    public const int m_flRecoveryTimeCrouch = 0xD50; // float
    public const int m_flRecoveryTimeStand = 0xD54; // float
    public const int m_flRecoveryTimeCrouchFinal = 0xD58; // float
    public const int m_flRecoveryTimeStandFinal = 0xD5C; // float
    public const int m_nRecoveryTransitionStartBullet = 0xD60; // int32_t
    public const int m_nRecoveryTransitionEndBullet = 0xD64; // int32_t
    public const int m_flThrowVelocity = 0xD68; // float
    public const int m_vSmokeColor = 0xD6C; // Vector
    public const int m_szAnimClass = 0xD78; // CUtlString
}

public static class CClientAlphaProperty
{
    // IClientAlphaProperty
    public const int m_nRenderFX = 0x10; // uint8_t
    public const int m_nRenderMode = 0x11; // uint8_t
    public const int m_bAlphaOverride = 0x0; // bitfield:1
    public const int m_bShadowAlphaOverride = 0x0; // bitfield:1
    public const int m_nReserved = 0x0; // bitfield:6
    public const int m_nAlpha = 0x13; // uint8_t
    public const int m_nDesyncOffset = 0x14; // uint16_t
    public const int m_nReserved2 = 0x16; // uint16_t
    public const int m_nDistFadeStart = 0x18; // uint16_t
    public const int m_nDistFadeEnd = 0x1A; // uint16_t
    public const int m_flFadeScale = 0x1C; // float
    public const int m_flRenderFxStartTime = 0x20; // GameTime_t
    public const int m_flRenderFxDuration = 0x24; // float
}

public static class CCollisionProperty
{
    public const int m_collisionAttribute = 0x10; // VPhysicsCollisionAttribute_t
    public const int m_vecMins = 0x40; // Vector
    public const int m_vecMaxs = 0x4C; // Vector
    public const int m_usSolidFlags = 0x5A; // uint8_t
    public const int m_nSolidType = 0x5B; // SolidType_t
    public const int m_triggerBloat = 0x5C; // uint8_t
    public const int m_nSurroundType = 0x5D; // SurroundingBoundsType_t
    public const int m_CollisionGroup = 0x5E; // uint8_t
    public const int m_nEnablePhysics = 0x5F; // uint8_t
    public const int m_flBoundingRadius = 0x60; // float
    public const int m_vecSpecifiedSurroundingMins = 0x64; // Vector
    public const int m_vecSpecifiedSurroundingMaxs = 0x70; // Vector
    public const int m_vecSurroundingMaxs = 0x7C; // Vector
    public const int m_vecSurroundingMins = 0x88; // Vector
    public const int m_vCapsuleCenter1 = 0x94; // Vector
    public const int m_vCapsuleCenter2 = 0xA0; // Vector
    public const int m_flCapsuleRadius = 0xAC; // float
}

public static class CComicBook
{
    public const int m_CoverImage = 0x8; // CPanoramaImageName
    public const int m_XmlFile = 0x18; // CUtlString
}

public static class CCompositeMaterialEditorDoc
{
    public const int m_nVersion = 0x8; // int32_t
    public const int m_Points = 0x10; // CUtlVector<CompositeMaterialEditorPoint_t>
    public const int m_KVthumbnail = 0x28; // KeyValues3
}

public static class CDamageRecord
{
    public const int m_PlayerDamager = 0x28; // CHandle<C_CSPlayerPawnBase>
    public const int m_PlayerRecipient = 0x2C; // CHandle<C_CSPlayerPawnBase>
    public const int m_hPlayerControllerDamager = 0x30; // CHandle<CCSPlayerController>
    public const int m_hPlayerControllerRecipient = 0x34; // CHandle<CCSPlayerController>
    public const int m_szPlayerDamagerName = 0x38; // CUtlString
    public const int m_szPlayerRecipientName = 0x40; // CUtlString
    public const int m_DamagerXuid = 0x48; // uint64_t
    public const int m_RecipientXuid = 0x50; // uint64_t
    public const int m_iDamage = 0x58; // int32_t
    public const int m_iActualHealthRemoved = 0x5C; // int32_t
    public const int m_iNumHits = 0x60; // int32_t
    public const int m_iLastBulletUpdate = 0x64; // int32_t
    public const int m_bIsOtherEnemy = 0x68; // bool
    public const int m_killType = 0x69; // EKillTypes_t
}

public static class CDecalInfo
{
    public const int m_flAnimationScale = 0x0; // float
    public const int m_flAnimationLifeSpan = 0x4; // float
    public const int m_flPlaceTime = 0x8; // float
    public const int m_flFadeStartTime = 0xC; // float
    public const int m_flFadeDuration = 0x10; // float
    public const int m_nVBSlot = 0x14; // int32_t
    public const int m_nBoneIndex = 0x18; // int32_t
    public const int m_vPosition = 0x28; // Vector
    public const int m_flBoundingRadiusSqr = 0x34; // float
    public const int m_pNext = 0x40; // CDecalInfo*
    public const int m_pPrev = 0x48; // CDecalInfo*
    public const int m_nDecalMaterialIndex = 0xA8; // int32_t
}

public static class CEconItemAttribute
{
    public const int m_iAttributeDefinitionIndex = 0x30; // uint16_t
    public const int m_flValue = 0x34; // float
    public const int m_flInitialValue = 0x38; // float
    public const int m_nRefundableCurrency = 0x3C; // int32_t
    public const int m_bSetBonus = 0x40; // bool
}

public static class CEffectData
{
    public const int m_vOrigin = 0x8; // Vector
    public const int m_vStart = 0x14; // Vector
    public const int m_vNormal = 0x20; // Vector
    public const int m_vAngles = 0x2C; // QAngle
    public const int m_hEntity = 0x38; // CEntityHandle
    public const int m_hOtherEntity = 0x3C; // CEntityHandle
    public const int m_flScale = 0x40; // float
    public const int m_flMagnitude = 0x44; // float
    public const int m_flRadius = 0x48; // float
    public const int m_nSurfaceProp = 0x4C; // CUtlStringToken
    public const int m_nEffectIndex = 0x50; // CWeakHandle<InfoForResourceTypeIParticleSystemDefinition>
    public const int m_nDamageType = 0x58; // uint32_t
    public const int m_nPenetrate = 0x5C; // uint8_t
    public const int m_nMaterial = 0x5E; // uint16_t
    public const int m_nHitBox = 0x60; // uint16_t
    public const int m_nColor = 0x62; // uint8_t
    public const int m_fFlags = 0x63; // uint8_t
    public const int m_nAttachmentIndex = 0x64; // AttachmentHandle_t
    public const int m_nAttachmentName = 0x68; // CUtlStringToken
    public const int m_iEffectName = 0x6C; // uint16_t
    public const int m_nExplosionType = 0x6E; // uint8_t
}

public static class CEntityComponent
{
}

public static class CEntityIdentity
{
    public const int m_nameStringableIndex = 0x14; // int32_t
    public const int m_name = 0x18; // CUtlSymbolLarge
    public const int m_designerName = 0x20; // CUtlSymbolLarge
    public const int m_flags = 0x30; // uint32_t
    public const int m_worldGroupId = 0x38; // WorldGroupId_t
    public const int m_fDataObjectTypes = 0x3C; // uint32_t
    public const int m_PathIndex = 0x40; // ChangeAccessorFieldPathIndex_t
    public const int m_pPrev = 0x58; // CEntityIdentity*
    public const int m_pNext = 0x60; // CEntityIdentity*
    public const int m_pPrevByClass = 0x68; // CEntityIdentity*
    public const int m_pNextByClass = 0x70; // CEntityIdentity*
}

public static class CEntityInstance
{
    public const int m_iszPrivateVScripts = 0x8; // CUtlSymbolLarge
    public const int m_pEntity = 0x10; // CEntityIdentity*
    public const int m_CScriptComponent = 0x28; // CScriptComponent*
}

public static class CFireOverlay
{
    // CGlowOverlay
    public const int m_pOwner = 0xD0; // C_FireSmoke*
    public const int m_vBaseColors = 0xD8; // Vector[4]
    public const int m_flScale = 0x108; // float
    public const int m_nGUID = 0x10C; // int32_t
}

public static class CFlashlightEffect
{
    public const int m_bIsOn = 0x10; // bool
    public const int m_bMuzzleFlashEnabled = 0x20; // bool
    public const int m_flMuzzleFlashBrightness = 0x24; // float
    public const int m_quatMuzzleFlashOrientation = 0x30; // Quaternion
    public const int m_vecMuzzleFlashOrigin = 0x40; // Vector
    public const int m_flFov = 0x4C; // float
    public const int m_flFarZ = 0x50; // float
    public const int m_flLinearAtten = 0x54; // float
    public const int m_bCastsShadows = 0x58; // bool
    public const int m_flCurrentPullBackDist = 0x5C; // float
    public const int m_FlashlightTexture = 0x60; // CStrongHandle<InfoForResourceTypeCTextureBase>
    public const int m_MuzzleFlashTexture = 0x68; // CStrongHandle<InfoForResourceTypeCTextureBase>
    public const int m_textureName = 0x70; // char[64]
}

public static class CFuncWater
{
    // C_BaseModelEntity
    public const int m_BuoyancyHelper = 0xCC0; // CBuoyancyHelper
}

public static class CGameSceneNode
{
    public const int m_nodeToWorld = 0x10; // CTransform
    public const int m_pOwner = 0x30; // CEntityInstance*
    public const int m_pParent = 0x38; // CGameSceneNode*
    public const int m_pChild = 0x40; // CGameSceneNode*
    public const int m_pNextSibling = 0x48; // CGameSceneNode*
    public const int m_hParent = 0x70; // CGameSceneNodeHandle
    public const int m_vecOrigin = 0x80; // CNetworkOriginCellCoordQuantizedVector
    public const int m_angRotation = 0xB8; // QAngle
    public const int m_flScale = 0xC4; // float
    public const int m_vecAbsOrigin = 0xC8; // Vector
    public const int m_angAbsRotation = 0xD4; // QAngle
    public const int m_flAbsScale = 0xE0; // float
    public const int m_nParentAttachmentOrBone = 0xE4; // int16_t
    public const int m_bDebugAbsOriginChanges = 0xE6; // bool
    public const int m_bDormant = 0xE7; // bool
    public const int m_bForceParentToBeNetworked = 0xE8; // bool
    public const int m_bDirtyHierarchy = 0x0; // bitfield:1
    public const int m_bDirtyBoneMergeInfo = 0x0; // bitfield:1
    public const int m_bNetworkedPositionChanged = 0x0; // bitfield:1
    public const int m_bNetworkedAnglesChanged = 0x0; // bitfield:1
    public const int m_bNetworkedScaleChanged = 0x0; // bitfield:1
    public const int m_bWillBeCallingPostDataUpdate = 0x0; // bitfield:1
    public const int m_bNotifyBoneTransformsChanged = 0x0; // bitfield:1
    public const int m_bBoneMergeFlex = 0x0; // bitfield:1
    public const int m_nLatchAbsOrigin = 0x0; // bitfield:2
    public const int m_bDirtyBoneMergeBoneToRoot = 0x0; // bitfield:1
    public const int m_nHierarchicalDepth = 0xEB; // uint8_t
    public const int m_nHierarchyType = 0xEC; // uint8_t
    public const int m_nDoNotSetAnimTimeInInvalidatePhysicsCount = 0xED; // uint8_t
    public const int m_name = 0xF0; // CUtlStringToken
    public const int m_hierarchyAttachName = 0x130; // CUtlStringToken
    public const int m_flZOffset = 0x134; // float
    public const int m_vRenderOrigin = 0x138; // Vector
}

public static class CGameSceneNodeHandle
{
    public const int m_hOwner = 0x8; // CEntityHandle
    public const int m_name = 0xC; // CUtlStringToken
}

public static class CGlobalLightBase
{
    public const int m_bSpotLight = 0x10; // bool
    public const int m_SpotLightOrigin = 0x14; // Vector
    public const int m_SpotLightAngles = 0x20; // QAngle
    public const int m_ShadowDirection = 0x2C; // Vector
    public const int m_AmbientDirection = 0x38; // Vector
    public const int m_SpecularDirection = 0x44; // Vector
    public const int m_InspectorSpecularDirection = 0x50; // Vector
    public const int m_flSpecularPower = 0x5C; // float
    public const int m_flSpecularIndependence = 0x60; // float
    public const int m_SpecularColor = 0x64; // Color
    public const int m_bStartDisabled = 0x68; // bool
    public const int m_bEnabled = 0x69; // bool
    public const int m_LightColor = 0x6A; // Color
    public const int m_AmbientColor1 = 0x6E; // Color
    public const int m_AmbientColor2 = 0x72; // Color
    public const int m_AmbientColor3 = 0x76; // Color
    public const int m_flSunDistance = 0x7C; // float
    public const int m_flFOV = 0x80; // float
    public const int m_flNearZ = 0x84; // float
    public const int m_flFarZ = 0x88; // float
    public const int m_bEnableShadows = 0x8C; // bool
    public const int m_bOldEnableShadows = 0x8D; // bool
    public const int m_bBackgroundClearNotRequired = 0x8E; // bool
    public const int m_flCloudScale = 0x90; // float
    public const int m_flCloud1Speed = 0x94; // float
    public const int m_flCloud1Direction = 0x98; // float
    public const int m_flCloud2Speed = 0x9C; // float
    public const int m_flCloud2Direction = 0xA0; // float
    public const int m_flAmbientScale1 = 0xB0; // float
    public const int m_flAmbientScale2 = 0xB4; // float
    public const int m_flGroundScale = 0xB8; // float
    public const int m_flLightScale = 0xBC; // float
    public const int m_flFoWDarkness = 0xC0; // float
    public const int m_bEnableSeparateSkyboxFog = 0xC4; // bool
    public const int m_vFowColor = 0xC8; // Vector
    public const int m_ViewOrigin = 0xD4; // Vector
    public const int m_ViewAngles = 0xE0; // QAngle
    public const int m_flViewFoV = 0xEC; // float
    public const int m_WorldPoints = 0xF0; // Vector[8]
    public const int m_vFogOffsetLayer0 = 0x4A8; // Vector2D
    public const int m_vFogOffsetLayer1 = 0x4B0; // Vector2D
    public const int m_hEnvWind = 0x4B8; // CHandle<C_BaseEntity>
    public const int m_hEnvSky = 0x4BC; // CHandle<C_BaseEntity>
}

public static class CGlowOverlay
{
    public const int m_vPos = 0x8; // Vector
    public const int m_bDirectional = 0x14; // bool
    public const int m_vDirection = 0x18; // Vector
    public const int m_bInSky = 0x24; // bool
    public const int m_skyObstructionScale = 0x28; // float
    public const int m_Sprites = 0x30; // CGlowSprite[4]
    public const int m_nSprites = 0xB0; // int32_t
    public const int m_flProxyRadius = 0xB4; // float
    public const int m_flHDRColorScale = 0xB8; // float
    public const int m_flGlowObstructionScale = 0xBC; // float
    public const int m_bCacheGlowObstruction = 0xC0; // bool
    public const int m_bCacheSkyObstruction = 0xC1; // bool
    public const int m_bActivated = 0xC2; // int16_t
    public const int m_ListIndex = 0xC4; // uint16_t
    public const int m_queryHandle = 0xC8; // int32_t
}

public static class CGlowProperty
{
    public const int m_fGlowColor = 0x8; // Vector
    public const int m_iGlowType = 0x30; // int32_t
    public const int m_iGlowTeam = 0x34; // int32_t
    public const int m_nGlowRange = 0x38; // int32_t
    public const int m_nGlowRangeMin = 0x3C; // int32_t
    public const int m_glowColorOverride = 0x40; // Color
    public const int m_bFlashing = 0x44; // bool
    public const int m_flGlowTime = 0x48; // float
    public const int m_flGlowStartTime = 0x4C; // float
    public const int m_bEligibleForScreenHighlight = 0x50; // bool
    public const int m_bGlowing = 0x51; // bool
}

public static class CGlowSprite
{
    public const int m_vColor = 0x0; // Vector
    public const int m_flHorzSize = 0xC; // float
    public const int m_flVertSize = 0x10; // float
    public const int m_hMaterial = 0x18; // CStrongHandle<InfoForResourceTypeIMaterial2>
}

public static class CGrenadeTracer
{
    // C_BaseModelEntity
    public const int m_flTracerDuration = 0xCE0; // float
    public const int m_nType = 0xCE4; // GrenadeType_t
}

public static class CHitboxComponent
{
    // CEntityComponent
    public const int m_bvDisabledHitGroups = 0x24; // uint32_t[1]
}

public static class CHostageRescueZone
{
    // CHostageRescueZoneShim
}

public static class CHostageRescueZoneShim
{
    // C_BaseTrigger
}

public static class CInfoDynamicShadowHint
{
    // C_PointEntity
    public const int m_bDisabled = 0x540; // bool
    public const int m_flRange = 0x544; // float
    public const int m_nImportance = 0x548; // int32_t
    public const int m_nLightChoice = 0x54C; // int32_t
    public const int m_hLight = 0x550; // CHandle<C_BaseEntity>
}

public static class CInfoDynamicShadowHintBox
{
    // CInfoDynamicShadowHint
    public const int m_vBoxMins = 0x558; // Vector
    public const int m_vBoxMaxs = 0x564; // Vector
}

public static class CInfoOffscreenPanoramaTexture
{
    // C_PointEntity
    public const int m_bDisabled = 0x540; // bool
    public const int m_nResolutionX = 0x544; // int32_t
    public const int m_nResolutionY = 0x548; // int32_t
    public const int m_szLayoutFileName = 0x550; // CUtlSymbolLarge
    public const int m_RenderAttrName = 0x558; // CUtlSymbolLarge
    public const int m_TargetEntities = 0x560; // C_NetworkUtlVectorBase<CHandle<C_BaseModelEntity>>
    public const int m_nTargetChangeCount = 0x578; // int32_t
    public const int m_vecCSSClasses = 0x580; // C_NetworkUtlVectorBase<CUtlSymbolLarge>
    public const int m_bCheckCSSClasses = 0x6F8; // bool
}

public static class CInfoParticleTarget
{
    // C_PointEntity
}

public static class CInfoTarget
{
    // C_PointEntity
}

public static class CInfoWorldLayer
{
    // C_BaseEntity
    public const int m_pOutputOnEntitiesSpawned = 0x540; // CEntityIOOutput
    public const int m_worldName = 0x568; // CUtlSymbolLarge
    public const int m_layerName = 0x570; // CUtlSymbolLarge
    public const int m_bWorldLayerVisible = 0x578; // bool
    public const int m_bEntitiesSpawned = 0x579; // bool
    public const int m_bCreateAsChildSpawnGroup = 0x57A; // bool
    public const int m_hLayerSpawnGroup = 0x57C; // uint32_t
    public const int m_bWorldLayerActuallyVisible = 0x580; // bool
}

public static class CInterpolatedValue
{
    public const int m_flStartTime = 0x0; // float
    public const int m_flEndTime = 0x4; // float
    public const int m_flStartValue = 0x8; // float
    public const int m_flEndValue = 0xC; // float
    public const int m_interpType = 0x10; // int32_t
}

public static class CLightComponent
{
    // CEntityComponent
    public const int __m_pChainEntity = 0x48; // CNetworkVarChainer
    public const int m_Color = 0x85; // Color
    public const int m_SecondaryColor = 0x89; // Color
    public const int m_flBrightness = 0x90; // float
    public const int m_flBrightnessScale = 0x94; // float
    public const int m_flBrightnessMult = 0x98; // float
    public const int m_flRange = 0x9C; // float
    public const int m_flFalloff = 0xA0; // float
    public const int m_flAttenuation0 = 0xA4; // float
    public const int m_flAttenuation1 = 0xA8; // float
    public const int m_flAttenuation2 = 0xAC; // float
    public const int m_flTheta = 0xB0; // float
    public const int m_flPhi = 0xB4; // float
    public const int m_hLightCookie = 0xB8; // CStrongHandle<InfoForResourceTypeCTextureBase>
    public const int m_nCascades = 0xC0; // int32_t
    public const int m_nCastShadows = 0xC4; // int32_t
    public const int m_nShadowWidth = 0xC8; // int32_t
    public const int m_nShadowHeight = 0xCC; // int32_t
    public const int m_bRenderDiffuse = 0xD0; // bool
    public const int m_nRenderSpecular = 0xD4; // int32_t
    public const int m_bRenderTransmissive = 0xD8; // bool
    public const int m_flOrthoLightWidth = 0xDC; // float
    public const int m_flOrthoLightHeight = 0xE0; // float
    public const int m_nStyle = 0xE4; // int32_t
    public const int m_Pattern = 0xE8; // CUtlString
    public const int m_nCascadeRenderStaticObjects = 0xF0; // int32_t
    public const int m_flShadowCascadeCrossFade = 0xF4; // float
    public const int m_flShadowCascadeDistanceFade = 0xF8; // float
    public const int m_flShadowCascadeDistance0 = 0xFC; // float
    public const int m_flShadowCascadeDistance1 = 0x100; // float
    public const int m_flShadowCascadeDistance2 = 0x104; // float
    public const int m_flShadowCascadeDistance3 = 0x108; // float
    public const int m_nShadowCascadeResolution0 = 0x10C; // int32_t
    public const int m_nShadowCascadeResolution1 = 0x110; // int32_t
    public const int m_nShadowCascadeResolution2 = 0x114; // int32_t
    public const int m_nShadowCascadeResolution3 = 0x118; // int32_t
    public const int m_bUsesBakedShadowing = 0x11C; // bool
    public const int m_nShadowPriority = 0x120; // int32_t
    public const int m_nBakedShadowIndex = 0x124; // int32_t
    public const int m_bRenderToCubemaps = 0x128; // bool
    public const int m_nDirectLight = 0x12C; // int32_t
    public const int m_nIndirectLight = 0x130; // int32_t
    public const int m_flFadeMinDist = 0x134; // float
    public const int m_flFadeMaxDist = 0x138; // float
    public const int m_flShadowFadeMinDist = 0x13C; // float
    public const int m_flShadowFadeMaxDist = 0x140; // float
    public const int m_bEnabled = 0x144; // bool
    public const int m_bFlicker = 0x145; // bool
    public const int m_bPrecomputedFieldsValid = 0x146; // bool
    public const int m_vPrecomputedBoundsMins = 0x148; // Vector
    public const int m_vPrecomputedBoundsMaxs = 0x154; // Vector
    public const int m_vPrecomputedOBBOrigin = 0x160; // Vector
    public const int m_vPrecomputedOBBAngles = 0x16C; // QAngle
    public const int m_vPrecomputedOBBExtent = 0x178; // Vector
    public const int m_flPrecomputedMaxRange = 0x184; // float
    public const int m_nFogLightingMode = 0x188; // int32_t
    public const int m_flFogContributionStength = 0x18C; // float
    public const int m_flNearClipPlane = 0x190; // float
    public const int m_SkyColor = 0x194; // Color
    public const int m_flSkyIntensity = 0x198; // float
    public const int m_SkyAmbientBounce = 0x19C; // Color
    public const int m_bUseSecondaryColor = 0x1A0; // bool
    public const int m_bMixedShadows = 0x1A1; // bool
    public const int m_flLightStyleStartTime = 0x1A4; // GameTime_t
    public const int m_flCapsuleLength = 0x1A8; // float
    public const int m_flMinRoughness = 0x1AC; // float
}

public static class CLogicRelay
{
    // CLogicalEntity
    public const int m_OnTrigger = 0x540; // CEntityIOOutput
    public const int m_OnSpawn = 0x568; // CEntityIOOutput
    public const int m_bDisabled = 0x590; // bool
    public const int m_bWaitForRefire = 0x591; // bool
    public const int m_bTriggerOnce = 0x592; // bool
    public const int m_bFastRetrigger = 0x593; // bool
    public const int m_bPassthoughCaller = 0x594; // bool
}

public static class CLogicalEntity
{
    // C_BaseEntity
}

public static class CModelState
{
    public const int m_hModel = 0xA0; // CStrongHandle<InfoForResourceTypeCModel>
    public const int m_ModelName = 0xA8; // CUtlSymbolLarge
    public const int m_bClientClothCreationSuppressed = 0xE8; // bool
    public const int m_MeshGroupMask = 0x180; // uint64_t
    public const int m_nIdealMotionType = 0x222; // int8_t
    public const int m_nForceLOD = 0x223; // int8_t
    public const int m_nClothUpdateFlags = 0x224; // int8_t
}

public static class CNetworkedSequenceOperation
{
    public const int m_hSequence = 0x8; // HSequence
    public const int m_flPrevCycle = 0xC; // float
    public const int m_flCycle = 0x10; // float
    public const int m_flWeight = 0x14; // CNetworkedQuantizedFloat
    public const int m_bSequenceChangeNetworked = 0x1C; // bool
    public const int m_bDiscontinuity = 0x1D; // bool
    public const int m_flPrevCycleFromDiscontinuity = 0x20; // float
    public const int m_flPrevCycleForAnimEventDetection = 0x24; // float
}

public static class CPlayerSprayDecalRenderHelper
{
}

public static class CPlayer_AutoaimServices
{
    // CPlayerPawnComponent
}

public static class CPlayer_CameraServices
{
    // CPlayerPawnComponent
    public const int m_vecCsViewPunchAngle = 0x40; // QAngle
    public const int m_nCsViewPunchAngleTick = 0x4C; // GameTick_t
    public const int m_flCsViewPunchAngleTickRatio = 0x50; // float
    public const int m_PlayerFog = 0x58; // C_fogplayerparams_t
    public const int m_hColorCorrectionCtrl = 0x98; // CHandle<C_ColorCorrection>
    public const int m_hViewEntity = 0x9C; // CHandle<C_BaseEntity>
    public const int m_hTonemapController = 0xA0; // CHandle<C_TonemapController2>
    public const int m_audio = 0xA8; // audioparams_t
    public const int m_PostProcessingVolumes = 0x120; // C_NetworkUtlVectorBase<CHandle<C_PostProcessingVolume>>
    public const int m_flOldPlayerZ = 0x138; // float
    public const int m_flOldPlayerViewOffsetZ = 0x13C; // float
    public const int m_CurrentFog = 0x140; // fogparams_t
    public const int m_hOldFogController = 0x1A8; // CHandle<C_FogController>
    public const int m_bOverrideFogColor = 0x1AC; // bool[5]
    public const int m_OverrideFogColor = 0x1B1; // Color[5]
    public const int m_bOverrideFogStartEnd = 0x1C5; // bool[5]
    public const int m_fOverrideFogStart = 0x1CC; // float[5]
    public const int m_fOverrideFogEnd = 0x1E0; // float[5]
    public const int m_hActivePostProcessingVolume = 0x1F4; // CHandle<C_PostProcessingVolume>
    public const int m_angDemoViewAngles = 0x1F8; // QAngle
}

public static class CPlayer_FlashlightServices
{
    // CPlayerPawnComponent
}

public static class CPlayer_ItemServices
{
    // CPlayerPawnComponent
}

public static class CPlayer_MovementServices
{
    // CPlayerPawnComponent
    public const int m_nImpulse = 0x40; // int32_t
    public const int m_nButtons = 0x48; // CInButtonState
    public const int m_nQueuedButtonDownMask = 0x68; // uint64_t
    public const int m_nQueuedButtonChangeMask = 0x70; // uint64_t
    public const int m_nButtonDoublePressed = 0x78; // uint64_t
    public const int m_pButtonPressedCmdNumber = 0x80; // uint32_t[64]
    public const int m_nLastCommandNumberProcessed = 0x180; // uint32_t
    public const int m_nToggleButtonDownMask = 0x188; // uint64_t
    public const int m_flMaxspeed = 0x190; // float
    public const int m_arrForceSubtickMoveWhen = 0x194; // float[4]
    public const int m_flForwardMove = 0x1A4; // float
    public const int m_flLeftMove = 0x1A8; // float
    public const int m_flUpMove = 0x1AC; // float
    public const int m_vecLastMovementImpulses = 0x1B0; // Vector
    public const int m_vecOldViewAngles = 0x1BC; // QAngle
}

public static class CPlayer_MovementServices_Humanoid
{
    // CPlayer_MovementServices
    public const int m_flStepSoundTime = 0x1D0; // float
    public const int m_flFallVelocity = 0x1D4; // float
    public const int m_bInCrouch = 0x1D8; // bool
    public const int m_nCrouchState = 0x1DC; // uint32_t
    public const int m_flCrouchTransitionStartTime = 0x1E0; // GameTime_t
    public const int m_bDucked = 0x1E4; // bool
    public const int m_bDucking = 0x1E5; // bool
    public const int m_bInDuckJump = 0x1E6; // bool
    public const int m_groundNormal = 0x1E8; // Vector
    public const int m_flSurfaceFriction = 0x1F4; // float
    public const int m_surfaceProps = 0x1F8; // CUtlStringToken
    public const int m_nStepside = 0x208; // int32_t
}

public static class CPlayer_ObserverServices
{
    // CPlayerPawnComponent
    public const int m_iObserverMode = 0x40; // uint8_t
    public const int m_hObserverTarget = 0x44; // CHandle<C_BaseEntity>
    public const int m_iObserverLastMode = 0x48; // ObserverMode_t
    public const int m_bForcedObserverMode = 0x4C; // bool
    public const int m_flObserverChaseDistance = 0x50; // float
    public const int m_flObserverChaseDistanceCalcTime = 0x54; // GameTime_t
}

public static class CPlayer_UseServices
{
    // CPlayerPawnComponent
}

public static class CPlayer_ViewModelServices
{
    // CPlayerPawnComponent
}

public static class CPlayer_WaterServices
{
    // CPlayerPawnComponent
}

public static class CPlayer_WeaponServices
{
    // CPlayerPawnComponent
    public const int m_bAllowSwitchToNoWeapon = 0x40; // bool
    public const int m_hMyWeapons = 0x48; // C_NetworkUtlVectorBase<CHandle<C_BasePlayerWeapon>>
    public const int m_hActiveWeapon = 0x60; // CHandle<C_BasePlayerWeapon>
    public const int m_hLastWeapon = 0x64; // CHandle<C_BasePlayerWeapon>
    public const int m_iAmmo = 0x68; // uint16_t[32]
}

public static class CPointOffScreenIndicatorUi
{
    // C_PointClientUIWorldPanel
    public const int m_bBeenEnabled = 0xF20; // bool
    public const int m_bHide = 0xF21; // bool
    public const int m_flSeenTargetTime = 0xF24; // float
    public const int m_pTargetPanel = 0xF28; // C_PointClientUIWorldPanel*
}

public static class CPointTemplate
{
    // CLogicalEntity
    public const int m_iszWorldName = 0x540; // CUtlSymbolLarge
    public const int m_iszSource2EntityLumpName = 0x548; // CUtlSymbolLarge
    public const int m_iszEntityFilterName = 0x550; // CUtlSymbolLarge
    public const int m_flTimeoutInterval = 0x558; // float
    public const int m_bAsynchronouslySpawnEntities = 0x55C; // bool
    public const int m_pOutputOnSpawned = 0x560; // CEntityIOOutput
    public const int m_clientOnlyEntityBehavior = 0x588; // PointTemplateClientOnlyEntityBehavior_t
    public const int m_ownerSpawnGroupType = 0x58C; // PointTemplateOwnerSpawnGroupType_t
    public const int m_createdSpawnGroupHandles = 0x590; // CUtlVector<uint32_t>
    public const int m_SpawnedEntityHandles = 0x5A8; // CUtlVector<CEntityHandle>
    public const int m_ScriptSpawnCallback = 0x5C0; // HSCRIPT
    public const int m_ScriptCallbackScope = 0x5C8; // HSCRIPT
}

public static class CPrecipitationVData
{
    // CEntitySubclassVDataBase
    public const int
        m_szParticlePrecipitationEffect =
            0x28; // CResourceNameTyped<CWeakHandle<InfoForResourceTypeIParticleSystemDefinition>>

    public const int m_flInnerDistance = 0x108; // float
    public const int m_nAttachType = 0x10C; // ParticleAttachment_t
    public const int m_bBatchSameVolumeType = 0x110; // bool
    public const int m_nRTEnvCP = 0x114; // int32_t
    public const int m_nRTEnvCPComponent = 0x118; // int32_t
    public const int m_szModifier = 0x120; // CUtlString
}

public static class CProjectedTextureBase
{
    public const int m_hTargetEntity = 0xC; // CHandle<C_BaseEntity>
    public const int m_bState = 0x10; // bool
    public const int m_bAlwaysUpdate = 0x11; // bool
    public const int m_flLightFOV = 0x14; // float
    public const int m_bEnableShadows = 0x18; // bool
    public const int m_bSimpleProjection = 0x19; // bool
    public const int m_bLightOnlyTarget = 0x1A; // bool
    public const int m_bLightWorld = 0x1B; // bool
    public const int m_bCameraSpace = 0x1C; // bool
    public const int m_flBrightnessScale = 0x20; // float
    public const int m_LightColor = 0x24; // Color
    public const int m_flIntensity = 0x28; // float
    public const int m_flLinearAttenuation = 0x2C; // float
    public const int m_flQuadraticAttenuation = 0x30; // float
    public const int m_bVolumetric = 0x34; // bool
    public const int m_flVolumetricIntensity = 0x38; // float
    public const int m_flNoiseStrength = 0x3C; // float
    public const int m_flFlashlightTime = 0x40; // float
    public const int m_nNumPlanes = 0x44; // uint32_t
    public const int m_flPlaneOffset = 0x48; // float
    public const int m_flColorTransitionTime = 0x4C; // float
    public const int m_flAmbient = 0x50; // float
    public const int m_SpotlightTextureName = 0x54; // char[512]
    public const int m_nSpotlightTextureFrame = 0x254; // int32_t
    public const int m_nShadowQuality = 0x258; // uint32_t
    public const int m_flNearZ = 0x25C; // float
    public const int m_flFarZ = 0x260; // float
    public const int m_flProjectionSize = 0x264; // float
    public const int m_flRotation = 0x268; // float
    public const int m_bFlipHorizontal = 0x26C; // bool
}

public static class CRenderComponent
{
    // CEntityComponent
    public const int __m_pChainEntity = 0x10; // CNetworkVarChainer
    public const int m_bIsRenderingWithViewModels = 0x50; // bool
    public const int m_nSplitscreenFlags = 0x54; // uint32_t
    public const int m_bEnableRendering = 0x60; // bool
    public const int m_bInterpolationReadyToDraw = 0xB0; // bool
}

public static class CSMatchStats_t
{
    // CSPerRoundStats_t
    public const int m_iEnemy5Ks = 0x68; // int32_t
    public const int m_iEnemy4Ks = 0x6C; // int32_t
    public const int m_iEnemy3Ks = 0x70; // int32_t
}

public static class CSPerRoundStats_t
{
    public const int m_iKills = 0x30; // int32_t
    public const int m_iDeaths = 0x34; // int32_t
    public const int m_iAssists = 0x38; // int32_t
    public const int m_iDamage = 0x3C; // int32_t
    public const int m_iEquipmentValue = 0x40; // int32_t
    public const int m_iMoneySaved = 0x44; // int32_t
    public const int m_iKillReward = 0x48; // int32_t
    public const int m_iLiveTime = 0x4C; // int32_t
    public const int m_iHeadShotKills = 0x50; // int32_t
    public const int m_iObjective = 0x54; // int32_t
    public const int m_iCashEarned = 0x58; // int32_t
    public const int m_iUtilityDamage = 0x5C; // int32_t
    public const int m_iEnemiesFlashed = 0x60; // int32_t
}

public static class CScriptComponent
{
    // CEntityComponent
    public const int m_scriptClassName = 0x30; // CUtlSymbolLarge
}

public static class CServerOnlyModelEntity
{
    // C_BaseModelEntity
}

public static class CSkeletonInstance
{
    // CGameSceneNode
    public const int m_modelState = 0x160; // CModelState
    public const int m_bIsAnimationEnabled = 0x390; // bool
    public const int m_bUseParentRenderBounds = 0x391; // bool
    public const int m_bDisableSolidCollisionsForHierarchy = 0x392; // bool
    public const int m_bDirtyMotionType = 0x0; // bitfield:1
    public const int m_bIsGeneratingLatchedParentSpaceState = 0x0; // bitfield:1
    public const int m_materialGroup = 0x394; // CUtlStringToken
    public const int m_nHitboxSet = 0x398; // uint8_t
}

public static class CSkyboxReference
{
    // C_BaseEntity
    public const int m_worldGroupId = 0x540; // WorldGroupId_t
    public const int m_hSkyCamera = 0x544; // CHandle<C_SkyCamera>
}

public static class CTablet
{
    // C_CSWeaponBase
}

public static class CTimeline
{
    // IntervalTimer
    public const int m_flValues = 0x10; // float[64]
    public const int m_nValueCounts = 0x110; // int32_t[64]
    public const int m_nBucketCount = 0x210; // int32_t
    public const int m_flInterval = 0x214; // float
    public const int m_flFinalValue = 0x218; // float
    public const int m_nCompressionType = 0x21C; // TimelineCompression_t
    public const int m_bStopped = 0x220; // bool
}

public static class CTripWireFire
{
    // C_BaseCSGrenade
}

public static class CTripWireFireProjectile
{
    // C_BaseGrenade
}

public static class CWaterSplasher
{
    // C_BaseModelEntity
}

public static class CWeaponZoneRepulsor
{
    // C_CSWeaponBaseGun
}

public static class C_AK47
{
    // C_CSWeaponBaseGun
}

public static class C_AttributeContainer
{
    // CAttributeManager
    public const int m_Item = 0x50; // C_EconItemView
    public const int m_iExternalItemProviderRegisteredToken = 0x498; // int32_t
    public const int m_ullRegisteredAsItemID = 0x4A0; // uint64_t
}

public static class C_BarnLight
{
    // C_BaseModelEntity
    public const int m_bEnabled = 0xCC0; // bool
    public const int m_nColorMode = 0xCC4; // int32_t
    public const int m_Color = 0xCC8; // Color
    public const int m_flColorTemperature = 0xCCC; // float
    public const int m_flBrightness = 0xCD0; // float
    public const int m_flBrightnessScale = 0xCD4; // float
    public const int m_nDirectLight = 0xCD8; // int32_t
    public const int m_nBakedShadowIndex = 0xCDC; // int32_t
    public const int m_nLuminaireShape = 0xCE0; // int32_t
    public const int m_flLuminaireSize = 0xCE4; // float
    public const int m_flLuminaireAnisotropy = 0xCE8; // float
    public const int m_LightStyleString = 0xCF0; // CUtlString
    public const int m_flLightStyleStartTime = 0xCF8; // GameTime_t
    public const int m_QueuedLightStyleStrings = 0xD00; // C_NetworkUtlVectorBase<CUtlString>
    public const int m_LightStyleEvents = 0xD18; // C_NetworkUtlVectorBase<CUtlString>
    public const int m_LightStyleTargets = 0xD30; // C_NetworkUtlVectorBase<CHandle<C_BaseModelEntity>>
    public const int m_StyleEvent = 0xD48; // CEntityIOOutput[4]
    public const int m_hLightCookie = 0xDE8; // CStrongHandle<InfoForResourceTypeCTextureBase>
    public const int m_flShape = 0xDF0; // float
    public const int m_flSoftX = 0xDF4; // float
    public const int m_flSoftY = 0xDF8; // float
    public const int m_flSkirt = 0xDFC; // float
    public const int m_flSkirtNear = 0xE00; // float
    public const int m_vSizeParams = 0xE04; // Vector
    public const int m_flRange = 0xE10; // float
    public const int m_vShear = 0xE14; // Vector
    public const int m_nBakeSpecularToCubemaps = 0xE20; // int32_t
    public const int m_vBakeSpecularToCubemapsSize = 0xE24; // Vector
    public const int m_nCastShadows = 0xE30; // int32_t
    public const int m_nShadowMapSize = 0xE34; // int32_t
    public const int m_nShadowPriority = 0xE38; // int32_t
    public const int m_bContactShadow = 0xE3C; // bool
    public const int m_nBounceLight = 0xE40; // int32_t
    public const int m_flBounceScale = 0xE44; // float
    public const int m_flMinRoughness = 0xE48; // float
    public const int m_vAlternateColor = 0xE4C; // Vector
    public const int m_fAlternateColorBrightness = 0xE58; // float
    public const int m_nFog = 0xE5C; // int32_t
    public const int m_flFogStrength = 0xE60; // float
    public const int m_nFogShadows = 0xE64; // int32_t
    public const int m_flFogScale = 0xE68; // float
    public const int m_flFadeSizeStart = 0xE6C; // float
    public const int m_flFadeSizeEnd = 0xE70; // float
    public const int m_flShadowFadeSizeStart = 0xE74; // float
    public const int m_flShadowFadeSizeEnd = 0xE78; // float
    public const int m_bPrecomputedFieldsValid = 0xE7C; // bool
    public const int m_vPrecomputedBoundsMins = 0xE80; // Vector
    public const int m_vPrecomputedBoundsMaxs = 0xE8C; // Vector
    public const int m_vPrecomputedOBBOrigin = 0xE98; // Vector
    public const int m_vPrecomputedOBBAngles = 0xEA4; // QAngle
    public const int m_vPrecomputedOBBExtent = 0xEB0; // Vector
}

public static class C_BaseButton
{
    // C_BaseToggle
    public const int m_glowEntity = 0xCC0; // CHandle<C_BaseModelEntity>
    public const int m_usable = 0xCC4; // bool
    public const int m_szDisplayText = 0xCC8; // CUtlSymbolLarge
}

public static class C_BaseCSGrenade
{
    // C_CSWeaponBase
    public const int m_bClientPredictDelete = 0x19F0; // bool
    public const int m_bRedraw = 0x19F1; // bool
    public const int m_bIsHeldByPlayer = 0x19F2; // bool
    public const int m_bPinPulled = 0x19F3; // bool
    public const int m_bJumpThrow = 0x19F4; // bool
    public const int m_eThrowStatus = 0x19F8; // EGrenadeThrowState
    public const int m_fThrowTime = 0x19FC; // GameTime_t
    public const int m_flThrowStrength = 0x1A00; // float
    public const int m_flThrowStrengthApproach = 0x1A04; // float
    public const int m_fDropTime = 0x1A08; // GameTime_t
}

public static class C_BaseCSGrenadeProjectile
{
    // C_BaseGrenade
    public const int m_vInitialPosition = 0x1068; // Vector
    public const int m_vInitialVelocity = 0x1074; // Vector
    public const int m_nBounces = 0x1080; // int32_t
    public const int m_nExplodeEffectIndex = 0x1088; // CStrongHandle<InfoForResourceTypeIParticleSystemDefinition>
    public const int m_nExplodeEffectTickBegin = 0x1090; // int32_t
    public const int m_vecExplodeEffectOrigin = 0x1094; // Vector
    public const int m_flSpawnTime = 0x10A0; // GameTime_t
    public const int vecLastTrailLinePos = 0x10A4; // Vector
    public const int flNextTrailLineTime = 0x10B0; // GameTime_t
    public const int m_bExplodeEffectBegan = 0x10B4; // bool
    public const int m_bCanCreateGrenadeTrail = 0x10B5; // bool
    public const int m_nSnapshotTrajectoryEffectIndex = 0x10B8; // ParticleIndex_t

    public const int
        m_hSnapshotTrajectoryParticleSnapshot = 0x10C0; // CStrongHandle<InfoForResourceTypeIParticleSnapshot>

    public const int m_arrTrajectoryTrailPoints = 0x10C8; // CUtlVector<Vector>
    public const int m_arrTrajectoryTrailPointCreationTimes = 0x10E0; // CUtlVector<float>
    public const int m_flTrajectoryTrailEffectCreationTime = 0x10F8; // float
}

public static class C_BaseClientUIEntity
{
    // C_BaseModelEntity
    public const int m_bEnabled = 0xCC8; // bool
    public const int m_DialogXMLName = 0xCD0; // CUtlSymbolLarge
    public const int m_PanelClassName = 0xCD8; // CUtlSymbolLarge
    public const int m_PanelID = 0xCE0; // CUtlSymbolLarge
}

public static class C_BaseCombatCharacter
{
    // C_BaseFlex
    public const int m_hMyWearables = 0x1018; // C_NetworkUtlVectorBase<CHandle<C_EconWearable>>
    public const int m_bloodColor = 0x1030; // int32_t
    public const int m_leftFootAttachment = 0x1034; // AttachmentHandle_t
    public const int m_rightFootAttachment = 0x1035; // AttachmentHandle_t
    public const int m_nWaterWakeMode = 0x1038; // C_BaseCombatCharacter::WaterWakeMode_t
    public const int m_flWaterWorldZ = 0x103C; // float
    public const int m_flWaterNextTraceTime = 0x1040; // float
    public const int m_flFieldOfView = 0x1044; // float
}

public static class C_BaseDoor
{
    // C_BaseToggle
    public const int m_bIsUsable = 0xCC0; // bool
}

public static class C_BaseEntity
{
    // CEntityInstance
    public const int m_CBodyComponent = 0x30; // CBodyComponent*
    public const int m_NetworkTransmitComponent = 0x38; // CNetworkTransmitComponent
    public const int m_nLastThinkTick = 0x308; // GameTick_t
    public const int m_pGameSceneNode = 0x310; // CGameSceneNode*
    public const int m_pRenderComponent = 0x318; // CRenderComponent*
    public const int m_pCollision = 0x320; // CCollisionProperty*
    public const int m_iMaxHealth = 0x328; // int32_t
    public const int m_iHealth = 0x32C; // int32_t
    public const int m_lifeState = 0x330; // uint8_t
    public const int m_bTakesDamage = 0x331; // bool
    public const int m_nTakeDamageFlags = 0x334; // TakeDamageFlags_t
    public const int m_ubInterpolationFrame = 0x338; // uint8_t
    public const int m_hSceneObjectController = 0x33C; // CHandle<C_BaseEntity>
    public const int m_nNoInterpolationTick = 0x340; // int32_t
    public const int m_nVisibilityNoInterpolationTick = 0x344; // int32_t
    public const int m_flProxyRandomValue = 0x348; // float
    public const int m_iEFlags = 0x34C; // int32_t
    public const int m_nWaterType = 0x350; // uint8_t
    public const int m_bInterpolateEvenWithNoModel = 0x351; // bool
    public const int m_bPredictionEligible = 0x352; // bool
    public const int m_bApplyLayerMatchIDToModel = 0x353; // bool
    public const int m_tokLayerMatchID = 0x354; // CUtlStringToken
    public const int m_nSubclassID = 0x358; // CUtlStringToken
    public const int m_nSimulationTick = 0x368; // int32_t
    public const int m_iCurrentThinkContext = 0x36C; // int32_t
    public const int m_aThinkFunctions = 0x370; // CUtlVector<thinkfunc_t>
    public const int m_flAnimTime = 0x388; // float
    public const int m_flSimulationTime = 0x38C; // float
    public const int m_nSceneObjectOverrideFlags = 0x390; // uint8_t
    public const int m_bHasSuccessfullyInterpolated = 0x391; // bool
    public const int m_bHasAddedVarsToInterpolation = 0x392; // bool
    public const int m_bRenderEvenWhenNotSuccessfullyInterpolated = 0x393; // bool
    public const int m_interpolationLatchDirtyFlags = 0x394; // int32_t[2]
    public const int m_ListEntry = 0x39C; // uint16_t[11]
    public const int m_flCreateTime = 0x3B4; // GameTime_t
    public const int m_flSpeed = 0x3B8; // float
    public const int m_EntClientFlags = 0x3BC; // uint16_t
    public const int m_bClientSideRagdoll = 0x3BE; // bool
    public const int m_iTeamNum = 0x3BF; // uint8_t
    public const int m_spawnflags = 0x3C0; // uint32_t
    public const int m_nNextThinkTick = 0x3C4; // GameTick_t
    public const int m_fFlags = 0x3C8; // uint32_t
    public const int m_vecAbsVelocity = 0x3CC; // Vector
    public const int m_vecVelocity = 0x3D8; // CNetworkVelocityVector
    public const int m_vecBaseVelocity = 0x408; // Vector
    public const int m_hEffectEntity = 0x414; // CHandle<C_BaseEntity>
    public const int m_hOwnerEntity = 0x418; // CHandle<C_BaseEntity>
    public const int m_MoveCollide = 0x41C; // MoveCollide_t
    public const int m_MoveType = 0x41D; // MoveType_t
    public const int m_flWaterLevel = 0x420; // float
    public const int m_fEffects = 0x424; // uint32_t
    public const int m_hGroundEntity = 0x428; // CHandle<C_BaseEntity>
    public const int m_flFriction = 0x42C; // float
    public const int m_flElasticity = 0x430; // float
    public const int m_flGravityScale = 0x434; // float
    public const int m_flTimeScale = 0x438; // float
    public const int m_bSimulatedEveryTick = 0x43C; // bool
    public const int m_bAnimatedEveryTick = 0x43D; // bool
    public const int m_flNavIgnoreUntilTime = 0x440; // GameTime_t
    public const int m_hThink = 0x444; // uint16_t
    public const int m_fBBoxVisFlags = 0x450; // uint8_t
    public const int m_bPredictable = 0x451; // bool
    public const int m_bRenderWithViewModels = 0x452; // bool
    public const int m_nSplitUserPlayerPredictionSlot = 0x454; // CSplitScreenSlot
    public const int m_nFirstPredictableCommand = 0x458; // int32_t
    public const int m_nLastPredictableCommand = 0x45C; // int32_t
    public const int m_hOldMoveParent = 0x460; // CHandle<C_BaseEntity>
    public const int m_Particles = 0x468; // CParticleProperty
    public const int m_vecPredictedScriptFloats = 0x490; // CUtlVector<float>
    public const int m_vecPredictedScriptFloatIDs = 0x4A8; // CUtlVector<int32_t>
    public const int m_nNextScriptVarRecordID = 0x4D8; // int32_t
    public const int m_vecAngVelocity = 0x4E8; // QAngle
    public const int m_DataChangeEventRef = 0x4F4; // int32_t
    public const int m_dependencies = 0x4F8; // CUtlVector<CEntityHandle>
    public const int m_nCreationTick = 0x510; // int32_t
    public const int m_bAnimTimeChanged = 0x529; // bool
    public const int m_bSimulationTimeChanged = 0x52A; // bool
    public const int m_sUniqueHammerID = 0x538; // CUtlString
}

public static class C_BaseFire
{
    // C_BaseEntity
    public const int m_flScale = 0x540; // float
    public const int m_flStartScale = 0x544; // float
    public const int m_flScaleTime = 0x548; // float
    public const int m_nFlags = 0x54C; // uint32_t
}

public static class C_BaseFlex
{
    // CBaseAnimGraph
    public const int m_flexWeight = 0xE90; // C_NetworkUtlVectorBase<float>
    public const int m_vLookTargetPosition = 0xEA8; // Vector
    public const int m_blinktoggle = 0xEC0; // bool
    public const int m_nLastFlexUpdateFrameCount = 0xF20; // int32_t
    public const int m_CachedViewTarget = 0xF24; // Vector
    public const int m_nNextSceneEventId = 0xF30; // uint32_t
    public const int m_iBlink = 0xF34; // int32_t
    public const int m_blinktime = 0xF38; // float
    public const int m_prevblinktoggle = 0xF3C; // bool
    public const int m_iJawOpen = 0xF40; // int32_t
    public const int m_flJawOpenAmount = 0xF44; // float
    public const int m_flBlinkAmount = 0xF48; // float
    public const int m_iMouthAttachment = 0xF4C; // AttachmentHandle_t
    public const int m_iEyeAttachment = 0xF4D; // AttachmentHandle_t
    public const int m_bResetFlexWeightsOnModelChange = 0xF4E; // bool
    public const int m_nEyeOcclusionRendererBone = 0xF68; // int32_t
    public const int m_mEyeOcclusionRendererCameraToBoneTransform = 0xF6C; // matrix3x4_t
    public const int m_vEyeOcclusionRendererHalfExtent = 0xF9C; // Vector
    public const int m_PhonemeClasses = 0xFB8; // C_BaseFlex::Emphasized_Phoneme[3]
}

public static class C_BaseFlex_Emphasized_Phoneme
{
    public const int m_sClassName = 0x0; // CUtlString
    public const int m_flAmount = 0x18; // float
    public const int m_bRequired = 0x1C; // bool
    public const int m_bBasechecked = 0x1D; // bool
    public const int m_bValid = 0x1E; // bool
}

public static class C_BaseGrenade
{
    // C_BaseFlex
    public const int m_bHasWarnedAI = 0x1018; // bool
    public const int m_bIsSmokeGrenade = 0x1019; // bool
    public const int m_bIsLive = 0x101A; // bool
    public const int m_DmgRadius = 0x101C; // float
    public const int m_flDetonateTime = 0x1020; // GameTime_t
    public const int m_flWarnAITime = 0x1024; // float
    public const int m_flDamage = 0x1028; // float
    public const int m_iszBounceSound = 0x1030; // CUtlSymbolLarge
    public const int m_ExplosionSound = 0x1038; // CUtlString
    public const int m_hThrower = 0x1044; // CHandle<C_CSPlayerPawn>
    public const int m_flNextAttack = 0x105C; // GameTime_t
    public const int m_hOriginalThrower = 0x1060; // CHandle<C_CSPlayerPawn>
}

public static class C_BaseModelEntity
{
    // C_BaseEntity
    public const int m_CRenderComponent = 0xA10; // CRenderComponent*
    public const int m_CHitboxComponent = 0xA18; // CHitboxComponent
    public const int m_bInitModelEffects = 0xA60; // bool
    public const int m_bIsStaticProp = 0xA61; // bool
    public const int m_nLastAddDecal = 0xA64; // int32_t
    public const int m_nDecalsAdded = 0xA68; // int32_t
    public const int m_iOldHealth = 0xA6C; // int32_t
    public const int m_nRenderMode = 0xA70; // RenderMode_t
    public const int m_nRenderFX = 0xA71; // RenderFx_t
    public const int m_bAllowFadeInView = 0xA72; // bool
    public const int m_clrRender = 0xA73; // Color
    public const int m_vecRenderAttributes = 0xA78; // C_UtlVectorEmbeddedNetworkVar<EntityRenderAttribute_t>
    public const int m_bRenderToCubemaps = 0xAE0; // bool
    public const int m_Collision = 0xAE8; // CCollisionProperty
    public const int m_Glow = 0xB98; // CGlowProperty
    public const int m_flGlowBackfaceMult = 0xBF0; // float
    public const int m_fadeMinDist = 0xBF4; // float
    public const int m_fadeMaxDist = 0xBF8; // float
    public const int m_flFadeScale = 0xBFC; // float
    public const int m_flShadowStrength = 0xC00; // float
    public const int m_nObjectCulling = 0xC04; // uint8_t
    public const int m_nAddDecal = 0xC08; // int32_t
    public const int m_vDecalPosition = 0xC0C; // Vector
    public const int m_vDecalForwardAxis = 0xC18; // Vector
    public const int m_flDecalHealBloodRate = 0xC24; // float
    public const int m_flDecalHealHeightRate = 0xC28; // float

    public const int
        m_ConfigEntitiesToPropagateMaterialDecalsTo = 0xC30; // C_NetworkUtlVectorBase<CHandle<C_BaseModelEntity>>

    public const int m_vecViewOffset = 0xC48; // CNetworkViewOffsetVector
    public const int m_pClientAlphaProperty = 0xC78; // CClientAlphaProperty*
    public const int m_ClientOverrideTint = 0xC80; // Color
    public const int m_bUseClientOverrideTint = 0xC84; // bool
}

public static class C_BasePlayerPawn
{
    // C_BaseCombatCharacter
    public const int m_pWeaponServices = 0x10A8; // CPlayer_WeaponServices*
    public const int m_pItemServices = 0x10B0; // CPlayer_ItemServices*
    public const int m_pAutoaimServices = 0x10B8; // CPlayer_AutoaimServices*
    public const int m_pObserverServices = 0x10C0; // CPlayer_ObserverServices*
    public const int m_pWaterServices = 0x10C8; // CPlayer_WaterServices*
    public const int m_pUseServices = 0x10D0; // CPlayer_UseServices*
    public const int m_pFlashlightServices = 0x10D8; // CPlayer_FlashlightServices*
    public const int m_pCameraServices = 0x10E0; // CPlayer_CameraServices*
    public const int m_pMovementServices = 0x10E8; // CPlayer_MovementServices*
    public const int m_ServerViewAngleChanges = 0x10F8; // C_UtlVectorEmbeddedNetworkVar<ViewAngleServerChange_t>
    public const int m_nHighestConsumedServerViewAngleChangeIndex = 0x1148; // uint32_t
    public const int v_angle = 0x114C; // QAngle
    public const int v_anglePrevious = 0x1158; // QAngle
    public const int m_iHideHUD = 0x1164; // uint32_t
    public const int m_skybox3d = 0x1168; // sky3dparams_t
    public const int m_flDeathTime = 0x11F8; // GameTime_t
    public const int m_vecPredictionError = 0x11FC; // Vector
    public const int m_flPredictionErrorTime = 0x1208; // GameTime_t
    public const int m_vecLastCameraSetupLocalOrigin = 0x120C; // Vector
    public const int m_flLastCameraSetupTime = 0x1218; // GameTime_t
    public const int m_flFOVSensitivityAdjust = 0x121C; // float
    public const int m_flMouseSensitivity = 0x1220; // float
    public const int m_vOldOrigin = 0x1224; // Vector
    public const int m_flOldSimulationTime = 0x1230; // float
    public const int m_nLastExecutedCommandNumber = 0x1234; // int32_t
    public const int m_nLastExecutedCommandTick = 0x1238; // int32_t
    public const int m_hController = 0x123C; // CHandle<CBasePlayerController>
    public const int m_bIsSwappingToPredictableController = 0x1240; // bool
}

public static class C_BasePlayerWeapon
{
    // C_EconEntity
    public const int m_nNextPrimaryAttackTick = 0x1560; // GameTick_t
    public const int m_flNextPrimaryAttackTickRatio = 0x1564; // float
    public const int m_nNextSecondaryAttackTick = 0x1568; // GameTick_t
    public const int m_flNextSecondaryAttackTickRatio = 0x156C; // float
    public const int m_iClip1 = 0x1570; // int32_t
    public const int m_iClip2 = 0x1574; // int32_t
    public const int m_pReserveAmmo = 0x1578; // int32_t[2]
}

public static class C_BasePropDoor
{
    // C_DynamicProp
    public const int m_eDoorState = 0x10F8; // DoorState_t
    public const int m_modelChanged = 0x10FC; // bool
    public const int m_bLocked = 0x10FD; // bool
    public const int m_closedPosition = 0x1100; // Vector
    public const int m_closedAngles = 0x110C; // QAngle
    public const int m_hMaster = 0x1118; // CHandle<C_BasePropDoor>
    public const int m_vWhereToSetLightingOrigin = 0x111C; // Vector
}

public static class C_BaseToggle
{
    // C_BaseModelEntity
}

public static class C_BaseTrigger
{
    // C_BaseToggle
    public const int m_bDisabled = 0xCC0; // bool
    public const int m_bClientSidePredicted = 0xCC1; // bool
}

public static class C_BaseViewModel
{
    // CBaseAnimGraph
    public const int m_vecLastFacing = 0xE88; // Vector
    public const int m_nViewModelIndex = 0xE94; // uint32_t
    public const int m_nAnimationParity = 0xE98; // uint32_t
    public const int m_flAnimationStartTime = 0xE9C; // float
    public const int m_hWeapon = 0xEA0; // CHandle<C_BasePlayerWeapon>
    public const int m_sVMName = 0xEA8; // CUtlSymbolLarge
    public const int m_sAnimationPrefix = 0xEB0; // CUtlSymbolLarge
    public const int m_hWeaponModel = 0xEB8; // CHandle<C_ViewmodelWeapon>
    public const int m_iCameraAttachment = 0xEBC; // AttachmentHandle_t
    public const int m_vecLastCameraAngles = 0xEC0; // QAngle
    public const int m_previousElapsedDuration = 0xECC; // float
    public const int m_previousCycle = 0xED0; // float
    public const int m_nOldAnimationParity = 0xED4; // int32_t
    public const int m_hOldLayerSequence = 0xED8; // HSequence
    public const int m_oldLayer = 0xEDC; // int32_t
    public const int m_oldLayerStartTime = 0xEE0; // float
    public const int m_hControlPanel = 0xEE4; // CHandle<C_BaseEntity>
}

public static class C_Beam
{
    // C_BaseModelEntity
    public const int m_flFrameRate = 0xCC0; // float
    public const int m_flHDRColorScale = 0xCC4; // float
    public const int m_flFireTime = 0xCC8; // GameTime_t
    public const int m_flDamage = 0xCCC; // float
    public const int m_nNumBeamEnts = 0xCD0; // uint8_t
    public const int m_queryHandleHalo = 0xCD4; // int32_t
    public const int m_hBaseMaterial = 0xCF8; // CStrongHandle<InfoForResourceTypeIMaterial2>
    public const int m_nHaloIndex = 0xD00; // CStrongHandle<InfoForResourceTypeIMaterial2>
    public const int m_nBeamType = 0xD08; // BeamType_t
    public const int m_nBeamFlags = 0xD0C; // uint32_t
    public const int m_hAttachEntity = 0xD10; // CHandle<C_BaseEntity>[10]
    public const int m_nAttachIndex = 0xD38; // AttachmentHandle_t[10]
    public const int m_fWidth = 0xD44; // float
    public const int m_fEndWidth = 0xD48; // float
    public const int m_fFadeLength = 0xD4C; // float
    public const int m_fHaloScale = 0xD50; // float
    public const int m_fAmplitude = 0xD54; // float
    public const int m_fStartFrame = 0xD58; // float
    public const int m_fSpeed = 0xD5C; // float
    public const int m_flFrame = 0xD60; // float
    public const int m_nClipStyle = 0xD64; // BeamClipStyle_t
    public const int m_bTurnedOff = 0xD68; // bool
    public const int m_vecEndPos = 0xD6C; // Vector
    public const int m_hEndEntity = 0xD78; // CHandle<C_BaseEntity>
}

public static class C_Breakable
{
    // C_BaseModelEntity
}

public static class C_BreakableProp
{
    // CBaseProp
    public const int m_OnBreak = 0xEC8; // CEntityIOOutput
    public const int m_OnHealthChanged = 0xEF0; // CEntityOutputTemplate<float>
    public const int m_OnTakeDamage = 0xF18; // CEntityIOOutput
    public const int m_impactEnergyScale = 0xF40; // float
    public const int m_iMinHealthDmg = 0xF44; // int32_t
    public const int m_flPressureDelay = 0xF48; // float
    public const int m_hBreaker = 0xF4C; // CHandle<C_BaseEntity>
    public const int m_PerformanceMode = 0xF50; // PerformanceMode_t
    public const int m_flDmgModBullet = 0xF54; // float
    public const int m_flDmgModClub = 0xF58; // float
    public const int m_flDmgModExplosive = 0xF5C; // float
    public const int m_flDmgModFire = 0xF60; // float
    public const int m_iszPhysicsDamageTableName = 0xF68; // CUtlSymbolLarge
    public const int m_iszBasePropData = 0xF70; // CUtlSymbolLarge
    public const int m_iInteractions = 0xF78; // int32_t
    public const int m_flPreventDamageBeforeTime = 0xF7C; // GameTime_t
    public const int m_bHasBreakPiecesOrCommands = 0xF80; // bool
    public const int m_explodeDamage = 0xF84; // float
    public const int m_explodeRadius = 0xF88; // float
    public const int m_explosionDelay = 0xF90; // float
    public const int m_explosionBuildupSound = 0xF98; // CUtlSymbolLarge
    public const int m_explosionCustomEffect = 0xFA0; // CUtlSymbolLarge
    public const int m_explosionCustomSound = 0xFA8; // CUtlSymbolLarge
    public const int m_explosionModifier = 0xFB0; // CUtlSymbolLarge
    public const int m_hPhysicsAttacker = 0xFB8; // CHandle<C_BasePlayerPawn>
    public const int m_flLastPhysicsInfluenceTime = 0xFBC; // GameTime_t
    public const int m_flDefaultFadeScale = 0xFC0; // float
    public const int m_hLastAttacker = 0xFC4; // CHandle<C_BaseEntity>
    public const int m_hFlareEnt = 0xFC8; // CHandle<C_BaseEntity>
    public const int m_noGhostCollision = 0xFCC; // bool
}

public static class C_BulletHitModel
{
    // CBaseAnimGraph
    public const int m_matLocal = 0xE80; // matrix3x4_t
    public const int m_iBoneIndex = 0xEB0; // int32_t
    public const int m_hPlayerParent = 0xEB4; // CHandle<C_BaseEntity>
    public const int m_bIsHit = 0xEB8; // bool
    public const int m_flTimeCreated = 0xEBC; // float
    public const int m_vecStartPos = 0xEC0; // Vector
}

public static class C_C4
{
    // C_CSWeaponBase
    public const int m_szScreenText = 0x19F0; // char[32]
    public const int m_activeLightParticleIndex = 0x1A10; // ParticleIndex_t
    public const int m_eActiveLightEffect = 0x1A14; // C4LightEffect_t
    public const int m_bStartedArming = 0x1A18; // bool
    public const int m_fArmedTime = 0x1A1C; // GameTime_t
    public const int m_bBombPlacedAnimation = 0x1A20; // bool
    public const int m_bIsPlantingViaUse = 0x1A21; // bool
    public const int m_entitySpottedState = 0x1A28; // EntitySpottedState_t
    public const int m_nSpotRules = 0x1A40; // int32_t
    public const int m_bPlayedArmingBeeps = 0x1A44; // bool[7]
    public const int m_bBombPlanted = 0x1A4B; // bool
    public const int m_bDroppedFromDeath = 0x1A4C; // bool
}

public static class C_CSGOViewModel
{
    // C_PredictedViewModel
    public const int m_bShouldIgnoreOffsetAndAccuracy = 0xF10; // bool
    public const int m_nWeaponParity = 0xF14; // uint32_t
    public const int m_nOldWeaponParity = 0xF18; // uint32_t
    public const int m_nLastKnownAssociatedWeaponEntIndex = 0xF1C; // CEntityIndex
    public const int m_bNeedToQueueHighResComposite = 0xF20; // bool
    public const int m_vLoweredWeaponOffset = 0xF64; // QAngle
}

public static class C_CSGO_CounterTerroristTeamIntroCamera
{
    // C_CSGO_TeamPreviewCamera
}

public static class C_CSGO_CounterTerroristWingmaintroCamera
{
    // C_CSGO_TeamPreviewCamera
}

public static class C_CSGO_EndOfMatchCamera
{
    // C_CSGO_TeamPreviewCamera
}

public static class C_CSGO_EndOfMatchCharacterPosition
{
    // C_CSGO_TeamPreviewCharacterPosition
}

public static class C_CSGO_EndOfMatchLineupEnd
{
    // C_CSGO_EndOfMatchLineupEndpoint
}

public static class C_CSGO_EndOfMatchLineupEndpoint
{
    // C_BaseEntity
}

public static class C_CSGO_EndOfMatchLineupStart
{
    // C_CSGO_EndOfMatchLineupEndpoint
}

public static class C_CSGO_MapPreviewCameraPath
{
    // C_BaseEntity
    public const int m_flZFar = 0x540; // float
    public const int m_flZNear = 0x544; // float
    public const int m_bLoop = 0x548; // bool
    public const int m_bVerticalFOV = 0x549; // bool
    public const int m_bConstantSpeed = 0x54A; // bool
    public const int m_flDuration = 0x54C; // float
    public const int m_flPathLength = 0x590; // float
    public const int m_flPathDuration = 0x594; // float
}

public static class C_CSGO_MapPreviewCameraPathNode
{
    // C_BaseEntity
    public const int m_szParentPathUniqueID = 0x540; // CUtlSymbolLarge
    public const int m_nPathIndex = 0x548; // int32_t
    public const int m_vInTangentLocal = 0x54C; // Vector
    public const int m_vOutTangentLocal = 0x558; // Vector
    public const int m_flFOV = 0x564; // float
    public const int m_flSpeed = 0x568; // float
    public const int m_flEaseIn = 0x56C; // float
    public const int m_flEaseOut = 0x570; // float
    public const int m_vInTangentWorld = 0x574; // Vector
    public const int m_vOutTangentWorld = 0x580; // Vector
}

public static class C_CSGO_PreviewModel
{
    // C_BaseFlex
    public const int m_animgraph = 0x1018; // CUtlString
    public const int m_animgraphCharacterModeString = 0x1020; // CUtlString
    public const int m_defaultAnim = 0x1028; // CUtlString
    public const int m_nDefaultAnimLoopMode = 0x1030; // AnimLoopMode_t
    public const int m_flInitialModelScale = 0x1034; // float
}

public static class C_CSGO_PreviewModelAlias_csgo_item_previewmodel
{
    // C_CSGO_PreviewModel
}

public static class C_CSGO_PreviewPlayer
{
    // C_CSPlayerPawn
    public const int m_animgraph = 0x22E8; // CUtlString
    public const int m_animgraphCharacterModeString = 0x22F0; // CUtlString
    public const int m_flInitialModelScale = 0x22F8; // float
}

public static class C_CSGO_PreviewPlayerAlias_csgo_player_previewmodel
{
    // C_CSGO_PreviewPlayer
}

public static class C_CSGO_TeamIntroCharacterPosition
{
    // C_CSGO_TeamPreviewCharacterPosition
}

public static class C_CSGO_TeamIntroCounterTerroristPosition
{
    // C_CSGO_TeamIntroCharacterPosition
}

public static class C_CSGO_TeamIntroTerroristPosition
{
    // C_CSGO_TeamIntroCharacterPosition
}

public static class C_CSGO_TeamPreviewCamera
{
    // C_CSGO_MapPreviewCameraPath
    public const int m_nVariant = 0x5A0; // int32_t
    public const int m_bDofEnabled = 0x5A4; // bool
    public const int m_flDofNearBlurry = 0x5A8; // float
    public const int m_flDofNearCrisp = 0x5AC; // float
    public const int m_flDofFarCrisp = 0x5B0; // float
    public const int m_flDofFarBlurry = 0x5B4; // float
    public const int m_flDofTiltToGround = 0x5B8; // float
}

public static class C_CSGO_TeamPreviewCharacterPosition
{
    // C_BaseEntity
    public const int m_nVariant = 0x540; // int32_t
    public const int m_nRandom = 0x544; // int32_t
    public const int m_nOrdinal = 0x548; // int32_t
    public const int m_sWeaponName = 0x550; // CUtlString
    public const int m_xuid = 0x558; // uint64_t
    public const int m_agentItem = 0x560; // C_EconItemView
    public const int m_glovesItem = 0x9A8; // C_EconItemView
    public const int m_weaponItem = 0xDF0; // C_EconItemView
}

public static class C_CSGO_TeamPreviewModel
{
    // C_CSGO_PreviewPlayer
}

public static class C_CSGO_TeamSelectCamera
{
    // C_CSGO_TeamPreviewCamera
}

public static class C_CSGO_TeamSelectCharacterPosition
{
    // C_CSGO_TeamPreviewCharacterPosition
}

public static class C_CSGO_TeamSelectCounterTerroristPosition
{
    // C_CSGO_TeamSelectCharacterPosition
}

public static class C_CSGO_TeamSelectTerroristPosition
{
    // C_CSGO_TeamSelectCharacterPosition
}

public static class C_CSGO_TerroristTeamIntroCamera
{
    // C_CSGO_TeamPreviewCamera
}

public static class C_CSGO_TerroristWingmaintroCamera
{
    // C_CSGO_TeamPreviewCamera
}

public static class C_CSGameRules
{
    // C_TeamplayRules
    public const int __m_pChainEntity = 0x8; // CNetworkVarChainer
    public const int m_bFreezePeriod = 0x30; // bool
    public const int m_bWarmupPeriod = 0x31; // bool
    public const int m_fWarmupPeriodEnd = 0x34; // GameTime_t
    public const int m_fWarmupPeriodStart = 0x38; // GameTime_t
    public const int m_nTotalPausedTicks = 0x3C; // int32_t
    public const int m_nPauseStartTick = 0x40; // int32_t
    public const int m_bServerPaused = 0x44; // bool
    public const int m_bGamePaused = 0x45; // bool
    public const int m_bTerroristTimeOutActive = 0x46; // bool
    public const int m_bCTTimeOutActive = 0x47; // bool
    public const int m_flTerroristTimeOutRemaining = 0x48; // float
    public const int m_flCTTimeOutRemaining = 0x4C; // float
    public const int m_nTerroristTimeOuts = 0x50; // int32_t
    public const int m_nCTTimeOuts = 0x54; // int32_t
    public const int m_bTechnicalTimeOut = 0x58; // bool
    public const int m_bMatchWaitingForResume = 0x59; // bool
    public const int m_iRoundTime = 0x5C; // int32_t
    public const int m_fMatchStartTime = 0x60; // float
    public const int m_fRoundStartTime = 0x64; // GameTime_t
    public const int m_flRestartRoundTime = 0x68; // GameTime_t
    public const int m_bGameRestart = 0x6C; // bool
    public const int m_flGameStartTime = 0x70; // float
    public const int m_timeUntilNextPhaseStarts = 0x74; // float
    public const int m_gamePhase = 0x78; // int32_t
    public const int m_totalRoundsPlayed = 0x7C; // int32_t
    public const int m_nRoundsPlayedThisPhase = 0x80; // int32_t
    public const int m_nOvertimePlaying = 0x84; // int32_t
    public const int m_iHostagesRemaining = 0x88; // int32_t
    public const int m_bAnyHostageReached = 0x8C; // bool
    public const int m_bMapHasBombTarget = 0x8D; // bool
    public const int m_bMapHasRescueZone = 0x8E; // bool
    public const int m_bMapHasBuyZone = 0x8F; // bool
    public const int m_bIsQueuedMatchmaking = 0x90; // bool
    public const int m_nQueuedMatchmakingMode = 0x94; // int32_t
    public const int m_bIsValveDS = 0x98; // bool
    public const int m_bLogoMap = 0x99; // bool
    public const int m_bPlayAllStepSoundsOnServer = 0x9A; // bool
    public const int m_iSpectatorSlotCount = 0x9C; // int32_t
    public const int m_MatchDevice = 0xA0; // int32_t
    public const int m_bHasMatchStarted = 0xA4; // bool
    public const int m_nNextMapInMapgroup = 0xA8; // int32_t
    public const int m_szTournamentEventName = 0xAC; // char[512]
    public const int m_szTournamentEventStage = 0x2AC; // char[512]
    public const int m_szMatchStatTxt = 0x4AC; // char[512]
    public const int m_szTournamentPredictionsTxt = 0x6AC; // char[512]
    public const int m_nTournamentPredictionsPct = 0x8AC; // int32_t
    public const int m_flCMMItemDropRevealStartTime = 0x8B0; // GameTime_t
    public const int m_flCMMItemDropRevealEndTime = 0x8B4; // GameTime_t
    public const int m_bIsDroppingItems = 0x8B8; // bool
    public const int m_bIsQuestEligible = 0x8B9; // bool
    public const int m_bIsHltvActive = 0x8BA; // bool
    public const int m_nGuardianModeWaveNumber = 0x8BC; // int32_t
    public const int m_nGuardianModeSpecialKillsRemaining = 0x8C0; // int32_t
    public const int m_nGuardianModeSpecialWeaponNeeded = 0x8C4; // int32_t
    public const int m_nGuardianGrenadesToGiveBots = 0x8C8; // int32_t
    public const int m_nNumHeaviesToSpawn = 0x8CC; // int32_t
    public const int m_numGlobalGiftsGiven = 0x8D0; // uint32_t
    public const int m_numGlobalGifters = 0x8D4; // uint32_t
    public const int m_numGlobalGiftsPeriodSeconds = 0x8D8; // uint32_t
    public const int m_arrFeaturedGiftersAccounts = 0x8DC; // uint32_t[4]
    public const int m_arrFeaturedGiftersGifts = 0x8EC; // uint32_t[4]
    public const int m_arrProhibitedItemIndices = 0x8FC; // uint16_t[100]
    public const int m_arrTournamentActiveCasterAccounts = 0x9C4; // uint32_t[4]
    public const int m_numBestOfMaps = 0x9D4; // int32_t
    public const int m_nHalloweenMaskListSeed = 0x9D8; // int32_t
    public const int m_bBombDropped = 0x9DC; // bool
    public const int m_bBombPlanted = 0x9DD; // bool
    public const int m_iRoundWinStatus = 0x9E0; // int32_t
    public const int m_eRoundWinReason = 0x9E4; // int32_t
    public const int m_bTCantBuy = 0x9E8; // bool
    public const int m_bCTCantBuy = 0x9E9; // bool
    public const int m_flGuardianBuyUntilTime = 0x9EC; // GameTime_t
    public const int m_iMatchStats_RoundResults = 0x9F0; // int32_t[30]
    public const int m_iMatchStats_PlayersAlive_CT = 0xA68; // int32_t[30]
    public const int m_iMatchStats_PlayersAlive_T = 0xAE0; // int32_t[30]
    public const int m_TeamRespawnWaveTimes = 0xB58; // float[32]
    public const int m_flNextRespawnWave = 0xBD8; // GameTime_t[32]
    public const int m_nServerQuestID = 0xC58; // int32_t
    public const int m_vMinimapMins = 0xC5C; // Vector
    public const int m_vMinimapMaxs = 0xC68; // Vector
    public const int m_MinimapVerticalSectionHeights = 0xC74; // float[8]
    public const int m_bDontIncrementCoopWave = 0xC94; // bool
    public const int m_bSpawnedTerrorHuntHeavy = 0xC95; // bool
    public const int m_nEndMatchMapGroupVoteTypes = 0xC98; // int32_t[10]
    public const int m_nEndMatchMapGroupVoteOptions = 0xCC0; // int32_t[10]
    public const int m_nEndMatchMapVoteWinner = 0xCE8; // int32_t
    public const int m_iNumConsecutiveCTLoses = 0xCEC; // int32_t
    public const int m_iNumConsecutiveTerroristLoses = 0xCF0; // int32_t
    public const int m_bMarkClientStopRecordAtRoundEnd = 0xD10; // bool
    public const int m_nMatchAbortedEarlyReason = 0xD68; // int32_t
    public const int m_bHasTriggeredRoundStartMusic = 0xD6C; // bool
    public const int m_bHasTriggeredCoopSpawnReset = 0xD6D; // bool
    public const int m_bSwitchingTeamsAtRoundReset = 0xD6E; // bool
    public const int m_pGameModeRules = 0xD88; // CCSGameModeRules*
    public const int m_RetakeRules = 0xD90; // C_RetakeGameRules
    public const int m_nMatchEndCount = 0xEA8; // uint8_t
    public const int m_nTTeamIntroVariant = 0xEAC; // int32_t
    public const int m_nCTTeamIntroVariant = 0xEB0; // int32_t
    public const int m_bTeamIntroPeriod = 0xEB4; // bool
    public const int m_flLastPerfSampleTime = 0x4EC0; // double
}

public static class C_CSGameRulesProxy
{
    // C_GameRulesProxy
    public const int m_pGameRules = 0x540; // C_CSGameRules*
}

public static class C_CSMinimapBoundary
{
    // C_BaseEntity
}

public static class C_CSObserverPawn
{
    // C_CSPlayerPawnBase
    public const int m_hDetectParentChange = 0x16B0; // CEntityHandle
}

public static class C_CSPlayerPawn
{
    // C_CSPlayerPawnBase
    public const int m_pBulletServices = 0x16B0; // CCSPlayer_BulletServices*
    public const int m_pHostageServices = 0x16B8; // CCSPlayer_HostageServices*
    public const int m_pBuyServices = 0x16C0; // CCSPlayer_BuyServices*
    public const int m_pGlowServices = 0x16C8; // CCSPlayer_GlowServices*
    public const int m_pActionTrackingServices = 0x16D0; // CCSPlayer_ActionTrackingServices*
    public const int m_flHealthShotBoostExpirationTime = 0x16D8; // GameTime_t
    public const int m_flLastFiredWeaponTime = 0x16DC; // GameTime_t
    public const int m_bHasFemaleVoice = 0x16E0; // bool
    public const int m_flLandseconds = 0x16E4; // float
    public const int m_flOldFallVelocity = 0x16E8; // float
    public const int m_szLastPlaceName = 0x16EC; // char[18]
    public const int m_bPrevDefuser = 0x16FE; // bool
    public const int m_bPrevHelmet = 0x16FF; // bool
    public const int m_nPrevArmorVal = 0x1700; // int32_t
    public const int m_nPrevGrenadeAmmoCount = 0x1704; // int32_t
    public const int m_unPreviousWeaponHash = 0x1708; // uint32_t
    public const int m_unWeaponHash = 0x170C; // uint32_t
    public const int m_bInBuyZone = 0x1710; // bool
    public const int m_bPreviouslyInBuyZone = 0x1711; // bool
    public const int m_aimPunchAngle = 0x1714; // QAngle
    public const int m_aimPunchAngleVel = 0x1720; // QAngle
    public const int m_aimPunchTickBase = 0x172C; // int32_t
    public const int m_aimPunchTickFraction = 0x1730; // float
    public const int m_aimPunchCache = 0x1738; // CUtlVector<QAngle>
    public const int m_bInLanding = 0x1758; // bool
    public const int m_flLandingTime = 0x175C; // float
    public const int m_bInHostageRescueZone = 0x1760; // bool
    public const int m_bInBombZone = 0x1761; // bool
    public const int m_bIsBuyMenuOpen = 0x1762; // bool
    public const int m_flTimeOfLastInjury = 0x1764; // GameTime_t
    public const int m_flNextSprayDecalTime = 0x1768; // GameTime_t
    public const int m_iRetakesOffering = 0x1880; // int32_t
    public const int m_iRetakesOfferingCard = 0x1884; // int32_t
    public const int m_bRetakesHasDefuseKit = 0x1888; // bool
    public const int m_bRetakesMVPLastRound = 0x1889; // bool
    public const int m_iRetakesMVPBoostItem = 0x188C; // int32_t
    public const int m_RetakesMVPBoostExtraUtility = 0x1890; // loadout_slot_t
    public const int m_bNeedToReApplyGloves = 0x18B0; // bool
    public const int m_EconGloves = 0x18B8; // C_EconItemView
    public const int m_bMustSyncRagdollState = 0x1D00; // bool
    public const int m_nRagdollDamageBone = 0x1D04; // int32_t
    public const int m_vRagdollDamageForce = 0x1D08; // Vector
    public const int m_vRagdollDamagePosition = 0x1D14; // Vector
    public const int m_szRagdollDamageWeaponName = 0x1D20; // char[64]
    public const int m_bRagdollDamageHeadshot = 0x1D60; // bool
    public const int m_vRagdollServerOrigin = 0x1D64; // Vector
    public const int m_bLastHeadBoneTransformIsValid = 0x22B0; // bool
    public const int m_lastLandTime = 0x22B4; // GameTime_t
    public const int m_bOnGroundLastTick = 0x22B8; // bool
    public const int m_qDeathEyeAngles = 0x22D4; // QAngle
    public const int m_bSkipOneHeadConstraintUpdate = 0x22E0; // bool
}

public static class C_CSPlayerPawnBase
{
    // C_BasePlayerPawn
    public const int m_pPingServices = 0x1268; // CCSPlayer_PingServices*
    public const int m_pViewModelServices = 0x1270; // CPlayer_ViewModelServices*
    public const int m_fRenderingClipPlane = 0x1278; // float[4]
    public const int m_nLastClipPlaneSetupFrame = 0x1288; // int32_t
    public const int m_vecLastClipCameraPos = 0x128C; // Vector
    public const int m_vecLastClipCameraForward = 0x1298; // Vector
    public const int m_bClipHitStaticWorld = 0x12A4; // bool
    public const int m_bCachedPlaneIsValid = 0x12A5; // bool
    public const int m_pClippingWeapon = 0x12A8; // C_CSWeaponBase*
    public const int m_previousPlayerState = 0x12B0; // CSPlayerState
    public const int m_flLastCollisionCeiling = 0x12B4; // float
    public const int m_flLastCollisionCeilingChangeTime = 0x12B8; // float
    public const int m_grenadeParameterStashTime = 0x12D8; // GameTime_t
    public const int m_bGrenadeParametersStashed = 0x12DC; // bool
    public const int m_angStashedShootAngles = 0x12E0; // QAngle
    public const int m_vecStashedGrenadeThrowPosition = 0x12EC; // Vector
    public const int m_vecStashedVelocity = 0x12F8; // Vector
    public const int m_angShootAngleHistory = 0x1304; // QAngle[2]
    public const int m_vecThrowPositionHistory = 0x131C; // Vector[2]
    public const int m_vecVelocityHistory = 0x1334; // Vector[2]
    public const int m_thirdPersonHeading = 0x1350; // QAngle
    public const int m_flSlopeDropOffset = 0x1368; // float
    public const int m_flSlopeDropHeight = 0x1378; // float
    public const int m_vHeadConstraintOffset = 0x1388; // Vector
    public const int m_bIsScoped = 0x13A0; // bool
    public const int m_bIsWalking = 0x13A1; // bool
    public const int m_bResumeZoom = 0x13A2; // bool
    public const int m_iPlayerState = 0x13A4; // CSPlayerState
    public const int m_bIsDefusing = 0x13A8; // bool
    public const int m_bIsGrabbingHostage = 0x13A9; // bool
    public const int m_iBlockingUseActionInProgress = 0x13AC; // CSPlayerBlockingUseAction_t
    public const int m_bIsRescuing = 0x13B0; // bool
    public const int m_fImmuneToGunGameDamageTime = 0x13B4; // GameTime_t
    public const int m_fImmuneToGunGameDamageTimeLast = 0x13B8; // GameTime_t
    public const int m_bGunGameImmunity = 0x13BC; // bool
    public const int m_bHasMovedSinceSpawn = 0x13BD; // bool
    public const int m_fMolotovUseTime = 0x13C0; // float
    public const int m_fMolotovDamageTime = 0x13C4; // float
    public const int m_nWhichBombZone = 0x13C8; // int32_t
    public const int m_bInNoDefuseArea = 0x13CC; // bool
    public const int m_iThrowGrenadeCounter = 0x13D0; // int32_t
    public const int m_bWaitForNoAttack = 0x13D4; // bool
    public const int m_flGuardianTooFarDistFrac = 0x13D8; // float
    public const int m_flDetectedByEnemySensorTime = 0x13DC; // GameTime_t
    public const int m_flNextGuardianTooFarWarning = 0x13E0; // float
    public const int m_bSuppressGuardianTooFarWarningAudio = 0x13E4; // bool
    public const int m_bKilledByTaser = 0x13E5; // bool
    public const int m_iMoveState = 0x13E8; // int32_t
    public const int m_bCanMoveDuringFreezePeriod = 0x13EC; // bool
    public const int m_flLowerBodyYawTarget = 0x13F0; // float
    public const int m_bStrafing = 0x13F4; // bool
    public const int m_flLastSpawnTimeIndex = 0x13F8; // GameTime_t
    public const int m_flEmitSoundTime = 0x13FC; // GameTime_t
    public const int m_iAddonBits = 0x1400; // int32_t
    public const int m_iPrimaryAddon = 0x1404; // int32_t
    public const int m_iSecondaryAddon = 0x1408; // int32_t
    public const int m_iProgressBarDuration = 0x140C; // int32_t
    public const int m_flProgressBarStartTime = 0x1410; // float
    public const int m_iDirection = 0x1414; // int32_t
    public const int m_iShotsFired = 0x1418; // int32_t
    public const int m_bNightVisionOn = 0x141C; // bool
    public const int m_bHasNightVision = 0x141D; // bool
    public const int m_flVelocityModifier = 0x1420; // float
    public const int m_flHitHeading = 0x1424; // float
    public const int m_nHitBodyPart = 0x1428; // int32_t
    public const int m_iStartAccount = 0x142C; // int32_t
    public const int m_vecIntroStartEyePosition = 0x1430; // Vector
    public const int m_vecIntroStartPlayerForward = 0x143C; // Vector
    public const int m_flClientDeathTime = 0x1448; // GameTime_t
    public const int m_flNightVisionAlpha = 0x144C; // float
    public const int m_bScreenTearFrameCaptured = 0x1450; // bool
    public const int m_flFlashBangTime = 0x1454; // float
    public const int m_flFlashScreenshotAlpha = 0x1458; // float
    public const int m_flFlashOverlayAlpha = 0x145C; // float
    public const int m_bFlashBuildUp = 0x1460; // bool
    public const int m_bFlashDspHasBeenCleared = 0x1461; // bool
    public const int m_bFlashScreenshotHasBeenGrabbed = 0x1462; // bool
    public const int m_flFlashMaxAlpha = 0x1464; // float
    public const int m_flFlashDuration = 0x1468; // float
    public const int m_lastStandingPos = 0x146C; // Vector
    public const int m_vecLastMuzzleFlashPos = 0x1478; // Vector
    public const int m_angLastMuzzleFlashAngle = 0x1484; // QAngle
    public const int m_hMuzzleFlashShape = 0x1490; // CHandle<C_BaseEntity>
    public const int m_iHealthBarRenderMaskIndex = 0x1494; // int32_t
    public const int m_flHealthFadeValue = 0x1498; // float
    public const int m_flHealthFadeAlpha = 0x149C; // float
    public const int m_nMyCollisionGroup = 0x14A0; // int32_t
    public const int m_ignoreLadderJumpTime = 0x14A4; // float
    public const int m_ladderSurpressionTimer = 0x14A8; // CountdownTimer
    public const int m_lastLadderNormal = 0x14C0; // Vector
    public const int m_lastLadderPos = 0x14CC; // Vector
    public const int m_flDeathCCWeight = 0x14E0; // float
    public const int m_bOldIsScoped = 0x14E4; // bool
    public const int m_flPrevRoundEndTime = 0x14E8; // float
    public const int m_flPrevMatchEndTime = 0x14EC; // float
    public const int m_unCurrentEquipmentValue = 0x14F0; // uint16_t
    public const int m_unRoundStartEquipmentValue = 0x14F2; // uint16_t
    public const int m_unFreezetimeEndEquipmentValue = 0x14F4; // uint16_t
    public const int m_vecThirdPersonViewPositionOverride = 0x14F8; // Vector
    public const int m_nHeavyAssaultSuitCooldownRemaining = 0x1504; // int32_t
    public const int m_ArmorValue = 0x1508; // int32_t
    public const int m_angEyeAngles = 0x1510; // QAngle
    public const int m_fNextThinkPushAway = 0x1528; // float
    public const int m_bShouldAutobuyDMWeapons = 0x152C; // bool
    public const int m_bShouldAutobuyNow = 0x152D; // bool
    public const int m_bHud_MiniScoreHidden = 0x152E; // bool
    public const int m_bHud_RadarHidden = 0x152F; // bool
    public const int m_nLastKillerIndex = 0x1530; // CEntityIndex
    public const int m_nLastConcurrentKilled = 0x1534; // int32_t
    public const int m_nDeathCamMusic = 0x1538; // int32_t
    public const int m_iIDEntIndex = 0x153C; // CEntityIndex
    public const int m_delayTargetIDTimer = 0x1540; // CountdownTimer
    public const int m_iTargetedWeaponEntIndex = 0x1558; // CEntityIndex
    public const int m_iOldIDEntIndex = 0x155C; // CEntityIndex
    public const int m_holdTargetIDTimer = 0x1560; // CountdownTimer
    public const int m_flCurrentMusicStartTime = 0x157C; // float
    public const int m_flMusicRoundStartTime = 0x1580; // float
    public const int m_bDeferStartMusicOnWarmup = 0x1584; // bool
    public const int m_cycleLatch = 0x1588; // int32_t
    public const int m_serverIntendedCycle = 0x158C; // float
    public const int m_vecPlayerPatchEconIndices = 0x1590; // uint32_t[5]
    public const int m_bHideTargetID = 0x15AC; // bool
    public const int m_nextTaserShakeTime = 0x15B0; // float
    public const int m_firstTaserShakeTime = 0x15B4; // float
    public const int m_flLastSmokeOverlayAlpha = 0x15B8; // float
    public const int m_vLastSmokeOverlayColor = 0x15BC; // Vector
    public const int m_nPlayerSmokedFx = 0x15C8; // ParticleIndex_t
    public const int m_flNextMagDropTime = 0x15CC; // float
    public const int m_nLastMagDropAttachmentIndex = 0x15D0; // int32_t
    public const int m_vecBulletHitModels = 0x15D8; // CUtlVector<C_BulletHitModel*>
    public const int m_vecPickupModelSlerpers = 0x15F0; // CUtlVector<C_PickUpModelSlerper*>
    public const int m_vecLastAliveLocalVelocity = 0x1608; // Vector
    public const int m_entitySpottedState = 0x1630; // EntitySpottedState_t
    public const int m_nSurvivalTeamNumber = 0x1648; // int32_t
    public const int m_bGuardianShouldSprayCustomXMark = 0x164C; // bool
    public const int m_bHasDeathInfo = 0x164D; // bool
    public const int m_flDeathInfoTime = 0x1650; // float
    public const int m_vecDeathInfoOrigin = 0x1654; // Vector
    public const int m_bKilledByHeadshot = 0x1660; // bool
    public const int m_hOriginalController = 0x1664; // CHandle<CCSPlayerController>
}

public static class C_CSPlayerResource
{
    // C_BaseEntity
    public const int m_bHostageAlive = 0x540; // bool[12]
    public const int m_isHostageFollowingSomeone = 0x54C; // bool[12]
    public const int m_iHostageEntityIDs = 0x558; // CEntityIndex[12]
    public const int m_bombsiteCenterA = 0x588; // Vector
    public const int m_bombsiteCenterB = 0x594; // Vector
    public const int m_hostageRescueX = 0x5A0; // int32_t[4]
    public const int m_hostageRescueY = 0x5B0; // int32_t[4]
    public const int m_hostageRescueZ = 0x5C0; // int32_t[4]
    public const int m_bEndMatchNextMapAllVoted = 0x5D0; // bool
    public const int m_foundGoalPositions = 0x5D1; // bool
}

public static class C_CSTeam
{
    // C_Team
    public const int m_szTeamMatchStat = 0x5F8; // char[512]
    public const int m_numMapVictories = 0x7F8; // int32_t
    public const int m_bSurrendered = 0x7FC; // bool
    public const int m_scoreFirstHalf = 0x800; // int32_t
    public const int m_scoreSecondHalf = 0x804; // int32_t
    public const int m_scoreOvertime = 0x808; // int32_t
    public const int m_szClanTeamname = 0x80C; // char[129]
    public const int m_iClanID = 0x890; // uint32_t
    public const int m_szTeamFlagImage = 0x894; // char[8]
    public const int m_szTeamLogoImage = 0x89C; // char[8]
}

public static class C_CSWeaponBase
{
    // C_BasePlayerWeapon
    public const int m_flFireSequenceStartTime = 0x15D4; // float
    public const int m_nFireSequenceStartTimeChange = 0x15D8; // int32_t
    public const int m_nFireSequenceStartTimeAck = 0x15DC; // int32_t
    public const int m_bPlayerFireEventIsPrimary = 0x15E0; // bool
    public const int m_seqIdle = 0x15E4; // HSequence
    public const int m_seqFirePrimary = 0x15E8; // HSequence
    public const int m_seqFireSecondary = 0x15EC; // HSequence
    public const int m_thirdPersonFireSequences = 0x15F0; // CUtlVector<HSequence>
    public const int m_hCurrentThirdPersonSequence = 0x1608; // HSequence
    public const int m_nSilencerBoneIndex = 0x160C; // int32_t
    public const int m_thirdPersonSequences = 0x1610; // HSequence[6]
    public const int m_ClientPreviousWeaponState = 0x1640; // CSWeaponState_t
    public const int m_iState = 0x1644; // CSWeaponState_t
    public const int m_flCrosshairDistance = 0x1648; // float
    public const int m_iAmmoLastCheck = 0x164C; // int32_t
    public const int m_iAlpha = 0x1650; // int32_t
    public const int m_iScopeTextureID = 0x1654; // int32_t
    public const int m_iCrosshairTextureID = 0x1658; // int32_t
    public const int m_flGunAccuracyPosition = 0x165C; // float
    public const int m_nViewModelIndex = 0x1660; // uint32_t
    public const int m_bReloadsWithClips = 0x1664; // bool
    public const int m_flTimeWeaponIdle = 0x1668; // GameTime_t
    public const int m_bFireOnEmpty = 0x166C; // bool
    public const int m_OnPlayerPickup = 0x1670; // CEntityIOOutput
    public const int m_weaponMode = 0x1698; // CSWeaponMode
    public const int m_flTurningInaccuracyDelta = 0x169C; // float
    public const int m_vecTurningInaccuracyEyeDirLast = 0x16A0; // Vector
    public const int m_flTurningInaccuracy = 0x16AC; // float
    public const int m_fAccuracyPenalty = 0x16B0; // float
    public const int m_flLastAccuracyUpdateTime = 0x16B4; // GameTime_t
    public const int m_fAccuracySmoothedForZoom = 0x16B8; // float
    public const int m_fScopeZoomEndTime = 0x16BC; // GameTime_t
    public const int m_iRecoilIndex = 0x16C0; // int32_t
    public const int m_flRecoilIndex = 0x16C4; // float
    public const int m_bBurstMode = 0x16C8; // bool
    public const int m_flPostponeFireReadyTime = 0x16CC; // GameTime_t
    public const int m_bInReload = 0x16D0; // bool
    public const int m_bReloadVisuallyComplete = 0x16D1; // bool
    public const int m_flDroppedAtTime = 0x16D4; // GameTime_t
    public const int m_bIsHauledBack = 0x16D8; // bool
    public const int m_bSilencerOn = 0x16D9; // bool
    public const int m_flTimeSilencerSwitchComplete = 0x16DC; // GameTime_t
    public const int m_iOriginalTeamNumber = 0x16E0; // int32_t
    public const int m_flNextAttackRenderTimeOffset = 0x16E4; // float
    public const int m_bVisualsDataSet = 0x1768; // bool
    public const int m_bOldFirstPersonSpectatedState = 0x1769; // bool
    public const int m_hOurPing = 0x176C; // CHandle<C_BaseEntity>
    public const int m_nOurPingIndex = 0x1770; // CEntityIndex
    public const int m_vecOurPingPos = 0x1774; // Vector
    public const int m_bGlowForPing = 0x1780; // bool
    public const int m_bUIWeapon = 0x1781; // bool
    public const int m_hPrevOwner = 0x1790; // CHandle<C_CSPlayerPawn>
    public const int m_nDropTick = 0x1794; // GameTick_t
    public const int m_donated = 0x17B4; // bool
    public const int m_fLastShotTime = 0x17B8; // GameTime_t
    public const int m_bWasOwnedByCT = 0x17BC; // bool
    public const int m_bWasOwnedByTerrorist = 0x17BD; // bool
    public const int m_gunHeat = 0x17C0; // float
    public const int m_smokeAttachments = 0x17C4; // uint32_t
    public const int m_lastSmokeTime = 0x17C8; // GameTime_t
    public const int m_flNextClientFireBulletTime = 0x17CC; // float
    public const int m_flNextClientFireBulletTime_Repredict = 0x17D0; // float
    public const int m_IronSightController = 0x18B0; // C_IronSightController
    public const int m_iIronSightMode = 0x1960; // int32_t
    public const int m_flLastLOSTraceFailureTime = 0x1970; // GameTime_t
    public const int m_iNumEmptyAttacks = 0x1974; // int32_t
}

public static class C_CSWeaponBaseGun
{
    // C_CSWeaponBase
    public const int m_zoomLevel = 0x19F0; // int32_t
    public const int m_iBurstShotsRemaining = 0x19F4; // int32_t
    public const int m_iSilencerBodygroup = 0x19F8; // int32_t
    public const int m_silencedModelIndex = 0x1A08; // int32_t
    public const int m_inPrecache = 0x1A0C; // bool
    public const int m_bNeedsBoltAction = 0x1A0D; // bool
}

public static class C_Chicken
{
    // C_DynamicProp
    public const int m_hHolidayHatAddon = 0x10F0; // CHandle<CBaseAnimGraph>
    public const int m_jumpedThisFrame = 0x10F4; // bool
    public const int m_leader = 0x10F8; // CHandle<C_CSPlayerPawnBase>
    public const int m_AttributeManager = 0x1100; // C_AttributeContainer
    public const int m_OriginalOwnerXuidLow = 0x15A8; // uint32_t
    public const int m_OriginalOwnerXuidHigh = 0x15AC; // uint32_t
    public const int m_bAttributesInitialized = 0x15B0; // bool
    public const int m_hWaterWakeParticles = 0x15B4; // ParticleIndex_t
}

public static class C_ClientRagdoll
{
    // CBaseAnimGraph
    public const int m_bFadeOut = 0xE80; // bool
    public const int m_bImportant = 0xE81; // bool
    public const int m_flEffectTime = 0xE84; // GameTime_t
    public const int m_gibDespawnTime = 0xE88; // GameTime_t
    public const int m_iCurrentFriction = 0xE8C; // int32_t
    public const int m_iMinFriction = 0xE90; // int32_t
    public const int m_iMaxFriction = 0xE94; // int32_t
    public const int m_iFrictionAnimState = 0xE98; // int32_t
    public const int m_bReleaseRagdoll = 0xE9C; // bool
    public const int m_iEyeAttachment = 0xE9D; // AttachmentHandle_t
    public const int m_bFadingOut = 0xE9E; // bool
    public const int m_flScaleEnd = 0xEA0; // float[10]
    public const int m_flScaleTimeStart = 0xEC8; // GameTime_t[10]
    public const int m_flScaleTimeEnd = 0xEF0; // GameTime_t[10]
}

public static class C_ColorCorrection
{
    // C_BaseEntity
    public const int m_vecOrigin = 0x540; // Vector
    public const int m_MinFalloff = 0x54C; // float
    public const int m_MaxFalloff = 0x550; // float
    public const int m_flFadeInDuration = 0x554; // float
    public const int m_flFadeOutDuration = 0x558; // float
    public const int m_flMaxWeight = 0x55C; // float
    public const int m_flCurWeight = 0x560; // float
    public const int m_netlookupFilename = 0x564; // char[512]
    public const int m_bEnabled = 0x764; // bool
    public const int m_bMaster = 0x765; // bool
    public const int m_bClientSide = 0x766; // bool
    public const int m_bExclusive = 0x767; // bool
    public const int m_bEnabledOnClient = 0x768; // bool[1]
    public const int m_flCurWeightOnClient = 0x76C; // float[1]
    public const int m_bFadingIn = 0x770; // bool[1]
    public const int m_flFadeStartWeight = 0x774; // float[1]
    public const int m_flFadeStartTime = 0x778; // float[1]
    public const int m_flFadeDuration = 0x77C; // float[1]
}

public static class C_ColorCorrectionVolume
{
    // C_BaseTrigger
    public const int m_LastEnterWeight = 0xCC8; // float
    public const int m_LastEnterTime = 0xCCC; // float
    public const int m_LastExitWeight = 0xCD0; // float
    public const int m_LastExitTime = 0xCD4; // float
    public const int m_bEnabled = 0xCD8; // bool
    public const int m_MaxWeight = 0xCDC; // float
    public const int m_FadeDuration = 0xCE0; // float
    public const int m_Weight = 0xCE4; // float
    public const int m_lookupFilename = 0xCE8; // char[512]
}

public static class C_CommandContext
{
    public const int needsprocessing = 0x0; // bool
    public const int command_number = 0xA8; // int32_t
}

public static class C_CsmFovOverride
{
    // C_BaseEntity
    public const int m_cameraName = 0x540; // CUtlString
    public const int m_flCsmFovOverrideValue = 0x548; // float
}

public static class C_DEagle
{
    // C_CSWeaponBaseGun
}

public static class C_DecoyGrenade
{
    // C_BaseCSGrenade
}

public static class C_DecoyProjectile
{
    // C_BaseCSGrenadeProjectile
    public const int m_nDecoyShotTick = 0x1100; // int32_t
    public const int m_nClientLastKnownDecoyShotTick = 0x1104; // int32_t
    public const int m_flTimeParticleEffectSpawn = 0x1128; // GameTime_t
}

public static class C_DynamicLight
{
    // C_BaseModelEntity
    public const int m_Flags = 0xCC0; // uint8_t
    public const int m_LightStyle = 0xCC1; // uint8_t
    public const int m_Radius = 0xCC4; // float
    public const int m_Exponent = 0xCC8; // int32_t
    public const int m_InnerAngle = 0xCCC; // float
    public const int m_OuterAngle = 0xCD0; // float
    public const int m_SpotRadius = 0xCD4; // float
}

public static class C_DynamicProp
{
    // C_BreakableProp
    public const int m_bUseHitboxesForRenderBox = 0xFD0; // bool
    public const int m_bUseAnimGraph = 0xFD1; // bool
    public const int m_pOutputAnimBegun = 0xFD8; // CEntityIOOutput
    public const int m_pOutputAnimOver = 0x1000; // CEntityIOOutput
    public const int m_pOutputAnimLoopCycleOver = 0x1028; // CEntityIOOutput
    public const int m_OnAnimReachedStart = 0x1050; // CEntityIOOutput
    public const int m_OnAnimReachedEnd = 0x1078; // CEntityIOOutput
    public const int m_iszDefaultAnim = 0x10A0; // CUtlSymbolLarge
    public const int m_nDefaultAnimLoopMode = 0x10A8; // AnimLoopMode_t
    public const int m_bAnimateOnServer = 0x10AC; // bool
    public const int m_bRandomizeCycle = 0x10AD; // bool
    public const int m_bStartDisabled = 0x10AE; // bool
    public const int m_bScriptedMovement = 0x10AF; // bool
    public const int m_bFiredStartEndOutput = 0x10B0; // bool
    public const int m_bForceNpcExclude = 0x10B1; // bool
    public const int m_bCreateNonSolid = 0x10B2; // bool
    public const int m_bIsOverrideProp = 0x10B3; // bool
    public const int m_iInitialGlowState = 0x10B4; // int32_t
    public const int m_nGlowRange = 0x10B8; // int32_t
    public const int m_nGlowRangeMin = 0x10BC; // int32_t
    public const int m_glowColor = 0x10C0; // Color
    public const int m_nGlowTeam = 0x10C4; // int32_t
    public const int m_iCachedFrameCount = 0x10C8; // int32_t
    public const int m_vecCachedRenderMins = 0x10CC; // Vector
    public const int m_vecCachedRenderMaxs = 0x10D8; // Vector
}

public static class C_DynamicPropAlias_cable_dynamic
{
    // C_DynamicProp
}

public static class C_DynamicPropAlias_dynamic_prop
{
    // C_DynamicProp
}

public static class C_DynamicPropAlias_prop_dynamic_override
{
    // C_DynamicProp
}

public static class C_EconEntity
{
    // C_BaseFlex
    public const int m_flFlexDelayTime = 0x1028; // float
    public const int m_flFlexDelayedWeight = 0x1030; // float*
    public const int m_bAttributesInitialized = 0x1038; // bool
    public const int m_AttributeManager = 0x1040; // C_AttributeContainer
    public const int m_OriginalOwnerXuidLow = 0x14E8; // uint32_t
    public const int m_OriginalOwnerXuidHigh = 0x14EC; // uint32_t
    public const int m_nFallbackPaintKit = 0x14F0; // int32_t
    public const int m_nFallbackSeed = 0x14F4; // int32_t
    public const int m_flFallbackWear = 0x14F8; // float
    public const int m_nFallbackStatTrak = 0x14FC; // int32_t
    public const int m_bClientside = 0x1500; // bool
    public const int m_bParticleSystemsCreated = 0x1501; // bool
    public const int m_vecAttachedParticles = 0x1508; // CUtlVector<int32_t>
    public const int m_hViewmodelAttachment = 0x1520; // CHandle<CBaseAnimGraph>
    public const int m_iOldTeam = 0x1524; // int32_t
    public const int m_bAttachmentDirty = 0x1528; // bool
    public const int m_nUnloadedModelIndex = 0x152C; // int32_t
    public const int m_iNumOwnerValidationRetries = 0x1530; // int32_t
    public const int m_hOldProvidee = 0x1540; // CHandle<C_BaseEntity>
    public const int m_vecAttachedModels = 0x1548; // CUtlVector<C_EconEntity::AttachedModelData_t>
}

public static class C_EconEntity_AttachedModelData_t
{
    public const int m_iModelDisplayFlags = 0x0; // int32_t
}

public static class C_EconItemView
{
    // IEconItemInterface
    public const int m_bInventoryImageRgbaRequested = 0x60; // bool
    public const int m_bInventoryImageTriedCache = 0x61; // bool
    public const int m_nInventoryImageRgbaWidth = 0x80; // int32_t
    public const int m_nInventoryImageRgbaHeight = 0x84; // int32_t
    public const int m_szCurrentLoadCachedFileName = 0x88; // char[260]
    public const int m_bRestoreCustomMaterialAfterPrecache = 0x1B8; // bool
    public const int m_iItemDefinitionIndex = 0x1BA; // uint16_t
    public const int m_iEntityQuality = 0x1BC; // int32_t
    public const int m_iEntityLevel = 0x1C0; // uint32_t
    public const int m_iItemID = 0x1C8; // uint64_t
    public const int m_iItemIDHigh = 0x1D0; // uint32_t
    public const int m_iItemIDLow = 0x1D4; // uint32_t
    public const int m_iAccountID = 0x1D8; // uint32_t
    public const int m_iInventoryPosition = 0x1DC; // uint32_t
    public const int m_bInitialized = 0x1E8; // bool
    public const int m_bIsStoreItem = 0x1E9; // bool
    public const int m_bIsTradeItem = 0x1EA; // bool
    public const int m_iEntityQuantity = 0x1EC; // int32_t
    public const int m_iRarityOverride = 0x1F0; // int32_t
    public const int m_iQualityOverride = 0x1F4; // int32_t
    public const int m_unClientFlags = 0x1F8; // uint8_t
    public const int m_unOverrideStyle = 0x1F9; // uint8_t
    public const int m_AttributeList = 0x210; // CAttributeList
    public const int m_NetworkedDynamicAttributes = 0x270; // CAttributeList
    public const int m_szCustomName = 0x2D0; // char[161]
    public const int m_szCustomNameOverride = 0x371; // char[161]
    public const int m_bInitializedTags = 0x440; // bool
}

public static class C_EconWearable
{
    // C_EconEntity
    public const int m_nForceSkin = 0x1560; // int32_t
    public const int m_bAlwaysAllow = 0x1564; // bool
}

public static class C_EntityDissolve
{
    // C_BaseModelEntity
    public const int m_flStartTime = 0xCC8; // GameTime_t
    public const int m_flFadeInStart = 0xCCC; // float
    public const int m_flFadeInLength = 0xCD0; // float
    public const int m_flFadeOutModelStart = 0xCD4; // float
    public const int m_flFadeOutModelLength = 0xCD8; // float
    public const int m_flFadeOutStart = 0xCDC; // float
    public const int m_flFadeOutLength = 0xCE0; // float
    public const int m_flNextSparkTime = 0xCE4; // GameTime_t
    public const int m_nDissolveType = 0xCE8; // EntityDisolveType_t
    public const int m_vDissolverOrigin = 0xCEC; // Vector
    public const int m_nMagnitude = 0xCF8; // uint32_t
    public const int m_bCoreExplode = 0xCFC; // bool
    public const int m_bLinkedToServerEnt = 0xCFD; // bool
}

public static class C_EntityFlame
{
    // C_BaseEntity
    public const int m_hEntAttached = 0x540; // CHandle<C_BaseEntity>
    public const int m_hOldAttached = 0x568; // CHandle<C_BaseEntity>
    public const int m_bCheapEffect = 0x56C; // bool
}

public static class C_EnvCombinedLightProbeVolume
{
    // C_BaseEntity
    public const int m_Color = 0x1598; // Color
    public const int m_flBrightness = 0x159C; // float
    public const int m_hCubemapTexture = 0x15A0; // CStrongHandle<InfoForResourceTypeCTextureBase>
    public const int m_bCustomCubemapTexture = 0x15A8; // bool
    public const int m_hLightProbeTexture = 0x15B0; // CStrongHandle<InfoForResourceTypeCTextureBase>
    public const int m_hLightProbeDirectLightIndicesTexture = 0x15B8; // CStrongHandle<InfoForResourceTypeCTextureBase>
    public const int m_hLightProbeDirectLightScalarsTexture = 0x15C0; // CStrongHandle<InfoForResourceTypeCTextureBase>
    public const int m_hLightProbeDirectLightShadowsTexture = 0x15C8; // CStrongHandle<InfoForResourceTypeCTextureBase>
    public const int m_vBoxMins = 0x15D0; // Vector
    public const int m_vBoxMaxs = 0x15DC; // Vector
    public const int m_bMoveable = 0x15E8; // bool
    public const int m_nHandshake = 0x15EC; // int32_t
    public const int m_nEnvCubeMapArrayIndex = 0x15F0; // int32_t
    public const int m_nPriority = 0x15F4; // int32_t
    public const int m_bStartDisabled = 0x15F8; // bool
    public const int m_flEdgeFadeDist = 0x15FC; // float
    public const int m_vEdgeFadeDists = 0x1600; // Vector
    public const int m_nLightProbeSizeX = 0x160C; // int32_t
    public const int m_nLightProbeSizeY = 0x1610; // int32_t
    public const int m_nLightProbeSizeZ = 0x1614; // int32_t
    public const int m_nLightProbeAtlasX = 0x1618; // int32_t
    public const int m_nLightProbeAtlasY = 0x161C; // int32_t
    public const int m_nLightProbeAtlasZ = 0x1620; // int32_t
    public const int m_bEnabled = 0x1639; // bool
}

public static class C_EnvCubemap
{
    // C_BaseEntity
    public const int m_hCubemapTexture = 0x5C0; // CStrongHandle<InfoForResourceTypeCTextureBase>
    public const int m_bCustomCubemapTexture = 0x5C8; // bool
    public const int m_flInfluenceRadius = 0x5CC; // float
    public const int m_vBoxProjectMins = 0x5D0; // Vector
    public const int m_vBoxProjectMaxs = 0x5DC; // Vector
    public const int m_bMoveable = 0x5E8; // bool
    public const int m_nHandshake = 0x5EC; // int32_t
    public const int m_nEnvCubeMapArrayIndex = 0x5F0; // int32_t
    public const int m_nPriority = 0x5F4; // int32_t
    public const int m_flEdgeFadeDist = 0x5F8; // float
    public const int m_vEdgeFadeDists = 0x5FC; // Vector
    public const int m_flDiffuseScale = 0x608; // float
    public const int m_bStartDisabled = 0x60C; // bool
    public const int m_bDefaultEnvMap = 0x60D; // bool
    public const int m_bDefaultSpecEnvMap = 0x60E; // bool
    public const int m_bIndoorCubeMap = 0x60F; // bool
    public const int m_bCopyDiffuseFromDefaultCubemap = 0x610; // bool
    public const int m_bEnabled = 0x620; // bool
}

public static class C_EnvCubemapBox
{
    // C_EnvCubemap
}

public static class C_EnvCubemapFog
{
    // C_BaseEntity
    public const int m_flEndDistance = 0x540; // float
    public const int m_flStartDistance = 0x544; // float
    public const int m_flFogFalloffExponent = 0x548; // float
    public const int m_bHeightFogEnabled = 0x54C; // bool
    public const int m_flFogHeightWidth = 0x550; // float
    public const int m_flFogHeightEnd = 0x554; // float
    public const int m_flFogHeightStart = 0x558; // float
    public const int m_flFogHeightExponent = 0x55C; // float
    public const int m_flLODBias = 0x560; // float
    public const int m_bActive = 0x564; // bool
    public const int m_bStartDisabled = 0x565; // bool
    public const int m_flFogMaxOpacity = 0x568; // float
    public const int m_nCubemapSourceType = 0x56C; // int32_t
    public const int m_hSkyMaterial = 0x570; // CStrongHandle<InfoForResourceTypeIMaterial2>
    public const int m_iszSkyEntity = 0x578; // CUtlSymbolLarge
    public const int m_hFogCubemapTexture = 0x580; // CStrongHandle<InfoForResourceTypeCTextureBase>
    public const int m_bHasHeightFogEnd = 0x588; // bool
    public const int m_bFirstTime = 0x589; // bool
}

public static class C_EnvDecal
{
    // C_BaseModelEntity
    public const int m_hDecalMaterial = 0xCC0; // CStrongHandle<InfoForResourceTypeIMaterial2>
    public const int m_flWidth = 0xCC8; // float
    public const int m_flHeight = 0xCCC; // float
    public const int m_flDepth = 0xCD0; // float
    public const int m_nRenderOrder = 0xCD4; // uint32_t
    public const int m_bProjectOnWorld = 0xCD8; // bool
    public const int m_bProjectOnCharacters = 0xCD9; // bool
    public const int m_bProjectOnWater = 0xCDA; // bool
    public const int m_flDepthSortBias = 0xCDC; // float
}

public static class C_EnvDetailController
{
    // C_BaseEntity
    public const int m_flFadeStartDist = 0x540; // float
    public const int m_flFadeEndDist = 0x544; // float
}

public static class C_EnvLightProbeVolume
{
    // C_BaseEntity
    public const int m_hLightProbeTexture = 0x1518; // CStrongHandle<InfoForResourceTypeCTextureBase>
    public const int m_hLightProbeDirectLightIndicesTexture = 0x1520; // CStrongHandle<InfoForResourceTypeCTextureBase>
    public const int m_hLightProbeDirectLightScalarsTexture = 0x1528; // CStrongHandle<InfoForResourceTypeCTextureBase>
    public const int m_hLightProbeDirectLightShadowsTexture = 0x1530; // CStrongHandle<InfoForResourceTypeCTextureBase>
    public const int m_vBoxMins = 0x1538; // Vector
    public const int m_vBoxMaxs = 0x1544; // Vector
    public const int m_bMoveable = 0x1550; // bool
    public const int m_nHandshake = 0x1554; // int32_t
    public const int m_nPriority = 0x1558; // int32_t
    public const int m_bStartDisabled = 0x155C; // bool
    public const int m_nLightProbeSizeX = 0x1560; // int32_t
    public const int m_nLightProbeSizeY = 0x1564; // int32_t
    public const int m_nLightProbeSizeZ = 0x1568; // int32_t
    public const int m_nLightProbeAtlasX = 0x156C; // int32_t
    public const int m_nLightProbeAtlasY = 0x1570; // int32_t
    public const int m_nLightProbeAtlasZ = 0x1574; // int32_t
    public const int m_bEnabled = 0x1581; // bool
}

public static class C_EnvParticleGlow
{
    // C_ParticleSystem
    public const int m_flAlphaScale = 0x1270; // float
    public const int m_flRadiusScale = 0x1274; // float
    public const int m_flSelfIllumScale = 0x1278; // float
    public const int m_ColorTint = 0x127C; // Color
    public const int m_hTextureOverride = 0x1280; // CStrongHandle<InfoForResourceTypeCTextureBase>
}

public static class C_EnvProjectedTexture
{
    // C_ModelPointEntity
}

public static class C_EnvScreenOverlay
{
    // C_PointEntity
    public const int m_iszOverlayNames = 0x540; // CUtlSymbolLarge[10]
    public const int m_flOverlayTimes = 0x590; // float[10]
    public const int m_flStartTime = 0x5B8; // GameTime_t
    public const int m_iDesiredOverlay = 0x5BC; // int32_t
    public const int m_bIsActive = 0x5C0; // bool
    public const int m_bWasActive = 0x5C1; // bool
    public const int m_iCachedDesiredOverlay = 0x5C4; // int32_t
    public const int m_iCurrentOverlay = 0x5C8; // int32_t
    public const int m_flCurrentOverlayTime = 0x5CC; // GameTime_t
}

public static class C_EnvSky
{
    // C_BaseModelEntity
    public const int m_hSkyMaterial = 0xCC0; // CStrongHandle<InfoForResourceTypeIMaterial2>
    public const int m_hSkyMaterialLightingOnly = 0xCC8; // CStrongHandle<InfoForResourceTypeIMaterial2>
    public const int m_bStartDisabled = 0xCD0; // bool
    public const int m_vTintColor = 0xCD1; // Color
    public const int m_vTintColorLightingOnly = 0xCD5; // Color
    public const int m_flBrightnessScale = 0xCDC; // float
    public const int m_nFogType = 0xCE0; // int32_t
    public const int m_flFogMinStart = 0xCE4; // float
    public const int m_flFogMinEnd = 0xCE8; // float
    public const int m_flFogMaxStart = 0xCEC; // float
    public const int m_flFogMaxEnd = 0xCF0; // float
    public const int m_bEnabled = 0xCF4; // bool
}

public static class C_EnvVolumetricFogController
{
    // C_BaseEntity
    public const int m_flScattering = 0x540; // float
    public const int m_flAnisotropy = 0x544; // float
    public const int m_flFadeSpeed = 0x548; // float
    public const int m_flDrawDistance = 0x54C; // float
    public const int m_flFadeInStart = 0x550; // float
    public const int m_flFadeInEnd = 0x554; // float
    public const int m_flIndirectStrength = 0x558; // float
    public const int m_nIndirectTextureDimX = 0x55C; // int32_t
    public const int m_nIndirectTextureDimY = 0x560; // int32_t
    public const int m_nIndirectTextureDimZ = 0x564; // int32_t
    public const int m_vBoxMins = 0x568; // Vector
    public const int m_vBoxMaxs = 0x574; // Vector
    public const int m_bActive = 0x580; // bool
    public const int m_flStartAnisoTime = 0x584; // GameTime_t
    public const int m_flStartScatterTime = 0x588; // GameTime_t
    public const int m_flStartDrawDistanceTime = 0x58C; // GameTime_t
    public const int m_flStartAnisotropy = 0x590; // float
    public const int m_flStartScattering = 0x594; // float
    public const int m_flStartDrawDistance = 0x598; // float
    public const int m_flDefaultAnisotropy = 0x59C; // float
    public const int m_flDefaultScattering = 0x5A0; // float
    public const int m_flDefaultDrawDistance = 0x5A4; // float
    public const int m_bStartDisabled = 0x5A8; // bool
    public const int m_bEnableIndirect = 0x5A9; // bool
    public const int m_bIsMaster = 0x5AA; // bool
    public const int m_hFogIndirectTexture = 0x5B0; // CStrongHandle<InfoForResourceTypeCTextureBase>
    public const int m_nForceRefreshCount = 0x5B8; // int32_t
    public const int m_bFirstTime = 0x5BC; // bool
}

public static class C_EnvVolumetricFogVolume
{
    // C_BaseEntity
    public const int m_bActive = 0x540; // bool
    public const int m_vBoxMins = 0x544; // Vector
    public const int m_vBoxMaxs = 0x550; // Vector
    public const int m_bStartDisabled = 0x55C; // bool
    public const int m_flStrength = 0x560; // float
    public const int m_nFalloffShape = 0x564; // int32_t
    public const int m_flFalloffExponent = 0x568; // float
}

public static class C_EnvWind
{
    // C_BaseEntity
    public const int m_EnvWindShared = 0x540; // C_EnvWindShared
}

public static class C_EnvWindClientside
{
    // C_BaseEntity
    public const int m_EnvWindShared = 0x540; // C_EnvWindShared
}

public static class C_EnvWindShared
{
    public const int m_flStartTime = 0x8; // GameTime_t
    public const int m_iWindSeed = 0xC; // uint32_t
    public const int m_iMinWind = 0x10; // uint16_t
    public const int m_iMaxWind = 0x12; // uint16_t
    public const int m_windRadius = 0x14; // int32_t
    public const int m_iMinGust = 0x18; // uint16_t
    public const int m_iMaxGust = 0x1A; // uint16_t
    public const int m_flMinGustDelay = 0x1C; // float
    public const int m_flMaxGustDelay = 0x20; // float
    public const int m_flGustDuration = 0x24; // float
    public const int m_iGustDirChange = 0x28; // uint16_t
    public const int m_location = 0x2C; // Vector
    public const int m_iszGustSound = 0x38; // int32_t
    public const int m_iWindDir = 0x3C; // int32_t
    public const int m_flWindSpeed = 0x40; // float
    public const int m_currentWindVector = 0x44; // Vector
    public const int m_CurrentSwayVector = 0x50; // Vector
    public const int m_PrevSwayVector = 0x5C; // Vector
    public const int m_iInitialWindDir = 0x68; // uint16_t
    public const int m_flInitialWindSpeed = 0x6C; // float
    public const int m_flVariationTime = 0x70; // GameTime_t
    public const int m_flSwayTime = 0x74; // GameTime_t
    public const int m_flSimTime = 0x78; // GameTime_t
    public const int m_flSwitchTime = 0x7C; // GameTime_t
    public const int m_flAveWindSpeed = 0x80; // float
    public const int m_bGusting = 0x84; // bool
    public const int m_flWindAngleVariation = 0x88; // float
    public const int m_flWindSpeedVariation = 0x8C; // float
    public const int m_iEntIndex = 0x90; // CEntityIndex
}

public static class C_EnvWindShared_WindAveEvent_t
{
    public const int m_flStartWindSpeed = 0x0; // float
    public const int m_flAveWindSpeed = 0x4; // float
}

public static class C_EnvWindShared_WindVariationEvent_t
{
    public const int m_flWindAngleVariation = 0x0; // float
    public const int m_flWindSpeedVariation = 0x4; // float
}

public static class C_FireCrackerBlast
{
    // C_Inferno
}

public static class C_FireFromAboveSprite
{
    // C_Sprite
}

public static class C_FireSmoke
{
    // C_BaseFire
    public const int m_nFlameModelIndex = 0x550; // int32_t
    public const int m_nFlameFromAboveModelIndex = 0x554; // int32_t
    public const int m_flScaleRegister = 0x558; // float
    public const int m_flScaleStart = 0x55C; // float
    public const int m_flScaleEnd = 0x560; // float
    public const int m_flScaleTimeStart = 0x564; // GameTime_t
    public const int m_flScaleTimeEnd = 0x568; // GameTime_t
    public const int m_flChildFlameSpread = 0x56C; // float
    public const int m_flClipPerc = 0x580; // float
    public const int m_bClipTested = 0x584; // bool
    public const int m_bFadingOut = 0x585; // bool
    public const int m_tParticleSpawn = 0x588; // TimedEvent
    public const int m_pFireOverlay = 0x590; // CFireOverlay*
}

public static class C_FireSprite
{
    // C_Sprite
    public const int m_vecMoveDir = 0xDF0; // Vector
    public const int m_bFadeFromAbove = 0xDFC; // bool
}

public static class C_Fish
{
    // CBaseAnimGraph
    public const int m_pos = 0xE80; // Vector
    public const int m_vel = 0xE8C; // Vector
    public const int m_angles = 0xE98; // QAngle
    public const int m_localLifeState = 0xEA4; // int32_t
    public const int m_deathDepth = 0xEA8; // float
    public const int m_deathAngle = 0xEAC; // float
    public const int m_buoyancy = 0xEB0; // float
    public const int m_wiggleTimer = 0xEB8; // CountdownTimer
    public const int m_wigglePhase = 0xED0; // float
    public const int m_wiggleRate = 0xED4; // float
    public const int m_actualPos = 0xED8; // Vector
    public const int m_actualAngles = 0xEE4; // QAngle
    public const int m_poolOrigin = 0xEF0; // Vector
    public const int m_waterLevel = 0xEFC; // float
    public const int m_gotUpdate = 0xF00; // bool
    public const int m_x = 0xF04; // float
    public const int m_y = 0xF08; // float
    public const int m_z = 0xF0C; // float
    public const int m_angle = 0xF10; // float
    public const int m_errorHistory = 0xF14; // float[20]
    public const int m_errorHistoryIndex = 0xF64; // int32_t
    public const int m_errorHistoryCount = 0xF68; // int32_t
    public const int m_averageError = 0xF6C; // float
}

public static class C_Fists
{
    // C_CSWeaponBase
    public const int m_bPlayingUinterruptableAct = 0x19F0; // bool
    public const int m_nUinterruptableActivity = 0x19F4; // PlayerAnimEvent_t
}

public static class C_Flashbang
{
    // C_BaseCSGrenade
}

public static class C_FlashbangProjectile
{
    // C_BaseCSGrenadeProjectile
}

public static class C_FogController
{
    // C_BaseEntity
    public const int m_fog = 0x540; // fogparams_t
    public const int m_bUseAngles = 0x5A8; // bool
    public const int m_iChangedVariables = 0x5AC; // int32_t
}

public static class C_FootstepControl
{
    // C_BaseTrigger
    public const int m_source = 0xCC8; // CUtlSymbolLarge
    public const int m_destination = 0xCD0; // CUtlSymbolLarge
}

public static class C_FuncBrush
{
    // C_BaseModelEntity
}

public static class C_FuncConveyor
{
    // C_BaseModelEntity
    public const int m_vecMoveDirEntitySpace = 0xCC8; // Vector
    public const int m_flTargetSpeed = 0xCD4; // float
    public const int m_nTransitionStartTick = 0xCD8; // GameTick_t
    public const int m_nTransitionDurationTicks = 0xCDC; // int32_t
    public const int m_flTransitionStartSpeed = 0xCE0; // float
    public const int m_hConveyorModels = 0xCE8; // C_NetworkUtlVectorBase<CHandle<C_BaseEntity>>
    public const int m_flCurrentConveyorOffset = 0xD00; // float
    public const int m_flCurrentConveyorSpeed = 0xD04; // float
}

public static class C_FuncElectrifiedVolume
{
    // C_FuncBrush
    public const int m_nAmbientEffect = 0xCC0; // ParticleIndex_t
    public const int m_EffectName = 0xCC8; // CUtlSymbolLarge
    public const int m_bState = 0xCD0; // bool
}

public static class C_FuncLadder
{
    // C_BaseModelEntity
    public const int m_vecLadderDir = 0xCC0; // Vector
    public const int m_Dismounts = 0xCD0; // CUtlVector<CHandle<C_InfoLadderDismount>>
    public const int m_vecLocalTop = 0xCE8; // Vector
    public const int m_vecPlayerMountPositionTop = 0xCF4; // Vector
    public const int m_vecPlayerMountPositionBottom = 0xD00; // Vector
    public const int m_flAutoRideSpeed = 0xD0C; // float
    public const int m_bDisabled = 0xD10; // bool
    public const int m_bFakeLadder = 0xD11; // bool
    public const int m_bHasSlack = 0xD12; // bool
}

public static class C_FuncMonitor
{
    // C_FuncBrush
    public const int m_targetCamera = 0xCC0; // CUtlString
    public const int m_nResolutionEnum = 0xCC8; // int32_t
    public const int m_bRenderShadows = 0xCCC; // bool
    public const int m_bUseUniqueColorTarget = 0xCCD; // bool
    public const int m_brushModelName = 0xCD0; // CUtlString
    public const int m_hTargetCamera = 0xCD8; // CHandle<C_BaseEntity>
    public const int m_bEnabled = 0xCDC; // bool
    public const int m_bDraw3DSkybox = 0xCDD; // bool
}

public static class C_FuncMoveLinear
{
    // C_BaseToggle
}

public static class C_FuncRotating
{
    // C_BaseModelEntity
}

public static class C_FuncTrackTrain
{
    // C_BaseModelEntity
    public const int m_nLongAxis = 0xCC0; // int32_t
    public const int m_flRadius = 0xCC4; // float
    public const int m_flLineLength = 0xCC8; // float
}

public static class C_GameRules
{
}

public static class C_GameRulesProxy
{
    // C_BaseEntity
}

public static class C_GlobalLight
{
    // C_BaseEntity
    public const int m_WindClothForceHandle = 0xA00; // uint16_t
}

public static class C_GradientFog
{
    // C_BaseEntity
    public const int m_hGradientFogTexture = 0x540; // CStrongHandle<InfoForResourceTypeCTextureBase>
    public const int m_flFogStartDistance = 0x548; // float
    public const int m_flFogEndDistance = 0x54C; // float
    public const int m_bHeightFogEnabled = 0x550; // bool
    public const int m_flFogStartHeight = 0x554; // float
    public const int m_flFogEndHeight = 0x558; // float
    public const int m_flFarZ = 0x55C; // float
    public const int m_flFogMaxOpacity = 0x560; // float
    public const int m_flFogFalloffExponent = 0x564; // float
    public const int m_flFogVerticalExponent = 0x568; // float
    public const int m_fogColor = 0x56C; // Color
    public const int m_flFogStrength = 0x570; // float
    public const int m_flFadeTime = 0x574; // float
    public const int m_bStartDisabled = 0x578; // bool
    public const int m_bIsEnabled = 0x579; // bool
    public const int m_bGradientFogNeedsTextures = 0x57A; // bool
}

public static class C_HEGrenade
{
    // C_BaseCSGrenade
}

public static class C_HEGrenadeProjectile
{
    // C_BaseCSGrenadeProjectile
}

public static class C_HandleTest
{
    // C_BaseEntity
    public const int m_Handle = 0x540; // CHandle<C_BaseEntity>
    public const int m_bSendHandle = 0x544; // bool
}

public static class C_Hostage
{
    // C_BaseCombatCharacter
    public const int m_entitySpottedState = 0x10A8; // EntitySpottedState_t
    public const int m_leader = 0x10C0; // CHandle<C_BaseEntity>
    public const int m_reuseTimer = 0x10C8; // CountdownTimer
    public const int m_vel = 0x10E0; // Vector
    public const int m_isRescued = 0x10EC; // bool
    public const int m_jumpedThisFrame = 0x10ED; // bool
    public const int m_nHostageState = 0x10F0; // int32_t
    public const int m_bHandsHaveBeenCut = 0x10F4; // bool
    public const int m_hHostageGrabber = 0x10F8; // CHandle<C_CSPlayerPawn>
    public const int m_fLastGrabTime = 0x10FC; // GameTime_t
    public const int m_vecGrabbedPos = 0x1100; // Vector
    public const int m_flRescueStartTime = 0x110C; // GameTime_t
    public const int m_flGrabSuccessTime = 0x1110; // GameTime_t
    public const int m_flDropStartTime = 0x1114; // GameTime_t
    public const int m_flDeadOrRescuedTime = 0x1118; // GameTime_t
    public const int m_blinkTimer = 0x1120; // CountdownTimer
    public const int m_lookAt = 0x1138; // Vector
    public const int m_lookAroundTimer = 0x1148; // CountdownTimer
    public const int m_isInit = 0x1160; // bool
    public const int m_eyeAttachment = 0x1161; // AttachmentHandle_t
    public const int m_chestAttachment = 0x1162; // AttachmentHandle_t
    public const int m_pPredictionOwner = 0x1168; // CBasePlayerController*
    public const int m_fNewestAlphaThinkTime = 0x1170; // GameTime_t
}

public static class C_HostageCarriableProp
{
    // CBaseAnimGraph
}

public static class C_IncendiaryGrenade
{
    // C_MolotovGrenade
}

public static class C_Inferno
{
    // C_BaseModelEntity
    public const int m_nfxFireDamageEffect = 0xD00; // ParticleIndex_t
    public const int m_firePositions = 0xD04; // Vector[64]
    public const int m_fireParentPositions = 0x1004; // Vector[64]
    public const int m_bFireIsBurning = 0x1304; // bool[64]
    public const int m_BurnNormal = 0x1344; // Vector[64]
    public const int m_fireCount = 0x1644; // int32_t
    public const int m_nInfernoType = 0x1648; // int32_t
    public const int m_nFireLifetime = 0x164C; // float
    public const int m_bInPostEffectTime = 0x1650; // bool
    public const int m_lastFireCount = 0x1654; // int32_t
    public const int m_nFireEffectTickBegin = 0x1658; // int32_t
    public const int m_drawableCount = 0x8260; // int32_t
    public const int m_blosCheck = 0x8264; // bool
    public const int m_nlosperiod = 0x8268; // int32_t
    public const int m_maxFireHalfWidth = 0x826C; // float
    public const int m_maxFireHeight = 0x8270; // float
    public const int m_minBounds = 0x8274; // Vector
    public const int m_maxBounds = 0x8280; // Vector
    public const int m_flLastGrassBurnThink = 0x828C; // float
}

public static class C_InfoInstructorHintHostageRescueZone
{
    // C_PointEntity
}

public static class C_InfoLadderDismount
{
    // C_BaseEntity
}

public static class C_InfoVisibilityBox
{
    // C_BaseEntity
    public const int m_nMode = 0x544; // int32_t
    public const int m_vBoxSize = 0x548; // Vector
    public const int m_bEnabled = 0x554; // bool
}

public static class C_IronSightController
{
    public const int m_bIronSightAvailable = 0x10; // bool
    public const int m_flIronSightAmount = 0x14; // float
    public const int m_flIronSightAmountGained = 0x18; // float
    public const int m_flIronSightAmountBiased = 0x1C; // float
    public const int m_flIronSightAmount_Interpolated = 0x20; // float
    public const int m_flIronSightAmountGained_Interpolated = 0x24; // float
    public const int m_flIronSightAmountBiased_Interpolated = 0x28; // float
    public const int m_flInterpolationLastUpdated = 0x2C; // float
    public const int m_angDeltaAverage = 0x30; // QAngle[8]
    public const int m_angViewLast = 0x90; // QAngle
    public const int m_vecDotCoords = 0x9C; // Vector2D
    public const int m_flDotBlur = 0xA4; // float
    public const int m_flSpeedRatio = 0xA8; // float
}

public static class C_Item
{
    // C_EconEntity
    public const int m_bShouldGlow = 0x1560; // bool
    public const int m_pReticleHintTextName = 0x1561; // char[256]
}

public static class C_ItemDogtags
{
    // C_Item
    public const int m_OwningPlayer = 0x1668; // CHandle<C_CSPlayerPawn>
    public const int m_KillingPlayer = 0x166C; // CHandle<C_CSPlayerPawn>
}

public static class C_Item_Healthshot
{
    // C_WeaponBaseItem
}

public static class C_Knife
{
    // C_CSWeaponBase
}

public static class C_LightDirectionalEntity
{
    // C_LightEntity
}

public static class C_LightEntity
{
    // C_BaseModelEntity
    public const int m_CLightComponent = 0xCC0; // CLightComponent*
}

public static class C_LightEnvironmentEntity
{
    // C_LightDirectionalEntity
}

public static class C_LightGlow
{
    // C_BaseModelEntity
    public const int m_nHorizontalSize = 0xCC0; // uint32_t
    public const int m_nVerticalSize = 0xCC4; // uint32_t
    public const int m_nMinDist = 0xCC8; // uint32_t
    public const int m_nMaxDist = 0xCCC; // uint32_t
    public const int m_nOuterMaxDist = 0xCD0; // uint32_t
    public const int m_flGlowProxySize = 0xCD4; // float
    public const int m_flHDRColorScale = 0xCD8; // float
    public const int m_Glow = 0xCE0; // C_LightGlowOverlay
}

public static class C_LightGlowOverlay
{
    // CGlowOverlay
    public const int m_vecOrigin = 0xD0; // Vector
    public const int m_vecDirection = 0xDC; // Vector
    public const int m_nMinDist = 0xE8; // int32_t
    public const int m_nMaxDist = 0xEC; // int32_t
    public const int m_nOuterMaxDist = 0xF0; // int32_t
    public const int m_bOneSided = 0xF4; // bool
    public const int m_bModulateByDot = 0xF5; // bool
}

public static class C_LightOrthoEntity
{
    // C_LightEntity
}

public static class C_LightSpotEntity
{
    // C_LightEntity
}

public static class C_LocalTempEntity
{
    // CBaseAnimGraph
    public const int flags = 0xE98; // int32_t
    public const int die = 0xE9C; // GameTime_t
    public const int m_flFrameMax = 0xEA0; // float
    public const int x = 0xEA4; // float
    public const int y = 0xEA8; // float
    public const int fadeSpeed = 0xEAC; // float
    public const int bounceFactor = 0xEB0; // float
    public const int hitSound = 0xEB4; // int32_t
    public const int priority = 0xEB8; // int32_t
    public const int tentOffset = 0xEBC; // Vector
    public const int m_vecTempEntAngVelocity = 0xEC8; // QAngle
    public const int tempent_renderamt = 0xED4; // int32_t
    public const int m_vecNormal = 0xED8; // Vector
    public const int m_flSpriteScale = 0xEE4; // float
    public const int m_nFlickerFrame = 0xEE8; // int32_t
    public const int m_flFrameRate = 0xEEC; // float
    public const int m_flFrame = 0xEF0; // float
    public const int m_pszImpactEffect = 0xEF8; // char*
    public const int m_pszParticleEffect = 0xF00; // char*
    public const int m_bParticleCollision = 0xF08; // bool
    public const int m_iLastCollisionFrame = 0xF0C; // int32_t
    public const int m_vLastCollisionOrigin = 0xF10; // Vector
    public const int m_vecTempEntVelocity = 0xF1C; // Vector
    public const int m_vecPrevAbsOrigin = 0xF28; // Vector
    public const int m_vecTempEntAcceleration = 0xF34; // Vector
}

public static class C_MapPreviewParticleSystem
{
    // C_ParticleSystem
}

public static class C_MapVetoPickController
{
    // C_BaseEntity
    public const int m_nDraftType = 0x550; // int32_t
    public const int m_nTeamWinningCoinToss = 0x554; // int32_t
    public const int m_nTeamWithFirstChoice = 0x558; // int32_t[64]
    public const int m_nVoteMapIdsList = 0x658; // int32_t[7]
    public const int m_nAccountIDs = 0x674; // int32_t[64]
    public const int m_nMapId0 = 0x774; // int32_t[64]
    public const int m_nMapId1 = 0x874; // int32_t[64]
    public const int m_nMapId2 = 0x974; // int32_t[64]
    public const int m_nMapId3 = 0xA74; // int32_t[64]
    public const int m_nMapId4 = 0xB74; // int32_t[64]
    public const int m_nMapId5 = 0xC74; // int32_t[64]
    public const int m_nStartingSide0 = 0xD74; // int32_t[64]
    public const int m_nCurrentPhase = 0xE74; // int32_t
    public const int m_nPhaseStartTick = 0xE78; // int32_t
    public const int m_nPhaseDurationTicks = 0xE7C; // int32_t
    public const int m_nPostDataUpdateTick = 0xE80; // int32_t
    public const int m_bDisabledHud = 0xE84; // bool
}

public static class C_Melee
{
    // C_CSWeaponBase
    public const int m_flThrowAt = 0x19F0; // GameTime_t
}

public static class C_ModelPointEntity
{
    // C_BaseModelEntity
}

public static class C_MolotovGrenade
{
    // C_BaseCSGrenade
}

public static class C_MolotovProjectile
{
    // C_BaseCSGrenadeProjectile
    public const int m_bIsIncGrenade = 0x1100; // bool
}

public static class C_Multimeter
{
    // CBaseAnimGraph
    public const int m_hTargetC4 = 0xE88; // CHandle<C_PlantedC4>
}

public static class C_MultiplayRules
{
    // C_GameRules
}

public static class C_NetTestBaseCombatCharacter
{
    // C_BaseCombatCharacter
}

public static class C_OmniLight
{
    // C_BarnLight
    public const int m_flInnerAngle = 0xF08; // float
    public const int m_flOuterAngle = 0xF0C; // float
    public const int m_bShowLight = 0xF10; // bool
}

public static class C_ParticleSystem
{
    // C_BaseModelEntity
    public const int m_szSnapshotFileName = 0xCC0; // char[512]
    public const int m_bActive = 0xEC0; // bool
    public const int m_bFrozen = 0xEC1; // bool
    public const int m_flFreezeTransitionDuration = 0xEC4; // float
    public const int m_nStopType = 0xEC8; // int32_t
    public const int m_bAnimateDuringGameplayPause = 0xECC; // bool
    public const int m_iEffectIndex = 0xED0; // CStrongHandle<InfoForResourceTypeIParticleSystemDefinition>
    public const int m_flStartTime = 0xED8; // GameTime_t
    public const int m_flPreSimTime = 0xEDC; // float
    public const int m_vServerControlPoints = 0xEE0; // Vector[4]
    public const int m_iServerControlPointAssignments = 0xF10; // uint8_t[4]
    public const int m_hControlPointEnts = 0xF14; // CHandle<C_BaseEntity>[64]
    public const int m_bNoSave = 0x1014; // bool
    public const int m_bNoFreeze = 0x1015; // bool
    public const int m_bNoRamp = 0x1016; // bool
    public const int m_bStartActive = 0x1017; // bool
    public const int m_iszEffectName = 0x1018; // CUtlSymbolLarge
    public const int m_iszControlPointNames = 0x1020; // CUtlSymbolLarge[64]
    public const int m_nDataCP = 0x1220; // int32_t
    public const int m_vecDataCPValue = 0x1224; // Vector
    public const int m_nTintCP = 0x1230; // int32_t
    public const int m_clrTint = 0x1234; // Color
    public const int m_bOldActive = 0x1258; // bool
    public const int m_bOldFrozen = 0x1259; // bool
}

public static class C_PathParticleRope
{
    // C_BaseEntity
    public const int m_bStartActive = 0x540; // bool
    public const int m_flMaxSimulationTime = 0x544; // float
    public const int m_iszEffectName = 0x548; // CUtlSymbolLarge
    public const int m_PathNodes_Name = 0x550; // CUtlVector<CUtlSymbolLarge>
    public const int m_flParticleSpacing = 0x568; // float
    public const int m_flSlack = 0x56C; // float
    public const int m_flRadius = 0x570; // float
    public const int m_ColorTint = 0x574; // Color
    public const int m_nEffectState = 0x578; // int32_t
    public const int m_iEffectIndex = 0x580; // CStrongHandle<InfoForResourceTypeIParticleSystemDefinition>
    public const int m_PathNodes_Position = 0x588; // C_NetworkUtlVectorBase<Vector>
    public const int m_PathNodes_TangentIn = 0x5A0; // C_NetworkUtlVectorBase<Vector>
    public const int m_PathNodes_TangentOut = 0x5B8; // C_NetworkUtlVectorBase<Vector>
    public const int m_PathNodes_Color = 0x5D0; // C_NetworkUtlVectorBase<Vector>
    public const int m_PathNodes_PinEnabled = 0x5E8; // C_NetworkUtlVectorBase<bool>
    public const int m_PathNodes_RadiusScale = 0x600; // C_NetworkUtlVectorBase<float>
}

public static class C_PathParticleRopeAlias_path_particle_rope_clientside
{
    // C_PathParticleRope
}

public static class C_PhysBox
{
    // C_Breakable
}

public static class C_PhysMagnet
{
    // CBaseAnimGraph
    public const int m_aAttachedObjectsFromServer = 0xE80; // CUtlVector<int32_t>
    public const int m_aAttachedObjects = 0xE98; // CUtlVector<CHandle<C_BaseEntity>>
}

public static class C_PhysPropClientside
{
    // C_BreakableProp
    public const int m_flTouchDelta = 0xFD0; // GameTime_t
    public const int m_fDeathTime = 0xFD4; // GameTime_t
    public const int m_impactEnergyScale = 0xFD8; // float
    public const int m_inertiaScale = 0xFDC; // float
    public const int m_flDmgModBullet = 0xFE0; // float
    public const int m_flDmgModClub = 0xFE4; // float
    public const int m_flDmgModExplosive = 0xFE8; // float
    public const int m_flDmgModFire = 0xFEC; // float
    public const int m_iszPhysicsDamageTableName = 0xFF0; // CUtlSymbolLarge
    public const int m_iszBasePropData = 0xFF8; // CUtlSymbolLarge
    public const int m_iInteractions = 0x1000; // int32_t
    public const int m_bHasBreakPiecesOrCommands = 0x1004; // bool
    public const int m_vecDamagePosition = 0x1008; // Vector
    public const int m_vecDamageDirection = 0x1014; // Vector
    public const int m_nDamageType = 0x1020; // int32_t
}

public static class C_PhysicsProp
{
    // C_BreakableProp
    public const int m_bAwake = 0xFD0; // bool
}

public static class C_PhysicsPropMultiplayer
{
    // C_PhysicsProp
}

public static class C_PickUpModelSlerper
{
    // CBaseAnimGraph
    public const int m_hPlayerParent = 0xE80; // CHandle<C_BaseEntity>
    public const int m_hItem = 0xE84; // CHandle<C_BaseEntity>
    public const int m_flTimePickedUp = 0xE88; // float
    public const int m_angOriginal = 0xE8C; // QAngle
    public const int m_vecPosOriginal = 0xE98; // Vector
    public const int m_angRandom = 0xEA8; // QAngle
}

public static class C_PlantedC4
{
    // CBaseAnimGraph
    public const int m_bBombTicking = 0xE80; // bool
    public const int m_nBombSite = 0xE84; // int32_t
    public const int m_nSourceSoundscapeHash = 0xE88; // int32_t
    public const int m_entitySpottedState = 0xE90; // EntitySpottedState_t
    public const int m_flNextGlow = 0xEA8; // GameTime_t
    public const int m_flNextBeep = 0xEAC; // GameTime_t
    public const int m_flC4Blow = 0xEB0; // GameTime_t
    public const int m_bCannotBeDefused = 0xEB4; // bool
    public const int m_bHasExploded = 0xEB5; // bool
    public const int m_flTimerLength = 0xEB8; // float
    public const int m_bBeingDefused = 0xEBC; // bool
    public const int m_bTriggerWarning = 0xEC0; // float
    public const int m_bExplodeWarning = 0xEC4; // float
    public const int m_bC4Activated = 0xEC8; // bool
    public const int m_bTenSecWarning = 0xEC9; // bool
    public const int m_flDefuseLength = 0xECC; // float
    public const int m_flDefuseCountDown = 0xED0; // GameTime_t
    public const int m_bBombDefused = 0xED4; // bool
    public const int m_hBombDefuser = 0xED8; // CHandle<C_CSPlayerPawn>
    public const int m_hControlPanel = 0xEDC; // CHandle<C_BaseEntity>
    public const int m_hDefuserMultimeter = 0xEE0; // CHandle<C_Multimeter>
    public const int m_flNextRadarFlashTime = 0xEE4; // GameTime_t
    public const int m_bRadarFlash = 0xEE8; // bool
    public const int m_pBombDefuser = 0xEEC; // CHandle<C_CSPlayerPawn>
    public const int m_fLastDefuseTime = 0xEF0; // GameTime_t
    public const int m_pPredictionOwner = 0xEF8; // CBasePlayerController*
}

public static class C_PlayerPing
{
    // C_BaseEntity
    public const int m_hPlayer = 0x570; // CHandle<C_CSPlayerPawn>
    public const int m_hPingedEntity = 0x574; // CHandle<C_BaseEntity>
    public const int m_iType = 0x578; // int32_t
    public const int m_bUrgent = 0x57C; // bool
    public const int m_szPlaceName = 0x57D; // char[18]
}

public static class C_PlayerSprayDecal
{
    // C_ModelPointEntity
    public const int m_nUniqueID = 0xCC0; // int32_t
    public const int m_unAccountID = 0xCC4; // uint32_t
    public const int m_unTraceID = 0xCC8; // uint32_t
    public const int m_rtGcTime = 0xCCC; // uint32_t
    public const int m_vecEndPos = 0xCD0; // Vector
    public const int m_vecStart = 0xCDC; // Vector
    public const int m_vecLeft = 0xCE8; // Vector
    public const int m_vecNormal = 0xCF4; // Vector
    public const int m_nPlayer = 0xD00; // int32_t
    public const int m_nEntity = 0xD04; // int32_t
    public const int m_nHitbox = 0xD08; // int32_t
    public const int m_flCreationTime = 0xD0C; // float
    public const int m_nTintID = 0xD10; // int32_t
    public const int m_nVersion = 0xD14; // uint8_t
    public const int m_ubSignature = 0xD15; // uint8_t[128]
    public const int m_SprayRenderHelper = 0xDA0; // CPlayerSprayDecalRenderHelper
}

public static class C_PlayerVisibility
{
    // C_BaseEntity
    public const int m_flVisibilityStrength = 0x540; // float
    public const int m_flFogDistanceMultiplier = 0x544; // float
    public const int m_flFogMaxDensityMultiplier = 0x548; // float
    public const int m_flFadeTime = 0x54C; // float
    public const int m_bStartDisabled = 0x550; // bool
    public const int m_bIsEnabled = 0x551; // bool
}

public static class C_PointCamera
{
    // C_BaseEntity
    public const int m_FOV = 0x540; // float
    public const int m_Resolution = 0x544; // float
    public const int m_bFogEnable = 0x548; // bool
    public const int m_FogColor = 0x549; // Color
    public const int m_flFogStart = 0x550; // float
    public const int m_flFogEnd = 0x554; // float
    public const int m_flFogMaxDensity = 0x558; // float
    public const int m_bActive = 0x55C; // bool
    public const int m_bUseScreenAspectRatio = 0x55D; // bool
    public const int m_flAspectRatio = 0x560; // float
    public const int m_bNoSky = 0x564; // bool
    public const int m_fBrightness = 0x568; // float
    public const int m_flZFar = 0x56C; // float
    public const int m_flZNear = 0x570; // float
    public const int m_bCanHLTVUse = 0x574; // bool
    public const int m_bDofEnabled = 0x575; // bool
    public const int m_flDofNearBlurry = 0x578; // float
    public const int m_flDofNearCrisp = 0x57C; // float
    public const int m_flDofFarCrisp = 0x580; // float
    public const int m_flDofFarBlurry = 0x584; // float
    public const int m_flDofTiltToGround = 0x588; // float
    public const int m_TargetFOV = 0x58C; // float
    public const int m_DegreesPerSecond = 0x590; // float
    public const int m_bIsOn = 0x594; // bool
    public const int m_pNext = 0x598; // C_PointCamera*
}

public static class C_PointCameraVFOV
{
    // C_PointCamera
    public const int m_flVerticalFOV = 0x5A0; // float
}

public static class C_PointClientUIDialog
{
    // C_BaseClientUIEntity
    public const int m_hActivator = 0xCF0; // CHandle<C_BaseEntity>
    public const int m_bStartEnabled = 0xCF4; // bool
}

public static class C_PointClientUIHUD
{
    // C_BaseClientUIEntity
    public const int m_bCheckCSSClasses = 0xCF8; // bool
    public const int m_bIgnoreInput = 0xE80; // bool
    public const int m_flWidth = 0xE84; // float
    public const int m_flHeight = 0xE88; // float
    public const int m_flDPI = 0xE8C; // float
    public const int m_flInteractDistance = 0xE90; // float
    public const int m_flDepthOffset = 0xE94; // float
    public const int m_unOwnerContext = 0xE98; // uint32_t
    public const int m_unHorizontalAlign = 0xE9C; // uint32_t
    public const int m_unVerticalAlign = 0xEA0; // uint32_t
    public const int m_unOrientation = 0xEA4; // uint32_t
    public const int m_bAllowInteractionFromAllSceneWorlds = 0xEA8; // bool
    public const int m_vecCSSClasses = 0xEB0; // C_NetworkUtlVectorBase<CUtlSymbolLarge>
}

public static class C_PointClientUIWorldPanel
{
    // C_BaseClientUIEntity
    public const int m_bForceRecreateNextUpdate = 0xCF8; // bool
    public const int m_bMoveViewToPlayerNextThink = 0xCF9; // bool
    public const int m_bCheckCSSClasses = 0xCFA; // bool
    public const int m_anchorDeltaTransform = 0xD00; // CTransform
    public const int m_pOffScreenIndicator = 0xEA0; // CPointOffScreenIndicatorUi*
    public const int m_bIgnoreInput = 0xEC8; // bool
    public const int m_bLit = 0xEC9; // bool
    public const int m_bFollowPlayerAcrossTeleport = 0xECA; // bool
    public const int m_flWidth = 0xECC; // float
    public const int m_flHeight = 0xED0; // float
    public const int m_flDPI = 0xED4; // float
    public const int m_flInteractDistance = 0xED8; // float
    public const int m_flDepthOffset = 0xEDC; // float
    public const int m_unOwnerContext = 0xEE0; // uint32_t
    public const int m_unHorizontalAlign = 0xEE4; // uint32_t
    public const int m_unVerticalAlign = 0xEE8; // uint32_t
    public const int m_unOrientation = 0xEEC; // uint32_t
    public const int m_bAllowInteractionFromAllSceneWorlds = 0xEF0; // bool
    public const int m_vecCSSClasses = 0xEF8; // C_NetworkUtlVectorBase<CUtlSymbolLarge>
    public const int m_bOpaque = 0xF10; // bool
    public const int m_bNoDepth = 0xF11; // bool
    public const int m_bRenderBackface = 0xF12; // bool
    public const int m_bUseOffScreenIndicator = 0xF13; // bool
    public const int m_bExcludeFromSaveGames = 0xF14; // bool
    public const int m_bGrabbable = 0xF15; // bool
    public const int m_bOnlyRenderToTexture = 0xF16; // bool
    public const int m_bDisableMipGen = 0xF17; // bool
    public const int m_nExplicitImageLayout = 0xF18; // int32_t
}

public static class C_PointClientUIWorldTextPanel
{
    // C_PointClientUIWorldPanel
    public const int m_messageText = 0xF20; // char[512]
}

public static class C_PointCommentaryNode
{
    // CBaseAnimGraph
    public const int m_bActive = 0xE88; // bool
    public const int m_bWasActive = 0xE89; // bool
    public const int m_flEndTime = 0xE8C; // GameTime_t
    public const int m_flStartTime = 0xE90; // GameTime_t
    public const int m_flStartTimeInCommentary = 0xE94; // float
    public const int m_iszCommentaryFile = 0xE98; // CUtlSymbolLarge
    public const int m_iszTitle = 0xEA0; // CUtlSymbolLarge
    public const int m_iszSpeakers = 0xEA8; // CUtlSymbolLarge
    public const int m_iNodeNumber = 0xEB0; // int32_t
    public const int m_iNodeNumberMax = 0xEB4; // int32_t
    public const int m_bListenedTo = 0xEB8; // bool
    public const int m_hViewPosition = 0xEC8; // CHandle<C_BaseEntity>
    public const int m_bRestartAfterRestore = 0xECC; // bool
}

public static class C_PointEntity
{
    // C_BaseEntity
}

public static class C_PointValueRemapper
{
    // C_BaseEntity
    public const int m_bDisabled = 0x540; // bool
    public const int m_bDisabledOld = 0x541; // bool
    public const int m_bUpdateOnClient = 0x542; // bool
    public const int m_nInputType = 0x544; // ValueRemapperInputType_t
    public const int m_hRemapLineStart = 0x548; // CHandle<C_BaseEntity>
    public const int m_hRemapLineEnd = 0x54C; // CHandle<C_BaseEntity>
    public const int m_flMaximumChangePerSecond = 0x550; // float
    public const int m_flDisengageDistance = 0x554; // float
    public const int m_flEngageDistance = 0x558; // float
    public const int m_bRequiresUseKey = 0x55C; // bool
    public const int m_nOutputType = 0x560; // ValueRemapperOutputType_t
    public const int m_hOutputEntities = 0x568; // C_NetworkUtlVectorBase<CHandle<C_BaseEntity>>
    public const int m_nHapticsType = 0x580; // ValueRemapperHapticsType_t
    public const int m_nMomentumType = 0x584; // ValueRemapperMomentumType_t
    public const int m_flMomentumModifier = 0x588; // float
    public const int m_flSnapValue = 0x58C; // float
    public const int m_flCurrentMomentum = 0x590; // float
    public const int m_nRatchetType = 0x594; // ValueRemapperRatchetType_t
    public const int m_flRatchetOffset = 0x598; // float
    public const int m_flInputOffset = 0x59C; // float
    public const int m_bEngaged = 0x5A0; // bool
    public const int m_bFirstUpdate = 0x5A1; // bool
    public const int m_flPreviousValue = 0x5A4; // float
    public const int m_flPreviousUpdateTickTime = 0x5A8; // GameTime_t
    public const int m_vecPreviousTestPoint = 0x5AC; // Vector
}

public static class C_PointWorldText
{
    // C_ModelPointEntity
    public const int m_bForceRecreateNextUpdate = 0xCC8; // bool
    public const int m_messageText = 0xCD8; // char[512]
    public const int m_FontName = 0xED8; // char[64]
    public const int m_bEnabled = 0xF18; // bool
    public const int m_bFullbright = 0xF19; // bool
    public const int m_flWorldUnitsPerPx = 0xF1C; // float
    public const int m_flFontSize = 0xF20; // float
    public const int m_flDepthOffset = 0xF24; // float
    public const int m_Color = 0xF28; // Color
    public const int m_nJustifyHorizontal = 0xF2C; // PointWorldTextJustifyHorizontal_t
    public const int m_nJustifyVertical = 0xF30; // PointWorldTextJustifyVertical_t
    public const int m_nReorientMode = 0xF34; // PointWorldTextReorientMode_t
}

public static class C_PostProcessingVolume
{
    // C_BaseTrigger
    public const int m_hPostSettings = 0xCD8; // CStrongHandle<InfoForResourceTypeCPostProcessingResource>
    public const int m_flFadeDuration = 0xCE0; // float
    public const int m_flMinLogExposure = 0xCE4; // float
    public const int m_flMaxLogExposure = 0xCE8; // float
    public const int m_flMinExposure = 0xCEC; // float
    public const int m_flMaxExposure = 0xCF0; // float
    public const int m_flExposureCompensation = 0xCF4; // float
    public const int m_flExposureFadeSpeedUp = 0xCF8; // float
    public const int m_flExposureFadeSpeedDown = 0xCFC; // float
    public const int m_flTonemapEVSmoothingRange = 0xD00; // float
    public const int m_bMaster = 0xD04; // bool
    public const int m_bExposureControl = 0xD05; // bool
    public const int m_flRate = 0xD08; // float
    public const int m_flTonemapPercentTarget = 0xD0C; // float
    public const int m_flTonemapPercentBrightPixels = 0xD10; // float
    public const int m_flTonemapMinAvgLum = 0xD14; // float
}

public static class C_Precipitation
{
    // C_BaseTrigger
    public const int m_flDensity = 0xCC8; // float
    public const int m_flParticleInnerDist = 0xCD8; // float
    public const int m_pParticleDef = 0xCE0; // char*
    public const int m_tParticlePrecipTraceTimer = 0xD08; // TimedEvent[1]
    public const int m_bActiveParticlePrecipEmitter = 0xD10; // bool[1]
    public const int m_bParticlePrecipInitialized = 0xD11; // bool
    public const int m_bHasSimulatedSinceLastSceneObjectUpdate = 0xD12; // bool
    public const int m_nAvailableSheetSequencesMaxIndex = 0xD14; // int32_t
}

public static class C_PrecipitationBlocker
{
    // C_BaseModelEntity
}

public static class C_PredictedViewModel
{
    // C_BaseViewModel
    public const int m_LagAnglesHistory = 0xEE8; // QAngle
    public const int m_vPredictedOffset = 0xF00; // Vector
}

public static class C_RagdollManager
{
    // C_BaseEntity
    public const int m_iCurrentMaxRagdollCount = 0x540; // int8_t
}

public static class C_RagdollProp
{
    // CBaseAnimGraph
    public const int m_ragPos = 0xE88; // C_NetworkUtlVectorBase<Vector>
    public const int m_ragAngles = 0xEA0; // C_NetworkUtlVectorBase<QAngle>
    public const int m_flBlendWeight = 0xEB8; // float
    public const int m_hRagdollSource = 0xEBC; // CHandle<C_BaseEntity>
    public const int m_iEyeAttachment = 0xEC0; // AttachmentHandle_t
    public const int m_flBlendWeightCurrent = 0xEC4; // float
    public const int m_parentPhysicsBoneIndices = 0xEC8; // CUtlVector<int32_t>
    public const int m_worldSpaceBoneComputationOrder = 0xEE0; // CUtlVector<int32_t>
}

public static class C_RagdollPropAttached
{
    // C_RagdollProp
    public const int m_boneIndexAttached = 0xEF8; // uint32_t
    public const int m_ragdollAttachedObjectIndex = 0xEFC; // uint32_t
    public const int m_attachmentPointBoneSpace = 0xF00; // Vector
    public const int m_attachmentPointRagdollSpace = 0xF0C; // Vector
    public const int m_vecOffset = 0xF18; // Vector
    public const int m_parentTime = 0xF24; // float
    public const int m_bHasParent = 0xF28; // bool
}

public static class C_RectLight
{
    // C_BarnLight
    public const int m_bShowLight = 0xF08; // bool
}

public static class C_RetakeGameRules
{
    public const int m_nMatchSeed = 0xF8; // int32_t
    public const int m_bBlockersPresent = 0xFC; // bool
    public const int m_bRoundInProgress = 0xFD; // bool
    public const int m_iFirstSecondHalfRound = 0x100; // int32_t
    public const int m_iBombSite = 0x104; // int32_t
}

public static class C_RopeKeyframe
{
    // C_BaseModelEntity
    public const int m_LinksTouchingSomething = 0xCC8; // CBitVec<10>
    public const int m_nLinksTouchingSomething = 0xCCC; // int32_t
    public const int m_bApplyWind = 0xCD0; // bool
    public const int m_fPrevLockedPoints = 0xCD4; // int32_t
    public const int m_iForcePointMoveCounter = 0xCD8; // int32_t
    public const int m_bPrevEndPointPos = 0xCDC; // bool[2]
    public const int m_vPrevEndPointPos = 0xCE0; // Vector[2]
    public const int m_flCurScroll = 0xCF8; // float
    public const int m_flScrollSpeed = 0xCFC; // float
    public const int m_RopeFlags = 0xD00; // uint16_t
    public const int m_iRopeMaterialModelIndex = 0xD08; // CStrongHandle<InfoForResourceTypeIMaterial2>
    public const int m_LightValues = 0xF80; // Vector[10]
    public const int m_nSegments = 0xFF8; // uint8_t
    public const int m_hStartPoint = 0xFFC; // CHandle<C_BaseEntity>
    public const int m_hEndPoint = 0x1000; // CHandle<C_BaseEntity>
    public const int m_iStartAttachment = 0x1004; // AttachmentHandle_t
    public const int m_iEndAttachment = 0x1005; // AttachmentHandle_t
    public const int m_Subdiv = 0x1006; // uint8_t
    public const int m_RopeLength = 0x1008; // int16_t
    public const int m_Slack = 0x100A; // int16_t
    public const int m_TextureScale = 0x100C; // float
    public const int m_fLockedPoints = 0x1010; // uint8_t
    public const int m_nChangeCount = 0x1011; // uint8_t
    public const int m_Width = 0x1014; // float
    public const int m_PhysicsDelegate = 0x1018; // C_RopeKeyframe::CPhysicsDelegate
    public const int m_hMaterial = 0x1028; // CStrongHandle<InfoForResourceTypeIMaterial2>
    public const int m_TextureHeight = 0x1030; // int32_t
    public const int m_vecImpulse = 0x1034; // Vector
    public const int m_vecPreviousImpulse = 0x1040; // Vector
    public const int m_flCurrentGustTimer = 0x104C; // float
    public const int m_flCurrentGustLifetime = 0x1050; // float
    public const int m_flTimeToNextGust = 0x1054; // float
    public const int m_vWindDir = 0x1058; // Vector
    public const int m_vColorMod = 0x1064; // Vector
    public const int m_vCachedEndPointAttachmentPos = 0x1070; // Vector[2]
    public const int m_vCachedEndPointAttachmentAngle = 0x1088; // QAngle[2]
    public const int m_bConstrainBetweenEndpoints = 0x10A0; // bool
    public const int m_bEndPointAttachmentPositionsDirty = 0x0; // bitfield:1
    public const int m_bEndPointAttachmentAnglesDirty = 0x0; // bitfield:1
    public const int m_bNewDataThisFrame = 0x0; // bitfield:1
    public const int m_bPhysicsInitted = 0x0; // bitfield:1
}

public static class C_RopeKeyframe_CPhysicsDelegate
{
    public const int m_pKeyframe = 0x8; // C_RopeKeyframe*
}

public static class C_SceneEntity
{
    // C_PointEntity
    public const int m_bIsPlayingBack = 0x548; // bool
    public const int m_bPaused = 0x549; // bool
    public const int m_bMultiplayer = 0x54A; // bool
    public const int m_bAutogenerated = 0x54B; // bool
    public const int m_flForceClientTime = 0x54C; // float
    public const int m_nSceneStringIndex = 0x550; // uint16_t
    public const int m_bClientOnly = 0x552; // bool
    public const int m_hOwner = 0x554; // CHandle<C_BaseFlex>
    public const int m_hActorList = 0x558; // C_NetworkUtlVectorBase<CHandle<C_BaseFlex>>
    public const int m_bWasPlaying = 0x570; // bool
    public const int m_QueuedEvents = 0x580; // CUtlVector<C_SceneEntity::QueuedEvents_t>
    public const int m_flCurrentTime = 0x598; // float
}

public static class C_SceneEntity_QueuedEvents_t
{
    public const int starttime = 0x0; // float
}

public static class C_SensorGrenade
{
    // C_BaseCSGrenade
}

public static class C_SensorGrenadeProjectile
{
    // C_BaseCSGrenadeProjectile
}

public static class C_ShatterGlassShardPhysics
{
    // C_PhysicsProp
    public const int m_ShardDesc = 0xFE0; // shard_model_desc_t
}

public static class C_SingleplayRules
{
    // C_GameRules
}

public static class C_SkyCamera
{
    // C_BaseEntity
    public const int m_skyboxData = 0x540; // sky3dparams_t
    public const int m_skyboxSlotToken = 0x5D0; // CUtlStringToken
    public const int m_bUseAngles = 0x5D4; // bool
    public const int m_pNext = 0x5D8; // C_SkyCamera*
}

public static class C_SmokeGrenade
{
    // C_BaseCSGrenade
}

public static class C_SmokeGrenadeProjectile
{
    // C_BaseCSGrenadeProjectile
    public const int m_nSmokeEffectTickBegin = 0x1108; // int32_t
    public const int m_bDidSmokeEffect = 0x110C; // bool
    public const int m_nRandomSeed = 0x1110; // int32_t
    public const int m_vSmokeColor = 0x1114; // Vector
    public const int m_vSmokeDetonationPos = 0x1120; // Vector
    public const int m_VoxelFrameData = 0x1130; // CUtlVector<uint8_t>
    public const int m_bSmokeVolumeDataReceived = 0x1148; // bool
    public const int m_bSmokeEffectSpawned = 0x1149; // bool
}

public static class C_SoundAreaEntityBase
{
    // C_BaseEntity
    public const int m_bDisabled = 0x540; // bool
    public const int m_bWasEnabled = 0x548; // bool
    public const int m_iszSoundAreaType = 0x550; // CUtlSymbolLarge
    public const int m_vPos = 0x558; // Vector
}

public static class C_SoundAreaEntityOrientedBox
{
    // C_SoundAreaEntityBase
    public const int m_vMin = 0x568; // Vector
    public const int m_vMax = 0x574; // Vector
}

public static class C_SoundAreaEntitySphere
{
    // C_SoundAreaEntityBase
    public const int m_flRadius = 0x568; // float
}

public static class C_SoundOpvarSetAABBEntity
{
    // C_SoundOpvarSetPointEntity
}

public static class C_SoundOpvarSetOBBEntity
{
    // C_SoundOpvarSetAABBEntity
}

public static class C_SoundOpvarSetOBBWindEntity
{
    // C_SoundOpvarSetPointBase
}

public static class C_SoundOpvarSetPathCornerEntity
{
    // C_SoundOpvarSetPointEntity
}

public static class C_SoundOpvarSetPointBase
{
    // C_BaseEntity
    public const int m_iszStackName = 0x540; // CUtlSymbolLarge
    public const int m_iszOperatorName = 0x548; // CUtlSymbolLarge
    public const int m_iszOpvarName = 0x550; // CUtlSymbolLarge
    public const int m_iOpvarIndex = 0x558; // int32_t
    public const int m_bUseAutoCompare = 0x55C; // bool
}

public static class C_SoundOpvarSetPointEntity
{
    // C_SoundOpvarSetPointBase
}

public static class C_SpotlightEnd
{
    // C_BaseModelEntity
    public const int m_flLightScale = 0xCC0; // float
    public const int m_Radius = 0xCC4; // float
}

public static class C_Sprite
{
    // C_BaseModelEntity
    public const int m_hSpriteMaterial = 0xCD8; // CStrongHandle<InfoForResourceTypeIMaterial2>
    public const int m_hAttachedToEntity = 0xCE0; // CHandle<C_BaseEntity>
    public const int m_nAttachment = 0xCE4; // AttachmentHandle_t
    public const int m_flSpriteFramerate = 0xCE8; // float
    public const int m_flFrame = 0xCEC; // float
    public const int m_flDieTime = 0xCF0; // GameTime_t
    public const int m_nBrightness = 0xD00; // uint32_t
    public const int m_flBrightnessDuration = 0xD04; // float
    public const int m_flSpriteScale = 0xD08; // float
    public const int m_flScaleDuration = 0xD0C; // float
    public const int m_bWorldSpaceScale = 0xD10; // bool
    public const int m_flGlowProxySize = 0xD14; // float
    public const int m_flHDRColorScale = 0xD18; // float
    public const int m_flLastTime = 0xD1C; // GameTime_t
    public const int m_flMaxFrame = 0xD20; // float
    public const int m_flStartScale = 0xD24; // float
    public const int m_flDestScale = 0xD28; // float
    public const int m_flScaleTimeStart = 0xD2C; // GameTime_t
    public const int m_nStartBrightness = 0xD30; // int32_t
    public const int m_nDestBrightness = 0xD34; // int32_t
    public const int m_flBrightnessTimeStart = 0xD38; // GameTime_t
    public const int m_hOldSpriteMaterial = 0xD40; // CWeakHandle<InfoForResourceTypeIMaterial2>
    public const int m_nSpriteWidth = 0xDE8; // int32_t
    public const int m_nSpriteHeight = 0xDEC; // int32_t
}

public static class C_SpriteOriented
{
    // C_Sprite
}

public static class C_Sun
{
    // C_BaseModelEntity
    public const int m_fxSSSunFlareEffectIndex = 0xCC0; // ParticleIndex_t
    public const int m_fxSunFlareEffectIndex = 0xCC4; // ParticleIndex_t
    public const int m_fdistNormalize = 0xCC8; // float
    public const int m_vSunPos = 0xCCC; // Vector
    public const int m_vDirection = 0xCD8; // Vector
    public const int m_iszEffectName = 0xCE8; // CUtlSymbolLarge
    public const int m_iszSSEffectName = 0xCF0; // CUtlSymbolLarge
    public const int m_clrOverlay = 0xCF8; // Color
    public const int m_bOn = 0xCFC; // bool
    public const int m_bmaxColor = 0xCFD; // bool
    public const int m_flSize = 0xD00; // float
    public const int m_flHazeScale = 0xD04; // float
    public const int m_flRotation = 0xD08; // float
    public const int m_flHDRColorScale = 0xD0C; // float
    public const int m_flAlphaHaze = 0xD10; // float
    public const int m_flAlphaScale = 0xD14; // float
    public const int m_flAlphaHdr = 0xD18; // float
    public const int m_flFarZScale = 0xD1C; // float
}

public static class C_SunGlowOverlay
{
    // CGlowOverlay
    public const int m_bModulateByDot = 0xD0; // bool
}

public static class C_Team
{
    // C_BaseEntity
    public const int m_aPlayerControllers = 0x540; // C_NetworkUtlVectorBase<CHandle<CBasePlayerController>>
    public const int m_aPlayers = 0x558; // C_NetworkUtlVectorBase<CHandle<C_BasePlayerPawn>>
    public const int m_iScore = 0x570; // int32_t
    public const int m_szTeamname = 0x574; // char[129]
}

public static class C_TeamRoundTimer
{
    // C_BaseEntity
    public const int m_bTimerPaused = 0x540; // bool
    public const int m_flTimeRemaining = 0x544; // float
    public const int m_flTimerEndTime = 0x548; // GameTime_t
    public const int m_bIsDisabled = 0x54C; // bool
    public const int m_bShowInHUD = 0x54D; // bool
    public const int m_nTimerLength = 0x550; // int32_t
    public const int m_nTimerInitialLength = 0x554; // int32_t
    public const int m_nTimerMaxLength = 0x558; // int32_t
    public const int m_bAutoCountdown = 0x55C; // bool
    public const int m_nSetupTimeLength = 0x560; // int32_t
    public const int m_nState = 0x564; // int32_t
    public const int m_bStartPaused = 0x568; // bool
    public const int m_bInCaptureWatchState = 0x569; // bool
    public const int m_flTotalTime = 0x56C; // float
    public const int m_bStopWatchTimer = 0x570; // bool
    public const int m_bFireFinished = 0x571; // bool
    public const int m_bFire5MinRemain = 0x572; // bool
    public const int m_bFire4MinRemain = 0x573; // bool
    public const int m_bFire3MinRemain = 0x574; // bool
    public const int m_bFire2MinRemain = 0x575; // bool
    public const int m_bFire1MinRemain = 0x576; // bool
    public const int m_bFire30SecRemain = 0x577; // bool
    public const int m_bFire10SecRemain = 0x578; // bool
    public const int m_bFire5SecRemain = 0x579; // bool
    public const int m_bFire4SecRemain = 0x57A; // bool
    public const int m_bFire3SecRemain = 0x57B; // bool
    public const int m_bFire2SecRemain = 0x57C; // bool
    public const int m_bFire1SecRemain = 0x57D; // bool
    public const int m_nOldTimerLength = 0x580; // int32_t
    public const int m_nOldTimerState = 0x584; // int32_t
}

public static class C_TeamplayRules
{
    // C_MultiplayRules
}

public static class C_TextureBasedAnimatable
{
    // C_BaseModelEntity
    public const int m_bLoop = 0xCC0; // bool
    public const int m_flFPS = 0xCC4; // float
    public const int m_hPositionKeys = 0xCC8; // CStrongHandle<InfoForResourceTypeCTextureBase>
    public const int m_hRotationKeys = 0xCD0; // CStrongHandle<InfoForResourceTypeCTextureBase>
    public const int m_vAnimationBoundsMin = 0xCD8; // Vector
    public const int m_vAnimationBoundsMax = 0xCE4; // Vector
    public const int m_flStartTime = 0xCF0; // float
    public const int m_flStartFrame = 0xCF4; // float
}

public static class C_TintController
{
    // C_BaseEntity
}

public static class C_TonemapController2
{
    // C_BaseEntity
    public const int m_flAutoExposureMin = 0x540; // float
    public const int m_flAutoExposureMax = 0x544; // float
    public const int m_flTonemapPercentTarget = 0x548; // float
    public const int m_flTonemapPercentBrightPixels = 0x54C; // float
    public const int m_flTonemapMinAvgLum = 0x550; // float
    public const int m_flExposureAdaptationSpeedUp = 0x554; // float
    public const int m_flExposureAdaptationSpeedDown = 0x558; // float
    public const int m_flTonemapEVSmoothingRange = 0x55C; // float
}

public static class C_TonemapController2Alias_env_tonemap_controller2
{
    // C_TonemapController2
}

public static class C_TriggerBuoyancy
{
    // C_BaseTrigger
    public const int m_BuoyancyHelper = 0xCC8; // CBuoyancyHelper
    public const int m_flFluidDensity = 0xCE8; // float
}

public static class C_TriggerLerpObject
{
    // C_BaseTrigger
}

public static class C_TriggerMultiple
{
    // C_BaseTrigger
}

public static class C_TriggerVolume
{
    // C_BaseModelEntity
}

public static class C_ViewmodelAttachmentModel
{
    // CBaseAnimGraph
}

public static class C_ViewmodelWeapon
{
    // CBaseAnimGraph
    public const int m_worldModel = 0xE80; // char*
}

public static class C_VoteController
{
    // C_BaseEntity
    public const int m_iActiveIssueIndex = 0x550; // int32_t
    public const int m_iOnlyTeamToVote = 0x554; // int32_t
    public const int m_nVoteOptionCount = 0x558; // int32_t[5]
    public const int m_nPotentialVotes = 0x56C; // int32_t
    public const int m_bVotesDirty = 0x570; // bool
    public const int m_bTypeDirty = 0x571; // bool
    public const int m_bIsYesNoVote = 0x572; // bool
}

public static class C_WaterBullet
{
    // CBaseAnimGraph
}

public static class C_WeaponAWP
{
    // C_CSWeaponBaseGun
}

public static class C_WeaponAug
{
    // C_CSWeaponBaseGun
}

public static class C_WeaponBaseItem
{
    // C_CSWeaponBase
    public const int m_SequenceCompleteTimer = 0x19F0; // CountdownTimer
    public const int m_bRedraw = 0x1A08; // bool
}

public static class C_WeaponBizon
{
    // C_CSWeaponBaseGun
}

public static class C_WeaponCZ75a
{
    // C_CSWeaponBaseGun
}

public static class C_WeaponElite
{
    // C_CSWeaponBaseGun
}

public static class C_WeaponFamas
{
    // C_CSWeaponBaseGun
}

public static class C_WeaponFiveSeven
{
    // C_CSWeaponBaseGun
}

public static class C_WeaponG3SG1
{
    // C_CSWeaponBaseGun
}

public static class C_WeaponGalilAR
{
    // C_CSWeaponBaseGun
}

public static class C_WeaponGlock
{
    // C_CSWeaponBaseGun
}

public static class C_WeaponHKP2000
{
    // C_CSWeaponBaseGun
}

public static class C_WeaponM249
{
    // C_CSWeaponBaseGun
}

public static class C_WeaponM4A1
{
    // C_CSWeaponBaseGun
}

public static class C_WeaponM4A1Silencer
{
    // C_CSWeaponBaseGun
}

public static class C_WeaponMAC10
{
    // C_CSWeaponBaseGun
}

public static class C_WeaponMP5SD
{
    // C_CSWeaponBaseGun
}

public static class C_WeaponMP7
{
    // C_CSWeaponBaseGun
}

public static class C_WeaponMP9
{
    // C_CSWeaponBaseGun
}

public static class C_WeaponMag7
{
    // C_CSWeaponBaseGun
}

public static class C_WeaponNOVA
{
    // C_CSWeaponBase
}

public static class C_WeaponNegev
{
    // C_CSWeaponBaseGun
}

public static class C_WeaponP250
{
    // C_CSWeaponBaseGun
}

public static class C_WeaponP90
{
    // C_CSWeaponBaseGun
}

public static class C_WeaponRevolver
{
    // C_CSWeaponBaseGun
}

public static class C_WeaponSCAR20
{
    // C_CSWeaponBaseGun
}

public static class C_WeaponSG556
{
    // C_CSWeaponBaseGun
}

public static class C_WeaponSSG08
{
    // C_CSWeaponBaseGun
}

public static class C_WeaponSawedoff
{
    // C_CSWeaponBase
}

public static class C_WeaponShield
{
    // C_CSWeaponBaseGun
    public const int m_flDisplayHealth = 0x1A10; // float
}

public static class C_WeaponTaser
{
    // C_CSWeaponBaseGun
    public const int m_fFireTime = 0x1A10; // GameTime_t
}

public static class C_WeaponTec9
{
    // C_CSWeaponBaseGun
}

public static class C_WeaponUMP45
{
    // C_CSWeaponBaseGun
}

public static class C_WeaponUSPSilencer
{
    // C_CSWeaponBaseGun
}

public static class C_WeaponXM1014
{
    // C_CSWeaponBase
}

public static class C_World
{
    // C_BaseModelEntity
}

public static class C_WorldModelGloves
{
    // CBaseAnimGraph
}

public static class C_WorldModelNametag
{
    // CBaseAnimGraph
}

public static class C_WorldModelStattrak
{
    // CBaseAnimGraph
}

public static class C_fogplayerparams_t
{
    public const int m_hCtrl = 0x8; // CHandle<C_FogController>
    public const int m_flTransitionTime = 0xC; // float
    public const int m_OldColor = 0x10; // Color
    public const int m_flOldStart = 0x14; // float
    public const int m_flOldEnd = 0x18; // float
    public const int m_flOldMaxDensity = 0x1C; // float
    public const int m_flOldHDRColorScale = 0x20; // float
    public const int m_flOldFarZ = 0x24; // float
    public const int m_NewColor = 0x28; // Color
    public const int m_flNewStart = 0x2C; // float
    public const int m_flNewEnd = 0x30; // float
    public const int m_flNewMaxDensity = 0x34; // float
    public const int m_flNewHDRColorScale = 0x38; // float
    public const int m_flNewFarZ = 0x3C; // float
}

public static class CompMatMutatorCondition_t
{
    public const int m_nMutatorCondition = 0x0; // CompMatPropertyMutatorConditionType_t
    public const int m_strMutatorConditionContainerName = 0x8; // CUtlString
    public const int m_strMutatorConditionContainerVarName = 0x10; // CUtlString
    public const int m_strMutatorConditionContainerVarValue = 0x18; // CUtlString
    public const int m_bPassWhenTrue = 0x20; // bool
}

public static class CompMatPropertyMutator_t
{
    public const int m_bEnabled = 0x0; // bool
    public const int m_nMutatorCommandType = 0x4; // CompMatPropertyMutatorType_t
    public const int m_strInitWith_Container = 0x8; // CUtlString
    public const int m_strCopyProperty_InputContainerSrc = 0x10; // CUtlString
    public const int m_strCopyProperty_InputContainerProperty = 0x18; // CUtlString
    public const int m_strCopyProperty_TargetProperty = 0x20; // CUtlString
    public const int m_strRandomRollInputVars_SeedInputVar = 0x28; // CUtlString
    public const int m_vecRandomRollInputVars_InputVarsToRoll = 0x30; // CUtlVector<CUtlString>
    public const int m_strCopyMatchingKeys_InputContainerSrc = 0x48; // CUtlString
    public const int m_strCopyKeysWithSuffix_InputContainerSrc = 0x50; // CUtlString
    public const int m_strCopyKeysWithSuffix_FindSuffix = 0x58; // CUtlString
    public const int m_strCopyKeysWithSuffix_ReplaceSuffix = 0x60; // CUtlString
    public const int m_nSetValue_Value = 0x68; // CompositeMaterialInputLooseVariable_t
    public const int m_strGenerateTexture_TargetParam = 0x2D8; // CUtlString
    public const int m_strGenerateTexture_InitialContainer = 0x2E0; // CUtlString
    public const int m_nResolution = 0x2E8; // int32_t
    public const int m_bIsScratchTarget = 0x2EC; // bool
    public const int m_bSplatDebugInfo = 0x2ED; // bool
    public const int m_bCaptureInRenderDoc = 0x2EE; // bool
    public const int m_vecTexGenInstructions = 0x2F0; // CUtlVector<CompMatPropertyMutator_t>
    public const int m_vecConditionalMutators = 0x308; // CUtlVector<CompMatPropertyMutator_t>
    public const int m_strPopInputQueue_Container = 0x320; // CUtlString
    public const int m_strDrawText_InputContainerSrc = 0x328; // CUtlString
    public const int m_strDrawText_InputContainerProperty = 0x330; // CUtlString
    public const int m_vecDrawText_Position = 0x338; // Vector2D
    public const int m_colDrawText_Color = 0x340; // Color
    public const int m_strDrawText_Font = 0x348; // CUtlString
    public const int m_vecConditions = 0x350; // CUtlVector<CompMatMutatorCondition_t>
}

public static class CompositeMaterialAssemblyProcedure_t
{
    public const int m_vecCompMatIncludes = 0x0; // CUtlVector<CResourceName>
    public const int m_vecMatchFilters = 0x18; // CUtlVector<CompositeMaterialMatchFilter_t>
    public const int m_vecCompositeInputContainers = 0x30; // CUtlVector<CompositeMaterialInputContainer_t>
    public const int m_vecPropertyMutators = 0x48; // CUtlVector<CompMatPropertyMutator_t>
}

public static class CompositeMaterialEditorPoint_t
{
    public const int m_ModelName = 0x0; // CResourceName
    public const int m_nSequenceIndex = 0xE0; // int32_t
    public const int m_flCycle = 0xE4; // float
    public const int m_KVModelStateChoices = 0xE8; // KeyValues3
    public const int m_bEnableChildModel = 0xF8; // bool
    public const int m_ChildModelName = 0x100; // CResourceName

    public const int
        m_vecCompositeMaterialAssemblyProcedures = 0x1E0; // CUtlVector<CompositeMaterialAssemblyProcedure_t>

    public const int m_vecCompositeMaterials = 0x1F8; // CUtlVector<CompositeMaterial_t>
}

public static class CompositeMaterialInputContainer_t
{
    public const int m_bEnabled = 0x0; // bool
    public const int m_nCompositeMaterialInputContainerSourceType = 0x4; // CompositeMaterialInputContainerSourceType_t
    public const int m_strSpecificContainerMaterial = 0x8; // CResourceName
    public const int m_strAttrName = 0xE8; // CUtlString
    public const int m_strAlias = 0xF0; // CUtlString
    public const int m_vecLooseVariables = 0xF8; // CUtlVector<CompositeMaterialInputLooseVariable_t>
    public const int m_strAttrNameForVar = 0x110; // CUtlString
    public const int m_bExposeExternally = 0x118; // bool
}

public static class CompositeMaterialInputLooseVariable_t
{
    public const int m_strName = 0x0; // CUtlString
    public const int m_bExposeExternally = 0x8; // bool
    public const int m_strExposedFriendlyName = 0x10; // CUtlString
    public const int m_strExposedFriendlyGroupName = 0x18; // CUtlString
    public const int m_bExposedVariableIsFixedRange = 0x20; // bool
    public const int m_strExposedVisibleWhenTrue = 0x28; // CUtlString
    public const int m_strExposedHiddenWhenTrue = 0x30; // CUtlString
    public const int m_nVariableType = 0x38; // CompositeMaterialInputLooseVariableType_t
    public const int m_bValueBoolean = 0x3C; // bool
    public const int m_nValueIntX = 0x40; // int32_t
    public const int m_nValueIntY = 0x44; // int32_t
    public const int m_nValueIntZ = 0x48; // int32_t
    public const int m_nValueIntW = 0x4C; // int32_t
    public const int m_bHasFloatBounds = 0x50; // bool
    public const int m_flValueFloatX = 0x54; // float
    public const int m_flValueFloatX_Min = 0x58; // float
    public const int m_flValueFloatX_Max = 0x5C; // float
    public const int m_flValueFloatY = 0x60; // float
    public const int m_flValueFloatY_Min = 0x64; // float
    public const int m_flValueFloatY_Max = 0x68; // float
    public const int m_flValueFloatZ = 0x6C; // float
    public const int m_flValueFloatZ_Min = 0x70; // float
    public const int m_flValueFloatZ_Max = 0x74; // float
    public const int m_flValueFloatW = 0x78; // float
    public const int m_flValueFloatW_Min = 0x7C; // float
    public const int m_flValueFloatW_Max = 0x80; // float
    public const int m_cValueColor4 = 0x84; // Color
    public const int m_nValueSystemVar = 0x88; // CompositeMaterialVarSystemVar_t
    public const int m_strResourceMaterial = 0x90; // CResourceName
    public const int m_strTextureContentAssetPath = 0x170; // CUtlString
    public const int m_strTextureRuntimeResourcePath = 0x178; // CResourceName
    public const int m_strTextureCompilationVtexTemplate = 0x258; // CUtlString
    public const int m_nTextureType = 0x260; // CompositeMaterialInputTextureType_t
    public const int m_strString = 0x268; // CUtlString
}

public static class CompositeMaterialMatchFilter_t
{
    public const int m_nCompositeMaterialMatchFilterType = 0x0; // CompositeMaterialMatchFilterType_t
    public const int m_strMatchFilter = 0x8; // CUtlString
    public const int m_strMatchValue = 0x10; // CUtlString
    public const int m_bPassWhenTrue = 0x18; // bool
}

public static class CompositeMaterial_t
{
    public const int m_TargetKVs = 0x8; // KeyValues3
    public const int m_PreGenerationKVs = 0x18; // KeyValues3
    public const int m_FinalKVs = 0x28; // KeyValues3
    public const int m_vecGeneratedTextures = 0x40; // CUtlVector<GeneratedTextureHandle_t>
}

public static class CountdownTimer
{
    public const int m_duration = 0x8; // float
    public const int m_timestamp = 0xC; // GameTime_t
    public const int m_timescale = 0x10; // float
    public const int m_nWorldGroupId = 0x14; // WorldGroupId_t
}

public static class EngineCountdownTimer
{
    public const int m_duration = 0x8; // float
    public const int m_timestamp = 0xC; // float
    public const int m_timescale = 0x10; // float
}

public static class EntityRenderAttribute_t
{
    public const int m_ID = 0x30; // CUtlStringToken
    public const int m_Values = 0x34; // Vector4D
}

public static class EntitySpottedState_t
{
    public const int m_bSpotted = 0x8; // bool
    public const int m_bSpottedByMask = 0xC; // uint32_t[2]
}

public static class GeneratedTextureHandle_t
{
    public const int m_strBitmapName = 0x0; // CUtlString
}

public static class IClientAlphaProperty
{
}

public static class IntervalTimer
{
    public const int m_timestamp = 0x8; // GameTime_t
    public const int m_nWorldGroupId = 0xC; // WorldGroupId_t
}

public static class PhysicsRagdollPose_t
{
    public const int __m_pChainEntity = 0x8; // CNetworkVarChainer
    public const int m_Transforms = 0x30; // C_NetworkUtlVectorBase<CTransform>
    public const int m_hOwner = 0x48; // CHandle<C_BaseEntity>
    public const int m_bDirty = 0x68; // bool
}

public static class SellbackPurchaseEntry_t
{
    public const int m_unDefIdx = 0x30; // uint16_t
    public const int m_nCost = 0x34; // int32_t
    public const int m_nPrevArmor = 0x38; // int32_t
    public const int m_bPrevHelmet = 0x3C; // bool
    public const int m_hItem = 0x40; // CEntityHandle
}

public static class ServerAuthoritativeWeaponSlot_t
{
    public const int unClass = 0x28; // uint16_t
    public const int unSlot = 0x2A; // uint16_t
    public const int unItemDefIdx = 0x2C; // uint16_t
}

public static class TimedEvent
{
    public const int m_TimeBetweenEvents = 0x0; // float
    public const int m_fNextEvent = 0x4; // float
}

public static class VPhysicsCollisionAttribute_t
{
    public const int m_interactsAs = 0x8; // uint64_t
    public const int m_interactsWith = 0x10; // uint64_t
    public const int m_interactsExclude = 0x18; // uint64_t
    public const int m_nEntityId = 0x20; // uint32_t
    public const int m_nOwnerId = 0x24; // uint32_t
    public const int m_nHierarchyId = 0x28; // uint16_t
    public const int m_nCollisionGroup = 0x2A; // uint8_t
    public const int m_nCollisionFunctionMask = 0x2B; // uint8_t
}

public static class ViewAngleServerChange_t
{
    public const int nType = 0x30; // FixAngleSet_t
    public const int qAngle = 0x34; // QAngle
    public const int nIndex = 0x40; // uint32_t
}

public static class WeaponPurchaseCount_t
{
    public const int m_nItemDefIndex = 0x30; // uint16_t
    public const int m_nCount = 0x32; // uint16_t
}

public static class WeaponPurchaseTracker_t
{
    public const int m_weaponPurchases = 0x8; // C_UtlVectorEmbeddedNetworkVar<WeaponPurchaseCount_t>
}

public static class audioparams_t
{
    public const int localSound = 0x8; // Vector[8]
    public const int soundscapeIndex = 0x68; // int32_t
    public const int localBits = 0x6C; // uint8_t
    public const int soundscapeEntityListIndex = 0x70; // int32_t
    public const int soundEventHash = 0x74; // uint32_t
}

public static class fogparams_t
{
    public const int dirPrimary = 0x8; // Vector
    public const int colorPrimary = 0x14; // Color
    public const int colorSecondary = 0x18; // Color
    public const int colorPrimaryLerpTo = 0x1C; // Color
    public const int colorSecondaryLerpTo = 0x20; // Color
    public const int start = 0x24; // float
    public const int end = 0x28; // float
    public const int farz = 0x2C; // float
    public const int maxdensity = 0x30; // float
    public const int exponent = 0x34; // float
    public const int HDRColorScale = 0x38; // float
    public const int skyboxFogFactor = 0x3C; // float
    public const int skyboxFogFactorLerpTo = 0x40; // float
    public const int startLerpTo = 0x44; // float
    public const int endLerpTo = 0x48; // float
    public const int maxdensityLerpTo = 0x4C; // float
    public const int lerptime = 0x50; // GameTime_t
    public const int duration = 0x54; // float
    public const int blendtobackground = 0x58; // float
    public const int scattering = 0x5C; // float
    public const int locallightscale = 0x60; // float
    public const int enable = 0x64; // bool
    public const int blend = 0x65; // bool
    public const int m_bNoReflectionFog = 0x66; // bool
    public const int m_bPadding = 0x67; // bool
}

public static class shard_model_desc_t
{
    public const int m_nModelID = 0x8; // int32_t
    public const int m_hMaterial = 0x10; // CStrongHandle<InfoForResourceTypeIMaterial2>
    public const int m_solid = 0x18; // ShardSolid_t
    public const int m_ShatterPanelMode = 0x19; // ShatterPanelMode
    public const int m_vecPanelSize = 0x1C; // Vector2D
    public const int m_vecStressPositionA = 0x24; // Vector2D
    public const int m_vecStressPositionB = 0x2C; // Vector2D
    public const int m_vecPanelVertices = 0x38; // C_NetworkUtlVectorBase<Vector2D>
    public const int m_flGlassHalfThickness = 0x50; // float
    public const int m_bHasParent = 0x54; // bool
    public const int m_bParentFrozen = 0x55; // bool
    public const int m_SurfacePropStringToken = 0x58; // CUtlStringToken
}

public static class sky3dparams_t
{
    public const int scale = 0x8; // int16_t
    public const int origin = 0xC; // Vector
    public const int bClip3DSkyBoxNearToWorldFar = 0x18; // bool
    public const int flClip3DSkyBoxNearToWorldFarOffset = 0x1C; // float
    public const int fog = 0x20; // fogparams_t
    public const int m_nWorldGroupID = 0x88; // WorldGroupId_t
}